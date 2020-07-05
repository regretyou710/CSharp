<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(190, 12)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(260, 120)
        Me.textBox1.TabIndex = 5
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(58, 79)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(88, 41)
        Me.button2.TabIndex = 4
        Me.button2.Text = "讀取檔案"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(58, 22)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(88, 42)
        Me.button1.TabIndex = 3
        Me.button1.Text = "寫入檔案"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(47, 293)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(109, 28)
        Me.button7.TabIndex = 12
        Me.button7.Text = "SaveFileDialog"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(47, 259)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(109, 28)
        Me.button6.TabIndex = 11
        Me.button6.Text = "OpenFileDialog"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(47, 225)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(109, 28)
        Me.button5.TabIndex = 10
        Me.button5.Text = "Path"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(47, 191)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(109, 28)
        Me.button4.TabIndex = 9
        Me.button4.Text = "DirectoryInfo"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(47, 157)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(109, 28)
        Me.button3.TabIndex = 8
        Me.button3.Text = "Directory"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 365)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
End Class
