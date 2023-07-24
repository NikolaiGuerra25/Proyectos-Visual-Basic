Public Class Problema3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Variables'
        Dim moneda As Decimal, newMoneda As Decimal
        Dim opcion, opcion1 As Integer
        Dim contador1 As Integer
        Dim salir As String
        contador1 = 0

        'Inicio'
        MsgBox("Bienvenido al programa para realizar conversiones de divisas")
        Do
            contador1 = 0
            Do While (contador1 = 0)
                Try
                    opcion = InputBox("Seleccione una opcion ingresando el numero" & vbNewLine & "1. Convertir Euro a dolares" & vbNewLine &
                                          "2. Convertir dolares a Euro" & vbNewLine &
                                          "3. Convertir dolares a Yen" & vbNewLine &
                                          "4. Convertir Yen a dolares" & vbNewLine &
                                          "5. Convertir dolares a pesetas" & vbNewLine &
                                          "6. Convertir pesetas a dolares" & vbNewLine &
                                          "7. Convertir dolares a libras esterlinas" & vbNewLine & "8. Convertir libras esterlinas a dolares", "Bienvenido al programa conversor de divisas")
                    If opcion >= 1 And opcion <= 8 Then
                        opcion1 = opcion
                    Else
                        contador1 -= 1
                    End If
                Catch ex As Exception
                    contador1 -= 1
                End Try
                contador1 += 1
            Loop

            'Seleccion y calculos'
            Select Case opcion1
                Case 1
                    moneda = InputBox("Ingrese la cantidad de euros a convertir")
                    newMoneda = moneda * 1.12
                    MsgBox("La conversion de " & moneda & " euros a dolares son: $" & Math.Round(newMoneda, 2))
                Case 2
                    moneda = InputBox("Ingrese la cantidad de dolares a convertir")
                    newMoneda = moneda * 0.9
                    MsgBox("La conversion de " & moneda & " dolares a euros son: $" & Math.Round(newMoneda, 2))
                Case 3
                    moneda = InputBox("Ingrese la cantidad de dolares a convertir")
                    newMoneda = moneda * 121.9
                    MsgBox("La conversion de " & moneda & " dolares a Yenes son: $" & Math.Round(newMoneda, 2))
                Case 4
                    moneda = InputBox("Ingrese la cantidad de Yenes a convertir")
                    newMoneda = moneda * 0.0082
                    MsgBox("La conversion de " & moneda & " Yenes a dolares son: $" & Math.Round(newMoneda, 2))
                Case 5
                    moneda = InputBox("Ingrese la cantidad de dolares a convertir")
                    newMoneda = moneda * 149.149
                    MsgBox("La conversion de " & moneda & " dolares a pesetas son: $" & Math.Round(newMoneda, 2))
                Case 6
                    moneda = InputBox("Ingrese la cantidad de pesetas a convertir")
                    newMoneda = moneda * 0.0067
                    MsgBox("La conversion de " & moneda & " pesetas a dolares son: $" & Math.Round(newMoneda, 2))
                Case 7
                    moneda = InputBox("Ingrese la cantidad de dolares a convertir")
                    newMoneda = moneda * 0.76
                    MsgBox("La conversion de " & moneda & " dolares a libras esterlinas son: $" & Math.Round(newMoneda, 2))
                Case 8
                    moneda = InputBox("Ingrese la cantidad de libras esterlinas a convertir")
                    newMoneda = moneda * 1.31
                    MsgBox("La conversion de " & moneda & " libras esterlinas a dolares son: $" & Math.Round(newMoneda, 2))
            End Select

            'Ciclo'
            Do
                salir = InputBox("1. Ingrese 1 para salir" & vbNewLine &
                    "2. Ingrese 2 para realizar otro calculo", "Salida del Ciclo")
            Loop Until IsNumeric(salir)

        Loop Until IsNumeric(salir) And CInt(salir) = 1
    End Sub
End Class
