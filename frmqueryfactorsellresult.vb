Imports System.Data.OleDb

Public Class frmqueryfactorsellresult
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
    Friend WithEvents datagridefactor As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.datagridefactor = New System.Windows.Forms.DataGrid
        CType(Me.datagridefactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridefactor
        '
        Me.datagridefactor.DataMember = ""
        Me.datagridefactor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridefactor.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridefactor.Location = New System.Drawing.Point(0, 0)
        Me.datagridefactor.Name = "datagridefactor"
        Me.datagridefactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datagridefactor.Size = New System.Drawing.Size(560, 427)
        Me.datagridefactor.TabIndex = 0
        '
        'frmqueryfactorsellresult
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(560, 427)
        Me.Controls.Add(Me.datagridefactor)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frmqueryfactorsellresult"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نتيجه جستجو"
        CType(Me.datagridefactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mydataset As New DataSet

    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)

        OleDbConn.Open()


        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "searchresult")

        Me.datagridefactor.DataSource = mydataset.Tables(0)

        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With datagridefactor
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "فاکتور فروش"
            .Font = New Font("Tahoma", 8.0!)
            .ParentRowsBackColor = Color.Lavender
            .ParentRowsForeColor = Color.MidnightBlue
        End With
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.Lavender
            .BackColor = Color.GhostWhite
            .ForeColor = Color.MidnightBlue
            .GridLineColor = Color.RoyalBlue
            .HeaderBackColor = Color.MidnightBlue
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.Lavender
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
            .MappingName = mydataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "تاريخ"
            .MappingName = "dob"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "فاکتور"
            .MappingName = "factor"
            .Alignment = HorizontalAlignment.Center
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "کد خریدار"
            .MappingName = "code_c"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "نام خریدار"
            .MappingName = "customer.name"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "کد کالا"
            .MappingName = "code_g"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "نام کالا"
            .MappingName = "goods.name"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "في خريد"
            .MappingName = "buyprice"
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "في فروش"
            .MappingName = "sellprice"
            .Alignment = HorizontalAlignment.Center
            '.Width = 75
            '.ReadOnly = True
        End With

        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "تعداد"
            .MappingName = "num"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "قيمت کل"
            .MappingName = "sumprice"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8 _
            , grdColStyle9, grdColStyle10})

        datagridefactor.TableStyles.Add(grdTableStyle1)
    End Function

    Private Sub datagridefactor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagridefactor.Click
        '  Try
        Dim SqlStr As String
        Dim frm As New frmupdelfactorsell

        SqlStr = "SELECT sell.code_g, goods.name, sell.buyprice, sell.sellprice, sell.num, sell.sumprice, sell.discount, sell.dob, sell.factor, sell.code_c, customer.name" & _
                 " FROM customer INNER JOIN (goods INNER JOIN sell ON goods.code_g = sell.code_g) ON customer.code_c = sell.code_c where sell.factor = " & datagridefactor.Item(datagridefactor.CurrentRowIndex, 1)
        ' & " and code = " & datagridefactor.Item(datagridefactor.CurrentRowIndex, 3)
        frm.filllst(SqlStr)
        codeCustomer = CInt(datagridefactor.Item(datagridefactor.CurrentRowIndex, 2))
        frm.MdiParent = frmmain
        frm.Show()
        Me.Close()
        'Catch err As System.Exception
        '    '  MessageBox.Show("لطفا بر روی ردیف خالی از اطلاعات کلیک نکنید")
        '    MessageBox.Show(err.Message)
        'End Try

    End Sub

    Private Sub frmqueryfactorsellresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub datagridefactor_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles datagridefactor.Navigate

    End Sub
End Class
