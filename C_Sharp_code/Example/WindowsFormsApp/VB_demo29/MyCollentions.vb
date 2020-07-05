Class QueueBuffer
    Private mBuffer As Queue
    Public Sub New()
        mBuffer = New Queue()
    End Sub

    Public Sub sendMessage(msg As Messages)
        mBuffer.Enqueue(msg)
    End Sub
    Public Sub receiveMessage()
        Dim msg As Messages = CType(mBuffer.Dequeue(), Messages)
        Console.WriteLine(msg.ToString())
    End Sub
End Class
Class StackBuffer
    Private mBuffer As Stack
    Public Sub New()
        mBuffer = New Stack()
    End Sub

    Public Sub sendMessage(msg As Messages)
        mBuffer.Push(msg)
    End Sub
    Public Sub receiveMessage()
        Dim msg As Messages = DirectCast(mBuffer.Pop(), Messages)
        Console.WriteLine(msg.ToString())
    End Sub
End Class
Class Car
    Private _no As Integer
    Private _model As String
    Public Sub New(_no As Integer, _model As String)
        Me._no = _no
        Me._model = _model
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
Class Messages
    Private MsgText As String
    Public Sub New(msg As String)
        MsgText = msg
    End Sub
    Public Overrides Function ToString() As String
        Return MsgText
    End Function
End Class
