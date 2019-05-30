Public Class DashboardAdmin
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Application.Restart()


    End Sub

    Private Sub tileDailyRecors_Click(sender As Object, e As EventArgs) Handles tileDailyRecors.Click
        Hide()
        DailyRecords.Show()

    End Sub

    Private Sub tileMonthlyRecors_Click(sender As Object, e As EventArgs) Handles tileMonthlyRecors.Click
        MonthlyData.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddsuplier_Click(sender As Object, e As EventArgs) Handles btnAddsuplier.Click
        Me.Hide()
        AddSupplier.Show()

    End Sub

    Private Sub tileCreateUser_Click(sender As Object, e As EventArgs) Handles tileCreateUser.Click
        CreateUserForm.Show()
        Me.Hide()
    End Sub

    Private Sub tileUserRecors_Click(sender As Object, e As EventArgs) Handles tileUserRecors.Click
        UserInfo.Show()

        Me.Hide()
    End Sub

    Private Sub btnSupplierDailyRecord_Click(sender As Object, e As EventArgs) Handles btnSupplierDailyRecord.Click
        SupplierDailyRecord.Show()
        Hide()

    End Sub

    Private Sub btnProductDetail_Click(sender As Object, e As EventArgs) Handles btnProductDetail.Click
        Me.Hide()
        productDetail.Show()
        productDetail.ReloadProduct()

    End Sub

    Private Sub btnSuppliedAllProduct_Click(sender As Object, e As EventArgs) Handles btnSuppliedAllProduct.Click
        SuppliedRecord.Show()
        Hide()

    End Sub

    Private Sub btnSupplierInfo_Click(sender As Object, e As EventArgs) Handles btnSupplierInfo.Click
        Hide()
        SupplierInfo.Show()
        SupplierInfo.reload()
    End Sub

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel1.Text = "PATIL MAMA " & Environment.NewLine & "VADAPAV WALE"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnChagePaytm_Click(sender As Object, e As EventArgs) Handles btnChagePaytm.Click
        NewPayTMBarcode.Show()

    End Sub
End Class