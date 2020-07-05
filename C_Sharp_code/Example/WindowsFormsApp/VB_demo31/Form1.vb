Public Class Form1
    Public stu As DataSet1.StudentDataTable = New DataSet1.StudentDataTable()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As DataSet1TableAdapters.StudentTableAdapter = New DataSet1TableAdapters.StudentTableAdapter()
        da.Fill(stu)
        DataGridView1.DataSource = stu
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As DataSet1TableAdapters.StudentTableAdapter = New DataSet1TableAdapters.StudentTableAdapter()
        da.Update(stu)
        DataGridView1.DataSource = stu
    End Sub
End Class
