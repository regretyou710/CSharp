Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ilion As ICarnivore
        Dim alion As New Lion()
        Dim antelope As New Antelope()


        antelope.Sleep()
        Ilion = alion

        If (Ilion.IsHungry) Then
            Dim victim As Animal
            victim = Ilion.Hunt
            If victim IsNot Nothing Then
                Ilion.Eat(victim)
            End If
        End If
        alion.Sleep()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim lions() As Lion = {New Lion("C"), New Lion("D"), New Lion("A"), New Lion("B")}
        '在系統呼叫排序接收到參數時,系統會去看陣列中有沒有實作compareable的介面
        '如果有實作compareto的方法，會用此方法進行比較排序
        Array.Sort(lions)
        For Each t In lions
            Console.WriteLine("Lion name: " & t.name)
        Next
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' Dim tv As New WidescreenTV()
        Dim tv As Television = New WidescreenTV() '不懂特地轉型的用意為何
        Console.WriteLine(tv)
        tv.TurnOn()
        tv.IncreaseVolume()
        tv.DecreaseVolume()
        tv.TurnOff()
    End Sub
End Class
