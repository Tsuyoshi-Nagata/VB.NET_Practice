Public Class FormUranai
    Private Sub ButtonUranaiStart_Click(sender As Object, e As EventArgs) Handles ButtonUranaiStart.Click
        '年間累積日を記憶する変数
        Dim dateNumber As Integer
        '選んだ日付から、年間累積日を計算
        dateNumber = DateTimeUranai.Value.DayOfYear

        '年間累積日を5で割った余りは？
        Select Case dateNumber Mod 5
            Case 0 '大吉
                PictureBoxResult.Image = My.Resources.Daikichi
                TextResult.Text = "今世紀最大にツイてます"

            Case 1 '中吉
                PictureBoxResult.Image = My.Resources.Cyuukichi
                TextResult.Text = "No.2の座をほしいままにできるかも"

            Case 2 '小吉
                PictureBoxResult.Image = My.Resources.Shokichi
                TextResult.Text = "実は吉より運がいい"

            Case 3 '吉
                PictureBoxResult.Image = My.Resources.Kichi
                TextResult.Text = "とはいえ吉である"

            Case 4 '凶
                PictureBoxResult.Image = My.Resources.Kyo
                TextResult.Text = "明日があるさ"

            Case Else 'ここにたどり着いたら条件ミス'
                PictureBoxResult.Image = Nothing

        End Select
    End Sub
End Class
