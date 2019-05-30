<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.lblerror = New System.Windows.Forms.Label()
        Me.tmrerr = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtboxppass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtboxusername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.RadDesktopAlert1 = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
        Me.btnLogin = New Telerik.WinControls.UI.RadButton()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblerror.ForeColor = System.Drawing.Color.Transparent
        Me.lblerror.Location = New System.Drawing.Point(2, 2)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(39, 13)
        Me.lblerror.TabIndex = 13
        Me.lblerror.Text = "Label3"
        '
        'tmrerr
        '
        Me.tmrerr.Interval = 2000
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(84, 168)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(78, 20)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(84, 106)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(83, 20)
        Me.BunifuCustomLabel1.TabIndex = 15
        Me.BunifuCustomLabel1.Text = "Username"
        '
        'txtboxppass
        '
        Me.txtboxppass.BackColor = System.Drawing.Color.White
        Me.txtboxppass.BorderColorFocused = System.Drawing.Color.Red
        Me.txtboxppass.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtboxppass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtboxppass.BorderThickness = 1
        Me.txtboxppass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxppass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxppass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtboxppass.isPassword = True
        Me.txtboxppass.Location = New System.Drawing.Point(221, 158)
        Me.txtboxppass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxppass.Name = "txtboxppass"
        Me.txtboxppass.Size = New System.Drawing.Size(368, 30)
        Me.txtboxppass.TabIndex = 1
        Me.txtboxppass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtboxusername
        '
        Me.txtboxusername.BackColor = System.Drawing.Color.White
        Me.txtboxusername.BorderColorFocused = System.Drawing.Color.Red
        Me.txtboxusername.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtboxusername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtboxusername.BorderThickness = 1
        Me.txtboxusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtboxusername.isPassword = False
        Me.txtboxusername.Location = New System.Drawing.Point(221, 96)
        Me.txtboxusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxusername.Name = "txtboxusername"
        Me.txtboxusername.Size = New System.Drawing.Size(368, 30)
        Me.txtboxusername.TabIndex = 0
        Me.txtboxusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RadDesktopAlert1
        '
        Me.RadDesktopAlert1.ScreenPosition = Telerik.WinControls.UI.AlertScreenPosition.TopCenter
        Me.RadDesktopAlert1.ShowOptionsButton = False
        Me.RadDesktopAlert1.ShowPinButton = False
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(221, 243)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(164, 36)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.ThemeName = "Office2010Black"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.ThemeName = "Office2010Black"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(560, 340)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Forget Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fast_Food_Management.My.Resources.Resources.LoginBack
        Me.ClientSize = New System.Drawing.Size(668, 368)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtboxppass)
        Me.Controls.Add(Me.txtboxusername)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblerror As Label
    Friend WithEvents tmrerr As Timer
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtboxppass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtboxusername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents RadDesktopAlert1 As Telerik.WinControls.UI.RadDesktopAlert
    Friend WithEvents btnLogin As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
