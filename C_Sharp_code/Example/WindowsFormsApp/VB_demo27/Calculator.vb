
Public Class Calculator
    Public Delegate Function Calc(a As Double, b As Double) As Double
    Public Delegate Sub Info()
    Public Sub display()
        Console.WriteLine("這是四則運算")
    End Sub

    Public Function 加(ByVal x As Double, ByVal y As Double) As Double
        Dim sum As Double = 0
        sum = x + y
        Console.WriteLine("{0}+{1}={2}", x, y, sum)
        Return sum
    End Function

    Public Function 減(ByVal x As Double, ByVal y As Double) As Double
        Dim sum As Double = 0
        sum = x - y
        Console.WriteLine("{0}-{1}={2}", x, y, sum)
        Return sum
    End Function

    Public Function 乘(ByVal x As Double, ByVal y As Double) As Double
        Dim sum As Double = 0
        sum = x * y
        Console.WriteLine("{0}*{1}={2}", x, y, sum)
        Return sum
    End Function

    Public Function 除(ByVal x As Double, ByVal y As Double) As Double
        Dim sum As Double = 0
        sum = x / y
        Console.WriteLine("{0}/{1}={2}", x, y, sum)
        Return sum
    End Function
End Class
