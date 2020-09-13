Imports System.Data.OleDb

Public Class frmaddProduce

    Dim CodeP As Integer = 0
    Dim flagComboName = 0

    Private Function fillcomboname()
        Dim myOleDbDataAdapter As OleDbDataAdapter
        Dim myDataTable As DataTable = New DataTable
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

        OleDbCon.Open()

        '  Try
        myOleDbDataAdapter = New OleDbDataAdapter("select code_g,name from goods order by name", _
            OleDbCon)

        myDataTable.Clear()

        myOleDbDataAdapter.Fill(myDataTable)
        Cbonameg.DataSource = myDataTable
        Cbonameg.ValueMember = "code_g"
        Cbonameg.DisplayMember = "name"

        'Catch
        '    MsgBox("Error Opening {0}", OleDbCon.DataSource)
        'End Try

        OleDbCon.Close()
        OleDbCon.Dispose()

        flagComboName = 1
    End Function
    Private Function cleartextboxes()
        txtaddress.Clear()
        txtclerk.Clear()
        txtname.Clear()
        txtsiba.Clear()
        txttel_mobile.Clear()
        txttel_office.Clear()
    End Function
    Private Function checkkey(ByVal strproducename As String, ByVal intgoodscode As Integer) As Boolean
        Dim count As Integer = 0
        Dim bool As Boolean = False
        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim oledbcommand As New OleDbCommand

        oledbcommand.CommandText = "select count(*) from produce where name = '" & txtname.Text & "' and code_g=" & intgoodscode
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

    Public Function filllst(ByVal strsql As String)


        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand

        '  strfilllst = strsql

        lvwfactor.Items.Clear()

        olecommand.CommandText = strsql
        olecommand.Connection = OleDbCon
        ' Try
        OleDbCon.Open()
        Dim datareader As OleDbDataReader
        datareader = olecommand.ExecuteReader

        While datareader.Read
            Dim lvi As New ListViewItem
            lvi.Text = CStr(datareader("name"))

            Cbonameg.SelectedValue = datareader("code_g")
            lvi.SubItems.Add(CStr(datareader("tel_office")))
            lvi.SubItems.Add(CStr(datareader("tel_mobile")))
            lvi.SubItems.Add(CStr(datareader("clerk")))
            lvi.SubItems.Add(CStr(datareader("address")))
            lvi.SubItems.Add(CStr(datareader("siba")))
            lvi.SubItems.Add(CStr(datareader("code_P")))



            lvwfactor.Items.Add(lvi)
            ' lvwfactor.Sorting().  = SortOrder.Ascending


        End While


        '  convertDISCOUNT()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'Finally
        '    OleDbCon.Close()
        'End Try
    End Function

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub frmaddProduce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flagComboName = 0
        fillcomboname()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" _
        And txttel_mobile.Text <> "" And txtsiba.Text <> "" And Cbonameg.Text <> "" Then
            If checkkey(Me.txtname.Text, Me.Cbonameg.SelectedValue) = True Then
                Try
                    Dim oledbcon As New OleDbConnection(strcon)
                    oledbcon.Open()
                    Dim olecommand As New OleDbCommand

                    olecommand.CommandText = "Insert Into produce " _
                        & "(code_g,name,tel_office,tel_mobile,clerk,address,siba) " _
                        & "Values (" _
                        & "'" & Cbonameg.SelectedValue & "' , " _
                        & "'" & txtname.Text & "' , " _
                        & "'" & txttel_office.Text & "' , " _
                        & "'" & txttel_mobile.Text & "' , " _
                        & "'" & txtclerk.Text & "' , " _
                        & "'" & txtaddress.Text & "' , " _
                        & "'" & txtsiba.Text & "')"


                    olecommand.Connection = oledbcon

                    olecommand.ExecuteNonQuery()
                    oledbcon.Close()
                    oledbcon.Dispose()

                    cleartextboxes()
                    filllst("select * from produce")
                    txtname.Focus()
                    MessageBox.Show("اطلاعات به درستی ثبت گردید")

                Catch
                    MessageBox.Show("مشکلی در ذخیره سازی رکورد جاری به وجود آمده است")
                End Try
            Else
                MessageBox.Show("این رکورد بااین نام کالا برای این شرکت قبلا ثبت شده است")
            End If
        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click

        If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" _
        And txttel_mobile.Text <> "" And txtsiba.Text <> "" And Cbonameg.Text <> "" Then
            '    If checkkey(Me.txtname.Text, Me.Cbonameg.SelectedValue) = True Then

            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()

                Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                MyOledbCommand.CommandText = "Update produce Set " _
                & "code_g='" & Cbonameg.SelectedValue & "', " _
                & "name='" & txtname.Text.ToString & "', " _
                & "tel_office='" & txttel_office.Text.ToString & "', " _
                & "tel_mobile='" & txttel_mobile.Text.ToString & "', " _
                & "clerk='" & txtclerk.Text.ToString & "', " _
                & "address='" & txtaddress.Text.ToString & "' " _
                & " WHERE code_P = " & CodeP


                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()

                filllst("select * from produce")
                MsgBox("اطلاعات به درستی ذخیره شد")

            Catch ex As Exception
                MessageBox.Show("مشکلی در ثبت تغییرات رکورد جاری پیش آمده است" & vbCrLf & ex.Message)
                Exit Sub
            End Try

            'Else
            '    MessageBox.Show("این رکورد بااین نام کالا برای این شرکت قبلا ثبت شده است")
            'End If

        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If

    End Sub



    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Try
            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
            OleDbConn.Open()


            Dim MyOledbCommand As OleDbCommand = New OleDbCommand


            MyOledbCommand.CommandText = "DELETE FROM produce WHERE code_P=" & CodeP

            MyOledbCommand.Connection = OleDbConn

            MyOledbCommand.ExecuteNonQuery()
            OleDbConn.Close()

            filllst("select * from produce")

            MsgBox("اطلاعات انتخابی به درستی حذف گردید")

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txttel_office.Focus()
        End If
    End Sub

    Private Sub txttel_office_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_office.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txttel_mobile.Focus()
        End If
    End Sub

    Private Sub txttel_mobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_mobile.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtclerk.Focus()
        End If
    End Sub

    Private Sub txtclerk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclerk.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtsiba.Focus()
        End If
    End Sub

    Private Sub txtsiba_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsiba.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            add.Focus()
        End If
    End Sub

    Private Sub Cbonameg_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbonameg.SelectedValueChanged
        If Cbonameg.Text <> "" And flagComboName <> 0 Then
            filllst("select * from produce where code_g=" & Cbonameg.SelectedValue)
            'MessageBox.Show("1")

            'txtsellprice.Focus()
        End If
    End Sub

    Private Sub lvwfactor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwfactor.SelectedIndexChanged

        Try
            Dim strname As String = lvwfactor.SelectedItems(0).SubItems(0).Text
            Dim strtel_office As String = lvwfactor.SelectedItems(0).SubItems(1).Text
            Dim strtel_mobile As String = lvwfactor.SelectedItems(0).SubItems(2).Text
            Dim strclerk As String = lvwfactor.SelectedItems(0).SubItems(3).Text
            Dim straddress As String = lvwfactor.SelectedItems(0).SubItems(4).Text
            Dim strsiba As String = lvwfactor.SelectedItems(0).SubItems(5).Text
            CodeP = lvwfactor.SelectedItems(0).SubItems(6).Text

            cleartextboxes()

            txtname.Text = strname
            txttel_office.Text = strtel_office
            txttel_mobile.Text = strtel_mobile
            txtclerk.Text = strclerk
            txtaddress.Text = straddress
            txtsiba.Text = strsiba

        Catch

        End Try
    End Sub
End Class