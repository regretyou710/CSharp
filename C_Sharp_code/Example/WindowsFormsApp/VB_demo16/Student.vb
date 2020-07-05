Public Class Student
    Private _no As Integer
    Private _name As String
    Private _major As String

    Public Property No() As Integer
        Get
            Return _no
        End Get
        Set(value As Integer)
            Me._no = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property
    Public Property Major() As String
        Get
            Return _major
        End Get
        Set(value As String)
            Me._major = value
        End Set
    End Property

End Class
