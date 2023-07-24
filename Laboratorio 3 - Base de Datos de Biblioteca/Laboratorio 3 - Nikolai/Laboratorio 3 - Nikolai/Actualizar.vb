Imports System.Data
Imports System.Data.SqlClient
Public Class Actualizar
    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Laboratorio_3___HerramientasDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me._Laboratorio_3___HerramientasDataSet1.Books)
        'TODO: This line of code loads data into the '_Laboratorio_3___HerramientasDataSet.Authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me._Laboratorio_3___HerramientasDataSet.Authors)
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        LoadDataInGridAutor()
        LoadDataInGridLibro()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
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

    'Solo numeros id'
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo numeros id'
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Limpiar txtbox'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Clear()
    End Sub

    'Limpiar txtbox'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Clear()
    End Sub

    'Solo Letras Pais'
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Actualizar Autor'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control2 As Integer
        Dim id As Integer = TextBox4.Text
        Dim autor As String = TextBox1.Text
        Dim pais As String = TextBox2.Text
        Dim consultaAutor As String
        control2 = 0

        If autor = "" Or pais = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaAutor = "Update Authors set Name = '" & autor & "', Country = '" & pais & "' where Id = '" & id & "'"

            Dim command2 As New SqlCommand(consultaAutor, con)

            control2 = command2.ExecuteNonQuery()

            If control2 > 0 Then
                MsgBox("La actualizacion se ha realizado con exito",, "Alerta")
                LoadDataInGridAutor()
            End If
        End If
    End Sub

    'Actualizar Libro'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control As Integer
        Dim id As Integer = TextBox5.Text
        Dim titulo As String = TextBox3.Text
        Dim consultaLibro As String
        control = 0

        If titulo = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaLibro = "Update Books set Title = '" & titulo & "' where Id = '" & id & "'"

            Dim command2 As New SqlCommand(consultaLibro, con)

            control = command2.ExecuteNonQuery()

            If control > 0 Then
                MsgBox("La actualizacion se ha realizado con exito",, "Alerta")
                LoadDataInGridLibro()
            End If
        End If
    End Sub

    'Limpiar libros'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox5.Clear()
        TextBox3.Clear()
    End Sub

    'Limpiar Autor'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub IngresarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarDatosToolStripMenuItem.Click
        Ingresar.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BorrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarDatosToolStripMenuItem.Click
        Borrar.Show()
        Me.Hide()
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class