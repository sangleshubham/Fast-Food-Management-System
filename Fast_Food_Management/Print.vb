Public Class Print
    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect2()

        cnn.Open()
        With cmd 'create coonection command
            .Connection = cnn
            .CommandText = "select orderno,name,quantity,totalprice from dailyrecord"
        End With
        Dim dt3 As New DataTable
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception
        End Try
        Chart1.DataSource = dt3
        gridviewUserName.DataSource = dt3
        Chart1.Series("User Record").YValueMembers = "totalprice"
        Chart1.Series("User Record").XValueMember = "orderno"
        cnn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Chart1.Printing.PageSetup()
        'PrintDocument1 = Chart1.Printing.PrintDocument

        'Chart1.Printing.PrintDocument.Print()
        ' Chart1.Printing.PrintPreview()
        With gridviewUserName.PrintStyle
            .PrintHeaderOnEachPage = True
            .BorderColor = Color.IndianRed
            '.CellBackColor = Color.DarkGreen
            Dim reportFont As Font = New Drawing.Font("Times New Roman", 14)
            .CellFont = reportFont
        End With
        gridviewUserName.PrintPreview()
        ' gridviewUserName.PrintPreview()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Chart1.Printing.PageSetup()
        '  PrintPreviewDialog1.Document = Chart1.Printing.PrintDocument
        '  PrintDialog1.Document = PrintPreviewDialog1.Document


        ' PrintPreviewDialog1.ShowDialog()
        'printing Grid View columns
        'Chart1.Printing.PageSetup()
        'Chart1.Printing.PrintPreview()

        'PrintPreviewDialog1.Document = Chart1.Printing.PrintDocument
        'PrintPreviewDialog1.Show()
        gridviewUserName.PrintPreview()
        '  gridviewUserName.Print(True)
        Chart1.Printing.PageSetup()
        Chart1.Printing.PrintPreview()
        Chart1.Printing.Print(True)

    End Sub

End Class