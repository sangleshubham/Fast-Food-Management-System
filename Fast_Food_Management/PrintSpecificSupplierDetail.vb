Public Class PrintSpecificSupplierDetail
    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        ProductSuppliesBySpecificSupplier.gridviewUserName.PrintPreview()

    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        ProductSuppliesBySpecificSupplier.Chart1.Printing.PageSetup()
        ProductSuppliesBySpecificSupplier.Chart1.Printing.PrintPreview()
        ProductSuppliesBySpecificSupplier.Chart1.Printing.Print(True)
    End Sub

    Private Sub PrintSpecificSupplierDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True

    End Sub
End Class