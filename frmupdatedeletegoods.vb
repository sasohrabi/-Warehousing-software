Imports System.String
Imports System.Data.OleDb

Public Class frmupdatedeletegoods
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Application.EnableVisualStyles()

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbounit As System.Windows.Forms.ComboBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cbosearchby As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents mskvalidupto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskaddress As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbogroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.cbosearchby = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.cbounit = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdclean = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label9 = New System.Windows.Forms.Label
        Me.mskvalidupto = New System.Windows.Forms.MaskedTextBox
        Me.mskaddress = New System.Windows.Forms.MaskedTextBox
        Me.cbotype = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbogroup = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdsearch
        '
        Me.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(8, 6)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 67
        Me.cmdsearch.Text = "جستجو"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtsearch.Location = New System.Drawing.Point(86, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsearch.Size = New System.Drawing.Size(201, 20)
        Me.txtsearch.TabIndex = 66
        '
        'cbosearchby
        '
        Me.cbosearchby.BackColor = System.Drawing.SystemColors.Info
        Me.cbosearchby.Items.AddRange(New Object() {"کد", "نام", "تاريخ", "تعداد", "گروه"})
        Me.cbosearchby.Location = New System.Drawing.Point(376, 7)
        Me.cbosearchby.Name = "cbosearchby"
        Me.cbosearchby.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbosearchby.Size = New System.Drawing.Size(240, 21)
        Me.cbosearchby.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(622, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = ":واحد کالا"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = ":فیمت خرید کالا"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(622, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = ":کد کالا"
        '
        'txtbuyprice
        '
        Me.txtbuyprice.BackColor = System.Drawing.Color.LightYellow
        Me.txtbuyprice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtbuyprice.Location = New System.Drawing.Point(7, 60)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbuyprice.Size = New System.Drawing.Size(272, 21)
        Me.txtbuyprice.TabIndex = 58
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LightYellow
        Me.txtname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtname.Location = New System.Drawing.Point(7, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtname.Size = New System.Drawing.Size(272, 21)
        Me.txtname.TabIndex = 56
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.LightYellow
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.Location = New System.Drawing.Point(367, 25)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcode.Size = New System.Drawing.Size(249, 21)
        Me.txtcode.TabIndex = 55
        '
        'cbounit
        '
        Me.cbounit.BackColor = System.Drawing.SystemColors.Info
        Me.cbounit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cbounit.Location = New System.Drawing.Point(367, 59)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbounit.Size = New System.Drawing.Size(249, 23)
        Me.cbounit.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = ":قیمت فروش کالا"
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = ":تاریخ خرید کالا"
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(622, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = ":تعداد کالا"
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.Color.LightYellow
        Me.txtsellprice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsellprice.Location = New System.Drawing.Point(367, 96)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsellprice.Size = New System.Drawing.Size(249, 21)
        Me.txtsellprice.TabIndex = 78
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.Color.LightYellow
        Me.txtnumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(367, 130)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnumber.Size = New System.Drawing.Size(249, 21)
        Me.txtnumber.TabIndex = 80
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = ":نام کالا"
        '
        'cmdexit
        '
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(8, 246)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 82
        Me.cmdexit.Text = "خروج"
        '
        'cmdupdate
        '
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdupdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(541, 240)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdupdate.TabIndex = 85
        Me.cmdupdate.Text = "تغيير"
        '
        'cmddelete
        '
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(621, 240)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 84
        Me.cmddelete.Text = "حذف"
        '
        'cmdclean
        '
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(461, 240)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(75, 23)
        Me.cmdclean.TabIndex = 83
        Me.cmdclean.Text = "پاک"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Tan
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Sienna
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(7, 19)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGrid1.Size = New System.Drawing.Size(675, 255)
        Me.DataGrid1.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = ":آدرس کالا"
        '
        'mskvalidupto
        '
        Me.mskvalidupto.BackColor = System.Drawing.SystemColors.Info
        Me.mskvalidupto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskvalidupto.Location = New System.Drawing.Point(7, 96)
        Me.mskvalidupto.Mask = "13##/##/##"
        Me.mskvalidupto.Name = "mskvalidupto"
        Me.mskvalidupto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskvalidupto.Size = New System.Drawing.Size(272, 21)
        Me.mskvalidupto.TabIndex = 92
        '
        'mskaddress
        '
        Me.mskaddress.BackColor = System.Drawing.SystemColors.Info
        Me.mskaddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskaddress.Location = New System.Drawing.Point(7, 130)
        Me.mskaddress.Name = "mskaddress"
        Me.mskaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mskaddress.Size = New System.Drawing.Size(272, 21)
        Me.mskaddress.TabIndex = 93
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.SystemColors.Info
        Me.cbotype.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cbotype.Items.AddRange(New Object() {"مصرفی", "سرمایه ای"})
        Me.cbotype.Location = New System.Drawing.Point(367, 163)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbotype.Size = New System.Drawing.Size(249, 23)
        Me.cbotype.TabIndex = 95
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(622, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(45, 20)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = ":نوع کالا"
        '
        'cbogroup
        '
        Me.cbogroup.BackColor = System.Drawing.SystemColors.Info
        Me.cbogroup.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cbogroup.Location = New System.Drawing.Point(7, 163)
        Me.cbogroup.Name = "cbogroup"
        Me.cbogroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbogroup.Size = New System.Drawing.Size(272, 23)
        Me.cbogroup.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = ":گروه کالا"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(618, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "جستجو بر اساس:"
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(285, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "مقدار فیلد:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cbotype)
        Me.GroupBox1.Controls.Add(Me.txtnumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.cbogroup)
        Me.GroupBox1.Controls.Add(Me.cbounit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtbuyprice)
        Me.GroupBox1.Controls.Add(Me.mskaddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mskvalidupto)
        Me.GroupBox1.Controls.Add(Me.txtsellprice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 196)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات کالا"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 288)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نتیجه جستجو"
        '
        'frmupdatedeletegoods
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.cbosearchby)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdclean)
        Me.MaximizeBox = False
        Me.Name = "frmupdatedeletegoods"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تغییر جدول کالا"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim mydataset As New DataSet
    Dim counter As Integer = 1
    Private Function clear()
        txtsearch.Text = ""
        txtcode.Text = ""
        txtname.Text = ""
        cbounit.Text = ""
        txtbuyprice.Text = ""
        txtsellprice.Text = ""
        txtnumber.Text = ""
        cbotype.Text = ""
        cbogroup.Text = ""
        Me.mskvalidupto.Clear()
        Me.mskaddress.Clear()
    End Function
    Private Function fillcombounit()
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT unit FROM units"
        Try
            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                cbounit.Items.Add(MyDataReader("unit")) 'or use ...mydatareader.item(0)

            Loop

        Catch err As System.Exception

            MyDataReader.Close()
            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

        If (txtcode.Text = "") Then
            txtcode.Focus()
        Else
            txtnumber.Focus()

        End If
    End Function

    'Private Function fillcombocompany()
    '    Dim myOleDbDataAdapter As OleDbDataAdapter
    '    Dim myDataTable As DataTable = New DataTable
    '    Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

    '    OleDbCon.Open()

    '    Try
    '        myOleDbDataAdapter = New OleDbDataAdapter("select code,name from company order by name", _
    '            OleDbCon)

    '        myDataTable.Clear()

    '        myOleDbDataAdapter.Fill(myDataTable)
    '        cbogroup.DataSource = myDataTable
    '        cbogroup.ValueMember = "code"
    '        cbogroup.DisplayMember = "name"

    '    Catch
    '        MsgBox("Error Opening {0}", OleDbCon.DataSource)
    '    End Try

    '    OleDbCon.Close()
    '    OleDbCon.Dispose()
    'End Function

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
                strquery += " WHERE goods.code_g = "
                strquery += txtsearch.Text
            ElseIf (Compare(strsearch, "نام", True) = 0) Then
                strquery += " WHERE goods.name like '"
                strquery += txtsearch.Text.Trim & "%'"
            ElseIf (Compare(strsearch, "تاريخ", True) = 0) Then
                strquery += " WHERE goods.dob like '"
                strquery += txtsearch.Text.Trim & "%'"
            ElseIf (Compare(strsearch, "تعداد", True) = 0) Then
                strquery += " WHERE goods.num like '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "نوع", True) = 0) Then
                strquery += " WHERE goods.type like '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "شرکت", True) = 0) Then
                strquery += " WHERE goods.group_g like '"
                strquery += txtsearch.Text.Trim & "%'"
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
                cbounit.Text = (MyDataReader.Item(2).ToString)
                txtbuyprice.Text = (MyDataReader.Item(3).ToString)
                txtsellprice.Text = (MyDataReader.Item(4).ToString)
                Me.mskvalidupto.Text = (MyDataReader.Item(5).ToString)
                txtnumber.Text = (MyDataReader.Item(6).ToString)
                Me.mskaddress.Text = (MyDataReader.Item(7).ToString)
                cbotype.Text = (MyDataReader.Item(8).ToString)
                cbogroup.Text = MyDataReader.Item(9).ToString
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
    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)
        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "searchresult")



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
            .MappingName = "code_g"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام کالا"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Center
            .Width = 150
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "واحد"
            .MappingName = "unit"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "قيمت خريد"
            .MappingName = "buyprice"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "قيمت فروش"
            .MappingName = "sellprice"
            '.Width = 50
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "تاريخ خريد"
            .MappingName = "dob"
            .Alignment = HorizontalAlignment.Center
            '.Width = 75
            '.ReadOnly = True
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "تعداد"
            .MappingName = "num"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "آدرس"
            .MappingName = "address"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "نوع"
            .MappingName = "type"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "گروه"
            .MappingName = "group_g"
            .Alignment = HorizontalAlignment.Center
        End With
        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10})

        DataGrid1.TableStyles.Add(grdTableStyle1)

    End Function
    Private Function check_goods(ByVal code_goods As Integer) As Integer
        Try
            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            Dim OleCommand As OleDbCommand = New OleDbCommand
            Dim datareader As OleDbDataReader

            OleDbCon.Open()

            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = "SELECT count(*) FROM sell where code_g=" & code_goods

            datareader = OleCommand.ExecuteReader
            Do While datareader.Read
                If datareader.IsDBNull(0) Then
                    Return 0
                Else
                    MessageBox.Show("برای این کالا فاکتور فروش ثبت شده و امکان حذف آن نمی باشد")
                    Return 1
                End If
                Exit Do
            Loop
        Catch ex As Exception
        End Try

    End Function

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        counter += 1
        Dim strquery As String = "Select goods.code_g, goods.name, goods.unit, goods.buyprice, goods.sellprice, goods.dob, goods.num,goods.address,goods.type,goods.group_g FROM goods " ' where goods.name like '" & "تيغ" & "%'"
        makequery(strquery)
        FillTextBox(strquery)
        FillDataGrid(strquery)
    End Sub

    Private Sub frmupdatedeletegoods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombounit()
        ' fillcombocompany()
    End Sub
    'Private Sub cbocompany_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    temptxt.Text = cbocompany.SelectedValue.ToString
    '    'Me.Text = cbocompany.ValueMember
    'End Sub


    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        Try
            If check_goods(CInt(txtcode.Text)) = 0 Then


                Dim string1 As Integer = txtcode.Text
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()


                Dim MyOledbCommand As OleDbCommand = New OleDbCommand


                MyOledbCommand.CommandText = "DELETE FROM goods WHERE code_g=" & string1

                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()
            End If

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try

    End Sub


    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        clear()

    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click

        If Me.txtname.Text <> "" And Me.cbounit.Text <> "" And Me.txtbuyprice.Text <> "" And Me.txtsellprice.Text <> "" _
            And Me.txtnumber.Text <> "" Then
            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()

                Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                MyOledbCommand.CommandText = "Update goods Set " _
                & "name='" & txtname.Text.ToString & "', " _
                & "unit='" & cbounit.Text.ToString & "', " _
                & "buyprice='" & txtbuyprice.Text.ToString & "', " _
                & "sellprice='" & txtsellprice.Text.ToString & "', " _
                & "dob='" & Me.mskvalidupto.Text.ToString & "', " _
                & "num='" & txtnumber.Text.ToString & "', " _
                & "address='" & Me.mskaddress.Text.ToString & "', " _
                & "type='" & Me.cbotype.Text.ToString & "', " _
                & "group_g='" & Me.cbogroup.Text.ToString & "' " _
                & "WHERE code_g = " & txtcode.Text


                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()
            Catch ex As Exception
                MessageBox.Show("مشکلی در ثبت تغییرات رکورد جاری پیش آمده است" & vbCrLf & ex.Message)
                Exit Sub
            End Try

            MsgBox("اطلاعات به درستی ذخیره شد")
            counter += 1
            Dim strquery As String = "Select goods.code_g, goods.name, goods.unit, goods.buyprice, goods.sellprice, goods.dob, goods.num,goods.address,goods.type,goods.group_g FROM goods where goods.code_g = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            FillDataGrid(strquery)
        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If


    End Sub


    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim SqlStr As String
        SqlStr = "Select goods.code_g, goods.name, goods.unit, goods.buyprice, goods.sellprice, goods.dob, goods.num,goods.address,goods.type,goods.group_g FROM goods where goods.code_g = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        FillTextBox(SqlStr)
    End Sub

    Private Sub cbosearchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosearchby.SelectedIndexChanged
        txtsearch.Focus()

    End Sub

    Private Sub txtsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdsearch.Focus()
        End If


    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()

    End Sub

    Private Sub txtcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcode.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txtbuyprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuyprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txtsellprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txtnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub
End Class
