Imports System.Data.SqlClient
Imports System.Data
Public Class Form1
    'Login'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataR, dataR2 As SqlDataReader
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        Dim consulta, consulta2 As String
        con.Open()

        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            Label4.Text = "ERROR: No se aceptan campos vacios"
        Else
            consulta = "Select * From Cliente where Usuario='" & TextBox2.Text & "' And Contra='" & TextBox1.Text & "'"
            consulta2 = "Select * From Admin where Usuario='" & TextBox2.Text & "' And Contra='" & TextBox1.Text & "'"
            Dim comando As New SqlCommand(consulta, con)
            Dim comando2 As New SqlCommand(consulta2, con)
            dataR = comando.ExecuteReader

            If dataR.Read() Then
                Me.Hide()
                Module1.usuario = TextBox2.Text
                menuCliente.Show()
            Else
                dataR.Close()
                dataR2 = comando2.ExecuteReader()
                If dataR2.Read() Then
                    Me.Hide()
                    Module2.admin = TextBox2.Text
                    menuAdmin.Show()
                Else
                    dataR2.Close()
                    Label4.Text = "ERROR: Admin o Cliente no valido"
                End If
            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Salir'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
