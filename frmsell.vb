Imports System.Data.OleDb

Public Class frmsell
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
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdclean As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtoneprice As System.Windows.Forms.TextBox
    Friend WithEvents txtsumprice As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtpayprice As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents cmdgride As System.Windows.Forms.Button
    Friend WithEvents cmddate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    'Friend WithEvents Ds As pardis.ds
    Public WithEvents con As System.Data.OleDb.OleDbConnection
    Friend WithEvents ad As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents shamsi1 As AxKKRtarikh.AxShamsi
    Friend WithEvents Shamsi As AxKKRtarikh.AxShamsi
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsell))
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdclean = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtoneprice = New System.Windows.Forms.TextBox
        Me.txtsumprice = New System.Windows.Forms.TextBox
        Me.txtnumber = New System.Windows.Forms.TextBox
        Me.txtpayprice = New System.Windows.Forms.TextBox
        Me.txtdob = New System.Windows.Forms.TextBox
        Me.cmdgride = New System.Windows.Forms.Button
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.cmddate = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.con = New System.Data.OleDb.OleDbConnection
        Me.ad = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.Shamsi = New AxKKRtarikh.AxShamsi
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdadd
        '
        Me.cmdadd.AllowDrop = True
        Me.cmdadd.BackColor = System.Drawing.SystemColors.Info
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdadd.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdadd.Location = New System.Drawing.Point(264, 288)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(168, 24)
        Me.cmdadd.TabIndex = 11
        Me.cmdadd.Text = "«÷«›Â"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdclean
        '
        Me.cmdclean.AllowDrop = True
        Me.cmdclean.BackColor = System.Drawing.SystemColors.Info
        Me.cmdclean.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclean.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclean.Location = New System.Drawing.Point(48, 288)
        Me.cmdclean.Name = "cmdclean"
        Me.cmdclean.Size = New System.Drawing.Size(160, 24)
        Me.cmdclean.TabIndex = 12
        Me.cmdclean.Text = "Å«ò"
        Me.cmdclean.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":òœ"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":ﬁÌ„  Œ—Ìœ"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":‰«„"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ": ⁄œ«œ"
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":ﬁÌ„  ò·Ì"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":ﬁÌ„  Å—œ«Œ Ì „‘ —Ì"
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ": «—ÌŒ "
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Info
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtname.Location = New System.Drawing.Point(312, 104)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(120, 20)
        Me.txtname.TabIndex = 2
        '
        'txtoneprice
        '
        Me.txtoneprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtoneprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtoneprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtoneprice.Location = New System.Drawing.Point(304, 144)
        Me.txtoneprice.Name = "txtoneprice"
        Me.txtoneprice.Size = New System.Drawing.Size(100, 20)
        Me.txtoneprice.TabIndex = 4
        '
        'txtsumprice
        '
        Me.txtsumprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsumprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsumprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtsumprice.Location = New System.Drawing.Point(128, 144)
        Me.txtsumprice.Name = "txtsumprice"
        Me.txtsumprice.Size = New System.Drawing.Size(100, 20)
        Me.txtsumprice.TabIndex = 6
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(24, 104)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(96, 20)
        Me.txtnumber.TabIndex = 5
        '
        'txtpayprice
        '
        Me.txtpayprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtpayprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpayprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtpayprice.Location = New System.Drawing.Point(232, 184)
        Me.txtpayprice.Name = "txtpayprice"
        Me.txtpayprice.Size = New System.Drawing.Size(96, 20)
        Me.txtpayprice.TabIndex = 7
        '
        'txtdob
        '
        Me.txtdob.BackColor = System.Drawing.SystemColors.Info
        Me.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdob.Location = New System.Drawing.Point(66, 42)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(96, 20)
        Me.txtdob.TabIndex = 9
        '
        'cmdgride
        '
        Me.cmdgride.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.cmdgride.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdgride.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdgride.Location = New System.Drawing.Point(244, 41)
        Me.cmdgride.Name = "cmdgride"
        Me.cmdgride.Size = New System.Drawing.Size(15, 21)
        Me.cmdgride.TabIndex = 1
        Me.cmdgride.Text = ">"
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtcode.Location = New System.Drawing.Point(286, 41)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(120, 20)
        Me.txtcode.TabIndex = 0
        '
        'cmddate
        '
        Me.cmddate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddate.Location = New System.Drawing.Point(14, 43)
        Me.cmddate.Name = "cmddate"
        Me.cmddate.Size = New System.Drawing.Size(16, 22)
        Me.cmddate.TabIndex = 8
        Me.cmddate.Text = ">"
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = ": Ê÷ÌÕ« "
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(24, 216)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(384, 55)
        Me.txtdescription.TabIndex = 10
        '
        'con
        '
        Me.con.ConnectionString = resources.GetString("con.ConnectionString")
        '
        'ad
        '
        Me.ad.InsertCommand = Me.OleDbInsertCommand1
        Me.ad.SelectCommand = Me.OleDbSelectCommand1
        Me.ad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "sell", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code", "code"), New System.Data.Common.DataColumnMapping("description", "description"), New System.Data.Common.DataColumnMapping("dob", "dob"), New System.Data.Common.DataColumnMapping("name", "name"), New System.Data.Common.DataColumnMapping("num", "num"), New System.Data.Common.DataColumnMapping("oneprice", "oneprice"), New System.Data.Common.DataColumnMapping("payprice", "payprice"), New System.Data.Common.DataColumnMapping("sumprice", "sumprice")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO sell(code, description, dob, name, num, oneprice, payprice, sumprice)" & _
            " VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.con
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("code", System.Data.OleDb.OleDbType.VarWChar, 50, "code"), New System.Data.OleDb.OleDbParameter("description", System.Data.OleDb.OleDbType.VarWChar, 50, "description"), New System.Data.OleDb.OleDbParameter("dob", System.Data.OleDb.OleDbType.VarWChar, 50, "dob"), New System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 50, "name"), New System.Data.OleDb.OleDbParameter("num", System.Data.OleDb.OleDbType.VarWChar, 50, "num"), New System.Data.OleDb.OleDbParameter("oneprice", System.Data.OleDb.OleDbType.VarWChar, 50, "oneprice"), New System.Data.OleDb.OleDbParameter("payprice", System.Data.OleDb.OleDbType.VarWChar, 50, "payprice"), New System.Data.OleDb.OleDbParameter("sumprice", System.Data.OleDb.OleDbType.VarWChar, 50, "sumprice")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT code, description, dob, name, num, oneprice, payprice, sumprice FROM sell"
        Me.OleDbSelectCommand1.Connection = Me.con
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(272, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = ":Ê«Õœ"
        '
        'txtunit
        '
        Me.txtunit.BackColor = System.Drawing.SystemColors.Info
        Me.txtunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtunit.Location = New System.Drawing.Point(168, 104)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(96, 20)
        Me.txtunit.TabIndex = 3
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 323)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(480, 24)
        Me.StatusBar1.TabIndex = 27
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Shamsi
        '
        Me.Shamsi.Enabled = True
        Me.Shamsi.Location = New System.Drawing.Point(84, 20)
        Me.Shamsi.Name = "Shamsi"
        Me.Shamsi.OcxState = CType(resources.GetObject("Shamsi.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Shamsi.Size = New System.Drawing.Size(78, 17)
        Me.Shamsi.TabIndex = 28
        Me.Shamsi.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdgride)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.cmddate)
        Me.GroupBox1.Controls.Add(Me.Shamsi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(456, 72)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "òœ ò«·« —« Ê«—œ ò‰Ìœ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(456, 192)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ﬁ”„  ›—Ê‘ —Ê“«‰Â"
        '
        'frmsell
        '
        Me.AcceptButton = Me.cmdadd
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtpayprice)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtsumprice)
        Me.Controls.Add(Me.txtoneprice)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdclean)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frmsell"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "›—„ ›—Ê‘ —Ê“«‰Â"
        CType(Me.Shamsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Function cleartextboxes()
        txtcode.Clear()
        txtname.Clear()
        txtunit.Clear()
        txtoneprice.Clear()
        txtnumber.Clear()
        txtsumprice.Clear()
        txtpayprice.Clear()
        txtdob.Clear()
        txtdescription.Clear()
        txtcode.TabIndex = 0
        txtcode.Focus()

    End Function
    Private Function addnew()

        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim olecommand As New OleDbCommand

        olecommand.CommandText = "Insert Into sell " _
            & "(code,name,unit,oneprice,num,sumprice,payprice,dob,description) " _
            & "Values (" _
            & "'" & txtcode.Text & "' , " _
            & "'" & txtname.Text & "' , " _
            & "'" & txtunit.Text & "' , " _
            & "'" & txtoneprice.Text & "' , " _
            & "'" & txtnumber.Text & "' , " _
            & "'" & txtsumprice.Text & "' , " _
            & "'" & txtpayprice.Text & "' , " _
            & "'" & txtdob.Text & "' , " _
            & "'" & txtdescription.Text & "')"

        olecommand.Connection = oledbcon

        olecommand.ExecuteNonQuery()
        oledbcon.Close()
        oledbcon.Dispose()

        '   txtStatus.Text &= vbCrLf & "Sending query: " & _
        '     ad.InsertCommand.CommandText & _
        '    vbCrLf
        ' send query
        'txtStatus.Text &= vbCrLf & "Query successful"
    End Function
    Private Function selectnum(ByVal code As Integer, ByRef number As Integer)
        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = "SELECT goods.num FROM goods WHERE code= " & code
        Try
            MyDataReader = OleCommand.ExecuteReader


            Do While MyDataReader.Read

                number = (MyDataReader.Item(0))

            Loop

            StatusBar1.Text = " Record " & txtcode.Text & " selected"

        Catch err As System.Exception
            StatusBar1.Text = " Selected Record Contains Null String"



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
    Private Function updatenum(ByVal code As Integer, ByVal txtnumber As Integer, ByVal number As Integer)

        Dim oledbcon As New OleDbConnection(strcon)
        oledbcon.Open()
        Dim olecommand As New OleDbCommand

        number -= txtnumber

        olecommand.CommandText = "UPDATE goods SET num = " & number & " WHERE code= " & code
        olecommand.Connection = oledbcon

        olecommand.ExecuteNonQuery()
        oledbcon.Close()
        oledbcon.Dispose()

        ' txtStatus.Text &= vbCrLf & "Sending query: " & _
        '    ad.InsertCommand.CommandText & _
        '   vbCrLf
        ' send query
        '  txtStatus.Text &= vbCrLf & "Query successful"

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


                txtcode.Text = (MyDataReader.Item(0))
                txtname.Text = (MyDataReader.Item(1))
                txtunit.Text = (MyDataReader.Item(2))
                txtoneprice.Text = (MyDataReader.Item(4))

            Loop

            StatusBar1.Text = " Record " & txtcode.Text & " selected"

        Catch err As System.Exception
            StatusBar1.Text = " Selected Record Contains Null String"



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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclean.Click
        cleartextboxes()
    End Sub

    Private Sub frmsell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cleartextboxes()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgride.Click
        'Dim frm As New frmgride
        'frm.Show()
        'Me.Hide()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        Dim number As Integer = 0
        addnew()
        selectnum(txtcode.Text, number)
        updatenum(txtcode.Text, txtnumber.Text, number)

    End Sub

    Private Sub cmddate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddate.Click
        txtdob.Text = Shamsi.Tarikh
        txtdescription.Focus()


    End Sub


    Private Sub txtnumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            txtsumprice.Text = txtnumber.Text * txtoneprice.Text
            txtpayprice.Focus()
            txtpayprice.Text = txtsumprice.Text
            txtsumprice.Enabled = False
        End If
    End Sub

    Private Sub txtcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcode.KeyPress
        Dim strsql As String
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmddate.Focus()
            strsql = "SELECT * FROM goods WHERE code=" & txtcode.Text
            FillTextBox(strsql)
        End If

    End Sub

    Private Sub txtpayprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayprice.KeyPress
        Dim i As Short = Asc(e.KeyChar)
        If (i = 13) Then
            cmddate.Focus()
        End If
    End Sub

    Private Sub txtsumprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsumprice.TextChanged

    End Sub
End Class
