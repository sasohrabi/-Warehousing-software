Partial Class DataSet1sell
    Partial Class sellDataTable

        Private Sub sellDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.discountColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
