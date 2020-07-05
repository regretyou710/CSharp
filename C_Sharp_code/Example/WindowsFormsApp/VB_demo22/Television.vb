Public MustInherit Class Television
    Public MustOverride Sub IncreaseVolume()

    Public MustOverride Sub DecreaseVolume()

    Public Sub TurnOff()
        Console.WriteLine("television off")
    End Sub

    Public Sub TurnOn()
        Console.WriteLine("television on")
    End Sub

End Class
