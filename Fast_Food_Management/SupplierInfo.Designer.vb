<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierInfo))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProductBySupplier = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDeleteSupplier = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnexit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtProductName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtaddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtmobno = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.cmbSupplierName = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.grdSupplierRecord = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSupplierRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSupplierRecord.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(227, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 25)
        Me.Panel2.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnProductBySupplier)
        Me.Panel1.Controls.Add(Me.btnDeleteSupplier)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 600)
        Me.Panel1.TabIndex = 59
        '
        'btnProductBySupplier
        '
        Me.btnProductBySupplier.Activecolor = System.Drawing.Color.Black
        Me.btnProductBySupplier.BackColor = System.Drawing.Color.Black
        Me.btnProductBySupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProductBySupplier.BorderRadius = 0
        Me.btnProductBySupplier.ButtonText = "Product By Supplier"
        Me.btnProductBySupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductBySupplier.DisabledColor = System.Drawing.Color.Gray
        Me.btnProductBySupplier.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProductBySupplier.Iconimage = CType(resources.GetObject("btnProductBySupplier.Iconimage"), System.Drawing.Image)
        Me.btnProductBySupplier.Iconimage_right = Nothing
        Me.btnProductBySupplier.Iconimage_right_Selected = Nothing
        Me.btnProductBySupplier.Iconimage_Selected = Nothing
        Me.btnProductBySupplier.IconMarginLeft = 0
        Me.btnProductBySupplier.IconMarginRight = 0
        Me.btnProductBySupplier.IconRightVisible = True
        Me.btnProductBySupplier.IconRightZoom = 0R
        Me.btnProductBySupplier.IconVisible = True
        Me.btnProductBySupplier.IconZoom = 90.0R
        Me.btnProductBySupplier.IsTab = False
        Me.btnProductBySupplier.Location = New System.Drawing.Point(0, 188)
        Me.btnProductBySupplier.Name = "btnProductBySupplier"
        Me.btnProductBySupplier.Normalcolor = System.Drawing.Color.Black
        Me.btnProductBySupplier.OnHovercolor = System.Drawing.Color.Black
        Me.btnProductBySupplier.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProductBySupplier.selected = False
        Me.btnProductBySupplier.Size = New System.Drawing.Size(223, 58)
        Me.btnProductBySupplier.TabIndex = 6
        Me.btnProductBySupplier.Text = "Product By Supplier"
        Me.btnProductBySupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductBySupplier.Textcolor = System.Drawing.Color.White
        Me.btnProductBySupplier.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.Activecolor = System.Drawing.Color.Black
        Me.btnDeleteSupplier.BackColor = System.Drawing.Color.Black
        Me.btnDeleteSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteSupplier.BorderRadius = 0
        Me.btnDeleteSupplier.ButtonText = "Delete Supplier"
        Me.btnDeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSupplier.DisabledColor = System.Drawing.Color.Gray
        Me.btnDeleteSupplier.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDeleteSupplier.Iconimage = CType(resources.GetObject("btnDeleteSupplier.Iconimage"), System.Drawing.Image)
        Me.btnDeleteSupplier.Iconimage_right = Nothing
        Me.btnDeleteSupplier.Iconimage_right_Selected = Nothing
        Me.btnDeleteSupplier.Iconimage_Selected = Nothing
        Me.btnDeleteSupplier.IconMarginLeft = 0
        Me.btnDeleteSupplier.IconMarginRight = 0
        Me.btnDeleteSupplier.IconRightVisible = True
        Me.btnDeleteSupplier.IconRightZoom = 0R
        Me.btnDeleteSupplier.IconVisible = True
        Me.btnDeleteSupplier.IconZoom = 90.0R
        Me.btnDeleteSupplier.IsTab = False
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(-3, 252)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Normalcolor = System.Drawing.Color.Black
        Me.btnDeleteSupplier.OnHovercolor = System.Drawing.Color.Black
        Me.btnDeleteSupplier.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDeleteSupplier.selected = False
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(226, 48)
        Me.btnDeleteSupplier.TabIndex = 7
        Me.btnDeleteSupplier.Text = "Delete Supplier"
        Me.btnDeleteSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteSupplier.Textcolor = System.Drawing.Color.White
        Me.btnDeleteSupplier.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnexit
        '
        Me.btnexit.Activecolor = System.Drawing.Color.Black
        Me.btnexit.BackColor = System.Drawing.Color.Black
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.BorderRadius = 0
        Me.btnexit.ButtonText = "Exit"
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
        Me.btnexit.Location = New System.Drawing.Point(0, 306)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Normalcolor = System.Drawing.Color.Black
        Me.btnexit.OnHovercolor = System.Drawing.Color.Black
        Me.btnexit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnexit.selected = False
        Me.btnexit.Size = New System.Drawing.Size(223, 48)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Textcolor = System.Drawing.Color.White
        Me.btnexit.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
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
        Me.txtProductName.Location = New System.Drawing.Point(385, 402)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(392, 30)
        Me.txtProductName.TabIndex = 4
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtaddress
        '
        Me.txtaddress.BorderColorFocused = System.Drawing.Color.Red
        Me.txtaddress.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtaddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtaddress.BorderThickness = 1
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.isPassword = False
        Me.txtaddress.Location = New System.Drawing.Point(385, 362)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(428, 30)
        Me.txtaddress.TabIndex = 3
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtmobno
        '
        Me.txtmobno.BorderColorFocused = System.Drawing.Color.Red
        Me.txtmobno.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtmobno.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtmobno.BorderThickness = 1
        Me.txtmobno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmobno.Enabled = False
        Me.txtmobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmobno.isPassword = False
        Me.txtmobno.Location = New System.Drawing.Point(385, 323)
        Me.txtmobno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(164, 30)
        Me.txtmobno.TabIndex = 2
        Me.txtmobno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtname
        '
        Me.txtname.BorderColorFocused = System.Drawing.Color.Red
        Me.txtname.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtname.BorderThickness = 1
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtname.isPassword = False
        Me.txtname.Location = New System.Drawing.Point(385, 285)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(392, 30)
        Me.txtname.TabIndex = 1
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Phone No"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(246, 295)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 20)
        Me.lblname.TabIndex = 69
        Me.lblname.Text = "Name"
        '
        'cmbSupplierName
        '
        Me.cmbSupplierName.FormattingEnabled = True
        Me.cmbSupplierName.Location = New System.Drawing.Point(298, 188)
        Me.cmbSupplierName.Name = "cmbSupplierName"
        Me.cmbSupplierName.Size = New System.Drawing.Size(272, 21)
        Me.cmbSupplierName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtPrice.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtPrice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPrice.BorderThickness = 1
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrice.isPassword = False
        Me.txtPrice.Location = New System.Drawing.Point(385, 442)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(164, 30)
        Me.txtPrice.TabIndex = 5
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 452)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Price Of Product"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(484, 58)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Supplier Information"
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(1013, 247)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(57, 66)
        Me.WindowsUIButtonPanel3.TabIndex = 75
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        '
        'UserImage
        '
        Me.UserImage.BackColor = System.Drawing.Color.Black
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserImage.Location = New System.Drawing.Point(796, 45)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(271, 196)
        Me.UserImage.TabIndex = 70
        Me.UserImage.TabStop = False
        '
        'grdSupplierRecord
        '
        Me.grdSupplierRecord.Location = New System.Drawing.Point(1013, 343)
        '
        '
        '
        Me.grdSupplierRecord.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.grdSupplierRecord.Name = "grdSupplierRecord"
        Me.grdSupplierRecord.Size = New System.Drawing.Size(61, 49)
        Me.grdSupplierRecord.TabIndex = 76
        Me.grdSupplierRecord.Text = "RadGridView1"
        Me.grdSupplierRecord.Visible = False
        '
        'SupplierInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1079, 600)
        Me.Controls.Add(Me.grdSupplierRecord)
        Me.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserImage)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.cmbSupplierName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SupplierInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SupplierInfo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSupplierRecord.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSupplierRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProductBySupplier As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDeleteSupplier As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents txtProductName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtaddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtmobno As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Public WithEvents cmbSupplierName As ComboBox
    Friend WithEvents txtPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents grdSupplierRecord As Telerik.WinControls.UI.RadGridView
End Class
