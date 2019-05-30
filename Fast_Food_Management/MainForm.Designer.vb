<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.datepkrOrderDate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtperunitprice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtquantity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.drpdwnProductList = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtOrderNo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.btnclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddProduct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnorder = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmess = New System.Windows.Forms.Label()
        Me.tmrerr = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadCalculatorDropDown1 = New Telerik.WinControls.UI.RadCalculatorDropDown()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdPaytm = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdCash = New Telerik.WinControls.UI.RadRadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCalculatorDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rdPaytm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datepkrOrderDate
        '
        Me.datepkrOrderDate.BackColor = System.Drawing.Color.Black
        Me.datepkrOrderDate.BorderRadius = 0
        Me.datepkrOrderDate.ForeColor = System.Drawing.Color.White
        Me.datepkrOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datepkrOrderDate.FormatCustom = Nothing
        Me.datepkrOrderDate.Location = New System.Drawing.Point(556, 453)
        Me.datepkrOrderDate.Name = "datepkrOrderDate"
        Me.datepkrOrderDate.Size = New System.Drawing.Size(306, 53)
        Me.datepkrOrderDate.TabIndex = 3
        Me.datepkrOrderDate.Value = New Date(2018, 1, 3, 15, 59, 45, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(516, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Rs."
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtTotalPrice.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtTotalPrice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtTotalPrice.BorderThickness = 1
        Me.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalPrice.isPassword = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(556, 416)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(219, 30)
        Me.txtTotalPrice.TabIndex = 3
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtperunitprice
        '
        Me.txtperunitprice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtperunitprice.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtperunitprice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtperunitprice.BorderThickness = 1
        Me.txtperunitprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtperunitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperunitprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtperunitprice.isPassword = False
        Me.txtperunitprice.Location = New System.Drawing.Point(556, 340)
        Me.txtperunitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtperunitprice.Name = "txtperunitprice"
        Me.txtperunitprice.Size = New System.Drawing.Size(186, 30)
        Me.txtperunitprice.TabIndex = 4
        Me.txtperunitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtquantity
        '
        Me.txtquantity.BorderColorFocused = System.Drawing.Color.Red
        Me.txtquantity.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtquantity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtquantity.BorderThickness = 1
        Me.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtquantity.isPassword = False
        Me.txtquantity.Location = New System.Drawing.Point(556, 378)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(186, 30)
        Me.txtquantity.TabIndex = 2
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'drpdwnProductList
        '
        Me.drpdwnProductList.BackColor = System.Drawing.Color.Transparent
        Me.drpdwnProductList.BorderRadius = 1
        Me.drpdwnProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpdwnProductList.ForeColor = System.Drawing.Color.White
        Me.drpdwnProductList.Items = New String() {"Vadapav", "Pani-Pauch", "Bottel"}
        Me.drpdwnProductList.Location = New System.Drawing.Point(556, 295)
        Me.drpdwnProductList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.drpdwnProductList.Name = "drpdwnProductList"
        Me.drpdwnProductList.NomalColor = System.Drawing.Color.Black
        Me.drpdwnProductList.onHoverColor = System.Drawing.Color.Black
        Me.drpdwnProductList.selectedIndex = -1
        Me.drpdwnProductList.Size = New System.Drawing.Size(271, 37)
        Me.drpdwnProductList.TabIndex = 1
        '
        'txtOrderNo
        '
        Me.txtOrderNo.BorderColorFocused = System.Drawing.Color.Red
        Me.txtOrderNo.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtOrderNo.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtOrderNo.BorderThickness = 1
        Me.txtOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOrderNo.isPassword = False
        Me.txtOrderNo.Location = New System.Drawing.Point(556, 257)
        Me.txtOrderNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(420, 30)
        Me.txtOrderNo.TabIndex = 0
        Me.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(316, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 21)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "PER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(315, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "ORDER DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(315, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(315, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "TOTAL PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(315, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "PRODUCT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "ORDER NO"
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.Black
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.Location = New System.Drawing.Point(204, 31)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(251, 196)
        Me.picUser.TabIndex = 49
        Me.picUser.TabStop = False
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
        Me.btnclose.Location = New System.Drawing.Point(-3, 292)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Normalcolor = System.Drawing.Color.Black
        Me.btnclose.OnHovercolor = System.Drawing.Color.Black
        Me.btnclose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnclose.selected = False
        Me.btnclose.Size = New System.Drawing.Size(200, 54)
        Me.btnclose.TabIndex = 48
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Textcolor = System.Drawing.Color.White
        Me.btnclose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Activecolor = System.Drawing.Color.Black
        Me.btnAddProduct.BackColor = System.Drawing.Color.Black
        Me.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddProduct.BorderRadius = 0
        Me.btnAddProduct.ButtonText = "Add Product"
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddProduct.Iconimage = CType(resources.GetObject("btnAddProduct.Iconimage"), System.Drawing.Image)
        Me.btnAddProduct.Iconimage_right = Nothing
        Me.btnAddProduct.Iconimage_right_Selected = Nothing
        Me.btnAddProduct.Iconimage_Selected = Nothing
        Me.btnAddProduct.IconMarginLeft = 0
        Me.btnAddProduct.IconMarginRight = 0
        Me.btnAddProduct.IconRightVisible = True
        Me.btnAddProduct.IconRightZoom = 0R
        Me.btnAddProduct.IconVisible = True
        Me.btnAddProduct.IconZoom = 90.0R
        Me.btnAddProduct.IsTab = False
        Me.btnAddProduct.Location = New System.Drawing.Point(0, 233)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Normalcolor = System.Drawing.Color.Black
        Me.btnAddProduct.OnHovercolor = System.Drawing.Color.Black
        Me.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddProduct.selected = False
        Me.btnAddProduct.Size = New System.Drawing.Size(197, 54)
        Me.btnAddProduct.TabIndex = 48
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProduct.Textcolor = System.Drawing.Color.White
        Me.btnAddProduct.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnorder
        '
        Me.btnorder.Activecolor = System.Drawing.Color.Black
        Me.btnorder.BackColor = System.Drawing.Color.Black
        Me.btnorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnorder.BorderRadius = 0
        Me.btnorder.ButtonText = "Make Order"
        Me.btnorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnorder.DisabledColor = System.Drawing.Color.Gray
        Me.btnorder.Iconcolor = System.Drawing.Color.Transparent
        Me.btnorder.Iconimage = CType(resources.GetObject("btnorder.Iconimage"), System.Drawing.Image)
        Me.btnorder.Iconimage_right = Nothing
        Me.btnorder.Iconimage_right_Selected = Nothing
        Me.btnorder.Iconimage_Selected = Nothing
        Me.btnorder.IconMarginLeft = 0
        Me.btnorder.IconMarginRight = 0
        Me.btnorder.IconRightVisible = True
        Me.btnorder.IconRightZoom = 0R
        Me.btnorder.IconVisible = True
        Me.btnorder.IconZoom = 90.0R
        Me.btnorder.IsTab = False
        Me.btnorder.Location = New System.Drawing.Point(556, 556)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Normalcolor = System.Drawing.Color.Black
        Me.btnorder.OnHovercolor = System.Drawing.Color.Black
        Me.btnorder.OnHoverTextColor = System.Drawing.Color.White
        Me.btnorder.selected = False
        Me.btnorder.Size = New System.Drawing.Size(172, 41)
        Me.btnorder.TabIndex = 4
        Me.btnorder.Text = "Make Order"
        Me.btnorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnorder.Textcolor = System.Drawing.Color.White
        Me.btnorder.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(516, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Rs."
        '
        'lblmess
        '
        Me.lblmess.AutoSize = True
        Me.lblmess.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblmess.ForeColor = System.Drawing.Color.Red
        Me.lblmess.Location = New System.Drawing.Point(749, 380)
        Me.lblmess.Name = "lblmess"
        Me.lblmess.Size = New System.Drawing.Size(113, 21)
        Me.lblmess.TabIndex = 52
        Me.lblmess.Text = "ErrorMessage"
        '
        'tmrerr
        '
        Me.tmrerr.Interval = 2000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(482, 202)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(67, 25)
        Me.lblUserName.TabIndex = 53
        Me.lblUserName.Text = "Label4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 36.0!)
        Me.Label9.Location = New System.Drawing.Point(529, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 58)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Order"
        '
        'RadCalculatorDropDown1
        '
        Me.RadCalculatorDropDown1.Location = New System.Drawing.Point(891, 91)
        Me.RadCalculatorDropDown1.Name = "RadCalculatorDropDown1"
        Me.RadCalculatorDropDown1.Size = New System.Drawing.Size(178, 24)
        Me.RadCalculatorDropDown1.TabIndex = 54
        Me.RadCalculatorDropDown1.TabStop = False
        Me.RadCalculatorDropDown1.Text = "RadCalculatorDropDown1"
        Me.RadCalculatorDropDown1.ThemeName = "TelerikMetro"
        Me.RadCalculatorDropDown1.Value = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 25)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnAddProduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 608)
        Me.Panel1.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(829, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdPaytm)
        Me.GroupBox1.Controls.Add(Me.rdCash)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 512)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 38)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'rdPaytm
        '
        Me.rdPaytm.Location = New System.Drawing.Point(129, 14)
        Me.rdPaytm.Name = "rdPaytm"
        Me.rdPaytm.Size = New System.Drawing.Size(54, 18)
        Me.rdPaytm.TabIndex = 0
        Me.rdPaytm.Text = "PayTM"
        '
        'rdCash
        '
        Me.rdCash.Location = New System.Drawing.Point(7, 14)
        Me.rdCash.Name = "rdCash"
        Me.rdCash.Size = New System.Drawing.Size(44, 18)
        Me.rdCash.TabIndex = 0
        Me.rdCash.Text = "Cash"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(315, 521)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(211, 21)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "SELECT PAYMENT OPTION"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1081, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.RadCalculatorDropDown1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblmess)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.datepkrOrderDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtperunitprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.drpdwnProductList)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "       "
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCalculatorDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.rdPaytm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents datepkrOrderDate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtperunitprice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtquantity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents drpdwnProductList As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtOrderNo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents btnAddProduct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnorder As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblmess As Label
    Friend WithEvents tmrerr As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RadCalculatorDropDown1 As Telerik.WinControls.UI.RadCalculatorDropDown
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdPaytm As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdCash As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents Label10 As Label
End Class
