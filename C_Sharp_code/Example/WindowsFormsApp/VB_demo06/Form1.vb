Public Class Form1
    Public Structure Student
        Public no As Integer
        Public name As String
    End Structure

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim s As Student
        s.no = 49780048
        s.name = "KEN"
        Console.WriteLine("no:{0}, name:{1}", s.no, s.name)
    End Sub
End Class
