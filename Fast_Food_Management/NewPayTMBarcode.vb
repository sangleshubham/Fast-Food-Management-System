Public Class NewPayTMBarcode
    Dim isfileselected As Boolean = False
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextEdit1.Text = OpenFileDialog1.FileName
            isfileselected = True
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If isfileselected = True Then
            Dim file As New IO.FileInfo(OpenFileDialog1.FileName) 'total info is stored of file is stored in the fileinfo object
            file.CopyTo(Application.StartupPath & "\paytm", True) 'file will copy to the destination path with file name False means overwriting is off
            Hide()

        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Hide()
    End Sub
End Class