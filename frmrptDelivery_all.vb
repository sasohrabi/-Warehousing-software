Public Class frmrptDelivery_all

    Private Sub frmrptDelivery_all_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New rptDelivery_all
        crv.ReportSource = rpt
    End Sub

    Private Sub crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load

    End Sub
End Class