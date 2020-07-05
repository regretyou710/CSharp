Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 18 And TextBox2.Text = "國民" Then
            MessageBox.Show("你可以選舉")
        Else
            MessageBox.Show("你不可以選舉")
        End If
    End Sub
End Class
