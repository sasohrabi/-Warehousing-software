Imports System.String
Imports System.Data.OleDb

Public Class frmupdatedeletecompany
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Application.EnableVisualStyles()


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
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtclerk As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cbosearchby As System.Windows.Forms.ComboBox
    Friend WithEvents txtsiba As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbotype_v As System.Windows.Forms.ComboBox
    Friend WithEvents txttel_office As System.Windows.Forms.TextBox
    Friend WithEvents txttel_mobile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.cbosearchby = New System.Windows.Forms.ComboBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtclerk = New System.Windows.Forms.TextBox
        Me.txtsiba = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttel_mobile = New System.Windows.Forms.TextBox
        Me.txttel_office = New System.Windows.Forms.TextBox
        Me.cbotype_v = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(549, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "تغيير"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(629, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "حذف"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(469, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "پاک"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(7, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "خروج"
        '
        'cmdsearch
        '
        Me.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(7, 6)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 33
        Me.cmdsearch.Text = "جستجو"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtsearch.Location = New System.Drawing.Point(85, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(209, 20)
        Me.txtsearch.TabIndex = 32
        '
        'cbosearchby
        '
        Me.cbosearchby.BackColor = System.Drawing.SystemColors.Info
        Me.cbosearchby.Items.AddRange(New Object() {"کد", "نام", "تلفن", "موبایل", "منشي", "آدرس"})
        Me.cbosearchby.Location = New System.Drawing.Point(371, 7)
        Me.cbosearchby.Name = "cbosearchby"
        Me.cbosearchby.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbosearchby.Size = New System.Drawing.Size(248, 21)
        Me.cbosearchby.TabIndex = 31
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.LightYellow
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(6, 99)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(280, 21)
        Me.txtaddress.TabIndex = 25
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LightYellow
        Me.txtname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(6, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(280, 21)
        Me.txtname.TabIndex = 22
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.LightYellow
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(363, 25)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(248, 21)
        Me.txtcode.TabIndex = 21
        '
        'txtclerk
        '
        Me.txtclerk.BackColor = System.Drawing.Color.LightYellow
        Me.txtclerk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclerk.Location = New System.Drawing.Point(363, 99)
        Me.txtclerk.Name = "txtclerk"
        Me.txtclerk.Size = New System.Drawing.Size(248, 21)
        Me.txtclerk.TabIndex = 24
        '
        'txtsiba
        '
        Me.txtsiba.BackColor = System.Drawing.Color.LightYellow
        Me.txtsiba.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsiba.Location = New System.Drawing.Point(363, 135)
        Me.txtsiba.Name = "txtsiba"
        Me.txtsiba.Size = New System.Drawing.Size(248, 21)
        Me.txtsiba.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(625, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "جستجو بر اساس:"
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "مقدار فیلد:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txttel_mobile)
        Me.GroupBox1.Controls.Add(Me.txttel_office)
        Me.GroupBox1.Controls.Add(Me.cbotype_v)
        Me.GroupBox1.Controls.Add(Me.txtclerk)
        Me.GroupBox1.Controls.Add(Me.txtsiba)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 173)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات تهیه کننده"
        '
        'txttel_mobile
        '
        Me.txttel_mobile.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_mobile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel_mobile.Location = New System.Drawing.Point(6, 63)
        Me.txttel_mobile.Name = "txttel_mobile"
        Me.txttel_mobile.Size = New System.Drawing.Size(280, 21)
        Me.txttel_mobile.TabIndex = 112
        '
        'txttel_office
        '
        Me.txttel_office.BackColor = System.Drawing.SystemColors.Info
        Me.txttel_office.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel_office.Location = New System.Drawing.Point(363, 60)
        Me.txttel_office.Name = "txttel_office"
        Me.txttel_office.Size = New System.Drawing.Size(248, 21)
        Me.txttel_office.TabIndex = 111
        '
        'cbotype_v
        '
        Me.cbotype_v.BackColor = System.Drawing.SystemColors.Info
        Me.cbotype_v.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype_v.FormattingEnabled = True
        Me.cbotype_v.Location = New System.Drawing.Point(6, 134)
        Me.cbotype_v.Name = "cbotype_v"
        Me.cbotype_v.Size = New System.Drawing.Size(279, 23)
        Me.cbotype_v.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(291, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = ":نوع تهیه کننده"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = ":موبایل تهیه کننده"
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(614, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(111, 20)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = ":حساب سیبا تهیه کننده"
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.Location = New System.Drawing.Point(290, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = ":آدرس تهیه کننده"
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(611, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "کد تهیه کننده:"
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(614, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = ":منشی تهیه کننده"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(614, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(77, 20)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = ":تلفن تهیه کننده"
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(292, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(64, 20)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = ":نام تهیه کننده"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(697, 244)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نتیجه جستجو"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Tan
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Sienna
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(7, 19)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGrid1.Size = New System.Drawing.Size(685, 219)
        Me.DataGrid1.TabIndex = 87
        '
        'frmupdatedeletecompany
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(711, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.cbosearchby)
        Me.MaximizeBox = False
        Me.Name = "frmupdatedeletecompany"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تغییر جدول تهیه کننده"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim mydataset As New DataSet
    Dim counter As Integer = 1

    Private Function clear()
        txtsearch.Text = ""
        txtcode.Text = ""
        txtname.Text = ""
        txttel_office.Text = ""
        txttel_mobile.text = ""
        txtclerk.Text = ""
        txtaddress.Text = ""
        txtsiba.Text = ""
    End Function

    Private Function makequery(ByRef strquery As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strsearch As String
        Dim bsearchstrempty As Boolean

        bsearchstrempty = False
        If txtsearch.Text.Trim = "" Then
            MessageBox.Show("لطفا ابتدا متن را وارد کنيد")
            bsearchstrempty = True
        End If
        strsearch = cbosearchby.Text
        If (Not bsearchstrempty) Then
            If (Compare(strsearch, "کد", True) = 0) Then
                strquery += " WHERE code_s= "
                strquery += txtsearch.Text
            ElseIf (Compare(strsearch, "نام", True) = 0) Then
                strquery += " WHERE name = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "تلفن", True) = 0) Then
                strquery += " WHERE tel_office = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "موبایل", True) = 0) Then
                strquery += " WHERE tel_mobile = '"
                strquery += txtsearch.Text & "'"
            ElseIf (Compare(strsearch, "منشي", True) = 0) Then
                strquery += " WHERE clerk like '"
                strquery += txtsearch.Text & "%'"
            ElseIf (Compare(strsearch, "آدرس", True) = 0) Then
                strquery += " WHERE address like '"
                strquery += txtsearch.Text & "%'"

            End If
        Else
            strquery = ""
        End If

    End Function

    Public Function FillTextBox(ByVal Sqlstring As String)
        Try
            clear()

            Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
            OleDbCon.Open()

            Dim MyDataReader As OleDbDataReader

            Dim OleCommand As OleDbCommand = New OleDbCommand
            OleCommand.Connection = (OleDbCon)
            OleCommand.CommandText = Sqlstring

            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                txtcode.Text = (MyDataReader.Item(0).ToString)
                txtname.Text = (MyDataReader.Item(1).ToString)
                txttel_office.Text = (MyDataReader.Item(2).ToString)
                txttel_mobile.Text = (MyDataReader.Item(3).ToString)
                txtclerk.Text = (MyDataReader.Item(4).ToString)
                txtaddress.Text = (MyDataReader.Item(5).ToString)
                txtsiba.Text = (MyDataReader.Item(6).ToString)
                cbotype_v.Text = (MyDataReader.Item(7).ToString)
            Loop
            MyDataReader.Close()

        Catch e1 As Exception

            MsgBox("فیلد خالی در اطلاعات مربوط به رکورد جاری وجود دارد")

        End Try

        If (txtcode.Text = "") Then
            txtcode.Focus()
        End If

        txtcode.Enabled = False

    End Function

    'Public Function FillListview(ByVal Sqlstring As String)

    '   lvwsearchresult.Items.Clear()
    '  Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
    ' Dim MyDataReader As OleDbDataReader
    '  Dim MyOleDbCommand As OleDbCommand = New OleDbCommand
    ' Dim MyDataSet As DataSet = New DataSet
    '      Dim MyOleDataAdapter As OleDbDataAdapter = New OleDbDataAdapter



    '     OleDbConn.Open()
    '    MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
    '   MyOleDataAdapter.Fill(MyDataSet)
    '  MyOleDbCommand.Connection = (OleDbConn)

    '      MyOleDbCommand.CommandText = Sqlstring
    '
    '       MyDataReader = MyOleDbCommand.ExecuteReader
    '
    '       ProgressBar1.Minimum = 0
    '    ProgressBar1.Maximum = MyDataSet.Tables(0).Rows.Count
    '
    '
    '       Do While MyDataReader.Read
    '
    '         Dim strsearch As String() = {MyDataReader(4), MyDataReader(3), MyDataReader(2), _
    '      MyDataReader(1), MyDataReader(0)}
    '          lvwsearchresult.Items.Add(New ListViewItem(strsearch))
    '         ProgressBar1.Value = ProgressBar1.Value + 1
    '
    '       Loop
    '
    '
    '      MyDataReader.Close()
    '       OleDbConn.Close()
    '      OleDbConn.Dispose()
    '

    '   End Function
    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)
        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "Suppliers")


        Me.DataGrid1.DataSource = (mydataset.Tables(0))




        Me.Text = " " & mydataset.Tables(0).Rows.Count & " Rows."
        'Analyze_position()
        If counter = 2 Then
            FormatGridWithTableStyles()
        End If
        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With DataGrid1
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "نتيجه جستجو:"
            .Font = New Font("Tahoma", 8.0!)
            .ParentRowsBackColor = Color.Lavender
            .ParentRowsForeColor = Color.MidnightBlue
        End With
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.Lavender
            .BackColor = Color.GhostWhite
            .ForeColor = Color.MidnightBlue
            .GridLineColor = Color.RoyalBlue
            .HeaderBackColor = Color.MidnightBlue
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.Lavender
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
            .MappingName = mydataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد"
            .MappingName = "code_s"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام تهیه کننده"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Center
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "تلفن"
            .MappingName = "tel_office"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "موبایل"
            .MappingName = "tel_mobile"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "منشي"
            .MappingName = "clerk"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "آدرس"
            .MappingName = "address"
            '.Width = 50
        End With
        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "شماره حساب سیبا"
            .MappingName = "siba"
            '.Width = 50
        End With
        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "نوع"
            .MappingName = "type_v"
            '.Width = 50
        End With



        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        DataGrid1.TableStyles.Add(grdTableStyle1)

    End Function

    Private Sub frmupdatedeletecompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click

        counter += 1
        Dim strquery As String = "select * from Suppliers"
        makequery(strquery)
        FillTextBox(strquery)
        'FillListview(strquery)
        FillDataGrid(strquery)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If Me.txtname.Text <> "" And Me.txttel_office.Text <> "" And Me.txtclerk.Text <> "" And Me.txtaddress.Text <> "" Then
            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()

                Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                MyOledbCommand.CommandText = "Update Suppliers Set " _
                & "name='" & txtname.Text.ToString & "', " _
                & "tel_office='" & txttel_office.Text.ToString & "', " _
                & "tel_mobile='" & txttel_mobile.Text.ToString & "', " _
                & "clerk='" & txtclerk.Text.ToString & "', " _
                & "address='" & txtaddress.Text.ToString & "', " _
                & "siba='" & txtsiba.Text.ToString & "', " _
                & "type_v='" & cbotype_v.Text.ToString & "' " _
                & "WHERE code_s = " & txtcode.Text


                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()

            Catch ex As Exception
                MessageBox.Show("مشکلی در ثبت تغییرات رکورد جاری پیش آمده است" & vbCrLf & ex.Message)
                Exit Sub
            End Try

            MsgBox("اطلاعات به درستی ذخیره شد")
            counter += 1
            Dim strquery As String = "select * from Suppliers where code_s = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
            FillDataGrid(strquery)
        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim string1 As Integer = txtcode.Text
            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
            OleDbConn.Open()


            Dim MyOledbCommand As OleDbCommand = New OleDbCommand


            MyOledbCommand.CommandText = "DELETE FROM Suppliers WHERE code_s=" & string1

            MyOledbCommand.Connection = OleDbConn

            MyOledbCommand.ExecuteNonQuery()
            OleDbConn.Close()

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim SqlStr As String

        SqlStr = "SELECT * FROM Suppliers where code_s = " & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        FillTextBox(SqlStr)
    End Sub
    Private Sub txtsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmdsearch.Focus()
        End If
    End Sub

    Private Sub cbosearchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosearchby.SelectedIndexChanged
        txtsearch.Focus()

    End Sub
End Class
