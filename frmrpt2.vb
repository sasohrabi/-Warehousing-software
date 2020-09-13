Imports System.Data.OleDb
Public Class rpt2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(744, 475)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'rpt2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 475)
        Me.Controls.Add(Me.crv)
        Me.Name = "rpt2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ç«Å ›«ò Ê— ›—Ê‘"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mydataset As New pardisDataSet

    Public Function print(ByVal intfactor As Integer)
        Try


            Dim rpt As New rptsellfactor
            Dim str As String = ""
            '  Dim str As String = "SELECT sell.dob, sell.factor, sell.code_c, sell.code_g, sell.buyprice, sell.sellprice, sell.num, sell.sumprice,goods.code_g , goods.name  " _
            '& " FROM (sell INNER JOIN " _
            '& "  goods ON sell.code_g = goods.code_g) where sell.factor = 2"
            str = "select code_g ,name ,unit from goods  where name <> null"
            Dim OleDbConn As New OleDbConnection(strcon)
            OleDbConn.Open()

            'Dim MyDataSet As New DataSet
            mydataset.Clear()

            Dim MyOleDataAdapter As New OleDbDataAdapter
            MyOleDataAdapter.SelectCommand = New OleDbCommand(str, OleDbConn)
            MyOleDataAdapter.Fill(mydataset, "goods")
            str = "select * from sell where factor= " & intfactor
            MyOleDataAdapter.SelectCommand = New OleDbCommand(str, OleDbConn)
            MyOleDataAdapter.Fill(mydataset, "sell")

            str = "select * from customer where name <> null"
            MyOleDataAdapter.SelectCommand = New OleDbCommand(str, OleDbConn)
            MyOleDataAdapter.Fill(mydataset, "customer")


            'Dim relation As DataRelation = _
            '  mydataset.Relations.Add("CustOrders", _
            '  mydataset.Tables("Customers").Columns("CustomerID"), _
            '  mydataset.Tables("Orders").Columns("CustomerID"))

            Dim pvCollection As New CrystalDecisions.Shared.ParameterValues()
            Dim pdvpriceName As New CrystalDecisions.Shared.ParameterDiscreteValue()

            ' Set the discreet value to the customers name.


            rpt.SetDataSource(mydataset)
            pdvpriceName.Value = strpublicinttostr

            pvCollection.Add(pdvpriceName)
            rpt.DataDefinition.ParameterFields("strtotalgrandprice").ApplyCurrentValues(pvCollection)
            crv.ReportSource = rpt

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Function


    Private Sub crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load




    End Sub

    Private Sub rpt2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
