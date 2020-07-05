Imports System.IO
Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x As Integer = 7
        Dim y As Integer = 0
        Dim z As Integer
        Try
            z = x / y
            Console.WriteLine(z)
        Catch ex As OverflowException
            Console.WriteLine(ex.Message)
            Return
        Finally
            Console.WriteLine("Finally執行結束")
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim a As Integer() = {1, 2, 3, 4}
        For i As Integer = 0 To a.Length
            Try
                Console.WriteLine(a(i))
            Catch ex As IndexOutOfRangeException
                Console.WriteLine(ex.Message)
            End Try
        Next
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            Dim f As FileStream = File.Open("C:\abc.txt", FileMode.Open)
            Console.WriteLine(f.Length)
        Catch ex As FileNotFoundException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Try
            Dim cs As CFirst = New CSecond()
            Dim ct As CThird = CType(cs, CFirst)
        Catch ex As InvalidCastException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Class CFirst

    End Class
    Class CSecond : Inherits CFirst

    End Class
    Class CThird : Inherits CFirst

    End Class

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim p As String = "C:\img.jpg"
        Try
            Dim f As FileStream = File.Open(p, FileMode.Open)
            Console.WriteLine(p.Length)
        Catch ex As FileNotFoundException
            Console.WriteLine("發生錯誤:" & ex.Message)
            p = "C:\img1.jpg"
            Try
                Dim f As FileStream = File.Open(p, FileMode.Open)
                Console.WriteLine(p.Length)

            Catch ex2 As FileNotFoundException
                Console.WriteLine("發生錯誤:" & ex2.Message)
            End Try
        End Try
        Console.WriteLine("END..")
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim sum As Integer = 0
        Dim a As String() = {"1", "3", "Five", "7", "9"}
        For i As Integer = 0 To a.Length
            Try
                sum += Convert.ToInt32(a(i))
                Console.WriteLine("sum={0}", sum)
            Catch ex1 As FormatException
                '捕抓到例外並在離開catch範圍後迴圈還沒結束
                Console.WriteLine("index:{0},{1}", i, ex1.Message)
                'return;'使用return,後面都不會執行,程式結束
            Catch ex2 As IndexOutOfRangeException
                Console.WriteLine("index:{0},{1}", i, ex2.Message)
            End Try
        Next
        Console.WriteLine("sum=" & sum)
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        funcA()
        Console.WriteLine("程式結束")
    End Sub

    Private Sub funcA()
        Try
            funcB()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub funcB()
        Throw New ArgumentException("自訂例外發生")
    End Sub
End Class
