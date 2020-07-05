Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        strLen("Hello")
    End Sub
    Private Sub strLen(ByVal x As String)
        Dim l As Integer = x.Length
        MessageBox.Show(x & " length=" & l)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim length As Integer
        length = strLen2("Hello")
        MessageBox.Show("Hello length=" & length)
    End Sub
    Private Function strLen2(ByVal x As String) As Integer
        Dim l As Integer
        l = x.Length
        Return l
    End Function

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim x As String = ""
        result(x)
        MessageBox.Show(x)
    End Sub

    Private Sub result(ByVal arg As String)
        Dim sum As Integer
        For i As Integer = 1 To 100
            sum += i
        Next
        arg = "1~100總合=" & sum
        MessageBox.Show(arg)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim x As String = ""
        result2(x)
        MessageBox.Show(x)
    End Sub
    Private Sub result2(ByRef arg As String)
        Dim sum As Integer
        For i As Integer = 1 To 100
            sum += i
        Next
        arg = "1~100總合=" & sum
        MessageBox.Show(arg)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        result3(2, 3)
        result3(2, 3, 4)
    End Sub
    Private Sub result3(ByVal x As Integer, ByVal y As Integer, Optional ByVal z As Integer = 1)
        Dim total As Integer = x * y * z
        MessageBox.Show("total=" & total)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim d As DateTime
        d = DateAdd(DateInterval.Day, -2, DateTime.Now) '參數一:哪一種資料型態,參數二:往前或往後多少值,參數三:起始值
        MessageBox.Show(d.ToShortDateString)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim d As Long
        d = DateDiff(DateInterval.Day, DateTime.Now, Convert.ToDateTime("2020/10/23")) '參數一:哪一種資料型態,參數二:起始值,參數三:結束值
        MessageBox.Show(d)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        greet()
    End Sub
    Private Overloads Sub greet()
        MessageBox.Show("Hello")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        greet("Tom")
    End Sub
    Private Overloads Sub greet(ByVal arg As String)
        MessageBox.Show("Hello, " & arg)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        greet("Jimy", TimeOfDay.Evening)
    End Sub
    Enum TimeOfDay
        Morning
        Afternoon
        Evening
    End Enum
    Private Overloads Sub greet(ByVal arg As String, ByVal d As TimeOfDay)
        Dim msg As String
        msg = arg & ","
        Select Case d
            Case Is = TimeOfDay.Morning
                msg += "Morning"
            Case Is = TimeOfDay.Afternoon
                msg += "Afternoon"
            Case Is = TimeOfDay.Evening
                msg += "Evening"
            Case Else
                msg += "Hello"
        End Select
        MessageBox.Show(msg)
    End Sub
End Class
