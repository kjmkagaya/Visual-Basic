﻿Module Module1

    Sub Main()

        Dim username As String = Nothing
        Dim password As String = Nothing
        Console.WriteLine("What is your name?")
        username = Console.ReadLine()
        Console.WriteLine("What is your password")
        password = Console.ReadLine()
        If (username = "Kagaya " Or username <> Nothing) And (password = "12345") Then
            Console.WriteLine("Heelo " & username)
        Else
            Console.WriteLine("You cant login")
        End If

        Console.ReadLine()

    End Sub

End Module
