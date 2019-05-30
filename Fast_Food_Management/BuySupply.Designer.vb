<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuySupply
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuySupply))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnexit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnorder = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblmess = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtperunitprice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtquantity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.drpSupplierList = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtOrderNo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrerr = New System.Windows.Forms.Timer(Me.components)
        Me.datepkrOrderDate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 25)
        Me.Panel2.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 587)
        Me.Panel1.TabIndex = 30
        '
        'btnexit
        '
        Me.btnexit.Activecolor = System.Drawing.Color.Black
        Me.btnexit.BackColor = System.Drawing.Color.Black
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.BorderRadius = 0
        Me.btnexit.ButtonText = "Close"
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.DisabledColor = System.Drawing.Color.Gray
        Me.btnexit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnexit.Iconimage = CType(resources.GetObject("btnexit.Iconimage"), System.Drawing.Image)
        Me.btnexit.Iconimage_right = Nothing
        Me.btnexit.Iconimage_right_Selected = Nothing
        Me.btnexit.Iconimage_Selected = Nothing
        Me.btnexit.IconMarginLeft = 0
        Me.btnexit.IconMarginRight = 0
        Me.btnexit.IconRightVisible = True
        Me.btnexit.IconRightZoom = 0R
        Me.btnexit.IconVisible = True
        Me.btnexit.IconZoom = 90.0R
        Me.btnexit.IsTab = False
        Me.btnexit.Location = New System.Drawing.Point(4, 232)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Normalcolor = System.Drawing.Color.Black
        Me.btnexit.OnHovercolor = System.Drawing.Color.Black
        Me.btnexit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnexit.selected = False
        Me.btnexit.Size = New System.Drawing.Size(196, 48)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Close"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Textcolor = System.Drawing.Color.White
        Me.btnexit.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnorder
        '
        Me.btnorder.Activecolor = System.Drawing.Color.Black
        Me.btnorder.BackColor = System.Drawing.Color.Black
        Me.btnorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnorder.BorderRadius = 0
        Me.btnorder.ButtonText = "Buy Supply"
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
        Me.btnorder.Location = New System.Drawing.Point(571, 467)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Normalcolor = System.Drawing.Color.Black
        Me.btnorder.OnHovercolor = System.Drawing.Color.Black
        Me.btnorder.OnHoverTextColor = System.Drawing.Color.White
        Me.btnorder.selected = False
        Me.btnorder.Size = New System.Drawing.Size(172, 41)
        Me.btnorder.TabIndex = 58
        Me.btnorder.Text = "Buy Supply"
        Me.btnorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnorder.Textcolor = System.Drawing.Color.White
        Me.btnorder.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblmess
        '
        Me.lblmess.AutoSize = True
        Me.lblmess.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblmess.ForeColor = System.Drawing.Color.Red
        Me.lblmess.Location = New System.Drawing.Point(775, 344)
        Me.lblmess.Name = "lblmess"
        Me.lblmess.Size = New System.Drawing.Size(113, 21)
        Me.lblmess.TabIndex = 68
        Me.lblmess.Text = "ErrorMessage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(542, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Rs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(542, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 67
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
        Me.txtTotalPrice.Location = New System.Drawing.Point(582, 380)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(219, 30)
        Me.txtTotalPrice.TabIndex = 57
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
        Me.txtperunitprice.Location = New System.Drawing.Point(582, 304)
        Me.txtperunitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtperunitprice.Name = "txtperunitprice"
        Me.txtperunitprice.Size = New System.Drawing.Size(186, 30)
        Me.txtperunitprice.TabIndex = 59
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
        Me.txtquantity.Location = New System.Drawing.Point(582, 342)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(186, 30)
        Me.txtquantity.TabIndex = 1
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'drpSupplierList
        '
        Me.drpSupplierList.BackColor = System.Drawing.Color.Black
        Me.drpSupplierList.BorderRadius = 3
        Me.drpSupplierList.ForeColor = System.Drawing.Color.White
        'Me.drpSupplierList.Items = New String(-1) {}
        Me.drpSupplierList.Location = New System.Drawing.Point(582, 224)
        Me.drpSupplierList.Name = "drpSupplierList"
        Me.drpSupplierList.NomalColor = System.Drawing.Color.Black
        Me.drpSupplierList.onHoverColor = System.Drawing.Color.Black
        Me.drpSupplierList.selectedIndex = -1
        Me.drpSupplierList.Size = New System.Drawing.Size(217, 35)
        Me.drpSupplierList.TabIndex = 70
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
        Me.txtOrderNo.Location = New System.Drawing.Point(582, 183)
        Me.txtOrderNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(420, 30)
        Me.txtOrderNo.TabIndex = 53
        Me.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(342, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 21)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "PER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(341, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(341, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "TOTAL PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(341, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "SUPPLIER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "SUPPLY NO"
        '
        'tmrerr
        '
        Me.tmrerr.Interval = 2000
        '
        'datepkrOrderDate
        '
        Me.datepkrOrderDate.BackColor = System.Drawing.Color.Black
        Me.datepkrOrderDate.BorderRadius = 0
        Me.datepkrOrderDate.Enabled = False
        Me.datepkrOrderDate.ForeColor = System.Drawing.Color.White
        Me.datepkrOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datepkrOrderDate.FormatCustom = Nothing
        Me.datepkrOrderDate.Location = New System.Drawing.Point(206, 31)
        Me.datepkrOrderDate.Name = "datepkrOrderDate"
        Me.datepkrOrderDate.Size = New System.Drawing.Size(306, 53)
        Me.datepkrOrderDate.TabIndex = 69
        Me.datepkrOrderDate.Value = New Date(2018, 1, 3, 15, 59, 45, 0)
        Me.datepkrOrderDate.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(342, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.BorderColorFocused = System.Drawing.Color.Red
        Me.txtProductName.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtProductName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtProductName.BorderThickness = 1
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.Enabled = False
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProductName.isPassword = False
        Me.txtProductName.Location = New System.Drawing.Point(582, 266)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(186, 30)
        Me.txtProductName.TabIndex = 59
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BuySupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 587)
        Me.Controls.Add(Me.datepkrOrderDate)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.lblmess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtperunitprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.drpSupplierList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuySupply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuySupply"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnorder As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblmess As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtperunitprice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtquantity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents drpSupplierList As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtOrderNo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrerr As Timer
    Friend WithEvents datepkrOrderDate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Timer1 As Timer
End Class
