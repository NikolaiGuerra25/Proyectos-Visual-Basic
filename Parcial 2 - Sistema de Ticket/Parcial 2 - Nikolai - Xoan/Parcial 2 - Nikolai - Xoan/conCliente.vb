Imports System.Data
Imports System.Data.SqlClient
Public Class conCliente
    Private Sub conCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        menuCliente.Show()
        Me.Hide()
    End Sub

    'Limpiar Campos'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim control As Integer
        Dim fecha As Date
        fecha = Today
        Dim asunto As String = TextBox2.Text
        Dim urgencia As String = ComboBox1.Text
        Dim descripcion As String = TextBox1.Text
        Dim estado As String = "No visto"
        Dim ingresarConsulta As String
        control = 0
        Dim cliente As String = Module1.usuario

        If asunto = "" Or urgencia = "" Then
            MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
        Else
            ingresarConsulta = "Insert into Consulta(Fecha,Asunto,Urgencia,Descripcion,Estado,Cliente) Values('" & fecha & "', '" & asunto & "', '" & urgencia & "', '" & descripcion & "', '" & estado & "', '" & cliente & "')"

            Dim command As New SqlCommand(ingresarConsulta, con)

            control = command.ExecuteNonQuery()

            If control > 0 Then
                MsgBox("La insercion de la consulta se ha realizado con exito",, "Alerta")
            End If
        End If
    End Sub

    'Solo Letras'
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class