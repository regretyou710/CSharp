Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ac As New Account()
        '使用關鍵字AddHandler將事件與事件處理常式產生關聯,格式:AddHandler event, AddressOf eventhandler 
        'AddHandler ac.餘額充足, AddressOf 帳戶餘額
        'AddHandler ac.餘額不足, AddressOf 帳戶餘額

        AddHandler ac.餘額充足, AddressOf 帳戶充足
        AddHandler ac.餘額不足, AddressOf 帳戶不足

        Console.Write("存入50元,")
        ac.Deposit(50)
        Console.Write("存入100元,")
        ac.Deposit(100)
        Console.Write("領出20元,")
        ac.Withdraw(20)
    End Sub
    Public Sub 帳戶餘額(sender As Object, args As EventArgs)
        Dim e As AccountEventArgs = args
        Dim balance As Double = e.Balance
        Console.WriteLine("目前帳戶結餘:{0:C}", balance)
    End Sub
    Public Sub 帳戶充足(sender As Object, args As AccountEventArgs)
        Dim balance As Double = args.Balance
        Console.WriteLine("目前帳戶結餘:{0:C}", balance)
    End Sub
    Public Sub 帳戶不足(sender As Object, args As AccountEventArgs)
        Dim balance As Double = args.Balance
        Console.WriteLine("目前帳戶結餘:{0:C}", balance)
    End Sub

    '在提款和存款動作分開下的事件發生撰寫方式
    '產生Account物件並使用WithEvents關鍵字
    '使用 WithEvents定義變數時，您可以使用 Handles 關鍵字，以宣告方式指定方法處理變數的事件
    Public WithEvents ac2 As New Account()

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim amount As Double
        Dim str As String = InputBox("請輸入存款金額", "存款", "金額", 0, 0)
        If (str <> "") Then
            ac2.Deposit(Convert.ToDouble(str))
        End If
    End Sub
    Private Sub ac2_帳戶充足(sender As Object, args As AccountEventArgs) Handles ac2.餘額充足
        MessageBox.Show("目前帳戶餘額:" & args.Balance.ToString())
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim amount As Double
        Dim str As String = InputBox("請輸入提款金額", "存款", "金額", 0, 0)
        If (str <> "") Then
            ac2.Withdraw(Convert.ToDouble(str))
        End If
    End Sub
    Private Sub ac2_餘額不足(sender As Object, args As AccountEventArgs) Handles ac2.餘額不足
        MessageBox.Show("目前帳戶餘額:" & args.Balance.ToString())
    End Sub
End Class
