<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthemSP
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmaSP = New System.Windows.Forms.TextBox()
        Me.txtmotaSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttenSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgiaSP = New System.Windows.Forms.TextBox()
        Me.cboloaiSP = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 236)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách SP"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(534, 211)
        Me.DataGridView1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboloaiSP)
        Me.GroupBox1.Controls.Add(Me.btnexit)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmaSP)
        Me.GroupBox1.Controls.Add(Me.txtmotaSP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttenSP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtgiaSP)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 189)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin SP"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(388, 145)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 32)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Thoát"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(233, 145)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(87, 32)
        Me.btnxoa.TabIndex = 6
        Me.btnxoa.Text = "Xóa trắng"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(89, 145)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(86, 32)
        Me.btnthem.TabIndex = 5
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã SP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(310, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mô tả SP"
        '
        'txtmaSP
        '
        Me.txtmaSP.Location = New System.Drawing.Point(110, 26)
        Me.txtmaSP.Name = "txtmaSP"
        Me.txtmaSP.Size = New System.Drawing.Size(158, 23)
        Me.txtmaSP.TabIndex = 0
        '
        'txtmotaSP
        '
        Me.txtmotaSP.Location = New System.Drawing.Point(377, 27)
        Me.txtmotaSP.Multiline = True
        Me.txtmotaSP.Name = "txtmotaSP"
        Me.txtmotaSP.Size = New System.Drawing.Size(163, 103)
        Me.txtmotaSP.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Đơn Giá"
        '
        'txttenSP
        '
        Me.txttenSP.Location = New System.Drawing.Point(110, 53)
        Me.txttenSP.Name = "txttenSP"
        Me.txttenSP.Size = New System.Drawing.Size(158, 23)
        Me.txttenSP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Loại SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tên SP"
        '
        'txtgiaSP
        '
        Me.txtgiaSP.Location = New System.Drawing.Point(110, 107)
        Me.txtgiaSP.Name = "txtgiaSP"
        Me.txtgiaSP.Size = New System.Drawing.Size(158, 23)
        Me.txtgiaSP.TabIndex = 3
        '
        'cboloaiSP
        '
        Me.cboloaiSP.FormattingEnabled = True
        Me.cboloaiSP.Items.AddRange(New Object() {"T01", "T02", "T03"})
        Me.cboloaiSP.Location = New System.Drawing.Point(110, 80)
        Me.cboloaiSP.Name = "cboloaiSP"
        Me.cboloaiSP.Size = New System.Drawing.Size(158, 23)
        Me.cboloaiSP.TabIndex = 2
        '
        'frmthemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(569, 455)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmthemSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Sản Phẩm"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtmotaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttenSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgiaSP As System.Windows.Forms.TextBox
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents cboloaiSP As System.Windows.Forms.ComboBox
End Class
