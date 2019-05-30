Public Class OnlyUserRecord
    Public name As String = ""
    Private Sub OnlyUserRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChartRefresh()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ChartRefresh()

    End Sub
    Public Sub ChartRefresh()

        connect2()

        cnn.Open()

        lblname.Text = UserInfo.cmb.SelectedValue.ToString



        Dim dt2 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select orderno as [Order NO],itemname as [Item Name],quantity as [Quantity],totalprice as [Total Price],orderdate as [Order Date] from productdata where username ='" & UserInfo.cmb.SelectedValue.ToString & "'"
        da.SelectCommand = cmd

        da.Fill(dt2)
        gridviewUserName.DataSource = dt2

        With cmd 'create coonection command
            .Connection = cnn
            .CommandText = "select totalprice,orderdate from productdata where username='" & lblname.Text & "'"
        End With
        Dim dt3 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception
        End Try
        Try

            Dim cnt As Integer = dt2.Rows.Count
            Dim cnl As Integer = 0
            Dim tot As Integer = 0
            While (cnl < cnt)

                tot += CInt(dt2.Rows(cnl).Item("totalprice"))
                cnl += 1
            End While
            lblTotal.Text = "Rs." & tot
        Catch ex As Exception
            lblTotal.Text = "Rs. 00"
        End Try
        gridviewUserName.BestFitColumns(True)
        Chart1.DataSource = dt3
        Dim pal(13) As String

        pal(0) = DataVisualization.Charting.ChartColorPalette.Bright
        pal(1) = DataVisualization.Charting.ChartColorPalette.Berry
        pal(2) = DataVisualization.Charting.ChartColorPalette.Chocolate
        pal(3) = DataVisualization.Charting.ChartColorPalette.EarthTones
        pal(4) = DataVisualization.Charting.ChartColorPalette.Excel
        pal(5) = DataVisualization.Charting.ChartColorPalette.SeaGreen
        pal(6) = DataVisualization.Charting.ChartColorPalette.Fire
        pal(7) = DataVisualization.Charting.ChartColorPalette.BrightPastel
        pal(8) = DataVisualization.Charting.ChartColorPalette.Grayscale
        pal(9) = DataVisualization.Charting.ChartColorPalette.Light
        pal(10) = DataVisualization.Charting.ChartColorPalette.Pastel

        Dim r As System.Random = New System.Random()

        Dim a As Integer
        a = r.Next(0, 12)
        Chart1.Palette = pal(a)

        Chart1.Series("User Record").YValueMembers = "totalprice"
        Chart1.Series("User Record").XValueMember = "orderdate"
        cnn.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
        UserInfo.Show()

        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        PrintOnlyUserRecord.Show()

    End Sub
End Class