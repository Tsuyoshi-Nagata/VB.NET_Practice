﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.buttonChange = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonEnd = New System.Windows.Forms.Button()
        Me.集計表示SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoneyDataSet = New MyHousekeepingBook.MoneyDataSet()
        Me.MoneyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataSet1 = New MyHousekeepingBook.CategoryDataSet()
        Me.mainMenu.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(800, 28)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存SToolStripMenuItem, Me.ToolStripSeparator1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.追加AToolStripMenuItem, Me.変更CToolStripMenuItem, Me.削除DToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '追加AToolStripMenuItem
        '
        Me.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem"
        Me.追加AToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.追加AToolStripMenuItem.Text = "追加(&A)"
        '
        '変更CToolStripMenuItem
        '
        Me.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem"
        Me.変更CToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.変更CToolStripMenuItem.Text = "変更(&C)"
        '
        '削除DToolStripMenuItem
        '
        Me.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem"
        Me.削除DToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.削除DToolStripMenuItem.Text = "削除（&D）"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.一覧表示ToolStripMenuItem, Me.集計表示SToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(72, 26)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '一覧表示ToolStripMenuItem
        '
        Me.一覧表示ToolStripMenuItem.Name = "一覧表示ToolStripMenuItem"
        Me.一覧表示ToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.一覧表示ToolStripMenuItem.Text = "一覧表示(&L)"
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.品名DataGridViewTextBoxColumn, Me.金額DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.MoneyDataTableBindingSource
        Me.dgv.Location = New System.Drawing.Point(12, 42)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(776, 355)
        Me.dgv.TabIndex = 1
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(21, 415)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(75, 23)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonChange
        '
        Me.buttonChange.Location = New System.Drawing.Point(111, 415)
        Me.buttonChange.Name = "buttonChange"
        Me.buttonChange.Size = New System.Drawing.Size(75, 23)
        Me.buttonChange.TabIndex = 2
        Me.buttonChange.Text = "変更"
        Me.buttonChange.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(204, 415)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 23)
        Me.buttonDelete.TabIndex = 2
        Me.buttonDelete.Text = "削除"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonEnd
        '
        Me.buttonEnd.Location = New System.Drawing.Point(649, 415)
        Me.buttonEnd.Name = "buttonEnd"
        Me.buttonEnd.Size = New System.Drawing.Size(75, 23)
        Me.buttonEnd.TabIndex = 2
        Me.buttonEnd.Text = "終了"
        Me.buttonEnd.UseVisualStyleBackColor = True
        '
        '集計表示SToolStripMenuItem
        '
        Me.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem"
        Me.集計表示SToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.集計表示SToolStripMenuItem.Text = "集計表示(&S)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報VToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(79, 26)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報VToolStripMenuItem
        '
        Me.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem"
        Me.バージョン情報VToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'MoneyDataSet
        '
        Me.MoneyDataSet.DataSetName = "MoneyDataSet"
        Me.MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoneyDataSetBindingSource
        '
        Me.MoneyDataSetBindingSource.DataSource = Me.MoneyDataSet
        Me.MoneyDataSetBindingSource.Position = 0
        '
        'MoneyDataTableBindingSource
        '
        Me.MoneyDataTableBindingSource.DataMember = "moneyDataTable"
        Me.MoneyDataTableBindingSource.DataSource = Me.MoneyDataSetBindingSource
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
        'CategoryDataSet1
        '
        Me.CategoryDataSet1.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonEnd)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonChange)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "Form1"
        Me.Text = "簡易家計簿"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class