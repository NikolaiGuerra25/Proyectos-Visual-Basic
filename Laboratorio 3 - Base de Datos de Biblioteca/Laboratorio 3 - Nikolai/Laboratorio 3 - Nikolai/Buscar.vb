Imports System.Data
Imports System.Data.SqlClient

Public Class Buscar
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub InsertarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDatosToolStripMenuItem.Click
        Ingresar.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Actualizar.Show()
        Me.Hide()
    End Sub

    Private Sub BorrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarDatosToolStripMenuItem.Click
        Borrar.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'Buscar Autor'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control2 As Integer
        Dim autor As String = TextBox4.Text
        Dim consultaAutor As String
        
        control2 = 0

        If autor = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaAutor = "Select * from Authors where Name = '" & autor & "'"

            Dim command2 As New SqlCommand(consultaAutor, con)

            Dim sda As New SqlDataAdapter(command2)
            Dim dt As New DataTable

            sda.Fill(dt)
            DataGridView1.DataSource = dt
        End If
    End Sub

    'Combo Box'
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Autor" Then
            GroupBox1.Visible = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            GroupBox2.Visible = False
        End If
        If ComboBox1.Text = "Libro" Then
            GroupBox1.Visible = False
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            GroupBox2.Visible = True
        End If
    End Sub

    'Actualizar Autor'
    Private Sub LoadDataInGridAutor()
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        Dim comando As New SqlCommand("Select * from Authors", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Buscar Libro'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control As Integer
        Dim titulo As String = TextBox5.Text
        Dim consultaLibro As String
        control = 0

        If titulo = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaLibro = "Select * from Books where Title = '" & titulo & "'"

            Dim command0 As New SqlCommand(consultaLibro, con)

            Dim sda As New SqlDataAdapter(command0)
            Dim dt As New DataTable

            sda.Fill(dt)
            DataGridView2.DataSource = dt
        End If
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class