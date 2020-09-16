<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimer
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextSetTime = New System.Windows.Forms.TextBox()
        Me.TextRemainingTime = New System.Windows.Forms.TextBox()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.TimerControl = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "時間設定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "秒"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "残り時間"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "秒"
        '
        'TextSetTime
        '
        Me.TextSetTime.Location = New System.Drawing.Point(136, 41)
        Me.TextSetTime.Name = "TextSetTime"
        Me.TextSetTime.Size = New System.Drawing.Size(100, 22)
        Me.TextSetTime.TabIndex = 1
        Me.TextSetTime.Text = "10"
        Me.TextSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextRemainingTime
        '
        Me.TextRemainingTime.Location = New System.Drawing.Point(136, 137)
        Me.TextRemainingTime.Name = "TextRemainingTime"
        Me.TextRemainingTime.Size = New System.Drawing.Size(100, 22)
        Me.TextRemainingTime.TabIndex = 1
        Me.TextRemainingTime.Text = "10"
        Me.TextRemainingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(63, 89)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(213, 23)
        Me.ButtonStart.TabIndex = 2
        Me.ButtonStart.Text = "スタート！"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'TimerControl
        '
        Me.TimerControl.Interval = 1000
        '
        'FormTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 218)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.TextRemainingTime)
        Me.Controls.Add(Me.TextSetTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTimer"
        Me.Text = "タイマー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextSetTime As TextBox
    Friend WithEvents TextRemainingTime As TextBox
    Friend WithEvents ButtonStart As Button
    Friend WithEvents TimerControl As Windows.Forms.Timer
End Class
