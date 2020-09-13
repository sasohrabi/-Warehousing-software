Imports VB = Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.String


Public Class Frmbackup
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
   
    Friend WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents Dir2 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents Drive2 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents file1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents file2 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents lblTimeDate As System.Windows.Forms.Label
    Friend WithEvents cmdbackup As System.Windows.Forms.Button
    Friend WithEvents cmdrestore As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdrename As System.Windows.Forms.Button
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents mskdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents shamsi As AxKKRtarikh.AxShamsi
    Friend WithEvents cmddate As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmbackup))
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.file1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.Dir2 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.Drive2 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.file2 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeDate = New System.Windows.Forms.Label
        Me.cmdbackup = New System.Windows.Forms.Button
        Me.cmdrestore = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNewName = New System.Windows.Forms.TextBox
        Me.cmdrename = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Picture1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.mskdate = New System.Windows.Forms.MaskedTextBox
        Me.shamsi = New AxKKRtarikh.AxShamsi
        Me.cmddate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Picture1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dir1
        '
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(16, 48)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dir1.Size = New System.Drawing.Size(168, 112)
        Me.Dir1.TabIndex = 0
        '
        'Drive1
        '
        Me.Drive1.FormattingEnabled = True
        Me.Drive1.Location = New System.Drawing.Point(16, 24)
        Me.Drive1.Name = "Drive1"
        Me.Drive1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drive1.Size = New System.Drawing.Size(168, 21)
        Me.Drive1.TabIndex = 1
        '
        'file1
        '
        Me.file1.FormattingEnabled = True
        Me.file1.Location = New System.Drawing.Point(16, 168)
        Me.file1.Name = "file1"
        Me.file1.Pattern = "*.mdb"
        Me.file1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.file1.Size = New System.Drawing.Size(168, 147)
        Me.file1.TabIndex = 2
        '
        'Dir2
        '
        Me.Dir2.FormattingEnabled = True
        Me.Dir2.IntegralHeight = False
        Me.Dir2.Location = New System.Drawing.Point(408, 96)
        Me.Dir2.Name = "Dir2"
        Me.Dir2.Size = New System.Drawing.Size(168, 112)
        Me.Dir2.TabIndex = 3
        '
        'Drive2
        '
        Me.Drive2.FormattingEnabled = True
        Me.Drive2.Location = New System.Drawing.Point(16, 24)
        Me.Drive2.Name = "Drive2"
        Me.Drive2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drive2.Size = New System.Drawing.Size(168, 21)
        Me.Drive2.TabIndex = 4
        '
        'file2
        '
        Me.file2.FormattingEnabled = True
        Me.file2.Location = New System.Drawing.Point(408, 216)
        Me.file2.Name = "file2"
        Me.file2.Pattern = "*.mdb"
        Me.file2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.file2.Size = New System.Drawing.Size(168, 95)
        Me.file2.TabIndex = 5
        '
        'Timer1
        '
        '
        'lblTimeDate
        '
        Me.lblTimeDate.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeDate.Location = New System.Drawing.Point(480, 8)
        Me.lblTimeDate.Name = "lblTimeDate"
        Me.lblTimeDate.Size = New System.Drawing.Size(112, 16)
        Me.lblTimeDate.TabIndex = 6
        Me.lblTimeDate.Text = "Label23"
        '
        'cmdbackup
        '
        Me.cmdbackup.Enabled = False
        Me.cmdbackup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdbackup.Location = New System.Drawing.Point(24, 40)
        Me.cmdbackup.Name = "cmdbackup"
        Me.cmdbackup.Size = New System.Drawing.Size(128, 25)
        Me.cmdbackup.TabIndex = 9
        Me.cmdbackup.Text = "<-- پشتيبان گيري"
        '
        'cmdrestore
        '
        Me.cmdrestore.Enabled = False
        Me.cmdrestore.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdrestore.Location = New System.Drawing.Point(24, 40)
        Me.cmdrestore.Name = "cmdrestore"
        Me.cmdrestore.Size = New System.Drawing.Size(128, 25)
        Me.cmdrestore.TabIndex = 10
        Me.cmdrestore.Text = "برگرداندن پشتيبان-->"
        '
        'cmddelete
        '
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Location = New System.Drawing.Point(24, 272)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 11
        Me.cmddelete.Text = "حذف"
        Me.cmddelete.Visible = False
        '
        'cmdclose
        '
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclose.Location = New System.Drawing.Point(496, 376)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 23)
        Me.cmdclose.TabIndex = 12
        Me.cmdclose.Text = "خروج"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtNewName)
        Me.GroupBox1.Controls.Add(Me.Drive1)
        Me.GroupBox1.Controls.Add(Me.Dir1)
        Me.GroupBox1.Controls.Add(Me.file1)
        Me.GroupBox1.Controls.Add(Me.cmdrename)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(199, 357)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "دايرکتوري منبع"
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(97, 330)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(78, 20)
        Me.txtNewName.TabIndex = 15
        '
        'cmdrename
        '
        Me.cmdrename.Enabled = False
        Me.cmdrename.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdrename.Location = New System.Drawing.Point(16, 328)
        Me.cmdrename.Name = "cmdrename"
        Me.cmdrename.Size = New System.Drawing.Size(75, 23)
        Me.cmdrename.TabIndex = 14
        Me.cmdrename.Text = "تغيير نام"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Drive2)
        Me.GroupBox2.Controls.Add(Me.cmddelete)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(199, 304)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "دايرکتوري مقصد"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.cmdbackup)
        Me.GroupBox3.Location = New System.Drawing.Point(208, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(172, 96)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "پشتيبان"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox4.Controls.Add(Me.cmdrestore)
        Me.GroupBox4.Location = New System.Drawing.Point(208, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(172, 96)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "برگرداندن"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Window
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture1.Controls.Add(Me.Label3)
        Me.Picture1.Controls.Add(Me.lblTimeDate)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Location = New System.Drawing.Point(0, 0)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(598, 43)
        Me.Picture1.TabIndex = 21
        Me.Picture1.TabStop = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(494, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "MindWorkSoft 2004"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(212, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 52)
        Me.Panel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(2, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "لطفا ابتدا کد امنیتی را وارد کنید"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(2, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(154, 20)
        Me.TextBox2.TabIndex = 2
        '
        'mskdate
        '
        Me.mskdate.BackColor = System.Drawing.SystemColors.Info
        Me.mskdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskdate.Location = New System.Drawing.Point(249, 52)
        Me.mskdate.Mask = "13##/##/##"
        Me.mskdate.Name = "mskdate"
        Me.mskdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskdate.Size = New System.Drawing.Size(85, 22)
        Me.mskdate.TabIndex = 23
        '
        'shamsi
        '
        Me.shamsi.Enabled = True
        Me.shamsi.Location = New System.Drawing.Point(249, 57)
        Me.shamsi.Name = "shamsi"
        Me.shamsi.OcxState = CType(resources.GetObject("shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.shamsi.Size = New System.Drawing.Size(80, 17)
        Me.shamsi.TabIndex = 43
        Me.shamsi.Visible = False
        '
        'cmddate
        '
        Me.cmddate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddate.Location = New System.Drawing.Point(232, 52)
        Me.cmddate.Name = "cmddate"
        Me.cmddate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmddate.Size = New System.Drawing.Size(16, 22)
        Me.cmddate.TabIndex = 101
        Me.cmddate.Text = ">"
        Me.cmddate.UseVisualStyleBackColor = False
        '
        'Frmbackup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 411)
        Me.Controls.Add(Me.cmddate)
        Me.Controls.Add(Me.mskdate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.file2)
        Me.Controls.Add(Me.Dir2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.shamsi)
        Me.MaximizeBox = False
        Me.Name = "Frmbackup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "پشتیبان گیری"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Picture1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbackup.Click
        Dim SourceDir As String
        Dim DestDir As String
        Dim DatabaseFile As String
        Dim DistanationFile As String
        Dim Source As String
        Dim Destination As String
        Dim result As Integer = 0

        'find out if there is file selected
        If file1.FileName = "" Then
            MsgBox("لطفا ابتدا روي فايل مربوطه کليک کنيد", MsgBoxStyle.OkOnly, "فايلي انتخاب نشده")
            Exit Sub
        End If



        DatabaseFile = file1.FileName
        If Len(Dir1.Path) > 3 Then 'not a root directory
            SourceDir = Dir1.Path & "\"
            Source = SourceDir & DatabaseFile
        Else
            SourceDir = Dir1.Path
            Source = SourceDir & DatabaseFile
        End If

        'if the want to append text to  filename
        '    If Check3.CheckState = System.Windows.Forms.CheckState.Checked Then
        'DistanationFile = VB.Left(File1.FileName, Len(File1.FileName) - 4) & txtAppend.Text & VB.Right(File1.FileName, 4)
        ''  ElseIf Check1.CheckState = System.Windows.Forms.CheckState.Checked Then
        'DistanationFile = VB.Left(File1.FileName, Len(File1.FileName) - 4) & VB6.Format(Now, "dd-mm-yy-h-n") & VB.Right(File1.FileName, 4)
        ''   Else
        '    DistanationFile = DatabaseFile
        '    End If



        If Len(Dir2.Path) > 3 Then 'not a root directory
            DestDir = Dir2.Path & "\"
            Destination = DestDir & DistanationFile
        Else
            DestDir = Dir2.Path
            Destination = DestDir & DistanationFile
        End If

        'start copying
        CopyFileWindowsWay(Source, Destination)
        file2.Refresh()
        result = MsgBox("آيا مايليد اطلاعات جداول فروش و خريد حذف شوند؟", MsgBoxStyle.YesNo, "                                                        !توجه")
        If result = 6 Then
            Dim oleconnection1 As New OleDbConnection(strcon)
            Dim oleconnection2 As New OleDbConnection(strcon)
            Dim oleconnection3 As New OleDbConnection(strcon)
            Dim oleconnection4 As New OleDbConnection(strcon)

            Dim olecommand1 As New OleDbCommand
            Dim olecommand2 As New OleDbCommand
            Dim olecommand3 As New OleDbCommand
            Dim olecommand4 As New OleDbCommand

            olecommand1.CommandText = "delete * from sell"
            olecommand1.Connection = oleconnection1
            oleconnection1.Open()
            olecommand1.ExecuteNonQuery()
            oleconnection1.Close()

            olecommand2.CommandText = "delete * from buy"
            olecommand2.Connection = oleconnection2
            oleconnection2.Open()
            olecommand2.ExecuteNonQuery()
            oleconnection2.Close()

            olecommand3.CommandText = "delete * from cus_trans_temp"
            olecommand3.Connection = oleconnection3
            oleconnection3.Open()
            olecommand3.ExecuteNonQuery()
            oleconnection3.Close()

            olecommand4.CommandText = "delete * from sup_trans_temp"
            olecommand4.Connection = oleconnection4
            oleconnection4.Open()
            olecommand4.ExecuteNonQuery()
            oleconnection4.Close()

            MessageBox.Show("جداول خرید و فروش با موفقیت خالی شدند")

            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            Dim olecommandT1 As New OleDbCommand
            Dim olecommandT2 As New OleDbCommand
            Dim olecommandT3 As New OleDbCommand
            Dim olecommandT4 As New OleDbCommand
            Dim olecommandT5 As New OleDbCommand
            Dim olecommandT6 As New OleDbCommand

            Dim str As String

            str = "انتقالی از سال" & VB.Left(mskdate.Text, 4)

            olecommandT1.CommandText = "insert Into cus_trans_temp(CustomerID,notes,[date],debtor,creditor) SELECT cust_transactions.CustomerID,'" & str & "'" & ",'" & mskdate.Text & "', ABS(Sum(cust_transactions.creditor)-Sum(cust_transactions.debtor)),0 FROM cust_transactions GROUP BY cust_transactions.CustomerID HAVING (Sum(cust_transactions.creditor)- Sum(cust_transactions.debtor)) <> 0"
            olecommandT1.Connection = OleDbCon

            olecommandT2.CommandText = "insert Into sup_trans_temp(SupplierID,notes,[date],debtor,creditor) SELECT supp_transactions.SupplierID,'" & str & "'" & ",'" & mskdate.Text & "',0, ABS(Sum(supp_transactions.creditor)-Sum(supp_transactions.debtor)) FROM supp_transactions GROUP BY supp_transactions.SupplierID HAVING (Sum(supp_transactions.creditor)-Sum(supp_transactions.debtor)) <> 0"
            olecommandT2.Connection = OleDbCon

            olecommandT3.CommandText = "delete * from cust_transactions"
            olecommandT3.Connection = OleDbCon

            olecommandT4.CommandText = _
            "delete * from supp_transactions"
            olecommandT4.Connection = OleDbCon


            olecommandT5.CommandText = "insert Into cust_transactions(CustomerID,notes,[date],debtor,creditor) SELECT cus_trans_temp.CustomerID, cus_trans_temp.notes,cus_trans_temp.date,cus_trans_temp.debtor, cus_trans_temp.creditor FROM cus_trans_temp"
            olecommandT5.Connection = OleDbCon

            olecommandT6.CommandText = _
            "insert Into supp_transactions(SupplierID,notes,[date],debtor,creditor) SELECT sup_trans_temp.SupplierID,sup_trans_temp.notes,sup_trans_temp.date,sup_trans_temp.debtor, sup_trans_temp.creditor FROM sup_trans_temp"
            olecommandT6.Connection = OleDbCon

            Try
                OleDbCon.Open()
                olecommandT1.ExecuteNonQuery()
                olecommandT2.ExecuteNonQuery()
                olecommandT3.ExecuteNonQuery()
                olecommandT4.ExecuteNonQuery()
                olecommandT5.ExecuteNonQuery()
                olecommandT6.ExecuteNonQuery()
                OleDbCon.Close()

                MessageBox.Show("حسابها با موفقیت بسته و به سال بعد منتقل شدند.")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Finally

            End Try
        End If

    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrestore.Click
        Dim RestoreSourceDir As String
        Dim RestoreSourceFile As String
        Dim RestoreSourse As String
        Dim RestoreDistination As String

        On Error GoTo ErrHandlerRestore

        'find out if there is file selected
        If file2.FileName = "" Then
            MsgBox("لطفا ابتدا روي فايل مورد نظر کليک کنيد", MsgBoxStyle.OkOnly, "فايلي انتخاب نشده")
            Exit Sub
        End If

        'combine directory and file for the source of the file to restore
        RestoreSourceFile = file2.FileName
        If Len(Dir2.Path) > 3 Then 'not a root directory
            RestoreSourceDir = Dir2.Path & "\"
        Else
            RestoreSourceDir = Dir2.Path
        End If
        RestoreSourse = RestoreSourceDir & RestoreSourceFile

        'find distination of file to restore
        If Len(Dir1.Path) > 3 Then 'not a root directory
            RestoreDistination = Dir1.Path & "\" & RestoreSourceFile
        Else
            RestoreDistination = Dir1.Path & RestoreSourceFile
        End If

        'start copying
        CopyFileWindowsWay(RestoreSourse, RestoreDistination)
        file1.Refresh()

        Exit Sub
ErrHandlerRestore:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا در بازگرداندن فايل")
    End Sub

    Private Sub cmdRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrename.Click
        If file1.FileName = "" Then
            MsgBox("لطفا ابتدا فايل مربوطه را انتخاب کنيد", MsgBoxStyle.OkOnly, "فايلي انتخاب نشده")
            Exit Sub
        End If


        txtNewName.Focus()
    End Sub

    Private Sub BoxRename_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Source As Object
        Dim SourceDir As Object
        Dim DatabaseFile As Object
        Dim erro As Object

        Select Case erro
            Case Is < 0
                Error (5)
            Case 1
                GoTo ErrHandlerRename
        End Select

        'UPGRADE_WARNING: Couldn't resolve default property of object DatabaseFile. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        DatabaseFile = file1.FileName
        If Len(Dir1.Path) > 3 Then 'not a root directory
            'UPGRADE_WARNING: Couldn't resolve default property of object SourceDir. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            SourceDir = Dir1.Path & "\"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object SourceDir. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            SourceDir = Dir1.Path
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object DatabaseFile. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SourceDir. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Source. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Source = SourceDir & DatabaseFile
        'UPGRADE_WARNING: Couldn't resolve default property of object SourceDir. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Source. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Rename(Source, SourceDir & txtNewName.Text & ".mdb")
        file1.Refresh()

        Exit Sub
ErrHandlerRename:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا در تعويض نام فايل!")
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Frmbackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mskdate.Text = shamsi.Tarikh
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Drive1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drive1.SelectedIndexChanged
        On Error GoTo ErrHandlerDriveChange
        Dir1.Path = Drive1.Drive
        Dir1.Refresh()
        Exit Sub
ErrHandlerDriveChange:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا")
    End Sub

    Private Sub Drive2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drive2.SelectedIndexChanged
        On Error GoTo ErrHandlerDriveChange
        Dir2.Path = Drive2.Drive
        Dir2.Refresh()
        Exit Sub
ErrHandlerDriveChange:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimeDate.Text = CStr(Now)
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        On Error GoTo ErrHandlerDelete
        Dim CurrDir As String
        Dim CurrFile As String

        'ensure that file is selected
        If file2.FileName = "" Then
            MsgBox("هيچ فايلي انتخاب نشده", MsgBoxStyle.OkOnly, "خطا!")
            Exit Sub
        End If

        If Len(Dir2.Path) > 3 Then 'not a root directory
            CurrDir = Dir2.Path & "\"
            CurrFile = CurrDir & file2.FileName
        Else
            CurrDir = Dir2.Path
            CurrFile = CurrDir & file2.FileName
        End If

        If MsgBox("آيا مطمئن هستيد که مي خواهيد اين فايل را حذف کنيد " & CurrFile & "?", MsgBoxStyle.YesNo, "حذف فايل") = MsgBoxResult.No Then Exit Sub
        Kill(CurrFile)
        file2.Refresh()
        Exit Sub

ErrHandlerDelete:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا رخ داده")
    End Sub
    Private Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change
        file1.Path = Dir1.Path
        file1.Refresh()
    End Sub

    Private Sub Dir2_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir2.Change
        file2.Path = Dir2.Path
        file2.Refresh()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Me.Close()

    End Sub

    Private Sub Frmbackup_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Timer1.Enabled = False
    End Sub

    Private Sub cmdbackup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbackup.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        If Me.TextBox2.Text.Length = 4 Then

            If Me.TextBox2.Text = 1001 Then
                Me.cmdbackup.Enabled = True
                Me.cmdrename.Enabled = True
                Me.cmdrestore.Enabled = True

            Else
                MessageBox.Show(" کد اشتباه وارد شده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub cmddate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddate.Click
        mskdate.Text = shamsi.Tarikh
    End Sub
End Class
