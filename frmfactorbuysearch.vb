Public Class frmfactorbuysearch

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents txtvendee As System.Windows.Forms.TextBox
    Friend WithEvents txtfactor As System.Windows.Forms.TextBox
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents msk2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msk1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msk As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfactorbuysearch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.msk2 = New System.Windows.Forms.MaskedTextBox
        Me.msk1 = New System.Windows.Forms.MaskedTextBox
        Me.msk = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxShamsi1 = New AxKKRtarikh.AxShamsi
        Me.txtvendee = New System.Windows.Forms.TextBox
        Me.txtfactor = New System.Windows.Forms.TextBox
        Me.rb4 = New System.Windows.Forms.RadioButton
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
        Me.GroupBox1.Controls.Add(Me.msk2)
        Me.GroupBox1.Controls.Add(Me.msk1)
        Me.GroupBox1.Controls.Add(Me.msk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AxShamsi1)
        Me.GroupBox1.Controls.Add(Me.txtvendee)
        Me.GroupBox1.Controls.Add(Me.txtfactor)
        Me.GroupBox1.Controls.Add(Me.rb4)
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(370, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو بر اساس"
        '
        'msk2
        '
        Me.msk2.BackColor = System.Drawing.SystemColors.Info
        Me.msk2.Enabled = False
        Me.msk2.Location = New System.Drawing.Point(6, 176)
        Me.msk2.Mask = "13##/##/##"
        Me.msk2.Name = "msk2"
        Me.msk2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msk2.Size = New System.Drawing.Size(101, 26)
        Me.msk2.TabIndex = 15
        '
        'msk1
        '
        Me.msk1.BackColor = System.Drawing.SystemColors.Info
        Me.msk1.Enabled = False
        Me.msk1.Location = New System.Drawing.Point(139, 176)
        Me.msk1.Mask = "13##/##/##"
        Me.msk1.Name = "msk1"
        Me.msk1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msk1.Size = New System.Drawing.Size(99, 26)
        Me.msk1.TabIndex = 14
        '
        'msk
        '
        Me.msk.BackColor = System.Drawing.SystemColors.Info
        Me.msk.Enabled = False
        Me.msk.Location = New System.Drawing.Point(6, 128)
        Me.msk.Mask = "13##/##/##"
        Me.msk.Name = "msk"
        Me.msk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msk.Size = New System.Drawing.Size(283, 26)
        Me.msk.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "از"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "تا"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'txtvendee
        '
        Me.txtvendee.BackColor = System.Drawing.SystemColors.Info
        Me.txtvendee.Enabled = False
        Me.txtvendee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtvendee.Location = New System.Drawing.Point(6, 78)
        Me.txtvendee.Name = "txtvendee"
        Me.txtvendee.Size = New System.Drawing.Size(283, 22)
        Me.txtvendee.TabIndex = 5
        '
        'txtfactor
        '
        Me.txtfactor.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactor.Enabled = False
        Me.txtfactor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfactor.Location = New System.Drawing.Point(6, 32)
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Size = New System.Drawing.Size(283, 22)
        Me.txtfactor.TabIndex = 4
        '
        'rb4
        '
        Me.rb4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb4.Location = New System.Drawing.Point(252, 178)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(112, 24)
        Me.rb4.TabIndex = 3
        Me.rb4.Text = "بين دو تاريخ دلخواه:"
        '
        'rb3
        '
        Me.rb3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb3.Location = New System.Drawing.Point(260, 128)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(104, 24)
        Me.rb3.TabIndex = 2
        Me.rb3.Text = "در تاريخ"
        '
        'rb2
        '
        Me.rb2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb2.Location = New System.Drawing.Point(260, 78)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(104, 24)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "نام خريدار"
        '
        'rb1
        '
        Me.rb1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rb1.Location = New System.Drawing.Point(260, 32)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(104, 24)
        Me.rb1.TabIndex = 0
        Me.rb1.Text = "شماره فاکتور"
        '
        'cmdsearch
        '
        Me.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(302, 231)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 1
        Me.cmdsearch.Text = "جستجو"
        '
        'cmdcancel
        '
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(6, 231)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancel.TabIndex = 2
        Me.cmdcancel.Text = "انصراف"
        '
        'cmdclean
        '
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(222, 231)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(75, 23)
        Me.cmdclean.TabIndex = 3
        Me.cmdclean.Text = "پاک"
        '
        'frmfactorbuysearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(385, 260)
        Me.Controls.Add(Me.cmdclean)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdsearch)
        Me.MaximizeBox = False
        Me.Name = "frmfactorbuysearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجودرجدول خرید"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxShamsi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function clear()
        txtfactor.Text = ""
        txtvendee.Text = ""


    End Function
    Private Function makequery(ByRef strquery As String)

        Dim strsearch As String

        If rb1.Checked And txtfactor.Text.Trim <> "" Then
            strquery += " WHERE factor = "
            strquery += txtfactor.Text
        ElseIf rb2.Checked And txtvendee.Text.Trim <> "" Then
            strquery += " WHERE vendor like '"
            strquery += txtvendee.Text & "%'"
        ElseIf rb3.Checked And msk.Text <> "" Then
            strquery += " WHERE dob = '"
            strquery += msk.Text & "'"
        ElseIf rb4.Checked And msk1.Text <> "" And msk2.Text <> "" Then
            strquery += " WHERE dob Between '" & msk1.Text & "' " & " And '" & msk2.Text & "'"

        Else
            strquery = ""
        End If

    End Function

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        txtfactor.Enabled = True
        txtfactor.Focus()

    End Sub


    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        Dim frm As New frmqueryfactorbuyresult
        Dim strquery As String = "SELECT buy.dob, buy.factor, buy.code_s, Suppliers.name, buy.code_g, goods.name, buy.buyprice, buy.sellprice, buy.num, buy.sumprice FROM Suppliers INNER JOIN (goods INNER JOIN buy ON goods.code_g = buy.code_g) ON Suppliers.code_s = buy.code_s"
        makequery(strquery)
        frm.MdiParent = frmmain
        frm.Show()
        frm.FillDataGrid(strquery)
        Me.Close()
    End Sub

    Private Sub frmfactorsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        clear()
    End Sub


    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged

        txtvendee.Enabled = True
        txtvendee.Focus()

    End Sub

    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        msk.Enabled = True
        msk.Focus()


    End Sub

    Private Sub rb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb4.CheckedChanged
        msk1.Enabled = True
        msk2.Enabled = True
        msk1.Focus()


    End Sub

    Private Sub msk_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub msk1_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub msk2_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()

    End Sub

    Private Sub txtfactor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfactor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub txtvendee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendee.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub msk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msk.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub msk1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msk1.KeyDown
        If e.KeyCode = Keys.Enter Then
            msk2.Focus()
        End If
    End Sub

    Private Sub msk2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msk2.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsearch.Focus()
        End If
    End Sub
End Class
