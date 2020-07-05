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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(29, 83)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 44)
        Me.button2.TabIndex = 3
        Me.button2.Text = "方法(有回傳值)"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(29, 33)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 44)
        Me.button1.TabIndex = 2
        Me.button1.Text = "方法(無回傳值)"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(29, 233)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 44)
        Me.button5.TabIndex = 7
        Me.button5.Text = "方法參數傳遞(Optional)"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(29, 183)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 44)
        Me.button4.TabIndex = 6
        Me.button4.Text = "方法參數傳遞(ByRef)"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(29, 133)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 44)
        Me.button3.TabIndex = 5
        Me.button3.Text = "方法參數傳遞(ByVal)"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(275, 33)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 44)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Day Add"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(275, 83)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(145, 44)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Day Diff"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(275, 133)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(145, 44)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "overload1"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(275, 183)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(145, 44)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "overload2"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(275, 233)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(145, 44)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "overload3"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 355)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Private WithEvents Button8 As Button
    Private WithEvents Button9 As Button
    Private WithEvents Button10 As Button
End Class
