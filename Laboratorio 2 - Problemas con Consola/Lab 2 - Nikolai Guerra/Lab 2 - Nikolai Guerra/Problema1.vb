Imports System.ComponentModel

Public Class Problema1
    Private Sub Problema1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Limpiar Todo'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    'MAIN'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Varables'
        Dim hTrabajadas, hExtras, pagExtra, pagNormal, pagTotal As Decimal
        Try
            hTrabajadas = Val(TextBox1.Text)
            If hTrabajadas > 0 Then


                'Calculos'
                If (hTrabajadas > 35) Then
                    hExtras = hTrabajadas - 35
                    pagExtra = hExtras * 22.5
                    pagNormal = 35 * 15
                    pagTotal = pagNormal + pagExtra

                    'Impresion'
                    TextBox2.Text = Math.Round(pagNormal, 2)
                    TextBox3.Text = Math.Round(pagExtra, 2)
                    TextBox4.Text = Math.Round(pagTotal, 2)
                Else

                    'Impresion'
                    pagTotal = hTrabajadas * 15
                    TextBox2.Text = Math.Round(pagTotal, 2)
                    TextBox3.Text = 0
                    TextBox4.Text = Math.Round(pagTotal, 2)
                End If
            Else
                MsgBox("Error en los datos ingresados", vbCritical, "Error")
                TextBox1.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error en los datos ingresados", vbCritical, "Error")
            TextBox1.Clear()

        End Try
        'Incio'

    End Sub

    'Cerrar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    'Limpiar Txt1'
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIc.SetError(sender, "")
        Else
            Me.errorIc.SetError(sender, "Ingrese un dato")
        End If
    End Sub
End Class