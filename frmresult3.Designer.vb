<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmresult3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttype_v = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttel_office = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttel_mobile = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtsiba = New System.Windows.Forms.TextBox
        Me.txtclerk = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.DataGride2 = New System.Windows.Forms.DataGrid
        Me.cng1 = New ControleNavegador.ControleNavegador
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txttype_v)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttel_office)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttel_mobile)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtsiba)
        Me.GroupBox1.Controls.Add(Me.txtclerk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 157)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطاعات مربوط به مشتری"
        '
        'txttype_v
        '
        Me.txttype_v.BackColor = System.Drawing.SystemColors.Info
        Me.txttype_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttype_v.Location = New System.Drawing.Point(8, 122)
        Me.txttype_v.Name = "txttype_v"
        Me.txttype_v.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttype_v.Size = New System.Drawing.Size(187, 22)
        Me.txttype_v.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(194, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = ":نوع مشتری"
        '
        'txttel_office
        '
        Me.txttel_office.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_office.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttel_office.Location = New System.Drawing.Point(288, 56)
        Me.txttel_office.Name = "txttel_office"
        Me.txttel_office.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttel_office.Size = New System.Drawing.Size(175, 22)
        Me.txttel_office.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = ":موبایل مشتری"
        '
        'txttel_mobile
        '
        Me.txttel_mobile.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttel_mobile.Location = New System.Drawing.Point(8, 56)
        Me.txttel_mobile.Name = "txttel_mobile"
        Me.txttel_mobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttel_mobile.Size = New System.Drawing.Size(187, 22)
        Me.txttel_mobile.TabIndex = 16
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Location = New System.Drawing.Point(288, 22)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode.Size = New System.Drawing.Size(175, 22)
        Me.txtcode.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(463, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":شماره سیبا"
        '
        'txtsiba
        '
        Me.txtsiba.BackColor = System.Drawing.SystemColors.Info
        Me.txtsiba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsiba.Location = New System.Drawing.Point(288, 122)
        Me.txtsiba.Name = "txtsiba"
        Me.txtsiba.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsiba.Size = New System.Drawing.Size(175, 22)
        Me.txtsiba.TabIndex = 14
        '
        'txtclerk
        '
        Me.txtclerk.BackColor = System.Drawing.SystemColors.Info
        Me.txtclerk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclerk.Location = New System.Drawing.Point(288, 89)
        Me.txtclerk.Name = "txtclerk"
        Me.txtclerk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclerk.Size = New System.Drawing.Size(175, 22)
        Me.txtclerk.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":نام مشتری"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":منشی مشتری"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(8, 89)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtaddress.Size = New System.Drawing.Size(187, 22)
        Me.txtaddress.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":کد مشتری"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(464, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":تلفن مشتری"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":آدرس مشتری"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Info
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Location = New System.Drawing.Point(8, 22)
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtname.Size = New System.Drawing.Size(187, 22)
        Me.txtname.TabIndex = 9
        '
        'DataGride2
        '
        Me.DataGride2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGride2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGride2.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.DataGride2.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGride2.DataMember = ""
        Me.DataGride2.FlatMode = True
        Me.DataGride2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGride2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGride2.Location = New System.Drawing.Point(12, 221)
        Me.DataGride2.Name = "DataGride2"
        Me.DataGride2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGride2.Size = New System.Drawing.Size(545, 245)
        Me.DataGride2.TabIndex = 24
        '
        'cng1
        '
        Me.cng1.DataSource = Nothing
        Me.cng1.Location = New System.Drawing.Point(62, 175)
        Me.cng1.Name = "cng1"
        Me.cng1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cng1.Size = New System.Drawing.Size(428, 40)
        Me.cng1.TabIndex = 26
        '
        'frmresult3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGride2)
        Me.Controls.Add(Me.cng1)
        Me.MaximizeBox = False
        Me.Name = "frmresult3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " نتیجه جستجو"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttype_v As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttel_office As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttel_mobile As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsiba As System.Windows.Forms.TextBox
    Friend WithEvents txtclerk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents DataGride2 As System.Windows.Forms.DataGrid
    Friend WithEvents cng1 As ControleNavegador.ControleNavegador
End Class
