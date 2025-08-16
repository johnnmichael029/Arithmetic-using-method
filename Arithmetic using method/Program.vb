Imports System

Module Program
    Dim num1, num2, user_sel As Integer
    Sub Main(args As String())
        UserInput()
        UserSelection()
        AddNumbers(num1, num2, user_sel)
    End Sub

    Function AddNumbers(ByVal num1 As Integer, ByVal num2 As Integer, ByVal opt As Integer)
        Console.WriteLine(IIf(opt = 1, num1 + num2, IIf(opt = 2, num1 - num2, IIf(opt = 3, num1 * num2, num1 / num2))))

    End Function

    Function UserInput()

        Console.Write("Enter first number: ")
        num1 = Console.ReadLine()

        Console.Write("Enter second number: ")
        num2 = Console.ReadLine()
        Return num1 & num2
    End Function

    Function UserSelection()
        Console.WriteLine("Select operation: [1] Add, [2], Subtract, [3] Multiply, [4] Divide")
        user_sel = Console.ReadLine()
        Return user_sel
    End Function
End Module
