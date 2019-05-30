<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productDetail
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productDetail))
        Me.grdviewProducts = New Telerik.WinControls.UI.RadGridView()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDeleteProduct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.drpdwnProductName = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtprice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.txtPriceUpdate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.grdviewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdviewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpdwnProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdviewProducts
        '
        Me.grdviewProducts.Location = New System.Drawing.Point(294, 284)
        '
        '
        '
        Me.grdviewProducts.MasterTemplate.AllowAddNewRow = False
        Me.grdviewProducts.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.grdviewProducts.Name = "grdviewProducts"
        Me.grdviewProducts.ReadOnly = True
        Me.grdviewProducts.Size = New System.Drawing.Size(382, 303)
        Me.grdviewProducts.TabIndex = 1
        Me.grdviewProducts.Text = "grdviewDailyRecord"
        Me.grdviewProducts.ThemeName = "Office2010Black"
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
        Me.btnClose.Location = New System.Drawing.Point(0, 148)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.Black
        Me.btnClose.OnHovercolor = System.Drawing.Color.Black
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(218, 48)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Activecolor = System.Drawing.Color.Black
        Me.btnDeleteProduct.BackColor = System.Drawing.Color.Black
        Me.btnDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteProduct.BorderRadius = 0
        Me.btnDeleteProduct.ButtonText = "Delete Product"
        Me.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteProduct.DisabledColor = System.Drawing.Color.Gray
        Me.btnDeleteProduct.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDeleteProduct.Iconimage = CType(resources.GetObject("btnDeleteProduct.Iconimage"), System.Drawing.Image)
        Me.btnDeleteProduct.Iconimage_right = Nothing
        Me.btnDeleteProduct.Iconimage_right_Selected = Nothing
        Me.btnDeleteProduct.Iconimage_Selected = Nothing
        Me.btnDeleteProduct.IconMarginLeft = 0
        Me.btnDeleteProduct.IconMarginRight = 0
        Me.btnDeleteProduct.IconRightVisible = True
        Me.btnDeleteProduct.IconRightZoom = 0R
        Me.btnDeleteProduct.IconVisible = True
        Me.btnDeleteProduct.IconZoom = 90.0R
        Me.btnDeleteProduct.IsTab = False
        Me.btnDeleteProduct.Location = New System.Drawing.Point(0, 92)
        Me.btnDeleteProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Normalcolor = System.Drawing.Color.Black
        Me.btnDeleteProduct.OnHovercolor = System.Drawing.Color.Black
        Me.btnDeleteProduct.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDeleteProduct.selected = False
        Me.btnDeleteProduct.Size = New System.Drawing.Size(218, 48)
        Me.btnDeleteProduct.TabIndex = 10
        Me.btnDeleteProduct.Text = "Delete Product"
        Me.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteProduct.Textcolor = System.Drawing.Color.White
        Me.btnDeleteProduct.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(285, 185)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(115, 22)
        Me.RadLabel1.TabIndex = 12
        Me.RadLabel1.Text = "Select Product"
        '
        'drpdwnProductName
        '
        Me.drpdwnProductName.Location = New System.Drawing.Point(406, 185)
        Me.drpdwnProductName.Name = "drpdwnProductName"
        Me.drpdwnProductName.Size = New System.Drawing.Size(270, 20)
        Me.drpdwnProductName.TabIndex = 13
        Me.drpdwnProductName.Text = "Product Name"
        Me.drpdwnProductName.ThemeName = "Office2010Black"
        '
        'txtprice
        '
        Me.txtprice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtprice.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtprice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtprice.BorderThickness = 1
        Me.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprice.Enabled = False
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprice.isPassword = False
        Me.txtprice.Location = New System.Drawing.Point(415, 110)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(110, 30)
        Me.txtprice.TabIndex = 19
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtprice.Visible = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(290, 120)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(103, 20)
        Me.lblname.TabIndex = 20
        Me.lblname.Text = "Product Price"
        Me.lblname.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(219, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 25)
        Me.Panel2.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnDeleteProduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 599)
        Me.Panel1.TabIndex = 57
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.Black
        Me.btnUpdate.BackColor = System.Drawing.Color.Black
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.BorderRadius = 0
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdate.Iconimage = CType(resources.GetObject("btnUpdate.Iconimage"), System.Drawing.Image)
        Me.btnUpdate.Iconimage_right = Nothing
        Me.btnUpdate.Iconimage_right_Selected = Nothing
        Me.btnUpdate.Iconimage_Selected = Nothing
        Me.btnUpdate.IconMarginLeft = 0
        Me.btnUpdate.IconMarginRight = 0
        Me.btnUpdate.IconRightVisible = True
        Me.btnUpdate.IconRightZoom = 0R
        Me.btnUpdate.IconVisible = True
        Me.btnUpdate.IconZoom = 90.0R
        Me.btnUpdate.IsTab = False
        Me.btnUpdate.Location = New System.Drawing.Point(0, 204)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.Black
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(218, 48)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Textcolor = System.Drawing.Color.White
        Me.btnUpdate.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(373, 58)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Product Details"
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(691, 31)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(57, 66)
        Me.WindowsUIButtonPanel3.TabIndex = 59
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        '
        'txtPriceUpdate
        '
        Me.txtPriceUpdate.BorderColorFocused = System.Drawing.Color.Red
        Me.txtPriceUpdate.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtPriceUpdate.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPriceUpdate.BorderThickness = 1
        Me.txtPriceUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPriceUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPriceUpdate.isPassword = False
        Me.txtPriceUpdate.Location = New System.Drawing.Point(406, 228)
        Me.txtPriceUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriceUpdate.Name = "txtPriceUpdate"
        Me.txtPriceUpdate.Size = New System.Drawing.Size(110, 30)
        Me.txtPriceUpdate.TabIndex = 19
        Me.txtPriceUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(294, 230)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(103, 22)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Update Price"
        '
        'productDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 599)
        Me.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPriceUpdate)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.drpdwnProductName)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.grdviewProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "productDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "productDetail"
        CType(Me.grdviewProducts.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdviewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpdwnProductName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdviewProducts As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDeleteProduct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpdwnProductName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtprice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblname As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents txtPriceUpdate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
End Class
