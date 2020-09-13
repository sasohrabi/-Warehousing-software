Public Class frmrptSuppliers_personal

    Dim code As Integer = 0

    Property property_0() As Integer
        Get
            property_0 = Code
        End Get
        Set(ByVal value As Integer)
            Code = value
        End Set
    End Property

    Private Sub frmrptSuppliers_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New rptSuppliers_personal
        'Dim x() As Integer = {1, 2, 3, 4}
        'Dim pvCollection As New CrystalDecisions.Shared.ParameterValues()
        'Dim pdvpriceName As New CrystalDecisions.Shared.ParameterDiscreteValue()
        'pdvpriceName.Value = x(0)
        'pvCollection.Add(pdvpriceName)


        rpt.RecordSelectionFormula = "{supp_transactions.SupplierID} = " & property_0()

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
End Class