Imports System.Diagnostics
Module auxFunctions
    Public Function Log(text As String)
        Trace.WriteLine(Date.Now & " - " & text)
        Return 0
    End Function

End Module
