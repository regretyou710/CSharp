'Public NotInheritable Class Car '加上NotInheritable關鍵字 密封不能被繼承
Public Class car
    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property

    Public Sub New()
        Me.New("Is Car")
    End Sub
    Public Sub New(ByVal argName As String)
        Me._name = argName
    End Sub

    Public Overridable Sub Display()
        Console.WriteLine("Car method")
    End Sub
End Class
