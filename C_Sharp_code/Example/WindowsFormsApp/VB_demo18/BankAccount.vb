Public Class CheckingAccount
    Private Shared accountNumberSeed As Integer = 100000
    Public accountName As String
    Public accountNumber As Integer
    Public accountBalance As Decimal

    Public Sub New(ByVal name As String, ByVal balance As Decimal)
        accountNumberSeed += 1
        accountName = name
        accountNumber = accountNumberSeed
        accountBalance = balance
    End Sub

    Public Sub despoit(ByVal amount As Decimal)
        '存錢
        If amount > 0 Then
            accountBalance += amount
        End If
    End Sub
    Public Function withdraw(ByVal amount As Decimal) As Boolean
        If (amount > accountBalance) OrElse (amount < 0) Then
            Return False
        End If
        accountBalance -= amount
        Return True
    End Function

End Class

Public Class SavingAccount
    Private Shared accountNumberSeed As Integer = 100000
    Public accountName As String
    Public accountNumber As Integer
    Public accountBalance As Decimal
    Private interestRate As Decimal

    Public Sub New(ByVal name As String, ByVal balance As Decimal)

        accountName = name
        accountNumber = accountNumberSeed
        accountNumberSeed += 1
        accountBalance = balance
        interestRate = Me.getRate()
    End Sub

    Public Sub New()

    End Sub
    Public Function getRate() As Decimal
        If (accountBalance > 1000) Then
            Return 6
        Else
            Return 3
        End If
    End Function
    Public Sub despoit(ByVal amount As Decimal)
        '存錢
        If amount > 0 Then
            accountBalance += amount
            interestRate = Me.getRate()
        End If
    End Sub
    Public Function withdraw(ByVal amount As Decimal) As Boolean
        If (amount > accountBalance) OrElse (amount < 0) Then
            Return False
        End If
        accountBalance -= amount
        interestRate = Me.getRate()
        Return True
    End Function
End Class