Imports System.Data.OleDb
Public Class frmrptH


    Dim mydataset As New pardisDataSet

    Public Function print(ByVal intfactor As Integer)
        Try


            Dim rpt As New rptsellfactorH
            Dim str As String = ""
            '  Dim str As String = "SELECT sell.dob, sell.factor, sell.code_c, sell.code_g, sell.buyprice, sell.sellprice, sell.num, sell.sumprice,goods.code_g , goods.name  " _
            '& " FROM (sell INNER JOIN " _
            '& "  goods ON sell.code_g = goods.code_g) where sell.factor = 2"
            str = "select * from goods  where name <> null"
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

    Private Sub frmrptH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class