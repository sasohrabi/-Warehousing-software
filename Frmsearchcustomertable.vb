Public Class Frmsearchcustomertable


    Private Function makequery(ByRef strquery As String)

        Dim strsearch As String

        If rb1.Checked And txtcode.Text.Trim <> "" Then
            strquery += " WHERE code_c = "
            strquery += txtcode.Text
        ElseIf rb2.Checked And txtname.Text.Trim <> "" Then
            strquery += " WHERE name like '"
            strquery += txtname.Text & "%'"
        ElseIf rb3.Checked And txtaddress.Text.Trim <> "" Then
            strquery += " WHERE address like '"
            strquery += txtaddress.Text & "%'"

        Else
            strquery = ""
        End If

    End Function

    Private Sub Frmsearchcustomertable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        Dim frm As New frmresult3
        Dim strquery As String = "select * from customer"
        makequery(strquery)

        frm.MdiParent = frmmain
        frm.FillDataGrid(strquery)
        frm.FillTextBox(strquery)
        frm.Show()
        Me.Close()
    End Sub

    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        txtcode.Enabled = True
        txtcode.Focus()
    End Sub

    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged
        txtname.Enabled = True
        txtname.Focus()
    End Sub

    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        txtaddress.Enabled = True
        txtaddress.Focus()
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Cboname.SelectedValue = 0
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub txtcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Cboname.SelectedValue = 0

            cmdsearch.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Cboname.SelectedValue = 0
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click

    End Sub
End Class