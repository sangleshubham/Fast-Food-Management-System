<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlyUserRecord
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OnlyUserRecord))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.gridviewUserName = New Telerik.WinControls.UI.RadGridView()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewUserName.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Black
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(464, 170)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "User Record"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(638, 408)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'gridviewUserName
        '
        Me.gridviewUserName.Location = New System.Drawing.Point(12, 31)
        '
        '
        '
        Me.gridviewUserName.MasterTemplate.AllowAddNewRow = False
        Me.gridviewUserName.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gridviewUserName.Name = "gridviewUserName"
        Me.gridviewUserName.ReadOnly = True
        Me.gridviewUserName.Size = New System.Drawing.Size(442, 566)
        Me.gridviewUserName.TabIndex = 7
        Me.gridviewUserName.Text = "grdviewDailyRecord"
        '
        'btnRefresh
        '
        Me.btnRefresh.Activecolor = System.Drawing.Color.Black
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.BorderRadius = 0
        Me.btnRefresh.ButtonText = "Refresh"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.btnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRefresh.Iconimage = CType(resources.GetObject("btnRefresh.Iconimage"), System.Drawing.Image)
        Me.btnRefresh.Iconimage_right = Nothing
        Me.btnRefresh.Iconimage_right_Selected = Nothing
        Me.btnRefresh.Iconimage_Selected = Nothing
        Me.btnRefresh.IconMarginLeft = 0
        Me.btnRefresh.IconMarginRight = 0
        Me.btnRefresh.IconRightVisible = True
        Me.btnRefresh.IconRightZoom = 0R
        Me.btnRefresh.IconVisible = True
        Me.btnRefresh.IconZoom = 90.0R
        Me.btnRefresh.IsTab = False
        Me.btnRefresh.Location = New System.Drawing.Point(894, 46)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Normalcolor = System.Drawing.Color.Black
        Me.btnRefresh.OnHovercolor = System.Drawing.Color.Black
        Me.btnRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRefresh.selected = False
        Me.btnRefresh.Size = New System.Drawing.Size(208, 40)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Textcolor = System.Drawing.Color.White
        Me.btnRefresh.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnClose
        '
        Me.btnClose.Activecolor = System.Drawing.Color.Black
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.BorderRadius = 0
        Me.btnClose.ButtonText = "Close"
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledColor = System.Drawing.Color.Gray
        Me.btnClose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClose.Iconimage = CType(resources.GetObject("btnClose.Iconimage"), System.Drawing.Image)
        Me.btnClose.Iconimage_right = Nothing
        Me.btnClose.Iconimage_right_Selected = Nothing
        Me.btnClose.Iconimage_Selected = Nothing
        Me.btnClose.IconMarginLeft = 0
        Me.btnClose.IconMarginRight = 0
        Me.btnClose.IconRightVisible = True
        Me.btnClose.IconRightZoom = 0R
        Me.btnClose.IconVisible = True
        Me.btnClose.IconZoom = 90.0R
        Me.btnClose.IsTab = False
        Me.btnClose.Location = New System.Drawing.Point(894, 92)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.Black
        Me.btnClose.OnHovercolor = System.Drawing.Color.Black
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(208, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.lblname.Location = New System.Drawing.Point(466, 143)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(116, 24)
        Me.lblname.TabIndex = 11
        Me.lblname.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(460, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 58)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User Sale Record"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1173, 25)
        Me.Panel2.TabIndex = 57
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(1108, 323)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(53, 64)
        Me.WindowsUIButtonPanel3.TabIndex = 58
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(890, 135)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 20)
        Me.lblTotal.TabIndex = 59
        Me.lblTotal.Text = "Total"
        '
        'OnlyUserRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1173, 621)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gridviewUserName)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "OnlyUserRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Only User Record"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewUserName.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewUserName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents gridviewUserName As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents lblTotal As Label
End Class
