Imports System.IO

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path As String = "C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg"
        Dim fsr As New FileStream(path, FileMode.Open)
        Dim br As New BinaryReader(fsr)
        Dim c As Integer = Convert.ToInt32(fsr.Length)
        Dim bytes(c) As Byte
        br.Read(bytes, 0, c)
        br.Close()
        fsr.Close()

        Dim newPath As String = "image1.jpg"
        Dim fso As New FileStream(newPath, FileMode.Create)
        Dim bw As New BinaryWriter(fso)
        bw.Write(bytes, 0, c)
        bw.Close()
        fso.Close()
        pictureBox1.Image = Image.FromFile(newPath)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim fso As New FileStream("fso.bin", FileMode.Create)
        Dim bw As New BinaryWriter(fso)
        Dim boolValue As Boolean = False
        bw.Write(boolValue)

        Dim byteValue As Byte = 1
        bw.Write(byteValue)

        Dim intValue As Integer = 10
        bw.Write(intValue)

        Dim byteArrayValue As Byte() = {65, 66, 67, 68}
        bw.Write(byteArrayValue)

        Dim charValue As Char = "好"c '用c表示這個字是字元
        bw.Write(charValue)

        Dim stringValue As String = "歡迎"
        bw.Write(stringValue)

        bw.Close()
        fso.Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim fsr As New FileStream("fso.bin", FileMode.Open)
        Dim br As New BinaryReader(fsr)

        Dim boolValue As Boolean = br.ReadBoolean()
        Console.WriteLine(boolValue)

        Dim byteValue As Byte = br.ReadByte()
        Console.WriteLine(byteValue)

        Dim intValue As Integer = br.ReadInt32()
        Console.WriteLine(intValue)

        Dim byteArrayValue As Byte() = br.ReadBytes(4)
        For Each t As Byte In byteArrayValue
            Console.Write(ChrW(t) & " ")
        Next
        Console.WriteLine()

        Dim charValue As Char = br.ReadChar()
        Console.WriteLine(charValue)

        Dim stringValue As String = br.ReadString()
        Console.WriteLine(stringValue)

        br.Close()
        fsr.Close()

    End Sub
End Class
