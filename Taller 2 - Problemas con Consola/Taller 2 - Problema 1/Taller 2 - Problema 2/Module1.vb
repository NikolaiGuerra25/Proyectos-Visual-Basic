Module Module1
    Public Function titulo()
        Console.WriteLine("|----------------------------------------------------------------------------|")
        Console.WriteLine("|                           GRUPO CONTABLE S.A.                              |")
        Console.WriteLine("|                         Telefono: +507 797-5590                            |")
        Console.WriteLine("|                       Dirección: Calle 4ta, David                          |")
        Console.WriteLine("|                      RUC: 895-PD-1532-52-1 D.V. 90                         |")
        Console.WriteLine("|                           grupocontablesa.com                              |")
        Console.WriteLine("|                    Correo: grupo.contablesa@gmail.com                      |")
        Console.WriteLine("|----------------------------------------------------------------------------|")
    End Function

    Sub Main()
        'Color'
        Console.ForegroundColor = ConsoleColor.Cyan

        'Variables'
        Dim opcion As Integer, contador As Integer
        Dim nombre As String, cedula As String
        Dim años As Decimal, bono As Decimal, sueldoTotal As Decimal, salMensual As Decimal, salSemanal As Decimal, liquidacion As Decimal, vacacion As Decimal, decimo As Decimal, renuncia As Decimal
        Const salario = 12000

        'Inicio'
        titulo()
        Console.WriteLine("|Ingrese el nombre del trabajador                                                   |")
        nombre = Console.ReadLine()
        Console.WriteLine("|Ingrese la cedula de identidad personal del trabajador                             |")
        cedula = Console.ReadLine()
        Do While (contador = 0)
            Try
                Console.WriteLine("|Ingrese los años que el trabajador lleva trabajando                                |")
                años = Console.ReadLine()
                contador = contador + 1
            Catch ex As Exception
                Console.WriteLine("|ERROR: No se aceptan letras ni simbolos                                                 |")
            End Try
        Loop

        'Calculo del bono'
        Select Case años
            Case Is >= 10
                bono = 12000 * 0.1
                sueldoTotal = bono + 12000
            Case 5 To 9
                bono = 12000 * 0.07
                sueldoTotal = bono + 12000
            Case 3 To 4
                bono = 12000 * 0.05
                sueldoTotal = bono + 12000
            Case < 2
                bono = 12000 * 0.03
                sueldoTotal = bono + 12000
        End Select

        'Liquidacion / Renuncia'
        'Liquidacion'
        salMensual = salario / 12
        salSemanal = salMensual / 4.333
        liquidacion = salSemanal * años

        'Renuncia'
        vacacion = salario * 0.0909
        decimo = (((salario / 12) * 4) / 3)
        renuncia = vacacion + decimo

        'Impresion'
        Console.Clear()
        titulo()
        Console.WriteLine("|Nombre del Trabajador: {0}                                                         ", nombre)
        Console.WriteLine("|C.I.P.: {0}                                                                        ", cedula)
        Console.WriteLine("|-----------------------------------------------------------------------------------|")
        Console.WriteLine("|Salario Anual    Años Trabajados     Prima por Antigüedad     Sueldo Anual Nuevo   |")
        Console.WriteLine("|-----------------------------------------------------------------------------------|")
        Console.WriteLine("|${0}             {1}                ${2}                      ${3}                 ", Math.Round(salario, 2), años, Math.Round(bono, 2), Math.Round(sueldoTotal, 2))
        Console.WriteLine("|-----------------------------------------------------------------------------------|")
        Console.WriteLine("|Liquidacion: ${0}                                                                  ", Math.Round(liquidacion, 2))
        Console.WriteLine("|Renuncia: ${0}                                                                     ", Math.Round(renuncia, 2))
        Console.ReadLine()
    End Sub

End Module
