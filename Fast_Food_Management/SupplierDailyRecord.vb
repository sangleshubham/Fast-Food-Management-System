Public Class SupplierDailyRecord
    Private Sub SupplierDailyRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            datepkrDailySupplyRecord.Value = My.Computer.Clock.LocalTime
        Catch ex As Exception

        End Try


        fillGridAndDrawChart()

    End Sub
    Private Sub fillGridAndDrawChart()
        connect2()
        cnn.Open()

        'code for showing graph....

        With cmd 'create coonection command
            .Connection = cnn
            .CommandText = "SELECT time,totalprice from itemsupplied  where daydate=#" & datepkrDailySupplyRecord.Value.ToShortDateString & "#"
        End With
        Dim dt2 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
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
            lblTotal.Text = "Rs. " & tot
        Catch ex As Exception
            lblTotal.Text = "Rs. 00"
        End Try

        Chart1.DataSource = dt2

        Chart1.Series("Supply").YValueMembers = "totalprice"
        Chart1.Series("Supply").XValueMember = "time"


        'code for showing Grid View....

        With cmd 'create coonection command
            .Connection = cnn
            .CommandText = "SELECT orderno as [Order No],pname As [Product Name],suppliername As [Supplier Name],quantity As [Quantity],priceper As [Per Unit Price],totalprice As [Total Price],dateofsupply As [Supply Date] from itemsupplied  where daydate=#" & datepkrDailySupplyRecord.Value.ToShortDateString & "#"
        End With

        Dim dt3 As New DataTable

        da.SelectCommand = cmd

        Try
            da.Fill(dt3)
        Catch ex As Exception
            MessageBox.Show("No data to show")
        End Try
        grdviewDailyRecord.DataSource = dt3
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

        cnn.Close()

        grdviewDailyRecord.BestFitColumns(True)
    End Sub

    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        If pbarcircle.Value < 100 Then
            pbarcircle.Value = pbarcircle.Value + 1
            If lblProgress.Text = "Loading Records" Then
                lblProgress.Text = "Loading Records."

            ElseIf lblProgress.Text = "Loading Records." Then
                lblProgress.Text = "Loading Records.."

            ElseIf lblProgress.Text = "Loading Records.." Then
                lblProgress.Text = "Loading Records..."

            ElseIf lblProgress.Text = "Loading Records..." Then
                lblProgress.Text = "Loading Records...."

            ElseIf lblProgress.Text = "Loading Records...." Then
                lblProgress.Text = "Loading Records"


            End If

        Else
            pbarcircle.Hide()
            lblProgress.Hide()
            Chart1.Visible = True
            grdviewDailyRecord.Visible = True
            datepkrDailySupplyRecord.Visible = True
            Label2.Visible = True
            Label1.Visible = True
            btnclose.Visible = True
            btnrefresh.Visible = True
            WindowsUIButtonPanel3.Visible = True
            lblTotal.Visible = True
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If Login.isadmin = True Then
            DashboardAdmin.Show()
            Hide()
        Else
            Me.Hide()
            Dashboard.Show()
        End If
        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        fillGridAndDrawChart()

    End Sub

    Private Sub datepkrDailySupplyRecord_onValueChanged(sender As Object, e As EventArgs) Handles datepkrDailySupplyRecord.onValueChanged
        fillGridAndDrawChart()

    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        PrintSupplierDailyRecords.Show()

    End Sub
End Class