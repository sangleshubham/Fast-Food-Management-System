Public Class PrintOnlyUserRecord
    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        Hide()

    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click
        TopMost = False
        OnlyUserRecord.gridviewUserName.PrintPreview()
        TopMost = True
    End Sub

    Private Sub WindowsUIButtonPanel2_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel2.Click
        TopMost = False
        OnlyUserRecord.Chart1.Printing.PageSetup()
        OnlyUserRecord.Chart1.Printing.PrintPreview()
        OnlyUserRecord.Chart1.Printing.Print(True)
        TopMost = True
    End Sub

    Private Sub PrintOnlyUserRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True

    End Sub
End Class