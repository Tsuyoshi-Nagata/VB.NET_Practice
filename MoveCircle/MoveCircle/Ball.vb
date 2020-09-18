
Imports System.Drawing
Imports System.Windows.Forms

Public Class Ball
    'クラスに必要な情報の定義
    '公開し外部から障ることができる値

    '移動の割合
    Public pitch As Integer

    '非公開で外部からは変更することができない値

    '描画するPictureBox
    Private pictureBox As PictureBox
    '描画するキャンバス
    Private canvas As Bitmap
    '塗りつぶす色
    Private brushColor As Brush
    '横座標（X座標）
    Private positionX As Integer
    '縦座標（Y座標）
    Private positionY As Integer
    '移動前の横位置（X座標）
    Private previousX As Integer
    '移動前の縦位置（Y座標）
    Private previousY As Integer
    '移動方向（X座標）（＋1 or －1）
    Private directionX As Integer
    '移動方向（Y座標）（＋1 or －1）
    Private directionY As Integer
    '円の半径
    Private radius As Integer
    '表示する漢字
    Private kanji As String
    '表示するフォント名
    Private fontName As String

    'Ballコンストラクタ
    '4つの引数を指定しクラス内部に保持する　4つの引数は、描画するPictureBox
    '描画するキャンバス、塗りつぶす色、表示する漢字
    Public Sub New(pb As PictureBox, cl As Brush, st As String)
        '描画するPictureBox
        pictureBox = pb
        '描画するキャンバス
        canvas = pb.Image
        '塗りつぶす色
        brushColor = cl
        '表示する漢字
        kanji = st
        '円の半径の初期設定
        radius = 40
        '移動の割合の初期設定（半径の半分）
        pitch = radius / 2
        '移動方向を+1で初期設定
        directionX = +1
        '移動方向を-1で初期設定
        directionY = -1
        '漢字のフォント名の初期設定
        fontName = "HG教科書体"
    End Sub

    '指定した位置にボールを描く
    Public Sub PutCircle(x As Integer, y As Integer)
        '現在の位置を記憶
        positionX = x
        positionY = y
        Using g As Graphics = Graphics.FromImage(canvas)
            '円をbrushColorで指定された色で描く
            g.FillEllipse(brushColor, x, y, radius * 2, radius * 2)
            '文字列を描画する
            g.DrawString(kanji, New Font(fontName, radius),
            Brushes.Black, x + 4, y + 12, New StringFormat())

            'mainPictureBox.Imageに表示する
            pictureBox.Image = canvas

        End Using

    End Sub

    '指定した位置のボールを消す（白で描く）
    Public Sub DeleteCircle()
        '初めて呼ばれて移動前の値がないとき
        If (previousX = 0) Then
            previousX = positionX
        End If

        If (previousY = 0) Then
            previousY = positionY
        End If

        Using g As Graphics = Graphics.FromImage(canvas)
            '円を白で描く
            g.FillEllipse(Brushes.White, previousX, previousY, radius * 2, radius * 2)
            'mainPictureBoxに表示する
            pictureBox.Image = canvas
        End Using

    End Sub

    '指定した位置にボールを動かす
    Public Sub Move()
        '移動前の表示を削除
        DeleteCircle()

        '新しい移動先の計算
        Dim x As Integer = positionX + pitch * directionX
        Dim y As Integer = positionY + pitch * directionY

        '壁で跳ね返る補正

        '右端に来た場合の判定
        If (x >= pictureBox.Width - radius * 2) Then
            directionX = -1
        End If

        '左端に来た場合の判定
        If (x <= 0) Then
            directionX = +1
        End If

        '下端に来た場合の判定
        If (y >= pictureBox.Height - radius * 2) Then
            directionY = -1
        End If

        '上端に来た場合の判定
        If (y <= 0) Then
            directionY = +1
        End If

        '跳ね返り補正を反映した値で新しい位置を計算
        positionX = x + directionX
        positionY = y + directionY

        '新しい位置に描画
        PutCircle(positionX, positionY)

        '新しい位置を移動前の値として記憶
        previousX = positionX
        previousY = positionY

    End Sub

End Class
