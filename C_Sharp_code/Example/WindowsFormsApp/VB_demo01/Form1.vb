Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim u As String = TextBox1.Text
        Dim p As String = TextBox2.Text
        MessageBox.Show("帳號:" + u + vbCrLf + "密碼:" + p, "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As String = Interaction.InputBox("輸入字串", "輸入視窗")
        MessageBox.Show(s, "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
    End Sub
End Class