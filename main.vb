
Module main

    Public strcon As String = _
      "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source =" & Application.StartupPath & "\pardis.mdb;Mode=ReadWrite;Persist Security Info=False;"
    Public strconSqlLite As String = _
       "Data Source=" & Application.StartupPath & "\checkrecived.sqlite;Version=3;"
    Public strpublicinttostr As String = ""
    Public strunit As String = ""
    Public debtor_or_creditor As Boolean = True
    Public debtor_or_creditor2 As Boolean = True
    Public add_or_up As Boolean = True
    Public add_or_up2 As Boolean = True
    Public intkey As Integer = 0
    Public codeCustomer As Integer = 0
    Public codeSupplier As Integer = 0

    '"Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source =E:\saeed\SAEED PROJECTS\VB.NET\pardis\data base\pardis.mdb;Mode=ReadWrite;Persist Security Info=False;Jet OLEDB:Database Password=83440085;"

End Module
