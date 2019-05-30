Public Class PrintMonthlyRecords
    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        MonthlyData.grdviewDailyRecord.PrintPreview()

    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        MonthlyData.Chart1.Printing.PageSetup()
        MonthlyData.Chart1.Printing.PrintPreview()
        MonthlyData.Chart1.Printing.Print(True)
    End Sub
End Class