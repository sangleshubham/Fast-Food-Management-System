Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Public Class MonthlyData
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
            datepkrDailyRecord.Visible = True
            Label2.Visible = True
            Label1.Visible = True
            btnclose.Visible = True
            btnrefresh.Visible = True
            WindowsUIButtonPanel3.Visible = True
            lblTotal.Visible = True
            lblTotal.Visible = True
        End If
    End Sub

    Private Sub MonthlyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmrLoad.Start()

        pbarcircle.Visible = True

        grdviewDailyRecord.BestFitColumns(True)


        Try
            datepkrDailyRecord.Value = My.Computer.Clock.LocalTime
        Catch ex As Exception

        End Try


        connect2()
        cnn.Open()
        Dim mon As String = datepkrDailyRecord.Value.Month
        Dim year As String = datepkrDailyRecord.Value.Year
        Dim cldate As String = mon & "-" & year
        'code for showing graph....

        With cmd 'create coonection command
            .Connection = cnn
            '.CommandText = "SELECT * from productdata where orderdate=#08-Jan-18 11:20:40 PM#"

            .CommandText = "SELECT totalprice,orderdate from productdata  where mondate='" & cldate.ToString & "'"
        End With

        Dim dt4 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt4)
        Catch ex As Exception

        End Try
        Try

            Dim cnt As Integer = dt4.Rows.Count
            Dim cnl As Integer = 0
            Dim tot As Integer = 0
            While (cnl < cnt)

                tot += CInt(dt4.Rows(cnl).Item("totalprice"))
                cnl += 1
            End While
            lblTotal.Text = "Rs. " & tot
        Catch ex As Exception
            lblTotal.Text = "Rs. 00"
        End Try

        Chart1.DataSource = dt4

        Chart1.Series("Daily Record").YValueMembers = "totalprice"
        Chart1.Series("Daily Record").XValueMember = "orderdate"


        'code for showing Grid View....
        With cmd 'create coonection command
            .Connection = cnn

            .CommandText = "Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" & cldate & "'"
        End With
        Dim dt3 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception

        End Try
        grdviewDailyRecord.DataSource = dt3
        cnn.Close()

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



    End Sub

    Private Sub datepkrDailyRecord_onValueChanged(sender As Object, e As EventArgs) Handles datepkrDailyRecord.onValueChanged


        connect2()
        cnn.Open()
        Dim mon As String = datepkrDailyRecord.Value.Month
        Dim year As String = datepkrDailyRecord.Value.Year
        Dim cldate As String = mon & "-" & year
        'code for showing graph....

        With cmd 'create coonection command
            .Connection = cnn
            '.CommandText = "SELECT * from productdata where orderdate=#08-Jan-18 11:20:40 PM#"

            .CommandText = "SELECT totalprice,orderdate from productdata  where mondate='" & cldate.ToString & "'"
        End With
        Dim dt4 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt4)
        Catch ex As Exception

        End Try


        Chart1.DataSource = dt4

        Chart1.Series("Daily Record").YValueMembers = "totalprice"
        Chart1.Series("Daily Record").XValueMember = "orderdate"

        'code for showing Grid View....
        With cmd 'create coonection command
            .Connection = cnn
            '.CommandText = "Select * from productdata where orderdate=#08-Jan-18 11:20:40 PM#"
            .CommandText = "Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" & cldate & "'"
        End With
        Dim dt3 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception

        End Try
        grdviewDailyRecord.DataSource = dt3
        cnn.Close()

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

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click


        connect2()
        cnn.Open()
        Dim mon As String = datepkrDailyRecord.Value.Month
        Dim year As String = datepkrDailyRecord.Value.Year
        Dim cldate As String = mon & "-" & year
        'code for showing graph....

        With cmd 'create coonection command
            .Connection = cnn
            '.CommandText = "SELECT * from productdata where orderdate=#08-Jan-18 11:20:40 PM#"

            .CommandText = "SELECT totalprice,orderdate from productdata  where mondate='" & cldate.ToString & "'"
        End With
        Dim dt2 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
        Catch ex As Exception

        End Try


        Chart1.DataSource = dt2

        Chart1.Series("Daily Record").YValueMembers = "totalprice"
        Chart1.Series("Daily Record").XValueMember = "orderdate"

        'code for showing Grid View....
        With cmd 'create coonection command    
            .Connection = cnn

            .CommandText = "Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" & cldate & "'"
        End With
        Dim dt3 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception

        End Try
        grdviewDailyRecord.DataSource = dt3
        cnn.Close()

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

    Private Sub grdviewDailyRecord_Click(sender As Object, e As EventArgs) Handles grdviewDailyRecord.Click

    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        PrintMonthlyRecords.Show()

    End Sub
End Class