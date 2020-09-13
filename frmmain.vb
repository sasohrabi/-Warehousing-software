Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI

Imports System
Imports System.Collections
Imports System.Management
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Data.SQLite
Imports System.Data.OleDb




Public Class frmmain

    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)

        Return cpu_ids
    End Function


    Private oDefaultRenderer As New ToolStripProfessionalRenderer(New PropertyGridEx.CustomColorScheme)

    Private Sub فروشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشToolStripMenuItem.Click
        Dim frm As New frmfactorsell
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub خریدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles خریدToolStripMenuItem.Click
        Dim frm As New frmfactorbuy
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub جدولکالابراساسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولکالابراساسToolStripMenuItem.Click
        Dim frm As New Frmsearchgoodstable
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub جدولفروشندهبراساسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولفروشندهبراساسToolStripMenuItem.Click
        Dim frm As New Frmsearchcompanytable
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub جدولفروشباساسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولفروشباساسToolStripMenuItem.Click
        Dim frm As New frmfactorsellsearch2
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub جدولخریدبراساسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولخریدبراساسToolStripMenuItem.Click
        Dim frm As New frmfactorbuysearch2
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub کالاToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کالاToolStripMenuItem.Click
        Dim frm As New frmaddgoods
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub واحدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles واحدToolStripMenuItem.Click
        Dim frm As New frmaddunit
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub کالاToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کالاToolStripMenuItem1.Click
        Dim frm As New frmfactorsellsearch
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub فروشندهToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشندهToolStripMenuItem1.Click
        Dim frm As New frmfactorbuysearch
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub کالاToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کالاToolStripMenuItem2.Click
        Dim frm As New frmupdatedeletegoods
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub فروشندهToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشندهToolStripMenuItem2.Click
        Dim frm As New frmupdatedeletecompany
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub واحدToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles واحدToolStripMenuItem1.Click
        Dim frm As New frmupdatedeletunit
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub لیستکالاهایانبارToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لیستکالاهایانبارToolStripMenuItem.Click
        Dim frm As New frmrpt6
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مجموعپولخریداجناسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعپولخریداجناسToolStripMenuItem.Click
        Dim frm As New frmrpt3
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مجموعپولفاکتورفروشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعپولفاکتورفروشToolStripMenuItem.Click
        Dim frm As New Frmrpt4
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مجموعپولفاکتورخریدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعپولفاکتورخریدToolStripMenuItem.Click
        Dim frm As New frmrpt5
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ماشینحسابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ماشینحسابToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Private Sub پشتیبانگیریToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پشتیبانگیریToolStripMenuItem.Click
        Dim frm As New Frmbackup
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub خروجToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles خروجToolStripMenuItem1.Click
        Dim d As Double
        For d = 1 To 0 + 0.2 Step -0.09
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()
            Me.Opacity = d
            Me.Refresh()
        Next d
        Environment.Exit(0)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        فروشToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        خریدToolStripMenuItem.PerformClick()
    End Sub

    Private Sub جدولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولToolStripMenuItem.Click
        جدولکالابراساسToolStripMenuItem.PerformClick()
    End Sub

    Private Sub جدولفروشندهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولفروشندهToolStripMenuItem.Click
        جدولفروشندهبراساسToolStripMenuItem.PerformClick()
    End Sub

    Private Sub جدولفوسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولفوسToolStripMenuItem.Click
        جدولفروشباساسToolStripMenuItem.PerformClick()
    End Sub

    Private Sub جدولخریدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولخریدToolStripMenuItem.Click
        جدولخریدبراساسToolStripMenuItem.PerformClick()
    End Sub

    Private Sub کالاToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کالاToolStripMenuItem3.Click
        کالاToolStripMenuItem.PerformClick()
    End Sub

    Private Sub فروشندهToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشندهToolStripMenuItem3.Click
        تهیهکنندهToolStripMenuItem.PerformClick()
    End Sub

    Private Sub واحدToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles واحدToolStripMenuItem2.Click
        واحدToolStripMenuItem.PerformClick()
    End Sub

    Private Sub فاکتورفروشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فاکتورفروشToolStripMenuItem.Click
        کالاToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub فاکتورخریدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فاکتورخریدToolStripMenuItem.Click
        فروشندهToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub کالاToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کالاToolStripMenuItem4.Click
        کالاToolStripMenuItem2.PerformClick()
    End Sub

    Private Sub فروشندهToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشندهToolStripMenuItem4.Click
        فروشندهToolStripMenuItem2.PerformClick()
    End Sub

    Private Sub واحدToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles واحدToolStripMenuItem3.Click
        واحدToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        لیستکالاهایانبارToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ماشینحسابToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ماشینحسابToolStripMenuItem1.Click
        ماشینحسابToolStripMenuItem.PerformClick()
    End Sub

    Private Sub پشتیبانگیریToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پشتیبانگیریToolStripMenuItem1.Click
        پشتیبانگیریToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        خروجToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub frmmain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.OemMinus Or e.KeyCode = 109 Then
            فروشToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.Oemplus Or e.KeyCode = 107 Then
            خریدToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub frmmain2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripManager.Renderer = oDefaultRenderer
        oDefaultRenderer.RoundedEdges = False
        'If CpuId() <> "BFEBFBFF000206A7" Then
        '    MessageBox.Show("نرم افزار برای این سخت افزار طراحی نگردیده")
        '    Application.Exit()
        'End If
        Me.KeyPreview = True
    End Sub

    Private Sub دريافتنيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles دريافتنيToolStripMenuItem.Click
        حسابهايدريافتنيToolStripMenuItem.PerformClick()
    End Sub

    Private Sub حسابهايدريافتنيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حسابهايدريافتنيToolStripMenuItem.Click
        Dim frm As New frmDelivery
        ' frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub پرداختنيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پرداختنيToolStripMenuItem.Click
        Dim frm As New frmPeyment
        frm.Show()
    End Sub

    Private Sub تهیهکنندهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تهیهکنندهToolStripMenuItem.Click
        Dim frm As New frmaddcompany
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub فروشندهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشندهToolStripMenuItem.Click
        Dim frm As New frmaddcustomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مشتریToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشتریToolStripMenuItem.Click
        Dim frm As New frmupdatedeletecustomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مشتریToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشتریToolStripMenuItem1.Click
        فروشندهToolStripMenuItem.PerformClick()
    End Sub

    Private Sub مشتریToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشتریToolStripMenuItem2.Click
        مشتریToolStripMenuItem.PerformClick()
    End Sub

    Private Sub جدولتهیهکنندهبراساسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولتهیهکنندهبراساسToolStripMenuItem.Click
        Dim frm As New Frmsearchcustomertable
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub جدولمشتریToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولمشتریToolStripMenuItem.Click
        جدولتهیهکنندهبراساسToolStripMenuItem.PerformClick()
    End Sub

    Private Sub پشتیبانگیریآسانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پشتیبانگیریآسانToolStripMenuItem.Click
        Dim frm As New frmeasybackup
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub پشتیبانگیریآسانToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles پشتیبانگیریآسانToolStripMenuItem1.Click
        پشتیبانگیریآسانToolStripMenuItem.PerformClick()

    End Sub

    Private Sub اتصالبهفایلCDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اتصالبهفایلCDToolStripMenuItem.Click
        Dim frm As New frn
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub اتصالبهفایلرویCDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اتصالبهفایلرویCDToolStripMenuItem.Click
        اتصالبهفایلCDToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Dim frm As New FrmSecrectCode
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub تنظیماتامنیتیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تنظیماتامنیتیToolStripMenuItem.Click
        ToolStripMenuItem5.PerformClick()
    End Sub

    Private Sub مجموعپولفاکتورفروشToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعپولفاکتورفروشToolStripMenuItem1.Click
        Dim frm As New frmrpt4form
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مجموعپولفاکتورخریدToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعپولفاکتورخریدToolStripMenuItem1.Click
        Dim frm As New frmrpt5form
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub حسابهايپرداختنيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حسابهايپرداختنيToolStripMenuItem.Click
        Dim frm As New frmPeyment
        frm.Show()
    End Sub
    Private Sub cleartblPartyAccount()
        Try
            Dim oledbcon As SQLiteConnection = New SQLiteConnection(strconSqlLite)
            oledbcon.Open()

            Dim olecommand As SQLiteCommand = New SQLiteCommand

            olecommand.CommandText = "DELETE FROM tblPartyAccount"

            olecommand.Connection = oledbcon

            olecommand.ExecuteNonQuery()
            oledbcon.Close()

        Catch e1 As Exception

            MsgBox(e1.Message)

        End Try
    End Sub
    Private Sub insertTblPartyAccount()
        Try

            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            OleDbCon.Open()

            Dim MyDataReader As OleDbDataReader

            Dim OleCommand As OleDbCommand = New OleDbCommand
            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = "SELECT code_c,name FROM customer"

            MyDataReader = OleCommand.ExecuteReader

            Dim OleDbCon2 As SQLiteConnection = New SQLiteConnection(strconSqlLite)
            OleDbCon2.Open()
            Dim OleCommand2 As SQLiteCommand = New SQLiteCommand
            OleCommand2.Connection = OleDbCon2

            Do While MyDataReader.Read
                OleCommand2.CommandText = "Insert Into tblPartyAccount " _
                    & "(code,PartyAccount) " _
                    & "Values (" _
                    & "'" & (MyDataReader.Item(0).ToString) & "' , " _
                    & "'" & (MyDataReader.Item(1).ToString) & "')"
                OleCommand2.ExecuteNonQuery()
            Loop
            MyDataReader.Close()

            OleCommand.CommandText = "SELECT code_s,name FROM Suppliers"
            MyDataReader = OleCommand.ExecuteReader
            Do While MyDataReader.Read
                OleCommand2.CommandText = "Insert Into tblPartyAccount " _
                    & "(code,PartyAccount) " _
                    & "Values (" _
                    & "'" & (MyDataReader.Item(0).ToString) & "' , " _
                    & "'" & (MyDataReader.Item(1).ToString) & "')"
                OleCommand2.ExecuteNonQuery()
            Loop
            MyDataReader.Close()

            OleDbCon.Close()
            OleDbCon2.Close()

        Catch e1 As Exception

            MsgBox(e1.Message)

        End Try

    End Sub
    Private Sub چکهایدریافتیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles چکهایدریافتیToolStripMenuItem.Click
        Try

            cleartblPartyAccount()
            insertTblPartyAccount()

            System.Diagnostics.Process.Start(Application.StartupPath & "\incoming.exe")

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
        '    Dim frm As New frmCheckIncoming
        '    frm.MdiParent = Me
        '   frm.Show()

    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton2.ButtonClick

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub نمایشجداولپایهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نمایشجداولپایهToolStripMenuItem.Click
        Dim frm As New frmBaseTables
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub چکهایارسالیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles چکهایارسالیToolStripMenuItem.Click
        Try

            cleartblPartyAccount()
            insertTblPartyAccount()

            System.Diagnostics.Process.Start(Application.StartupPath & "\issue.exe")

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub اضافهکردنToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافهکردنToolStripMenuItem1.Click

    End Sub

    Private Sub تولیدکنندهواردکنندهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تولیدکنندهواردکنندهToolStripMenuItem.Click
        Dim frm As New frmaddProduce
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub اجرایپیشرفتهکدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اجرایپیشرفتهکدToolStripMenuItem.Click
        Dim frm As New frmSQL
        frm.Show()
    End Sub

    Private Sub راهنماییToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles راهنماییToolStripMenuItem.Click
        Dim frm As New frmGuide
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class