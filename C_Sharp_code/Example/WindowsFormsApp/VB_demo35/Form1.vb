Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ws As New Service_VB.WebService1_WSVBSoapClient()
        Dim ds As New DataSet()
        ds = ws.getStudent()
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class
