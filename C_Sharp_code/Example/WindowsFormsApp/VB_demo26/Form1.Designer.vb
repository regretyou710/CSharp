﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(68, 189)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(108, 37)
        Me.button4.TabIndex = 7
        Me.button4.Text = "物件轉型"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(68, 146)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(108, 37)
        Me.button3.TabIndex = 6
        Me.button3.Text = "檔案不存在"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(68, 103)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(108, 37)
        Me.button2.TabIndex = 5
        Me.button2.Text = "索引超出範圍"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(68, 60)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(108, 37)
        Me.button1.TabIndex = 4
        Me.button1.Text = "DivideByZero"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(200, 156)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(108, 47)
        Me.button7.TabIndex = 10
        Me.button7.Text = "自訂引發例外"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(200, 103)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(108, 47)
        Me.button6.TabIndex = 9
        Me.button6.Text = "多個攔截程式區塊"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(200, 60)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(108, 37)
        Me.button5.TabIndex = 8
        Me.button5.Text = "巢狀例外"
        Me.button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 369)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
End Class
