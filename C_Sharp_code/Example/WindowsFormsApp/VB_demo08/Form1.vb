Public Class Form1
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim a As Integer = 2
        a >>= 1
        Console.WriteLine(a)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim a As Integer = 2
        a <<= 1
        Console.WriteLine(a)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim a As Integer = 2
        a ^= 2 'a的2次方
        Console.WriteLine(a)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = 1
        Dim b As Integer

        '先判斷左邊是否為true,如果左邊為true才運算右邊 否則左邊為false,右邊不進行運算
        If (a < 1 AndAlso (b = Convert.ToInt32(DateTime.Now) > 2020)) Then
            MessageBox.Show("True")
        Else
            MessageBox.Show("False")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = 1
        Dim b As Integer

        '先判斷左邊是否為true,如果左邊為true右邊不進行運算 否則左邊為false,才運算右邊
        If (a <= 1 OrElse (b = Convert.ToInt32(DateTime.Now) > 2020)) Then
            MessageBox.Show("True")
        Else
            MessageBox.Show("False")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim t As Integer = 14
        Dim s As String
        s = If(t >= 12, "下午", "上午")
        MessageBox.Show(s)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Integer
        x = InputBox("輸入一個數字", "視窗")
        Dim s As String = IIf(x Mod 2 = 0, "偶數", "奇數")
        MessageBox.Show(s)
    End Sub
End Class
