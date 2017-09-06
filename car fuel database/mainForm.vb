
Imports System.Data.SQLite
Imports System.IO

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim connection As String = "Data Source=" & Directory.GetCurrentDirectory() & "\config\database.db; Version=3"
        Dim connection As String = "Data Source=C:\Users\Rehaell\Source\Repos\car-fuel-database\car fuel database\config\database.db; Version=3"

        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As New SQLiteCommand
        Dim SQLdr As SQLiteDataReader

        Log("Opening database connetion to " & connection)
        SQLConn.ConnectionString = connection
        SQLConn.Open()
    End Sub
End Class
