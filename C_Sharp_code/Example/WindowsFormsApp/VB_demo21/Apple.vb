Public Class Apple
    Public _name As String
    Public Sub New(ByVal argName As String)
        _name = argName
    End Sub

    Public Overrides Function ToString() As String
        Return "Name: " & _name
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim x As Apple
        x = CType(obj, Apple) '將obj轉型存到變數x
        If (Me._name.Equals(x._name)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
