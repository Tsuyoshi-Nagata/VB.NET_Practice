Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim valueLeft As Integer '入力値１用の整数型変数
        Dim valueRight As Integer '入力値２用の整数型変数
        Dim valueAnswer As Integer '計算結果用の整数型変数


        '値の取り込み
        If Integer.TryParse(Input1TextBox.Text, valueLeft) = True Then
            valueLeft = Integer.Parse(Input1TextBox.Text) '入力値１を整数型に変換後代入
        Else
            valueLeft = 0 '0を代入
        End If

        If Integer.TryParse(Input2TextBox.Text, valueRight) = True Then
            valueRight = Integer.Parse(Input2TextBox.Text) '入力値２を整数型に変換後代入
        Else
            valueRight = 0 '0を代入
        End If

        '取り込んだ値の計算
        valueAnswer = valueLeft + valueRight

        '計算結果を出力
        AnswerTextBox.Text = valueAnswer.ToString()


    End Sub
End Class