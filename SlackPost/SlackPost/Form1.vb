Public Class FormSlackPost
    Private Sub butPost_Click(sender As Object, e As EventArgs) Handles butPost.Click
        Dim strWebHookurl As String = "https://hooks.slack.com/services/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"

        Dim strData As String = String.Format("{{'text':'{0}'}},txtPost", txtPost.Text)

        Dim client As System.Net.WebClient = New System.Net.WebClient()
        client.Headers.Add(System.Net.HttpRequestHeader.ContentType,
                           "application/json;charset=UTF-8")
        client.Encoding = System.Text.Encoding.UTF8

        Dim reply As String = client.UploadString(strWebHookurl, strData)

        MessageBox.Show(reply)

    End Sub
End Class
