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
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button9
        '
        Me.button9.Location = New System.Drawing.Point(284, 302)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(120, 47)
        Me.button9.TabIndex = 17
        Me.button9.Text = "ToArray"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Location = New System.Drawing.Point(284, 229)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(120, 47)
        Me.button8.TabIndex = 16
        Me.button8.Text = "ToList"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(284, 161)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(120, 47)
        Me.button6.TabIndex = 14
        Me.button6.Text = "Join"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(284, 91)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(120, 47)
        Me.button5.TabIndex = 13
        Me.button5.Text = "Group By"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(110, 302)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(120, 47)
        Me.button4.TabIndex = 12
        Me.button4.Text = "calculate"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(110, 229)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(120, 47)
        Me.button3.TabIndex = 11
        Me.button3.Text = "Class filter,sort"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(110, 161)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 47)
        Me.button2.TabIndex = 10
        Me.button2.Text = "filter,sort"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(110, 91)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 47)
        Me.button1.TabIndex = 9
        Me.button1.Text = "IEnumerable<T>"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Location = New System.Drawing.Point(452, 232)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(120, 47)
        Me.button12.TabIndex = 20
        Me.button12.Text = "LINQ to DataSet"
        Me.button12.UseVisualStyleBackColor = True
        '
        'button11
        '
        Me.button11.Location = New System.Drawing.Point(452, 159)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(120, 47)
        Me.button11.TabIndex = 19
        Me.button11.Text = "LINQ to SQL"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.Location = New System.Drawing.Point(452, 91)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(120, 47)
        Me.button10.TabIndex = 18
        Me.button10.Text = "LINQ to XML"
        Me.button10.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 455)
        Me.Controls.Add(Me.button12)
        Me.Controls.Add(Me.button11)
        Me.Controls.Add(Me.button10)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button9 As Button
    Private WithEvents button8 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button12 As Button
    Private WithEvents button11 As Button
    Private WithEvents button10 As Button
End Class
