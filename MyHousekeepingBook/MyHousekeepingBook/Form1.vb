Public Class Form1
    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click

        AddData()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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
            = New System.IO.StreamWriter("C:\Users\johns\Documents\TextFile.txt", False, System.Text.Encoding.Default)

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

    Sub LoadData()
        Dim path As String = "MoneyData.csv"
        Dim delimStr As String = ","
        Dim delimiter() As Char = delimStr.ToCharArray
        Dim strData() As String
        Dim strLine As String
        Dim fileExits As Boolean _
            = My.Computer.FileSystem.FileExists("C:\Users\johns\Documents\TextFile.txt")
        If fileExits Then
            Dim sr As IO.StreamReader =
                New IO.StreamReader("C:\Users\johns\Documents\TextFile.txt", System.Text.Encoding.Default)
            While (sr.Peek() >= 0)
                strLine = sr.ReadLine()
                strData = strLine.Split(delimiter)
                MoneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    Date.Parse(strData(0)),
                    strData(1).ToString(),
                    strData(2).ToString(),
                    Integer.Parse(strData(3)),
                    strData(4).ToString()
                )
            End While
            sr.Close()
        End If

    End Sub

    Private Sub UpdateData()
        Dim nowRow As Integer = dgv.CurrentRow.Index
        Dim oldDate As Date _
            = Date.Parse(dgv.Rows(nowRow).Cells(0).Value.ToString())
        Dim oldCategory As String = dgv.Rows(nowRow).Cells(1).Value.ToString()
        Dim oldItem As String = dgv.Rows(nowRow).Cells(2).Value.ToString()
        Dim oldMoney As Integer _
            = Integer.Parse(dgv.Rows(nowRow).Cells(3).Value.ToString())
        Dim oldRemarks As String = dgv.Rows(nowRow).Cells(4).Value.ToString()
        Dim frmItem As ItemForm = New ItemForm(
            CategoryDataSet1, oldDate, oldCategory, oldItem, oldMoney, oldRemarks)
        Dim drRet As DialogResult = frmItem.ShowDialog()

        If drRet = DialogResult.OK Then
            dgv.Rows(nowRow).Cells(0).Value _
                = frmItem.MonthCalendar1.SelectionRange.Start()
            dgv.Rows(nowRow).Cells(1).Value = frmItem.cmbCategory.Text
            dgv.Rows(nowRow).Cells(2).Value = frmItem.txtItem.Text
            dgv.Rows(nowRow).Cells(3).Value = Integer.Parse(frmItem.mtxtMoney.Text)
            dgv.Rows(nowRow).Cells(4).Value = frmItem.txtRemarks.Text
        End If

    End Sub

    Private Sub 変更CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 変更CToolStripMenuItem.Click
        UpdateData()
    End Sub

    Private Sub buttonChange_Click(sender As Object, e As EventArgs) Handles buttonChange.Click
        UpdateData()
    End Sub

    Private Sub DeleteData()
        Dim nowRow As Integer = dgv.CurrentRow.Index
        dgv.Rows.RemoveAt(nowRow)
    End Sub

    Private Sub 削除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 削除DToolStripMenuItem.Click
        DeleteData()
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        DeleteData()
    End Sub
End Class
