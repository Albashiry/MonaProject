Public Class Home

    Private Sub تعدلالبياناتالشخصيهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعدلالبياناتالشخصيهToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub الطلابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الطلابToolStripMenuItem.Click
        Students.Show()
    End Sub

    Private Sub المشرفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المشرفينToolStripMenuItem.Click
        Supervisors.Show()
    End Sub

    Private Sub جهاتالتدريبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جهاتالتدريبToolStripMenuItem.Click
        Companies.Show()
    End Sub

    Private Sub الاطلاععلىالتقاريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاطلاععلىالتقاريرToolStripMenuItem.Click
        Report_read.Show()
    End Sub

    Private Sub ارفاقخطةتدريبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارفاقخطةتدريبToolStripMenuItem.Click
        Plans.Show()
    End Sub

    Private Sub إرفاقتقريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إرفاقتقريرToolStripMenuItem.Click
        Report_submit.Show()
    End Sub
End Class