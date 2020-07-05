Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim horse As New Horse()
        Console.WriteLine("name:" & horse._name)
        Console.WriteLine("-----------")
        Dim horse1 As New Horse("Pony")
        Console.WriteLine("name:" & horse1._name)
    End Sub
End Class
