<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.man = New System.Windows.Forms.RadioButton()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(209, 248)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(106, 45)
        Me.button1.TabIndex = 3
        Me.button1.Text = "顯示"
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.female)
        Me.groupBox1.Controls.Add(Me.man)
        Me.groupBox1.Location = New System.Drawing.Point(165, 80)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(196, 117)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "性別"
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(66, 79)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(58, 19)
        Me.female.TabIndex = 5
        Me.female.TabStop = True
        Me.female.Text = "女生"
        Me.female.UseVisualStyleBackColor = True
        '
        'man
        '
        Me.man.AutoSize = True
        Me.man.Location = New System.Drawing.Point(66, 37)
        Me.man.Name = "man"
        Me.man.Size = New System.Drawing.Size(58, 19)
        Me.man.TabIndex = 4
        Me.man.TabStop = True
        Me.man.Text = "男生"
        Me.man.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 372)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form3"
        Me.Text = "VBForm3"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents female As RadioButton
    Private WithEvents man As RadioButton
End Class
