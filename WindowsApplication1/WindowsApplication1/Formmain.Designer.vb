<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnslogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsxemSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsthemSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnssuaSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsxoaSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsxemKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsthemKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnssuaKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsxoaKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnslicense = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.QuảnLýSảnPhẩmToolStripMenuItem, Me.QuảnLýKháchHàngToolStripMenuItem, Me.ThôngTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnslogout, Me.mnsexit})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'mnslogout
        '
        Me.mnslogout.Image = Global.WindowsApplication1.My.Resources.Resources.Log_out
        Me.mnslogout.Name = "mnslogout"
        Me.mnslogout.Size = New System.Drawing.Size(129, 22)
        Me.mnslogout.Text = "Đăng Xuất"
        '
        'mnsexit
        '
        Me.mnsexit.Image = Global.WindowsApplication1.My.Resources.Resources.Delete
        Me.mnsexit.Name = "mnsexit"
        Me.mnsexit.Size = New System.Drawing.Size(129, 22)
        Me.mnsexit.Text = "Thoát"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsxemSP, Me.mnsthemSP, Me.mnssuaSP, Me.mnsxoaSP})
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm"
        '
        'mnsxemSP
        '
        Me.mnsxemSP.Image = Global.WindowsApplication1.My.Resources.Resources.List
        Me.mnsxemSP.Name = "mnsxemSP"
        Me.mnsxemSP.Size = New System.Drawing.Size(121, 22)
        Me.mnsxemSP.Text = "Xem SP"
        '
        'mnsthemSP
        '
        Me.mnsthemSP.Image = Global.WindowsApplication1.My.Resources.Resources.Add
        Me.mnsthemSP.Name = "mnsthemSP"
        Me.mnsthemSP.Size = New System.Drawing.Size(121, 22)
        Me.mnsthemSP.Text = "Thêm SP"
        '
        'mnssuaSP
        '
        Me.mnssuaSP.Image = Global.WindowsApplication1.My.Resources.Resources.Help
        Me.mnssuaSP.Name = "mnssuaSP"
        Me.mnssuaSP.Size = New System.Drawing.Size(121, 22)
        Me.mnssuaSP.Text = "Sửa SP"
        '
        'mnsxoaSP
        '
        Me.mnsxoaSP.Image = Global.WindowsApplication1.My.Resources.Resources.Delete1
        Me.mnsxoaSP.Name = "mnsxoaSP"
        Me.mnsxoaSP.Size = New System.Drawing.Size(121, 22)
        Me.mnsxoaSP.Text = "Xóa SP"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsxemKH, Me.mnsthemKH, Me.mnssuaKH, Me.mnsxoaKH})
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng"
        '
        'mnsxemKH
        '
        Me.mnsxemKH.Image = Global.WindowsApplication1.My.Resources.Resources.List
        Me.mnsxemKH.Name = "mnsxemKH"
        Me.mnsxemKH.Size = New System.Drawing.Size(124, 22)
        Me.mnsxemKH.Text = "Xem KH"
        '
        'mnsthemKH
        '
        Me.mnsthemKH.Image = Global.WindowsApplication1.My.Resources.Resources.Add
        Me.mnsthemKH.Name = "mnsthemKH"
        Me.mnsthemKH.Size = New System.Drawing.Size(124, 22)
        Me.mnsthemKH.Text = "Thêm KH"
        '
        'mnssuaKH
        '
        Me.mnssuaKH.Image = Global.WindowsApplication1.My.Resources.Resources.Help
        Me.mnssuaKH.Name = "mnssuaKH"
        Me.mnssuaKH.Size = New System.Drawing.Size(124, 22)
        Me.mnssuaKH.Text = "Sửa KH"
        '
        'mnsxoaKH
        '
        Me.mnsxoaKH.Image = Global.WindowsApplication1.My.Resources.Resources.Delete
        Me.mnsxoaKH.Name = "mnsxoaKH"
        Me.mnsxoaKH.Size = New System.Drawing.Size(124, 22)
        Me.mnsxoaKH.Text = "Xóa KH"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnslicense})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông Tin"
        '
        'mnslicense
        '
        Me.mnslicense.Image = Global.WindowsApplication1.My.Resources.Resources.Info
        Me.mnslicense.Name = "mnslicense"
        Me.mnslicense.Size = New System.Drawing.Size(132, 22)
        Me.mnslicense.Text = "Bản Quyền"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 354)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(625, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(161, 17)
        Me.ToolStripStatusLabel1.Text = "Sinh viên: Nguyễn Huy Hưng"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel2.Text = "MSSV: PS02365"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 323)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 376)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý Xì Trum"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnslogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsxemSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsthemSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnssuaSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsxoaSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnslicense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsxemKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsthemKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnssuaKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsxoaKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
