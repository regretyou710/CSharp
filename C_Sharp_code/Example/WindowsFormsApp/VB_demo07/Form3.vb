Public Class Form3
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Not female.Checked) Then
            MessageBox.Show("Man is select")
        Else
            MessageBox.Show("Female is select")
        End If
    End Sub
End Class