Imports System.Data.OleDb

Public Class frmPeyment

    Dim mydataset As New DataSet
    Public intcode_s As Integer = 0
    Public strname As String = ""
    Dim selectit As Boolean = False


    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)

        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "Suppliers")


        Me.datagridefactor.DataSource = mydataset.Tables(0)

        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With datagridefactor
            .BackColor = Color.OldLace
            .BackgroundColor = Color.Tan
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.SaddleBrown
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.OldLace
            .CaptionText = "برای انتخاب شخص مورد نظر برروی سطر آن دوبار کلیک کنید"
            .Font = New Font("Tahoma", 12.0!, FontStyle.Bold)
            .ParentRowsBackColor = Color.OldLace
            .ParentRowsForeColor = Color.DarkSlateGray
        End With
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.Lavender
            .BackColor = Color.OldLace
            .ForeColor = Color.DarkSlateGray
            .GridLineColor = Color.Tan
            .HeaderBackColor = Color.Wheat
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.SaddleBrown
            .SelectionBackColor = Color.SlateGray
            .SelectionForeColor = Color.White
            .MappingName = "Suppliers"
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد تهیه کننده"
            .MappingName = "code_s"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام تهیه کننده"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Center
            .Width = 200
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "شماره تلفن"
            .MappingName = "tel_office"
            .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "شماره موبایل"
            .MappingName = "tel_mobile"
            .Width = 95
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "منشی"
            .MappingName = "clerk"
            .Width = 50
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "آدرس"
            .MappingName = "address"
            .Alignment = HorizontalAlignment.Center
            .Width = 250
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "شماره حساب سیبا"
            .MappingName = "siba"
            .Alignment = HorizontalAlignment.Center
            '.Width = 75
            '.ReadOnly = True
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "نوع تهیه کننده"
            .MappingName = "type_v"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        datagridefactor.TableStyles.Add(grdTableStyle1)

    End Function
    Public Function filllst(ByVal op As Integer, ByVal strsql As String, ByRef lvw As ListView)
        Dim summoneydebtor As Long = 0
        Dim summoneycreditor As Long = 0
        Dim currBalance As Integer = 0
        '  Dim strsql As String = "select * from tempsell order by row desc"
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand
        lvw.Items.Clear()

        olecommand.CommandText = strsql
        olecommand.Connection = OleDbCon
        Try
            OleDbCon.Open()
            Dim datareader As OleDbDataReader
            datareader = olecommand.ExecuteReader
            If op = 0 Then
                While datareader.Read
                    Dim lvi As New ListViewItem
                    lvi.Text = CStr(datareader("key"))
                    lvi.SubItems.Add(CStr(datareader("notes")))
                    lvi.SubItems.Add(CStr(datareader("date")))
                    summoneydebtor += CInt(datareader("debtor"))
                    ToolStripTextBox1.Text = summoneydebtor
                    lvi.SubItems.Add(CStr(datareader("debtor")))

                    lvw.Items.Add(lvi)
                    'lvwfactor.Sorting = SortOrder.Ascending

                End While
            ElseIf op = 1 Then
                While datareader.Read
                    Dim lvi As New ListViewItem
                    lvi.Text = CStr(datareader("key"))
                    lvi.SubItems.Add(CStr(datareader("notes")))
                    lvi.SubItems.Add(CStr(datareader("date")))
                    summoneycreditor += CInt(datareader("creditor"))
                    ToolStripLabel4.Text = summoneycreditor
                    lvi.SubItems.Add(CStr(datareader("creditor")))
                    lvw.Items.Add(lvi)
                    'lvwfactor.Sorting = SortOrder.Ascending
                End While

            ElseIf op = 2 Then
                While datareader.Read
                    Dim lvi As New ListViewItem
                    lvi.Text = CStr(datareader("notes"))
                    lvi.SubItems.Add(CStr(datareader("date")))
                    summoneydebtor += CInt(datareader("debtor"))
                    summoneycreditor += CInt(datareader("creditor"))
                    ToolStripLabel7.Text = summoneydebtor
                    ToolStripLabel9.Text = summoneycreditor
                    lvi.SubItems.Add(CStr(datareader("debtor")))
                    lvi.SubItems.Add(CStr(datareader("creditor")))
                    currBalance = currBalance + datareader("creditor") - datareader("debtor")
                    ToolStripLabel11.Text = currBalance
                    lvi.SubItems.Add(CStr(currBalance))
                    lvw.Items.Add(lvi)
                End While
            ElseIf op = 4 Then
                While datareader.Read
                    Dim lvi As New ListViewItem
                    lvi.Text = CStr(datareader(0))
                    lvi.SubItems.Add(CStr(datareader(1)))
                    summoneydebtor += CInt(datareader(2))
                    summoneycreditor += CInt(datareader(3))
                    ToolStripLabel14.Text = summoneydebtor
                    ToolStripLabel16.Text = summoneycreditor
                    lvi.SubItems.Add(CStr(datareader(2)))
                    lvi.SubItems.Add(CStr(datareader(3)))
                    currBalance = datareader(3) - datareader(2)
                    lvi.SubItems.Add(CStr(currBalance))
                    lvw.Items.Add(lvi)
                End While
                ToolStripLabel18.Text = CDbl(ToolStripLabel16.Text) - CDbl(ToolStripLabel14.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            OleDbCon.Close()
        End Try
    End Function
    Private Function deleteitem(ByRef lvw As ListView, ByRef ToolStripTxt As ToolStripLabel)

        Dim summoney As Integer = CInt(ToolStripTxt.Text)
        Dim lvi As New ListViewItem
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand

        olecommand.Connection = OleDbCon

        For Each lvi In lvw.SelectedItems

            intkey = CInt(lvi.SubItems(0).Text)
            summoney -= CInt(lvi.SubItems(3).Text)

            olecommand.CommandText = "delete from supp_transactions where key=" & intkey
            Try
                OleDbCon.Open()
                olecommand.ExecuteNonQuery()
                lvw.Items.RemoveAt(lvi.Index)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDbCon.Close()
            End Try
        Next
        ToolStripTxt.Text = summoney
        intkey = 0

    End Function

    Private Sub frmPeyment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSQL As String = "select * from Suppliers"
        Me.txtsuppliername.Focus()
        Me.txtsuppliername.TabIndex = 0
        FillDataGrid(strSQL)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged
        selectit = True
    End Sub

    Private Sub اضافهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافهToolStripMenuItem.Click
        Dim frm As New frmsupp_transactions
        add_or_up2 = True
        frm.txtSupplierID.Text = intcode_s
        frm.txtsuppliername.Text = strname
        frm.set_frm_supplier(Me)
        frm.ShowDialog()
    End Sub

    Private Sub txsuppliername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsuppliername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtlocationname.Focus()
        End If
    End Sub

    Private Sub txsuppliername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsuppliername.TextChanged
        Const MESSAGEBOX_CAPTION As String = "جستجو"

        With mydataset.Tables("Suppliers")
            .DefaultView.RowFilter = "name like '%" & txtsuppliername.Text & "%'"

            If .DefaultView.Count = 0 Then

                MessageBox.Show("رکوردي با اين مشخصات وجود ندارد", _
                MESSAGEBOX_CAPTION, MessageBoxButtons.OK, _
                MessageBoxIcon.Information)

            End If
            datagridefactor.DataSource = .DefaultView

        End With
    End Sub

    Private Sub datagridefactor_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datagridefactor.DoubleClick
        Try
            debtor_or_creditor2 = True
            intcode_s = Me.datagridefactor.Item(datagridefactor.CurrentRowIndex, 0)
            strname = Me.datagridefactor.Item(datagridefactor.CurrentRowIndex, 1)
            Me.tb1.SelectedIndex = 1
            Me.tb2.SelectedIndex = 0
            ttlbl1.Text = strname & "      "
            ToolStripLabel2.Text = strname & "      "
            ToolStripLabel5.Text = strname & "      "
            filllst(0, "select key,notes,date,debtor from supp_transactions where SupplierID = " & intcode_s & " and debtor <> 0 order by date", ListView3)
            MenuStrip1.Enabled = True
        Catch
            MsgBox("بر روی ردیف خالی کلیک نکنید", MsgBoxStyle.Information, "توجه")
        End Try
    End Sub

    Private Sub tb2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb2.Click
        If tb2.SelectedIndex = 0 Then
            MenuStrip1.Enabled = True
            debtor_or_creditor2 = True
        ElseIf tb2.SelectedIndex = 1 Then
            MenuStrip1.Enabled = True
            debtor_or_creditor2 = False
            filllst(1, "select key,notes,date,creditor from supp_transactions where SupplierID = " & intcode_s & " and creditor <> 0 order by date", ListView1)
        Else
            MenuStrip1.Enabled = False
            filllst(2, "select notes,date,debtor,creditor from supp_transactions where SupplierID = " & intcode_s & " order by date", ListView2)
            '    MsgBox("tab2")

        End If
    End Sub
    Private Sub تغییرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تغییرToolStripMenuItem.Click
        Try
            If selectit = False Then
                MsgBox("شما ابتدا باید یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
                Exit Sub
            End If

            Dim frm As New frmsupp_transactions

            frm.txtSupplierID.Text = intcode_s
            frm.txtsuppliername.Text = strname

            add_or_up2 = False
            If debtor_or_creditor2 = True Then
                intkey = CInt(ListView3.SelectedItems(0).SubItems(0).Text())
                frm.txtnotes.Text = ListView3.SelectedItems(0).SubItems(1).Text()
                frm.mskdate.Text = ListView3.SelectedItems(0).SubItems(2).Text()
                frm.mskdebtor.Text = ListView3.SelectedItems(0).SubItems(3).Text()
            ElseIf debtor_or_creditor2 = False Then
                intkey = CInt(ListView1.SelectedItems(0).SubItems(0).Text())
                frm.txtnotes.Text = ListView1.SelectedItems(0).SubItems(1).Text()
                frm.mskdate.Text = ListView1.SelectedItems(0).SubItems(2).Text()
                frm.mskcreditor.Text = ListView1.SelectedItems(0).SubItems(3).Text()
            End If

            frm.set_frm_supplier(Me)
            frm.ShowDialog()

        Catch
            MsgBox("لطفا ابتدا یک سطر را انتخاب کنید")
        End Try

        selectit = False
    End Sub
    Private Sub tb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.Click
        If tb1.SelectedIndex = 2 Then
            filllst(4, "SELECT Suppliers.code_s, Suppliers.name, Sum(supp_transactions.debtor), Sum(supp_transactions.creditor) FROM Suppliers, supp_transactions WHERE Suppliers.code_s=supp_transactions.SupplierID GROUP BY Suppliers.code_s, Suppliers.name", ListView4)
            'ElseIf tb1.SelectedIndex = 1 Then
            '    MenuStrip1.Enabled = True
            '    debtor_or_credito = False
            '    filllst(1, "select notess,date,creditor from cust_transactions where CustomerID = " & intcode_c & " and creditor <> 0 order by date", ListView1)
            '    '   MsgBox("tab1 " & debtor_or_credito)
            'Else
            '    filllst(2, "select notess,date,debtor,creditor from cust_transactions where CustomerID = " & intcode_c & " order by date", ListView2)
            '    '    MsgBox("tab2")
            '    MenuStrip1.Enabled = False
        End If
    End Sub


    Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفToolStripMenuItem.Click
        If selectit = False Then
            MsgBox("شما ابتدا باید یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
            Exit Sub
        End If

        If debtor_or_creditor2 = True Then
            deleteitem(ListView3, ToolStripTextBox1)
        ElseIf debtor_or_creditor2 = False Then
            deleteitem(ListView1, ToolStripLabel4)
        End If
    End Sub

    Private Sub txtlocationname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlocationname.TextChanged
        Const MESSAGEBOX_CAPTION As String = "جستجو"

        With mydataset.Tables("Suppliers")
            .DefaultView.RowFilter = "address like '%" & txtlocationname.Text & "%'"

            If .DefaultView.Count = 0 Then

                MessageBox.Show("رکوردي با اين مشخصات وجود ندارد", _
                MESSAGEBOX_CAPTION, MessageBoxButtons.OK, _
                MessageBoxIcon.Information)

            End If
            datagridefactor.DataSource = .DefaultView

        End With
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Dim frm As New frmrptSuppliers_personal
        frm.property_0 = intcode_s
        frm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip4.Click
        Dim frm As New frmrptSuppliers_all
        frm.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        selectit = True
    End Sub

    Private Sub tb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb2.SelectedIndexChanged
        selectit = True
    End Sub
End Class
