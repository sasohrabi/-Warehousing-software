Option Strict Off
Option Explicit On 
Module ModMain
    Public Structure SHFILEOPSTRUCT
        Dim hWnd As Integer
        Dim wFunc As Integer
        Dim pFrom As String
        Dim pTo As String
        Dim fFlags As Short
        Dim fAnyOperationsAborted As Boolean
        Dim hNameMappings As Integer
        Dim lpszProgressTitle As String
    End Structure

    'UPGRADE_WARNING: Structure SHFILEOPSTRUCT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
    Public Declare Function SHFileOperation Lib "shell32.dll" Alias "SHFileOperationA" (ByRef lpFileOp As SHFILEOPSTRUCT) As Integer
    Public Const FO_COPY As Short = &H2S
    Public Const FOF_ALLOWUNDO As Short = &H40S
    Public Counts As Integer


    Public Function FileExists(ByVal sPathName As String) As Boolean
        On Error Resume Next
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2049"'
        FileExists = (GetAttr(sPathName) And vbNormal) = vbNormal
        On Error GoTo 0
    End Function

    Public Sub CopyFileWindowsWay(ByRef SourceFile As String, ByRef DestinationFile As String)

        Dim lngReturn As Integer
        Dim typFileOperation As SHFILEOPSTRUCT

        With typFileOperation
            .hWnd = 0
            .wFunc = FO_COPY
            .pFrom = SourceFile & vbNullChar & vbNullChar 'source file
            .pTo = DestinationFile & vbNullChar & vbNullChar 'destination file
            .fFlags = FOF_ALLOWUNDO
        End With
        lngReturn = SHFileOperation(typFileOperation)
    End Sub
End Module
