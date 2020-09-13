Public Class frmBaseTables


    Private Sub GoodsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GoodsBindingSource.EndEdit()
        Me.GoodsTableAdapter.Update(Me.PardisDataSet.goods)

    End Sub

    Private Sub frmBaseTables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PardisDataSet.units' table. You can move, or remove it, as needed.
        Me.UnitsTableAdapter.Fill(Me.PardisDataSet.units)
        'TODO: This line of code loads data into the 'PardisDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PardisDataSet.Suppliers)

        Me.CustomerTableAdapter.Fill(Me.PardisDataSet.customer)
        Me.GoodsTableAdapter.Fill(Me.PardisDataSet.goods)

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.CustomerTableAdapter.Update(Me.PardisDataSet.customer)
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.SuppliersTableAdapter.Update(Me.PardisDataSet.Suppliers)
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        Me.Validate()
        Me.UnitsBindingSource.EndEdit()
        Me.UnitsTableAdapter.Update(Me.PardisDataSet.units)
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.GoodsTableAdapter.FillBy(Me.PardisDataSet.goods)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class