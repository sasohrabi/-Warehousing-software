<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQL
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
        Me.txtContextCodeD = New System.Windows.Forms.RichTextBox
        Me.btnSQLD = New System.Windows.Forms.Button
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.btnCLOSE = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.datagrideRESULT = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCodeRUN = New System.Windows.Forms.Button
        Me.txtCodeRUN = New System.Windows.Forms.RichTextBox
        CType(Me.datagrideRESULT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContextCodeD
        '
        Me.txtContextCodeD.BackColor = System.Drawing.Color.LightGreen
        Me.txtContextCodeD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtContextCodeD.Location = New System.Drawing.Point(95, 12)
        Me.txtContextCodeD.Name = "txtContextCodeD"
        Me.txtContextCodeD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContextCodeD.Size = New System.Drawing.Size(663, 42)
        Me.txtContextCodeD.TabIndex = 0
        Me.txtContextCodeD.Text = ""
        '
        'btnSQLD
        '
        Me.btnSQLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSQLD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSQLD.Location = New System.Drawing.Point(4, 9)
        Me.btnSQLD.Name = "btnSQLD"
        Me.btnSQLD.Size = New System.Drawing.Size(85, 49)
        Me.btnSQLD.TabIndex = 1
        Me.btnSQLD.Text = "اجرای نمایش"
        Me.btnSQLD.UseVisualStyleBackColor = True
        '
        'btnCLEAR
        '
        Me.btnCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCLEAR.Location = New System.Drawing.Point(55, 195)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(34, 33)
        Me.btnCLEAR.TabIndex = 2
        Me.btnCLEAR.Text = "پاک"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnCLOSE
        '
        Me.btnCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCLOSE.Location = New System.Drawing.Point(4, 197)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(45, 31)
        Me.btnCLOSE.TabIndex = 3
        Me.btnCLOSE.Text = "خروج"
        Me.btnCLOSE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(764, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "متن کد نمایش  :"
        '
        'datagrideRESULT
        '
        Me.datagrideRESULT.DataMember = ""
        Me.datagrideRESULT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagrideRESULT.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrideRESULT.Location = New System.Drawing.Point(0, 234)
        Me.datagrideRESULT.Name = "datagrideRESULT"
        Me.datagrideRESULT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datagrideRESULT.Size = New System.Drawing.Size(892, 356)
        Me.datagrideRESULT.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(764, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "متن کد اجرایی  :"
        '
        'btnCodeRUN
        '
        Me.btnCodeRUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCodeRUN.ForeColor = System.Drawing.Color.Red
        Me.btnCodeRUN.Location = New System.Drawing.Point(4, 64)
        Me.btnCodeRUN.Name = "btnCodeRUN"
        Me.btnCodeRUN.Size = New System.Drawing.Size(85, 50)
        Me.btnCodeRUN.TabIndex = 7
        Me.btnCodeRUN.Text = "اجرای کد"
        Me.btnCodeRUN.UseVisualStyleBackColor = True
        '
        'txtCodeRUN
        '
        Me.txtCodeRUN.BackColor = System.Drawing.Color.MistyRose
        Me.txtCodeRUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtCodeRUN.Location = New System.Drawing.Point(95, 60)
        Me.txtCodeRUN.Name = "txtCodeRUN"
        Me.txtCodeRUN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodeRUN.Size = New System.Drawing.Size(663, 168)
        Me.txtCodeRUN.TabIndex = 8
        Me.txtCodeRUN.Text = ""
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 590)
        Me.Controls.Add(Me.txtCodeRUN)
        Me.Controls.Add(Me.btnCodeRUN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datagrideRESULT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCLOSE)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.btnSQLD)
        Me.Controls.Add(Me.txtContextCodeD)
        Me.Name = "frmSQL"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فرم اجرای کد"
        CType(Me.datagrideRESULT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContextCodeD As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSQLD As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagrideRESULT As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCodeRUN As System.Windows.Forms.Button
    Friend WithEvents txtCodeRUN As System.Windows.Forms.RichTextBox
End Class
