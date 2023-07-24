Module Module1

    Sub Main()
        'Variables'
        Dim num1 As Decimal, num2 As Decimal, num3 As Decimal, num4 As Decimal, num5 As Long
        Dim sum As Decimal, rest As Decimal, mult As Decimal, div As Decimal, resi As Decimal, exp As Double

        'Inicio'
        Console.WriteLine("Ingrese 5 numeros aleatorios:")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()
        num3 = Console.ReadLine()
        num4 = Console.ReadLine()
        num5 = Console.ReadLine()

        'Operaciones'
        sum = num1 + num2 + num3 + num4 + num5
        rest = num1 - num2 - num3 - num4 - num5
        mult = num1 * num2 * num3 * num4 * num5
        div = sum / 5
        resi = sum Mod 5
        exp = num1 ^ num2 ^ num3 ^ num4 ^ num5

        'Impresion'
        Console.WriteLine(" ")
        Console.WriteLine("RESULTADOS DE OPERACIONES:")
        Console.WriteLine("La suma de los 5 numeros es: {0}", sum)
        Console.WriteLine("La resta de los 5 numeros es: {0}", rest)
        Console.WriteLine("La multiplicacion de los 5 numeros es: {0}", mult)
        Console.WriteLine("La division de los 5 numeros es: {0}", div)
        Console.WriteLine("El residuo de los 5 numeros es: {0}", resi)
        Console.WriteLine("La potencia de los 5 numeros es: {0}", exp)
        Console.ReadLine()
    End Sub

End Module
