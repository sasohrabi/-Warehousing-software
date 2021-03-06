Imports System.String
Imports System.Data.OleDb

Public Class frmupdatedeletecustomer


    Dim mydataset As New DataSet
    Dim counter As Integer = 1

    Private Function clear()
        txtsearch.Text = ""
        txtcode.Text = ""
        txtname.Text = ""
        txttel_office.Text = ""
        txttel_mobile.text = ""
        txtclerk.Text = ""
        txtaddress.Text = ""
        txtsiba.Text = ""
    End Function

    Private Function makequery(ByRef strquery As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strsearch As String
        Dim bsearchstrempty As Boolean

        bsearchstrempty = False
        If txtsearch.Text.Trim = "" Then
            MessageBox.Show("لطفا ابتدا متن را وارد کنيد")
            bsearchstrempty = True
        End If
        strsearch = cbosearchby.Text
        If (Not bsearchstrempty) Then
            If (Compare(strsearch, "کد", True) = 0) Then
                strquery += " WHERE code_c= "
                strquery += txtsearch.Text
            ElseIf (Compare(strsearch, "نام", True) = 0) Then
                strquery += " WHERE name = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "تلفن", True) = 0) Then
                strquery += " WHERE tel_office = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "موبایل", True) = 0) Then
                strquery += " WHERE tel_mobile = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "منشي", True) = 0) Then
                strquery += " WHERE clerk like '"
                strquery += txtsearch.Text & "%'"
            ElseIf (Compare(strsearch, "آدرس", True) = 0) Then
                strquery += " WHERE address like '"
                strquery += txtsearch.Text & "%'"

            End If
        Else
            strquery = ""
        End If

    End Function

    Public Function FillTextBox(ByVal Sqlstring As String)
        Try
            clear()

            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            OleDbCon.Open()

            Dim MyDataReader As OleDbDataReader

            Dim OleCommand As OleDbCommand = New OleDbCommand
            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = Sqlstring

            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                txtcode.Text = (MyDataReader.Item(0).ToString)
                txtname.Text = (MyDataReader.Item(1).ToString)
                txttel_office.Text = (MyDataReader.Item(2).ToString)
                txttel_mobile.Text = (MyDataReader.Item(3).ToString)
                txtclerk.Text = (MyDataReader.Item(4).ToString)
                txtaddress.Text = (MyDataReader.Item(5).ToString)
                txtsiba.Text = (MyDataReader.Item(6).ToString)
                cbotype_v.Text = (MyDataReader.Item(7).ToString)
            Loop
            MyDataReader.Close()

        Catch e1 As Exception

            MsgBox("فیلد خالی در اطلاعات مربوط به رکورد جاری وجود دارد")

        End Try

        If (txtcode.Text = "") Then
            txtcode.Focus()
        End If

        txtcode.Enabled = False

    End Function

    'Public Function FillListview(ByVal Sqlstring As String)

    '   lvwsearchresult.Items.Clear()
    '  Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
    ' Dim MyDataReader As OleDbDataReader
    '  Dim MyOleDbCommand As OleDbCommand = New OleDbCommand
    ' Dim MyDataSet As DataSet = New DataSet
    '      Dim MyOleDataAdapter As OleDbDataAdapter = New OleDbDataAdapter



    '     OleDbConn.Open()
    '    MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
    '   MyOleDataAdapter.Fill(MyDataSet)
    '  MyOleDbCommand.Connection = (OleDbConn)

    '      MyOleDbCommand.CommandText = Sqlstring
    '
    '       MyDataReader = MyOleDbCommand.ExecuteReader
    '
    '       ProgressBar1.Minimum = 0
    '    ProgressBar1.Maximum = MyDataSet.Tables(0).Rows.Count
    '
    '
    '       Do While MyDataReader.Read
    '
    '         Dim strsearch As String() = {MyDataReader(4), MyDataReader(3), MyDataReader(2), _
    '      MyDataReader(1), MyDataReader(0)}
    '          lvwsearchresult.Items.Add(New ListViewItem(strsearch))
    '         ProgressBar1.Value = ProgressBar1.Value + 1
    '
    '       Loop
    '
    '
    '      MyDataReader.Close()
    '       OleDbConn.Close()
    '      OleDbConn.Dispose()
    '

    '   End Function
    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)
        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "customer")


        Me.DataGrid1.DataSource = (mydataset.Tables(0))




        Me.Text = " " & mydataset.Tables(0).Rows.Count & " Rows."
        'Analyze_position()
        If counter = 2 Then
            FormatGridWithTableStyles()
        End If
        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With DataGrid1
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "نتيجه جستجو:"
            .Font = New Font("Tahoma", 8.0!)
            .ParentRowsBackColor = Color.Lavender
            .ParentRowsForeColor = Color.MidnightBlue
        End With
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.Lavender
            .BackColor = Color.GhostWhite
            .ForeColor = Color.MidnightBlue
            .GridLineColor = Color.RoyalBlue
            .HeaderBackColor = Color.MidnightBlue
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.Lavender
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
            .MappingName = mydataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد"
            .MappingName = "code_c"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام مشتری"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Center
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "تلفن"
            .MappingName = "tel_office"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "موبایل"
            .MappingName = "tel_mobile"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "منشي"
            .MappingName = "clerk"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "آدرس"
            .MappingName = "address"
            '.Width = 50
        End With
        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "شماره حساب سیبا"
            .MappingName = "siba"
            '.Width = 50
        End With
        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "نوع"
            .MappingName = "type_v"
            '.Width = 50
        End With



        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        DataGrid1.TableStyles.Add(grdTableStyle1)

    End Function

    Private Sub frmupdatedeletecustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click

        counter += 1
        Dim strquery As String = "select * from customer"
        makequery(strquery)
        FillTextBox(strquery)
        'FillListview(strquery)
        FillDataGrid(strquery)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" Then
            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()

                Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                MyOledbCommand.CommandText = "Update customer Set " _
                & "name='" & txtname.Text.ToString & "', " _
                & "tel_office='" & txttel_office.Text.ToString & "', " _
                & "tel_mobile='" & txttel_mobile.Text.ToString & "', " _
                & "clerk='" & txtclerk.Text.ToString & "', " _
                & "address='" & txtaddress.Text.ToString & "', " _
                & "siba='" & txtsiba.Text.ToString & "', " _
                & "type_v='" & cbotype_v.Text.ToString & "' " _
                & "WHERE code_c = " & txtcode.Text


                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()

            Catch ex As Exception
                MessageBox.Show("مشکلی در ثبت تغییرات رکورد جاری پیش آمده است" & vbCrLf & ex.Message)
                Exit Sub
            End Try

            MsgBox("اطلاعات به درستی ذخیره شد")
            counter += 1
            Dim strquery As String = "select * from customer where code_c = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            FillDataGrid(strquery)
        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim string1 As Integer = txtcode.Text
            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
            OleDbConn.Open()


            Dim MyOledbCommand As OleDbCommand = New OleDbCommand


            MyOledbCommand.CommandText = "DELETE FROM customer WHERE code_c=" & string1

            MyOledbCommand.Connection = OleDbConn

            MyOledbCommand.ExecuteNonQuery()
            OleDbConn.Close()

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim SqlStr As String

        SqlStr = "SELECT * FROM customer where code_c = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        FillTextBox(SqlStr)
    End Sub

    Private Sub txtsearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub cbosearchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosearchby.SelectedIndexChanged
        txtsearch.Focus()
    End Sub
End Class