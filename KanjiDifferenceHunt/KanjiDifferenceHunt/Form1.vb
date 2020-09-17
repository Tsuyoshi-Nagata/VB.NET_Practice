Public Class FormGame

    '正解の文字：1つだけ
    Dim correctText As String = "﨑"

    '間違いの文字：24個
    Dim mistakeText As String = "崎"

    '経過時間
    Dim nowTime As Double


    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click
        If CType(sender, Button).Text = correctText Then
            '時間の計測終了
            Timer1.Stop()
        Else
            'ペナルティーで記録に10秒追加
            nowTime = nowTime + 10
        End If
    End Sub

    'スタートボタンを押したとき
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        '探す文字を表示
        TextHunt.Text = correctText

        '乱数を生成するためのインスタンスを作成
        Dim Rnd As Random = New Random()

        '0～24の乱数を取得
        Dim randomResult As Integer = Rnd.Next(25)

        'SplitContainerの下部のPanel2に乗っている
        'ButtonのTextをすべて間違いの文字にする
        For i As Integer = 0 To SplitContainer1.Panel2.Controls.Count - 1
            SplitContainer1.Panel2.Controls(i).Text = mistakeText
        Next

        'ランダムで1つだけ正解の文字にする
        SplitContainer1.Panel2.Controls(randomResult).Text = correctText

        'タイマースタート
        'タイマーの初期化
        nowTime = 0
        Timer1.Start()
    End Sub


    '0.02秒おきに呼ばれるタイマーのイベントハンドラ
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nowTime = nowTime + 0.02
        TextTimer.Text = nowTime.ToString("0.00")
    End Sub
End Class
