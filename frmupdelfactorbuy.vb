Imports System.Data.OleDb

Public Class frmupdelfactorbuy
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
    Friend WithEvents tlp1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents chk_account As System.Windows.Forms.CheckBox
    Friend WithEvents cboSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents mskdate As System.Windows.Forms.MaskedTextBox
    Private WithEvents txtfactor As System.Windows.Forms.TextBox
    Friend WithEvents Shamsi As AxKKRtarikh.AxShamsi
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cboname As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stsconvertint As System.Windows.Forms.StatusBar
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdresume As System.Windows.Forms.Button
    Friend WithEvents txtNumberPresent As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvwfactor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmupdelfactorbuy))
        Me.tlp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.chk_account = New System.Windows.Forms.CheckBox
        Me.cboSupplierName = New System.Windows.Forms.ComboBox
        Me.mskdate = New System.Windows.Forms.MaskedTextBox
        Me.txtfactor = New System.Windows.Forms.TextBox
        Me.Shamsi = New AxKKRtarikh.AxShamsi
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtgrandtotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cboname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSupplierID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.stsconvertint = New System.Windows.Forms.StatusBar
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdresume = New System.Windows.Forms.Button
        Me.txtNumberPresent = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lvwfactor = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp1
        '
        Me.tlp1.IsBalloon = True
        Me.tlp1.StripAmpersands = True
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.Location = New System.Drawing.Point(643, 78)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(96, 22)
        Me.txtcode.TabIndex = 163
        Me.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tlp1.SetToolTip(Me.txtcode, "مکان جنس در انبار")
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(14, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(725, 2)
        Me.Label14.TabIndex = 162
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Info
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(386, 457)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 23)
        Me.cmdExit.TabIndex = 161
        Me.cmdExit.Text = "خروج"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Info
        Me.cmdSave.BackgroundImage = CType(resources.GetObject("cmdSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(558, 457)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 23)
        Me.cmdSave.TabIndex = 159
        Me.cmdSave.Text = "ذخيره"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'chk_account
        '
        Me.chk_account.AutoSize = True
        Me.chk_account.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk_account.Location = New System.Drawing.Point(447, 488)
        Me.chk_account.Name = "chk_account"
        Me.chk_account.Size = New System.Drawing.Size(105, 20)
        Me.chk_account.TabIndex = 158
        Me.chk_account.Text = "انجام حسابداری"
        Me.chk_account.UseVisualStyleBackColor = True
        '
        'cboSupplierName
        '
        Me.cboSupplierName.BackColor = System.Drawing.SystemColors.Info
        Me.cboSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSupplierName.Location = New System.Drawing.Point(14, 9)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboSupplierName.Size = New System.Drawing.Size(247, 24)
        Me.cboSupplierName.TabIndex = 157
        '
        'mskdate
        '
        Me.mskdate.BackColor = System.Drawing.SystemColors.Info
        Me.mskdate.Enabled = False
        Me.mskdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskdate.Location = New System.Drawing.Point(625, 13)
        Me.mskdate.Mask = "13##/##/##"
        Me.mskdate.Name = "mskdate"
        Me.mskdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mskdate.Size = New System.Drawing.Size(85, 22)
        Me.mskdate.TabIndex = 124
        '
        'txtfactor
        '
        Me.txtfactor.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactor.Enabled = False
        Me.txtfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfactor.Location = New System.Drawing.Point(455, 11)
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Size = New System.Drawing.Size(81, 22)
        Me.txtfactor.TabIndex = 156
        Me.txtfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Shamsi
        '
        Me.Shamsi.Enabled = True
        Me.Shamsi.Location = New System.Drawing.Point(386, 458)
        Me.Shamsi.Name = "Shamsi"
        Me.Shamsi.OcxState = CType(resources.GetObject("Shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Shamsi.Size = New System.Drawing.Size(80, 17)
        Me.Shamsi.TabIndex = 155
        Me.Shamsi.Visible = False
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(265, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(53, 37)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "نام تهیه کننده"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(143, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(56, 19)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "تعداد خرید"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtgrandtotal.Location = New System.Drawing.Point(13, 458)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(195, 22)
        Me.txtgrandtotal.TabIndex = 151
        Me.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(208, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "مجموع کل"
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(293, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "في فروش"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(507, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "نام کالا"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cboname
        '
        Me.Cboname.BackColor = System.Drawing.SystemColors.Info
        Me.Cboname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cboname.Location = New System.Drawing.Point(455, 77)
        Me.Cboname.Name = "Cboname"
        Me.Cboname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cboname.Size = New System.Drawing.Size(182, 24)
        Me.Cboname.TabIndex = 140
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "قيمت کل"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(205, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "تعداد موجود"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSupplierID.Location = New System.Drawing.Point(325, 11)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSupplierID.Size = New System.Drawing.Size(71, 22)
        Me.txtSupplierID.TabIndex = 130
        Me.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(705, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(30, 24)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "تاريخ"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "شماره فاکتور"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(395, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "کد تهیه کننده"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stsconvertint
        '
        Me.stsconvertint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.stsconvertint.Location = New System.Drawing.Point(0, 516)
        Me.stsconvertint.Name = "stsconvertint"
        Me.stsconvertint.Size = New System.Drawing.Size(751, 16)
        Me.stsconvertint.TabIndex = 129
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.SystemColors.Info
        Me.cmdcancel.BackgroundImage = CType(resources.GetObject("cmdcancel.BackgroundImage"), System.Drawing.Image)
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(472, 457)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 23)
        Me.cmdcancel.TabIndex = 128
        Me.cmdcancel.Text = "انصراف"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.SystemColors.Info
        Me.cmddelete.BackgroundImage = CType(resources.GetObject("cmddelete.BackgroundImage"), System.Drawing.Image)
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(558, 486)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(88, 23)
        Me.cmddelete.TabIndex = 127
        Me.cmddelete.Text = "حذف"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.SystemColors.Info
        Me.cmdupdate.BackgroundImage = CType(resources.GetObject("cmdupdate.BackgroundImage"), System.Drawing.Image)
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(652, 486)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 23)
        Me.cmdupdate.TabIndex = 126
        Me.cmdupdate.Text = "تغيير"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdresume
        '
        Me.cmdresume.BackColor = System.Drawing.SystemColors.Info
        Me.cmdresume.BackgroundImage = CType(resources.GetObject("cmdresume.BackgroundImage"), System.Drawing.Image)
        Me.cmdresume.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdresume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdresume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdresume.Location = New System.Drawing.Point(652, 457)
        Me.cmdresume.Name = "cmdresume"
        Me.cmdresume.Size = New System.Drawing.Size(88, 23)
        Me.cmdresume.TabIndex = 125
        Me.cmdresume.Text = "ادامه"
        Me.cmdresume.UseVisualStyleBackColor = False
        '
        'txtNumberPresent
        '
        Me.txtNumberPresent.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumberPresent.Enabled = False
        Me.txtNumberPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNumberPresent.Location = New System.Drawing.Point(206, 77)
        Me.txtNumberPresent.Name = "txtNumberPresent"
        Me.txtNumberPresent.Size = New System.Drawing.Size(66, 22)
        Me.txtNumberPresent.TabIndex = 149
        Me.txtNumberPresent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(383, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "في خريد"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbuyprice
        '
        Me.txtbuyprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtbuyprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtbuyprice.Location = New System.Drawing.Point(369, 77)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.Size = New System.Drawing.Size(80, 22)
        Me.txtbuyprice.TabIndex = 147
        Me.txtbuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsellprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsellprice.Location = New System.Drawing.Point(278, 77)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.Size = New System.Drawing.Size(85, 22)
        Me.txtsellprice.TabIndex = 143
        Me.txtsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalprice
        '
        Me.txttotalprice.BackColor = System.Drawing.SystemColors.Info
        Me.txttotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txttotalprice.Location = New System.Drawing.Point(12, 77)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(120, 22)
        Me.txttotalprice.TabIndex = 137
        Me.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(138, 77)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(63, 22)
        Me.txtnumber.TabIndex = 136
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(669, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = " کد کالا"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvwfactor
        '
        Me.lvwfactor.BackColor = System.Drawing.SystemColors.Info
        Me.lvwfactor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader1})
        Me.lvwfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lvwfactor.FullRowSelect = True
        Me.lvwfactor.GridLines = True
        Me.lvwfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvwfactor.LabelEdit = True
        Me.lvwfactor.LabelWrap = False
        Me.lvwfactor.Location = New System.Drawing.Point(13, 107)
        Me.lvwfactor.Name = "lvwfactor"
        Me.lvwfactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lvwfactor.RightToLeftLayout = True
        Me.lvwfactor.Size = New System.Drawing.Size(727, 344)
        Me.lvwfactor.TabIndex = 165
        Me.lvwfactor.UseCompatibleStateImageBehavior = False
        Me.lvwfactor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "کد کالا"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "نام کالا"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 187
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
        Me.ColumnHeader8.Width = 65
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "قيمت کل"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 191
        '
        'frmupdelfactorbuy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(751, 532)
        Me.Controls.Add(Me.lvwfactor)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.chk_account)
        Me.Controls.Add(Me.cboSupplierName)
        Me.Controls.Add(Me.mskdate)
        Me.Controls.Add(Me.txtfactor)
        Me.Controls.Add(Me.Shamsi)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtgrandtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Cboname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stsconvertint)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdresume)
        Me.Controls.Add(Me.txtNumberPresent)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbuyprice)
        Me.Controls.Add(Me.txtsellprice)
        Me.Controls.Add(Me.txttotalprice)
        Me.Controls.Add(Me.txtnumber)
        Me.MaximizeBox = False
        Me.Name = "frmupdelfactorbuy"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اعمال تغییرات در فاکتور خرید"
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim SaveOrEdit As String = ""
    Dim selectit As Boolean = False
    Dim strnumber As String
    Dim errinsert As Integer = 0
    Dim erredit As Integer = 0
    Public strupdatelist As String
    Public editnumber As Integer = 0
    Public editcode As Integer = 0
    Public strfilllst As String = ""

    Private Function cleartextboxes()
        ' txtdob.Clear()
        txtfactor.Clear()
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

        'Try
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
    Private Function fillcomboSupplierName()
        Dim myOleDbDataAdapter As OleDbDataAdapter
        Dim myDataTable As DataTable = New DataTable
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

        OleDbCon.Open()

        Try
            myOleDbDataAdapter = New OleDbDataAdapter("select code_s,name from Suppliers order by name", _
                OleDbCon)

            myDataTable.Clear()

            myOleDbDataAdapter.Fill(myDataTable)
            cboSupplierName.DataSource = myDataTable
            cboSupplierName.ValueMember = "code_s"
            cboSupplierName.DisplayMember = "name"

        Catch
            MsgBox("Error Opening {0}", OleDbCon.DataSource)
        End Try

        OleDbCon.Close()
        OleDbCon.Dispose()
    End Function
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
  
    Public Function filllst(ByVal strsql As String)

        Dim summoney As Long = 0
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand

        strfilllst = strsql

        lvwfactor.Items.Clear()
        lvwfactor.Sorting = SortOrder.Ascending

        olecommand.CommandText = strsql
        olecommand.Connection = OleDbCon
        Try
            OleDbCon.Open()
            Dim datareader As OleDbDataReader
            datareader = olecommand.ExecuteReader

            While datareader.Read
                Dim lvi As New ListViewItem
                lvi.Text = CStr(datareader("code_g"))

                lvi.SubItems.Add(CStr(datareader("goods.name")))
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
                txtSupplierID.Text = datareader("code_s")
                cboSupplierName.Text = datareader("Suppliers.name")

            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            OleDbCon.Close()
        End Try
    End Function
    Private Function selectnum(ByVal code As Integer, ByRef number As Integer)

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT goods.num FROM goods WHERE code_g= " & code
        Try
            number = OleCommand.ExecuteScalar

        Catch err As System.Exception

            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

        If (txtcode.Text = "") Then
            txtcode.Focus()
        Else
            txtnumber.Focus()

        End If
    End Function
    Private Function updatenum(ByVal code As Integer, ByVal number As Integer)

        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim olecommand As New OleDbCommand

        olecommand.CommandText = "UPDATE goods SET num = " & number & " WHERE code_g= " & code
        olecommand.Connection = oledbcon

        olecommand.ExecuteNonQuery()
        oledbcon.Close()
        oledbcon.Dispose()

    End Function
    Private Function addnew()
        Try
            Dim oledbcon As New OleDbConnection(strcon)
            oledbcon.Open()
            Dim olecommand As New OleDbCommand

            olecommand.CommandText = "Insert Into buy " _
                & "(dob,factor,code_s,code_g,buyprice,sellprice,num,sumprice) " _
                & "Values (" _
                & "'" & mskdate.Text & "' , " _
                & "'" & txtfactor.Text & "' , " _
                & "'" & txtSupplierID.Text & "' , " _
                & "'" & txtcode.Text & "' , " _
                & "'" & txtbuyprice.Text & "' , " _
                & "'" & txtsellprice.Text & "' , " _
                & "'" & txtnumber.Text & "' , " _
                & "'" & txttotalprice.Text & "')"

            olecommand.Connection = oledbcon

            olecommand.ExecuteNonQuery()
            oledbcon.Close()
            oledbcon.Dispose()
        Catch
            errinsert = 1
        End Try
    End Function
    Private Function deleteitem()
        Dim summoney As Long = CInt(txtgrandtotal.Text)
        Dim intcode As Integer
        Dim intfactor As Integer = CInt(txtfactor.Text)
        Dim intnumber As Integer

        Dim lvi As New ListViewItem

        Dim OleDbCon As New OleDbConnection(strcon)
        Dim olecommand As New OleDbCommand

        Dim oledbcon2 As New OleDbConnection(strcon)
        Dim olecommand2 As New OleDbCommand

        Dim oledbcon3 As New OleDbConnection(strcon)
        Dim olecommand3 As New OleDbCommand


        For Each lvi In lvwfactor.SelectedItems

            intcode = lvi.SubItems(0).Text
            ' str0number = lvi.SubItems(1).Text

            summoney -= CInt(lvi.SubItems(5).Text)



            olecommand.CommandText = "delete from buy where factor=" & intfactor & " and code_g = " & intcode
            olecommand.Connection = OleDbCon

            olecommand2.CommandText = "SELECT num FROM goods WHERE code_g=" & intcode
            olecommand2.Connection = oledbcon2


            oledbcon2.Open()
            intnumber = olecommand2.ExecuteScalar
            oledbcon2.Close()
            intnumber -= CInt(lvi.SubItems(4).Text)

            olecommand3.CommandText = "UPDATE goods SET num= " & intnumber & " WHERE code_g= " & intcode
            olecommand3.Connection = oledbcon3

            Try



                OleDbCon.Open()
                olecommand.ExecuteNonQuery()


                oledbcon3.Open()
                olecommand3.ExecuteNonQuery()
                oledbcon3.Close()


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
            MsgBox("شما ابتدا باید یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
            Exit Function
        End If
        Try


            Dim olecommand As New OleDbCommand

            olecommand.CommandText = "Update buy Set " _
             & "dob='" & mskdate.Text & "', " _
             & "factor='" & txtfactor.Text & "', " _
             & "code_s='" & txtSupplierID.Text & "', " _
             & "code_g='" & txtcode.Text & "', " _
             & "buyprice='" & txtbuyprice.Text & "', " _
             & "sellprice='" & txtsellprice.Text & "', " _
             & "num='" & txtnumber.Text & "', " _
             & "sumprice='" & txttotalprice.Text & "' " _
             & "WHERE factor = " & txtfactor.Text & " and code_g=" & editcode

            olecommand.Connection = OleDbCon
            OleDbCon.Open()
            olecommand.ExecuteNonQuery()
        Catch
            erredit = 1
        Finally
            OleDbCon.Close()
            selectit = False

        End Try
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcomboname()
        fillcomboSupplierName()

        txtcode.TabIndex = 0
        txtcode.Focus()

        txtSupplierID.Text = codeSupplier
        'cleartextboxes()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If SaveOrEdit = "Save" Then
            If Me.Cboname.Text <> "" And Me.txtnumber.Text <> "" And Me.txtsellprice.Text <> "" And Me.txttotalprice.Text <> "" And Len(mskdate.Text) = 10 Then

                Dim number As Integer = 0

                selectnum(txtcode.Text, number)

                number += CInt(txtnumber.Text)

                If number >= 0 Then
                    If errinsert = 0 Then
                        updatenum(txtcode.Text, number)
                        addnew()
                        cleartextboxes()
                    Else
                        MessageBox.Show("این رکورد با این شماره فاکتور قبلا در جدول ثبت شده است")
                    End If

                Else
                    MessageBox.Show("تعداد درخواستی بیش از تعداد موجود در انبار است")
                End If
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")


            End If



        ElseIf SaveOrEdit = "Edit" Then

            If Me.Cboname.Text <> "" And Me.txtnumber.Text <> "" And Me.txtsellprice.Text <> "" And Me.txttotalprice.Text <> "" And Len(mskdate.Text) = 10 Then
                Dim number2 As Integer = 0


                updatenum(editcode, editnumber)

                selectnum(txtcode.Text, number2)
                number2 += CInt(txtnumber.Text)

                If number2 >= 0 Then
                    If erredit = 0 Then
                        updatenum(txtcode.Text, number2)
                        updateitem()
                        'cleartextboxes()
                    Else
                        MessageBox.Show("این رکورد با این شماره فاکتور قبلا در جدول ثبت شده است")
                    End If

                Else
                    MessageBox.Show("تعداد درخواست بيشتر از موجودي انبار مي باشد بنا براين اطلاعات قبلي ثبت ميشود.")
                    editnumber += CInt(strnumber)
                    updatenum(editcode, editnumber)
                End If

                ' deleteitem()
                ' addnew()
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")

            End If


        Else

            Me.Text = "هیچ گونه اطلاعاتی دخیره نشده است"

        End If

        filllst(strfilllst)

        cmdresume.Enabled = True
        cmdupdate.Enabled = True
        cmddelete.Enabled = True

        txtcode.TabIndex = 0
        txtcode.Focus()

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


    Private Sub cmdresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresume.Click
        SaveOrEdit = "Save"

        mskdate.TabIndex = 0
        txtcode.Focus()

        cmdupdate.Enabled = False
        cmddelete.Enabled = False
        cmdresume.Enabled = False

        Me.cmdSave.Focus()


    End Sub

    Private Sub Cboname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cboname.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtbuyprice.Focus()
        End If
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

    Private Sub Cboname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cboname.SelectedValueChanged

        ' MessageBox.Show("شما در اين فرم در حالت تغيير نمي توايند ليست را دستکاري کنيد." & " فقط در فرم فروش و خريد اينکار امکان پذير است\n.")
        If Cboname.Text <> "" Then
            txtcode.Text = Cboname.SelectedValue.ToString
            'txtbuyprice.Focus()
        End If
    End Sub

    Private Sub lvwfactor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwfactor.SelectedIndexChanged
        selectit = True
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        deleteitem()
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

    Private Sub lvwfactor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwfactor.KeyDown
        If e.KeyCode <> Keys.Delete Then Exit Sub
        deleteitem()
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

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click

        Dim number1 As Integer = 0

        SaveOrEdit = "Edit"

        If selectit = False Then
            MsgBox("شما ابتدا باید یک سطر را انتخاب کنید", MsgBoxStyle.Critical, "انتخاب")
            Exit Sub
        End If


        Dim strcode As Integer = lvwfactor.SelectedItems(0).SubItems(0).Text
        Dim strname As String = lvwfactor.SelectedItems(0).SubItems(1).Text
        Dim strbuyprice As String = lvwfactor.SelectedItems(0).SubItems(2).Text
        Dim strsellprice As String = lvwfactor.SelectedItems(0).SubItems(3).Text
        Dim strnumber As String = lvwfactor.SelectedItems(0).SubItems(4).Text
        Dim strsumprice As String = lvwfactor.SelectedItems(0).SubItems(5).Text

        txtcode.Text = strcode
        Cboname.Text = strname
        txtbuyprice.Text = strbuyprice
        txtsellprice.Text = strsellprice
        txtnumber.Text = strnumber
        txttotalprice.Text = strsumprice

        number1 = CInt(strnumber)
        selectnum(txtcode.Text, editnumber)
        editnumber -= CInt(number1)
        editcode = txtcode.Text

        cmdresume.Enabled = False
        cmddelete.Enabled = False

    End Sub

    Private Sub txtsellprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtnumber.Focus()
        End If
    End Sub
    Private Sub txtsellprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsellprice.TextChanged

    End Sub

    Private Sub txttotalprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdresume.Focus()
        End If
    End Sub


    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrEdit = "Cancel"

        cmdresume.Enabled = True
        cmddelete.Enabled = True
        cmdupdate.Enabled = True

    End Sub

    Private Sub txtgrandtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrandtotal.TextChanged
        If txtgrandtotal.Text.Trim <> "" Then
            stsconvertint.Text = CStr(Adad(txtgrandtotal.Text) & " ريال")
        End If

    End Sub

    Private Sub txtnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumber.TextChanged
        If txtnumber.Text <> "" And txtsellprice.Text <> "" Then
            txttotalprice.Text = txtbuyprice.Text * txtnumber.Text
        End If
    End Sub
    Private Sub txtSupplierID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierID.TextChanged
        If txtSupplierID.Text <> "" Then
            Try
                cboSupplierName.SelectedValue = Val(txtSupplierID.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub cboSupplierName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplierName.SelectedValueChanged
        If cboSupplierName.Text <> "" Then
            txtSupplierID.Text = cboSupplierName.SelectedValue.ToString
            'txtsellprice.Focus()
        End If
    End Sub

    Private Sub txtbuyprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuyprice.TextChanged
        If txtnumber.Text <> "" And txtbuyprice.Text <> "" Then
            txttotalprice.Text = txtbuyprice.Text * txtnumber.Text
        End If
    End Sub

    Private Sub txtbuyprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuyprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtsellprice.Focus()
        End If
    End Sub

    Private Sub chk_account_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_account.CheckedChanged
        Dim str As String = "بابت فاکتور خرید شماره " & txtfactor.Text & ""

        If chk_account.Checked = True Then
            Dim frm As New frmSupp_transactions2

            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            Dim OleDbCon2 As OleDbConnection = New OleDbConnection(strcon)
            Dim dr As OleDbDataReader
            Dim i As Integer = 0
            OleDbCon.Open()
            OleDbCon2.Open()

            Dim OleCommand As OleDbCommand = New OleDbCommand
            Dim MyOledbCommand As OleDbCommand = New OleDbCommand

            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = "SELECT key,supp_transactions.SupplierID, supp_transactions.notes, supp_transactions.date, supp_transactions.debtor, supp_transactions.creditor" & _
            " FROM supp_transactions where supp_transactions.notes ='" & str & " '"
            '"بابت فاکتور فروش شماره" + txtfactor.Text + ""

            dr = OleCommand.ExecuteReader
            While dr.Read
                If dr(5) <> 0 Then
                    frm.mskcreditor.Text = dr(5)
                End If
                MyOledbCommand.CommandText = "DELETE FROM supp_transactions WHERE key=" & dr(0)
                MyOledbCommand.Connection = OleDbCon2
                MyOledbCommand.ExecuteNonQuery()
            End While

            frm.txtSupplierID.Text = txtSupplierID.Text
            frm.txtsuppliername.Text = cboSupplierName.Text
            frm.txtnotes.Text = "بابت فاکتور خرید شماره " + txtfactor.Text
            frm.mskdate.Text = mskdate.Text
            frm.mskdebtor.Text = txtgrandtotal.Text

            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtNumberPresent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumberPresent.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txtgrandtotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrandtotal.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub
End Class


