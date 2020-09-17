<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUranai
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
        Me.DateTimeUranai = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxResult = New System.Windows.Forms.PictureBox()
        Me.ButtonUranaiStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextResult = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimeUranai
        '
        Me.DateTimeUranai.Location = New System.Drawing.Point(97, 10)
        Me.DateTimeUranai.Name = "DateTimeUranai"
        Me.DateTimeUranai.Size = New System.Drawing.Size(171, 22)
        Me.DateTimeUranai.TabIndex = 0
        '
        'PictureBoxResult
        '
        Me.PictureBoxResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxResult.Image = Global.Uranai.My.Resources.Resources.Title
        Me.PictureBoxResult.Location = New System.Drawing.Point(12, 70)
        Me.PictureBoxResult.Name = "PictureBoxResult"
        Me.PictureBoxResult.Size = New System.Drawing.Size(256, 100)
        Me.PictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxResult.TabIndex = 1
        Me.PictureBoxResult.TabStop = False
        '
        'ButtonUranaiStart
        '
        Me.ButtonUranaiStart.Location = New System.Drawing.Point(12, 41)
        Me.ButtonUranaiStart.Name = "ButtonUranaiStart"
        Me.ButtonUranaiStart.Size = New System.Drawing.Size(256, 23)
        Me.ButtonUranaiStart.TabIndex = 2
        Me.ButtonUranaiStart.Text = "占う"
        Me.ButtonUranaiStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "今日の日付"
        '
        'TextResult
        '
        Me.TextResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextResult.Location = New System.Drawing.Point(12, 175)
        Me.TextResult.Multiline = True
        Me.TextResult.Name = "TextResult"
        Me.TextResult.Size = New System.Drawing.Size(256, 70)
        Me.TextResult.TabIndex = 4
        '
        'FormUranai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.TextResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonUranaiStart)
        Me.Controls.Add(Me.PictureBoxResult)
        Me.Controls.Add(Me.DateTimeUranai)
        Me.Name = "FormUranai"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "占い"
        CType(Me.PictureBoxResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimeUranai As DateTimePicker
    Friend WithEvents PictureBoxResult As PictureBox
    Friend WithEvents ButtonUranaiStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextResult As TextBox
End Class
