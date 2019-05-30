<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaptureByCamera
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaptureByCamera))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCaptureImage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChangeCamera = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.drawRect = New System.Windows.Forms.Timer(Me.components)
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblFaceCount = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1007, 501)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCaptureImage
        '
        Me.btnCaptureImage.Activecolor = System.Drawing.Color.Black
        Me.btnCaptureImage.BackColor = System.Drawing.Color.Black
        Me.btnCaptureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCaptureImage.BorderRadius = 0
        Me.btnCaptureImage.ButtonText = "Capture Image"
        Me.btnCaptureImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaptureImage.DisabledColor = System.Drawing.Color.Gray
        Me.btnCaptureImage.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCaptureImage.Iconimage = CType(resources.GetObject("btnCaptureImage.Iconimage"), System.Drawing.Image)
        Me.btnCaptureImage.Iconimage_right = Nothing
        Me.btnCaptureImage.Iconimage_right_Selected = Nothing
        Me.btnCaptureImage.Iconimage_Selected = Nothing
        Me.btnCaptureImage.IconMarginLeft = 0
        Me.btnCaptureImage.IconMarginRight = 0
        Me.btnCaptureImage.IconRightVisible = True
        Me.btnCaptureImage.IconRightZoom = 0R
        Me.btnCaptureImage.IconVisible = True
        Me.btnCaptureImage.IconZoom = 90.0R
        Me.btnCaptureImage.IsTab = False
        Me.btnCaptureImage.Location = New System.Drawing.Point(13, 520)
        Me.btnCaptureImage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCaptureImage.Name = "btnCaptureImage"
        Me.btnCaptureImage.Normalcolor = System.Drawing.Color.Black
        Me.btnCaptureImage.OnHovercolor = System.Drawing.Color.Black
        Me.btnCaptureImage.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCaptureImage.selected = False
        Me.btnCaptureImage.Size = New System.Drawing.Size(222, 48)
        Me.btnCaptureImage.TabIndex = 9
        Me.btnCaptureImage.Text = "Capture Image"
        Me.btnCaptureImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaptureImage.Textcolor = System.Drawing.Color.White
        Me.btnCaptureImage.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnClose.Location = New System.Drawing.Point(776, 520)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.Black
        Me.btnClose.OnHovercolor = System.Drawing.Color.Black
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(188, 48)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChangeCamera
        '
        Me.btnChangeCamera.Activecolor = System.Drawing.Color.Black
        Me.btnChangeCamera.BackColor = System.Drawing.Color.Black
        Me.btnChangeCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeCamera.BorderRadius = 0
        Me.btnChangeCamera.ButtonText = "Detect Face"
        Me.btnChangeCamera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeCamera.DisabledColor = System.Drawing.Color.Gray
        Me.btnChangeCamera.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChangeCamera.Iconimage = CType(resources.GetObject("btnChangeCamera.Iconimage"), System.Drawing.Image)
        Me.btnChangeCamera.Iconimage_right = Nothing
        Me.btnChangeCamera.Iconimage_right_Selected = Nothing
        Me.btnChangeCamera.Iconimage_Selected = Nothing
        Me.btnChangeCamera.IconMarginLeft = 0
        Me.btnChangeCamera.IconMarginRight = 0
        Me.btnChangeCamera.IconRightVisible = True
        Me.btnChangeCamera.IconRightZoom = 0R
        Me.btnChangeCamera.IconVisible = True
        Me.btnChangeCamera.IconZoom = 90.0R
        Me.btnChangeCamera.IsTab = False
        Me.btnChangeCamera.Location = New System.Drawing.Point(384, 520)
        Me.btnChangeCamera.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeCamera.Name = "btnChangeCamera"
        Me.btnChangeCamera.Normalcolor = System.Drawing.Color.Black
        Me.btnChangeCamera.OnHovercolor = System.Drawing.Color.Black
        Me.btnChangeCamera.OnHoverTextColor = System.Drawing.Color.White
        Me.btnChangeCamera.selected = False
        Me.btnChangeCamera.Size = New System.Drawing.Size(236, 48)
        Me.btnChangeCamera.TabIndex = 9
        Me.btnChangeCamera.Text = "Detect Face"
        Me.btnChangeCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeCamera.Textcolor = System.Drawing.Color.White
        Me.btnChangeCamera.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'drawRect
        '
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.Red
        Me.RadLabel1.Location = New System.Drawing.Point(373, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(221, 18)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Please Stand Only one Person In Camera"
        Me.RadLabel1.Visible = False
        '
        'lblFaceCount
        '
        Me.lblFaceCount.AutoSize = True
        Me.lblFaceCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaceCount.Location = New System.Drawing.Point(13, 13)
        Me.lblFaceCount.Name = "lblFaceCount"
        Me.lblFaceCount.Size = New System.Drawing.Size(51, 55)
        Me.lblFaceCount.TabIndex = 11
        Me.lblFaceCount.Text = "0"
        '
        'CaptureByCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1039, 581)
        Me.Controls.Add(Me.lblFaceCount)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnChangeCamera)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCaptureImage)
        Me.Name = "CaptureByCamera"
        Me.Text = "CaptureByCamera"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCaptureImage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnChangeCamera As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents drawRect As Timer
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFaceCount As Label
End Class
