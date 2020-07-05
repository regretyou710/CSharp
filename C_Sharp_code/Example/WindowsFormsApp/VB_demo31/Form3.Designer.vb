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
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(92, 118)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(146, 25)
        Me.textBox4.TabIndex = 27
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.label4.Location = New System.Drawing.Point(15, 118)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 23)
        Me.label4.TabIndex = 26
        Me.label4.Text = "主修:"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(92, 82)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(146, 25)
        Me.textBox3.TabIndex = 25
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.label3.Location = New System.Drawing.Point(15, 82)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 23)
        Me.label3.TabIndex = 24
        Me.label3.Text = "年齡:"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(92, 44)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(146, 25)
        Me.textBox2.TabIndex = 23
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.label2.Location = New System.Drawing.Point(15, 44)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 23)
        Me.label2.TabIndex = 22
        Me.label2.Text = "姓名:"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(92, 7)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(146, 25)
        Me.textBox1.TabIndex = 21
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 23)
        Me.label1.TabIndex = 20
        Me.label1.Text = "學號:"
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(19, 341)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(130, 35)
        Me.button5.TabIndex = 19
        Me.button5.Text = "資料庫回存"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(19, 300)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(130, 35)
        Me.button4.TabIndex = 18
        Me.button4.Text = "資料異動顯示"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(19, 259)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(130, 35)
        Me.button3.TabIndex = 17
        Me.button3.Text = "DataSet資料刪除"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(19, 218)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(130, 35)
        Me.button2.TabIndex = 16
        Me.button2.Text = "DataSet資料修改"
        Me.button2.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(194, 177)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 27
        Me.dataGridView1.Size = New System.Drawing.Size(517, 252)
        Me.dataGridView1.TabIndex = 15
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(19, 177)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(130, 35)
        Me.button1.TabIndex = 14
        Me.button1.Text = "DataSet資料新增"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 437)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox4 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents button1 As Button
End Class
