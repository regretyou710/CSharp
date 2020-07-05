<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(195, 89)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(126, 25)
        Me.textBox1.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(143, 92)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 15)
        Me.label1.TabIndex = 4
        Me.label1.Text = "分數"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(169, 184)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(152, 68)
        Me.button1.TabIndex = 3
        Me.button1.Text = "顯示"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 345)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
