<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblmes2 = New System.Windows.Forms.Label()
        Me.btnxoaPW = New System.Windows.Forms.Button()
        Me.btnxoaID = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(47, 149)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(93, 32)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Đăng nhập"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnclose.Location = New System.Drawing.Point(203, 149)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(88, 32)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Thoát"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(128, 45)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(191, 26)
        Me.txtID.TabIndex = 0
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtPW.Location = New System.Drawing.Point(128, 91)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(191, 26)
        Me.txtPW.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mật khẩu"
        '
        'lblmes
        '
        Me.lblmes.AutoSize = True
        Me.lblmes.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblmes.ForeColor = System.Drawing.Color.Red
        Me.lblmes.Location = New System.Drawing.Point(131, 126)
        Me.lblmes.Name = "lblmes"
        Me.lblmes.Size = New System.Drawing.Size(0, 16)
        Me.lblmes.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblmes2)
        Me.GroupBox1.Controls.Add(Me.btnxoaPW)
        Me.GroupBox1.Controls.Add(Me.btnxoaID)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblmes)
        Me.GroupBox1.Controls.Add(Me.txtPW)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 190)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đăng nhập"
        '
        'lblmes2
        '
        Me.lblmes2.AutoSize = True
        Me.lblmes2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblmes2.ForeColor = System.Drawing.Color.Red
        Me.lblmes2.Location = New System.Drawing.Point(43, 127)
        Me.lblmes2.Name = "lblmes2"
        Me.lblmes2.Size = New System.Drawing.Size(0, 16)
        Me.lblmes2.TabIndex = 8
        '
        'btnxoaPW
        '
        Me.btnxoaPW.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnxoaPW.Location = New System.Drawing.Point(325, 90)
        Me.btnxoaPW.Name = "btnxoaPW"
        Me.btnxoaPW.Size = New System.Drawing.Size(45, 26)
        Me.btnxoaPW.TabIndex = 7
        Me.btnxoaPW.Text = "Xóa"
        Me.btnxoaPW.UseVisualStyleBackColor = True
        '
        'btnxoaID
        '
        Me.btnxoaID.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnxoaID.Location = New System.Drawing.Point(325, 45)
        Me.btnxoaID.Name = "btnxoaID"
        Me.btnxoaID.Size = New System.Drawing.Size(45, 26)
        Me.btnxoaID.TabIndex = 7
        Me.btnxoaID.Text = "Xóa"
        Me.btnxoaID.UseVisualStyleBackColor = True
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 211)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.Name = "frmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập Xì Trum"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblmes As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnxoaPW As System.Windows.Forms.Button
    Friend WithEvents btnxoaID As System.Windows.Forms.Button
    Friend WithEvents lblmes2 As System.Windows.Forms.Label

End Class
