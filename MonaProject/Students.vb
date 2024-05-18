Imports System.Data.OleDb
Public Class Students
    Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\trainDB.accdb")
    Dim Da As OleDbDataAdapter
    Dim Dt As New DataTable

    Dim query As New String("SELECT [sys_users].fullname, student.speciality, student.college, student.university, [sys_users].phone, [sys_users].email FROM sys_users, student WHERE [sys_users].user_id=student.user_id")
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt.Clear()
        Da = New OleDbDataAdapter(query, Con)
        Da.Fill(Dt)
        DGVstd.DataSource = Dt
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'search code'
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'search code'
    End Sub
End Class