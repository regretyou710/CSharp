Imports System.Data.SqlClient

Public Class Form3
    Const conString As String = "Data Source=USER-PC;Initial Catalog=School;Integrated Security=true"
    Public ds As New DataSet()
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student"
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "Student")
        dataGridView1.DataSource = ds.Tables("Student")

        Dim row As DataRow = ds.Tables("Student").Rows(0) ''第一列
        textBox1.Text = row(0).ToString() '第一行
        textBox2.Text = row(1).ToString() '第二行
        textBox3.Text = row("Age").ToString() '第三行
        textBox4.Text = row("Major").ToString() '第四行
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        '資料新增
        dataGridView1.DataSource = Nothing
        '在DataSet中的Student Table產生一空白列
        Dim row As DataRow = ds.Tables("Student").NewRow()
        'row(0) = textBox1.Text
        row(1) = textBox2.Text
        row(2) = textBox3.Text
        row(3) = textBox4.Text
        '將產生的列加入DataSet的集合
        ds.Tables("Student").Rows.Add(row)
        '顯示
        dataGridView1.DataSource = ds.Tables("Student")
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        '回寫資料庫(增刪修)
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim cmd As New SqlCommandBuilder(da)
        Dim rs As Integer = da.Update(ds, "Student") 'da.Update(ds.Tables("Student"))
        MessageBox.Show("異動" & rs & "筆資料")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        '透過textbox對DataGridView做異動
        Dim row As DataRow = ds.Tables("Student").Rows(0) '取得第一列資料
        row(0) = textBox1.Text
        row(1) = textBox2.Text
        row(2) = textBox3.Text
        row(3) = textBox4.Text
        dataGridView1.DataSource = ds.Tables("Student")
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        '刪除資料

        'ds.Tables("Student").Rows(6).Delete() '指定刪除某列


        For Each r As DataGridViewRow In dataGridView1.SelectedRows
            If (Not r.IsNewRow) Then
                dataGridView1.Rows.Remove(r)
            End If
        Next

        dataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        '取得未回寫資料庫前的異動情況
        Dim change As DataTable = ds.Tables(0).GetChanges()
        dataGridView1.DataSource = change
    End Sub
End Class