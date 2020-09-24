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
        Me.components = New System.ComponentModel.Container()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.追加AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.変更CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.削除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一覧表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.集計表示SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyDataSet = New MyHousekeepingBook.MoneyDataSet()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.buttonChange = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonEnd = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabList = New System.Windows.Forms.TabPage()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.SumDgv = New System.Windows.Forms.DataGridView()
        Me.CategoryDataSet1 = New MyHousekeepingBook.CategoryDataSet()
        Me.日付DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.入金合計DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出金合計DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SummaryDataSet = New MyHousekeepingBook.SummaryDataSet()
        Me.mainMenu.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabList.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        CType(Me.SumDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SumDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SummaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.mainMenu.Size = New System.Drawing.Size(1312, 44)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存SToolStripMenuItem, Me.ToolStripSeparator1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(129, 36)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(225, 44)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(222, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(225, 44)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.追加AToolStripMenuItem, Me.変更CToolStripMenuItem, Me.削除DToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(109, 36)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '追加AToolStripMenuItem
        '
        Me.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem"
        Me.追加AToolStripMenuItem.Size = New System.Drawing.Size(262, 44)
        Me.追加AToolStripMenuItem.Text = "追加(&A)"
        '
        '変更CToolStripMenuItem
        '
        Me.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem"
        Me.変更CToolStripMenuItem.Size = New System.Drawing.Size(262, 44)
        Me.変更CToolStripMenuItem.Text = "変更(&C)"
        '
        '削除DToolStripMenuItem
        '
        Me.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem"
        Me.削除DToolStripMenuItem.Size = New System.Drawing.Size(262, 44)
        Me.削除DToolStripMenuItem.Text = "削除（&D）"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.一覧表示ToolStripMenuItem, Me.集計表示SToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(112, 38)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '一覧表示ToolStripMenuItem
        '
        Me.一覧表示ToolStripMenuItem.Name = "一覧表示ToolStripMenuItem"
        Me.一覧表示ToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.一覧表示ToolStripMenuItem.Text = "一覧表示(&L)"
        '
        '集計表示SToolStripMenuItem
        '
        Me.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem"
        Me.集計表示SToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.集計表示SToolStripMenuItem.Text = "集計表示(&S)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報VToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(124, 36)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報VToolStripMenuItem
        '
        Me.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem"
        Me.バージョン情報VToolStripMenuItem.Size = New System.Drawing.Size(312, 44)
        Me.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.品名DataGridViewTextBoxColumn, Me.金額DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.MoneyDataTableBindingSource
        Me.dgv.Location = New System.Drawing.Point(3, 8)
        Me.dgv.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1253, 568)
        Me.dgv.TabIndex = 1
        '
        '日付DataGridViewTextBoxColumn
        '
        Me.日付DataGridViewTextBoxColumn.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn"
        Me.日付DataGridViewTextBoxColumn.Width = 125
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        Me.分類DataGridViewTextBoxColumn.Width = 125
        '
        '品名DataGridViewTextBoxColumn
        '
        Me.品名DataGridViewTextBoxColumn.DataPropertyName = "品名"
        Me.品名DataGridViewTextBoxColumn.HeaderText = "品名"
        Me.品名DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn"
        Me.品名DataGridViewTextBoxColumn.Width = 125
        '
        '金額DataGridViewTextBoxColumn
        '
        Me.金額DataGridViewTextBoxColumn.DataPropertyName = "金額"
        Me.金額DataGridViewTextBoxColumn.HeaderText = "金額"
        Me.金額DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn"
        Me.金額DataGridViewTextBoxColumn.Width = 125
        '
        '備考DataGridViewTextBoxColumn
        '
        Me.備考DataGridViewTextBoxColumn.DataPropertyName = "備考"
        Me.備考DataGridViewTextBoxColumn.HeaderText = "備考"
        Me.備考DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn"
        Me.備考DataGridViewTextBoxColumn.Width = 125
        '
        'MoneyDataTableBindingSource
        '
        Me.MoneyDataTableBindingSource.DataMember = "moneyDataTable"
        Me.MoneyDataTableBindingSource.DataSource = Me.MoneyDataSetBindingSource
        '
        'MoneyDataSetBindingSource
        '
        Me.MoneyDataSetBindingSource.DataSource = Me.MoneyDataSet
        Me.MoneyDataSetBindingSource.Position = 0
        '
        'MoneyDataSet
        '
        Me.MoneyDataSet.DataSetName = "MoneyDataSet"
        Me.MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(17, 605)
        Me.buttonAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(114, 37)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonChange
        '
        Me.buttonChange.Location = New System.Drawing.Point(163, 605)
        Me.buttonChange.Margin = New System.Windows.Forms.Padding(5)
        Me.buttonChange.Name = "buttonChange"
        Me.buttonChange.Size = New System.Drawing.Size(114, 37)
        Me.buttonChange.TabIndex = 2
        Me.buttonChange.Text = "変更"
        Me.buttonChange.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(315, 605)
        Me.buttonDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(114, 37)
        Me.buttonDelete.TabIndex = 2
        Me.buttonDelete.Text = "削除"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonEnd
        '
        Me.buttonEnd.Location = New System.Drawing.Point(1038, 605)
        Me.buttonEnd.Margin = New System.Windows.Forms.Padding(5)
        Me.buttonEnd.Name = "buttonEnd"
        Me.buttonEnd.Size = New System.Drawing.Size(114, 37)
        Me.buttonEnd.TabIndex = 2
        Me.buttonEnd.Text = "終了"
        Me.buttonEnd.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabList)
        Me.TabControl1.Controls.Add(Me.tabSummary)
        Me.TabControl1.Location = New System.Drawing.Point(12, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1280, 775)
        Me.TabControl1.TabIndex = 3
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.dgv)
        Me.tabList.Controls.Add(Me.buttonEnd)
        Me.tabList.Controls.Add(Me.buttonAdd)
        Me.tabList.Controls.Add(Me.buttonDelete)
        Me.tabList.Controls.Add(Me.buttonChange)
        Me.tabList.Location = New System.Drawing.Point(8, 39)
        Me.tabList.Name = "tabList"
        Me.tabList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabList.Size = New System.Drawing.Size(1264, 728)
        Me.tabList.TabIndex = 0
        Me.tabList.Text = "一覧表示"
        Me.tabList.UseVisualStyleBackColor = True
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.SumDgv)
        Me.tabSummary.Location = New System.Drawing.Point(8, 39)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(1264, 728)
        Me.tabSummary.TabIndex = 1
        Me.tabSummary.Text = "集計表示"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'SumDgv
        '
        Me.SumDgv.AutoGenerateColumns = False
        Me.SumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SumDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn1, Me.入金合計DataGridViewTextBoxColumn, Me.出金合計DataGridViewTextBoxColumn})
        Me.SumDgv.DataSource = Me.SumDataTableBindingSource
        Me.SumDgv.Location = New System.Drawing.Point(6, 6)
        Me.SumDgv.Name = "SumDgv"
        Me.SumDgv.RowHeadersWidth = 82
        Me.SumDgv.RowTemplate.Height = 33
        Me.SumDgv.Size = New System.Drawing.Size(1252, 716)
        Me.SumDgv.TabIndex = 0
        '
        'CategoryDataSet1
        '
        Me.CategoryDataSet1.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '日付DataGridViewTextBoxColumn1
        '
        Me.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn1.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1"
        Me.日付DataGridViewTextBoxColumn1.Width = 200
        '
        '入金合計DataGridViewTextBoxColumn
        '
        Me.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn.MinimumWidth = 10
        Me.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn"
        Me.入金合計DataGridViewTextBoxColumn.Width = 200
        '
        '出金合計DataGridViewTextBoxColumn
        '
        Me.出金合計DataGridViewTextBoxColumn.DataPropertyName = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn.HeaderText = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn.MinimumWidth = 10
        Me.出金合計DataGridViewTextBoxColumn.Name = "出金合計DataGridViewTextBoxColumn"
        Me.出金合計DataGridViewTextBoxColumn.Width = 200
        '
        'SumDataTableBindingSource
        '
        Me.SumDataTableBindingSource.DataMember = "SumDataTable"
        Me.SumDataTableBindingSource.DataSource = Me.SummaryDataSet
        '
        'SummaryDataSet
        '
        Me.SummaryDataSet.DataSetName = "SummaryDataSet"
        Me.SummaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 863)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "簡易家計簿"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabList.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        CType(Me.SumDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SumDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SummaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents dgv As DataGridView
    Friend WithEvents buttonAdd As Button
    Friend WithEvents buttonChange As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonEnd As Button
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 追加AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 変更CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 削除DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 一覧表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 集計表示SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoneyDataSet As MoneyDataSet
    Friend WithEvents 日付DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 品名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 金額DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備考DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataTableBindingSource As BindingSource
    Friend WithEvents MoneyDataSetBindingSource As BindingSource
    Friend WithEvents CategoryDataSet1 As CategoryDataSet
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabList As TabPage
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents SumDgv As DataGridView
    Friend WithEvents 日付DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 入金合計DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 出金合計DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SumDataTableBindingSource As BindingSource
    Friend WithEvents SummaryDataSet As SummaryDataSet
End Class
