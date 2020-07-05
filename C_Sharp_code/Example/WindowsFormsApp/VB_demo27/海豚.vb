Public Class 海豚
    Public Delegate Sub 表演特技型別()

    Private _特技 As 表演特技型別
    Public WriteOnly Property 特技() As 表演特技型別
        Set(value As 表演特技型別)
            _特技 = value
        End Set
    End Property
    Public Sub 表演特技()
        If (_特技 IsNot Nothing) Then
            _特技() '等同=>_特技.Invoke()
        End If
    End Sub
    Public Sub 噴濕觀眾()
        Console.WriteLine("向觀眾噴水")
    End Sub
    Public Sub 跳火圈()
        Console.WriteLine("跳躍火圈")
    End Sub
End Class
