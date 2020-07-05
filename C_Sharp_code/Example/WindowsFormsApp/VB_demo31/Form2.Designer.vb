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
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(36, 282)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(165, 43)
        Me.button5.TabIndex = 10
        Me.button5.Text = "ReadXML"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(36, 233)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(165, 43)
        Me.button4.TabIndex = 9
        Me.button4.Text = "WriteXML"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(36, 184)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(165, 43)
        Me.button3.TabIndex = 8
        Me.button3.Text = "ExecuteNonQuery"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(36, 135)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(165, 43)
        Me.button2.TabIndex = 7
        Me.button2.Text = "ExecuteReader"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(36, 86)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(165, 43)
        Me.button1.TabIndex = 6
        Me.button1.Text = "ExecuteScalar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'dataGridView2
        '
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Location = New System.Drawing.Point(246, 233)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.RowHeadersWidth = 51
        Me.dataGridView2.RowTemplate.Height = 27
        Me.dataGridView2.Size = New System.Drawing.Size(511, 198)
        Me.dataGridView2.TabIndex = 12
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(246, 24)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 27
        Me.dataGridView1.Size = New System.Drawing.Size(511, 203)
        Me.dataGridView1.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents dataGridView2 As DataGridView
    Private WithEvents dataGridView1 As DataGridView
End Class
