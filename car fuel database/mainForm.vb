

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenSQLiteConn("C:\Users\Rehaell\Source\Repos\car-fuel-database\car fuel database\")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CardToolStripMenuItem1.Click

    End Sub
End Class
