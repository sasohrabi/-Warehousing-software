Partial Class pardisDataSet
    Partial Class sellDataTable

        Private Sub sellDataTable_sellRowChanging(ByVal sender As System.Object, ByVal e As sellRowChangeEvent) Handles Me.sellRowChanging

        End Sub

    End Class

    Partial Class goodsDataTable

        Private Sub goodsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
