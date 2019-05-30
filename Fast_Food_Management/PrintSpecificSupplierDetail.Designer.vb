<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSpecificSupplierDetail
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
        Me.WindowsUIButtonPanel3 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.WindowsUIButtonPanel2 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowsUIButtonPanel3
        '
        Me.WindowsUIButtonPanel3.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Exit", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel3.Location = New System.Drawing.Point(3, 91)
        Me.WindowsUIButtonPanel3.Name = "WindowsUIButtonPanel3"
        Me.WindowsUIButtonPanel3.Size = New System.Drawing.Size(194, 99)
        Me.WindowsUIButtonPanel3.TabIndex = 0
        Me.WindowsUIButtonPanel3.Text = "WindowsUIButtonPanel1"
        '
        'WindowsUIButtonPanel2
        '
        Me.WindowsUIButtonPanel2.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print Supplier Record Graph", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel2.Location = New System.Drawing.Point(206, 148)
        Me.WindowsUIButtonPanel2.Name = "WindowsUIButtonPanel2"
        Me.WindowsUIButtonPanel2.Size = New System.Drawing.Size(339, 111)
        Me.WindowsUIButtonPanel2.TabIndex = 40
        Me.WindowsUIButtonPanel2.Text = "WindowsUIButtonPanel1"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print Supplier Records", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(206, 31)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(339, 111)
        Me.WindowsUIButtonPanel1.TabIndex = 41
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 25)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.WindowsUIButtonPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 270)
        Me.Panel1.TabIndex = 42
        '
        'PrintSpecificSupplierDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(553, 270)
        Me.Controls.Add(Me.WindowsUIButtonPanel2)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintSpecificSupplierDetail"
        Me.Text = "PrintSpecificSupplierDetail"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowsUIButtonPanel3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents WindowsUIButtonPanel2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
