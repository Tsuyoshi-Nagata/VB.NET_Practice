Public Class FormTimer
    Dim EndTime As Integer '終了時間の設定
    Dim NowTime As Integer '経過時間の設定

    'ボタンクリック時の処理
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        '時間を設定するTextBoxコントロールの値を終了時間の変数に代入する
        If Integer.TryParse(TextSetTime.Text, EndTime) = True Then
            EndTime = Integer.Parse(TextSetTime.Text)
        Else
            EndTime = 1
        End If

        '残り時間を計算するため、経過時間の変数を0で初期化
        NowTime = 0

        'タイマースタート
        TimerControl.Start()
    End Sub

    Private Sub TimerControl_Tick(sender As Object, e As EventArgs) Handles TimerControl.Tick
        '残り時間の変数を整数型で定義
        Dim RemainingTime As Integer

        '経過時間に1秒加える
        NowTime = NowTime + 1

        '残り時間を計算して表示
        RemainingTime = EndTime - NowTime
        TextRemainingTime.Text = RemainingTime.ToString()

        '＜判定＞設定時間になったか
        If EndTime = NowTime Then
            '「Yes」の場合
            '   タイマーを止める
            TimerControl.Stop()

            '   終了時間になったことを知らせる
            MessageBox.Show("時間になりました！")
        Else

        End If


        '「No」の場合の処理
    End Sub
End Class
