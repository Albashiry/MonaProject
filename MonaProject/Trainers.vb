Imports System.Data.OleDb
Public Class Trainers
    Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\trainDB.accdb")
    Dim Da As OleDbDataAdapter
    Dim Dt As New DataTable

    'correct query
    Dim query As New String("select sys_users.fullname,sys_users.phone,sys_users.email,tcompany.company_name from sys_users,trainer,tcompany where sys_users.user_id=trainer.user_id and trainer.company_id=tcompany.company_id")

    Private Sub Trainers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt.Clear()
        Da = New OleDbDataAdapter(query, Con)
        Da.Fill(Dt)
        DGVtr.DataSource = Dt
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Companies.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
End Class