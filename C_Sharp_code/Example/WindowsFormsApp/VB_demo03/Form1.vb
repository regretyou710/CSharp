Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim classA As New ClassA
        classA.str = "Hello"
        Console.WriteLine(classA.str)
    End Sub

    Public Class ClassA
        Public Property str As String
    End Class

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim classB As New ClassB
        classB.x = "this's "
        classB.y = "VB!"
        Console.WriteLine(classB.x + classB.y)
    End Sub
End Class
