Public Class PrintSupplierRecord
    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        SuppliedRecord.gridviewSupplierTotalRecord.PrintPreview()

    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        SuppliedRecord.Chart1.Printing.PageSetup()
        SuppliedRecord.Chart1.Printing.PrintPreview()
        SuppliedRecord.Chart1.Printing.Print(True)

    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub
End Class