Public Class Form1
    Enum MyColor
        Red = 1
        Blue = 2
        Yellow = 3
        '沒有指派的話會由索引0開始
    End Enum
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim c As MyColor = MyColor.Blue

        Console.WriteLine(c)
        Console.WriteLine(c.ToString()) '顯示列舉項目

    End Sub
End Class
