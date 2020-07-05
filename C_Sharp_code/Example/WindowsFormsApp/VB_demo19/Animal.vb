Public Class Animal
    Public Sub Eat()
        Console.WriteLine("Animal Eat")
    End Sub
    Public Function Speak() As String
        Return "Animal Speak"
    End Function
End Class

Class Lion
    Inherits Animal
End Class

Class Horse : Inherits Animal
    'VB中:表示換行
End Class


