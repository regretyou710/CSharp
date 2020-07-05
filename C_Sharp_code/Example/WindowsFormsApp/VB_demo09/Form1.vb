Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = New Random().Next(1, 101)
        If (i Mod 2 = 0) Then
            MessageBox.Show("偶數 " & i)
        Else
            MessageBox.Show("奇數 " & i)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As Integer
        s = Interaction.InputBox("請輸入分數", "系統")
        's = New Random().Next(1, 101)
        'MessageBox.Show(s)

        Dim msg As String
        If (s >= 90) Then
            msg = "甲"
        ElseIf (s >= 80) Then
            msg = "乙"
        ElseIf (s >= 70) Then
            msg = "丙"
        ElseIf (s >= 60) Then
            msg = "丁"
        Else
            msg = "不及格"
        End If
        MessageBox.Show(msg)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As Integer
        s = New Random().Next(1, 101)

        Dim msg As String
        Select Case s
            Case Is >= 90
                msg = "甲"
            Case Is >= 80
                msg = "乙"
            Case Is >= 70
                msg = "丙"
            Case Is >= 60
                msg = "丁"
            Case Else
                msg = "不及格"
        End Select
        MessageBox.Show(s & "分:" & msg)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c As Control
        For Each c In Me.Controls
            If (TypeOf (c) Is TextBox) Then
                c.BackColor = Color.Aqua
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim sum As Integer
        For i As Integer = 1 To 1000 Step 1
            sum += i
        Next
        Console.WriteLine("1~1000總合:" & sum)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i, j As Integer
        i = 1
        Do While (i <= 9)
            j = 1
            Do While (j <= 9)
                Console.Write("{0}*{1}={2}{3}", i, j, i * j, vbTab)
                j += 1
            Loop
            i += 1
            Console.WriteLine()
        Loop
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i, j As Integer
        i = 1
        Do
            j = 1
            Do
                Console.Write("{0}*{1}={2}{3}", i, j, i * j, vbTab)
                j += 1
            Loop While (j <= 9)
            i += 1
            Console.WriteLine()
        Loop While (i <= 9)
    End Sub
End Class
