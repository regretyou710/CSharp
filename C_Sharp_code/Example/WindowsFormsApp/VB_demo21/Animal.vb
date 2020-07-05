Public Class Animal
    Private _name As String

    Sub New()
        Me.New("no name")
    End Sub
    Sub New(ByVal argName As String)
        Me._name = argName
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Overridable Sub Talk()
        Console.WriteLine("Animal Talk")
    End Sub
End Class
