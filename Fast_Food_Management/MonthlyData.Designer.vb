<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthlyData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyData))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.btnrefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datepkrDailyRecord = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.grdviewDailyRecord = New Telerik.WinControls.UI.RadGridView()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblProgress = New MaterialSkin.Controls.MaterialLabel()
        Me.pbarcircle = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewDailyRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewDailyRecord.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnrefresh
        '
        Me.btnrefresh.Activecolor = System.Drawing.Color.Black
        Me.btnrefresh.BackColor = System.Drawing.Color.Black
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.BorderRadius = 0
        Me.btnrefresh.ButtonText = "Refresh"
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.DisabledColor = System.Drawing.Color.Gray
        Me.btnrefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnrefresh.Iconimage = CType(resources.GetObject("btnrefresh.Iconimage"), System.Drawing.Image)
        Me.btnrefresh.Iconimage_right = Nothing
        Me.btnrefresh.Iconimage_right_Selected = Nothing
        Me.btnrefresh.Iconimage_Selected = Nothing
        Me.btnrefresh.IconMarginLeft = 0
        Me.btnrefresh.IconMarginRight = 0
        Me.btnrefresh.IconRightVisible = True
        Me.btnrefresh.IconRightZoom = 0R
        Me.btnrefresh.IconVisible = True
        Me.btnrefresh.IconZoom = 90.0R
        Me.btnrefresh.IsTab = False
        Me.btnrefresh.Location = New System.Drawing.Point(934, 132)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Normalcolor = System.Drawing.Color.Black
        Me.btnrefresh.OnHovercolor = System.Drawing.Color.Black
        Me.btnrefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnrefresh.selected = False
        Me.btnrefresh.Size = New System.Drawing.Size(135, 46)
        Me.btnrefresh.TabIndex = 19
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Textcolor = System.Drawing.Color.White
        Me.btnrefresh.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnrefresh.Visible = False
        '
        'btnclose
        '
        Me.btnclose.Activecolor = System.Drawing.Color.Black
        Me.btnclose.BackColor = System.Drawing.Color.Black
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.BorderRadius = 0
        Me.btnclose.ButtonText = "Close"
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DisabledColor = System.Drawing.Color.Gray
        Me.btnclose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnclose.Iconimage = CType(resources.GetObject("btnclose.Iconimage"), System.Drawing.Image)
        Me.btnclose.Iconimage_right = Nothing
        Me.btnclose.Iconimage_right_Selected = Nothing
        Me.btnclose.Iconimage_Selected = Nothing
        Me.btnclose.IconMarginLeft = 0
        Me.btnclose.IconMarginRight = 0
        Me.btnclose.IconRightVisible = True
        Me.btnclose.IconRightZoom = 0R
        Me.btnclose.IconVisible = True
        Me.btnclose.IconZoom = 90.0R
        Me.btnclose.IsTab = False
        Me.btnclose.Location = New System.Drawing.Point(934, 193)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Normalcolor = System.Drawing.Color.Black
        Me.btnclose.OnHovercolor = System.Drawing.Color.Black
        Me.btnclose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnclose.selected = False
        Me.btnclose.Size = New System.Drawing.Size(135, 40)
        Me.btnclose.TabIndex = 20
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Textcolor = System.Drawing.Color.White
        Me.btnclose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnclose.Visible = False
        '
        'Chart1
        '
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(415, 239)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Daily Record"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(654, 385)
        Me.Chart1.TabIndex = 18
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Select Month"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!)
        Me.Label1.Location = New System.Drawing.Point(443, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 58)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Monthly Records"
        Me.Label1.Visible = False
        '
        'datepkrDailyRecord
        '
        Me.datepkrDailyRecord.BackColor = System.Drawing.Color.Black
        Me.datepkrDailyRecord.BorderRadius = 0
        Me.datepkrDailyRecord.ForeColor = System.Drawing.Color.White
        Me.datepkrDailyRecord.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepkrDailyRecord.FormatCustom = "dd-MMM-yy"
        Me.datepkrDailyRecord.Location = New System.Drawing.Point(591, 151)
        Me.datepkrDailyRecord.Name = "datepkrDailyRecord"
        Me.datepkrDailyRecord.Size = New System.Drawing.Size(246, 36)
        Me.datepkrDailyRecord.TabIndex = 15
        Me.datepkrDailyRecord.Value = New Date(2018, 1, 14, 11, 37, 24, 933)
        Me.datepkrDailyRecord.Visible = False
        '
        'grdviewDailyRecord
        '
        Me.grdviewDailyRecord.Location = New System.Drawing.Point(12, 46)
        '
        '
        '
        Me.grdviewDailyRecord.MasterTemplate.AllowAddNewRow = False
        Me.grdviewDailyRecord.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdviewDailyRecord.Name = "grdviewDailyRecord"
        Me.grdviewDailyRecord.ReadOnly = True
        Me.grdviewDailyRecord.Size = New System.Drawing.Size(397, 578)
        Me.grdviewDailyRecord.TabIndex = 14
        Me.grdviewDailyRecord.Text = "grdviewDailyRecord"
        Me.grdviewDailyRecord.Visible = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1095, 25)
        Me.Panel2.TabIndex = 23
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Depth = 0
        Me.lblProgress.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProgress.Location = New System.Drawing.Point(504, 251)
        Me.lblProgress.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(121, 19)
        Me.lblProgress.TabIndex = 21
        Me.lblProgress.Text = "Loading Records"
        '
        'pbarcircle
        '
        Me.pbarcircle.animated = False
        Me.pbarcircle.animationIterval = 5
        Me.pbarcircle.animationSpeed = 300
        Me.pbarcircle.BackColor = System.Drawing.Color.White
        Me.pbarcircle.BackgroundImage = CType(resources.GetObject("pbarcircle.BackgroundImage"), System.Drawing.Image)
        Me.pbarcircle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.pbarcircle.ForeColor = System.Drawing.Color.Black
        Me.pbarcircle.LabelVisible = True
        Me.pbarcircle.LineProgressThickness = 8
        Me.pbarcircle.LineThickness = 5
        Me.pbarcircle.Location = New System.Drawing.Point(454, 279)
        Me.pbarcircle.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pbarcircle.MaxValue = 100
        Me.pbarcircle.Name = "pbarcircle"
        Me.pbarcircle.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.pbarcircle.ProgressColor = System.Drawing.Color.SeaGreen
        Me.pbarcircle.Size = New System.Drawing.Size(201, 201)
        Me.pbarcircle.TabIndex = 22
        Me.pbarcircle.Value = 0
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(1022, 397)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(47, 64)
        Me.WindowsUIButtonPanel3.TabIndex = 24
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel3.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(878, 46)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 20)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'MonthlyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 639)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datepkrDailyRecord)
        Me.Controls.Add(Me.grdviewDailyRecord)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.pbarcircle)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonthlyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Data"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewDailyRecord.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewDailyRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnrefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents datepkrDailyRecord As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents grdviewDailyRecord As Telerik.WinControls.UI.RadGridView
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProgress As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pbarcircle As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents lblTotal As Label
End Class
