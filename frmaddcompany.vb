Imports System.Data.OleDb

Public Class frmaddcompany
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
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txttel_office As System.Windows.Forms.TextBox
    Friend WithEvents txtclerk As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsiba As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttel_mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbotype_v As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txttel_office = New System.Windows.Forms.TextBox
        Me.txtclerk = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbotype_v = New System.Windows.Forms.ComboBox
        Me.txttel_mobile = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtsiba = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Enabled = False
        Me.txtcode.Location = New System.Drawing.Point(24, 14)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(227, 20)
        Me.txtcode.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Info
        Me.txtname.Location = New System.Drawing.Point(15, 24)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(227, 22)
        Me.txtname.TabIndex = 3
        '
        'txttel_office
        '
        Me.txttel_office.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_office.Location = New System.Drawing.Point(15, 62)
        Me.txttel_office.Name = "txttel_office"
        Me.txttel_office.Size = New System.Drawing.Size(227, 22)
        Me.txttel_office.TabIndex = 4
        '
        'txtclerk
        '
        Me.txtclerk.BackColor = System.Drawing.SystemColors.Info
        Me.txtclerk.Location = New System.Drawing.Point(15, 138)
        Me.txtclerk.Name = "txtclerk"
        Me.txtclerk.Size = New System.Drawing.Size(227, 22)
        Me.txtclerk.TabIndex = 5
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtaddress.Location = New System.Drawing.Point(15, 175)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(227, 22)
        Me.txtaddress.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "کد تهیه کننده:"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(248, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = ":نام تهیه کننده"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(246, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":تلفن تهیه کننده"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(248, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = ":منشی تهیه کننده"
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(248, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = ":آدرس تهیه کننده"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(258, 345)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 24)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "اضافه"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "خروج"
        '
        'cmdsave
        '
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(180, 345)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 22
        Me.cmdsave.Text = "ذخيره"
        '
        'cmdcancel
        '
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(102, 345)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 23
        Me.cmdcancel.Text = "انصراف"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cbotype_v)
        Me.GroupBox1.Controls.Add(Me.txttel_mobile)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtsiba)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txttel_office)
        Me.GroupBox1.Controls.Add(Me.txtclerk)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(321, 291)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطاعات مربوط به تهیه کننده"
        '
        'cbotype_v
        '
        Me.cbotype_v.BackColor = System.Drawing.SystemColors.Info
        Me.cbotype_v.FormattingEnabled = True
        Me.cbotype_v.Location = New System.Drawing.Point(16, 251)
        Me.cbotype_v.Name = "cbotype_v"
        Me.cbotype_v.Size = New System.Drawing.Size(208, 24)
        Me.cbotype_v.TabIndex = 18
        '
        'txttel_mobile
        '
        Me.txttel_mobile.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_mobile.Location = New System.Drawing.Point(15, 100)
        Me.txttel_mobile.Name = "txttel_mobile"
        Me.txttel_mobile.Size = New System.Drawing.Size(227, 22)
        Me.txttel_mobile.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(244, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = ":موبایل تهیه کننده"
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(230, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = ":نوع تهیه کننده"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(230, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = ":حساب سیبا تهیه کننده"
        '
        'txtsiba
        '
        Me.txtsiba.BackColor = System.Drawing.SystemColors.Info
        Me.txtsiba.Location = New System.Drawing.Point(15, 214)
        Me.txtsiba.Name = "txtsiba"
        Me.txtsiba.Size = New System.Drawing.Size(209, 22)
        Me.txtsiba.TabIndex = 12
        '
        'frmaddcompany
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(340, 378)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcode)
        Me.MaximizeBox = False
        Me.Name = "frmaddcompany"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافه کردن تهیه کننده"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim SaveOrCancel As String = ""
    Private Function clear()
        Me.txtname.Clear()
        Me.txttel_office.Clear()
        Me.txttel_mobile.Clear()
        Me.txtclerk.Clear()
        Me.txtaddress.Clear()
        Me.txtsiba.Clear()
        Me.cbotype_v.Text = ""

    End Function

    Private Function checkkey(ByVal strSuppliername As String) As Boolean
        Dim count As Integer = 0
        Dim bool As Boolean = False
        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim oledbcommand As New OleDbCommand

        oledbcommand.CommandText = "select count(*) from Suppliers where name = '" & strSuppliername & "'"
        oledbcommand.Connection = oledbcon

        count = oledbcommand.ExecuteScalar

        oledbcon.Close()
        oledbcon.Dispose()
        If count = 0 Then
            bool = True
        Else
            bool = False
        End If

        Return bool

    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged

    End Sub

    'Private Sub frmaddcompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.Button6.Focus()


    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'txtcode.Clear()
        'txtname.Clear()
        'txttel_office.Clear()
        'txtclerk.Clear()
        'txtaddress.Clear()
        'txtsiba.Clear()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        SaveOrCancel = "Save"
        Dim codenumber As Integer = 0
        Dim datareader As OleDbDataReader

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(code_s) FROM Suppliers"

        datareader = OleCommand.ExecuteReader
        Do While datareader.Read
            If datareader.IsDBNull(0) Then
                codenumber = 100
                txtcode.Text = codenumber
            Else
                codenumber = datareader.Item(0)
                codenumber += 2
                txtcode.Text = codenumber
            End If
        Loop
        OleDbCon.Close()
        OleDbCon.Dispose()
        txtname.Focus()

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        If SaveOrCancel = "Save" Then

            If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" Then
                If checkkey(Me.txtname.Text) = True Then
                    Try
                        Dim oledbcon As New OleDbConnection(strcon)
                        oledbcon.Open()
                        Dim olecommand As New OleDbCommand

                        olecommand.CommandText = "Insert Into Suppliers " _
                            & "(code_s,name,tel_office,tel_mobile,clerk,address,siba,type_v) " _
                            & "Values (" _
                            & "'" & txtcode.Text & "' , " _
                            & "'" & txtname.Text & "' , " _
                            & "'" & txttel_office.Text & "' , " _
                            & "'" & txttel_mobile.Text & "' , " _
                            & "'" & txtclerk.Text & "' , " _
                            & "'" & txtaddress.Text & "' , " _
                            & "'" & txtsiba.Text & "' , " _
                            & "'" & cbotype_v.Text & "')"

                        olecommand.Connection = oledbcon

                        olecommand.ExecuteNonQuery()
                        oledbcon.Close()
                        oledbcon.Dispose()

                        clear()
                    Catch
                        MessageBox.Show("مشکلی در ذخیره سازی رکورد جاری به وجود آمده است")
                    End Try
                Else
                    MessageBox.Show("این رکورد بااین نام تهیه کننده قبلا ثبت شده است")
                End If
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If



        End If
        Me.Button6.PerformClick()

        'Me.cmdsave.Focus()

    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrCancel = "cancel"
        'Me.Close()

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txttel_office.Focus()
        End If

    End Sub

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_office.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            Me.txttel_mobile.Focus()
        End If
    End Sub

    Private Sub txtclerk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclerk.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsiba.Focus()

        End If
    End Sub

    Private Sub txtsiba_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsiba.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbotype_v.Focus()
        End If
    End Sub

    Private Sub txttel_mobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_mobile.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            Me.txtclerk.Focus()
        End If
    End Sub

    Private Sub cbotype_v_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotype_v.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdsave.Focus()
        End If
    End Sub
End Class
