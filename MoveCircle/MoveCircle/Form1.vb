Public Class FormBallGame


    '画面下の描画領域
    Private canvas As Bitmap
    'ボールを管理
    Private balls As Ball()
    'ボールに描く漢字の配列
    Private kanjis As String()
    'ボールを塗る色の配列
    Private brushes As Brush()
    '表示する漢字のフォント名
    Private fontName As String = "HG教科書"
    '正解の文字：1つだけ
    Private correctText As String = "荻"
    '間違いの文字：ボールの個数分
    Private mistakeText As String = "萩"
    '正解した場合背景の文字を〇にする
    Private circleText As String = "〇"
    '経過時間
    Private nowTime As Double = 0
    'ボールの数（0から始まるため1つ減らす）
    Private ballCount As Integer = 5 - 1
    '正解の番号：0～ボールの数のいずれか
    Private randomResult As Integer = 0



    Private Sub FormBallGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitGraphics()
        SetStartPosition()

        'DrawCircleSelectPictureBox()
        'DrawMainPictureBox(brushes.Gray, fontName, correctText)

    End Sub



    '再スタートボタンが押されたとき呼ばれるイベントハンドラ
    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        InitGraphics()
        SetStartPosition()
    End Sub




    '上部ピクチャーボックスがマウスで押されたとき呼ばれるイベントハンドラ
    Private Sub SelectPictureBox_MouseClick(sender As Object, e As MouseEventArgs) Handles SelectPictureBox.Click
        '再スタートボタンが操作可能な場合は何もせずに終了
        If (RestartButton.Enabled) Then
            Exit Sub
        End If

        '押されたX座標で正解判定
        '＜判定＞押されたボタンがマウスの左ボタン？
        If (e.Button = MouseButtons.Left) Then
            'どの円を選択したか計算で算出（クリックしたX座標の位置/PictureBoxの横幅）
            Dim selectCircle As Integer = e.X / SelectPictureBox.Height
            If (randomResult = selectCircle) Then
                Timer1.Stop()
                DrawMainPictureBox(Drawing.Brushes.Red, fontName, circleText, True)

                '再スタートボタンを操作可能に
                RestartButton.Enabled = True
            Else
                DrawMainPictureBox(Drawing.Brushes.Red, fontName, correctText, False)

                '移動の割合を減らし、ゆっくり動かす
                For i As Integer = 0 To ballCount
                    balls(i).pitch = balls(i).pitch - balls(i).pitch / 2
                Next

                'ペナルティ
                nowTime = nowTime + 10

            End If

        End If


    End Sub


    '下部のピクチャーボックスがマウスで押されたとき呼ばれるイベントハンドラ
    Private Sub MainPictureBox_MouseClick(sender As Object, e As MouseEventArgs) Handles MainPictureBox.Click
        ' 再スタートボタンが操作可能な場合は何もせずに処理終了
        If (RestartButton.Enabled) Then
            Exit Sub
        End If

        SetBalls(e.X, e.Y)  ' マウスをクリックした位置にボールをセット
    End Sub


    'タイマーが動いているときに呼ばれるイベントハンドラ
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To ballCount
            balls(i).Move()
        Next

        nowTime = nowTime + 0.02
        TextTimer.Text = nowTime.ToString("0.00")
    End Sub





    'PictureBoxコントロールに円を描いてみる
    Private Sub DrawCircleSelectPictureBox()
        '高さ
        Dim height As Integer = SelectPictureBox.Height
        '横幅
        Dim width As Integer = SelectPictureBox.Width

        Dim selectCanvas As Bitmap = New Bitmap(width, height)

        Using g As Graphics = Graphics.FromImage(selectCanvas)
            For i As Integer = 0 To ballCount
                g.FillEllipse(brushes(i), i * height, 0, height, height)
            Next
            SelectPictureBox.Image = selectCanvas
        End Using

    End Sub

    '下のPictureBoxに描画すり
    Private Sub DrawMainPictureBox(color As Brush, font As String, text As String, trueFlag As Boolean)

        '高さ
        Dim height As Integer = MainPictureBox.Height
        '横幅
        Dim width As Integer = MainPictureBox.Width

        '描画先とするImageオブジェクトを作成する
        'Dim canvas As Bitmap = New Bitmap(width, height)

        If canvas Is Nothing Then
            canvas = New Bitmap(width, height)
        End If

        Using g As Graphics = Graphics.FromImage(canvas)
            If trueFlag Then
                g.FillRectangle(Drawing.Brushes.LightPink, 0, 0, width, height)

            Else
                g.FillRectangle(Drawing.Brushes.White, 0, 0, width, height)

            End If

            '背景に引数で指定した文字列を描画する
            g.DrawString(text,
                         New Font(font, height - height / 4),
                         color, 0, 0, New StringFormat())

            'mainPictureBoxに表示する
            MainPictureBox.Image = canvas

        End Using
    End Sub


    '配列の初期化、画面の初期設定を行う
    Private Sub InitGraphics()
        brushes = New Brush(ballCount) {}
        kanjis = New String(ballCount) {}
        balls = New Ball(ballCount) {}

        'ブラシの色設定
        brushes(0) = Drawing.Brushes.LightPink
        brushes(1) = Drawing.Brushes.LightBlue
        brushes(2) = Drawing.Brushes.LightGray
        brushes(3) = Drawing.Brushes.LightCoral
        brushes(4) = Drawing.Brushes.LightGreen

        '上のImageオブジェクト
        DrawCircleSelectPictureBox()

        '下のImageオブジェクト
        DrawMainPictureBox(Drawing.Brushes.Gray, fontName, correctText, False)

        '再スタートボタンを操作できないようにする
        RestartButton.Enabled = False
        Texthunt.Text = correctText

    End Sub


    'ボールのインスタンスの作成とランダムな位置にボールを置く
    Private Sub SetStartPosition()
        '漢字の設定
        For i As Integer = 0 To ballCount
            '間違いの文字をセット
            kanjis(i) = mistakeText
        Next
        'ボールの数分の乱数を取得
        randomResult = New Random().Next(ballCount)
        '正解の文字をセット
        kanjis(randomResult) = correctText

        'ボールクラスのインスタンス作成
        For i As Integer = 0 To ballCount
            balls(i) = New Ball(MainPictureBox, brushes(i), kanjis(i))
        Next
        'ランダムな位置にボールを描く
        Dim rndXMax As Integer = MainPictureBox.Width
        Dim rndYMAx As Integer = MainPictureBox.Height
        SetBalls(New Random().Next(rndXMax), New Random().Next(rndYMAx))

        'タイマーをスタートさせる
        nowTime = 0
        Timer1.Start()



    End Sub


    Private Sub SetBalls(x As Integer, y As Integer)
        Dim rndXMax As Integer = MainPictureBox.Width
        Dim rndYMax As Integer = MainPictureBox.Height
        Dim rndX As Integer
        Dim rndY As Integer
        For i As Integer = 0 To ballCount
            rndX = New Random(i * x).Next(rndXMax)
            rndY = New Random(i * y).Next(rndYMax)

            '移動前のボール削除
            balls(i).DeleteCircle()
            '新しい位置にボールを描く
            balls(i).PutCircle(rndX, rndY)

        Next


    End Sub


End Class
