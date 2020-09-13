Imports System.Data.OleDb
Imports System.String
Imports vb = Microsoft.VisualBasic

Public Class frmrpt4form

    Private Function clear()
        txtfarvardin.Text = "0"
        txtordibehesht.Text = "0"
        txtkhordad.Text = "0"
        txttir.Text = "0"
        txtmordad.Text = "0"
        txtshahrivar.Text = "0"
        txtmehr.Text = "0"
        txtaban.Text = "0"
        txtazar.Text = "0"
        txtdey.Text = "0"
        txtbahman.Text = "0"
        txtesfand.Text = "0"

        txttotal.Text = "0"

    End Function

    Private Sub frmrpt4form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Try
            'Dim OleDbConn2 As OleDbConnection = New OleDbConnection(strcon)
            'Dim MyOledbCommand2 As OleDbCommand = New OleDbCommand
            'MyOledbCommand2.Connection = OleDbConn2
            'MyOledbCommand2.CommandText = "DELETE * FROM tempsumprice"

            'OleDbConn2.Open()
            'MyOledbCommand2.ExecuteNonQuery()
            'OleDbConn2.Close()

            clear()

            Dim i As Integer = 0
            Dim strdate1 As String = vb.Left(msk1.Text, 4)
            ' Dim strdate2 As String = vb.Left(msk2.CtlText, 4)



            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
            Dim MyOledbCommand As OleDbCommand = New OleDbCommand
            MyOledbCommand.Connection = OleDbConn


            For i = 1 To 12
                Select Case i
                    Case 1 To 6
                        MyOledbCommand.CommandText = "" & _
                        "SELECT SUM(sumprice) " & _
                       " FROM sell WHERE dob Between  '" & strdate1 & "/" & 0 & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & 0 & i & "/" & 31 & "'"

                        OleDbConn.Open()
                        If i = 1 Then
                            txtfarvardin.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 2 Then
                            txtordibehesht.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 3 Then
                            txtkhordad.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 4 Then
                            txttir.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 5 Then
                            txtmordad.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 6 Then
                            txtshahrivar.Text = MyOledbCommand.ExecuteScalar
                        End If

                        OleDbConn.Close()
                    Case 7 To 9
                        MyOledbCommand.CommandText = "" & _
                        "SELECT SUM(sumprice) " & _
                        " FROM sell WHERE dob Between  '" & strdate1 & "/" & 0 & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & 0 & i & "/" & 30 & "'"

                        OleDbConn.Open()
                        If i = 7 Then
                            txtmehr.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 8 Then
                            txtaban.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 9 Then
                            txtazar.Text = MyOledbCommand.ExecuteScalar
                        End If

                        OleDbConn.Close()
                    Case 10, 11
                        MyOledbCommand.CommandText = "" & _
                        "SELECT sum(sumprice) " & _
                        " FROM sell WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 30 & "'"

                        OleDbConn.Open()
                        If i = 10 Then
                            txtdey.Text = MyOledbCommand.ExecuteScalar
                        ElseIf i = 11 Then
                            txtbahman.Text = MyOledbCommand.ExecuteScalar
                        End If
                        OleDbConn.Close()
                    Case 12
                        If chk1.Checked Then
                            MyOledbCommand.CommandText = "" & _
                              "SELECT sum(sumprice) " & _
                              " FROM sell WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 29 & "'"

                            OleDbConn.Open()
                            If i = 12 Then
                                txtesfand.Text = MyOledbCommand.ExecuteScalar
                                OleDbConn.Close()
                            End If
                        Else
                            MyOledbCommand.CommandText = "" & _
                                                          "SELECT sum(sumprice) " & _
                                                          " FROM sell WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 30 & "'"

                            OleDbConn.Open()
                            If i = 12 Then
                                txtesfand.Text = MyOledbCommand.ExecuteScalar
                                OleDbConn.Close()
                            End If
                            OleDbConn.Close()


                        End If

                End Select
            Next

            'MyOledbCommand.CommandText = "" & _
            '                  "SELECT sum(sumprice) " & _
            '                  " FROM sell WHERE dob Between  '" & strdate1 & "/" & 1 & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & 12 & "/" & 30 & "'"
            'OleDbConn.Open()
            'txttotal.Text = MyOledbCommand.ExecuteScalar
            'OleDbConn.Close()

        Catch err As System.Exception

            MessageBox.Show(err.Message)

            Dim ctrl As Control
            For Each ctrl In Me.Controls
                If (TypeOf ctrl Is TextBox) Then
                    ctrl.Text = "0"
                End If

            Next
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim total As Double = CInt(txtfarvardin.Text) + CInt(txtordibehesht.Text) + CInt(txtkhordad.Text) + CInt(txttir.Text) + CInt(txtmordad.Text) + CInt(txtshahrivar.Text) + CInt(txtmehr.Text) + CInt(txtaban.Text) + CInt(txtazar.Text) + CInt(txtdey.Text) + CInt(txtbahman.Text) + CInt(txtesfand.Text)
        txttotal.Text = Convert.ToInt64(txtfarvardin.Text) + Convert.ToInt64(txtordibehesht.Text) + Convert.ToInt64(txtkhordad.Text) + Convert.ToInt64(txttir.Text) + Convert.ToInt64(txtmordad.Text) + Convert.ToInt64(txtshahrivar.Text) + Convert.ToInt64(txtmehr.Text) + Convert.ToInt64(txtaban.Text) + Convert.ToInt64(txtazar.Text) + Convert.ToInt64(txtdey.Text) + Convert.ToInt64(txtbahman.Text) + Convert.ToInt64(txtesfand.Text)
    End Sub
End Class