Imports System.String
Imports System.Data.OleDb

Public Class frmaddgoods
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cbounit As System.Windows.Forms.ComboBox
    Friend WithEvents cboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents mskvalidupto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskaddress As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.cmdadd = New System.Windows.Forms.Button
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.cmdclean = New System.Windows.Forms.Button
        Me.txtname = New System.Windows.Forms.TextBox
        Me.cbounit = New System.Windows.Forms.ComboBox
        Me.cboGroup = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbotype = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.mskaddress = New System.Windows.Forms.MaskedTextBox
        Me.mskvalidupto = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":کد کا لا"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(273, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نام کا لا:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(273, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "قيمت فروش:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(276, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "قيمت خريد:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(278, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "واحد کا لا:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(274, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "گروه کالا:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(274, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "تاريخ:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(279, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(32, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "تعداد:"
        '
        'txtbuyprice
        '
        Me.txtbuyprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtbuyprice.Location = New System.Drawing.Point(10, 109)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbuyprice.Size = New System.Drawing.Size(261, 22)
        Me.txtbuyprice.TabIndex = 12
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsellprice.Location = New System.Drawing.Point(10, 148)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsellprice.Size = New System.Drawing.Size(261, 22)
        Me.txtsellprice.TabIndex = 13
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtnumber.Location = New System.Drawing.Point(10, 187)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnumber.Size = New System.Drawing.Size(260, 22)
        Me.txtnumber.TabIndex = 17
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdadd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdadd.Location = New System.Drawing.Point(265, 443)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(80, 24)
        Me.cmdadd.TabIndex = 20
        Me.cmdadd.Text = "اضافه"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.Enabled = False
        Me.txtcode.Location = New System.Drawing.Point(18, 13)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(261, 20)
        Me.txtcode.TabIndex = 10
        '
        'cmdclean
        '
        Me.cmdclean.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(8, 443)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(80, 24)
        Me.cmdclean.TabIndex = 21
        Me.cmdclean.Text = "خروج"
        Me.cmdclean.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Info
        Me.txtname.Location = New System.Drawing.Point(10, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtname.Size = New System.Drawing.Size(261, 22)
        Me.txtname.TabIndex = 11
        '
        'cbounit
        '
        Me.cbounit.BackColor = System.Drawing.SystemColors.Info
        Me.cbounit.ItemHeight = 16
        Me.cbounit.Location = New System.Drawing.Point(10, 65)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbounit.Size = New System.Drawing.Size(261, 24)
        Me.cbounit.TabIndex = 19
        '
        'cboGroup
        '
        Me.cboGroup.BackColor = System.Drawing.SystemColors.Info
        Me.cboGroup.Location = New System.Drawing.Point(10, 350)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboGroup.Size = New System.Drawing.Size(261, 24)
        Me.cboGroup.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(278, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = ":مکان کالا"
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdcancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(105, 443)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 24)
        Me.cmdcancel.TabIndex = 25
        Me.cmdcancel.Text = "انصراف"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(189, 443)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 26
        Me.cmdsave.Text = "ذخيره"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cbotype)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.mskaddress)
        Me.GroupBox1.Controls.Add(Me.mskvalidupto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtbuyprice)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboGroup)
        Me.GroupBox1.Controls.Add(Me.cbounit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnumber)
        Me.GroupBox1.Controls.Add(Me.txtsellprice)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(337, 393)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلا عات مربوط به کالا"
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.SystemColors.Info
        Me.cbotype.ItemHeight = 16
        Me.cbotype.Items.AddRange(New Object() {"مصرفی", "سرمایه ای"})
        Me.cbotype.Location = New System.Drawing.Point(10, 311)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbotype.Size = New System.Drawing.Size(260, 24)
        Me.cbotype.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(278, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = ":نوع کالا"
        '
        'mskaddress
        '
        Me.mskaddress.BackColor = System.Drawing.SystemColors.Info
        Me.mskaddress.Location = New System.Drawing.Point(10, 270)
        Me.mskaddress.Name = "mskaddress"
        Me.mskaddress.Size = New System.Drawing.Size(260, 22)
        Me.mskaddress.TabIndex = 26
        '
        'mskvalidupto
        '
        Me.mskvalidupto.BackColor = System.Drawing.SystemColors.Info
        Me.mskvalidupto.Location = New System.Drawing.Point(10, 227)
        Me.mskvalidupto.Mask = "13##/##/##"
        Me.mskvalidupto.Name = "mskvalidupto"
        Me.mskvalidupto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mskvalidupto.Size = New System.Drawing.Size(260, 22)
        Me.mskvalidupto.TabIndex = 25
        '
        'frmaddgoods
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(355, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdclean)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmaddgoods"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim SaveOrCancel As String = ""

    Private Function clear()
        txtcode.Clear()
        txtname.Clear()
        txtbuyprice.Clear()
        txtsellprice.Clear()
        txtnumber.Clear()

        cbounit.Text = ""
        cbotype.Text = ""
        mskvalidupto.Clear()
        mskaddress.Clear()


    End Function
    Private Function fillcombounit()
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT unit FROM units"
        Try
            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                cbounit.Items.Add(MyDataReader("unit")) 'or use ...mydatareader.item(0)

            Loop

        Catch err As System.Exception

            MyDataReader.Close()
            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

        If (txtcode.Text = "") Then
            txtcode.Focus()
        Else
            txtnumber.Focus()

        End If
    End Function
    'Private Function fillcombocompany()
    '    Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
    '    OleDbCon.Open()

    '    Dim MyDataReader As OleDbDataReader

    '    Dim OleCommand As OleDbCommand = New OleDbCommand
    '    OleCommand.Connection = (OleDbCon)
    '    OleCommand.CommandText = "SELECT code,name FROM company"
    '    Try
    '        MyDataReader = OleCommand.ExecuteReader


    '        Do While MyDataReader.Read

    '            cbocompany.Items.Add(MyDataReader("code") & "   " & MyDataReader("name")) 'or use ...mydatareader.item(0)

    '        Loop

    '    Catch err As System.Exception

    '        MyDataReader.Close()
    '        OleDbCon.Close()
    '        OleDbCon.Dispose()
    '    End Try

    '    If (txtcode.Text = "") Then
    '        txtcode.Focus()
    '    Else
    '        txtnumber.Focus()

    '    End If
    'End Function
    'Private Function fillcombocompany()
    '    Dim myOleDbDataAdapter As OleDbDataAdapter
    '    Dim myDataTable As DataTable = New DataTable
    '    Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)

    '    OleDbCon.Open()

    '    Try
    '        myOleDbDataAdapter = New OleDbDataAdapter("select code,name from company order by name", _
    '            OleDbCon)

    '        myDataTable.Clear()

    '        myOleDbDataAdapter.Fill(myDataTable)
    '        cboGroup.DataSource = myDataTable
    '        cboGroup.ValueMember = "code"
    '        cboGroup.DisplayMember = "name"

    '    Catch
    '        MsgBox("Error Opening {0}", OleDbCon.DataSource)
    '    End Try

    '    OleDbCon.Close()
    '    OleDbCon.Dispose()

    'End Function
    Private Function checkkey(ByVal strshrperseneli As String) As Boolean
        Dim count As Integer = 0
        Dim bool As Boolean = False
        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim oledbcommand As New OleDbCommand

        oledbcommand.CommandText = "select count(*) from goods where name = '" & strshrperseneli & "'"
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

    Private Sub frmaddgoods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombounit()
        'fillcombocompany()
        Me.Text = "اضافه کردن کالا" & "                        " & TarikhShamsi(Now.Date, True)
        'mskvalidupto.CtlText = TarikhShamsi(Now.Date, False)
    End Sub

    Private Function count_hal_giri() As Integer
        Dim codenumber As Integer = 0
        Dim datareader As OleDbDataReader
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()
        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT count(*) FROM goods"

        datareader = OleCommand.ExecuteReader

        Do While datareader.Read
            If datareader.IsDBNull(0) Then
                Return 1
            Else
                Return datareader.Item(0)
            End If
        Loop
    End Function

    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click


        SaveOrCancel = "Save"

        Dim codenumber As Integer = 0
        Dim datareader As OleDbDataReader

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT max(goods.code_g) FROM goods"

        datareader = OleCommand.ExecuteReader
        Do While datareader.Read
            If datareader.IsDBNull(0) Then
                codenumber = 10000
                txtcode.Text = codenumber
            Else
                codenumber = datareader.Item(0)
                codenumber += 1
                txtcode.Text = codenumber
            End If
        Loop
        OleDbCon.Close()
        OleDbCon.Dispose()
        txtname.Focus()
        'txtcode.TabIndex = 0


    End Sub

    Private Sub cmdclean_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        'clear()
        Me.Close()
    End Sub


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        'If count_hal_giri() <= 100 Then
        If SaveOrCancel = "Save" Then
            If Me.txtname.Text <> "" And Me.cbounit.Text <> "" And Me.txtbuyprice.Text <> "" And Me.txtsellprice.Text <> "" _
               And Me.cboGroup.Text <> "" And Me.txtnumber.Text <> "" And Me.cbotype.Text <> "" Then
                If checkkey(Me.txtname.Text) = True Then
                    Try
                        Dim oledbcon As New OleDbConnection(strcon)
                        oledbcon.Open()
                        Dim olecommand As New OleDbCommand

                        olecommand.CommandText = "Insert Into goods " _
                            & "(code_g,name,unit,buyprice,sellprice,dob,num,address,type,group_g) " _
                            & "Values (" _
                            & "'" & txtcode.Text & "' , " _
                            & "'" & txtname.Text & "' , " _
                            & "'" & cbounit.Text & "' , " _
                            & "'" & txtbuyprice.Text & "' , " _
                            & "'" & txtsellprice.Text & "' , " _
                            & "'" & mskvalidupto.Text & "' , " _
                            & "'" & txtnumber.Text & "' , " _
                            & "'" & mskaddress.Text & "' , " _
                            & "'" & cbotype.Text & "' , " _
                            & "'" & cboGroup.Text & "')"  '& "'" & Val(Mid(str, 1)) & "' , " _

                        olecommand.Connection = oledbcon

                        olecommand.ExecuteNonQuery()
                        oledbcon.Close()
                        oledbcon.Dispose()
                    Catch err As System.Exception
                        MessageBox.Show("مشکلی در ثبت رکورد پیش آمده")
                    End Try
                Else
                    MessageBox.Show("این رکورد بااین نام کالا قبلا ثبت شده است")
                End If
            Else
                MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
            End If
        End If
        clear()
        Me.cmdadd.Focus()
        'Else
        '    MsgBox("این نرم افزار نسخه آزمایشی می باشد")
        'End If


    End Sub

    Private Sub txtcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcode.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cbounit.Focus()
        End If
    End Sub

    Private Sub cbounit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbounit.SelectedIndexChanged

        txtbuyprice.Focus()

    End Sub

    Private Sub txtbuyprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuyprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtsellprice.Focus()
        End If
    End Sub

    Private Sub txtsellprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            Me.txtnumber.Focus()
        End If
    End Sub


    Private Sub txtnumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar))
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            mskvalidupto.Focus()
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        SaveOrCancel = "Cancel"
        'Me.Close()

    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbounit.Focus()

        End If
    End Sub

    Private Sub mskvalidupto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskvalidupto.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskaddress.Focus()

        End If
    End Sub

    Private Sub mskaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbotype.Focus()
        End If
    End Sub

    Private Sub cbocompany_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtnumber.Focus()
        End If
    End Sub
    Private Sub cbotype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbotype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboGroup.Focus()
        End If
    End Sub

    Private Sub cboGroup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdsave.Focus()
        End If
    End Sub
End Class
