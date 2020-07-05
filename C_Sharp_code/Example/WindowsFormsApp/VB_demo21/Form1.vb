Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim horse As New Horse()
        Console.WriteLine("name:" & horse.Name)

        Dim horse1 As Animal
        horse1 = horse '向上隱含轉型父類別
        horse1.Talk() 'override 方法
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim bike As New Bike()
        Console.WriteLine("name: " & bike.Name)
        Console.WriteLine("---------")
        Dim bike1 As Car
        bike1 = bike
        bike1.Display() 'Bike class方法遮蔽後再去呼叫會是轉型後的父類方法
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim apple As New Apple("Apple")
        MessageBox.Show(apple.ToString())
        Dim apple2 As New Apple("Apple")

        'apple = apple2
        If (apple.Equals(apple2)) Then
            MessageBox.Show("Equals")
        Else
            MessageBox.Show("Not Equals")
        End If
    End Sub
End Class
