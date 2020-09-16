<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Input1TextBox = New System.Windows.Forms.TextBox()
        Me.PlusLabel = New System.Windows.Forms.Label()
        Me.Input2TextBox = New System.Windows.Forms.TextBox()
        Me.EqualLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input1TextBox
        '
        Me.Input1TextBox.Location = New System.Drawing.Point(13, 13)
        Me.Input1TextBox.Name = "Input1TextBox"
        Me.Input1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Input1TextBox.TabIndex = 0
        '
        'PlusLabel
        '
        Me.PlusLabel.AutoSize = True
        Me.PlusLabel.Location = New System.Drawing.Point(120, 16)
        Me.PlusLabel.Name = "PlusLabel"
        Me.PlusLabel.Size = New System.Drawing.Size(15, 15)
        Me.PlusLabel.TabIndex = 1
        Me.PlusLabel.Text = "+"
        '
        'Input2TextBox
        '
        Me.Input2TextBox.Location = New System.Drawing.Point(141, 13)
        Me.Input2TextBox.Name = "Input2TextBox"
        Me.Input2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Input2TextBox.TabIndex = 2
        '
        'EqualLabel
        '
        Me.EqualLabel.AutoSize = True
        Me.EqualLabel.Location = New System.Drawing.Point(248, 15)
        Me.EqualLabel.Name = "EqualLabel"
        Me.EqualLabel.Size = New System.Drawing.Size(15, 15)
        Me.EqualLabel.TabIndex = 3
        Me.EqualLabel.Text = "="
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(270, 12)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AnswerTextBox.TabIndex = 4
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(13, 58)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(357, 28)
        Me.CalcButton.TabIndex = 5
        Me.CalcButton.Text = "計算する"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 116)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.EqualLabel)
        Me.Controls.Add(Me.Input2TextBox)
        Me.Controls.Add(Me.PlusLabel)
        Me.Controls.Add(Me.Input1TextBox)
        Me.Name = "Form1"
        Me.Text = "簡単計算プログラム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input1TextBox As TextBox
    Friend WithEvents PlusLabel As Label
    Friend WithEvents Input2TextBox As TextBox
    Friend WithEvents EqualLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents CalcButton As Button
End Class
