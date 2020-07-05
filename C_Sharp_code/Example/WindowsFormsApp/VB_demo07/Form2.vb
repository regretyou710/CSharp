Public Class Form2
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text > 100 Or textBox1.Text < 0 Then
            MessageBox.Show("Score Error")
        Else
            MessageBox.Show("Score:" + textBox1.Text)
        End If
    End Sub
End Class