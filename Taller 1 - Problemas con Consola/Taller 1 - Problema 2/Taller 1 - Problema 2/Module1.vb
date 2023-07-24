Module Module1

    Sub Main()
        'Varaibles'
        Dim altura As Decimal, radio As Decimal
        Dim area As Decimal, volumen As Decimal
        Const PI = 3.1416

        'Inicio'
        Console.WriteLine("Ingrese la altura")
        altura = Console.ReadLine()
        Console.WriteLine("Ingrese el radio")
        radio = Console.ReadLine()

        'Calculos'
        area = 2 * PI * radio * (altura + radio)
        volumen = PI * (radio ^ 2) * altura

        'Impresion'
        Console.WriteLine(" ")
        Console.WriteLine("RESULTADOS:")
        Console.WriteLine("El area del cilindro es: {0} u^2", area)
        Console.WriteLine("El volumen del cilindro es: {0} u^3", volumen)
        Console.ReadLine()
    End Sub

End Module
