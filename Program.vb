Imports System

Module Patterns
    Sub Main()
        Console.WriteLine("Enter the number of rows to print ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine()

        If n < 3 Then
            Console.WriteLine("Please enter a value greater than equal to 3")
            Return
        Else
            SquareHollowPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            NumberTrianglePattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            NumberIncreasingPyramidPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            NumberIncreasingReversePyramidPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            NumberChangingPyramidPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            ZeroOneTrianglePattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            PalindromeTrianglePattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            RhombusPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            DiamondStarPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            MirrorImageTrianglePattern(n)
            Console.WriteLine(vbLf)
            Console.WriteLine("-------------------------------------------------------")

            HollowTrianglePattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            ReverseHollowTrianglePattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            HollowDiamondPyramid(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            HollowHourglassPattern(n)
            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------------")

            PascalTriangle(n)
        End If

        Console.ReadKey()
    End Sub

    Public Sub SquareHollowPattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = 1 To input
                If i = 1 OrElse i = input OrElse j = 1 OrElse j = input Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub NumberTrianglePattern(ByVal input As Integer)
        Dim numberCount As Integer = 1
        For i As Integer = 1 To input
            For j As Integer = input To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To i
                Console.Write(numberCount & " ")
                numberCount += 1
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub NumberIncreasingPyramidPattern(ByVal input As Integer)
        For i As Integer = 1 To input
            Dim numberCount As Integer = 1
            For j As Integer = 1 To i
                Console.Write(numberCount & " ")
                numberCount += 1
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub NumberIncreasingReversePyramidPattern(ByVal input As Integer)
        For i As Integer = 1 To input
            Dim numberCount As Integer = 1
            For j As Integer = input To i Step -1
                Console.Write(numberCount & " ")
                numberCount += 1
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub NumberChangingPyramidPattern(ByVal input As Integer)
        Dim numberCount As Integer = 1
        For i As Integer = 1 To input
            For j As Integer = 1 To i
                Console.Write(numberCount & " ")
                numberCount += 1
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub ZeroOneTrianglePattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = 1 To i
                If i Mod 2 = 1 Then
                    Console.Write(If(j Mod 2 = 1, "1 ", "0 "))
                Else
                    Console.Write(If(j Mod 2 = 1, "0 ", "1 "))
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub PalindromeTrianglePattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = 1 To input - i
                Console.Write("  ")
            Next
            For j As Integer = i To 1 Step -1
                Console.Write(j & " ")
            Next
            For j As Integer = 2 To i
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub RhombusPattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = input - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To input
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub DiamondStarPattern(ByVal input As Integer)
        Dim starCount As Integer = 1

        For i As Integer = 1 To input
            For j As Integer = input To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To starCount
                Console.Write("*")
            Next
            starCount += 2
            Console.WriteLine()
        Next

        For i As Integer = 1 To input + 1
            For j As Integer = 1 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = 1 To starCount
                Console.Write("*")
            Next
            starCount -= 2
            Console.WriteLine()
        Next
    End Sub

    Public Sub MirrorImageTrianglePattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = 1 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i To input
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next

        For i As Integer = input - 1 To 1 Step -1
            For j As Integer = 1 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i To input
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowTrianglePattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = i To input - 1
                Console.Write(" ")
            Next
            For j As Integer = 1 To i * 2 - 1
                If j = 1 OrElse j = i * 2 - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        For i As Integer = 1 To 2 * input - 1
            Console.Write("*")
        Next
        Console.WriteLine()
    End Sub

    Public Sub ReverseHollowTrianglePattern(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = 1 To i - 1
                Console.Write(" ")
            Next

            Dim lastCol As Integer = input * 2 - (2 * i - 1)

            For j As Integer = 1 To lastCol
                If i = 1 OrElse j = 1 OrElse j = lastCol Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowDiamondPyramid(ByVal input As Integer)
        For i As Integer = 1 To input
            For j As Integer = i To input - 1
                Console.Write(" ")
            Next
            For j As Integer = 1 To i * 2 - 1
                If j = 1 OrElse j = i * 2 - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next

        For i As Integer = 1 To input - 1
            For j As Integer = 1 To i
                Console.Write(" ")
            Next
            Dim lastCol As Integer = input * 2 - (2 * i + 1)
            For j As Integer = 1 To lastCol
                If j = 1 OrElse j = lastCol Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowHourglassPattern(ByVal input As Integer)
        For i As Integer = input To 1 Step -1
            For j As Integer = i To input
                Console.Write(" ")
            Next
            For k As Integer = 1 To i * 2 - 1
                If k = 1 OrElse i = input Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.Write("*")
            Console.WriteLine()
        Next

        For i As Integer = 2 To input
            For j As Integer = i To input
                Console.Write(" ")
            Next
            For k As Integer = 1 To i * 2 - 1
                If k = 1 OrElse i = input Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.Write("*")
            Console.WriteLine()
        Next
    End Sub

    Public Sub PascalTriangle(ByVal input As Integer)
        For i As Integer = 0 To input - 1
            Dim count As Integer = 1
            For j As Integer = 0 To input - i - 1
                Console.Write(" ")
            Next
            For j As Integer = 0 To i
                Console.Write(count & " ")
                count = count * (i - j) / (j + 1)
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
