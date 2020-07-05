Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim list As New List(Of Car)()
        Dim car As New Car(1, "BMW")
        list.Add(car)
        car = New Car(2, "BENZ")
        list.Add(car)
        car = New Car(3, "INFINITI")
        list.Add(car)
        car = New Car(4, "HONDA")
        list.Insert(1, car)

        For i As Integer = 0 To list.Count - 1
            Console.WriteLine(list(i))
        Next
        Console.WriteLine("===============")

        '移除元素
        list.RemoveAt(1)
        '修改元素
        Dim c2 As Car = list(2)
        c2.Model = "YRIS"
        For Each obj As Car In list
            Console.WriteLine(obj)
        Next
        Console.WriteLine("===============")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim dic As New Dictionary(Of String, Car)
        Dim car As New Car(1, "BMW")
        dic.Add("bmw", car)
        car = New Car(2, "BENZ")
        dic.Add("benx", car)
        car = New Car(3, "INFINITI")
        dic.Add("infiniti", car)
        car = New Car(4, "HONDA")
        dic.Add("honda", car)

        For Each entry As KeyValuePair(Of String, Car) In dic
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("===============")

        For Each key As String In dic.Keys
            Console.WriteLine("{0}", dic(key))
        Next
        Console.WriteLine("===============")

        '移除元素
        dic.Remove("honda")
        '修改元素
        Dim c2 As Car = dic("infiniti")
        c2.Model = "YRIS"
        For Each entry As KeyValuePair(Of String, Car) In dic
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("===============")
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim sort As New SortedList(Of String, Car)
        Dim car As New Car(1, "BMW")
        sort.Add("bmw", car)
        car = New Car(2, "BENZ")
        sort.Add("benx", car)
        car = New Car(3, "INFINITI")
        sort.Add("infiniti", car)
        car = New Car(4, "HONDA")
        sort.Add("honda", car)

        For Each entry As KeyValuePair(Of String, Car) In sort
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("===============")

        For Each key As String In sort.Keys
            Console.WriteLine("{0}", sort(key))
        Next
        Console.WriteLine("===============")

        '移除元素
        sort.Remove("honda")
        '修改元素
        Dim c2 As Car = sort("infiniti")
        c2.Model = "YRIS"
        For Each entry As KeyValuePair(Of String, Car) In sort
            Console.WriteLine("Key:{0}" & vbTab & "Value:{1}", entry.Key, entry.Value)
        Next
        Console.WriteLine("===============")
    End Sub
End Class
