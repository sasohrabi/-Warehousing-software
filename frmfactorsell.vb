Imports System.Data.OleDb

Public Class frmfactorsell
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabfactor As System.Windows.Forms.TabPage
    Friend WithEvents chk_account As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumberPresent As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mskdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents stsconvertint As System.Windows.Forms.StatusBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtrow As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents shamsi As AxKKRtarikh.AxShamsi
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmddate As System.Windows.Forms.Button
    Friend WithEvents txtgrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents tlp1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdnewfactor As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Private WithEvents txtfactor As System.Windows.Forms.TextBox
    Friend WithEvents lvwfactor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdresume As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cboname As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabsearchgoods As System.Windows.Forms.TabPage
    Friend WithEvents tabsellbatch As System.Windows.Forms.TabPage
    Friend WithEvents datagridegoods As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgoodsnametabsearch As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfactorsell))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabfactor = New System.Windows.Forms.TabPage
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.chk_account = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboCustomerName = New System.Windows.Forms.ComboBox
        Me.txtNumberPresent = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.mskdate = New System.Windows.Forms.MaskedTextBox
        Me.cmdprint = New System.Windows.Forms.Button
        Me.stsconvertint = New System.Windows.Forms.StatusBar
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtrow = New System.Windows.Forms.TextBox
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.shamsi = New AxKKRtarikh.AxShamsi
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmddate = New System.Windows.Forms.Button
        Me.txtgrandtotal = New System.Windows.Forms.TextBox
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdnewfactor = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.txtfactor = New System.Windows.Forms.TextBox
        Me.lvwfactor = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdresume = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cboname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabsearchgoods = New System.Windows.Forms.TabPage
        Me.datagridegoods = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtgoodsnametabsearch = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tabsellbatch = New System.Windows.Forms.TabPage
        Me.tlp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabfactor.SuspendLayout()
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabsearchgoods.SuspendLayout()
        CType(Me.datagridegoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabfactor)
        Me.TabControl1.Controls.Add(Me.tabsearchgoods)
        Me.TabControl1.Controls.Add(Me.tabsellbatch)
        Me.TabControl1.Location = New System.Drawing.Point(-6, -24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(886, 560)
        Me.TabControl1.TabIndex = 0
        '
        'tabfactor
        '
        Me.tabfactor.BackColor = System.Drawing.SystemColors.Control
        Me.tabfactor.Controls.Add(Me.txtbuyprice)
        Me.tabfactor.Controls.Add(Me.chk_account)
        Me.tabfactor.Controls.Add(Me.Label14)
        Me.tabfactor.Controls.Add(Me.cboCustomerName)
        Me.tabfactor.Controls.Add(Me.txtNumberPresent)
        Me.tabfactor.Controls.Add(Me.Label13)
        Me.tabfactor.Controls.Add(Me.Label6)
        Me.tabfactor.Controls.Add(Me.Label11)
        Me.tabfactor.Controls.Add(Me.mskdate)
        Me.tabfactor.Controls.Add(Me.cmdprint)
        Me.tabfactor.Controls.Add(Me.stsconvertint)
        Me.tabfactor.Controls.Add(Me.Label12)
        Me.tabfactor.Controls.Add(Me.txtrow)
        Me.tabfactor.Controls.Add(Me.txtCustomerID)
        Me.tabfactor.Controls.Add(Me.cmdcancel)
        Me.tabfactor.Controls.Add(Me.Label5)
        Me.tabfactor.Controls.Add(Me.cmddelete)
        Me.tabfactor.Controls.Add(Me.cmdupdate)
        Me.tabfactor.Controls.Add(Me.shamsi)
        Me.tabfactor.Controls.Add(Me.cmdExit)
        Me.tabfactor.Controls.Add(Me.cmddate)
        Me.tabfactor.Controls.Add(Me.txtgrandtotal)
        Me.tabfactor.Controls.Add(Me.txtsellprice)
        Me.tabfactor.Controls.Add(Me.txtnumber)
        Me.tabfactor.Controls.Add(Me.txtcode)
        Me.tabfactor.Controls.Add(Me.Label10)
        Me.tabfactor.Controls.Add(Me.cmdnewfactor)
        Me.tabfactor.Controls.Add(Me.cmdSave)
        Me.tabfactor.Controls.Add(Me.txttotalprice)
        Me.tabfactor.Controls.Add(Me.txtfactor)
        Me.tabfactor.Controls.Add(Me.lvwfactor)
        Me.tabfactor.Controls.Add(Me.Label9)
        Me.tabfactor.Controls.Add(Me.cmdresume)
        Me.tabfactor.Controls.Add(Me.Label8)
        Me.tabfactor.Controls.Add(Me.Cboname)
        Me.tabfactor.Controls.Add(Me.Label7)
        Me.tabfactor.Controls.Add(Me.Label4)
        Me.tabfactor.Controls.Add(Me.Label3)
        Me.tabfactor.Controls.Add(Me.Label2)
        Me.tabfactor.Controls.Add(Me.Label1)
        Me.tabfactor.Location = New System.Drawing.Point(4, 24)
        Me.tabfactor.Name = "tabfactor"
        Me.tabfactor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabfactor.Size = New System.Drawing.Size(878, 532)
        Me.tabfactor.TabIndex = 0
        Me.tabfactor.Text = "TabPage1"
        '
        'txtbuyprice
        '
        Me.txtbuyprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtbuyprice.Enabled = False
        Me.txtbuyprice.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuyprice.Location = New System.Drawing.Point(369, 72)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.Size = New System.Drawing.Size(80, 30)
        Me.txtbuyprice.TabIndex = 128
        Me.txtbuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chk_account
        '
        Me.chk_account.AutoSize = True
        Me.chk_account.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk_account.Location = New System.Drawing.Point(484, 482)
        Me.chk_account.Name = "chk_account"
        Me.chk_account.Size = New System.Drawing.Size(105, 20)
        Me.chk_account.TabIndex = 137
        Me.chk_account.Text = "انجام حسابداری"
        Me.chk_account.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(12, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(850, 2)
        Me.Label14.TabIndex = 136
        '
        'cboCustomerName
        '
        Me.cboCustomerName.BackColor = System.Drawing.SystemColors.Info
        Me.cboCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboCustomerName.Location = New System.Drawing.Point(12, 7)
        Me.cboCustomerName.Name = "cboCustomerName"
        Me.cboCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboCustomerName.Size = New System.Drawing.Size(326, 28)
        Me.cboCustomerName.TabIndex = 135
        '
        'txtNumberPresent
        '
        Me.txtNumberPresent.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumberPresent.Enabled = False
        Me.txtNumberPresent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberPresent.Location = New System.Drawing.Point(206, 72)
        Me.txtNumberPresent.Name = "txtNumberPresent"
        Me.txtNumberPresent.Size = New System.Drawing.Size(66, 30)
        Me.txtNumberPresent.TabIndex = 133
        Me.txtNumberPresent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(344, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(53, 23)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "نام مشتري"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(123, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "تعداد فروش"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(205, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "تعداد موجود"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskdate
        '
        Me.mskdate.BackColor = System.Drawing.SystemColors.Info
        Me.mskdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskdate.Location = New System.Drawing.Point(732, 9)
        Me.mskdate.Mask = "13##/##/##"
        Me.mskdate.Name = "mskdate"
        Me.mskdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskdate.Size = New System.Drawing.Size(97, 26)
        Me.mskdate.TabIndex = 0
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.SystemColors.Info
        Me.cmdprint.BackgroundImage = CType(resources.GetObject("cmdprint.BackgroundImage"), System.Drawing.Image)
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(595, 482)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(80, 23)
        Me.cmdprint.TabIndex = 131
        Me.cmdprint.Text = "چاپ"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'stsconvertint
        '
        Me.stsconvertint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsconvertint.Location = New System.Drawing.Point(3, 505)
        Me.stsconvertint.Name = "stsconvertint"
        Me.stsconvertint.Size = New System.Drawing.Size(872, 24)
        Me.stsconvertint.TabIndex = 130
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(369, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "في خريد"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtrow
        '
        Me.txtrow.BackColor = System.Drawing.SystemColors.Info
        Me.txtrow.Enabled = False
        Me.txtrow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrow.Location = New System.Drawing.Point(822, 72)
        Me.txtrow.Name = "txtrow"
        Me.txtrow.Size = New System.Drawing.Size(40, 30)
        Me.txtrow.TabIndex = 125
        Me.txtrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(403, 5)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCustomerID.Size = New System.Drawing.Size(71, 26)
        Me.txtCustomerID.TabIndex = 101
        Me.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.SystemColors.Info
        Me.cmdcancel.BackgroundImage = CType(resources.GetObject("cmdcancel.BackgroundImage"), System.Drawing.Image)
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(595, 453)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 23)
        Me.cmdcancel.TabIndex = 127
        Me.cmdcancel.Text = "انصراف"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(823, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "رديف"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.SystemColors.Info
        Me.cmddelete.BackgroundImage = CType(resources.GetObject("cmddelete.BackgroundImage"), System.Drawing.Image)
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(681, 482)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(88, 23)
        Me.cmddelete.TabIndex = 124
        Me.cmddelete.Text = "حذف"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.SystemColors.Info
        Me.cmdupdate.BackgroundImage = CType(resources.GetObject("cmdupdate.BackgroundImage"), System.Drawing.Image)
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(775, 482)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 23)
        Me.cmdupdate.TabIndex = 123
        Me.cmdupdate.Text = "تغيير"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'shamsi
        '
        Me.shamsi.Enabled = True
        Me.shamsi.Location = New System.Drawing.Point(337, 459)
        Me.shamsi.Name = "shamsi"
        Me.shamsi.OcxState = CType(resources.GetObject("shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.shamsi.Size = New System.Drawing.Size(80, 17)
        Me.shamsi.TabIndex = 132
        Me.shamsi.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Info
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(423, 453)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 23)
        Me.cmdExit.TabIndex = 117
        Me.cmdExit.Text = "خروج"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmddate
        '
        Me.cmddate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddate.Location = New System.Drawing.Point(715, 8)
        Me.cmddate.Name = "cmddate"
        Me.cmddate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmddate.Size = New System.Drawing.Size(17, 27)
        Me.cmddate.TabIndex = 140
        Me.cmddate.Text = ">"
        Me.cmddate.UseVisualStyleBackColor = False
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtgrandtotal.Location = New System.Drawing.Point(12, 454)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(195, 26)
        Me.txtgrandtotal.TabIndex = 120
        Me.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsellprice.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsellprice.Location = New System.Drawing.Point(278, 72)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.Size = New System.Drawing.Size(85, 30)
        Me.txtsellprice.TabIndex = 119
        Me.txtsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtnumber.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(138, 72)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(63, 30)
        Me.txtnumber.TabIndex = 108
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(766, 72)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(51, 26)
        Me.txtcode.TabIndex = 107
        Me.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tlp1.SetToolTip(Me.txtcode, "مکان جنس در انبار")
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(207, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "مجموع کل"
        '
        'cmdnewfactor
        '
        Me.cmdnewfactor.BackColor = System.Drawing.SystemColors.Info
        Me.cmdnewfactor.BackgroundImage = CType(resources.GetObject("cmdnewfactor.BackgroundImage"), System.Drawing.Image)
        Me.cmdnewfactor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdnewfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdnewfactor.Location = New System.Drawing.Point(509, 453)
        Me.cmdnewfactor.Name = "cmdnewfactor"
        Me.cmdnewfactor.Size = New System.Drawing.Size(80, 23)
        Me.cmdnewfactor.TabIndex = 116
        Me.cmdnewfactor.Text = "ثبت فاکتور"
        Me.cmdnewfactor.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Info
        Me.cmdSave.BackgroundImage = CType(resources.GetObject("cmdSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(681, 453)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 23)
        Me.cmdSave.TabIndex = 115
        Me.cmdSave.Text = "ذخيره"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txttotalprice
        '
        Me.txttotalprice.BackColor = System.Drawing.SystemColors.Info
        Me.txttotalprice.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalprice.Location = New System.Drawing.Point(12, 72)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(120, 30)
        Me.txttotalprice.TabIndex = 109
        Me.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfactor
        '
        Me.txtfactor.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactor.Enabled = False
        Me.txtfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfactor.Location = New System.Drawing.Point(549, 7)
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Size = New System.Drawing.Size(81, 27)
        Me.txtfactor.TabIndex = 103
        Me.txtfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvwfactor
        '
        Me.lvwfactor.BackColor = System.Drawing.SystemColors.Info
        Me.lvwfactor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader1})
        Me.lvwfactor.Font = New System.Drawing.Font("B Traffic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lvwfactor.FullRowSelect = True
        Me.lvwfactor.GridLines = True
        Me.lvwfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvwfactor.LabelEdit = True
        Me.lvwfactor.LabelWrap = False
        Me.lvwfactor.Location = New System.Drawing.Point(0, 104)
        Me.lvwfactor.Name = "lvwfactor"
        Me.lvwfactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lvwfactor.RightToLeftLayout = True
        Me.lvwfactor.Size = New System.Drawing.Size(875, 343)
        Me.lvwfactor.TabIndex = 122
        Me.lvwfactor.UseCompatibleStateImageBehavior = False
        Me.lvwfactor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "رديف"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 53
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "کد کالا"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 56
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "نام کالا"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 312
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "في خريد"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 89
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "في فروش"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 94
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "تعداد فروش"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 140
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "قيمت کل"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 112
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(293, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "في فروش"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdresume
        '
        Me.cmdresume.BackColor = System.Drawing.SystemColors.Info
        Me.cmdresume.BackgroundImage = CType(resources.GetObject("cmdresume.BackgroundImage"), System.Drawing.Image)
        Me.cmdresume.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdresume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdresume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdresume.Location = New System.Drawing.Point(775, 453)
        Me.cmdresume.Name = "cmdresume"
        Me.cmdresume.Size = New System.Drawing.Size(88, 23)
        Me.cmdresume.TabIndex = 114
        Me.cmdresume.Text = "ادامه"
        Me.cmdresume.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(536, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(182, 20)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "نام کالا"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cboname
        '
        Me.Cboname.BackColor = System.Drawing.SystemColors.Info
        Me.Cboname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cboname.Location = New System.Drawing.Point(455, 72)
        Me.Cboname.Name = "Cboname"
        Me.Cboname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cboname.Size = New System.Drawing.Size(305, 24)
        Me.Cboname.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "قيمت کل"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(764, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = " کد کالا"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(835, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(30, 24)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "تاريخ"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(614, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "شماره فاکتور"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "کد مشتری"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabsearchgoods
        '
        Me.tabsearchgoods.BackColor = System.Drawing.SystemColors.Control
        Me.tabsearchgoods.Controls.Add(Me.datagridegoods)
        Me.tabsearchgoods.Controls.Add(Me.GroupBox1)
        Me.tabsearchgoods.Location = New System.Drawing.Point(4, 24)
        Me.tabsearchgoods.Name = "tabsearchgoods"
        Me.tabsearchgoods.Padding = New System.Windows.Forms.Padding(3)
        Me.tabsearchgoods.Size = New System.Drawing.Size(878, 532)
        Me.tabsearchgoods.TabIndex = 1
        Me.tabsearchgoods.Text = "TabPage2"
        '
        'datagridegoods
        '
        Me.datagridegoods.CaptionFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridegoods.DataMember = ""
        Me.datagridegoods.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagridegoods.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridegoods.Location = New System.Drawing.Point(3, 73)
        Me.datagridegoods.Name = "datagridegoods"
        Me.datagridegoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datagridegoods.Size = New System.Drawing.Size(872, 456)
        Me.datagridegoods.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtgoodsnametabsearch)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فيلتر کردن اطلاعات موجود"
        '
        'txtgoodsnametabsearch
        '
        Me.txtgoodsnametabsearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtgoodsnametabsearch.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtgoodsnametabsearch.Location = New System.Drawing.Point(6, 29)
        Me.txtgoodsnametabsearch.Name = "txtgoodsnametabsearch"
        Me.txtgoodsnametabsearch.Size = New System.Drawing.Size(685, 30)
        Me.txtgoodsnametabsearch.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(658, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 23)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "بر اساس نام کالا :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tabsellbatch
        '
        Me.tabsellbatch.Location = New System.Drawing.Point(4, 24)
        Me.tabsellbatch.Name = "tabsellbatch"
        Me.tabsellbatch.Size = New System.Drawing.Size(878, 532)
        Me.tabsellbatch.TabIndex = 2
        Me.tabsellbatch.Text = "TabPage1"
        Me.tabsellbatch.UseVisualStyleBackColor = True
        '
        'tlp1
        '
        Me.tlp1.IsBalloon = True
        Me.tlp1.StripAmpersands = True
        '
        'frmfactorsell
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(876, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmfactorsell"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت فاکتور فروش"
        Me.TabControl1.ResumeLayout(False)
        Me.tabfactor.ResumeLayout(False)
        Me.tabfactor.PerformLayout()
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabsearchgoods.ResumeLayout(False)
        CType(Me.datagridegoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region




    Dim SaveOrEdit As String = ""
    Dim selectit As Boolean = False

    Dim mydataset As New DataSet

    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)

        OleDbConn.Open()


        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "searchresult")

        Me.datagridegoods.DataSource = mydataset.Tables(0)

        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function

    Private Function FormatGridWithTableStyles()
        With datagridegoods
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.FixedSingle
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "مشخصات تمامی کالاهای موجود"
            .Font = New Font("Tahoma", 11.0!, FontStyle.Bold)
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
            .HeaderFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .HeaderForeColor = Color.Lavender
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
            .MappingName = myDataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد کالا"
            .MappingName = "code_g"
            .Width = 55
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام کالا"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Left
            .Width = 285
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "واحد"
            .MappingName = "unit"
            .Width = 50
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "قيمت خريد"
            .MappingName = "buyprice"
            .Width = 80
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "قيمت فروش"
            .MappingName = "sellprice"
            .Width = 88
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "تاريخ خريد"
            .MappingName = "dob"
            .Alignment = HorizontalAlignment.Center
            .Width = 100
            '.ReadOnly = True
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "تعداد"
            .MappingName = "num"
            .Width = 60
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "آدرس"
            .MappingName = "address"
            .Width = 90
            .Alignment = HorizontalAlignment.Center
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        datagridegoods.TableStyles.Add(grdTableStyle1)

    End Function

    Private Function cleartextboxes()
        ' txtdob.Clear()
        txtfactor.Clear()
        txtrow.Clear()
        ' txtcode.Clear()
        txtnumber.Clear()
        'txtsellprice.Clear()
        txttotalprice.Clear()
        txtgrandtotal.Clear()

        'txtdob.TabIndex = 0
        'txtdob.Focus()

        mskdate.Clear()



    End Function
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
        Cboname.DataSource = myDataTable
        Cboname.ValueMember = "code_g"
        Cboname.DisplayMember = "name"

        'Catch
        '    MsgBox("Error Opening {0}", OleDbCon.DataSource)
        'End Try

        OleDbCon.Close()
        OleDbCon.Dispose()
    End Function
    Private Function fillcomboCustomerName()
        Dim myOleDbDataAdapter As OleDbDataAdapter
        Dim myDataTable As DataTable = New DataTable
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

        OleDbCon.Open()

        Try
            myOleDbDataAdapter = New OleDbDataAdapter("select code_c,name from customer order by name", _
                OleDbCon)

            myDataTable.Clear()

            myOleDbDataAdapter.Fill(myDataTable)
            cboCustomerName.DataSource = myDataTable
            cboCustomerName.ValueMember = "code_c"
            cboCustomerName.DisplayMember = "name"

        Catch
            MsgBox("Error Opening {0}", OleDbCon.DataSource)
        End Try

        OleDbCon.Close()
        OleDbCon.Dispose()
    End Function
    Public Function FillTextBox(ByVal Sqlstring As String)

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)


        Dim MyDataReader As OleDbDataReader


        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = Sqlstring
        Try
            OleDbCon.Open()
            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                txtbuyprice.Text = (MyDataReader.Item("buyprice"))
                txtsellprice.Text = (MyDataReader.Item("sellprice"))
                txtNumberPresent.Text = (MyDataReader.Item("num"))
                '  txtdescription.Text = (MyDataReader.Item("description"))

            Loop

        Catch err As System.Exception

            'MyDataReader.Close()
            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

    End Function
    Public Function filllst()
        Dim summoney As Long = 0
        Dim strsql As String = "select * from tempsell order by row desc"
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand
        lvwfactor.Items.Clear()

        olecommand.CommandText = strsql
        olecommand.Connection = OleDbCon
        Try
            OleDbCon.Open()
            Dim datareader As OleDbDataReader
            datareader = olecommand.ExecuteReader

            While datareader.Read
                Dim lvi As New ListViewItem
                lvi.Text = CStr(datareader("row"))

                lvi.SubItems.Add(CStr(datareader("code_g")))
                lvi.SubItems.Add(CStr(datareader("name_g")))
                lvi.SubItems.Add(CStr(datareader("buyprice")))
                lvi.SubItems.Add(CStr(datareader("sellprice")))
                lvi.SubItems.Add(CStr(datareader("num")))
                lvi.SubItems.Add(CStr(datareader("sumprice")))
                summoney += CInt(datareader("sumprice"))
                txtgrandtotal.Text = summoney


                lvwfactor.Items.Add(lvi)
                'lvwfactor.Sorting = SortOrder.Ascending

                mskdate.Text = datareader("dob")
                txtfactor.Text = datareader("factor")
                txtCustomerID.Text = datareader("code_c")
                cboCustomerName.Text = datareader("name_c")
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            OleDbCon.Close()
        End Try
    End Function
    Private Function fixrow()
        Dim rownumber As Integer = 0
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(tempsell.row) FROM tempsell"

        MyDataReader = OleCommand.ExecuteReader

        Do While MyDataReader.Read
            If MyDataReader.IsDBNull(0) Then
                rownumber = 1
                txtrow.Text = rownumber
            Else
                rownumber = (MyDataReader.Item(0))
                rownumber += 1
                txtrow.Text = rownumber
            End If

        Loop

        MyDataReader.Close()
        OleDbCon.Close()
        OleDbCon.Dispose()

    End Function
    Private Function addnew()

        Dim num As Integer = 0
        Dim sumnum As Integer = 0
        Dim sumprice As String = ""
        Dim sqladdupdate As String = ""
        add_previus_goods(txtfactor.Text, txtcode.Text, num, sumprice)

        If num = 0 Then
            sumnum = CInt(txtnumber.Text)
            sqladdupdate = "Insert Into tempsell " _
                        & "(row,dob,factor,code_c,name_c,code_g,name_g,buyprice,sellprice,num,sumprice) " _
                        & "Values (" _
                        & "'" & txtrow.Text & "' , " _
                        & "'" & mskdate.Text & "' , " _
                        & "'" & txtfactor.Text & "' , " _
                        & "'" & txtCustomerID.Text & "' , " _
                        & "'" & cboCustomerName.Text & "' , " _
                        & "'" & txtcode.Text & "' , " _
                        & "'" & Cboname.Text & "' , " _
                        & "'" & txtbuyprice.Text & "' , " _
                        & "'" & txtsellprice.Text & "' , " _
                        & "'" & CStr(sumnum) & "' , " _
                        & "'" & txttotalprice.Text & "')"
        Else
            Dim result As DialogResult = MessageBox.Show("قبلا همين کالا با همين شماره فاکنور با قيمت فروش" & vbNewLine & sumprice & vbNewLine & "ثبت گرديده" & vbNewLine & "آيا از اينکه تعداد جديد به تعداد قبلي اضافه و قيمت فروش جديد جايگزين گردد مطمئن ايد؟", "اضافه کردن ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = Windows.Forms.DialogResult.Yes) Then
                sumnum = num + CInt(txtnumber.Text)
                sumprice += CInt(txttotalprice.Text)
                If CInt(sumnum) <= CInt(txtNumberPresent.Text) Then
                    sqladdupdate = "Update tempsell Set " _
                                  & "dob='" & mskdate.Text & "', " _
                                  & "factor='" & txtfactor.Text & "', " _
                                  & "code_c='" & txtCustomerID.Text & "', " _
                                  & "name_c='" & cboCustomerName.Text & "', " _
                                  & "row = '" & txtrow.Text & "', " _
                                  & "code_g='" & txtcode.Text & "', " _
                                  & "name_g='" & Cboname.Text & "' , " _
                                  & "buyprice='" & txtbuyprice.Text & "', " _
                                  & "sellprice='" & txtsellprice.Text & "', " _
                                  & "num='" & CStr(sumnum) & "', " _
                                  & "sumprice='" & sumprice.ToString() & "'" _
                                  & " WHERE factor=" & txtfactor.Text & " and code_g =" & txtcode.Text
                Else
                    MsgBox("تعداد درخواستی بیش از تعداد موجود در انبار است")
                    txtnumber.Focus()
                    Exit Function
                End If
            Else
                Exit Function
            End If
        End If

        If check_factor_exist(txtfactor.Text, txtcode.Text) Then
            Try
                If CInt(txtnumber.Text) <= CInt(txtNumberPresent.Text) Then
                    Dim oledbcon As New OleDbConnection(strcon)
                    oledbcon.Open()
                    Dim olecommand As New OleDbCommand

                    olecommand.CommandText = sqladdupdate

                    olecommand.Connection = oledbcon

                    olecommand.ExecuteNonQuery()
                    oledbcon.Close()
                    oledbcon.Dispose()
                Else
                    MsgBox("تعداد درخواستی بیش از تعداد موجود در انبار است")
                    txtnumber.Focus()
                    Exit Function

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("قبلا با همین شماره فاکتور این کالا ثبت شده است لطفا برای ذخیره رکورد جاری شماره فاکتور جدید را وارد کنید")
        End If

    End Function
    Private Function deleteitem()
        Dim summoney As Long = CInt(txtgrandtotal.Text)
        Dim strid As String
        Dim lvi As New ListViewItem
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

        For Each lvi In lvwfactor.SelectedItems

            strid = lvi.SubItems(0).Text
            summoney -= CInt(lvi.SubItems(6).Text)

            Dim olecommand As New OleDbCommand

            olecommand.CommandText = "delete from tempsell where row=" & strid
            olecommand.Connection = OleDbCon
            Try
                OleDbCon.Open()
                olecommand.ExecuteNonQuery()

                lvwfactor.Items.RemoveAt(lvi.Index)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDbCon.Close()
            End Try
        Next
        txtgrandtotal.Text = summoney

    End Function
    Private Function updateitem()

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

        If selectit = False Then
            MsgBox("شما باید ابتدا یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
            Exit Function
        End If
        Try


            Dim olecommand As New OleDbCommand


            olecommand.CommandText = "Update tempsell Set " _
                              & "dob='" & mskdate.Text & "', " _
                              & "factor='" & txtfactor.Text & "', " _
                              & "code_c='" & txtCustomerID.Text & "', " _
                              & "name_c='" & cboCustomerName.Text & "', " _
                              & "row = '" & txtrow.Text & "', " _
                              & "code_g='" & txtcode.Text & "', " _
                              & "name_g='" & Cboname.Text & "' , " _
                              & "buyprice='" & txtbuyprice.Text & "', " _
                              & "sellprice='" & txtsellprice.Text & "', " _
                              & "num='" & txtnumber.Text & "', " _
                              & "sumprice='" & txttotalprice.Text & "'" _
                              & " WHERE row = " & CInt(txtrow.Text)

            olecommand.Connection = OleDbCon
            OleDbCon.Open()
            olecommand.ExecuteNonQuery()

        Catch
            MessageBox.Show("این رکورد قبلا ثبت شده است")
        Finally
            OleDbCon.Close()
            selectit = False
        End Try
    End Function
    Private Function check_factor_exist(ByVal code_factor As Integer, ByVal code_goods As Integer) As Boolean

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT count(*) FROM sell where factor=" & code_factor & " and code_g =" & code_goods

        MyDataReader = OleCommand.ExecuteReader

        Do While MyDataReader.Read
            If MyDataReader(0) = 0 Then
                Return True
            Else
                Return False
            End If

        Loop

        MyDataReader.Close()
        OleDbCon.Close()
        OleDbCon.Dispose()
    End Function
    Private Function add_previus_goods(ByVal code_factor As Integer, ByVal code_goods As Integer, ByRef num As Integer, ByRef sumprice As String)
        Try
            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            Dim OleCommand As OleDbCommand = New OleDbCommand
            Dim datareader As OleDbDataReader

            OleDbCon.Open()

            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = "SELECT num,sumprice FROM tempsell where factor=" & code_factor & " and code_g =" & code_goods

            datareader = OleCommand.ExecuteReader
            Do While datareader.Read
                If datareader.IsDBNull(0) Then
                    num = 0
                Else
                    num = CInt(datareader.Item(0))
                    sumprice = datareader.Item(1)
                End If
                Exit Do
            Loop
        Catch ex As Exception
            num = 0
        End Try

    End Function

    Private Sub frmfactorsell_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            TabControl1.SelectedIndex = 0
        ElseIf e.KeyCode = Keys.F2 Then
            TabControl1.SelectedIndex = 1
            Me.txtgoodsnametabsearch.Focus()
            Me.txtgoodsnametabsearch.TabIndex = 0
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcomboname()
        fillcomboCustomerName()
        filllst()
        ' cleartextboxes()
        Me.KeyPreview = True
        '  Me.KeyDown += New KeyEventHandler(frmfactorsell_KeyDown)
        Me.mskdate.Focus()
        Me.mskdate.TabIndex = 0

        Dim strquerytabsearch As String = "Select * from goods"
        FillDataGrid(strquerytabsearch)

    End Sub
    Private Function count_hal_giri() As Integer
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()
        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "select count(*) from sell"

        Return OleCommand.ExecuteScalar
    End Function
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '  If count_hal_giri() <= 100 Then
        If SaveOrEdit = "Save" Then
            If Me.Cboname.Text <> "" And Me.txtnumber.Text <> "" And Me.txtsellprice.Text <> "" And Me.txttotalprice.Text <> "" And Len(mskdate.Text) = 10 Then
                addnew()
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If


            'cleartextboxes()

        ElseIf SaveOrEdit = "Edit" Then
            If Me.txtnumber.Text <> "" And Me.txtsellprice.Text <> "" And Me.txttotalprice.Text <> "" And Len(mskdate.Text) = 10 Then
                updateitem()
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If

            ' deleteitem()
            'addnew()

        Else

            MessageBox.Show(" چیزی ذخیره نشده است")

        End If

        filllst()

        cmdresume.Enabled = True
        cmdupdate.Enabled = True
        cmddelete.Enabled = True

        txtcode.TabIndex = 0
        txtcode.Focus()
        'Else
        'MsgBox("این نرم افزار نسخه آزمایشی می باشد")
        'End If

    End Sub


    Private Sub cmdresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresume.Click
        SaveOrEdit = "Save"
        fixrow()
        mskdate.TabIndex = 0
        cmdSave.Focus()

        cmdupdate.Enabled = False
        cmddelete.Enabled = False
        cmdresume.Enabled = False

    End Sub

    Private Sub cmdnewfactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewfactor.Click

        Dim i As Integer = 0
        Dim number As Integer = 0
        Dim factornumber As Integer = 0

        Dim OleDbCon As New OleDbConnection(strcon)
        Dim oledbcon2 As New OleDbConnection(strcon)
        Dim oledbcon3 As New OleDbConnection(strcon)
        Dim oledbcon4 As New OleDbConnection(strcon)
        Dim oledbcon5 As New OleDbConnection(strcon)

        Try
            Dim MyDataReader1 As OleDbDataReader
            Dim OleCommand1 As New OleDbCommand
            OleCommand1.Connection = (OleDbCon)
            OleCommand1.CommandText = "SELECT row,code_g,num FROM tempsell"

            Dim mydatareader2 As OleDbDataReader
            Dim olecommand2 As New OleDbCommand
            olecommand2.CommandText = "SELECT goods.num FROM goods WHERE code_g=?"
            olecommand2.Connection = (oledbcon2)

            Dim olecommand3 As New OleDbCommand
            olecommand3.Connection = (oledbcon3)

            Dim olecommand4 As New OleDbCommand
            olecommand4.CommandText = "INSERT INTO sell( dob, factor, code_c, code_g ,buyprice, sellprice, num, sumprice)" & _
          "SELECT dob, factor, code_c, code_g, buyprice, sellprice, num, sumprice " & _
          "FROM tempsell WHERE row=?"
            olecommand4.Connection = (oledbcon4)

            Dim olecommand5 As New OleDbCommand
            olecommand5.Connection = (oledbcon5)

            OleDbCon.Open()

            MyDataReader1 = OleCommand1.ExecuteReader

            Do While MyDataReader1.Read


                olecommand2.Parameters.Add("code_g", Data.OleDb.OleDbType.Integer)
                olecommand2.Parameters("code_g").Value = MyDataReader1.Item(1)


                oledbcon2.Open()
                number = olecommand2.ExecuteScalar
                oledbcon2.Close()

                number -= CInt(MyDataReader1.Item(2))

                If number >= 0 Then
                    oledbcon3.Open()
                    olecommand3.CommandText = "UPDATE goods SET num = " & number & " WHERE code_g= " & MyDataReader1.Item(1)
                    olecommand3.ExecuteNonQuery()
                    oledbcon3.Close()

                    olecommand4.Parameters.Add("row", Data.OleDb.OleDbType.Integer)
                    olecommand4.Parameters("row").Value = MyDataReader1.Item(0)

                    oledbcon4.Open()
                    olecommand4.ExecuteNonQuery()
                    oledbcon4.Close()

                    oledbcon5.Open()
                    olecommand5.CommandText = "DELETE FROM tempsell WHERE row=" & MyDataReader1.Item(0)
                    olecommand5.ExecuteNonQuery()
                    oledbcon5.Close()

                Else
                    MessageBox.Show("تعداد درخواستی بیش از موجودی انبار است " & vbCrLf & MyDataReader1.Item(1) & " " & "کد جنس")
                    i += 1
                End If

                'strquery = "SELECT goods.num FROM goods WHERE code= "
                number = 0


            Loop

            MyDataReader1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDbCon.Close()
        End Try

        fillcomboname()
        If txtcode.Text <> "" Then
            Dim SqlStr As String
            SqlStr = "Select num,buyprice,sellprice from goods where code_g = " & Val(txtcode.Text)
            FillTextBox(SqlStr)
            Try
                Cboname.SelectedValue = Val(txtcode.Text)
            Catch ex As Exception

            End Try
            'SqlStr = "Select name from company where code = (select company from goods where code = " & Val(txtcode.Text) & ")"
            ' FillTxtcompany(SqlStr)
        End If

        If chk_account.Checked = True Then
            Dim frm As New frmcust_transactions2
            frm.txtCustomerID.Text = txtCustomerID.Text
            frm.txtcustomername.Text = cboCustomerName.Text
            frm.txtnotes.Text = "بابت فاکتور فروش شماره " + txtfactor.Text
            frm.mskdate.Text = mskdate.Text
            frm.mskdebtor.Text = txtgrandtotal.Text
            frm.ShowDialog()
        End If

        If i = 0 Then
            mskdate.Clear()


            mskdate.Focus()
            cleartextboxes()
            lvwfactor.Items.Clear()
        Else
            filllst()
        End If

        OleDbCon.Close()
        OleDbCon.Dispose()
    End Sub

    Private Sub cmddate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddate.Click

        '  txtdob.Text = TarikhShamsi(Now.Date, True)
        'mskdate.CtlText = TarikhShamsi(Now.Date, True)
        mskdate.Text = shamsi.Tarikh
        If mskdate.Text <> "" Then
            txtCustomerID.Focus()
        End If

    End Sub



    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        deleteitem()

    End Sub

    Private Sub lvwfactor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwfactor.KeyDown
        If e.KeyCode <> Keys.Delete Then Exit Sub
        deleteitem()
    End Sub


    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click

        SaveOrEdit = "Edit"

        If selectit = False Then
            MsgBox("شما ابتدا باید یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
            Exit Sub
        End If

        Dim strrow As Integer = lvwfactor.SelectedItems(0).SubItems(0).Text
        Dim strcode As Integer = lvwfactor.SelectedItems(0).SubItems(1).Text
        Dim strname As String = lvwfactor.SelectedItems(0).SubItems(2).Text
        Dim strbuyprice As String = lvwfactor.SelectedItems(0).SubItems(3).Text
        Dim strsellprice As String = lvwfactor.SelectedItems(0).SubItems(4).Text
        Dim strnumber As String = lvwfactor.SelectedItems(0).SubItems(5).Text
        Dim strsumprice As String = lvwfactor.SelectedItems(0).SubItems(6).Text

        txtcode.Text = strcode
        Cboname.Text = strname
        txtbuyprice.Text = strbuyprice
        txtsellprice.Text = strsellprice
        txtnumber.Text = strnumber
        txttotalprice.Text = strsumprice
        txtrow.Text = strrow

        cmdresume.Enabled = False
        cmddelete.Enabled = False

    End Sub



    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrEdit = "Cancel"

        cmdresume.Enabled = True
        cmddelete.Enabled = True
        cmdupdate.Enabled = True

    End Sub


    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click

        Dim factornumber As Integer = 0
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(sell.factor) FROM sell"

        MyDataReader = OleCommand.ExecuteReader

        Do While MyDataReader.Read
            If MyDataReader.IsDBNull(0) Then
                factornumber = 1
            Else
                factornumber = (MyDataReader.Item(0))
            End If

        Loop

        MyDataReader.Close()
        OleDbCon.Close()
        OleDbCon.Dispose()

        strpublicinttostr = Me.stsconvertint.Text

        Dim frm As New rpt2
        frm.print(factornumber)
        frm.Show()

    End Sub

    Private Sub txtnumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) And txtnumber.Text <> "" Then
            txttotalprice.Focus()
        ElseIf (i = 3) And txtnumber.Text = "" Then
            txtsellprice.Focus()
        End If
    End Sub
    Private Sub lvwfactor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwfactor.SelectedIndexChanged
        selectit = True
    End Sub
    Private Sub txtsellprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtnumber.Focus()
        End If
    End Sub


    Private Sub txtsellprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsellprice.TextChanged
        If txtnumber.Text <> "" And txtsellprice.Text <> "" Then
            txttotalprice.Text = txtsellprice.Text * txtnumber.Text
        End If
    End Sub

    Private Sub txttotalprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdresume.Focus()
        End If
    End Sub

    Private Sub txtdescription_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdresume.Focus()
        End If
    End Sub

    Private Sub txtgrandtotal_MultilineChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtgrandtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrandtotal.TextChanged
        If txtgrandtotal.Text.Trim <> "" Then
            stsconvertint.Text = CStr(Adad(txtgrandtotal.Text) & " ريال")
        End If
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub mskdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskdate.TextChanged
        Dim factornumber As Integer = 0
        Dim datareader As OleDbDataReader


        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Try
            OleDbCon.Open()

            Dim OleCommand As OleDbCommand = New OleDbCommand
            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = "SELECT max(sell.factor) FROM sell"
            datareader = OleCommand.ExecuteReader
            Do While datareader.Read
                If datareader.IsDBNull(0) Then
                    factornumber = 1
                    txtfactor.Text = factornumber
                Else
                    factornumber = datareader.Item(0)
                    factornumber += 1
                    txtfactor.Text = factornumber

                End If
            Loop
        Catch
            MessageBox.Show("مشکلی در نمایش فرم پیش آمده لطفا از اول فرم را باز کنید")
        End Try
        OleDbCon.Close()
        OleDbCon.Dispose()
    End Sub

    Private Sub mskdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskdate.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtCustomerID.Focus()
        End If
    End Sub
    Private Sub txtnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumber.TextChanged
        If txtnumber.Text <> "" And txtsellprice.Text <> "" Then
            txttotalprice.Text = txtsellprice.Text * txtnumber.Text
        End If
    End Sub
    Private Sub txtcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged
        If txtcode.Text <> "" Then
            Dim SqlStr As String
            SqlStr = "Select num,buyprice,sellprice from goods where code_g = " & Val(txtcode.Text)
            FillTextBox(SqlStr)
            Try
                Cboname.SelectedValue = Val(txtcode.Text)
            Catch ex As Exception

            End Try
            'SqlStr = "Select name from company where code = (select company from goods where code = " & Val(txtcode.Text) & ")"
            ' FillTxtcompany(SqlStr)
        End If
    End Sub
    Private Sub txtcode_KeyDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            ' Cboname.SelectedValue = 0
            Cboname.SelectedValue = Val(txtcode.Text)
            Cboname.Focus()
        ElseIf e.KeyCode = Keys.Space Then
            txtcode.Clear()
        End If
    End Sub

    Private Sub Cboname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cboname.SelectedIndexChanged
        If Cboname.Text <> "" Then
            txtcode.Text = Cboname.SelectedValue.ToString
            'txtsellprice.Focus()
        End If
    End Sub


    Private Sub Cboname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cboname.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtsellprice.Focus()
        End If
    End Sub
    Private Sub txtCustomerID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCustomerName.SelectedValue = Val(txtCustomerID.Text)
            cboCustomerName.Focus()
        End If
    End Sub

    Private Sub cboCustomerName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCustomerName.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtcode.Focus()
        End If
    End Sub

    Private Sub cboCustomerName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerName.SelectedIndexChanged
        If cboCustomerName.Text <> "" Then
            txtCustomerID.Text = cboCustomerName.SelectedValue.ToString
            'txtsellprice.Focus()
        End If
    End Sub

    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged
        If txtCustomerID.Text <> "" Then
            Try
                cboCustomerName.SelectedValue = Val(txtCustomerID.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub tlp1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub txtcode_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcode.MouseMove
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "Select address from goods where code_g = " & Val(txtcode.Text)

        MyDataReader = OleCommand.ExecuteReader

        Do While MyDataReader.Read
            If MyDataReader.IsDBNull(0) Then
                tlp1.ToolTipTitle = ""
            Else
                tlp1.ToolTipTitle = (MyDataReader.Item(0))
            End If

        Loop

        MyDataReader.Close()
        OleDbCon.Close()
        OleDbCon.Dispose()
    End Sub

    Private Sub txtfactor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfactor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustomerID.Focus()
        End If
    End Sub


    Private Sub txtgoodsnametabsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgoodsnametabsearch.TextChanged
        Const MESSAGEBOX_CAPTION As String = "جستجو"

        With mydataset.Tables(0)
            .DefaultView.RowFilter = "name like '%" & txtgoodsnametabsearch.Text.Trim & "%'"

            If .DefaultView.Count = 0 Then

                MessageBox.Show("رکوردي با اين مشخصات وجود ندارد", _
                MESSAGEBOX_CAPTION, MessageBoxButtons.OK, _
                MessageBoxIcon.Information)

            End If
            datagridegoods.DataSource = .DefaultView

        End With
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub datagridegoods_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datagridegoods.DoubleClick
        Try
            Me.txtcode.Text = Me.datagridegoods.Item(datagridegoods.CurrentRowIndex, 0)
            TabControl1.SelectedTab = tabfactor
        Catch
            MsgBox("بر روی ردیف خالی کلیک نکنید", MsgBoxStyle.Information, "توجه")
        End Try
    End Sub

    Private Sub stsconvertint_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles stsconvertint.PanelClick

    End Sub

    Private Sub txtgrandtotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrandtotal.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txtbuyprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuyprice.TextChanged
        '  txtbuyprice.Text = FormatCurrency(txtbuyprice.Text)
    End Sub
End Class
