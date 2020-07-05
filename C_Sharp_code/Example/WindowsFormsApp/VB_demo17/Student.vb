Public Class Student
    Private _no As Integer
    Private _name As String

    Sub New()

    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Function getNo() As Integer
        Return _no
    End Function

    Public Sub setNo(no As Integer)
        _no = no
    End Sub
End Class
