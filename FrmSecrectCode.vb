Public Class FrmSecrectCode

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If Me.TextBox1.Text.Length = 4 Then

            If Me.TextBox1.Text = 1003 Then
                Rename("D:\Pardis\pardis.mdb", "D:\pardis\filmfamily" & ".dat")
                MsgBox("تنظیمات به درستی انجام شد")
                Me.Close()
            ElseIf Me.TextBox1.Text = 1004 Then
                Rename("D:\pardis\filmfamily" & ".dat", "D:\Pardis\pardis.mdb")
                MsgBox("تنظیمات به درستی انجام شد")
                Me.Close()
            Else
                MessageBox.Show(" کد اشتباه وارد شده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub FrmSecrectCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class