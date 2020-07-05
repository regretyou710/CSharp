Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Integer = New Random().Next(1, 101)
        Dim guess As Integer
        Dim flag As Boolean
        For i As Integer = 1 To 3
            guess = InputBox("請輸入要猜的數字1~100")
            If (guess > r) Then
                MessageBox.Show("Lower")
            ElseIf (guess < r) Then
                MessageBox.Show("Higher")
            Else
                flag = True
                Exit For
            End If
        Next
        If (flag) Then
            MessageBox.Show("猜中了!" & guess)
        Else
            MessageBox.Show("沒猜中!" & r)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As Integer = New Random().Next(1, 101)
        Dim guess As Integer
        Dim i As Integer = 1
        Dim flag As Boolean
        Do While (i <= 3)
            guess = InputBox("請輸入要猜的數字1~100")
            If (guess > r) Then
                MessageBox.Show("Lower")
            ElseIf (guess < r) Then
                MessageBox.Show("Higher")
            Else
                flag = True
                Exit Do
            End If
            i += 1
        Loop
        If (flag) Then
            MessageBox.Show("猜中了!" & guess)
        Else
            MessageBox.Show("沒猜中!" & r)
        End If
    End Sub
End Class
