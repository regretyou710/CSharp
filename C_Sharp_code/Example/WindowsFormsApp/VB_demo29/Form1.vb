Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim qub As New QueueBuffer()
        qub.sendMessage(New Messages("first"))
        qub.sendMessage(New Messages("second"))
        qub.receiveMessage()
        qub.sendMessage(New Messages("third"))
        qub.receiveMessage()
        qub.sendMessage(New Messages("fourth"))
        qub.receiveMessage()
        qub.receiveMessage()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        '後進先出(LIFO)
        Dim stack As New StackBuffer()
        stack.sendMessage(New Messages("first"))
        stack.sendMessage(New Messages("second"))
        stack.sendMessage(New Messages("third"))
        stack.sendMessage(New Messages("fourth"))
        stack.receiveMessage()
        stack.receiveMessage()
        stack.receiveMessage()
        stack.receiveMessage()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim list As New ArrayList()
        Dim car As Car = New Car(1, "BMW")
        list.Add(car)
        car = New Car(2, "BENZ")
        list.Add(car)
        car = New Car(3, "INFINITI")
        list.Add(car)
        car = New Car(4, "HONDA")
        list.Insert(1, car) '將HONDA插入到index 1

        For i As Integer = 0 To list.Count - 1
            Console.WriteLine(list(i))
        Next
        Console.WriteLine("----------------------")
        list.RemoveAt(1) '移除index 1資料
        Dim car2 As Car = CType(list(2), Car)
        car2.Model = "YARIS"
        For Each obj As Object In list
            Console.WriteLine(obj)
        Next
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim hs As New Hashtable()
        Dim car As Car = New Car(1, "BMW")
        hs.Add("bmw", car)
        car = New Car(2, "BENZ")
        hs.Add("benz", car)
        car = New Car(3, "INFINITI")
        hs.Add("infiniti", car)
        car = New Car(4, "HONDA")
        hs.Add("honda", car)

        '讀取hashTable內的資料
        For Each entry As DictionaryEntry In hs
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("------------")

        '讀取key
        For Each s As String In hs.Keys
            Console.WriteLine("{0}", hs(s))
        Next
        Console.WriteLine("------------")

        '移除資料
        hs.Remove("honda")
        '修改資料
        Dim c2 As Car = DirectCast(hs("benz"), Car)
        c2.Model = "YARIS"
        For Each entry As DictionaryEntry In hs
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("------------")
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        '照key的順序排序
        Dim sort As New SortedList()
        Dim car As Car = New Car(1, "BMW")
        sort.Add("bmw", car)
        car = New Car(2, "BENZ")
        sort.Add("benz", car)
        car = New Car(3, "INFINITI")
        sort.Add("infiniti", car)
        car = New Car(4, "HONDA")
        sort.Add("honda", car)

        '讀取sort內的資料
        For Each entry As DictionaryEntry In sort
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("------------")

        '讀取key
        For Each s As String In sort.Keys
            Console.WriteLine("{0}", sort(s))
        Next
        Console.WriteLine("------------")

        '移除資料
        sort.Remove("honda")
        '修改資料
        Dim c2 As Car = DirectCast(sort("benz"), Car)
        c2.Model = "YARIS"
        For Each entry As DictionaryEntry In sort
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("------------")
    End Sub
End Class
