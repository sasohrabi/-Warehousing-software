Imports System.Data.OleDb

Public Class frmresult
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
    Friend WithEvents DataGride2 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdfirst As System.Windows.Forms.Button
    Friend WithEvents cmdlast As System.Windows.Forms.Button
    Friend WithEvents cmdprev As System.Windows.Forms.Button
    Friend WithEvents cmdnext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtgroup_g As System.Windows.Forms.TextBox
    Friend WithEvents txtposition As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGride2 = New System.Windows.Forms.DataGrid
        Me.cmdfirst = New System.Windows.Forms.Button
        Me.cmdprev = New System.Windows.Forms.Button
        Me.cmdnext = New System.Windows.Forms.Button
        Me.cmdlast = New System.Windows.Forms.Button
        Me.txtposition = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.txtdob = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtsellprice = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtbuyprice = New System.Windows.Forms.TextBox
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.txttype = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtgroup_g = New System.Windows.Forms.TextBox
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGride2.Location = New System.Drawing.Point(8, 269)
        Me.DataGride2.Name = "DataGride2"
        Me.DataGride2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGride2.Size = New System.Drawing.Size(493, 252)
        Me.DataGride2.TabIndex = 16
        '
        'cmdfirst
        '
        Me.cmdfirst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdfirst.Location = New System.Drawing.Point(43, 240)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdfirst.Size = New System.Drawing.Size(75, 23)
        Me.cmdfirst.TabIndex = 17
        Me.cmdfirst.Text = "<<"
        '
        'cmdprev
        '
        Me.cmdprev.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdprev.Location = New System.Drawing.Point(123, 240)
        Me.cmdprev.Name = "cmdprev"
        Me.cmdprev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdprev.Size = New System.Drawing.Size(75, 23)
        Me.cmdprev.TabIndex = 18
        Me.cmdprev.Text = "<"
        '
        'cmdnext
        '
        Me.cmdnext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdnext.Location = New System.Drawing.Point(291, 240)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdnext.Size = New System.Drawing.Size(80, 23)
        Me.cmdnext.TabIndex = 19
        Me.cmdnext.Text = ">"
        '
        'cmdlast
        '
        Me.cmdlast.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdlast.Location = New System.Drawing.Point(377, 240)
        Me.cmdlast.Name = "cmdlast"
        Me.cmdlast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdlast.Size = New System.Drawing.Size(80, 23)
        Me.cmdlast.TabIndex = 20
        Me.cmdlast.Text = ">>"
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.SystemColors.Info
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtposition.Location = New System.Drawing.Point(203, 240)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(80, 20)
        Me.txtposition.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(421, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":کد کالا"
        '
        'txtnum
        '
        Me.txtnum.BackColor = System.Drawing.SystemColors.Info
        Me.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnum.Location = New System.Drawing.Point(259, 140)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnum.Size = New System.Drawing.Size(160, 25)
        Me.txtnum.TabIndex = 15
        '
        'txtdob
        '
        Me.txtdob.BackColor = System.Drawing.SystemColors.Info
        Me.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdob.Location = New System.Drawing.Point(6, 102)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdob.Size = New System.Drawing.Size(194, 25)
        Me.txtdob.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = ":آدرس"
        '
        'txtsellprice
        '
        Me.txtsellprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtsellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsellprice.Location = New System.Drawing.Point(259, 102)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsellprice.Size = New System.Drawing.Size(160, 25)
        Me.txtsellprice.TabIndex = 12
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(6, 140)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtaddress.Size = New System.Drawing.Size(194, 25)
        Me.txtaddress.TabIndex = 23
        '
        'txtbuyprice
        '
        Me.txtbuyprice.BackColor = System.Drawing.SystemColors.Info
        Me.txtbuyprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuyprice.Location = New System.Drawing.Point(6, 65)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbuyprice.Size = New System.Drawing.Size(194, 25)
        Me.txtbuyprice.TabIndex = 11
        '
        'txtunit
        '
        Me.txtunit.BackColor = System.Drawing.SystemColors.Info
        Me.txtunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunit.Location = New System.Drawing.Point(259, 65)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtunit.Size = New System.Drawing.Size(161, 25)
        Me.txtunit.TabIndex = 10
        '
        'txttype
        '
        Me.txttype.BackColor = System.Drawing.SystemColors.Info
        Me.txttype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttype.Location = New System.Drawing.Point(259, 179)
        Me.txttype.Name = "txttype"
        Me.txttype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttype.Size = New System.Drawing.Size(161, 25)
        Me.txttype.TabIndex = 13
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Info
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Location = New System.Drawing.Point(6, 27)
        Me.txtname.Name = "txtname"
        Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtname.Size = New System.Drawing.Size(194, 25)
        Me.txtname.TabIndex = 9
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Location = New System.Drawing.Point(259, 27)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcode.Size = New System.Drawing.Size(161, 25)
        Me.txtcode.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":تعداد کل"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":قيمت فروش"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":واحد کالا"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(201, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":تاريخ خريد"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":نوع کالا"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":قيمت خريد"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":نام کالا"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtnum)
        Me.GroupBox1.Controls.Add(Me.txtsellprice)
        Me.GroupBox1.Controls.Add(Me.txtunit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtgroup_g)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txttype)
        Me.GroupBox1.Controls.Add(Me.txtbuyprice)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 221)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطاعات مربوط به اجناس"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(201, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = ":گروه کالا"
        '
        'txtgroup_g
        '
        Me.txtgroup_g.BackColor = System.Drawing.SystemColors.Info
        Me.txtgroup_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgroup_g.Location = New System.Drawing.Point(6, 179)
        Me.txtgroup_g.Name = "txtgroup_g"
        Me.txtgroup_g.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtgroup_g.Size = New System.Drawing.Size(194, 25)
        Me.txtgroup_g.TabIndex = 25
        '
        'frmresult
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(505, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.cmdlast)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.cmdprev)
        Me.Controls.Add(Me.cmdfirst)
        Me.Controls.Add(Me.DataGride2)
        Me.MaximizeBox = False
        Me.Name = "frmresult"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نتیجه جستجو"
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim myDataset As New DataSet
    Dim Nextb As Long
    Dim PrevB As Long
    Dim TotalC As Long

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
                txtbuyprice.Text = (MyDataReader.Item(3))
                txtsellprice.Text = (MyDataReader.Item(4))
                txtdob.Text = (MyDataReader.Item(5))
                txtnum.Text = (MyDataReader.Item(6))
                txtaddress.Text = (MyDataReader.Item(7))
                txttype.Text = (MyDataReader.Item(8))
                txtgroup_g.Text = (MyDataReader.Item(9))
            Loop



        Catch err As System.Exception




            MyDataReader.Close()


            OleDbCon.Close()
            OleDbCon.Dispose()
        End Try

    End Function
    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)
        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        myDataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(myDataset, "searchresult2")


        Me.DataGride2.DataSource = myDataset.Tables(0)


        Analyze_position()
        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        myDataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With DataGride2
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.FixedSingle
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "محصولات پرديس"
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
            .MappingName = myDataset.Tables(0).TableName
            .PreferredColumnWidth = 80
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "کد"
            .MappingName = "code_g"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "نام کالا"
            .MappingName = "name"
            .Alignment = HorizontalAlignment.Center
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "واحد"
            .MappingName = "unit"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "قيمت خريد"
            .MappingName = "buyprice"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "قيمت فروش"
            .MappingName = "sellprice"
            '.Width = 50
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "تاريخ خريد"
            .MappingName = "dob"
            .Alignment = HorizontalAlignment.Center
            '.Width = 75
            '.ReadOnly = True
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "تعداد"
            .MappingName = "num"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "آدرس"
            .MappingName = "address"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "نوع کالا"
            .MappingName = "type"
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "گروه کالا"
            .MappingName = "group_g"
            .Alignment = HorizontalAlignment.Center
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10})

        DataGride2.TableStyles.Add(grdTableStyle1)

    End Function
    Private Function Analyze_position()
        Nextb = 0
        PrevB = 0
        Dim x = myDataset.Tables(0).Rows.Count
        TotalC = x - 1
        FILL(0)
    End Function

    Private Sub DataGride2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGride2.Click
        Dim SqlStr As String

        SqlStr = "select * from goods where goods.code_g = " & DataGride2.Item(DataGride2.CurrentRowIndex, 0)
        FillTextBox(SqlStr)

    End Sub

    Private Function FILL(ByVal X As Long)
        If myDataset Is Nothing Then Exit Function
        Try
            With myDataset.Tables(0).Rows(X)
                txtcode.Text = IIf(IsDBNull(.Item("code_g")), "NULL", .Item("code_g"))
                txtname.Text = IIf(IsDBNull(.Item("name")), "NULL", .Item("name"))
                txtunit.Text = IIf(IsDBNull(.Item("unit")), "NULL", .Item("unit"))
                txtbuyprice.Text = IIf(IsDBNull(.Item("buyprice")), "NULL", .Item("buyprice"))
                txtsellprice.Text = IIf(IsDBNull(.Item("sellprice")), "NULL", .Item("sellprice"))
                txtdob.Text = IIf(IsDBNull(.Item("dob")), "NULL", .Item("dob"))
                txtnum.Text = IIf(IsDBNull(.Item("num")), "NULL", .Item("num"))
                txtaddress.Text = IIf(IsDBNull(.Item("address")), "NULL", .Item("address"))
                txttype.Text = IIf(IsDBNull(.Item("type")), "NULL", .Item("type"))
                txtgroup_g.Text = IIf(IsDBNull(.Item("group_g")), "NULL", .Item("group_g"))
            End With
        Catch err As Exception

        End Try
        txtposition.Text = "          " & X

    End Function

    Private Sub frmresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        Nextb = Nextb + 1
        If Nextb >= TotalC Then
            Nextb = TotalC
        End If

        FILL(Nextb)
    End Sub

    Private Sub cmdprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprev.Click
        'Stop
        If Nextb <= 0 Then
            PrevB = 0
        Else
            PrevB = Nextb - 1
            Nextb = PrevB
        End If

        If PrevB <= 0 Then
            PrevB = 0
        End If
        FILL(PrevB)
    End Sub

    Private Sub cmdlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlast.Click
        FILL(TotalC)
    End Sub

    Private Sub cmdfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfirst.Click
        FILL(0)
    End Sub

    Private Sub txtnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnum.TextChanged

    End Sub

    Private Sub txtunit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunit.TextChanged

    End Sub

    Private Sub DataGride2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGride2.Navigate

    End Sub

    Private Sub txtsellprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsellprice.TextChanged

    End Sub
End Class
