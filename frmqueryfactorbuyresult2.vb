Imports System.Data.OleDb

Public Class frmqueryfactorbuyresult2
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
    Friend WithEvents datagridefactor As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtgoodname As System.Windows.Forms.TextBox
    Friend WithEvents txtvendorname As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.datagridefactor = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtgoodname = New System.Windows.Forms.TextBox
        Me.txtvendorname = New System.Windows.Forms.TextBox
        CType(Me.datagridefactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagridefactor
        '
        Me.datagridefactor.DataMember = ""
        Me.datagridefactor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagridefactor.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridefactor.Location = New System.Drawing.Point(0, 83)
        Me.datagridefactor.Name = "datagridefactor"
        Me.datagridefactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datagridefactor.Size = New System.Drawing.Size(560, 456)
        Me.datagridefactor.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtgoodname)
        Me.GroupBox1.Controls.Add(Me.txtvendorname)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 72)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فيلتر کردن اطلاعات موجود"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "بر اساس جنس خريداري شده"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(432, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "بر اساس نام فروشنده"
        '
        'txtgoodname
        '
        Me.txtgoodname.BackColor = System.Drawing.SystemColors.Info
        Me.txtgoodname.Location = New System.Drawing.Point(8, 32)
        Me.txtgoodname.Name = "txtgoodname"
        Me.txtgoodname.Size = New System.Drawing.Size(128, 22)
        Me.txtgoodname.TabIndex = 2
        '
        'txtvendorname
        '
        Me.txtvendorname.BackColor = System.Drawing.SystemColors.Info
        Me.txtvendorname.Location = New System.Drawing.Point(296, 32)
        Me.txtvendorname.Name = "txtvendorname"
        Me.txtvendorname.Size = New System.Drawing.Size(136, 22)
        Me.txtvendorname.TabIndex = 1
        '
        'frmqueryfactorbuyresult2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(560, 539)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datagridefactor)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frmqueryfactorbuyresult2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نتيجه جستجو"
        CType(Me.datagridefactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mydataset As New DataSet

    Public Function FillDataGrid(ByVal Sqlstring As String)

        Dim OleDbConn As New OleDbConnection(strcon)

        OleDbConn.Open()

        'Dim MyDataSet As New DataSet
        mydataset.Clear()

        Dim MyOleDataAdapter As New OleDbDataAdapter
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConn)
        MyOleDataAdapter.Fill(mydataset, "srchresult")


        Me.datagridefactor.DataSource = mydataset.Tables(0)

        FormatGridWithTableStyles()

        MyOleDataAdapter.Dispose()
        mydataset.Dispose()
        OleDbConn.Close()
        OleDbConn.Dispose()

    End Function
    Private Function FormatGridWithTableStyles()
        With datagridefactor
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .CaptionText = "فاکتور خريد"
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
            .HeaderText = "تاريخ"
            .MappingName = "dob"
            '.Width = 50
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "فاکتور"
            .MappingName = "factor"
            .Alignment = HorizontalAlignment.Center
        End With
        '
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "کد تهیه کننده"
            .MappingName = "code_s"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "نام تهیه کننده"
            .MappingName = "Suppliers.name"
            ' .Width = 75
            '   .ReadOnly = True
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "کد کالا"
            .MappingName = "code_g"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "نام کالا"
            .MappingName = "goods.name"
            '.Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "في خريد"
            .MappingName = "buyprice"
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "في فروش"
            .MappingName = "sellprice"
            .Alignment = HorizontalAlignment.Center
            '.Width = 75
            '.ReadOnly = True
        End With

        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "تعداد"
            .MappingName = "num"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "قيمت کل"
            .MappingName = "sumprice"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4 _
            , grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8 _
            , grdColStyle9, grdColStyle10})

        datagridefactor.TableStyles.Add(grdTableStyle1)

    End Function

    Private Sub datagridefactor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagridefactor.Click
        'Dim SqlStr As String
        'Dim frm As New frmupdelfactorbuy
        'frm.Show()
        'SqlStr = "Select * from buy where factor = " & datagridefactor.Item(datagridefactor.CurrentRowIndex, 1) _
        '                           ' & " and code = " & datagridefactor.Item(datagridefactor.CurrentRowIndex, 3)
        'frm.filllst(SqlStr)
    End Sub

    Private Sub txtgoodname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgoodname.TextChanged
        Const MESSAGEBOX_CAPTION As String = "جستجو"

        With mydataset.Tables(0)
            .DefaultView.RowFilter = "goods.name like '%" & txtgoodname.Text.Trim & "%'"

            If .DefaultView.Count = 0 Then

                MessageBox.Show("رکوردي با اين مشخصات وجود ندارد", _
                MESSAGEBOX_CAPTION, MessageBoxButtons.OK, _
                MessageBoxIcon.Information)

            End If
            datagridefactor.DataSource = .DefaultView

        End With
    End Sub

    Private Sub txtvendorname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendorname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtgoodname.Focus()

        End If
    End Sub


    Private Sub txtvendorname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvendorname.TextChanged
        Const MESSAGEBOX_CAPTION As String = "جستجو"
        If txtvendorname.Text.Trim <> "" Then
            With mydataset.Tables(0)
                .DefaultView.RowFilter = "Suppliers.name like '%" & txtvendorname.Text.Trim & "%'"

                If .DefaultView.Count = 0 Then

                    MessageBox.Show("رکوردي با اين مشخصات وجود ندارد", _
                    MESSAGEBOX_CAPTION, MessageBoxButtons.OK, _
                    MessageBoxIcon.Information)

                End If
                datagridefactor.DataSource = .DefaultView

            End With
        End If
    End Sub

    Private Sub frmqueryfactorbuyresult2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtvendorname.Focus()
        Me.txtvendorname.TabIndex = 0
    End Sub

    Private Sub datagridefactor_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles datagridefactor.Navigate

    End Sub
End Class