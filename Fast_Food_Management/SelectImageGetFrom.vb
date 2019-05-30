Public Class SelectImageGetFrom
    Dim str As String = ""
    Private Sub btnGetImageByCamera_Click(sender As Object, e As EventArgs) Handles btnGetImageByCamera.Click
        CreateUserForm.Show()

        CreateUserForm.getframesonpicturebox()
        CreateUserForm.btnCapture.Visible = True
        CreateUserForm.chkbxDetectFace.Visible = True
        CreateUserForm.chkbxDetectFace.Checked = False
        Hide()
        'CreateUserForm.Timer1.Start()
    End Sub

    Private Sub btnGetFromDirectory_Click(sender As Object, e As EventArgs) Handles btnGetFromDirectory.Click
        Try
            CreateUserForm.camera.Stop()
        Catch ex As Exception

        End Try

        CreateUserForm.UserImage.Image = Nothing

        If CreateUserForm.selectuserimage.ShowDialog = DialogResult.OK Then
            CreateUserForm.btnCapture.Visible = False
            CreateUserForm.chkbxDetectFace.Visible = False

            CreateUserForm.isimageisgetfromcamera = False

            CreateUserForm.str = CreateUserForm.selectuserimage.FileName
            str = CreateUserForm.selectuserimage.FileName
            CreateUserForm.UserImage.Image = System.Drawing.Image.FromFile(str)
        End If
        Me.Hide()
        CreateUserForm.Show()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()

    End Sub
End Class