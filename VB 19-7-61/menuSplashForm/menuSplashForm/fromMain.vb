Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        My.Forms.fromStudents.ShowDialog()
    End Sub

    Private Sub MajorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MajorToolStripMenuItem.Click
        My.Forms.fromMajor.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.AboutBox1.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
