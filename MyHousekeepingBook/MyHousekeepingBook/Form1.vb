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

    Private Sub SaveData()
        Dim path As String = "MoneyData.csv"
        Dim strData As String
        Dim sw As System.IO.StreamWriter _
            = New System.IO.StreamWriter(path, False, System.Text.Encoding.Default)

        For Each drMoney As MoneyDataSet.moneyDataTableRow
                In MoneyDataSet.moneyDataTable
            strData = drMoney.日付.ToShortDateString() _
                + "," + drMoney.分類 _
                + "," + drMoney.品名 _
                + "," + drMoney.金額.ToString() _
                + "," + drMoney.備考
            sw.WriteLine(strData)

        Next
        sw.Close()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveData()
    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        SaveData()
    End Sub
End Class
