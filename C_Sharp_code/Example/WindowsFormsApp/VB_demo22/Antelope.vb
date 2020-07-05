Public Class Antelope
    Inherits Animal
    Public name As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal argName As String)
        Me.name = argName
    End Sub

    Public Overrides Function ToString() As String
        Return "這是羚羊"
    End Function

    Public Overrides Sub Sleep()
        Console.WriteLine("羚羊在睡覺")
    End Sub
End Class
