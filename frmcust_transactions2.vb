Imports System.Data.OleDb

Public Class frmcust_transactions2

    Private Sub cmddate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddate.Click
        mskdate.Text = shamsi.Tarikh
        mskdate.Focus()
    End Sub

    Private Sub txtnotes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotes.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub mskdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskdate.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub mskdebtor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskcreditor.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd_save.Focus()
        End If
    End Sub

    Private Sub cmdsave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub frmcust_transactions2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnotes.TabIndex = 0
        txtnotes.Focus()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If Me.txtCustomerID.Text <> "" And Me.txtcustomername.Text <> "" And Me.txtnotes.Text <> "" And Me.mskdebtor.Text <> "" And Me.mskcreditor.Text <> "" And Len(mskdate.Text) = 10 Then
            Try
                Dim oledbcon As New OleDbConnection(strcon)
                oledbcon.Open()
                Dim olecommand As New OleDbCommand
                olecommand.Connection = oledbcon
                If CInt(mskdebtor.Text) <> 0 Then
                    olecommand.CommandText = "Insert Into cust_transactions " _
                        & "(CustomerID,notes,[date],debtor,creditor) " _
                        & "Values (" _
                        & "'" & txtCustomerID.Text & "' , " _
                        & "'" & txtnotes.Text & "' , " _
                        & "'" & mskdate.Text & "' , " _
                        & "'" & mskdebtor.Text & "' , " _
                        & "'" & 0 & "')"

                    olecommand.ExecuteNonQuery()
                End If
                If CInt(mskcreditor.Text) <> 0 Then
                    olecommand.CommandText = "Insert Into cust_transactions " _
                        & "(CustomerID,notes,[date],debtor,creditor) " _
                        & "Values (" _
                        & "'" & txtCustomerID.Text & "' , " _
                        & "'" & txtnotes.Text & "' , " _
                        & "'" & mskdate.Text & "' , " _
                        & "'" & 0 & "' , " _
                        & "'" & mskcreditor.Text & "')"

                    olecommand.ExecuteNonQuery()
                End If

                oledbcon.Close()
                oledbcon.Dispose()

                cmdclean.PerformClick()
                MsgBox("اطلاعات با موفقیت ثبت شد", MsgBoxStyle.Information, "توجه")
                Me.Close()

            Catch ex As Exception
                MsgBox("مشکلی در ثبت اطلاعات پیش آمده است" & vbCrLf & ex.Message)
            End Try

        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If

    End Sub

    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        Me.txtnotes.Clear()
        Me.mskdate.Clear()
        Me.mskcreditor.Clear()
        Me.mskdebtor.Clear()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class