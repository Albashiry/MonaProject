Imports System.Data.OleDb
Public Class Supervisors
    Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\trainDB.accdb")
    Dim Da As OleDbDataAdapter
    Dim Dt As New DataTable

    Dim query As New String("select sys_users.fullname, supervisor.sposition, supervisor.university, sys_users.phone, sys_users.email from sys_users, supervisor where sys_users.user_id=supervisor.user_id")

    Private Sub Supervisors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt.Clear()
        Da = New OleDbDataAdapter(query, Con)
        Da.Fill(Dt)
        DGVsup.DataSource = Dt
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
End Class