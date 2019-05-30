Public Class PayTMPay
    Private Sub PayTMPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim impath As String = Application.StartupPath & "\paytm"
        picPatmBarcode.Image = System.Drawing.Image.FromFile(impath)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Hide()
        MainForm.Show()

    End Sub
End Class