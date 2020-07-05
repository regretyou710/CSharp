Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lion As New Lion()
        lion.Eat()
        Dim horse As New Horse()
        Dim str As String = horse.Speak()
        Console.WriteLine(str)
    End Sub
End Class
