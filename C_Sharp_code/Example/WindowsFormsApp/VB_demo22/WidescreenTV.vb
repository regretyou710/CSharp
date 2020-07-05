Public Class WidescreenTV
    Inherits Television

    Public Overrides Sub IncreaseVolume()
        Console.WriteLine("increase volume(WidescreenTV)")
    End Sub

    Public Overrides Sub DecreaseVolume()
        Console.WriteLine("decrease volume(WidescreenTV)")
    End Sub

    Public Overrides Function ToString() As String
        Return "This's Wide Screen TV"
    End Function
End Class
