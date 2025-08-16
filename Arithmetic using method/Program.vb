Imports System

Module Program
    Dim num1, num2, user_sel As Integer
    Sub Main(args As String())
        CallMethods()
    End Sub

    Function AddNumbers(ByVal num1 As Integer, ByVal num2 As Integer, ByVal opt As Integer)
        Dim result = IIf(opt = 1, num1 + num2, IIf(opt = 2, num1 - num2, IIf(opt = 3, num1 * num2, num1 / num2)))
        Console.WriteLine("Result: " & result)
        Return result
    End Function

    Function UserInput()
        Console.Write("Enter first number: ")
        num1 = Console.ReadLine()
        Console.Write("Enter second number: ")
        num2 = Console.ReadLine()
        Return num1 & num2
    End Function

    Function UserSelection()
        Console.Write("[1] Add" & vbCrLf & "[2] Subtract" & vbCrLf & "[3] Multiply" & vbCrLf & "[4] Divide" & vbCrLf & "Select operation: ")
        user_sel = Console.ReadLine()
        Return user_sel
        UserAgain()
    End Function

    Function UserAgain()
        Console.Write("Again? [Y/N]: ")
        Dim again As String = Console.ReadLine()
        If again.ToUpper().Equals("Y") Then
            CallMethods()
        Else
            Console.WriteLine("Thank You!")
            Environment.Exit(0)
        End If
        Return again
    End Function

    Function CallMethods()
        UserInput()
        UserSelection()
        AddNumbers(num1, num2, user_sel)
        UserAgain()
        Return Nothing
    End Function
End Module
