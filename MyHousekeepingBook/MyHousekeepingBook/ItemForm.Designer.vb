<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemForm
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.mtxtMoney = New System.Windows.Forms.MaskedTextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.CategoryDataSet = New MyHousekeepingBook.CategoryDataSet()
        Me.CategoryDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "分類"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "品名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "金額"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "備考"
        '
        'cmbCategory
        '
        Me.cmbCategory.DataSource = Me.CategoryDataTableBindingSource
        Me.cmbCategory.DisplayMember = "分類"
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(334, 48)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 23)
        Me.cmbCategory.TabIndex = 2
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(334, 96)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 22)
        Me.txtItem.TabIndex = 3
        '
        'mtxtMoney
        '
        Me.mtxtMoney.Location = New System.Drawing.Point(334, 145)
        Me.mtxtMoney.Mask = "999999"
        Me.mtxtMoney.Name = "mtxtMoney"
        Me.mtxtMoney.Size = New System.Drawing.Size(100, 22)
        Me.mtxtMoney.TabIndex = 4
        Me.mtxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(334, 189)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(100, 22)
        Me.txtRemarks.TabIndex = 3
        '
        'buttonOK
        '
        Me.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(101, 250)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 5
        Me.buttonOK.Text = "登録"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(334, 250)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "キャンセル"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryDataTableBindingSource
        '
        Me.CategoryDataTableBindingSource.DataMember = "CategoryDataTable"
        Me.CategoryDataTableBindingSource.DataSource = Me.CategoryDataSet
        '
        'ItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 312)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.mtxtMoney)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "ItemForm"
        Me.Text = "登録"
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents buttonOK As Button
    Friend WithEvents buttonCancel As Button
    Public WithEvents MonthCalendar1 As MonthCalendar
    Public WithEvents cmbCategory As ComboBox
    Public WithEvents txtItem As TextBox
    Public WithEvents mtxtMoney As MaskedTextBox
    Public WithEvents txtRemarks As TextBox
    Friend WithEvents CategoryDataTableBindingSource As BindingSource
    Friend WithEvents CategoryDataSet As CategoryDataSet
End Class
