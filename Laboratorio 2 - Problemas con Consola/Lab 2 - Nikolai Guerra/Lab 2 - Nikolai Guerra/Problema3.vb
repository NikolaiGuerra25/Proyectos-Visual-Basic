Public Class Problema3

    'MAIN'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Variable'
        Dim pagTotal, distancia, peso As Decimal

        'Inicio'
        distancia = Val(TextBox1.Text)
        peso = Val(TextBox2.Text)

        'Calculo'
        If ComboBox1.Text = "Bicicleta" Then
            pagTotal = 100

            'Impresion'
            TextBox3.Text = Math.Round(pagTotal, 2)
        End If
        If ComboBox1.Text = "Auto / Moto" Then
            pagTotal = 30 * distancia

            'Impresion'
            TextBox3.Text = Math.Round(pagTotal, 2)
        End If
        If ComboBox1.Text = "Camion" Then
            pagTotal = (30 * distancia) + (25 * peso)

            'Impresion'
            TextBox3.Text = Math.Round(pagTotal, 2)
        End If
    End Sub

    'Activacion Txt'
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Bicicleta" Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
        If ComboBox1.Text = "Auto / Moto" Then
            TextBox1.Enabled = True
            TextBox2.Enabled = False
        End If
        If ComboBox1.Text = "Camion" Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        End If
    End Sub

    'Limpiar Todo'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    'Cerrar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    'Funcion Solo Numeros'
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        Dim punto As Boolean
        Select Case e.KeyChar
            Case "."
                If punto = False Then
                    punto = True
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "0"
                e.Handled = False
            Case "1"
                e.Handled = False
            Case "2"
                e.Handled = False
            Case "3"
                e.Handled = False
            Case "4"
                e.Handled = False
            Case "5"
                e.Handled = False
            Case "6"
                e.Handled = False
            Case "7"
                e.Handled = False
            Case "8"
                e.Handled = False
            Case "9"
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Solo Numeros'
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        solonumeros(e)
    End Sub

    'Solo Numeros'
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        solonumeros(e)
    End Sub

    'Limpiar Txt'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
    End Sub

    'Limpiar Txt'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Clear()
    End Sub

    Private Sub Problema3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class