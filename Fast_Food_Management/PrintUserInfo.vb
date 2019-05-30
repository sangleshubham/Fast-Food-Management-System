Public Class PrintUserInfo
    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()
    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        TopMost = False

        UserInfo.grdUserInfo.PrintPreview()
        TopMost = True
    End Sub

    Private Sub PrintUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub
End Class