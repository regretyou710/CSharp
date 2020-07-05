Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = CInt(textBox1.Text)
        'Dim i As Integer = Convert.ToInt32(textBox1.Text)
        'Console.WriteLine("文數字轉數字:" + Convert.ToString(i))
        MessageBox.Show("文數字轉數字:" + CStr(i))
    End Sub
End Class
