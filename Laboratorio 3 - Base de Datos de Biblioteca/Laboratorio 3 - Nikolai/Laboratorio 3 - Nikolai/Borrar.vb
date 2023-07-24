Imports System.Data
Imports System.Data.SqlClient
Public Class Borrar
    Private Sub Borrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Laboratorio_3___HerramientasDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me._Laboratorio_3___HerramientasDataSet1.Books)
        'TODO: This line of code loads data into the '_Laboratorio_3___HerramientasDataSet.Authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me._Laboratorio_3___HerramientasDataSet.Authors)
        LoadDataInGridAutor()
        LoadDataInGridLibro()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub IngresarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarDatosToolStripMenuItem.Click
        Ingresar.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Actualizar.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'ComboBox'
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

    'Borrar Autor'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control2 As Integer
        Dim id As Integer = TextBox4.Text
        Dim consultaAutor As String
        control2 = 0

        If id = 0 Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaAutor = "Delete from Authors where Id = '" & id & "'"

            Dim command2 As New SqlCommand(consultaAutor, con)

            control2 = command2.ExecuteNonQuery()

            If control2 > 0 Then
                MsgBox("El borrado se ha realizado con exito",, "Alerta")
                LoadDataInGridAutor()
            End If
        End If
    End Sub

    'Limpiar id autor'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Clear()
    End Sub

    'limpiar id libro'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Clear()
    End Sub

    'Borrar Libro'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control As Integer
        Dim id As Integer = TextBox5.Text
        Dim consultaLibro As String
        control = 0

        If id = 0 Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaLibro = "Delete from Books where Id = '" & id & "'"

            Dim command2 As New SqlCommand(consultaLibro, con)

            control = command2.ExecuteNonQuery()

            If control > 0 Then
                MsgBox("El borrado se ha realizado con exito",, "Alerta")
                LoadDataInGridLibro()
            End If
        End If
    End Sub

    Private Sub BuscarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDatosToolStripMenuItem.Click
        Buscar.Show()
        Me.Hide()
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

    'Actualizar Libro'
    Private Sub LoadDataInGridLibro()
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        Dim comando As New SqlCommand("Select * from Books", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub
End Class