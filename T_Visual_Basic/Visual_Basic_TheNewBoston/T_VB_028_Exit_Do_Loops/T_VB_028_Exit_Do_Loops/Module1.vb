﻿Module Module1

    Sub Main()
        Dim num1 As Integer = 0
        Do Until num1 = 10
            If num1 = 5 Then Exit Do
            Console.WriteLine(num1)
            num1 += 1
        Loop
        Console.ReadLine()

    End Sub

End Module
