Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'imports IO類別
        '變數名稱與類別名稱不區分大小寫 命名相同會呼叫不出方法
        Dim fs As FileStream = File.Create("text1.txt")
        Dim bytes() As Byte = {74, 65, 86, 65}
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        MessageBox.Show("fils saved")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        File.Copy("text1.txt", "text1_new.txt")
        If File.Exists("text1_new.txt") Then
            MessageBox.Show("text1_new.txt Exists")
        Else
            MessageBox.Show("text1_new.txt Not Exists")
        End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        If File.Exists("text1.txt") Then
            MessageBox.Show("text1_new.txt Exists")
        Else
            MessageBox.Show("text1_new.txt Not Exists")
        End If
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        File.Delete("text1_new.txt")
        If File.Exists("text1_new.txt") Then
            MessageBox.Show("text1_new.txt Exists")
        Else
            MessageBox.Show("text1_new.txt Not Exists")
        End If
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim f As New FileInfo("text1.txt")
        Dim fs As FileStream = f.Open(FileMode.Open)

        Dim bytes(f.Length) As Byte
        ' Dim bytes As Byte()
        ' ReDim bytes(f.Length)


        Dim c As Integer = Convert.ToInt32(f.Length)

        fs.Read(bytes, 0, c)
        fs.Close()
        For Each t As Byte In bytes
            Console.Write(Convert.ToChar(t))
        Next
        Console.WriteLine()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim f As New FileInfo("text2.txt")
        Dim fs As FileStream = f.Create()
        Dim bytes As Byte() = {74, 65, 86, 65}
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        f.CopyTo("text2_new.txt", True)
        MessageBox.Show("file copy")
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dim f As New FileInfo("text2_new.txt")
        f.Delete()
        If f.Exists() Then
            MessageBox.Show("text2_new.txt Exists")
        Else
            MessageBox.Show("text2_new.txt Not Exists")
        End If
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim f As New FileInfo("text1.txt")
        '一個char占用一個byte
        Console.WriteLine("目前檔案(byte):" & f.Length) '取得目前檔案的大小，以位元組為單位。
    End Sub
End Class
