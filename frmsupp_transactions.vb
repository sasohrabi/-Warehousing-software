Imports System.Data.OleDb

Public Class frmsupp_transactions

    Public Shared frmPeyment_refresh As frmPeyment
    Public Function set_frm_supplier(ByRef frm As Form)
        frmPeyment_refresh = frm
    End Function

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

    Private Sub mskdebtor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskdebtor.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdsave.Focus()
        End If
    End Sub

    Private Sub mskcreditor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskcreditor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmdsave.Focus()
        End If
    End Sub

    Private Sub cmdsave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub frmsupp_transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If debtor_or_creditor2 = True Then
            mskcreditor.Enabled = False
            mskcreditor.Text = 0
        Else
            mskdebtor.Enabled = False
            mskdebtor.Text = 0
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If add_or_up2 = True Then
            If txtSupplierID.Text <> "" And txtsuppliername.Text <> "" And Me.txtnotes.Text <> "" And Me.mskdebtor.Text <> "" And Me.mskcreditor.Text <> "" And Len(mskdate.Text) = 10 Then
                Try
                    Dim oledbcon As New OleDbConnection(strcon)
                    oledbcon.Open()
                    Dim olecommand As New OleDbCommand

                    olecommand.CommandText = "Insert Into supp_transactions " _
                        & "(SupplierID,notes,[date],debtor,creditor) " _
                        & "Values (" _
                        & "'" & txtSupplierID.Text & "' , " _
                        & "'" & txtnotes.Text & "' , " _
                        & "'" & mskdate.Text & "' , " _
                        & "'" & mskdebtor.Text & "' , " _
                        & "'" & mskcreditor.Text & "')"

                    olecommand.Connection = oledbcon

                    olecommand.ExecuteNonQuery()
                    oledbcon.Close()
                    oledbcon.Dispose()

                    If debtor_or_creditor2 = True Then
                        frmPeyment_refresh.filllst(0, "select key,notes,date,debtor from supp_transactions where SupplierID = " & frmPeyment_refresh.intcode_s & " and debtor <> 0 order by date", frmPeyment_refresh.ListView3)
                    ElseIf debtor_or_creditor2 = False Then
                        frmPeyment_refresh.filllst(1, "select key,notes,date,creditor from supp_transactions where SupplierID = " & frmPeyment_refresh.intcode_s & " and creditor <> 0 order by date", frmPeyment_refresh.ListView1)
                    End If

                Catch ex As Exception
                    MsgBox("مشکلی در ثبت اطلاعات پیش آمده است" & vbCrLf & ex.Message)
                End Try
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If

        Else
            If txtSupplierID.Text <> "" And txtsuppliername.Text <> "" And Me.txtnotes.Text <> "" And Me.mskdebtor.Text <> "" And Me.mskcreditor.Text <> "" And Len(mskdate.Text) = 10 Then
                Try
                    Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                    OleDbConn.Open()

                    Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                    MyOledbCommand.CommandText = "Update supp_transactions Set " _
                    & "SupplierID='" & txtSupplierID.Text & "', " _
                    & "notes='" & txtnotes.Text & "', " _
                    & "[date]='" & mskdate.Text & "', " _
                    & "debtor='" & mskdebtor.Text & "', " _
                    & "creditor='" & mskcreditor.Text & "' " _
                    & " WHERE key = " & intkey


                    MyOledbCommand.Connection = OleDbConn

                    MyOledbCommand.ExecuteNonQuery()
                    OleDbConn.Close()

                    If debtor_or_creditor2 = True Then
                        frmPeyment_refresh.filllst(0, "select key,notes,date,debtor from supp_transactions where SupplierID = " & frmPeyment_refresh.intcode_s & " and debtor <> 0 order by date", frmPeyment_refresh.ListView3)
                    ElseIf debtor_or_creditor2 = False Then
                        frmPeyment_refresh.filllst(1, "select key,notes,date,creditor from supp_transactions where SupplierID = " & frmPeyment_refresh.intcode_s & " and creditor <> 0 order by date", frmPeyment_refresh.ListView1)
                    End If

                    cmdclean.PerformClick()

                Catch ex As Exception
                    'MsgBox(ex.Message)
                    MsgBox("مشکلی در ثبت اطلاعات پیش آمده است" & vbCrLf & ex.Message)
                End Try

            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If

        End If
    End Sub

    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        Me.txtnotes.Clear()
        Me.mskdate.Clear()
        Me.mskdebtor.Clear()
        Me.mskcreditor.Clear()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

End Class