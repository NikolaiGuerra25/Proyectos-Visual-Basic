Public Class Problema2
    Private Sub Problema2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Cerrar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
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
        'Variables'
        Dim monto, interes, pagTotal As Decimal
        Dim dias As Integer

        'Inicio'
        monto = Val(TextBox1.Text)
        dias = Val(TextBox2.Text)

        'Calculos'
        Select Case dias
            Case Is > 129
                interes = monto * 0.15
            Case 91 To 129
                interes = monto * 0.07
            Case 61 To 90
                interes = monto * 0.05
            Case 30 To 60
                interes = monto * 0.02
        End Select

        pagTotal = interes + monto

        'Impresion'
        TextBox3.Text = Math.Round(interes, 2)
        TextBox4.Text = Math.Round(pagTotal, 2)
    End Sub

    'Solo Numeros'
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        solonumeros(e)
    End Sub

    'Solo Numeros'
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        solonumeros(e)
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

    'Limpiar Txt1'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
    End Sub

    'Limpiar Txt2'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Clear()
    End Sub
End Class