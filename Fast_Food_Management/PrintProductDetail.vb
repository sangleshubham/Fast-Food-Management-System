Public Class PrintProductDetail
    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        Me.TopMost = False
        productDetail.grdviewProducts.PrintPreview()
        Me.TopMost = True

    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub PrintProductDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub
End Class