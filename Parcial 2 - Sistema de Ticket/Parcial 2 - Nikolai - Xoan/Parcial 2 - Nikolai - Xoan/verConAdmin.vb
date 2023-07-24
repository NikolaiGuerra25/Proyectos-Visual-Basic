Imports System.Data.SqlClient
Imports System.Data
Public Class verConAdmin

    'Llenado Tabla con Vista'
    Private Sub verConAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim consultaAdmin As String

        consultaAdmin = "Select * from VistaAdmin"

        Dim command0 As New SqlCommand(consultaAdmin, con)

        Dim sda As New SqlDataAdapter(command0)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub

    'filtrar'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim filtro As String
        Dim urgencia As String = ComboBox1.Text

        filtro = "Select * from VistaAdmin where Urgencia = '" & urgencia & "'"

        Dim command As New SqlCommand(filtro, con)

        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Quitar Filtro'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim efiltro As String

        efiltro = "Select * from VistaAdmin"

        Dim command3 As New SqlCommand(efiltro, con)

        Dim sda As New SqlDataAdapter(command3)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Filtrar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim filtro As String
        Dim estado As String = ComboBox2.Text

        filtro = "Select * from VistaAdmin where Estado = '" & estado & "'"

        Dim command As New SqlCommand(filtro, con)

        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Quitar Filtro'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim efiltro As String

        efiltro = "Select * from VistaAdmin"

        Dim command3 As New SqlCommand(efiltro, con)

        Dim sda As New SqlDataAdapter(command3)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class