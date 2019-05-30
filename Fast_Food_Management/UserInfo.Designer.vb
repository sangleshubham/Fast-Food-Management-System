<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInfo
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo))
        Me.cmb = New System.Windows.Forms.ComboBox()
        Me.tmrerr = New System.Windows.Forms.Timer(Me.components)
        Me.txtemail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtaddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtadharno = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtmobno = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSalary = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJoin = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdUserInfo = New Telerik.WinControls.UI.RadGridView()
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.btnCreateuser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDeleteUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnexit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grdUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUserInfo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb
        '
        Me.cmb.FormattingEnabled = True
        Me.cmb.Location = New System.Drawing.Point(314, 188)
        Me.cmb.Name = "cmb"
        Me.cmb.Size = New System.Drawing.Size(272, 21)
        Me.cmb.TabIndex = 0
        '
        'tmrerr
        '
        Me.tmrerr.Interval = 2000
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
        Me.txtemail.Location = New System.Drawing.Point(453, 428)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(392, 30)
        Me.txtemail.TabIndex = 5
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtaddress.Location = New System.Drawing.Point(453, 388)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(428, 30)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtadharno
        '
        Me.txtadharno.BorderColorFocused = System.Drawing.Color.Red
        Me.txtadharno.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtadharno.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtadharno.BorderThickness = 1
        Me.txtadharno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtadharno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadharno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtadharno.isPassword = False
        Me.txtadharno.Location = New System.Drawing.Point(453, 348)
        Me.txtadharno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtadharno.Name = "txtadharno"
        Me.txtadharno.Size = New System.Drawing.Size(164, 30)
        Me.txtadharno.TabIndex = 3
        Me.txtadharno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtmobno.Location = New System.Drawing.Point(453, 308)
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
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtname.isPassword = False
        Me.txtname.Location = New System.Drawing.Point(453, 270)
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
        Me.Label4.Location = New System.Drawing.Point(314, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Aadhar Card No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Mobile No"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(314, 280)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 20)
        Me.lblname.TabIndex = 18
        Me.lblname.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnCreateuser)
        Me.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 621)
        Me.Panel1.TabIndex = 56
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(226, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(947, 25)
        Me.Panel2.TabIndex = 58
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
        Me.txtSalary.Location = New System.Drawing.Point(453, 468)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(133, 30)
        Me.txtSalary.TabIndex = 59
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(314, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Salary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Date Of Joining"
        '
        'txtJoin
        '
        Me.txtJoin.BorderColorFocused = System.Drawing.Color.Red
        Me.txtJoin.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtJoin.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtJoin.BorderThickness = 1
        Me.txtJoin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtJoin.isPassword = False
        Me.txtJoin.Location = New System.Drawing.Point(453, 507)
        Me.txtJoin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJoin.Name = "txtJoin"
        Me.txtJoin.Size = New System.Drawing.Size(164, 30)
        Me.txtJoin.TabIndex = 1
        Me.txtJoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 36.0!)
        Me.Label6.Location = New System.Drawing.Point(304, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 58)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "User Informetion"
        '
        'grdUserInfo
        '
        Me.grdUserInfo.Location = New System.Drawing.Point(896, 297)
        '
        '
        '
        Me.grdUserInfo.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdUserInfo.Name = "grdUserInfo"
        Me.grdUserInfo.Size = New System.Drawing.Size(58, 41)
        Me.grdUserInfo.TabIndex = 62
        Me.grdUserInfo.Text = "RadGridView1"
        Me.grdUserInfo.Visible = False
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(1067, 252)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(57, 66)
        Me.WindowsUIButtonPanel3.TabIndex = 76
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        '
        'btnCreateuser
        '
        Me.btnCreateuser.Activecolor = System.Drawing.Color.Black
        Me.btnCreateuser.BackColor = System.Drawing.Color.Black
        Me.btnCreateuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateuser.BorderRadius = 0
        Me.btnCreateuser.ButtonText = "Sell Of User"
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
        Me.btnCreateuser.Location = New System.Drawing.Point(0, 188)
        Me.btnCreateuser.Name = "btnCreateuser"
        Me.btnCreateuser.Normalcolor = System.Drawing.Color.Black
        Me.btnCreateuser.OnHovercolor = System.Drawing.Color.Black
        Me.btnCreateuser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateuser.selected = False
        Me.btnCreateuser.Size = New System.Drawing.Size(226, 58)
        Me.btnCreateuser.TabIndex = 6
        Me.btnCreateuser.Text = "Sell Of User"
        Me.btnCreateuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateuser.Textcolor = System.Drawing.Color.White
        Me.btnCreateuser.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Activecolor = System.Drawing.Color.Black
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Black
        Me.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteUser.BorderRadius = 0
        Me.btnDeleteUser.ButtonText = "Delete User"
        Me.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteUser.DisabledColor = System.Drawing.Color.Gray
        Me.btnDeleteUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDeleteUser.Iconimage = CType(resources.GetObject("btnDeleteUser.Iconimage"), System.Drawing.Image)
        Me.btnDeleteUser.Iconimage_right = Nothing
        Me.btnDeleteUser.Iconimage_right_Selected = Nothing
        Me.btnDeleteUser.Iconimage_Selected = Nothing
        Me.btnDeleteUser.IconMarginLeft = 0
        Me.btnDeleteUser.IconMarginRight = 0
        Me.btnDeleteUser.IconRightVisible = True
        Me.btnDeleteUser.IconRightZoom = 0R
        Me.btnDeleteUser.IconVisible = True
        Me.btnDeleteUser.IconZoom = 90.0R
        Me.btnDeleteUser.IsTab = False
        Me.btnDeleteUser.Location = New System.Drawing.Point(-3, 252)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Normalcolor = System.Drawing.Color.Black
        Me.btnDeleteUser.OnHovercolor = System.Drawing.Color.Black
        Me.btnDeleteUser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDeleteUser.selected = False
        Me.btnDeleteUser.Size = New System.Drawing.Size(226, 48)
        Me.btnDeleteUser.TabIndex = 7
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Textcolor = System.Drawing.Color.White
        Me.btnDeleteUser.TextFont = New System.Drawing.Font("Century Gothic", 15.75!)
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
        'UserImage
        '
        Me.UserImage.BackColor = System.Drawing.Color.Black
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserImage.Location = New System.Drawing.Point(857, 50)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(267, 196)
        Me.UserImage.TabIndex = 28
        Me.UserImage.TabStop = False
        '
        'UserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1173, 621)
        Me.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Controls.Add(Me.grdUserInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserImage)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtadharno)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.txtJoin)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.cmb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Info"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdUserInfo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrerr As Timer
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCreateuser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtemail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtaddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtadharno As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtmobno As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnDeleteUser As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents cmb As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSalary As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJoin As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents grdUserInfo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
