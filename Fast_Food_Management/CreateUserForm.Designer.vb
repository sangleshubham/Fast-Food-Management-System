<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateUserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUserForm))
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblmess = New System.Windows.Forms.Label()
        Me.tmrerr = New System.Windows.Forms.Timer(Me.components)
        Me.txtname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnCreateuser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnexit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmobno = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtaddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.selectuserimage = New System.Windows.Forms.OpenFileDialog()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtusername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtadharno = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalary = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblmess2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCapture = New Telerik.WinControls.UI.RadButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkbxDetectFace = New Telerik.WinControls.UI.RadCheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMes = New System.Windows.Forms.Label()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkbxDetectFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(264, 191)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(86, 20)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Full Name*"
        '
        'lblmess
        '
        Me.lblmess.AutoSize = True
        Me.lblmess.Location = New System.Drawing.Point(1, 0)
        Me.lblmess.Name = "lblmess"
        Me.lblmess.Size = New System.Drawing.Size(39, 13)
        Me.lblmess.TabIndex = 5
        Me.lblmess.Text = "Label1"
        '
        'tmrerr
        '
        Me.tmrerr.Interval = 2000
        '
        'txtname
        '
        Me.txtname.BorderColorFocused = System.Drawing.Color.Red
        Me.txtname.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtname.BorderThickness = 1
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtname.isPassword = False
        Me.txtname.Location = New System.Drawing.Point(413, 181)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(319, 30)
        Me.txtname.TabIndex = 0
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCreateuser
        '
        Me.btnCreateuser.Activecolor = System.Drawing.Color.Black
        Me.btnCreateuser.BackColor = System.Drawing.Color.Black
        Me.btnCreateuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateuser.BorderRadius = 0
        Me.btnCreateuser.ButtonText = "Create User"
        Me.btnCreateuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateuser.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateuser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateuser.Iconimage = CType(resources.GetObject("btnCreateuser.Iconimage"), System.Drawing.Image)
        Me.btnCreateuser.Iconimage_right = Nothing
        Me.btnCreateuser.Iconimage_right_Selected = Nothing
        Me.btnCreateuser.Iconimage_Selected = Nothing
        Me.btnCreateuser.IconMarginLeft = 0
        Me.btnCreateuser.IconMarginRight = 0
        Me.btnCreateuser.IconRightVisible = True
        Me.btnCreateuser.IconRightZoom = 0R
        Me.btnCreateuser.IconVisible = True
        Me.btnCreateuser.IconZoom = 90.0R
        Me.btnCreateuser.IsTab = False
        Me.btnCreateuser.Location = New System.Drawing.Point(4, 216)
        Me.btnCreateuser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateuser.Name = "btnCreateuser"
        Me.btnCreateuser.Normalcolor = System.Drawing.Color.Black
        Me.btnCreateuser.OnHovercolor = System.Drawing.Color.Black
        Me.btnCreateuser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateuser.selected = False
        Me.btnCreateuser.Size = New System.Drawing.Size(196, 48)
        Me.btnCreateuser.TabIndex = 8
        Me.btnCreateuser.Text = "Create User"
        Me.btnCreateuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateuser.Textcolor = System.Drawing.Color.White
        Me.btnCreateuser.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnexit.Location = New System.Drawing.Point(4, 273)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Normalcolor = System.Drawing.Color.Black
        Me.btnexit.OnHovercolor = System.Drawing.Color.Black
        Me.btnexit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnexit.selected = False
        Me.btnexit.Size = New System.Drawing.Size(196, 48)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Textcolor = System.Drawing.Color.White
        Me.btnexit.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mobile No*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Aadhar Card No*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Address*"
        '
        'txtmobno
        '
        Me.txtmobno.BorderColorFocused = System.Drawing.Color.Red
        Me.txtmobno.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtmobno.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtmobno.BorderThickness = 1
        Me.txtmobno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmobno.isPassword = False
        Me.txtmobno.Location = New System.Drawing.Point(413, 234)
        Me.txtmobno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(319, 30)
        Me.txtmobno.TabIndex = 1
        Me.txtmobno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtaddress
        '
        Me.txtaddress.BorderColorFocused = System.Drawing.Color.Red
        Me.txtaddress.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtaddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtaddress.BorderThickness = 1
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.isPassword = False
        Me.txtaddress.Location = New System.Drawing.Point(413, 348)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(601, 30)
        Me.txtaddress.TabIndex = 3
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.BorderColorFocused = System.Drawing.Color.Red
        Me.txtemail.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtemail.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtemail.BorderThickness = 1
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemail.isPassword = False
        Me.txtemail.Location = New System.Drawing.Point(413, 403)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(319, 30)
        Me.txtemail.TabIndex = 4
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UserImage
        '
        Me.UserImage.BackColor = System.Drawing.Color.Black
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserImage.Location = New System.Drawing.Point(739, 31)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(330, 188)
        Me.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserImage.TabIndex = 9
        Me.UserImage.TabStop = False
        '
        'selectuserimage
        '
        Me.selectuserimage.FileName = "OpenFileDialog1"
        Me.selectuserimage.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.jpeg"
        '
        'txtpass
        '
        Me.txtpass.BorderColorFocused = System.Drawing.Color.Red
        Me.txtpass.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtpass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtpass.BorderThickness = 1
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpass.isPassword = True
        Me.txtpass.Location = New System.Drawing.Point(413, 510)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(319, 30)
        Me.txtpass.TabIndex = 6
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtusername
        '
        Me.txtusername.BorderColorFocused = System.Drawing.Color.Red
        Me.txtusername.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtusername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtusername.BorderThickness = 1
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.isPassword = False
        Me.txtusername.Location = New System.Drawing.Point(413, 456)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(319, 30)
        Me.txtusername.TabIndex = 5
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Password*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Username*"
        '
        'txtadharno
        '
        Me.txtadharno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtadharno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtadharno.Location = New System.Drawing.Point(413, 295)
        Me.txtadharno.Mask = "0000   0000   0000"
        Me.txtadharno.Name = "txtadharno"
        Me.txtadharno.Size = New System.Drawing.Size(139, 26)
        Me.txtadharno.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 25)
        Me.Panel2.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnCreateuser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 625)
        Me.Panel1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Salary*"
        '
        'txtSalary
        '
        Me.txtSalary.BorderColorFocused = System.Drawing.Color.Red
        Me.txtSalary.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtSalary.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtSalary.BorderThickness = 1
        Me.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSalary.isPassword = False
        Me.txtSalary.Location = New System.Drawing.Point(413, 563)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(139, 30)
        Me.txtSalary.TabIndex = 7
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblmess2
        '
        Me.lblmess2.AutoSize = True
        Me.lblmess2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblmess2.ForeColor = System.Drawing.Color.Red
        Me.lblmess2.Location = New System.Drawing.Point(206, 46)
        Me.lblmess2.Name = "lblmess2"
        Me.lblmess2.Size = New System.Drawing.Size(44, 21)
        Me.lblmess2.TabIndex = 30
        Me.lblmess2.Text = "Error"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(361, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(295, 58)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Create User"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(739, 226)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(207, 24)
        Me.btnCapture.TabIndex = 32
        Me.btnCapture.Text = "Capture Image"
        Me.btnCapture.Visible = False
        '
        'Timer1
        '
        '
        'chkbxDetectFace
        '
        Me.chkbxDetectFace.Location = New System.Drawing.Point(991, 229)
        Me.chkbxDetectFace.Name = "chkbxDetectFace"
        Me.chkbxDetectFace.Size = New System.Drawing.Size(78, 18)
        Me.chkbxDetectFace.TabIndex = 33
        Me.chkbxDetectFace.Text = "Detect Face"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(200, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 90)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(736, 31)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(197, 13)
        Me.lblMes.TabIndex = 35
        Me.lblMes.Text = "Please Only stand one person in camera"
        Me.lblMes.Visible = False
        '
        'CreateUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 625)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkbxDetectFace)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblmess2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtadharno)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UserImage)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblmess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create User"
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkbxDetectFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As Label
    Friend WithEvents lblmess As Label
    Friend WithEvents tmrerr As Timer
    Friend WithEvents txtname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnCreateuser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmobno As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtaddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents selectuserimage As OpenFileDialog
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtadharno As MaskedTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalary As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblmess2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCapture As Telerik.WinControls.UI.RadButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkbxDetectFace As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMes As Label
    Friend WithEvents Button1 As Button
End Class
