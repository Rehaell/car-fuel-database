Imports System.Diagnostics
Imports System.Data.SQLite
Imports System.IO
Module auxFunctions

    Public Function OpenSQLiteConn(dbLocation As String)
        Dim connection As String = "Data Source=" & dbLocation & "config\database.db; Version=3"

        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As New SQLiteCommand
        Dim SQLdr As SQLiteDataReader

        Log("Opening database connetion to " & connection)
        SQLConn.ConnectionString = connection
        Try
            SQLConn.Open()
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Function

    Public Function Log(text As String)
        Trace.WriteLine(message:=Date.Now & " - " & text)
        Return 0
    End Function

End Module
