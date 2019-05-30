<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getSupplierImages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(getSupplierImages))
        Me.btnGetImageByCamera = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGetFromDirectory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'btnGetImageByCamera
        '
        Me.btnGetImageByCamera.Activecolor = System.Drawing.Color.Black
        Me.btnGetImageByCamera.BackColor = System.Drawing.Color.Black
        Me.btnGetImageByCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetImageByCamera.BorderRadius = 0
        Me.btnGetImageByCamera.ButtonText = "Use Camera"
        Me.btnGetImageByCamera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetImageByCamera.DisabledColor = System.Drawing.Color.Gray
        Me.btnGetImageByCamera.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGetImageByCamera.Iconimage = CType(resources.GetObject("btnGetImageByCamera.Iconimage"), System.Drawing.Image)
        Me.btnGetImageByCamera.Iconimage_right = Nothing
        Me.btnGetImageByCamera.Iconimage_right_Selected = Nothing
        Me.btnGetImageByCamera.Iconimage_Selected = Nothing
        Me.btnGetImageByCamera.IconMarginLeft = 0
        Me.btnGetImageByCamera.IconMarginRight = 0
        Me.btnGetImageByCamera.IconRightVisible = True
        Me.btnGetImageByCamera.IconRightZoom = 0R
        Me.btnGetImageByCamera.IconVisible = True
        Me.btnGetImageByCamera.IconZoom = 90.0R
        Me.btnGetImageByCamera.IsTab = False
        Me.btnGetImageByCamera.Location = New System.Drawing.Point(13, 13)
        Me.btnGetImageByCamera.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetImageByCamera.Name = "btnGetImageByCamera"
        Me.btnGetImageByCamera.Normalcolor = System.Drawing.Color.Black
        Me.btnGetImageByCamera.OnHovercolor = System.Drawing.Color.Black
        Me.btnGetImageByCamera.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGetImageByCamera.selected = False
        Me.btnGetImageByCamera.Size = New System.Drawing.Size(571, 48)
        Me.btnGetImageByCamera.TabIndex = 13
        Me.btnGetImageByCamera.Text = "Use Camera"
        Me.btnGetImageByCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGetImageByCamera.Textcolor = System.Drawing.Color.White
        Me.btnGetImageByCamera.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.Activecolor = System.Drawing.Color.Black
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.BorderRadius = 0
        Me.btnClose.ButtonText = "Exit"
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
        Me.btnClose.Location = New System.Drawing.Point(13, 125)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.Black
        Me.btnClose.OnHovercolor = System.Drawing.Color.Black
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(571, 48)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Exit"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGetFromDirectory
        '
        Me.btnGetFromDirectory.Activecolor = System.Drawing.Color.Black
        Me.btnGetFromDirectory.BackColor = System.Drawing.Color.Black
        Me.btnGetFromDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetFromDirectory.BorderRadius = 0
        Me.btnGetFromDirectory.ButtonText = "Get From Computer"
        Me.btnGetFromDirectory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetFromDirectory.DisabledColor = System.Drawing.Color.Gray
        Me.btnGetFromDirectory.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGetFromDirectory.Iconimage = CType(resources.GetObject("btnGetFromDirectory.Iconimage"), System.Drawing.Image)
        Me.btnGetFromDirectory.Iconimage_right = Nothing
        Me.btnGetFromDirectory.Iconimage_right_Selected = Nothing
        Me.btnGetFromDirectory.Iconimage_Selected = Nothing
        Me.btnGetFromDirectory.IconMarginLeft = 0
        Me.btnGetFromDirectory.IconMarginRight = 0
        Me.btnGetFromDirectory.IconRightVisible = True
        Me.btnGetFromDirectory.IconRightZoom = 0R
        Me.btnGetFromDirectory.IconVisible = True
        Me.btnGetFromDirectory.IconZoom = 90.0R
        Me.btnGetFromDirectory.IsTab = False
        Me.btnGetFromDirectory.Location = New System.Drawing.Point(13, 69)
        Me.btnGetFromDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetFromDirectory.Name = "btnGetFromDirectory"
        Me.btnGetFromDirectory.Normalcolor = System.Drawing.Color.Black
        Me.btnGetFromDirectory.OnHovercolor = System.Drawing.Color.Black
        Me.btnGetFromDirectory.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGetFromDirectory.selected = False
        Me.btnGetFromDirectory.Size = New System.Drawing.Size(571, 48)
        Me.btnGetFromDirectory.TabIndex = 12
        Me.btnGetFromDirectory.Text = "Get From Computer"
        Me.btnGetFromDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGetFromDirectory.Textcolor = System.Drawing.Color.White
        Me.btnGetFromDirectory.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'getSupplierImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 183)
        Me.Controls.Add(Me.btnGetImageByCamera)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGetFromDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "getSupplierImages"
        Me.Text = "getSupplierImages"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetImageByCamera As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGetFromDirectory As Bunifu.Framework.UI.BunifuFlatButton
End Class
