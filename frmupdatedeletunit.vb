Imports System.String
Imports System.Data.OleDb

Public Class frmupdatedeletunit
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cbosearchby As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.cbosearchby = New System.Windows.Forms.ComboBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":نام واحد"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":کد"
        '
        'txtunit
        '
        Me.txtunit.BackColor = System.Drawing.SystemColors.Info
        Me.txtunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtunit.Location = New System.Drawing.Point(88, 88)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtunit.Size = New System.Drawing.Size(120, 22)
        Me.txtunit.TabIndex = 5
        '
        'cmdupdate
        '
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdupdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(168, 136)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdupdate.TabIndex = 9
        Me.cmdupdate.Text = "تغيير"
        '
        'cmdclear
        '
        Me.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdclear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(88, 136)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 23)
        Me.cmdclear.TabIndex = 10
        Me.cmdclear.Text = "پاک"
        '
        'cmdexit
        '
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(8, 136)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 11
        Me.cmdexit.Text = "خروج"
        '
        'cmddelete
        '
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmddelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(248, 136)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 12
        Me.cmddelete.Text = "حذف"
        '
        'cmdsearch
        '
        Me.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(8, 8)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 21)
        Me.cmdsearch.TabIndex = 13
        Me.cmdsearch.Text = "جستجو"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtsearch.Location = New System.Drawing.Point(88, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(120, 22)
        Me.txtsearch.TabIndex = 14
        '
        'cbosearchby
        '
        Me.cbosearchby.BackColor = System.Drawing.SystemColors.Info
        Me.cbosearchby.Items.AddRange(New Object() {"کد", "نام"})
        Me.cbosearchby.Location = New System.Drawing.Point(216, 8)
        Me.cbosearchby.Name = "cbosearchby"
        Me.cbosearchby.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbosearchby.Size = New System.Drawing.Size(104, 24)
        Me.cbosearchby.TabIndex = 15
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Enabled = False
        Me.txtcode.Location = New System.Drawing.Point(88, 48)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcode.Size = New System.Drawing.Size(120, 22)
        Me.txtcode.TabIndex = 4
        '
        'frmupdatedeletunit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(328, 179)
        Me.Controls.Add(Me.cbosearchby)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdclear)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtcode)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmupdatedeletunit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تغییر واحد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


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
                strquery += " WHERE code = "
                strquery += txtsearch.Text
            ElseIf (Compare(strsearch, "واحد", True) = 0) Then
                strquery += " WHERE unit like '"
                strquery += txtsearch.Text & "%'"

            End If
        Else
            strquery = ""
        End If

    End Function

    Public Function FillTextBox(ByVal Sqlstring As String)

        Dim OleDbCon As OleDbConnection = New OleDbConnection(strcon)
        OleDbCon.Open()

        Dim MyDataReader As OleDbDataReader

        Dim OleCommand As OleDbCommand = New OleDbCommand
        OleCommand.Connection = (OleDbCon)
        OleCommand.CommandText = Sqlstring

        MyDataReader = OleCommand.ExecuteReader


        Do While MyDataReader.Read


            txtcode.Text = (MyDataReader.Item(0))
            txtunit.Text = (MyDataReader.Item(1))
        Loop

        If (txtcode.Text = "") Then
            txtcode.Focus()
        End If
        OleDbCon.Close()
        OleDbCon.Dispose()
        txtcode.Enabled = False

    End Function

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        Dim strquery As String = "select * from units"
        makequery(strquery)
        FillTextBox(strquery)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        Try
            Dim string1 As Integer = txtcode.Text
            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
            OleDbConn.Open()


            Dim MyOledbCommand As OleDbCommand = New OleDbCommand


            MyOledbCommand.CommandText = "DELETE FROM units WHERE code=" & string1

            MyOledbCommand.Connection = OleDbConn

            MyOledbCommand.ExecuteNonQuery()
            OleDbConn.Close()

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        If txtcode.Text <> "" And txtunit.Text <> "" Then
            Try
                Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)
                OleDbConn.Open()

                Dim MyOledbCommand As OleDbCommand = New OleDbCommand

                MyOledbCommand.CommandText = "Update units Set " _
                & "unit='" & txtunit.Text & "'  " _
                & "WHERE code = " & txtcode.Text


                MyOledbCommand.Connection = OleDbConn

                MyOledbCommand.ExecuteNonQuery()
                OleDbConn.Close()
            Catch
                MessageBox.Show("این رکورد قبلا در جدول واحد ثبت شده است")
            End Try

        Else
            MessageBox.Show("لطفا ابتدا تمام اطلاعات را وارد کنيد سپس روي دکمه ذخيره کليک کنيد")

        End If



    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtsearch.Text = ""
        txtcode.Text = ""
        txtunit.Text = ""

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()

    End Sub

    Private Sub cbosearchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosearchby.SelectedIndexChanged
        txtsearch.Focus()

    End Sub
End Class
