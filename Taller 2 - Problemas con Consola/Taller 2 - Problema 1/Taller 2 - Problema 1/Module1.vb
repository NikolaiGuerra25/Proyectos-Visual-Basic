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

    Public Function descuentos()
        Console.WriteLine("¿Cual descuento desea aplicar?")
        Console.WriteLine("1. Descuento del 7% " & vbNewLine & "2. Descuento del 10%")
        Console.WriteLine("3. Descuento del 20% " & vbNewLine & "4. Descuento del 30%")
        Console.WriteLine("5. Descuento del 40% " & vbNewLine & "6. Descuento del 50%")
    End Function

    Public Function producto()
        Console.WriteLine("|----------------------------------------------------------------------------|")
        Console.WriteLine("|Nombre del producto     Cantidad      Precio Unitario        Precio Total   |")
        Console.WriteLine("|----------------------------------------------------------------------------|")
    End Function

    Sub Main()
        'Color'
        Console.ForegroundColor = ConsoleColor.Yellow

        'Variables'
        Dim cantidadP As Integer, opcionDesc As Integer, opcion As Integer, aleatorio As Integer, contador As Integer, contador1 As Integer, contador2 As Integer
        Dim cantidadV(10) As Decimal
        Dim precioU(10) As Decimal
        Dim nombre(10) As String
        Dim precioTot(10) As Decimal
        Dim sum As Decimal, precioNeto As Decimal, desc As Decimal
        Dim cliente As String, direccion As String, telefono As String

        'Generar fecha'
        Dim fechaActual As Date = Date.Now
        'generar numero aleatorio'
        aleatorio = (9999 - 1000) * Rnd() + 1000

        'Inicio / Titulo'
        titulo()
        Console.WriteLine("|Ingrese el nombre del cliente                                              |")
        cliente = Console.ReadLine()
        Console.WriteLine("|Ingrese la direccion del cliente                                           |")
        direccion = Console.ReadLine()
        Console.WriteLine("|Ingrese el numero de telefono del cliente                                  |")
        telefono = Console.ReadLine()
        Do While (contador = 0)
            Try
                Console.WriteLine("|Ingrese la cantidad de productos a facturar                                |")
                cantidadP = Console.ReadLine()
                contador = contador + 1
            Catch ex As Exception
                Console.WriteLine("|ERROR: No se aceptan letras ni simbolos                                                 |")
            End Try
        Loop

        'Llenado de Vectores'
        Console.Clear()

        For x As Integer = 0 To cantidadP - 1 Step 1
            Console.WriteLine("|Ingrese el nombre del producto #{0}                                         |", x)
            nombre(x) = Console.ReadLine()
            Console.WriteLine("|Ingrese el precio unitario del producto #{0}                                |", x)
            precioU(x) = Console.ReadLine()
            Console.WriteLine("|Ingrese la cantidad vendida del producto #{0}                               |", x)
            cantidadV(x) = Console.ReadLine()
            precioTot(x) = precioU(x) * cantidadV(x)
            sum = sum + precioTot(x)
            Console.Clear()
        Next

        'Descuento'
        Do While (contador1 = 0)
            Try
                Console.WriteLine("¿Desea aplicar un descuento a la compra?")
                Console.WriteLine("1. Si / 2. No")
                opcion = Console.ReadLine()
                contador1 = contador1 + 1
            Catch ex As Exception
                Console.WriteLine("|ERROR: No se aceptan letras ni simbolos                                                 |")
            End Try
        Loop

        Console.Clear()
        Select Case opcion
            Case 1
                Do While (contador2 = 0)
                    Try
                        descuentos()
                        opcionDesc = Console.ReadLine()
                        contador2 = contador2 + 1
                    Catch ex As Exception
                        Console.WriteLine("|ERROR: No se aceptan letras ni simbolos                                                 |")
                    End Try
                Loop
                Select Case opcionDesc
                    Case 1
                        desc = sum * 0.07
                        precioNeto = sum - desc
                    Case 2
                        desc = sum * 0.1
                        precioNeto = sum - desc
                    Case 3
                        desc = sum * 0.2
                        precioNeto = sum - desc
                    Case 4
                        desc = sum * 0.3
                        precioNeto = sum - desc
                    Case 5
                        desc = sum * 0.4
                        precioNeto = sum - desc
                    Case 6
                        desc = sum * 0.5
                        precioNeto = sum - desc
                    Case Else
                        Console.Clear()
                        Console.WriteLine("ERROR:Opcion ingresada no valida")
                End Select

                'Impresion'
                Console.Clear()
                titulo()
                Console.WriteLine("|Fecha: {0}                                                                  ", fechaActual)
                Console.WriteLine("|Numero de Factura: {0}                                                      ", aleatorio)
                Console.WriteLine("|Cliente: {0}                                                                ", cliente)
                Console.WriteLine("|Direccion: {0}                                                              ", direccion)
                Console.WriteLine("|Telefono: {0}                                                               ", telefono)
                producto()
                For x = 0 To cantidadP Step 1
                    Console.WriteLine("{0}                      {1}           {2}                    {3}             ", nombre(x), cantidadV(x), precioU(x), precioTot(x))
                Next
                Console.WriteLine("|----------------------------------------------------------------------------|")
                Console.WriteLine("|                                                            SubTotal: ${0}  ", Math.Round(sum, 2))
                Console.WriteLine("|                                                            Descuento: ${0} ", Math.Round(desc, 2))
                Console.WriteLine("|                                                            Total: ${0}     ", Math.Round(precioNeto, 2))
            Case 2
                'Impresion'
                Console.Clear()
                titulo()
                Console.WriteLine("|Fecha: {0}                                                                  ", fechaActual)
                Console.WriteLine("|Numero de Factura: {0}                                                      ", aleatorio)
                Console.WriteLine("|Cliente: {0}                                                                ", cliente)
                Console.WriteLine("|Direccion: {0}                                                              ", direccion)
                Console.WriteLine("|Telefono: {0}                                                               ", telefono)
                producto()
                For x = 0 To cantidadP Step 1
                    Console.WriteLine("{0}                      {1}           {2}                    {3}             ", nombre(x), cantidadV(x), precioU(x), precioTot(x))
                Next
                Console.WriteLine("|----------------------------------------------------------------------------|")
                Console.WriteLine("|                                                            SubTotal: ${0}  ", Math.Round(sum, 2))
                Console.WriteLine("|                                                            Total: ${0}     ", Math.Round(precioNeto, 2))
            Case Else
                Console.Clear()
                Console.WriteLine("ERROR:Opcion ingresada no valida")
        End Select
        Console.ReadLine()
    End Sub

End Module
