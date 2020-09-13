Public Class frmrptDelivery_personal

    Dim code As Integer = 0

    Property property_0() As Integer
        Get
            property_0 = Code
        End Get
        Set(ByVal value As Integer)
            Code = value
        End Set
    End Property


    Private Sub frmrptDelivery_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim rpt As New rptDelivery_personal
        'Dim x() As Integer = {1, 2, 3, 4}
        'Dim pvCollection As New CrystalDecisions.Shared.ParameterValues()
        'Dim pdvpriceName As New CrystalDecisions.Shared.ParameterDiscreteValue()
        'pdvpriceName.Value = x(0)
        'pvCollection.Add(pdvpriceName)


        rpt.RecordSelectionFormula = "{cust_transactions.CustomerID} = " & property_0()

        crv.ReportSource = rpt

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

    Private Sub crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load

    End Sub
End Class