Public Class FormGmailCheck
    Private count As Integer = -1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim client As New OpenPop.Pop3.Pop3Client()

        client.Connect("pop.gmail.com", 995, True)
        client.Authenticate(txtAddress.Text, txtPassword.Text)

        Dim messageCount As Integer = client.GetMessageCount()
        If (count = -1) Then
            count = messageCount
        End If

        For i As Integer = messageCount To count + 1 Step -1
            txtNewMail.Text += client.GetMessage(i).Headers.Subject + vbCrLf
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "メールが届きました"
            NotifyIcon1.BalloonTipText = client.GetMessage(i).Headers.Subject
            NotifyIcon1.ShowBalloonTip(3000)

        Next i

        count = messageCount

    End Sub

    Private Sub butStart_Click(sender As Object, e As EventArgs) Handles butStart.Click
        Timer1.Enabled = True
    End Sub


End Class
