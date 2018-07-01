<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbTheLoaiCapNhat = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thể loại:"
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Location = New System.Drawing.Point(12, 39)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.Size = New System.Drawing.Size(675, 208)
        Me.dgvDanhSach.TabIndex = 1
        '
        'cbTheLoai
        '
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(286, 12)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(192, 21)
        Me.cbTheLoai.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(286, 253)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(192, 20)
        Me.txtMaSach.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(286, 279)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(192, 20)
        Me.txtTenSach.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thể loại:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(286, 331)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(192, 20)
        Me.txtTacGia.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(286, 357)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.ReadOnly = True
        Me.txtSoLuong.Size = New System.Drawing.Size(192, 20)
        Me.txtSoLuong.TabIndex = 4
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(212, 390)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(47, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Đơn giá:"
        '
        'cbTheLoaiCapNhat
        '
        Me.cbTheLoaiCapNhat.FormattingEnabled = True
        Me.cbTheLoaiCapNhat.Location = New System.Drawing.Point(286, 305)
        Me.cbTheLoaiCapNhat.Name = "cbTheLoaiCapNhat"
        Me.cbTheLoaiCapNhat.Size = New System.Drawing.Size(192, 21)
        Me.cbTheLoaiCapNhat.TabIndex = 5
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(286, 383)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(192, 20)
        Me.txtDonGia.TabIndex = 4
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(313, 417)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'frmQuanLySach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 451)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.cbTheLoaiCapNhat)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTheLoai)
        Me.Controls.Add(Me.dgvDanhSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuanLySach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ SÁCH"
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents label7 As Label
    Friend WithEvents cbTheLoaiCapNhat As ComboBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnCapNhat As Button
End Class
