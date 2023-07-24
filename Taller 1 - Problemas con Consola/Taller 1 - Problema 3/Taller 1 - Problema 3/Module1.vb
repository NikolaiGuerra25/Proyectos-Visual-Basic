Module Module1

    Sub Main()
        'Variables'
        Dim moneda As Decimal, newMoneda As Decimal
        Dim opcion As Integer

        'Inicio'
        Console.WriteLine("Bienvenido al programa conversor de divisas" & vbNewLine & "Seleccione una opcion ingresando el numero correspondiente")
        Console.WriteLine("1. Convertir Euro a dolares" & vbNewLine & "2. Convertir dolares a Euro")
        Console.WriteLine("3. Convertir dolares a Yen" & vbNewLine & "4. Convertir Yen a dolares")
        Console.WriteLine("5. Convertir dolares a pesetas" & vbNewLine & "6. Convertir pesetas a dolares")
        Console.WriteLine("7. Convertir dolares a libras esterlinas" & vbNewLine & "8. Convertir libras esterlinas a dolares")
        opcion = Console.ReadLine()

        'Seleccion y calculos'
        Select Case opcion
            Case 1
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de euros a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 1.12
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} euros a dolares son: $ {1} ", moneda, newMoneda)
            Case 2
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de dolares a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 0.9
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} dolares a euros son: {1} euros ", moneda, newMoneda)
            Case 3
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de dolares a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 121.9
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} dolares a Yen son: {1} yenes ", moneda, newMoneda)
            Case 4
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de Yenes a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 0.0082
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} Ynes a dolares son: $ {1} ", moneda, newMoneda)
            Case 5
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de dolares a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 149.149
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} dolares a pesetas son: {1} pesetas ", moneda, newMoneda)
            Case 6
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de pesetas a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 0.0067
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} pesetas a dolares son: $ {1} ", moneda, newMoneda)
            Case 7
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de dolares a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 0.76
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} dolares a libras esterlinas son: {1} libras esterlinas ", moneda, newMoneda)
            Case 8
                Console.WriteLine(" ")
                Console.WriteLine("Ingrese la cantidad de libras esterlinas a convertir")
                moneda = Console.ReadLine()
                newMoneda = moneda * 1.31
                Console.WriteLine(" ")
                Console.WriteLine("La conversion de {0} libras esterlinas a dolares son: $ {1} ", moneda, newMoneda)
            Case Else
                Console.WriteLine("ERROR! Opcion ingresada incorrecta")
        End Select
        Console.ReadLine()
    End Sub

End Module
