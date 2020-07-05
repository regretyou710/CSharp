Imports System.Runtime.Remoting.Messaging

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim calculator As Calculator = New Calculator()
        Dim calc As Calculator.Calc = New Calculator.Calc(AddressOf calculator.加)
        Dim x As Double = 1000
        Dim y As Double = 200
        Dim z As Double
        z = calc(x, y)

        '沒有回傳值委派
        Dim info As Calculator.Info = New Calculator.Info(AddressOf calculator.display)
        info()

        Console.WriteLine("----------------")
        '並行多個方法(同步處理)
        Dim 同步處理 As Calculator.Calc
        Dim calc1 As New Calculator.Calc(AddressOf calculator.加)
        Dim calc2 As New Calculator.Calc(AddressOf calculator.減)
        '加入一個新的委派方法
        同步處理 = [Delegate].Combine(calc1, calc2) '[Delegate]進行轉義,將Delegate關鍵字變成類別使用
        Dim t As Double = 同步處理(10, 2)
        Console.WriteLine(t)
        '移除一個委派方法
        同步處理 = [Delegate].Remove(同步處理, calc2) '第一個參數:要從哪一個方法中移除,第二個參數:要移除哪一個方法
        t = 同步處理(7, 2)
        Console.WriteLine(t)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim 海豚 As New 海豚()
        '海豚.特技 = New 海豚.表演特技型別(AddressOf 海豚.跳火圈)
        海豚.特技 = New 海豚.表演特技型別(AddressOf 海豚.噴濕觀眾)
        海豚.表演特技()
    End Sub
    '宣告有回傳值的委派方法類別
    Delegate Function MathOperation(ByVal a As Double)
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        'AddressOf=>目的為告知作業系統指定之函式執行入口處為何，讓作業系統能夠正確的呼叫 VB 者使用所準備好的函式。
        Dim callback As AsyncCallback = AddressOf MyCallBackMath
        Dim op As MathOperation = New MathOperation(AddressOf SimpleMath.calculator) '靜態方法不用new ,= New MathOperation(AddressOf new SimpleMath().calculator)
        op.BeginInvoke(0.25, callback, "HelloTest") '執行非同步的呼叫,因為非同步,告訴要執行的方法是callback
        MessageBox.Show("程式結束..")
    End Sub

    '執行緒要做的方法
    Public Sub MyCallBackMath(ByVal ar As IAsyncResult)
        Dim hello As Object = ar.AsyncState
        Dim asyncResult As AsyncResult = DirectCast(ar, AsyncResult) '將ar(Object轉成AsyncResult)
        Dim op As MathOperation = DirectCast(asyncResult.AsyncDelegate, MathOperation)
        Dim rs As Double = op.EndInvoke(ar)
        Console.WriteLine("回呼回傳值: {0} ,資料引數: {1}", rs, hello)

    End Sub
End Class
