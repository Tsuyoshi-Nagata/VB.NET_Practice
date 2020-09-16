Public Class FormFusen
    'マウスのx座標
    'マウスのy座標
    Private MouseX As Integer
    Private MouseY As Integer


    'テキストボックスにキーボードから文字を入力したとき
    Private Sub TextFusenMemo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFusenMemo.KeyDown
        '＜判定＞押されたキーが「Esc」？
        If (e.KeyCode = Keys.Escape) Then
            '「Yes」なら
            '   アプリ終了
            Me.Close()
        End If

    End Sub

    Private Sub TextFusenMemo_MouseDown(sender As Object, e As MouseEventArgs) Handles TextFusenMemo.MouseDown
        '＜判定＞押されたボタンがマウスの左ボタン？
        If (e.Button = MouseButtons.Left) Then
            '「Yes」なら
            '   マウスのx座標を記憶
            '   マウスのy座標を記憶
            Me.MouseX = e.X
            Me.MouseY = e.Y
        End If
    End Sub

    'テキストボックスでクリックしたマウスを移動させたとき
    Private Sub TextFusenMemo_MouseMove(sender As Object, e As MouseEventArgs) Handles TextFusenMemo.MouseMove
        '＜判定＞押されたボタンがマウスの左ボタン？
        If (e.Button = MouseButtons.Left) Then
            '「Yes」なら
            '   フォームの横位置を更新
            '   フォームの縦位置を更新
            Me.Left = Me.Left + e.X - MouseX
            Me.Top = Me.Top + e.Y - MouseY
        End If
    End Sub

    'テキストボックスをマウスでダブルクリックしたとき
    Private Sub TextFusenMemo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextFusenMemo.MouseDoubleClick
        '色の設定ダイアログを表示する
        ColorDialogFusen.ShowDialog()

        'テキストボックスの背景色を色の設定ダイアログで選んだ色に設定する
        TextFusenMemo.BackColor = ColorDialogFusen.Color
    End Sub
End Class
