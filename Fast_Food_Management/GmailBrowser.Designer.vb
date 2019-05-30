<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GmailBrowser
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStop = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUrl = New DevExpress.XtraEditors.TextEdit()
        Me.wbUse = New System.Windows.Forms.WebBrowser()
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnClose.Location = New System.Drawing.Point(1225, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 31)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(54, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(48, 23)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Forward"
        '
        'btnBack
        '
        Me.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBack.Location = New System.Drawing.Point(2, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        '
        'btnStop
        '
        Me.btnStop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnStop.Location = New System.Drawing.Point(160, 10)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(35, 23)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        '
        'btnGo
        '
        Me.btnGo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnGo.Location = New System.Drawing.Point(520, 11)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(24, 23)
        Me.btnGo.TabIndex = 10
        Me.btnGo.Text = "Go"
        '
        'btnRefresh
        '
        Me.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Location = New System.Drawing.Point(108, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 23)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(201, 13)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(313, 20)
        Me.txtUrl.TabIndex = 8
        '
        'wbUse
        '
        Me.wbUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbUse.Location = New System.Drawing.Point(2, 45)
        Me.wbUse.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUse.Name = "wbUse"
        Me.wbUse.Size = New System.Drawing.Size(1305, 597)
        Me.wbUse.TabIndex = 7
        '
        'GmailBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 660)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.wbUse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GmailBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GmailBrowser"
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents wbUse As WebBrowser
End Class
