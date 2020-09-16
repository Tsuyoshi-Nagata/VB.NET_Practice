<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFusen
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
        Me.TextFusenMemo = New System.Windows.Forms.TextBox()
        Me.ColorDialogFusen = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'TextFusenMemo
        '
        Me.TextFusenMemo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextFusenMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextFusenMemo.Location = New System.Drawing.Point(0, 0)
        Me.TextFusenMemo.Multiline = True
        Me.TextFusenMemo.Name = "TextFusenMemo"
        Me.TextFusenMemo.Size = New System.Drawing.Size(800, 450)
        Me.TextFusenMemo.TabIndex = 0
        '
        'FormFusen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextFusenMemo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFusen"
        Me.Opacity = 0.6R
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextFusenMemo As TextBox
    Friend WithEvents ColorDialogFusen As ColorDialog
End Class
