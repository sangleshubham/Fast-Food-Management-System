Public Class Dashboard
    Private Sub tileOrder_Click(sender As Object, e As EventArgs) Handles tileOrder.Click
        MainForm.Show()
        Me.Hide()
        'MainForm.reloadthemainfor()

    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel1.Text = "PATIL MAMA " & Environment.NewLine & "VADAPAV WALE"
        Dim a As System.Random = New System.Random()

        Dim i As Integer = a.Next(0, 3)

        'imgBox.Image = ImageList1.Images.Item(i)

    End Sub


    Private Sub btnSupplyProduct_Click(sender As Object, e As EventArgs) Handles btnSupplyProduct.Click
        BuySupply.Show()
        Hide()

    End Sub

    Private Sub tileDailyRecors_Click(sender As Object, e As EventArgs) Handles tileDailyRecors.Click
        DailyRecords.Show()
        Hide()
    End Sub

    Private Sub tileMonthlyRecors_Click(sender As Object, e As EventArgs) Handles tileMonthlyRecors.Click
        MonthlyData.Show()
        Hide()

    End Sub

    Private Sub btnSupplierDailyRecord_Click(sender As Object, e As EventArgs) Handles btnSupplierDailyRecord.Click
        SupplierDailyRecord.Show()
        Hide()

    End Sub

    Private Sub btnSuppliedAllProduct_Click(sender As Object, e As EventArgs) Handles btnSuppliedAllProduct.Click
        SuppliedRecord.Show()
        Hide()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Application.Restart()

    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Send_sms_to_customer.Show()
        Hide()

    End Sub
End Class