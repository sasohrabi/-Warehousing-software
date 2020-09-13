Imports System.Data.OleDb

Public Class frmaddcustomer

    Dim SaveOrCancel As String = ""
    Private Function clear()
        Me.txtname.Clear()
        Me.txttel_office.Clear()
        Me.txttel_mobile.Clear()
        Me.txtclerk.Clear()
        Me.txtaddress.Clear()
        Me.txtsiba.Clear()
        Me.cbotype_v.Text = ""

    End Function

    Private Function checkkey(ByVal strCustomername As String) As Boolean
        Dim count As Integer = 0
        Dim bool As Boolean = False
        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim oledbcommand As New OleDbCommand

        oledbcommand.CommandText = "select count(*) from customer where name = '" & strCustomername & "'"
        oledbcommand.Connection = oledbcon

        count = oledbcommand.ExecuteScalar

        oledbcon.Close()
        oledbcon.Dispose()
        If count = 0 Then
            bool = True
        Else
            bool = False
        End If

        Return bool

    End Function

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub txttel_office_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_office.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub txttel_mobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_mobile.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtclerk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclerk.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtsiba_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsiba.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub cbotype_v_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotype_v.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdsave.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SaveOrCancel = "Save"
        Dim codenumber As Integer = 0
        Dim datareader As OleDbDataReader

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(code_c) FROM customer"

        datareader = OleCommand.ExecuteReader
        Do While datareader.Read
            If datareader.IsDBNull(0) Then
                codenumber = 101
                txtcode.Text = codenumber
            Else
                codenumber = datareader.Item(0)
                codenumber += 2
                txtcode.Text = codenumber
            End If
        Loop
        OleDbCon.Close()
        OleDbCon.Dispose()
        txtname.Focus()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        If SaveOrCancel = "Save" Then

            If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" Then
                If checkkey(Me.txtname.Text) = True Then
                    Try
                        Dim oledbcon As New OleDbConnection(strcon)
                        oledbcon.Open()
                        Dim olecommand As New OleDbCommand

                        olecommand.CommandText = "Insert Into customer " _
                            & "(code_c,name,tel_office,tel_mobile,clerk,address,siba,type_v) " _
                            & "Values (" _
                            & "'" & txtcode.Text & "' , " _
                            & "'" & txtname.Text & "' , " _
                            & "'" & txttel_office.Text & "' , " _
                            & "'" & txttel_mobile.Text & "' , " _
                            & "'" & txtclerk.Text & "' , " _
                            & "'" & txtaddress.Text & "' , " _
                            & "'" & txtsiba.Text & "' , " _
                            & "'" & cbotype_v.Text & "')"

                        olecommand.Connection = oledbcon

                        olecommand.ExecuteNonQuery()
                        oledbcon.Close()
                        oledbcon.Dispose()
                        clear()
                    Catch
                        MessageBox.Show("مشکلی در ذخیره سازی رکورد جاری به وجود آمده است")
                    End Try
                Else
                    MessageBox.Show("این رکورد بااین نام مشتری قبلا ثبت شده است")
                End If
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If



        End If
        '  Me.Button1.PerformClick()

        Me.Button6.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrCancel = "cancel"
    End Sub

    Private Sub frmaddcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class