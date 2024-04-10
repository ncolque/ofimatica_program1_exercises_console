Imports System

Module Program
    Dim MT(100, 100) As Integer
    Dim F, C As Integer

    Private Sub ALUMNO_P1_EJER1()
        Dim N1, N2, N3 As Integer
        Dim NOMBRE, OPCION As String
        Dim P As Double
        Do
            Console.Write("INTRODUZCA NOMBRE: ") 'Mostrar un texto por consola
            NOMBRE = Console.ReadLine 'Leer un dato en consola por teclado
            Console.Write("INTRODUZCA NOTA 1: ")
            N1 = Console.ReadLine
            Console.Write("INTRODUZCA NOTA 2: ")
            N2 = Console.ReadLine
            Console.Write("INTRODUZCA NOTA 3: ")
            N3 = Console.ReadLine
            P = (N1 + N2 + N3) / 3
            If P < 4 Then
                Console.WriteLine(NOMBRE & " " & "REPROBADO")
            Else
                If P >= 4 And P < 7 Then
                    Console.WriteLine("RECUPERA")
                Else
                    Console.WriteLine("APROBADO")
                End If
            End If
            Console.WriteLine("DESEA INGRESAR OTRO JUEGO DE NOTAS SI/NO")
            OPCION = Console.ReadLine
        Loop Until OPCION = "NO"
        Console.ReadLine()
    End Sub
    Private Sub POTENCIA_NUMERO_P1_EJER2()
        Dim N, M, C, R As Integer
        C = 1
        R = 1
        Console.Write("INTRODUZCA EL EXPONENTE: ")
        N = Console.ReadLine
        Console.Write("INTRODUZCA LA BASE: ")
        M = Console.ReadLine
        While C <= N
            R = R * M
            C = C + 1
        End While
        Console.WriteLine("LA POTENCIA DE " & N & " DE BASE " & M & " ES " & R)
        'Console.ReadKey()
    End Sub
    Private Sub N_NUMEROS_MULTIPLOS_X_P1_EJER3()
        Dim N, S, C, G As Integer
        Dim P As Double
        C = 1
        S = 0
        Console.Write("INTRODUZCA EL VALOR DE N: ")
        N = Console.ReadLine
        While C <= N
            G = C * 5
            Console.WriteLine(G & " ")
            S = S + G
            C = C + 1
        End While
        P = S / N
        Console.WriteLine("EL PROMEDIO ES: " & P)
        Console.ReadKey()
    End Sub
    Private Sub N_NUMEROS_MATERIAS_P2_EJER1()
        Dim M, TP1, TP2 As Integer
        Console.Write("INGRESE EL NUMERO DE MATERIAS: ")
        M = Console.ReadLine
        If (M <= 4) Then
            TP1 = M * 3000
            Console.Write("EL TOTAL A PAGAR ES: " & TP1)
        Else
            TP2 = M * 2600
            Console.Write("EL TOTAL A PAGAR ES: " & TP2)
        End If
        Console.ReadKey()
    End Sub
    Private Sub PERSONA_ES_ADMITIDA_EMPLEADO_S_P2_EJER2()
        Dim NOMBRE As String
        Dim EDAD As Integer
        Console.Write("INGRESE EL NOMBRE DEL EMPLEADO: ")
        NOMBRE = Console.ReadLine
        Console.Write("INGRESE LA EDAD DEL EMPLEADO: ")
        EDAD = Console.ReadLine
        If (EDAD >= 25 And EDAD <= 35) Then
            Console.Write("ADMITIDO PARA EL TRABAJO")
        Else
            Console.Write("NO ES ADMITIDO PARA EL TRABAJO")
        End If
        Console.ReadKey()
    End Sub
    Private Sub EJERCICIOS_PRACTICOS()
        'Dim N1, N2, S, M As Integer
        'S = 0
        'Console.Write("VALOR INICIAL: ")
        'N1 = Console.ReadLine
        'Console.Write("VALOR FINAL: ")
        'N2 = Console.ReadLine
        'While N1 <= N2
        '    M = N1 * 3
        '    S = S + M
        '    N1 = N1 + 1
        'End While
        'Console.Write("SUMA DE MULTIPLOS DE 3 ES: " & S)
        'Console.ReadKey()

        'Dim HOMBRES, MUJERES, THM, PH, PM As Integer
        'Console.Write("CANTIDAD DE HOMBRES: ")
        'HOMBRES = Console.ReadLine
        'Console.Write("CANTIDAD DE MUJERES: ")
        'MUJERES = Console.ReadLine
        'THM = HOMBRES + MUJERES
        'PH = (HOMBRES * 100) / THM
        'PM = (MUJERES * 100) / THM
        'Console.WriteLine("PORCENTAJE DE MUJERES: " & PH & "%")
        'Console.WriteLine("PORCENTAJE DE HOMBRES: " & PM & "%")
        'Console.ReadKey()

        'Dim N, C, AC, S As Integer
        'C = 1
        'S = -1
        'AC = 4
        'Console.Write("INGRESAR EL VALOR DE N: ")
        'N = Console.ReadLine
        'While C <= N
        '    S = S + AC
        '    Console.Write(S & ", ")
        '    C = C + 1
        'End While
        'Console.ReadKey()
    End Sub
    Private Sub EJERCICIOS_PRACTICOS_VECTORES_MATRICES()
        'Dim EDADES(2) As Integer
        'EDADES(0) = 14
        'EDADES(1) = 29
        'EDADES(2) = 50
        'Dim S, I As Integer
        'Dim P As Double
        'S = 0
        'Console.WriteLine("LAS EDADES DEL VECTOR")
        'For I = 0 To 2
        '    Console.WriteLine("POSICIÓN(" & I & ")=" & EDADES(I))
        '    S = S + EDADES(I)
        'Next
        'P = S / 3
        'Console.Write("PROMEDIO-->" & P)
        'Console.ReadKey()

        'Dim EDADES(100) As Integer
        'Dim N, I, S As Integer
        'Dim P As Double
        'S = 0
        'Console.Write("INTRODUZCA CUANTAS EDADES DESEA CARGAR: ")
        'N = Console.ReadLine
        'For I = 0 To N
        '    EDADES(I) = Console.ReadLine
        '    S = S + EDADES(I)
        'Next
        'P = S / N
        'Console.Write("PROMEDIO-->" & P)
        'Console.ReadKey()

        'Dim V(100) As Integer
        'Dim I, N, S, SCP As Integer
        'S = 0
        'Console.Write("INTRODUZCA DIMENSIÓN: ")
        'N = Console.ReadLine
        'For I = 1 To N
        '    Console.Write("INTRODUZCA EL VALOR: ")
        '    V(I) = Console.ReadLine
        '    If V(I) Mod 2 = 0 Then
        '        S = S + V(I)
        '        SCP = SCP + 1
        '    End If
        'Next
        'Console.WriteLine("SUMA DE PARES-->" & S)
        'Console.Write("CANTIDAD DE PARES SON-->" & SCP)
        'Console.ReadKey()

        Dim M(100, 100) As Integer
        Dim I, J, F, C, S As Integer
        Console.Write("INTRODUZCA LA CANTIDAD DE FILAS--> ")
        F = Console.ReadLine
        Console.Write("INTRODUZCA LA CANTIDAD DE COLUMNAS--> ")
        C = Console.ReadLine
        S = 0
        For I = 1 To F
            For J = 1 To C
                Console.Write("M(" & I & "," & J & ")=")
                M(I, J) = Console.ReadLine
            Next
        Next
        For I = 1 To F
            For J = 1 To C
                S = S + M(I, J)
            Next
        Next
        Console.Write("LA SUMA DE LOS ELEMENTOS DE LA MATRIZ-->" & S)
        Console.ReadKey()
        'CALCULAR EL PROMEDIO DE LOS ELEMENTOS DE LA MATRIZ
        'CALCULAR EL PRODUCTO DE LOS ELEMENTOS DE LA MATRIZ
    End Sub
    Private Sub CARGAR_MATRIZ(ByRef F As Integer, ByRef C As Integer)
        Dim I, J As Integer
        For I = 1 To F
            For J = 1 To C
                Console.Write("MT(" & I & "," & J & ")=")
                'MT(I, J) = Console.ReadLine
                MT(I, J) = (9 * Rnd())
                Console.WriteLine(MT(I, J))
            Next
        Next
    End Sub
    Private Sub IMPRIMIR_MATRIZ(ByRef F As Integer, ByRef C As Integer)
        Dim I, J As Integer
        Console.WriteLine("-------------------------------MATRIZ CARGADA-------------------------------------")
        For I = 1 To F
            For J = 1 To C
                Console.Write(" (" & I & "," & J & ")= ")
                Console.Write(MT(I, J))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("----------------------------------------------------------------------------------")
    End Sub
    Private Sub SUMA_DIAGONAL_PRINCIPAL(ByRef F As Integer, ByRef C As Integer)
        Dim I, J, S As Integer
        Dim P As Double
        S = 0
        If F = C Then
            For I = 1 To F
                For J = 1 To C
                    If I = J Then
                        S = S + MT(I, J)
                    End If
                Next
            Next
            P = S / C
            Console.Write("LA SUMA DE LA DIAGONAL PRINCIPAL ES-->" & S & vbCrLf & "PROMEDIO DE LA DIAGONAL PRINCIPAL-->" & P)
        Else
            Console.Write("LA MATRIZ NO ES CUADRADA!!!")
        End If
    End Sub
    Private Sub SUMA_TRIANGULAR_INFERIOR_IZQUIERDA(ByRef F As Integer, ByRef C As Integer)
        Dim I, J, S As Integer
        S = 0
        If F = C Then
            For I = 1 To F
                For J = 1 To I
                    S = S + MT(I, J)
                Next
            Next
            Console.Write("SUMATORIA DE LA TRIANGULAR INFERIOR --> " & S)
        Else
            Console.Write("LA MATRIZ NO ES CUADRADA!!!")
        End If
    End Sub
    Private Sub SUMA_DIAGONAL_SUPERIOR_DERECHO(ByRef F As Integer, ByRef C As Integer)
        Dim I, J, S As Integer
        S = 0
        If F = C Then
            For I = 1 To F
                For J = 1 To C - I
                    S = S + MT(I, J)
                Next
            Next
            Console.Write("SUMATORIA DE LA TRIANGULAR SUPERIOR DERECHA --> " & S)
        Else
            Console.Write("LA MATRIZ NO ES CUADRADA!!!")
        End If
    End Sub
    Private Sub SUMA_FILAS(ByRef F As Integer, ByRef C As Integer)
        Dim I, J, SUMA, POS As Integer
        SUMA = 0
        POS = 0
        Dim V(C)
        If F = C Then
            For I = 1 To F
                For J = 1 To C
                    SUMA = SUMA + MT(I, J)
                Next
                POS = POS + 1
                V(POS) = SUMA
                SUMA = 0
            Next
            Console.Write("EL VECTOR DE LA SUMA DE FILAS ES V= ")
            For index = 1 To POS
                Console.Write(V(index) & " ")
            Next
        Else
            Console.Write("LA MATRIZ NO ES CUADRADA!!!")
        End If
    End Sub
    Function SUMATORIA(ByRef F As Integer, ByRef C As Integer)
        Return 0
    End Function
    Sub Main(args As String())
        'ALUMNO_P1_EJER1()
        'POTENCIA_NUMERO_P1_EJER2()
        'N_NUMEROS_MULTIPLOS_X_P1_EJER3()

        'N_NUMEROS_MATERIAS_P2_EJER1()
        'PERSONA_ES_ADMITIDA_EMPLEADO_S_P2_EJER2()

        'Console.WriteLine()
        'Console.Write("INTRODUZCA LA CANTIDAD DE FILAS-->")
        'F = Console.ReadLine
        'Console.Write("INTRODUZCA LA CANTIDAD DE COLUMNAS-->")
        'C = Console.ReadLine
        'CARGAR_MATRIZ(F, C)
        'Console.WriteLine()
        'IMPRIMIR_MATRIZ(F, C)
        'Console.WriteLine()
        'SUMA_DIAGONAL_PRINCIPAL(F, C)
        'Console.WriteLine()
        'SUMA_TRIANGULAR_INFERIOR_IZQUIERDA(F, C)
        'Console.WriteLine()
        'SUMA_DIAGONAL_SUPERIOR_DERECHO(F, C)
        'Console.WriteLine()
        'SUMA_FILAS(F, C)
        'Console.WriteLine()


        Console.ReadKey()
    End Sub
End Module
