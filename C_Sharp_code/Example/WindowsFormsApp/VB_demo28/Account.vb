Public Class Account
    Public Event 餘額不足 As EventHandler
    Public Event 餘額充足 As EventHandler
    Private _balance As Double
    Public Sub Deposit(amount As Double)
        _balance += amount
        Dim args As New AccountEventArgs(_balance)
        RaiseEvent 餘額充足(Me, args)
    End Sub
    Public Sub Withdraw(amount As Double)
        _balance -= amount
        Dim args As New AccountEventArgs(Me._balance)
        '使用RaiseEvent關鍵字透過委派方法將(自身類別與不含事件的EventArgs物件)傳出去給對應的呼叫方法
        RaiseEvent 餘額不足(Me, args)
    End Sub
End Class
Public Class AccountEventArgs
    Inherits EventArgs
    Private _balance As Double
    Public Sub New(b As Double)
        _balance = b
    End Sub
    Public ReadOnly Property Balance() As Double
        Get
            Return _balance
        End Get
    End Property
End Class
