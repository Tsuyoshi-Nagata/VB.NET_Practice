Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        '変数の宣言
        Dim valueLeft As Integer '入力値１用の整数型変数
        Dim valueRight As Integer '入力値２用の整数型変数
        Dim valueAnswer As Integer '計算結果用の整数型変数


        '値の取り込み
        valueLeft = InputCheckFunc(Input1TextBox.Text, valueLeft) '入力値１を整数型に変換後代入
        valueRight = InputCheckFunc(Input2TextBox.Text, valueRight) '入力値２を整数型に変換後代入
        '取り込んだ値の計算
        valueAnswer = valueLeft + valueRight

        '計算結果を出力
        AnswerTextBox.Text = valueAnswer.ToString()


    End Sub

    '入力値をチェックするファンクション
    Private Function InputCheckFunc(textValue As String, checkValue As Integer) As Integer
        If Integer.TryParse(textValue, checkValue) = True Then
            checkValue = Integer.Parse(textValue)
        Else
            checkValue = 0
        End If

        Return checkValue
    End Function



End Class