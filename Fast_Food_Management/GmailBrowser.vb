Public Class GmailBrowser
    Private Sub btnStop_Click(sender As Object, e As EventArgs)
        wbUse.Stop()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs)
        wbUse.Navigate(txtUrl.Text)
    End Sub


    Public Sub LoadWebBrowser(url As String)
        wbUse.Navigate(url)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        wbUse.Refresh()

    End Sub

    Private Sub GmailBrowser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FloatingWebBrowseOpener.Show()

    End Sub
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click

        If Login.isadmin = True Then
            DashboardAdmin.Show()
            Hide()
            FloatingWebBrowseOpener.Show()

        Else
            Me.Hide()
            Dashboard.Show()
            FloatingWebBrowseOpener.Show()

        End If
    End Sub

    Private Sub wbUse_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbUse.DocumentCompleted
        txtUrl.Text = e.Url.ToString
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        wbUse.GoBack()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        wbUse.GoForward()

    End Sub
End Class