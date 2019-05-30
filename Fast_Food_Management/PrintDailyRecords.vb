Public Class PrintDailyRecords
    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        TopMost = False

        DailyRecords.grdviewDailyRecord.PrintPreview()
        TopMost = True
    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        TopMost = False
        DailyRecords.Chart1.Printing.PageSetup()
        DailyRecords.Chart1.Printing.PrintPreview()
        DailyRecords.Chart1.Printing.Print(True)
        TopMost = False
    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub PrintDailyRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub
End Class