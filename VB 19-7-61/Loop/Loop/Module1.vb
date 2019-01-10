Module Module1

    Sub Main()


        Dim i As Integer
        Dim j As Integer
        j = 15
        Dim Middle As Integer
        Dim xrow, xcol As Integer

        Console.Write("Enter Row Numer : ")
        xrow = Console.Read()

        Console.Write("Enter Colum Number : ")
        xrow = Console.Read()


        Middle = (xcol / 2)

        For i = 1 To xrow
            For j = 1 To xcol
                If (i > Middle - i) And (i < Middle + 1) Then
                    Console.Write("*")
                Else
                    Console.Write("-")

                End If
            Next

            Console.WriteLine(i)

        Next




End Module
