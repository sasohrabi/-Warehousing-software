Imports System.Data.OleDb
Imports System.String
Imports vb = Microsoft.VisualBasic

Public Class frmrpt5
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
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents msk1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cmdprint = New System.Windows.Forms.Button
        Me.chk1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.msk1 = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(1028, 515)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'cmdprint
        '
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(5, 5)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(80, 20)
        Me.cmdprint.TabIndex = 12
        Me.cmdprint.Text = "چاپ"
        '
        'chk1
        '
        Me.chk1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.chk1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk1.Location = New System.Drawing.Point(213, 5)
        Me.chk1.Name = "chk1"
        Me.chk1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk1.Size = New System.Drawing.Size(108, 21)
        Me.chk1.TabIndex = 11
        Me.chk1.Text = "سال کبيسه منظور شود"
        Me.chk1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "در سال"
        '
        'msk1
        '
        Me.msk1.BackColor = System.Drawing.SystemColors.Info
        Me.msk1.Location = New System.Drawing.Point(84, 5)
        Me.msk1.Mask = "13##"
        Me.msk1.Name = "msk1"
        Me.msk1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msk1.Size = New System.Drawing.Size(84, 20)
        Me.msk1.TabIndex = 13
        '
        'frmrpt5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 515)
        Me.Controls.Add(Me.msk1)
        Me.Controls.Add(Me.cmdprint)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.crv)
        Me.Name = "frmrpt5"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مجموع پول فاکتورهای خرید"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Try
            Dim OleDbConn2 As OleDbConnection = New OleDbConnection(strcon)
            Dim MyOledbCommand2 As OleDbCommand = New OleDbCommand
            MyOledbCommand2.Connection = OleDbConn2
            MyOledbCommand2.CommandText = "DELETE * FROM tempsumprice2"

            OleDbConn2.Open()
            MyOledbCommand2.ExecuteNonQuery()
            OleDbConn2.Close()

            Dim i As Integer = 0
            Dim strdate1 As String = vb.Left(msk1.Text, 4)
            'Dim strdate2 As String = vb.Left(msk2.CtlText, 4)



            Dim OleDbConn As OleDbConnection = New OleDbConnection(strcon)


            Dim MyOledbCommand As OleDbCommand = New OleDbCommand
            MyOledbCommand.Connection = OleDbConn


            For i = 1 To 12
                Select Case i
                    Case 1 To 6
                        MyOledbCommand.CommandText = "INSERT INTO tempsumprice2(sumfactorbuy) " & _
                        "SELECT SUM(sumprice) " & _
                       " FROM buy WHERE dob Between  '" & strdate1 & "/" & 0 & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & 0 & i & "/" & 31 & "'"

                        OleDbConn.Open()
                        MyOledbCommand.ExecuteNonQuery()
                        OleDbConn.Close()
                    Case 7 To 9
                        MyOledbCommand.CommandText = "INSERT INTO tempsumprice2(sumfactorbuy) " & _
                        "SELECT SUM(sumprice) " & _
                        " FROM buy WHERE dob Between  '" & strdate1 & "/" & 0 & i & " / " & 0 & 1 & " '" & " And  '" & strdate1 & "/" & 0 & i & "/" & 30 & "'"

                        OleDbConn.Open()
                        MyOledbCommand.ExecuteNonQuery()
                        OleDbConn.Close()
                    Case 10, 11
                        MyOledbCommand.CommandText = "INSERT INTO tempsumprice2(sumfactorbuy)" & _
                        "SELECT sum(sumprice) " & _
                        " FROM buy WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 30 & "'"

                        OleDbConn.Open()
                        MyOledbCommand.ExecuteNonQuery()
                        OleDbConn.Close()
                    Case 12
                        If chk1.Checked Then
                            MyOledbCommand.CommandText = "INSERT INTO tempsumprice2 (sumfactorbuy)" & _
                              "SELECT sum(sumprice) " & _
                              " FROM buy WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 29 & "'"

                            OleDbConn.Open()
                            MyOledbCommand.ExecuteNonQuery()
                            OleDbConn.Close()
                        Else
                            MyOledbCommand.CommandText = "INSERT INTO tempsumprice2 (sumfactorbuy)" & _
                                                          "SELECT sum(sumprice) " & _
                                                          " FROM buy WHERE dob Between  '" & strdate1 & "/" & i & "/" & 0 & 1 & "'" & " And  '" & strdate1 & "/" & i & "/" & 30 & "'"

                            OleDbConn.Open()
                            MyOledbCommand.ExecuteNonQuery()
                            OleDbConn.Close()


                        End If

                End Select
            Next

            Dim rpt As New rpt5
            crv.ReportSource = rpt
            crv.RefreshReport()
 

        Catch err As System.Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load

    End Sub
End Class
