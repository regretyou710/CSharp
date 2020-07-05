Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim array(5) As Integer
        For i As Integer = 0 To array.Length - 1
            array(i) = i + 1
        Next
        For i As Integer = 0 To array.Length - 1
            Console.WriteLine("array({0})={1}", i, array(i))
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim arrays(2, 2) As Integer
        Console.WriteLine("一維陣列長度:" & arrays.GetLength(0))
        Console.WriteLine("二維陣列長度:" & arrays.GetLength(1))
        For i As Integer = 0 To arrays.GetLength(0) - 1
            For j As Integer = 0 To arrays.GetLength(1) - 1
                arrays(i, j) = (i + 1) * (j + 1)
            Next
        Next
        For i As Integer = 0 To arrays.GetLength(0) - 1
            For j As Integer = 0 To arrays.GetLength(1) - 1
                Console.Write("array({0},{1})={2}{3}", i, j, arrays(i, j), vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim num() As Integer = {1, 3, 5, 7, 9}
        For Each i In num
            Console.Write("{0}{1}", i, vbTab)
        Next
        Console.WriteLine()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim nums(,) As Integer = {{12, 14}, {16, 18}, {10, 20}}
        For i As Integer = 0 To nums.GetLength(0) - 1
            For j As Integer = 0 To nums.GetLength(1) - 1
                Console.Write("nums({0},{1})={2}{3}", i, j, nums(i, j), vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim total() As Integer = {1, 3, 5, 7, 9}
        Dim sum As Integer
        For Each i In total
            sum += i
        Next
        Console.WriteLine("1.sum={0}", sum)
        '-----------------------------
        sum = 0
        For i As Integer = 0 To total.Length - 1
            sum += total(i)
        Next
        Console.WriteLine("2.sum={0}", sum)
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click

        'Dim mails(2, 1) As String
        'mails(0, 0) = "Eason"
        'mails(0, 1) = "Eason@mial.com.tw"
        'mails(1, 0) = "Judy"
        'mails(1, 1) = "Judy@mial.com.tw"
        'mails(2, 0) = "Jesson"
        'mails(2, 1) = "Jesson@mial.com.tw"

        Dim mails(,) As String = {{"Jacky", "Jacky@mail.com.tw"}, {"Mary", "Mary@mail.com.tw"}, {"Rose", "Rose@mail.com.tw"}}


        For i As Integer = 0 To mails.GetLength(0) - 1
            For j As Integer = 0 To mails.GetLength(1) - 1
                Console.Write("{0}{1}", mails(i, j), vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim ary1() As Integer = {1, 2, 3, 4, 5}
        For Each i In ary1
            Console.Write("{0}{1}", i, vbTab)
        Next
        Console.WriteLine()
        ReDim ary1(10)
        For Each i In ary1
            Console.Write("{0}{1}", i, vbTab)
        Next
        Console.WriteLine()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ary1() As Integer = {1, 2, 3, 4, 5}
        For Each i In ary1
            Console.Write("{0}{1}", i, vbTab)
        Next
        Console.WriteLine()
        ReDim Preserve ary1(10)
        For Each i In ary1
            Console.Write("{0}{1}", i, vbTab)
        Next
        Console.WriteLine()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ary2()() As String = New String(2)() {}
        ary2(0) = New String() {"A", "B"}
        ary2(1) = New String() {"C"}
        ary2(2) = New String() {"D", "E", "F"}
        Console.WriteLine("ary2有幾個一維:" & ary2.Length)
        For i As Integer = 0 To ary2.GetLength(0) - 1
            For j As Integer = 0 To ary2(i).Length - 1
                Console.Write("{0}{1}", ary2(i)(j), vbTab)
            Next
            Console.WriteLine()
        Next

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim numbers(5) As Integer
        Dim r As New Random
        For i As Integer = 0 To numbers.Length - 1
            numbers(i) = r.Next(1, 101)
            Console.Write("{0}{1}", numbers(i), vbTab)
        Next
        Console.WriteLine()
        Array.Sort(numbers)
        For Each t In numbers
            Console.Write("{0}{1}", t, vbTab)
        Next
        Console.WriteLine()
    End Sub

    Structure Student
        Public no As Integer
        Public name As String
        Public major As String '科目
    End Structure

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '宣告Student陣列的類別名稱為stu
        '陣列中每一個元素建立一個Student物件
        Dim stu As Student() = {New Student(), New Student(), New Student()}
        For i As Integer = 0 To stu.Length - 1
            stu(i).no = i + 1
        Next
        stu(0).name = "Eason"
        stu(1).name = "Mary"
        stu(2).name = "Judy"
        stu(0).major = "國文"
        stu(1).major = "英文"
        stu(2).major = "數學"
        For Each t In stu
            Console.WriteLine("{0},{1},{2}", t.no, t.name, t.major)
        Next
    End Sub
End Class
