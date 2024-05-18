Imports System.Data.OleDb
Public Class Report_read
    Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\trainDB.accdb")
    Dim Da As OleDbDataAdapter
    Dim Dt As New DataTable

    Dim query As New String("select sys_users.fullname, student.speciality,student.university, student.college,report.report_text, report.report_date from student, sys_users, report where student.user_id=sys_users.user_id and student.std_id=report.std_id")

    Private Sub Report_read_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt.Clear()
        Da = New OleDbDataAdapter(query, Con)
        Da.Fill(Dt)
        DGVrep.DataSource = Dt
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub
End Class