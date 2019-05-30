Module Databse
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public path As String = Application.StartupPath & "\DBForFoodManagement" '.mdb"
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public cmd As New OleDb.OleDbCommand
    Public cnn As New OleDb.OleDbConnection
    Public Sub connection()
        cn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Persist Security Info=True")
    End Sub
    Public Sub connect2()
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Persist Security Info=True"
    End Sub
End Module