Public Class Animal
    Public _name As String

    Sub New()
        Console.WriteLine("Animal constructor()")
    End Sub
    Sub New(ByVal name As String)
        Me._name = name
        Console.WriteLine("Animal constructor(string)")
    End Sub
End Class
