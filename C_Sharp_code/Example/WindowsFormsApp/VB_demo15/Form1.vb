Public Class Form1
    Public Class Student
        Private Shared _count As Integer
        Private _no As Integer
        Private _name As String
        Private _major As String
        '建構式
        Public Sub New()
            _no = -1
            _name = "NA"
            _major = "NA"
        End Sub
        Public Sub New(ByVal no As Integer, ByVal name As String,
                       ByVal major As String)
            Me._no = no
            Me._name = name
            Me._major = major
        End Sub
        Public Function getCount() As Integer
            Return _count
        End Function
        Public Sub setCount()
            _count += 1
        End Sub
        Public Function getNo() As Integer
            Return _no
        End Function
        Public Sub setNo(ByVal no As Integer)
            Me._no = no
        End Sub
        Public Function getName() As String
            Return _name
        End Function
        Public Sub setName(ByVal name As String)
            Me._name = name
        End Sub
        Public Function getMajor() As String
            Return _major
        End Function
        Public Sub setMajor(ByVal major As String)
            Me._major = major
        End Sub

        Public Sub info()
            Console.WriteLine(_no & "," & _name & "," & _major)
        End Sub
    End Class
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim stu As New Student
        stu.setNo(102)
        stu.setName("Ken")
        stu.setMajor("English")
        stu.info()
        Dim stu2 As New Student()
        stu2.info()
        Dim stu3 As New Student(103, "Mary", "Math")
        stu3.info()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim obj1 As New Student
        obj1.setCount()
        Dim obj2 As New Student
        Console.WriteLine(obj1.getCount() & " " & obj2.getCount())
        obj2.setCount()
        Console.WriteLine(obj1.getCount() & " " & obj2.getCount())
    End Sub
End Class
