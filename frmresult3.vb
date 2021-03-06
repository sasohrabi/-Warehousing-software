Imports System.Data.OleDb

Public Class frmresult3

    Dim myDataset As New DataSet
    'Dim Nextb As Long
    'Dim PrevB As Long
    'Dim TotalC As Long

    Public Function FillTextBox(ByVal Sqlstring As String)

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = Sqlstring
        Try
            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read


                txtcode.Text = (MyDataReader.Item(0).ToString)
                txtname.Text = (MyDataReader.Item(1).ToString)
                txttel_office.Text = (MyDataReader.Item(2).ToString)
                txttel_mobile.Text = (MyDataReader.Item(3).ToString)
                txtclerk.Text = (MyDataReader.Item(4).ToString)
                txtaddress.Text = (MyDataReader.Item(5).ToString)
                txtsiba.Text = (MyDataReader.Item(6).ToString)
                txttype_v.Text = (MyDataReader.Item(7).ToString)
            Loop
        Catch err As System.Exception

            MyDataReader.Close()


            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

    End Function
    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)
        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        myDataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(myDataset, "searchresult3")


        Me.DataGride2.DataSource = myDataset.Tables(0)
        cng1.DataSource = Me.BindingContext(myDataset.Tables(0))

        txtcode.DataBindings.Add("text", myDataset.Tables(0), "code_c")
        txtname.DataBindings.Add("text", myDataset.Tables(0), "name")
        txttel_office.DataBindings.Add("text", myDataset.Tables(0), "tel_office")
        txttel_mobile.DataBindings.Add("text", myDataset.Tables(0), "tel_mobile")
        txtclerk.DataBindings.Add("text", myDataset.Tables(0), "clerk")
        txtaddress.DataBindings.Add("text", myDataset.Tables(0), "address")
        txtsiba.DataBindings.Add("text", myDataset.Tables(0), "siba")
        txttype_v.DataBindings.Add("text", myDataset.Tables(0), "type_v")

        'Analyze_position()
        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        myDataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With DataGride2
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.FixedSingle
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "اطلاعات مشتریان"
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
            .MappingName = myDataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد مشتری"
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
            .HeaderText = "تلفن مشتری"
            .MappingName = "tel_office"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "موبایل مشتری"
            .MappingName = "tel_mobile"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "منشي مشتری"
            .MappingName = "clerk"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "آدرس مشتری"
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
            .HeaderText = "نوع مشتری"
            .MappingName = "type_v"
            '.Width = 50
        End With



        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        DataGride2.TableStyles.Add(grdTableStyle1)

    End Function

    Private Sub frmresult3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGride2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGride2.Click
        Dim SqlStr As String

        SqlStr = "select * from customer where code_c = " & DataGride2.Item(DataGride2.CurrentRowIndex, 0)
        FillTextBox(SqlStr)
    End Sub
End Class