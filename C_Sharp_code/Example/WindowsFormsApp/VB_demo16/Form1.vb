Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stu As New Student
        stu.No = 201
        stu.Name = "Mary"
        stu.Major = "Chinese"
        Console.WriteLine("{0},{1},{2}", stu.No, stu.Name, stu.Major)
    End Sub
End Class
