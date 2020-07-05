Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private easonCheckingAccount As CheckingAccount
    Private easonSavingAccount As SavingAccount

    Public Sub output(ByVal anyObject As Object)
        TextBox1.AppendText(anyObject)
        ' Console.WriteLine(anyObject)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        easonCheckingAccount = New CheckingAccount("Eason", 1000)
        Dim outputString As String = "帳戶名稱:" & easonCheckingAccount.accountName & vbTab
        outputString += "帳戶號碼:" & easonCheckingAccount.accountNumber & vbTab
        outputString += "帳戶餘額:" & easonCheckingAccount.accountBalance & vbTab
        output(outputString & vbLf)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        easonSavingAccount = New SavingAccount("Eason", 1000)
        Dim outputString As String = "帳戶名稱:" & easonSavingAccount.accountName & vbTab
        outputString += "帳戶號碼:" & easonSavingAccount.accountNumber & vbTab
        outputString += "帳戶餘額:" & easonSavingAccount.accountBalance & vbTab
        output(outputString & vbLf)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim outStirng As String
        '有產生物件才執行顯示利率
        If easonSavingAccount IsNot Nothing Then
            outStirng = "Interest Rate is: " & easonSavingAccount.getRate().ToString()
            output(outStirng & "%" & vbLf)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim outStirng As String
        '有產生物件才執行存400元
        If easonSavingAccount IsNot Nothing Then
            easonSavingAccount.despoit(400D)
            outStirng = "Balance is: " & easonSavingAccount.accountBalance.ToString
            output(outStirng & vbLf)
        End If
    End Sub
End Class
