Public Class getSupplierImages
    Private Sub btnGetImageByCamera_Click(sender As Object, e As EventArgs) Handles btnGetImageByCamera.Click
        AddSupplier.Show()

        AddSupplier.getframesonpicturebox()
        AddSupplier.btnCapture.Visible = True
        AddSupplier.chkbxDetectFace.Visible = True
        AddSupplier.chkbxDetectFace.Checked = False
        Hide()
    End Sub

    Private Sub btnGetFromDirectory_Click(sender As Object, e As EventArgs) Handles btnGetFromDirectory.Click
        Try
            AddSupplier.camera.Stop()
        Catch ex As Exception

        End Try

        AddSupplier.SupplierImage.Image = Nothing

        If AddSupplier.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AddSupplier.btnCapture.Visible = False
            AddSupplier.chkbxDetectFace.Visible = False

            AddSupplier.isimageisgetfromcamera = False
            Dim str As String

            str = AddSupplier.OpenFileDialog1.FileName
            AddSupplier.SupplierImage.Image = System.Drawing.Image.FromFile(str)
        End If
        Me.Hide()
        AddSupplier.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()

    End Sub
End Class