Public Class Frmsearchgoodstable
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AxShamsi1 As AxKKRtarikh.AxShamsi
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtcompanyname As System.Windows.Forms.TextBox
    Friend WithEvents txtgoodname As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsearchgoodstable))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcompanyname = New System.Windows.Forms.TextBox
        Me.AxShamsi1 = New AxKKRtarikh.AxShamsi
        Me.txtgoodname = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdclean = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxShamsi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtcompanyname)
        Me.GroupBox1.Controls.Add(Me.AxShamsi1)
        Me.GroupBox1.Controls.Add(Me.txtgoodname)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(364, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو بر اساس"
        '
        'txtcompanyname
        '
        Me.txtcompanyname.BackColor = System.Drawing.SystemColors.Info
        Me.txtcompanyname.Enabled = False
        Me.txtcompanyname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcompanyname.Location = New System.Drawing.Point(6, 128)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(277, 22)
        Me.txtcompanyname.TabIndex = 8
        '
        'AxShamsi1
        '
        Me.AxShamsi1.Enabled = True
        Me.AxShamsi1.Location = New System.Drawing.Point(120, 232)
        Me.AxShamsi1.Name = "AxShamsi1"
        Me.AxShamsi1.OcxState = CType(resources.GetObject("AxShamsi1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShamsi1.Size = New System.Drawing.Size(80, 17)
        Me.AxShamsi1.TabIndex = 7
        '
        'txtgoodname
        '
        Me.txtgoodname.BackColor = System.Drawing.SystemColors.Info
        Me.txtgoodname.Enabled = False
        Me.txtgoodname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtgoodname.Location = New System.Drawing.Point(6, 80)
        Me.txtgoodname.Name = "txtgoodname"
        Me.txtgoodname.Size = New System.Drawing.Size(277, 22)
        Me.txtgoodname.TabIndex = 5
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.Location = New System.Drawing.Point(6, 32)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(277, 22)
        Me.txtcode.TabIndex = 4
        '
        'rb3
        '
        Me.rb3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb3.Location = New System.Drawing.Point(250, 128)
        Me.rb3.Name = "rb3"
        Me.rb3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rb3.Size = New System.Drawing.Size(104, 24)
        Me.rb3.TabIndex = 2
        Me.rb3.Text = "گروه کالا"
        '
        'rb2
        '
        Me.rb2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb2.Location = New System.Drawing.Point(249, 79)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(104, 24)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "نام کالا"
        '
        'rb1
        '
        Me.rb1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb1.Location = New System.Drawing.Point(249, 33)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(104, 24)
        Me.rb1.TabIndex = 0
        Me.rb1.Text = "کد کالا"
        '
        'cmdsearch
        '
        Me.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(302, 195)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 1
        Me.cmdsearch.Text = "جستجو"
        '
        'cmdcancel
        '
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(12, 195)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancel.TabIndex = 2
        Me.cmdcancel.Text = "انصراف"
        '
        'cmdclean
        '
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(221, 195)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(75, 23)
        Me.cmdclean.TabIndex = 3
        Me.cmdclean.Text = "پاک"
        '
        'Frmsearchgoodstable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(385, 224)
        Me.Controls.Add(Me.cmdclean)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdsearch)
        Me.MaximizeBox = False
        Me.Name = "Frmsearchgoodstable"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجو در جدول کالا"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxShamsi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Function makequery(ByRef strquery As String)


        Dim strsearch As String
        Dim bsearchstrempty As Boolean

        bsearchstrempty = False

        If rb1.Checked And txtcode.Text.Trim <> "" Then
            strquery += " WHERE goods.code_g = "
            strquery += txtcode.Text
        ElseIf rb2.Checked And txtgoodname.Text.Trim <> "" Then
            strquery += " WHERE goods.name like '"
            strquery += txtgoodname.Text.Trim & "%'"
        ElseIf rb3.Checked And txtcompanyname.Text.Trim <> "" Then
            strquery += " WHERE goods.group_g like '"
            strquery += txtcompanyname.Text.Trim & "%'"
        Else
            strquery = ""


        End If


    End Function

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        txtcode.Enabled = True
        txtcode.Focus()
    End Sub


    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        Dim frm As New frmresult
        Dim strquery As String = "Select * from goods" ' where goods.name like '" & "تيغ" & "%'"
        makequery(strquery)

        frm.MdiParent = frmmain
        frm.FillTextBox(strquery)
        frm.FillDataGrid(strquery)
        frm.Show()
        Me.Close()

    End Sub

    Private Sub frmfactorsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click

    End Sub


    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged

        txtgoodname.Enabled = True
        txtgoodname.Focus()
    End Sub

    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        txtcompanyname.Enabled = True
        txtcompanyname.Focus()


    End Sub


    Private Sub txtcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If

    End Sub

    Private Sub txtcompanyname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcompanyname.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub txtgoodname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgoodname.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

