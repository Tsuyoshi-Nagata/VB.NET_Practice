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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblGood = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnBefore = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "第"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCount.Location = New System.Drawing.Point(101, 30)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(132, 34)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "lblCount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "問"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(307, 210)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(165, 40)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Question"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(193, 119)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(140, 40)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.Text = "Answer"
        '
        'lblGood
        '
        Me.lblGood.AutoSize = True
        Me.lblGood.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGood.Location = New System.Drawing.Point(498, 210)
        Me.lblGood.Name = "lblGood"
        Me.lblGood.Size = New System.Drawing.Size(104, 40)
        Me.lblGood.TabIndex = 2
        Me.lblGood.Text = "Good"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(400, 112)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(282, 47)
        Me.txtAnswer.TabIndex = 3
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(107, 201)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(165, 59)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnBefore
        '
        Me.btnBefore.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBefore.Location = New System.Drawing.Point(73, 330)
        Me.btnBefore.Name = "btnBefore"
        Me.btnBefore.Size = New System.Drawing.Size(142, 68)
        Me.btnBefore.TabIndex = 4
        Me.btnBefore.Text = "Before"
        Me.btnBefore.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.Location = New System.Drawing.Point(544, 330)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(138, 68)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBefore)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblGood)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblGood As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnBefore As Button
    Friend WithEvents btnNext As Button
End Class
