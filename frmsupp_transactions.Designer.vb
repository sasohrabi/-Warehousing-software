<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupp_transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsupp_transactions))
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtnotes = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.mskcreditor = New System.Windows.Forms.MaskedTextBox
        Me.mskdebtor = New System.Windows.Forms.MaskedTextBox
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.mskdate = New System.Windows.Forms.MaskedTextBox
        Me.cmdclean = New System.Windows.Forms.Button
        Me.cmddate = New System.Windows.Forms.Button
        Me.shamsi = New AxKKRtarikh.AxShamsi
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtsuppliername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSupplierID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "مبلغ بستانکاری :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "مبلغ بدهکاری :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "تاریخ :"
        '
        'txtnotes
        '
        Me.txtnotes.BackColor = System.Drawing.SystemColors.Info
        Me.txtnotes.Location = New System.Drawing.Point(1, 101)
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(325, 22)
        Me.txtnotes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "توضیح :"
        '
        'mskcreditor
        '
        Me.mskcreditor.BackColor = System.Drawing.SystemColors.Info
        Me.mskcreditor.Location = New System.Drawing.Point(151, 221)
        Me.mskcreditor.Mask = "#####################"
        Me.mskcreditor.Name = "mskcreditor"
        Me.mskcreditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mskcreditor.Size = New System.Drawing.Size(160, 22)
        Me.mskcreditor.TabIndex = 3
        '
        'mskdebtor
        '
        Me.mskdebtor.BackColor = System.Drawing.SystemColors.Info
        Me.mskdebtor.Location = New System.Drawing.Point(151, 183)
        Me.mskdebtor.Mask = "#####################"
        Me.mskdebtor.Name = "mskdebtor"
        Me.mskdebtor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mskdebtor.Size = New System.Drawing.Size(160, 22)
        Me.mskdebtor.TabIndex = 2
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(6, 269)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 24)
        Me.cmdcancel.TabIndex = 47
        Me.cmdcancel.Text = "انصراف"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(325, 269)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 45
        Me.cmdsave.Text = "ذخيره"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'mskdate
        '
        Me.mskdate.BackColor = System.Drawing.SystemColors.Info
        Me.mskdate.Location = New System.Drawing.Point(244, 141)
        Me.mskdate.Mask = "13##/##/##"
        Me.mskdate.Name = "mskdate"
        Me.mskdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskdate.Size = New System.Drawing.Size(81, 22)
        Me.mskdate.TabIndex = 1
        '
        'cmdclean
        '
        Me.cmdclean.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(239, 269)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(80, 24)
        Me.cmdclean.TabIndex = 46
        Me.cmdclean.Text = "پاک"
        Me.cmdclean.UseVisualStyleBackColor = False
        '
        'cmddate
        '
        Me.cmddate.BackColor = System.Drawing.SystemColors.Info
        Me.cmddate.BackgroundImage = CType(resources.GetObject("cmddate.BackgroundImage"), System.Drawing.Image)
        Me.cmddate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddate.Location = New System.Drawing.Point(226, 141)
        Me.cmddate.Name = "cmddate"
        Me.cmddate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmddate.Size = New System.Drawing.Size(16, 23)
        Me.cmddate.TabIndex = 28
        Me.cmddate.Text = ">"
        Me.cmddate.UseVisualStyleBackColor = False
        '
        'shamsi
        '
        Me.shamsi.Enabled = True
        Me.shamsi.Location = New System.Drawing.Point(12, 270)
        Me.shamsi.Name = "shamsi"
        Me.shamsi.OcxState = CType(resources.GetObject("shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.shamsi.Size = New System.Drawing.Size(80, 17)
        Me.shamsi.TabIndex = 48
        Me.shamsi.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtsuppliername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSupplierID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mskcreditor)
        Me.GroupBox1.Controls.Add(Me.mskdebtor)
        Me.GroupBox1.Controls.Add(Me.mskdate)
        Me.GroupBox1.Controls.Add(Me.cmddate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnotes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 257)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات صورتحساب"
        '
        'txtsuppliername
        '
        Me.txtsuppliername.BackColor = System.Drawing.SystemColors.Info
        Me.txtsuppliername.Enabled = False
        Me.txtsuppliername.Location = New System.Drawing.Point(143, 62)
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.Size = New System.Drawing.Size(184, 22)
        Me.txtsuppliername.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(312, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "نام تهیه کننده:"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Location = New System.Drawing.Point(185, 26)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(141, 22)
        Me.txtSupplierID.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "کد تهیه کننده:"
        '
        'frmsupp_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 299)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdclean)
        Me.Controls.Add(Me.shamsi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmsupp_transactions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فرم ثبت صورتحساب جدید تهیه کننده"
        CType(Me.shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnotes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskcreditor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskdebtor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents mskdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents cmddate As System.Windows.Forms.Button
    Friend WithEvents shamsi As AxKKRtarikh.AxShamsi
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsuppliername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
