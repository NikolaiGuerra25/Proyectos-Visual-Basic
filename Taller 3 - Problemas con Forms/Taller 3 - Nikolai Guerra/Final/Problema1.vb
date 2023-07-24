Public Class Problema1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Variable'
        Dim num1 As Decimal, num2 As Decimal, num3 As Decimal, num4 As Decimal, num5 As Long
        Dim sum As Decimal, rest As Decimal, mult As Decimal, div As Decimal, resi As Decimal, exp As Double
        Dim contador1 As Integer

        'Inicio'
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        num4 = Val(TextBox4.Text)
        num5 = Val(TextBox5.Text)

        'Operaciones'
        sum = num1 + num2 + num3 + num4 + num5
        rest = num1 - num2 - num3 - num4 - num5
        mult = num1 * num2 * num3 * num4 * num5
        div = sum / 5
        resi = sum Mod 5
        exp = num1 ^ num2 ^ num3 ^ num4 ^ num5

        'Impresion'
        TextBox10.Text = sum
        TextBox9.Text = rest
        TextBox8.Text = mult
        TextBox7.Text = div
        TextBox6.Text = resi
        TextBox11.Text = exp
    End Sub

    'LIMPIEZA'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox10.Clear()
        TextBox9.Clear()
        TextBox8.Clear()
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox11.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    'SOLO NUMEROS'
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("ERROR: Solo Puede ingresar numeros")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("ERROR: Solo Puede ingresar numeros")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("ERROR: Solo Puede ingresar numeros")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("ERROR: Solo Puede ingresar numeros")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("ERROR: Solo Puede ingresar numeros")
        End If
    End Sub
End Class
