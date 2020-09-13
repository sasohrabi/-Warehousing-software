Public Class frn

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        strcon = _
  "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source =F:\pardis.mdb;Persist Security Info=False;"
        Try
            Dim OleDbCon As OleDb.OleDbConnection = New OleDb.OleDbConnection(strcon)
            OleDbCon.Open()
        Catch ex As Exception
            MsgBox("مشکلی در برقراری اتصال پیش آمده")
            Exit Sub

        End Try

        MsgBox("اتصال با موفقیت بر قرار شد")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SourceDir As String
        Dim DestDir As String
        Dim DatabaseFile As String
        Dim DistanationFile As String
        Dim Source As String
        Dim Destination As String
        Dim result As Integer = 0

        'find out if there is file selected
        If file1.FileName = "" Then
            MsgBox("لطفا ابتدا روي فايل مربوطه کليک کنيد", MsgBoxStyle.OkOnly, "فايلي انتخاب نشده")
            Exit Sub
        End If



        DatabaseFile = file1.FileName
        If Len(Dir1.Path) > 3 Then 'not a root directory
            SourceDir = Dir1.Path & "\"
            Source = SourceDir & DatabaseFile
        Else
            SourceDir = Dir1.Path
            Source = SourceDir & DatabaseFile
        End If



        strcon = _
  "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source =" & Source & ";Persist Security Info=False;"
        Try
            Dim OleDbCon As OleDb.OleDbConnection = New OleDb.OleDbConnection(strcon)
            OleDbCon.Open()
        Catch ex As Exception
            MsgBox("مشکلی در برقراری اتصال پیش آمده")
            Exit Sub

        End Try

        MsgBox("اتصال با موفقیت بر قرار شد")
    End Sub

    Private Sub Drive1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drive1.SelectedIndexChanged
        On Error GoTo ErrHandlerDriveChange
        Dir1.Path = Drive1.Drive
        Dir1.Refresh()
        Exit Sub
ErrHandlerDriveChange:
        MsgBox("خطا: " & Err.Description, MsgBoxStyle.OkOnly, "خطا")
    End Sub

    Private Sub Dir1_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dir1.Change
        file1.Path = Dir1.Path
        file1.Refresh()
    End Sub
End Class