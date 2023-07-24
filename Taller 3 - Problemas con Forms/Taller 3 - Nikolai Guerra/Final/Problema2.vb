Public Class Problema2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Varaibles'
        Dim contador1 As Integer, contador2 As Integer
        Dim area As Decimal, volumen As Decimal, radio As Decimal, radio1 As Decimal, altura As Decimal, altura1 As Decimal
        Dim salir As String
        Const PI = 3.1415926

        'Inicio'
        MsgBox("Bienvenido al programa para calcular el area y el volumen de un cilindro")
        Do
            contador2 = 0
            contador1 = 0
            Do While (contador1 = 0)
                Try
                    radio = InputBox("Ingrese el radio", "Radio")
                    If radio >= 0 Then
                        radio1 = radio
                    Else
                        contador1 -= 1
                    End If
                Catch ex As Exception
                    contador1 -= 1
                End Try
                contador1 += 1
            Loop

            Do While (contador2 = 0)
                Try
                    altura = InputBox("Ingrese la altura", "Altura")
                    If altura >= 0 Then
                        altura1 = altura
                    Else
                        contador2 -= 1
                    End If
                Catch ex As Exception
                    contador2 -= 1
                End Try
                contador2 += 1
            Loop
            'Calculos'
            area = (2 * PI * radio1 * altura1) + (2 * PI * radio1 ^ 2)
            volumen = PI * (radio1 ^ 2) * altura1

            'Impresion'
            MsgBox("El Area del cilindro es: " & area & " u^2 " & vbNewLine & "El Volumen del cilindro es: " & volumen & " u^3")

            'Ciclo'
            Do
                salir = InputBox("1. Ingrese 1 para salir" & vbNewLine &
                    "2. Ingrese 2 para realizar otro calculo", "Salida del Ciclo")
            Loop Until IsNumeric(salir)

        Loop Until IsNumeric(salir) And CInt(salir) = 1
    End Sub
End Class
