<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSupplierDailyRecord = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileMonthlyRecors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSuppliedAllProduct = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileDailyRecors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileOrder = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSupplyProduct = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadSeparator2 = New Telerik.WinControls.UI.RadSeparator()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(213, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 25)
        Me.Panel2.TabIndex = 5
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(343, 113)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(231, 19)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "PATIL MAMA VADAPAV WALE"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'imgBox
        '
        Me.imgBox.Image = CType(resources.GetObject("imgBox.Image"), System.Drawing.Image)
        Me.imgBox.Location = New System.Drawing.Point(223, 176)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(846, 431)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBox.TabIndex = 7
        Me.imgBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(326, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 145)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Activecolor = System.Drawing.Color.Black
        Me.btnLogout.BackColor = System.Drawing.Color.Black
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.BorderRadius = 0
        Me.btnLogout.ButtonText = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledColor = System.Drawing.Color.Black
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogout.Iconimage = CType(resources.GetObject("btnLogout.Iconimage"), System.Drawing.Image)
        Me.btnLogout.Iconimage_right = Nothing
        Me.btnLogout.Iconimage_right_Selected = Nothing
        Me.btnLogout.Iconimage_Selected = Nothing
        Me.btnLogout.IconMarginLeft = 0
        Me.btnLogout.IconMarginRight = 0
        Me.btnLogout.IconRightVisible = True
        Me.btnLogout.IconRightZoom = 0R
        Me.btnLogout.IconVisible = True
        Me.btnLogout.IconZoom = 90.0R
        Me.btnLogout.IsTab = False
        Me.btnLogout.Location = New System.Drawing.Point(915, 113)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Normalcolor = System.Drawing.Color.Black
        Me.btnLogout.OnHovercolor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogout.selected = False
        Me.btnLogout.Size = New System.Drawing.Size(154, 41)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Textcolor = System.Drawing.Color.White
        Me.btnLogout.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSupplierDailyRecord
        '
        Me.btnSupplierDailyRecord.BackColor = System.Drawing.Color.Black
        Me.btnSupplierDailyRecord.color = System.Drawing.Color.Black
        Me.btnSupplierDailyRecord.colorActive = System.Drawing.Color.Black
        Me.btnSupplierDailyRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplierDailyRecord.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnSupplierDailyRecord.ForeColor = System.Drawing.Color.White
        Me.btnSupplierDailyRecord.Image = CType(resources.GetObject("btnSupplierDailyRecord.Image"), System.Drawing.Image)
        Me.btnSupplierDailyRecord.ImagePosition = 20
        Me.btnSupplierDailyRecord.ImageZoom = 50
        Me.btnSupplierDailyRecord.LabelPosition = 41
        Me.btnSupplierDailyRecord.LabelText = "Supplier Daily Details"
        Me.btnSupplierDailyRecord.Location = New System.Drawing.Point(0, 423)
        Me.btnSupplierDailyRecord.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSupplierDailyRecord.Name = "btnSupplierDailyRecord"
        Me.btnSupplierDailyRecord.Size = New System.Drawing.Size(213, 37)
        Me.btnSupplierDailyRecord.TabIndex = 0
        '
        'tileMonthlyRecors
        '
        Me.tileMonthlyRecors.BackColor = System.Drawing.Color.Black
        Me.tileMonthlyRecors.color = System.Drawing.Color.Black
        Me.tileMonthlyRecors.colorActive = System.Drawing.Color.Black
        Me.tileMonthlyRecors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileMonthlyRecors.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.tileMonthlyRecors.ForeColor = System.Drawing.Color.White
        Me.tileMonthlyRecors.Image = CType(resources.GetObject("tileMonthlyRecors.Image"), System.Drawing.Image)
        Me.tileMonthlyRecors.ImagePosition = 20
        Me.tileMonthlyRecors.ImageZoom = 50
        Me.tileMonthlyRecors.LabelPosition = 41
        Me.tileMonthlyRecors.LabelText = "Monthly Record"
        Me.tileMonthlyRecors.Location = New System.Drawing.Point(2, 374)
        Me.tileMonthlyRecors.Margin = New System.Windows.Forms.Padding(6)
        Me.tileMonthlyRecors.Name = "tileMonthlyRecors"
        Me.tileMonthlyRecors.Size = New System.Drawing.Size(212, 37)
        Me.tileMonthlyRecors.TabIndex = 0
        '
        'btnSuppliedAllProduct
        '
        Me.btnSuppliedAllProduct.BackColor = System.Drawing.Color.Black
        Me.btnSuppliedAllProduct.color = System.Drawing.Color.Black
        Me.btnSuppliedAllProduct.colorActive = System.Drawing.Color.Black
        Me.btnSuppliedAllProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuppliedAllProduct.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnSuppliedAllProduct.ForeColor = System.Drawing.Color.White
        Me.btnSuppliedAllProduct.Image = CType(resources.GetObject("btnSuppliedAllProduct.Image"), System.Drawing.Image)
        Me.btnSuppliedAllProduct.ImagePosition = 20
        Me.btnSuppliedAllProduct.ImageZoom = 50
        Me.btnSuppliedAllProduct.LabelPosition = 41
        Me.btnSuppliedAllProduct.LabelText = "All Supplied"
        Me.btnSuppliedAllProduct.Location = New System.Drawing.Point(2, 472)
        Me.btnSuppliedAllProduct.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSuppliedAllProduct.Name = "btnSuppliedAllProduct"
        Me.btnSuppliedAllProduct.Size = New System.Drawing.Size(212, 38)
        Me.btnSuppliedAllProduct.TabIndex = 0
        '
        'tileDailyRecors
        '
        Me.tileDailyRecors.BackColor = System.Drawing.Color.Black
        Me.tileDailyRecors.color = System.Drawing.Color.Black
        Me.tileDailyRecors.colorActive = System.Drawing.Color.Black
        Me.tileDailyRecors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileDailyRecors.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.tileDailyRecors.ForeColor = System.Drawing.Color.White
        Me.tileDailyRecors.Image = CType(resources.GetObject("tileDailyRecors.Image"), System.Drawing.Image)
        Me.tileDailyRecors.ImagePosition = 20
        Me.tileDailyRecors.ImageZoom = 50
        Me.tileDailyRecors.LabelPosition = 41
        Me.tileDailyRecors.LabelText = "Daily Records"
        Me.tileDailyRecors.Location = New System.Drawing.Point(0, 325)
        Me.tileDailyRecors.Margin = New System.Windows.Forms.Padding(6)
        Me.tileDailyRecors.Name = "tileDailyRecors"
        Me.tileDailyRecors.Size = New System.Drawing.Size(213, 37)
        Me.tileDailyRecors.TabIndex = 0
        '
        'tileOrder
        '
        Me.tileOrder.BackColor = System.Drawing.Color.Black
        Me.tileOrder.color = System.Drawing.Color.Black
        Me.tileOrder.colorActive = System.Drawing.Color.Black
        Me.tileOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileOrder.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.tileOrder.ForeColor = System.Drawing.Color.White
        Me.tileOrder.Image = CType(resources.GetObject("tileOrder.Image"), System.Drawing.Image)
        Me.tileOrder.ImagePosition = 20
        Me.tileOrder.ImageZoom = 50
        Me.tileOrder.LabelPosition = 41
        Me.tileOrder.LabelText = "Order"
        Me.tileOrder.Location = New System.Drawing.Point(0, 64)
        Me.tileOrder.Margin = New System.Windows.Forms.Padding(6)
        Me.tileOrder.Name = "tileOrder"
        Me.tileOrder.Size = New System.Drawing.Size(211, 37)
        Me.tileOrder.TabIndex = 1
        '
        'btnSupplyProduct
        '
        Me.btnSupplyProduct.BackColor = System.Drawing.Color.Black
        Me.btnSupplyProduct.color = System.Drawing.Color.Black
        Me.btnSupplyProduct.colorActive = System.Drawing.Color.Black
        Me.btnSupplyProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplyProduct.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnSupplyProduct.ForeColor = System.Drawing.Color.White
        Me.btnSupplyProduct.Image = CType(resources.GetObject("btnSupplyProduct.Image"), System.Drawing.Image)
        Me.btnSupplyProduct.ImagePosition = 20
        Me.btnSupplyProduct.ImageZoom = 50
        Me.btnSupplyProduct.LabelPosition = 41
        Me.btnSupplyProduct.LabelText = "Supply"
        Me.btnSupplyProduct.Location = New System.Drawing.Point(-6, 113)
        Me.btnSupplyProduct.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSupplyProduct.Name = "btnSupplyProduct"
        Me.btnSupplyProduct.Size = New System.Drawing.Size(220, 37)
        Me.btnSupplyProduct.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BunifuTileButton1)
        Me.Panel1.Controls.Add(Me.btnSupplyProduct)
        Me.Panel1.Controls.Add(Me.RadSeparator2)
        Me.Panel1.Controls.Add(Me.tileOrder)
        Me.Panel1.Controls.Add(Me.tileDailyRecors)
        Me.Panel1.Controls.Add(Me.btnSuppliedAllProduct)
        Me.Panel1.Controls.Add(Me.tileMonthlyRecors)
        Me.Panel1.Controls.Add(Me.btnSupplierDailyRecord)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 616)
        Me.Panel1.TabIndex = 4
        '
        'RadSeparator2
        '
        Me.RadSeparator2.Location = New System.Drawing.Point(0, 244)
        Me.RadSeparator2.Name = "RadSeparator2"
        Me.RadSeparator2.Size = New System.Drawing.Size(217, 10)
        Me.RadSeparator2.TabIndex = 9
        Me.RadSeparator2.Text = "RadSeparator2"
        Me.RadSeparator2.ThemeName = "Office2010Black"
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.Black
        Me.BunifuTileButton1.color = System.Drawing.Color.Black
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.Black
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "Send SMS"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(0, 167)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(211, 37)
        Me.BunifuTileButton1.TabIndex = 10
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 616)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.imgBox)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents imgBox As PictureBox
    Friend WithEvents btnSupplierDailyRecord As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tileMonthlyRecors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSuppliedAllProduct As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tileDailyRecors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tileOrder As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSupplyProduct As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadSeparator2 As Telerik.WinControls.UI.RadSeparator
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
End Class
