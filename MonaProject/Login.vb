Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "qw" And TextBox2.Text = "12" Then
            Home.Show()
            Me.Hide()
        Else
            MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة")

        End If
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Users.Show()
        Me.Close()
    End Sub
End Class
