Public Class Problema2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Varaibles'
        Dim altura As String, radio As String
        Dim area As Decimal, volumen As Decimal
        Dim salir As String
        Const PI = 3.1416

        'Inicio'
        MsgBox("Bienvenido al programa para calcular el area y el volumen de un cilindro")
        Do
            Do
                radio = InputBox("Ingrese el radio", "Radio")
            Loop Until IsNumeric(radio)
            Do
                altura = InputBox("Ingrese la altura", "Altura")
            Loop Until IsNumeric(altura)

            'Calculos'
            area = (2 * PI * radio * altura) + (2 * PI * radio ^ 2)
            volumen = PI * (radio ^ 2) * altura

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
