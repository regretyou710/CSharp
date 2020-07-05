Imports System.Data.SqlClient

Public Class Form2
    Const conString As String = "Data Source=USER-PC;Initial Catalog=School;Integrated Security=true"
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT COUNT(*) FROM Student"
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim rows As Integer = cmd.ExecuteScalar()
        MessageBox.Show(rows)
        conn.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student"
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim rs As SqlDataReader = cmd.ExecuteReader()
        Do While (rs.Read())
            Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}", rs(0), rs(1), rs("Age"), rs("Major"))
        Loop
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "INSERT INTO Student (Name, Age, Major) VALUES ('Tim',25,'English');
            INSERT INTO Score  (Score) VALUES (55);"
        'Dim sql2 As String = "DELETE FROM Student WHERE No = 14"
        'Dim sql3 As String = "UPDATE Student SET Name = 'Len' WHERE No = 5"
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim rows As Integer = cmd.ExecuteNonQuery()
        MessageBox.Show(rows)
        conn.Close()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student;SELECT * FROM Score;"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet()
        da.Fill(ds)
        ds.WriteXml("Datas.xml", XmlWriteMode.WriteSchema) '將資料表欄位和內容寫出
        Console.WriteLine("寫出完畢")
        conn.Close()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim ds As New DataSet()
        ds.ReadXml("Datas.xml")
        dataGridView1.DataSource = ds.Tables(0)
        dataGridView2.DataSource = ds.Tables(1)
    End Sub
End Class