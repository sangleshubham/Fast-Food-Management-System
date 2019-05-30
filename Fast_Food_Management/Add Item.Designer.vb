<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Item))
        Me.txtproname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnaddproduct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtproname
        '
        Me.txtproname.BorderColorFocused = System.Drawing.Color.Red
        Me.txtproname.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.txtproname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtproname.BorderThickness = 1
        Me.txtproname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtproname.isPassword = False
        Me.txtproname.Location = New System.Drawing.Point(170, 13)
        Me.txtproname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproname.Name = "txtproname"
        Me.txtproname.Size = New System.Drawing.Size(316, 30)
        Me.txtproname.TabIndex = 0
        Me.txtproname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Product Name"
        '
        'btnaddproduct
        '
        Me.btnaddproduct.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnaddproduct.BackColor = System.Drawing.Color.Black
        Me.btnaddproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnaddproduct.BorderRadius = 0
        Me.btnaddproduct.ButtonText = "Add Product"
        Me.btnaddproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddproduct.DisabledColor = System.Drawing.Color.Gray
        Me.btnaddproduct.Iconcolor = System.Drawing.Color.Transparent
        Me.btnaddproduct.Iconimage = CType(resources.GetObject("btnaddproduct.Iconimage"), System.Drawing.Image)
        Me.btnaddproduct.Iconimage_right = Nothing
        Me.btnaddproduct.Iconimage_right_Selected = Nothing
        Me.btnaddproduct.Iconimage_Selected = Nothing
        Me.btnaddproduct.IconMarginLeft = 0
        Me.btnaddproduct.IconMarginRight = 0
        Me.btnaddproduct.IconRightVisible = True
        Me.btnaddproduct.IconRightZoom = 0R
        Me.btnaddproduct.IconVisible = True
        Me.btnaddproduct.IconZoom = 90.0R
        Me.btnaddproduct.IsTab = False
        Me.btnaddproduct.Location = New System.Drawing.Point(154, 88)
        Me.btnaddproduct.Name = "btnaddproduct"
        Me.btnaddproduct.Normalcolor = System.Drawing.Color.Black
        Me.btnaddproduct.OnHovercolor = System.Drawing.Color.Black
        Me.btnaddproduct.OnHoverTextColor = System.Drawing.Color.White
        Me.btnaddproduct.selected = False
        Me.btnaddproduct.Size = New System.Drawing.Size(128, 41)
        Me.btnaddproduct.TabIndex = 2
        Me.btnaddproduct.Text = "Add Product"
        Me.btnaddproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddproduct.Textcolor = System.Drawing.Color.White
        Me.btnaddproduct.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnclose
        '
        Me.btnclose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnclose.BackColor = System.Drawing.Color.Black
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.BorderRadius = 0
        Me.btnclose.ButtonText = "Close"
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DisabledColor = System.Drawing.Color.Gray
        Me.btnclose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnclose.Iconimage = CType(resources.GetObject("btnclose.Iconimage"), System.Drawing.Image)
        Me.btnclose.Iconimage_right = Nothing
        Me.btnclose.Iconimage_right_Selected = Nothing
        Me.btnclose.Iconimage_Selected = Nothing
        Me.btnclose.IconMarginLeft = 0
        Me.btnclose.IconMarginRight = 0
        Me.btnclose.IconRightVisible = True
        Me.btnclose.IconRightZoom = 0R
        Me.btnclose.IconVisible = True
        Me.btnclose.IconZoom = 90.0R
        Me.btnclose.IsTab = False
        Me.btnclose.Location = New System.Drawing.Point(288, 88)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Normalcolor = System.Drawing.Color.Black
        Me.btnclose.OnHovercolor = System.Drawing.Color.Black
        Me.btnclose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnclose.selected = False
        Me.btnclose.Size = New System.Drawing.Size(128, 41)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Textcolor = System.Drawing.Color.White
        Me.btnclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtPrice.Location = New System.Drawing.Point(170, 51)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(96, 30)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(130, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Rs."
        '
        'Add_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(523, 144)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnaddproduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtproname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Item"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtproname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnaddproduct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
