<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frn
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.file1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(122, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ابتدا cd را در درون cdrom گذاشته سپس بر روی دکمه بررسی اتصال کلیک نمائید"
        '
        'Button2
        '
        Me.Button2.Image = Global.pardis2.My.Resources.Resources.Connection_Active
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(6, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "بررسی اتصال"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 83)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مسیر پیش فرض"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Drive1)
        Me.GroupBox2.Controls.Add(Me.Dir1)
        Me.GroupBox2.Controls.Add(Me.file1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 273)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "مسیر دستی"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(202, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "3- دیدن فایل pardis.mdb و انتخاب آن   ------>"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(202, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 44)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "2- انتخاب پوشه ای که فایل pardis.mdb داخل آن می باشد ------>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "1- انتخاب درایو cd    ------>"
        '
        'Button1
        '
        Me.Button1.Image = Global.pardis2.My.Resources.Resources.Connection_Active
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(8, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "بررسی اتصال"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ابتدا cd را در درون cdrom گذاشته سپس مسیر را بصورت دستی از لیست های روبرو انتخاب " & _
            "کنید سپس بر روی دکمه بررسی اتصال کلیک نمائید  "
        '
        'Drive1
        '
        Me.Drive1.FormattingEnabled = True
        Me.Drive1.Location = New System.Drawing.Point(23, 56)
        Me.Drive1.Name = "Drive1"
        Me.Drive1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drive1.Size = New System.Drawing.Size(168, 21)
        Me.Drive1.TabIndex = 4
        '
        'Dir1
        '
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(23, 80)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dir1.Size = New System.Drawing.Size(168, 112)
        Me.Dir1.TabIndex = 3
        '
        'file1
        '
        Me.file1.FormattingEnabled = True
        Me.file1.Location = New System.Drawing.Point(23, 200)
        Me.file1.Name = "file1"
        Me.file1.Pattern = "*.mdb"
        Me.file1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.file1.Size = New System.Drawing.Size(168, 17)
        Me.file1.TabIndex = 5
        '
        'frn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 378)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frn"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فرم اتصال به بانک روی cd"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents file1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
