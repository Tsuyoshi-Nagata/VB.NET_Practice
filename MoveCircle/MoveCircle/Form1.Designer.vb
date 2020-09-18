<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBallGame
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.SelectPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextTimer = New System.Windows.Forms.TextBox()
        Me.Texthunt = New System.Windows.Forms.TextBox()
        Me.MainPictureBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SelectPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestartButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SelectPictureBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextTimer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Texthunt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MainPictureBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 753)
        Me.SplitContainer1.SplitterDistance = 70
        Me.SplitContainer1.TabIndex = 0
        '
        'RestartButton
        '
        Me.RestartButton.Location = New System.Drawing.Point(823, 20)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(82, 35)
        Me.RestartButton.TabIndex = 3
        Me.RestartButton.Text = "再スタート"
        Me.RestartButton.UseVisualStyleBackColor = True
        '
        'SelectPictureBox
        '
        Me.SelectPictureBox.BackColor = System.Drawing.Color.White
        Me.SelectPictureBox.Location = New System.Drawing.Point(542, 9)
        Me.SelectPictureBox.Name = "SelectPictureBox"
        Me.SelectPictureBox.Size = New System.Drawing.Size(275, 50)
        Me.SelectPictureBox.TabIndex = 2
        Me.SelectPictureBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1142, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "秒"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(956, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "記録："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "↓下のエリアをクリックするとボールの位置が変わります"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "下の背景に表示された漢字と同じ色の円をクリック➡"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "を探せ"
        '
        'TextTimer
        '
        Me.TextTimer.Font = New System.Drawing.Font("メイリオ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextTimer.Location = New System.Drawing.Point(1007, 11)
        Me.TextTimer.Name = "TextTimer"
        Me.TextTimer.Size = New System.Drawing.Size(129, 48)
        Me.TextTimer.TabIndex = 0
        Me.TextTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Texthunt
        '
        Me.Texthunt.Font = New System.Drawing.Font("メイリオ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Texthunt.Location = New System.Drawing.Point(12, 11)
        Me.Texthunt.Name = "Texthunt"
        Me.Texthunt.Size = New System.Drawing.Size(45, 48)
        Me.Texthunt.TabIndex = 0
        '
        'MainPictureBox
        '
        Me.MainPictureBox.BackColor = System.Drawing.Color.White
        Me.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.MainPictureBox.Name = "MainPictureBox"
        Me.MainPictureBox.Size = New System.Drawing.Size(1182, 679)
        Me.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainPictureBox.TabIndex = 0
        Me.MainPictureBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'FormBallGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormBallGame"
        Me.Text = "間違いボール探し"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SelectPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RestartButton As Button
    Friend WithEvents SelectPictureBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextTimer As TextBox
    Friend WithEvents Texthunt As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainPictureBox As PictureBox
End Class
