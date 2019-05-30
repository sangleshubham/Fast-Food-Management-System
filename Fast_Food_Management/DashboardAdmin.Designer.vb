<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdmin))
        Me.btnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.btnAddsuplier = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadSeparator3 = New Telerik.WinControls.UI.RadSeparator()
        Me.RadSeparator2 = New Telerik.WinControls.UI.RadSeparator()
        Me.tileUserRecors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnProductDetail = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileCreateUser = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileDailyRecors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSuppliedAllProduct = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tileMonthlyRecors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSupplierDailyRecord = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSupplierInfo = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnChagePaytm = New Bunifu.Framework.UI.BunifuTileButton()
        Me.RadSeparator1 = New Telerik.WinControls.UI.RadSeparator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnLogout.Location = New System.Drawing.Point(824, 42)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Normalcolor = System.Drawing.Color.Black
        Me.btnLogout.OnHovercolor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogout.selected = False
        Me.btnLogout.Size = New System.Drawing.Size(154, 41)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Textcolor = System.Drawing.Color.White
        Me.btnLogout.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(323, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 145)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'imgBox
        '
        Me.imgBox.Image = CType(resources.GetObject("imgBox.Image"), System.Drawing.Image)
        Me.imgBox.Location = New System.Drawing.Point(221, 191)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(846, 406)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBox.TabIndex = 13
        Me.imgBox.TabStop = False
        '
        'btnAddsuplier
        '
        Me.btnAddsuplier.BackColor = System.Drawing.Color.Black
        Me.btnAddsuplier.color = System.Drawing.Color.Black
        Me.btnAddsuplier.colorActive = System.Drawing.Color.Black
        Me.btnAddsuplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddsuplier.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnAddsuplier.ForeColor = System.Drawing.Color.White
        Me.btnAddsuplier.Image = CType(resources.GetObject("btnAddsuplier.Image"), System.Drawing.Image)
        Me.btnAddsuplier.ImagePosition = 20
        Me.btnAddsuplier.ImageZoom = 50
        Me.btnAddsuplier.LabelPosition = 41
        Me.btnAddsuplier.LabelText = "Add Supplier"
        Me.btnAddsuplier.Location = New System.Drawing.Point(1, 72)
        Me.btnAddsuplier.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAddsuplier.Name = "btnAddsuplier"
        Me.btnAddsuplier.Size = New System.Drawing.Size(212, 37)
        Me.btnAddsuplier.TabIndex = 8
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(329, 100)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(231, 19)
        Me.BunifuCustomLabel1.TabIndex = 9
        Me.BunifuCustomLabel1.Text = "PATIL MAMA VADAPAV WALE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RadSeparator1)
        Me.Panel1.Controls.Add(Me.btnChagePaytm)
        Me.Panel1.Controls.Add(Me.RadSeparator3)
        Me.Panel1.Controls.Add(Me.RadSeparator2)
        Me.Panel1.Controls.Add(Me.btnAddsuplier)
        Me.Panel1.Controls.Add(Me.tileUserRecors)
        Me.Panel1.Controls.Add(Me.btnProductDetail)
        Me.Panel1.Controls.Add(Me.tileCreateUser)
        Me.Panel1.Controls.Add(Me.tileDailyRecors)
        Me.Panel1.Controls.Add(Me.btnSuppliedAllProduct)
        Me.Panel1.Controls.Add(Me.tileMonthlyRecors)
        Me.Panel1.Controls.Add(Me.btnSupplierDailyRecord)
        Me.Panel1.Controls.Add(Me.btnSupplierInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 584)
        Me.Panel1.TabIndex = 10
        '
        'RadSeparator3
        '
        Me.RadSeparator3.Location = New System.Drawing.Point(1, 343)
        Me.RadSeparator3.Name = "RadSeparator3"
        Me.RadSeparator3.Size = New System.Drawing.Size(213, 10)
        Me.RadSeparator3.TabIndex = 10
        Me.RadSeparator3.Text = "RadSeparator3"
        '
        'RadSeparator2
        '
        Me.RadSeparator2.Location = New System.Drawing.Point(1, 118)
        Me.RadSeparator2.Name = "RadSeparator2"
        Me.RadSeparator2.Size = New System.Drawing.Size(213, 10)
        Me.RadSeparator2.TabIndex = 9
        Me.RadSeparator2.Text = "RadSeparator2"
        '
        'tileUserRecors
        '
        Me.tileUserRecors.BackColor = System.Drawing.Color.Black
        Me.tileUserRecors.color = System.Drawing.Color.Black
        Me.tileUserRecors.colorActive = System.Drawing.Color.Black
        Me.tileUserRecors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileUserRecors.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.tileUserRecors.ForeColor = System.Drawing.Color.White
        Me.tileUserRecors.Image = CType(resources.GetObject("tileUserRecors.Image"), System.Drawing.Image)
        Me.tileUserRecors.ImagePosition = 20
        Me.tileUserRecors.ImageZoom = 50
        Me.tileUserRecors.LabelPosition = 41
        Me.tileUserRecors.LabelText = "User Records"
        Me.tileUserRecors.Location = New System.Drawing.Point(1, 474)
        Me.tileUserRecors.Margin = New System.Windows.Forms.Padding(6)
        Me.tileUserRecors.Name = "tileUserRecors"
        Me.tileUserRecors.Size = New System.Drawing.Size(213, 37)
        Me.tileUserRecors.TabIndex = 0
        '
        'btnProductDetail
        '
        Me.btnProductDetail.BackColor = System.Drawing.Color.Black
        Me.btnProductDetail.color = System.Drawing.Color.Black
        Me.btnProductDetail.colorActive = System.Drawing.Color.Black
        Me.btnProductDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductDetail.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnProductDetail.ForeColor = System.Drawing.Color.White
        Me.btnProductDetail.Image = CType(resources.GetObject("btnProductDetail.Image"), System.Drawing.Image)
        Me.btnProductDetail.ImagePosition = 20
        Me.btnProductDetail.ImageZoom = 50
        Me.btnProductDetail.LabelPosition = 41
        Me.btnProductDetail.LabelText = "Product Detail"
        Me.btnProductDetail.Location = New System.Drawing.Point(0, 376)
        Me.btnProductDetail.Margin = New System.Windows.Forms.Padding(6)
        Me.btnProductDetail.Name = "btnProductDetail"
        Me.btnProductDetail.Size = New System.Drawing.Size(212, 38)
        Me.btnProductDetail.TabIndex = 7
        '
        'tileCreateUser
        '
        Me.tileCreateUser.BackColor = System.Drawing.Color.Black
        Me.tileCreateUser.color = System.Drawing.Color.Black
        Me.tileCreateUser.colorActive = System.Drawing.Color.Black
        Me.tileCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileCreateUser.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.tileCreateUser.ForeColor = System.Drawing.Color.White
        Me.tileCreateUser.Image = CType(resources.GetObject("tileCreateUser.Image"), System.Drawing.Image)
        Me.tileCreateUser.ImagePosition = 20
        Me.tileCreateUser.ImageZoom = 50
        Me.tileCreateUser.LabelPosition = 41
        Me.tileCreateUser.LabelText = "Create User"
        Me.tileCreateUser.Location = New System.Drawing.Point(0, 17)
        Me.tileCreateUser.Margin = New System.Windows.Forms.Padding(6)
        Me.tileCreateUser.Name = "tileCreateUser"
        Me.tileCreateUser.Size = New System.Drawing.Size(212, 43)
        Me.tileCreateUser.TabIndex = 1
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
        Me.tileDailyRecors.Location = New System.Drawing.Point(0, 147)
        Me.tileDailyRecors.Margin = New System.Windows.Forms.Padding(6)
        Me.tileDailyRecors.Name = "tileDailyRecors"
        Me.tileDailyRecors.Size = New System.Drawing.Size(213, 37)
        Me.tileDailyRecors.TabIndex = 0
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
        Me.btnSuppliedAllProduct.Location = New System.Drawing.Point(0, 294)
        Me.btnSuppliedAllProduct.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSuppliedAllProduct.Name = "btnSuppliedAllProduct"
        Me.btnSuppliedAllProduct.Size = New System.Drawing.Size(211, 38)
        Me.btnSuppliedAllProduct.TabIndex = 0
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
        Me.tileMonthlyRecors.Location = New System.Drawing.Point(2, 196)
        Me.tileMonthlyRecors.Margin = New System.Windows.Forms.Padding(6)
        Me.tileMonthlyRecors.Name = "tileMonthlyRecors"
        Me.tileMonthlyRecors.Size = New System.Drawing.Size(212, 37)
        Me.tileMonthlyRecors.TabIndex = 0
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
        Me.btnSupplierDailyRecord.Location = New System.Drawing.Point(0, 245)
        Me.btnSupplierDailyRecord.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSupplierDailyRecord.Name = "btnSupplierDailyRecord"
        Me.btnSupplierDailyRecord.Size = New System.Drawing.Size(213, 37)
        Me.btnSupplierDailyRecord.TabIndex = 0
        '
        'btnSupplierInfo
        '
        Me.btnSupplierInfo.BackColor = System.Drawing.Color.Black
        Me.btnSupplierInfo.color = System.Drawing.Color.Black
        Me.btnSupplierInfo.colorActive = System.Drawing.Color.Black
        Me.btnSupplierInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplierInfo.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnSupplierInfo.ForeColor = System.Drawing.Color.White
        Me.btnSupplierInfo.Image = CType(resources.GetObject("btnSupplierInfo.Image"), System.Drawing.Image)
        Me.btnSupplierInfo.ImagePosition = 20
        Me.btnSupplierInfo.ImageZoom = 50
        Me.btnSupplierInfo.LabelPosition = 41
        Me.btnSupplierInfo.LabelText = "Supplier Details"
        Me.btnSupplierInfo.Location = New System.Drawing.Point(-1, 425)
        Me.btnSupplierInfo.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSupplierInfo.Name = "btnSupplierInfo"
        Me.btnSupplierInfo.Size = New System.Drawing.Size(214, 37)
        Me.btnSupplierInfo.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1079, 25)
        Me.Panel2.TabIndex = 11
        '
        'btnChagePaytm
        '
        Me.btnChagePaytm.BackColor = System.Drawing.Color.Black
        Me.btnChagePaytm.color = System.Drawing.Color.Black
        Me.btnChagePaytm.colorActive = System.Drawing.Color.Black
        Me.btnChagePaytm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChagePaytm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChagePaytm.ForeColor = System.Drawing.Color.White
        Me.btnChagePaytm.Image = CType(resources.GetObject("btnChagePaytm.Image"), System.Drawing.Image)
        Me.btnChagePaytm.ImagePosition = 18
        Me.btnChagePaytm.ImageZoom = 50
        Me.btnChagePaytm.LabelPosition = 36
        Me.btnChagePaytm.LabelText = "Change PayTm Barcode"
        Me.btnChagePaytm.Location = New System.Drawing.Point(0, 547)
        Me.btnChagePaytm.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnChagePaytm.Name = "btnChagePaytm"
        Me.btnChagePaytm.Size = New System.Drawing.Size(208, 32)
        Me.btnChagePaytm.TabIndex = 11
        '
        'RadSeparator1
        '
        Me.RadSeparator1.Location = New System.Drawing.Point(3, 520)
        Me.RadSeparator1.Name = "RadSeparator1"
        Me.RadSeparator1.Size = New System.Drawing.Size(213, 10)
        Me.RadSeparator1.TabIndex = 11
        Me.RadSeparator1.Text = "RadSeparator1"
        '
        'DashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1079, 609)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgBox As PictureBox
    Friend WithEvents btnAddsuplier As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tileCreateUser As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tileDailyRecors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSuppliedAllProduct As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tileMonthlyRecors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSupplierDailyRecord As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadSeparator2 As Telerik.WinControls.UI.RadSeparator
    Friend WithEvents RadSeparator3 As Telerik.WinControls.UI.RadSeparator
    Friend WithEvents tileUserRecors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnProductDetail As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSupplierInfo As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnChagePaytm As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents RadSeparator1 As Telerik.WinControls.UI.RadSeparator
End Class
