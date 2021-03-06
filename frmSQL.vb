Imports System.Data.OleDb

Public Class frmSQL

    Dim mydataset As New DataSet

    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)

        OleDbConn.Open()


        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "searchresult")

        Me.datagrideRESULT.DataSource = mydataset.Tables(0)

        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function clear()
        Me.txtContextCodeD.Text = ""
        Me.txtCodeRUN.Text = ""
    End Function
    Private Function FormatGridWithTableStyles()
        With datagrideRESULT
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.MediumSeaGreen
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "نتیجه"
            .Font = New Font("Tahoma", 8.0!)
            .ParentRowsBackColor = Color.Lavender
            .ParentRowsForeColor = Color.Chocolate
        End With
        'Dim grdTableStyle1 As New DataGridTableStyle
        'With grdTableStyle1
        '    .AlternatingBackColor = Color.Lavender
        '    .BackColor = Color.GhostWhite
        '    .ForeColor = Color.MidnightBlue
        '    .GridLineColor = Color.RoyalBlue
        '    .HeaderBackColor = Color.MidnightBlue
        '    .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
        '    .HeaderForeColor = Color.Lavender
        '    .SelectionBackColor = Color.Teal
        '    .SelectionForeColor = Color.PaleGreen
        '    .MappingName = mydataset.Tables(0).TableName
        '    .PreferredColumnWidth = 80
        '    .PreferredRowHeight = 15
        'End With

        'Dim grdColStyle1 As New DataGridTextBoxColumn
        'With grdColStyle1
        '    .HeaderText = "تاريخ"
        '    .MappingName = "dob"
        '    '.Width = 50
        'End With

        'Dim grdColStyle2 As New DataGridTextBoxColumn
        'With grdColStyle2
        '    .HeaderText = "فاکتور"
        '    .MappingName = "factor"
        '    .Alignment = HorizontalAlignment.Center
        'End With
        ''
        'Dim grdColStyle3 As New DataGridTextBoxColumn
        'With grdColStyle3
        '    .HeaderText = "کد خریدار"
        '    .MappingName = "code_c"
        '    ' .Width = 75
        '    '   .ReadOnly = True
        'End With

        'Dim grdColStyle4 As New DataGridTextBoxColumn
        'With grdColStyle4
        '    .HeaderText = "نام خریدار"
        '    .MappingName = "customer.name"
        '    ' .Width = 75
        '    '   .ReadOnly = True
        'End With

        'Dim grdColStyle5 As New DataGridTextBoxColumn
        'With grdColStyle5
        '    .HeaderText = "کد کالا"
        '    .MappingName = "code_g"
        '    '.Width = 75
        '    .Alignment = HorizontalAlignment.Center
        'End With

        'Dim grdColStyle6 As New DataGridTextBoxColumn
        'With grdColStyle6
        '    .HeaderText = "نام کالا"
        '    .MappingName = "goods.name"
        '    '.Width = 75
        '    .Alignment = HorizontalAlignment.Center
        'End With

        'Dim grdColStyle7 As New DataGridTextBoxColumn
        'With grdColStyle7
        '    .HeaderText = "في خريد"
        '    .MappingName = "buyprice"
        '    .Alignment = HorizontalAlignment.Center
        'End With

        'Dim grdColStyle8 As New DataGridTextBoxColumn
        'With grdColStyle8
        '    .HeaderText = "في فروش"
        '    .MappingName = "sellprice"
        '    .Alignment = HorizontalAlignment.Center
        '    '.Width = 75
        '    '.ReadOnly = True
        'End With

        'Dim grdColStyle9 As New DataGridTextBoxColumn
        'With grdColStyle9
        '    .HeaderText = "تعداد"
        '    .MappingName = "num"
        '    .Width = 75
        '    .Alignment = HorizontalAlignment.Center
        'End With

        'Dim grdColStyle10 As New DataGridTextBoxColumn
        'With grdColStyle10
        '    .HeaderText = "قيمت کل"
        '    .MappingName = "sumprice"
        '    .Width = 75
        '    .Alignment = HorizontalAlignment.Center
        'End With

        '' Add the style objects to the table style's collection of 
        '' column styles. Without this the styles do not take effect.        
        'grdTableStyle1.GridColumnStyles.AddRange _
        '    (New DataGridColumnStyle() _
        '    {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
        '    , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8 _
        '    , grdColStyle9, grdColStyle10})

        'datagrideRESULT.TableStyles.Add(grdTableStyle1)
    End Function


    Private Sub frmSQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        Me.Close()

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        clear()

    End Sub

    Private Sub btnRUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSQLD.Click
        If Me.txtContextCodeD.Text <> "" Then
            Dim strquery As String = Me.txtContextCodeD.Text
            FillDataGrid(strquery)
        End If
    End Sub

    Private Sub btnCodeRUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodeRUN.Click
        If Me.txtCodeRUN.Text <> "" Then
            Dim strquery As String = Me.txtCodeRUN.Text
            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()


                Dim MyOledbCommand As OleDbCommand = New OleDbCommand


                MyOledbCommand.CommandText = strquery

                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()

                MsgBox("کد به درستی اجرا شد")

            Catch err As System.Exception
                MessageBox.Show(err.Message)
            End Try
        End If
    End Sub
End Class