<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayTMPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayTMPay))
        Me.picPatmBarcode = New DevExpress.XtraEditors.PictureEdit()
        Me.browseBarcode = New System.Windows.Forms.OpenFileDialog()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.picPatmBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPatmBarcode
        '
        Me.picPatmBarcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.picPatmBarcode.Location = New System.Drawing.Point(0, 0)
        Me.picPatmBarcode.Name = "picPatmBarcode"
        Me.picPatmBarcode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picPatmBarcode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.picPatmBarcode.Properties.ZoomAccelerationFactor = 1.0R
        Me.picPatmBarcode.Size = New System.Drawing.Size(375, 449)
        Me.picPatmBarcode.TabIndex = 0
        Me.picPatmBarcode.ToolTip = "Scan This Barcode By PayTM"
        '
        'browseBarcode
        '
        Me.browseBarcode.FileName = "OpenFileDialog1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(381, 90)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(351, 235)
        Me.PictureEdit1.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(381, 396)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(351, 53)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.TabStop = False
        Me.SimpleButton2.Text = "Paid"
        '
        'PayTMPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 449)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.picPatmBarcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayTMPay"
        Me.Text = "PayTMPay"
        CType(Me.picPatmBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPatmBarcode As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents browseBarcode As OpenFileDialog
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
