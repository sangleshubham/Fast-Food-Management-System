<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgetPassword))
        Me.btnLogin = New Telerik.WinControls.UI.RadButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtgetUserName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblNo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(353, 246)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(164, 36)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Get Password"
        Me.btnLogin.ThemeName = "Office2010Black"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 200)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(83, 20)
        Me.BunifuCustomLabel1.TabIndex = 18
        Me.BunifuCustomLabel1.Text = "Username"
        '
        'txtgetUserName
        '
        Me.txtgetUserName.BackColor = System.Drawing.Color.White
        Me.txtgetUserName.BorderColorFocused = System.Drawing.Color.Red
        Me.txtgetUserName.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtgetUserName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtgetUserName.BorderThickness = 1
        Me.txtgetUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgetUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgetUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtgetUserName.isPassword = False
        Me.txtgetUserName.Location = New System.Drawing.Point(149, 190)
        Me.txtgetUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgetUserName.Name = "txtgetUserName"
        Me.txtgetUserName.Size = New System.Drawing.Size(368, 30)
        Me.txtgetUserName.TabIndex = 16
        Me.txtgetUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.Black
        Me.lblNo.Location = New System.Drawing.Point(12, 251)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(63, 20)
        Me.lblNo.TabIndex = 19
        Me.lblNo.Text = "number"
        Me.lblNo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 304)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtgetUserName)
        Me.Name = "ForgetPassword"
        Me.Text = "ForgetPassword"
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Telerik.WinControls.UI.RadButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtgetUserName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblNo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
