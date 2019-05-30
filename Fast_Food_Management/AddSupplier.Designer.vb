<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSupplier))
        Me.txtSupplierName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplierPhoneNo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblmess2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkbxDetectFace = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnCapture = New Telerik.WinControls.UI.RadButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSaveSupplier = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SupplierImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.chkbxDetectFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSupplierName
        '
        Me.txtSupplierName.BorderColorFocused = System.Drawing.Color.Red
        Me.txtSupplierName.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtSupplierName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtSupplierName.BorderThickness = 1
        Me.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSupplierName.isPassword = False
        Me.txtSupplierName.Location = New System.Drawing.Point(378, 268)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(392, 30)
        Me.txtSupplierName.TabIndex = 0
        Me.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(206, 278)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(113, 20)
        Me.lblname.TabIndex = 20
        Me.lblname.Text = "Supplier Name"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColorFocused = System.Drawing.Color.Red
        Me.txtAddress.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtAddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtAddress.BorderThickness = 1
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.isPassword = False
        Me.txtAddress.Location = New System.Drawing.Point(378, 306)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(392, 30)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Address"
        '
        'txtSupplierPhoneNo
        '
        Me.txtSupplierPhoneNo.BorderColorFocused = System.Drawing.Color.Red
        Me.txtSupplierPhoneNo.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtSupplierPhoneNo.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtSupplierPhoneNo.BorderThickness = 1
        Me.txtSupplierPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplierPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierPhoneNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSupplierPhoneNo.isPassword = False
        Me.txtSupplierPhoneNo.Location = New System.Drawing.Point(378, 344)
        Me.txtSupplierPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierPhoneNo.Name = "txtSupplierPhoneNo"
        Me.txtSupplierPhoneNo.Size = New System.Drawing.Size(392, 30)
        Me.txtSupplierPhoneNo.TabIndex = 2
        Me.txtSupplierPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Phone No"
        '
        'txtProductName
        '
        Me.txtProductName.BorderColorFocused = System.Drawing.Color.Red
        Me.txtProductName.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtProductName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtProductName.BorderThickness = 1
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProductName.isPassword = False
        Me.txtProductName.Location = New System.Drawing.Point(378, 382)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(392, 30)
        Me.txtProductName.TabIndex = 3
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Product Name"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.jpeg"
        '
        'lblmess2
        '
        Me.lblmess2.AutoSize = True
        Me.lblmess2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblmess2.ForeColor = System.Drawing.Color.Red
        Me.lblmess2.Location = New System.Drawing.Point(206, 42)
        Me.lblmess2.Name = "lblmess2"
        Me.lblmess2.Size = New System.Drawing.Size(44, 21)
        Me.lblmess2.TabIndex = 32
        Me.lblmess2.Text = "Error"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 25)
        Me.Panel2.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnSaveSupplier)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 626)
        Me.Panel1.TabIndex = 33
        '
        'txtPrice
        '
        Me.txtPrice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtPrice.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtPrice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPrice.BorderThickness = 1
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrice.isPassword = False
        Me.txtPrice.Location = New System.Drawing.Point(378, 420)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(175, 30)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Rs."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 36.0!)
        Me.Label6.Location = New System.Drawing.Point(320, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(323, 58)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Add Supplier"
        '
        'chkbxDetectFace
        '
        Me.chkbxDetectFace.Location = New System.Drawing.Point(977, 240)
        Me.chkbxDetectFace.Name = "chkbxDetectFace"
        Me.chkbxDetectFace.Size = New System.Drawing.Size(78, 18)
        Me.chkbxDetectFace.TabIndex = 39
        Me.chkbxDetectFace.Text = "Detect Face"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(798, 237)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(173, 24)
        Me.btnCapture.TabIndex = 38
        Me.btnCapture.Text = "Capture Image"
        Me.btnCapture.Visible = False
        '
        'Timer2
        '
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.Activecolor = System.Drawing.Color.Black
        Me.btnSaveSupplier.BackColor = System.Drawing.Color.Black
        Me.btnSaveSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSupplier.BorderRadius = 0
        Me.btnSaveSupplier.ButtonText = "Add Supplier"
        Me.btnSaveSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSupplier.DisabledColor = System.Drawing.Color.Gray
        Me.btnSaveSupplier.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSaveSupplier.Iconimage = CType(resources.GetObject("btnSaveSupplier.Iconimage"), System.Drawing.Image)
        Me.btnSaveSupplier.Iconimage_right = Nothing
        Me.btnSaveSupplier.Iconimage_right_Selected = Nothing
        Me.btnSaveSupplier.Iconimage_Selected = Nothing
        Me.btnSaveSupplier.IconMarginLeft = 0
        Me.btnSaveSupplier.IconMarginRight = 0
        Me.btnSaveSupplier.IconRightVisible = True
        Me.btnSaveSupplier.IconRightZoom = 0R
        Me.btnSaveSupplier.IconVisible = True
        Me.btnSaveSupplier.IconZoom = 90.0R
        Me.btnSaveSupplier.IsTab = False
        Me.btnSaveSupplier.Location = New System.Drawing.Point(0, 250)
        Me.btnSaveSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Normalcolor = System.Drawing.Color.Black
        Me.btnSaveSupplier.OnHovercolor = System.Drawing.Color.Black
        Me.btnSaveSupplier.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSaveSupplier.selected = False
        Me.btnSaveSupplier.Size = New System.Drawing.Size(200, 48)
        Me.btnSaveSupplier.TabIndex = 5
        Me.btnSaveSupplier.Text = "Add Supplier"
        Me.btnSaveSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSupplier.Textcolor = System.Drawing.Color.White
        Me.btnSaveSupplier.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnClose.Location = New System.Drawing.Point(0, 306)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.Black
        Me.btnClose.OnHovercolor = System.Drawing.Color.Black
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(200, 48)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SupplierImage
        '
        Me.SupplierImage.BackColor = System.Drawing.Color.Black
        Me.SupplierImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SupplierImage.Location = New System.Drawing.Point(798, 31)
        Me.SupplierImage.Name = "SupplierImage"
        Me.SupplierImage.Size = New System.Drawing.Size(271, 196)
        Me.SupplierImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SupplierImage.TabIndex = 29
        Me.SupplierImage.TabStop = False
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 626)
        Me.Controls.Add(Me.chkbxDetectFace)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblmess2)
        Me.Controls.Add(Me.SupplierImage)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplierPhoneNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.lblname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddSupplier"
        Me.Panel1.ResumeLayout(False)
        CType(Me.chkbxDetectFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSupplierName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblname As Label
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierPhoneNo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents SupplierImage As PictureBox
    Friend WithEvents btnSaveSupplier As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblmess2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkbxDetectFace As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnCapture As Telerik.WinControls.UI.RadButton
    Friend WithEvents Timer2 As Timer
End Class
