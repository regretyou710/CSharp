Public Class Form1
    Public Structure CheckingAccount
        Public accountName As String '帳戶名稱
        Public accountNumber As Integer '帳戶號碼
        Public accountBalance As Decimal '帳戶餘額
    End Structure
    Public Sub output(ByRef anyObject As Object)
        '判斷參數是否有資料 有資料就將資料輸出到TextBox1
        If anyObject IsNot Nothing Then
            TextBox1.AppendText(anyObject)
        End If
    End Sub
    Private tomCheckingAccount As CheckingAccount '宣告一個帳戶變數
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tomCheckingAccount = New CheckingAccount()
        tomCheckingAccount.accountName = "Tom"
        tomCheckingAccount.accountNumber = 20200423
        tomCheckingAccount.accountBalance = 500
        Dim outputString As String = "活儲帳戶:" & tomCheckingAccount.accountName
        outputString += vbTab & "帳號:" & tomCheckingAccount.accountNumber
        outputString += vbTab & "結餘:" & tomCheckingAccount.accountBalance
        output(outputString & vbLf)
    End Sub

    Public Sub depositMoney(ByVal amount As Decimal)
        '存款
        If amount > 0 Then
            tomCheckingAccount.accountBalance += amount
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim outputString As String
        depositMoney(500D)
        outputString = "結餘:" & tomCheckingAccount.accountBalance
        output(outputString & vbLf)
    End Sub

    Public Function withdrawMoney(ByVal amount As Decimal) As Boolean
        '提款
        If (amount > tomCheckingAccount.accountBalance OrElse amount < 0) Then
            Return False
        End If
        tomCheckingAccount.accountBalance -= amount
        Return True
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim outputString As String
        If (withdrawMoney(900)) Then
            outputString = "結餘:" & tomCheckingAccount.accountBalance
            output(outputString & vbLf)
        Else
            output("存款不足!" & vbLf)
        End If
    End Sub

    Private Function orderCheckBook() As Boolean
        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim outputString As String
        If orderCheckBook() Then
            outputString = "CheckBook 已訂購"
        Else
            outputString = "CheckBook 未訂購"
        End If
        output(outputString & vbLf)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
