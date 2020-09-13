Public Class frmrptsell
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
        Me.crv.Size = New System.Drawing.Size(736, 491)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'frmrptsell
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 491)
        Me.Controls.Add(Me.crv)
        Me.Name = "frmrptsell"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ç«Å ›«ò Ê— ›—Ê‘"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load
        'Dim rpt As New rptsellfactor
        'Dim pvCollection As New CrystalDecisions.Shared.ParameterValues()
        'Dim pdvpriceName As New CrystalDecisions.Shared.ParameterDiscreteValue()
        '' Set the discreet value to the customers name.
        'pdvpriceName.Value = strpublicinttostr

        '' Add it to the parameter collection.
        'pvCollection.Add(pdvpriceName)
        'rpt.DataDefinition.ParameterFields("strtotalgrandprice").ApplyCurrentValues(pvCollection)

        'crv.ReportSource = rpt


    End Sub

    Private Sub frmrptsell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
