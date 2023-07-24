Module Module1

    Sub Main()
        'Variables'
        Dim horasTrabajadas As Integer, hExtras As Integer, hNormales As Integer
        Dim pagHora As Decimal, pagTotal As Decimal, pagExtra As Decimal

        'Inicio'
        Console.WriteLine("Ingrese sus horas semanales trabajadas")
        horasTrabajadas = Console.ReadLine()
        Console.WriteLine("Ingrese su pago por hora")
        pagHora = Console.ReadLine()

        'Calculos horas extras'
        If horasTrabajadas > 40 Then
            hExtras = horasTrabajadas - 40
            pagExtra = hExtras * (pagHora * 1.5)
            hNormales = 40 * pagHora
            pagTotal = (40 * pagHora) + pagExtra
            Console.WriteLine(" ")
            Console.WriteLine("Su pago por 40 horas laborales es de: $ {0} ", Math.Round(hNormales, 2))
            Console.WriteLine("Su pago por horas extras es de: $ {0} ", Math.Round(pagExtra, 2))
            Console.WriteLine("Su sueldo semanal es de: $ {0} ", Math.Round(pagTotal, 2))
        Else
            pagTotal = horasTrabajadas * pagHora
            Console.WriteLine(" ")
            Console.WriteLine("Su sueldo semanal es de: $ {0} ", Math.Round(pagTotal, 2))
        End If
        Console.ReadLine()
    End Sub

End Module
