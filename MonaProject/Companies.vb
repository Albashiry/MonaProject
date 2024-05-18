Imports System.Data.OleDb
Public Class Companies
    Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\trainDB.accdb")
    Dim Da As OleDbDataAdapter
    Dim Dt As New DataTable

    Dim query As New String("SELECT [tcompany].company_name, [tcompany].company_location, sys_users.phone, sys_users.email FROM tcompany, sys_users WHERE [tcompany].user_id=sys_users.user_id")

    Private Sub Companies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt.Clear()
        Da = New OleDbDataAdapter(query, Con)
        Da.Fill(Dt)
        DGVcom.DataSource = Dt
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnTrainers_Click(sender As Object, e As EventArgs) Handles btnTrainers.Click
        Trainers.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub
End Class