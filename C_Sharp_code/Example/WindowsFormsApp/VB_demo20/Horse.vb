Public Class Horse
    Inherits Animal

    Sub New()
        Console.WriteLine("Horse constructor()")
    End Sub
    Sub New(ByVal name As String)
        MyBase.New(name)
        Console.WriteLine("Horse constructor(string)")
    End Sub
End Class
