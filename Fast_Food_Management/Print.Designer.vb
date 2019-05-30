<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim RadPrintWatermark1 As Telerik.WinControls.UI.RadPrintWatermark = New Telerik.WinControls.UI.RadPrintWatermark()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.gridviewUserName = New Telerik.WinControls.UI.RadGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RadPrintDocument1 = New Telerik.WinControls.UI.RadPrintDocument()
        CType(Me.gridviewUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewUserName.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Print Preview"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'gridviewUserName
        '
        Me.gridviewUserName.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        Me.gridviewUserName.MasterTemplate.AllowAddNewRow = False
        Me.gridviewUserName.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gridviewUserName.Name = "gridviewUserName"
        Me.gridviewUserName.ReadOnly = True
        Me.gridviewUserName.Size = New System.Drawing.Size(425, 343)
        Me.gridviewUserName.TabIndex = 12
        Me.gridviewUserName.Text = "grdviewDailyRecord"
        '
        'Chart1
        '
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(443, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "User Record"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(638, 408)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Chart1"
        '
        'RadPrintDocument1
        '
        Me.RadPrintDocument1.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPrintDocument1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPrintDocument1.Watermark = RadPrintWatermark1
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 561)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.gridviewUserName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Print"
        Me.Text = "Print"
        CType(Me.gridviewUserName.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents gridviewUserName As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents RadPrintDocument1 As Telerik.WinControls.UI.RadPrintDocument
End Class
