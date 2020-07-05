Class Car
    Private _no As Integer
    Private _model As String
    Public Sub New(no As Integer, model As String)
        _no = no
        _model = model
    End Sub
    Public WriteOnly Property Model As String
        Set(value As String)
            _model = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return "No:" & _no & vbTab & "Model:" & _model
    End Function
End Class
