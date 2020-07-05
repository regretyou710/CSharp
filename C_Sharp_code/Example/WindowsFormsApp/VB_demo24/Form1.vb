Imports System.IO

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim filePath As String = "text1.txt"
        Dim strs As String() = {"Line1", "Line2", "Line3"}
        File.WriteAllLines(filePath, strs)

        filePath = "text2.txt"
        Dim strContent As String = "這是一個VB.NET測試內容..."
        File.WriteAllText(filePath, strContent)

        MessageBox.Show("寫入完成")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim filePath As String = "text1.txt"
        Dim strs As String() = File.ReadAllLines(filePath)
        For Each t As String In strs
            textBox1.AppendText(t & vbLf)
        Next

        filePath = "text2.txt"
        Dim strContent As String = File.ReadAllText(filePath)
        textBox1.AppendText(strContent)

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim filePath As String = "D:\TestDirectoryView"
        Directory.CreateDirectory(filePath)

        filePath = "D:\TestDirectory"
        Dim dirs As String() = Directory.GetDirectories(filePath)
        For Each t As String In dirs
            Console.WriteLine("目錄/資料夾名稱:" & t)
        Next
        Console.WriteLine("===============")

        Dim files As String() = Directory.GetFiles(filePath)
        For Each t As String In files
            Console.WriteLine("目錄/檔案名稱:" & t)
        Next
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim filePath As String = "D:\TestDirectoryView"
        Dim path As New DirectoryInfo(filePath)
        Dim exists As Boolean = path.Exists()
        Console.WriteLine("目錄是否存在:" & exists)


        path = New DirectoryInfo("D:\TestDirectory")
        Dim dirs As DirectoryInfo() = path.GetDirectories()
        For Each t As DirectoryInfo In dirs
            Console.WriteLine("VB_目錄/資料夾名稱:" & t.Name)
        Next
        Console.WriteLine("===============")

        Dim files As FileInfo() = path.GetFiles()
        For Each t As FileInfo In files
            Console.WriteLine("VB_目錄/資料夾名稱:" & t.FullName)
        Next
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim myFile As String = "D:\TestDirectory\File1.txt"
        Console.WriteLine("取得Path目錄名稱:{0} ", Path.GetDirectoryName(myFile))
        Console.WriteLine("取得Path附檔名名稱:{0} ", Path.GetExtension(myFile))
        Console.WriteLine("取得Path檔案名稱(含附檔名):{0} ", Path.GetFileName(myFile))
        Console.WriteLine("取得Path檔案名稱(無附檔名):{0} ", Path.GetFileNameWithoutExtension(myFile))
        Console.WriteLine("隨機產生檔案名稱:{0} ", Path.GetRandomFileName())
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Title = "打開舊檔"
        openDialog.Filter = "Word (*.doc)|*.doc; | Text (*.txt)|*.txt; | 所有檔案(*.*)|*.*;" '//顯示的名稱|附檔名
        openDialog.ShowDialog() '顯示對話盒
        Dim selectFile As String = openDialog.FileName
        Console.WriteLine(selectFile) '印出選擇的檔案名稱
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = "txt" '儲存檔案後預設附檔名
        saveDialog.Filter = " Text (*.txt)|*.txt; | Word (*.doc)|*.doc; | 所有檔案(*.*) | *.*; "
        saveDialog.OverwritePrompt = True '設定 檔案如果存在跳出顯示窗提示
        saveDialog.ShowDialog()
        Dim selectFile As String = saveDialog.FileName
        Console.WriteLine(selectFile) '印出選擇的檔案名稱
    End Sub
End Class
