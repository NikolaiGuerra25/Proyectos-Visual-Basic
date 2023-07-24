Imports System.ComponentModel

Public Class Problema4
    Private Sub Problema4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub minutos_Validating(sender As Object, e As CancelEventArgs) Handles minutos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIc.SetError(sender, "")
        Else
            Me.errorIc.SetError(sender, "Ingrese un dato")
        End If
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim total As Decimal
        Dim minuto, cargoLL As Integer
        minuto = Val(minutos.Text)
        Try
            'CARGO
            If minutos.Text > 0 Then
                If horario.SelectedItem = "Mañana (6:00 AM - 11.59 AM)" Then
                    cargoLL = minuto * 2
                Else
                    cargoLL = 0

                End If




                'calculo total
                If tipo.SelectedItem = "Nacional Local" Then
                    total = (0.03 * (minuto - 10)) + cargoLL
                    distancia.Text = minuto - 10

                ElseIf tipo.SelectedItem = "Larga Distancia Nacional" Then
                    total = (0.06 * minuto) + cargoLL

                ElseIf tipo.SelectedItem = "Larga Distancia Internacional" Then
                    total = (0.1 * minuto) + cargoLL
                End If

                cargo.Text = cargoLL
                totalB.Text = total



            Else
                MsgBox("Error en los datos ingresados", vbCritical, "Error")
                distancia.Clear()
                cargo.Clear()
                totalB.Clear()
                minutos.Clear()

            End If
        Catch ex As Exception
            MsgBox("Error en los datos ingresados", vbCritical, "Error")
            distancia.Clear()
            cargo.Clear()
            totalB.Clear()
            minutos.Clear()
        End Try



    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        tipo.Text = ""
        minutos.Clear()
        horario.Text = ""
        distancia.Clear()
        cargo.Clear()
        totalB.Clear()

    End Sub

    Private Sub minutos_TextChanged(sender As Object, e As EventArgs) Handles minutos.TextChanged

    End Sub
End Class