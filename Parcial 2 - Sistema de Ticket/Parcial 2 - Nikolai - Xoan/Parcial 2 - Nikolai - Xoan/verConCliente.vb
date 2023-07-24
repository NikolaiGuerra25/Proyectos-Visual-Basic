Imports System.Data.SqlClient
Public Class verConCliente
    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Hide()
        menuCliente.Show()
    End Sub

    'Llenado Tabla'
    Private Sub verConCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim consultasUser As String
        Dim usuario As String = Module1.usuario

        consultasUser = "Select * from Consulta where Cliente = '" & usuario & "'"

        Dim command0 As New SqlCommand(consultasUser, con)

        Dim sda As New SqlDataAdapter(command0)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class