Imports System.Data
Imports System.Data.SqlClient
Public Class Ingresar
    Private Sub Ingresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
    End Sub

    'Insertar datos'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Laboratorio 3 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control, control2 As Integer
        Dim autor As String = TextBox2.Text
        Dim pais As String = TextBox3.Text
        Dim titulo As String = TextBox1.Text
        Dim consultaLibro As String
        Dim consultaAutor As String
        control = control2 = 0

        If titulo = "" Or
            autor = "" Or pais = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            consultaLibro = "Insert into Books (Title) Values('" & titulo & "')"
            consultaAutor = "Insert into Authors(Name,Country) Values('" & autor & "', '" & pais & "')"

            Dim command As New SqlCommand(consultaLibro, con)
            Dim command2 As New SqlCommand(consultaAutor, con)

            control = command.ExecuteNonQuery()
            control2 = command2.ExecuteNonQuery()

            If control > 0 And control2 > 0 Then
                MsgBox("La insercion se ha realizado con exito",, "Alerta")
            End If
        End If
    End Sub

    'Solo letras pais'
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Limpiar'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Actualizar.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BorrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarDatosToolStripMenuItem.Click
        Borrar.Show()
        Me.Hide()
    End Sub

    Private Sub BuacarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuacarDatosToolStripMenuItem.Click
        Buscar.Show()
        Me.Hide()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub
End Class