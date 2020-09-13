Public Class frmrptSuppliers_all

    Private Sub frmrptSuppliers_all_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New rptSuppliers_all
        crv.ReportSource = rpt
    End Sub
End Class