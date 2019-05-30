Public Class FloatingWebBrowseOpener
    Private Sub FloatingWebBrowseOpener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 94
    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        GmailBrowser.LoadWebBrowser("http://www.gmail.com/")
        GmailBrowser.Show()
        Hide()

    End Sub

    Private Sub PictureEdit2_Click(sender As Object, e As EventArgs) Handles PictureEdit2.Click
        GmailBrowser.LoadWebBrowser("http://www.facebook.com/")
        GmailBrowser.Show()
        Hide()
    End Sub

    Private Sub PictureEdit3_Click(sender As Object, e As EventArgs) Handles PictureEdit3.Click
        GmailBrowser.LoadWebBrowser("http://www.twitter.com/")
        GmailBrowser.Show()
        Hide()
    End Sub

    Private Sub PictureEdit4_Click(sender As Object, e As EventArgs) Handles PictureEdit4.Click
        GmailBrowser.LoadWebBrowser("http://www.instagram.com/?hl=en")
        GmailBrowser.Show()
        Hide()
    End Sub

    Private Sub PictureEdit5_Click(sender As Object, e As EventArgs) Handles PictureEdit5.Click
        GmailBrowser.LoadWebBrowser("http://in.linkedin.com/")
        GmailBrowser.Show()
        Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
    End Sub
End Class