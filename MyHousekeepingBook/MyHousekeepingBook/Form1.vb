Public Class Form1
    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click

        AddData()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '型付きデータセットのデータテーブルに（）内の分類データを準備する処理
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金")

    End Sub

    Private Sub AddData()
        Dim frmItem As ItemForm = New ItemForm(CategoryDataSet1)
        Dim drRet As DialogResult = frmItem.ShowDialog()

        If drRet = System.Windows.Forms.DialogResult.OK Then
            MoneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                frmItem.MonthCalendar1.SelectionRange.Start(),
                frmItem.cmbCategory.Text,
                frmItem.txtItem.Text,
                Integer.Parse(frmItem.mtxtMoney.Text),
                frmItem.txtRemarks.Text)
        End If

    End Sub

    Private Sub 追加AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 追加AToolStripMenuItem.Click

        AddData()

    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub buttonEnd_Click(sender As Object, e As EventArgs) Handles buttonEnd.Click
        Me.Close()
    End Sub
End Class
