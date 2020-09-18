<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSlackPost
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
        Me.butPost = New System.Windows.Forms.Button()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'butPost
        '
        Me.butPost.Location = New System.Drawing.Point(195, 216)
        Me.butPost.Name = "butPost"
        Me.butPost.Size = New System.Drawing.Size(75, 31)
        Me.butPost.TabIndex = 0
        Me.butPost.Text = "投稿"
        Me.butPost.UseVisualStyleBackColor = True
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(12, 24)
        Me.txtPost.Multiline = True
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(258, 186)
        Me.txtPost.TabIndex = 1
        '
        'FormSlackPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.txtPost)
        Me.Controls.Add(Me.butPost)
        Me.Name = "FormSlackPost"
        Me.Text = "Slack投稿"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butPost As Button
    Friend WithEvents txtPost As TextBox
End Class
