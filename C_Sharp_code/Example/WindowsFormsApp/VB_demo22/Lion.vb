Public Class Lion
    Inherits Animal
    Implements ICarnivore, IComparable

    Private isHungry As Boolean
    Public name As String

    Private ReadOnly Property ICarnivore_IsHungry As Boolean Implements ICarnivore.IsHungry
        Get
            Return isHungry
        End Get
    End Property

    Public Sub New()
        isHungry = True
    End Sub
    Public Sub New(ByVal argName As String)
        Me.name = argName
    End Sub

    Public Sub Eat(Victim As Animal) Implements ICarnivore.Eat
        Console.WriteLine("獅子吃獵物 " & Victim.ToString())
    End Sub

    Public Function Hunt() As Animal Implements ICarnivore.Hunt
        Return New Antelope()
    End Function

    Public Overrides Sub Sleep()
        Console.WriteLine("獅子在睡覺")
    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim x As Lion
        'Lion自己本身的物件name和傳遞進來的物件name做比較
        '本身大於傳遞進來,回傳正值,反之則回傳負值
        x = CType(obj, Lion)
        Return Me.name.CompareTo(x.name) * -1
    End Function
End Class
