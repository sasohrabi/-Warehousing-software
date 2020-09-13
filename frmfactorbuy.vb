Imports System.String
Imports System.Data.OleDb
Imports System.Windows.Forms.MaskedTextBox


Public Class frmfactorbuy
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
    Friend WithEvents stsconvertint As System.Windows.Forms.StatusBar
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdresume As System.Windows.Forms.Button
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents cmddate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumberPresent As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtrow As System.Windows.Forms.TextBox
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cboname As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tlp1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Shamsi As AxKKRtarikh.AxShamsi
    Private WithEvents txtfactor As System.Windows.Forms.TextBox
    Friend WithEvents mskdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents chk_account As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdnewfactor As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lvwfactor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfactorbuy))
        Me.stsconvertint = New System.Windows.Forms.StatusBar
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdresume = New System.Windows.Forms.Button
        Me.txtSupplierID = New System.Windows.Forms.TextBox
        Me.cmddate = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNumberPresent = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.txtrow = New System.Windows.Forms.TextBox
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cboname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgrandtotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tlp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Shamsi = New AxKKRtarikh.AxShamsi
        Me.txtfactor = New System.Windows.Forms.TextBox
        Me.mskdate = New System.Windows.Forms.MaskedTextBox
        Me.cboSupplierName = New System.Windows.Forms.ComboBox
        Me.chk_account = New System.Windows.Forms.CheckBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdnewfactor = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.lvwfactor = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsconvertint
        '
        Me.stsconvertint.Location = New System.Drawing.Point(0, 516)
        Me.stsconvertint.Name = "stsconvertint"
        Me.stsconvertint.Size = New System.Drawing.Size(876, 16)
        Me.stsconvertint.TabIndex = 78
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.SystemColors.Info
        Me.cmdcancel.BackgroundImage = CType(resources.GetObject("cmdcancel.BackgroundImage"), System.Drawing.Image)
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(600, 457)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 23)
        Me.cmdcancel.TabIndex = 75
        Me.cmdcancel.Text = "انصراف"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.SystemColors.Info
        Me.cmddelete.BackgroundImage = CType(resources.GetObject("cmddelete.BackgroundImage"), System.Drawing.Image)
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(686, 486)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(88, 23)
        Me.cmddelete.TabIndex = 72
        Me.cmddelete.Text = "حذف"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.SystemColors.Info
        Me.cmdupdate.BackgroundImage = CType(resources.GetObject("cmdupdate.BackgroundImage"), System.Drawing.Image)
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(780, 486)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 23)
        Me.cmdupdate.TabIndex = 71
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
        Me.cmdresume.Location = New System.Drawing.Point(780, 457)
        Me.cmdresume.Name = "cmdresume"
        Me.cmdresume.Size = New System.Drawing.Size(88, 23)
        Me.cmdresume.TabIndex = 61
        Me.cmdresume.Text = "ادامه"
        Me.cmdresume.UseVisualStyleBackColor = False
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSupplierID.Location = New System.Drawing.Point(375, 11)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSupplierID.Size = New System.Drawing.Size(71, 22)
        Me.txtSupplierID.TabIndex = 83
        Me.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmddate
        '
        Me.cmddate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddate.Location = New System.Drawing.Point(724, 11)
        Me.cmddate.Name = "cmddate"
        Me.cmddate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmddate.Size = New System.Drawing.Size(16, 22)
        Me.cmddate.TabIndex = 89
        Me.cmddate.Text = ">"
        Me.cmddate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(834, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(30, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "تاريخ"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(619, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "شماره فاکتور"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(452, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "کد تهیه کننده"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(205, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "تعداد موجود"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumberPresent
        '
        Me.txtNumberPresent.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumberPresent.Enabled = False
        Me.txtNumberPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNumberPresent.Location = New System.Drawing.Point(206, 77)
        Me.txtNumberPresent.Name = "txtNumberPresent"
        Me.txtNumberPresent.Size = New System.Drawing.Size(66, 22)
        Me.txtNumberPresent.TabIndex = 109
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
        Me.Label12.TabIndex = 108
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
        Me.txtbuyprice.TabIndex = 107
        Me.txtbuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtrow
        '
        Me.txtrow.BackColor = System.Drawing.SystemColors.Info
        Me.txtrow.Enabled = False
        Me.txtrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtrow.Location = New System.Drawing.Point(826, 80)
        Me.txtrow.Name = "txtrow"
        Me.txtrow.Size = New System.Drawing.Size(40, 22)
        Me.txtrow.TabIndex = 105
        Me.txtrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsellprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsellprice.Location = New System.Drawing.Point(278, 77)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.Size = New System.Drawing.Size(85, 22)
        Me.txtsellprice.TabIndex = 103
        Me.txtsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalprice
        '
        Me.txttotalprice.BackColor = System.Drawing.SystemColors.Info
        Me.txttotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txttotalprice.Location = New System.Drawing.Point(12, 77)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(120, 22)
        Me.txttotalprice.TabIndex = 96
        Me.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(138, 77)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(63, 22)
        Me.txtnumber.TabIndex = 95
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.Location = New System.Drawing.Point(770, 80)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(51, 22)
        Me.txtcode.TabIndex = 94
        Me.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tlp1.SetToolTip(Me.txtcode, "مکان جنس در انبار")
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(827, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "رديف"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(293, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "في فروش"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(571, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 101
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
        Me.Cboname.Size = New System.Drawing.Size(309, 24)
        Me.Cboname.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "قيمت کل"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(768, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = " کد کالا"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtgrandtotal.Location = New System.Drawing.Point(13, 458)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(195, 22)
        Me.txtgrandtotal.TabIndex = 111
        Me.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(208, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "مجموع کل"
        '
        'tlp1
        '
        Me.tlp1.IsBalloon = True
        Me.tlp1.StripAmpersands = True
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(293, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(74, 23)
        Me.Label15.TabIndex = 114
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
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "تعداد خرید"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shamsi
        '
        Me.Shamsi.Enabled = True
        Me.Shamsi.Location = New System.Drawing.Point(428, 460)
        Me.Shamsi.Name = "Shamsi"
        Me.Shamsi.OcxState = CType(resources.GetObject("Shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Shamsi.Size = New System.Drawing.Size(80, 17)
        Me.Shamsi.TabIndex = 115
        Me.Shamsi.Visible = False
        '
        'txtfactor
        '
        Me.txtfactor.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactor.Enabled = False
        Me.txtfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfactor.Location = New System.Drawing.Point(541, 11)
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Size = New System.Drawing.Size(81, 22)
        Me.txtfactor.TabIndex = 116
        Me.txtfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskdate
        '
        Me.mskdate.BackColor = System.Drawing.SystemColors.Info
        Me.mskdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.mskdate.Location = New System.Drawing.Point(743, 11)
        Me.mskdate.Mask = "13##/##/##"
        Me.mskdate.Name = "mskdate"
        Me.mskdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskdate.Size = New System.Drawing.Size(85, 22)
        Me.mskdate.TabIndex = 1
        '
        'cboSupplierName
        '
        Me.cboSupplierName.BackColor = System.Drawing.SystemColors.Info
        Me.cboSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSupplierName.Location = New System.Drawing.Point(14, 9)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboSupplierName.Size = New System.Drawing.Size(273, 24)
        Me.cboSupplierName.TabIndex = 118
        '
        'chk_account
        '
        Me.chk_account.AutoSize = True
        Me.chk_account.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk_account.Location = New System.Drawing.Point(575, 490)
        Me.chk_account.Name = "chk_account"
        Me.chk_account.Size = New System.Drawing.Size(105, 20)
        Me.chk_account.TabIndex = 119
        Me.chk_account.Text = "انجام حسابداری"
        Me.chk_account.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Info
        Me.cmdSave.BackgroundImage = CType(resources.GetObject("cmdSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(686, 457)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 23)
        Me.cmdSave.TabIndex = 120
        Me.cmdSave.Text = "ذخيره"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdnewfactor
        '
        Me.cmdnewfactor.BackColor = System.Drawing.SystemColors.Info
        Me.cmdnewfactor.BackgroundImage = CType(resources.GetObject("cmdnewfactor.BackgroundImage"), System.Drawing.Image)
        Me.cmdnewfactor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdnewfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdnewfactor.Location = New System.Drawing.Point(514, 457)
        Me.cmdnewfactor.Name = "cmdnewfactor"
        Me.cmdnewfactor.Size = New System.Drawing.Size(80, 23)
        Me.cmdnewfactor.TabIndex = 121
        Me.cmdnewfactor.Text = "ثبت فاکتور"
        Me.cmdnewfactor.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Info
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(428, 457)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 23)
        Me.cmdExit.TabIndex = 122
        Me.cmdExit.Text = "خروج"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(14, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(850, 2)
        Me.Label14.TabIndex = 123
        '
        'lvwfactor
        '
        Me.lvwfactor.BackColor = System.Drawing.SystemColors.Info
        Me.lvwfactor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader1})
        Me.lvwfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lvwfactor.FullRowSelect = True
        Me.lvwfactor.GridLines = True
        Me.lvwfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvwfactor.LabelEdit = True
        Me.lvwfactor.LabelWrap = False
        Me.lvwfactor.Location = New System.Drawing.Point(12, 108)
        Me.lvwfactor.Name = "lvwfactor"
        Me.lvwfactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lvwfactor.RightToLeftLayout = True
        Me.lvwfactor.Size = New System.Drawing.Size(852, 344)
        Me.lvwfactor.TabIndex = 124
        Me.lvwfactor.UseCompatibleStateImageBehavior = False
        Me.lvwfactor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "رديف"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 39
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
        Me.ColumnHeader8.Text = "تعداد خرید"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 140
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "قيمت کل"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 112
        '
        'frmfactorbuy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(876, 532)
        Me.Controls.Add(Me.lvwfactor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdnewfactor)
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
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumberPresent)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbuyprice)
        Me.Controls.Add(Me.txtrow)
        Me.Controls.Add(Me.txtsellprice)
        Me.Controls.Add(Me.txttotalprice)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Cboname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.cmddate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stsconvertint)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdresume)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmfactorbuy"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت فاکتور خرید"
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Dim SaveOrEdit As String = ""
    Dim selectit As Boolean = False

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

            MyDataReader.Close()
            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

    End Function
    Public Function filllst()
        Dim summoney As Long = 0
        Dim strsql As String = "select * from tempbuy order by row desc"
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
                txtSupplierID.Text = datareader("code_s")
                cboSupplierName.Text = datareader("name_s")
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
        OleCommand.CommandText = "SELECT max(tempbuy.row) FROM tempbuy"

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
        If check_factor_exist(txtfactor.Text, txtcode.Text) Then
            Try
                Dim oledbcon As New OleDbConnection(strcon)
                oledbcon.Open()
                Dim olecommand As New OleDbCommand

                olecommand.CommandText = "Insert Into tempbuy " _
                    & "(row,dob,factor,code_s,name_s,code_g,name_g,buyprice,sellprice,num,sumprice) " _
                    & "Values (" _
                    & "'" & txtrow.Text & "' , " _
                    & "'" & mskdate.Text & "' , " _
                    & "'" & txtfactor.Text & "' , " _
                    & "'" & txtSupplierID.Text & "' , " _
                    & "'" & cboSupplierName.Text & "' , " _
                    & "'" & txtcode.Text & "' , " _
                    & "'" & Cboname.Text & "' , " _
                    & "'" & txtbuyprice.Text & "' , " _
                    & "'" & txtsellprice.Text & "' , " _
                    & "'" & txtnumber.Text & "' , " _
                    & "'" & txttotalprice.Text & "')"


                olecommand.Connection = oledbcon

                olecommand.ExecuteNonQuery()
                oledbcon.Close()
                oledbcon.Dispose()

            Catch
                MessageBox.Show("این رکورد قبلا ثبت شده است")
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

            olecommand.CommandText = "delete from tempbuy where row=" & strid
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


            olecommand.CommandText = "Update tempbuy Set " _
                              & "dob='" & mskdate.Text & "', " _
                              & "factor='" & txtfactor.Text & "', " _
                              & "code_s='" & txtSupplierID.Text & "', " _
                              & "name_s='" & cboSupplierName.Text & "', " _
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
        OleCommand.CommandText = "SELECT count(*) FROM buy where factor=" & code_factor & " and code_g =" & code_goods

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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcomboname()
        filllst()
        fillcomboSupplierName()


        'cleartextboxes()

    End Sub

    Private Sub cmdExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdnewfactor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewfactor.Click

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
            OleCommand1.CommandText = "SELECT row,code_g,num,dob,buyprice,sellprice FROM tempbuy"

            Dim mydatareader2 As OleDbDataReader
            Dim olecommand2 As New OleDbCommand
            olecommand2.CommandText = "SELECT goods.num FROM goods WHERE code_g=?"
            olecommand2.Connection = (oledbcon2)

            Dim olecommand3 As New OleDbCommand
            olecommand3.Connection = (oledbcon3)

            Dim olecommand4 As New OleDbCommand
            olecommand4.CommandText = "INSERT INTO buy ( dob, factor, code_s, code_g, buyprice, sellprice, num, sumprice)" & _
            "SELECT dob, factor,code_s,code_g,buyprice, sellprice, num, sumprice " & _
            "FROM tempbuy WHERE row=?"
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

                number += CInt(MyDataReader1.Item(2))

                If number >= 0 Then
                    oledbcon3.Open()
                    olecommand3.CommandText = "UPDATE goods SET num = " & number _
                     & " ,dob='" & MyDataReader1.Item(3) & "'" & " ,buyprice=" & MyDataReader1.Item(4) & _
                     " ,sellprice=" & MyDataReader1.Item(5) & " WHERE code_g= " & MyDataReader1.Item(1)

                    olecommand3.ExecuteNonQuery()
                    oledbcon3.Close()

                    olecommand4.Parameters.Add("row", Data.OleDb.OleDbType.Integer)
                    olecommand4.Parameters("row").Value = MyDataReader1.Item(0)

                    oledbcon4.Open()
                    olecommand4.ExecuteNonQuery()
                    oledbcon4.Close()

                    oledbcon5.Open()
                    olecommand5.CommandText = "DELETE FROM tempbuy WHERE row=" & MyDataReader1.Item(0)
                    olecommand5.ExecuteNonQuery()
                    oledbcon5.Close()

                Else
                    MessageBox.Show("اشتباه در فاکتور رخ داده ")
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
            Dim frm As New frmSupp_transactions2
            frm.txtSupplierID.Text = txtSupplierID.Text
            frm.txtsuppliername.Text = cboSupplierName.Text
            frm.txtnotes.Text = "بابت فاکتور خرید شماره " + txtfactor.Text
            frm.mskdate.Text = mskdate.Text
            frm.mskcreditor.Text = txtgrandtotal.Text
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

    Private Sub cmdresume_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresume.Click
        SaveOrEdit = "Save"
        fixrow()
        'mskdate.TabIndex = 0
        cmdSave.Focus()

        cmdupdate.Enabled = False
        cmddelete.Enabled = False
        cmdresume.Enabled = False
    End Sub

    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
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
            'deleteitem()
            'addnew()

        Else

            MessageBox.Show("اطلاعاتي ذخيره نشده است")


        End If

        filllst()

        cmdresume.Enabled = True
        cmdupdate.Enabled = True
        cmddelete.Enabled = True

        txtcode.Focus()
    End Sub

    Private Sub cmdcancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrEdit = "Cancel"

        cmdresume.Enabled = True
        cmddelete.Enabled = True
        cmdupdate.Enabled = True
    End Sub

    Private Sub cmdupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
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

    Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        deleteitem()
    End Sub
    Private Sub txtvendee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtcode.Focus()
        End If
    End Sub

    Private Sub Cboname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cboname.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtbuyprice.Focus()
        End If
    End Sub

    Private Sub txtnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) And txtnumber.Text <> "" Then
            txttotalprice.Focus()
        ElseIf (i = 3) And txtnumber.Text = "" Then
            txtsellprice.Focus()
        End If
    End Sub

    Private Sub txtcode_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcode.MouseMove
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

    Private Sub txtcode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

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

    Private Sub txtcode_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cboname.SelectedValue = 0
            Cboname.SelectedValue = Val(txtcode.Text)
            Cboname.Focus()
        ElseIf e.KeyCode = Keys.Space Then
            txtcode.Clear()
        End If
    End Sub

    Private Sub Cboname_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cboname.Text <> "" Then
            txtcode.Text = Cboname.SelectedValue.ToString
            txtsellprice.Focus()
        End If
    End Sub

    Private Sub lvwfactor_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwfactor.SelectedIndexChanged
        selectit = True
    End Sub

    Private Sub lvwfactor_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode <> Keys.Delete Then Exit Sub
        deleteitem()
    End Sub

    Private Sub txtsellprice_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtnumber.Focus()
        End If
    End Sub


    Private Sub txttotalprice_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdresume.Focus()
        End If
    End Sub

    Private Sub mskdate_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskdate.TextChanged
        Dim factornumber As Integer = 0
        Dim datareader As OleDbDataReader


        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(buy.factor) FROM buy"
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

        OleDbCon.Close()
        OleDbCon.Dispose()
    End Sub

    Private Sub mskdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskdate.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtSupplierID.Focus()
        End If
    End Sub

    Private Sub txtgrandtotal_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrandtotal.TextChanged
        If txtgrandtotal.Text.Trim <> "" Then
            stsconvertint.Text = CStr(Adad(txtgrandtotal.Text) & " ريال")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtvendee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mskdate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumber.TextChanged
        If txtnumber.Text <> "" And txtsellprice.Text <> "" Then
            txttotalprice.Text = txtbuyprice.Text * txtnumber.Text
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mskdate_MaskInputRejected_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskdate.MaskInputRejected

    End Sub

    Private Sub cmddate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddate.Click
        '  txtdob.Text = TarikhShamsi(Now.Date, True)
        'mskdate.CtlText = TarikhShamsi(Now.Date, True)
        mskdate.Text = Shamsi.Tarikh
        If mskdate.Text <> "" Then
            txtSupplierID.Focus()
        End If
    End Sub

    Private Sub txtSupplierID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupplierID.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSupplierName.SelectedValue = Val(txtSupplierID.Text)
            cboSupplierName.Focus()
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

    Private Sub cboSupplierName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSupplierName.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtcode.Focus()
        End If
    End Sub

    Private Sub Cboname_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cboname.SelectedValueChanged
        If Cboname.Text <> "" Then
            txtcode.Text = Cboname.SelectedValue.ToString
            'txtsellprice.Focus()
        End If
    End Sub

    Private Sub lvwfactor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode <> Keys.Delete Then Exit Sub
        deleteitem()
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

    Private Sub txtfactor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfactor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSupplierID.Focus()
        End If
    End Sub

    Private Sub txtsellprice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsellprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumber.Focus()
        End If
    End Sub

    Private Sub txtNumberPresent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumberPresent.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
    End Sub
End Class
