
Imports System.Data.OleDb
Public Class frmresult2
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents DataGride2 As System.Windows.Forms.DataGrid
    Friend WithEvents txttel_office As System.Windows.Forms.TextBox
    Friend WithEvents txtclerk As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsiba As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttel_mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttype_v As System.Windows.Forms.TextBox
    Friend WithEvents cng1 As ControleNavegador.ControleNavegador
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txttel_office = New System.Windows.Forms.TextBox
        Me.txtclerk = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.DataGride2 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtsiba = New System.Windows.Forms.TextBox
        Me.cng1 = New ControleNavegador.ControleNavegador
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttel_mobile = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttype_v = New System.Windows.Forms.TextBox
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":کد تهیه کننده"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":نام تهبه کننده"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":منشی تهیه کننده"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(464, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":تلفن تهیه کننده"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":آدرس تهیه کننده"
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
        Me.DataGride2.TabIndex = 16
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
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطاعات مربوط به تهیه کنندگان"
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
        'cng1
        '
        Me.cng1.DataSource = Nothing
        Me.cng1.Location = New System.Drawing.Point(62, 175)
        Me.cng1.Name = "cng1"
        Me.cng1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cng1.Size = New System.Drawing.Size(428, 40)
        Me.cng1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = ":موبایل تهیه کننده"
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
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(194, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "نوع تهیه کننده:"
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
        'frmresult2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(566, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGride2)
        Me.Controls.Add(Me.cng1)
        Me.MaximizeBox = False
        Me.Name = "frmresult2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " نتیجه جستجو"
        CType(Me.DataGride2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myDataset As New DataSet
    'Dim Nextb As Long
    'Dim PrevB As Long
    'Dim TotalC As Long

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


                txtcode.Text = (MyDataReader.Item(0).ToString)
                txtname.Text = (MyDataReader.Item(1).ToString)
                txttel_office.Text = (MyDataReader.Item(2).ToString)
                txttel_mobile.Text = (MyDataReader.Item(3).ToString)
                txtclerk.Text = (MyDataReader.Item(4).ToString)
                txtaddress.Text = (MyDataReader.Item(5).ToString)
                txtsiba.Text = (MyDataReader.Item(6).ToString)
                txttype_v.Text = (MyDataReader.Item(7).ToString)
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
        MyOleDataAdapter.Fill(myDataset, "searchresult3")


        Me.DataGride2.DataSource = myDataset.Tables(0)
        cng1.DataSource = Me.BindingContext(myDataset.Tables(0))

        txtcode.DataBindings.Add("text", myDataset.Tables(0), "code_s")
        txtname.DataBindings.Add("text", myDataset.Tables(0), "name")
        txttel_office.DataBindings.Add("text", myDataset.Tables(0), "tel_office")
        txttel_mobile.DataBindings.Add("text", myDataset.Tables(0), "tel_mobile")
        txtclerk.DataBindings.Add("text", myDataset.Tables(0), "clerk")
        txtaddress.DataBindings.Add("text", myDataset.Tables(0), "address")
        txtsiba.DataBindings.Add("text", myDataset.Tables(0), "siba")
        txttype_v.DataBindings.Add("text", myDataset.Tables(0), "type_v")

        'Analyze_position()
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
            .CaptionText = "اطلاعات فراهم کنندگان"
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
            .HeaderText = "کد تهیه کننده"
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
            .HeaderText = "تلفن تهیه کننده"
            .MappingName = "tel_office"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "موبایل تهیه کننده"
            .MappingName = "tel_mobile"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "منشي تهیه کننده"
            .MappingName = "clerk"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With
        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "آدرس تهیه کننده"
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
            .HeaderText = "نوع تهیه کننده"
            .MappingName = "type_v"
            '.Width = 50
        End With

       

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})

        DataGride2.TableStyles.Add(grdTableStyle1)

    End Function
    'Private Function Analyze_position()
    '    Nextb = 0
    '    PrevB = 0
    '    Dim x = myDataset.Tables(0).Rows.Count
    '    TotalC = x - 1
    '    FILL(0)
    'End Function

    Private Sub DataGride2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGride2.Click
        Dim SqlStr As String

        SqlStr = "select * from Suppliers where code_s = " & DataGride2.Item(DataGride2.CurrentRowIndex, 0)
        FillTextBox(SqlStr)

    End Sub

    'Private Function FILL(ByVal X As Long)
    '    If myDataset Is Nothing Then Exit Function
    '    Try
    '        With myDataset.Tables(0).Rows(X)
    '            txtcode.Text = IIf(IsDBNull(.Item("code")), "NULL", .Item("code"))
    '            txtname.Text = IIf(IsDBNull(.Item("goods.name")), "NULL", .Item("goods.name"))
    '            txtunit.Text = IIf(IsDBNull(.Item("unit")), "NULL", .Item("unit"))
    '            txtbuyprice.Text = IIf(IsDBNull(.Item("buyprice")), "NULL", .Item("buyprice"))
    '            txtsellprice.Text = IIf(IsDBNull(.Item("sellprice")), "NULL", .Item("sellprice"))
    '            txtcompany.Text = IIf(IsDBNull(.Item("company.name")), "NULL", .Item("company.name"))
    '            txtdob.Text = IIf(IsDBNull(.Item("dob")), "NULL", .Item("dob"))
    '            txtnum.Text = IIf(IsDBNull(.Item("num")), "NULL", .Item("num"))

    '        End With
    '    Catch err As Exception

    '    End Try
    '    txtposition.Text = "          " & X

    'End Function

    'Private Sub frmresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
    '    Nextb = Nextb + 1
    '    If Nextb >= TotalC Then
    '        Nextb = TotalC
    '    End If

    '    FILL(Nextb)
    'End Sub

    'Private Sub cmdprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprev.Click
    '    'Stop
    '    If Nextb <= 0 Then
    '        PrevB = 0
    '    Else
    '        PrevB = Nextb - 1
    '        Nextb = PrevB
    '    End If

    '    If PrevB <= 0 Then
    '        PrevB = 0
    '    End If
    '    FILL(PrevB)
    'End Sub

    'Private Sub cmdlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlast.Click
    '    FILL(TotalC)
    'End Sub

    'Private Sub cmdfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfirst.Click
    '    FILL(0)
    'End Sub

    Private Sub frmresult2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cng1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cng1.Load

    End Sub
End Class

