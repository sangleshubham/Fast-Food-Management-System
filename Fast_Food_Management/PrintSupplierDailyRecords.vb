Public Class PrintSupplierDailyRecords
    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        Me.TopMost = False
        SupplierDailyRecord.grdviewDailyRecord.PrintPreview()
        Me.TopMost = True
    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        Me.TopMost = False
        SupplierDailyRecord.Chart1.Printing.PageSetup()
        SupplierDailyRecord.Chart1.Printing.PrintPreview()
        SupplierDailyRecord.Chart1.Printing.Print(True)
        Me.TopMost = True
    End Sub

    Private Sub PrintSupplierDailyRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class