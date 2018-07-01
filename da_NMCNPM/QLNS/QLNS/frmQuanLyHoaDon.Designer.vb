<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaHoaDon = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.dgvDanhSachSach = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Khách hàng:"
        '
        'cbKhachHang
        '
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(87, 12)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(169, 21)
        Me.cbKhachHang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã hóa đơn:"
        '
        'cbMaHoaDon
        '
        Me.cbMaHoaDon.FormattingEnabled = True
        Me.cbMaHoaDon.Location = New System.Drawing.Point(333, 12)
        Me.cbMaHoaDon.Name = "cbMaHoaDon"
        Me.cbMaHoaDon.Size = New System.Drawing.Size(59, 21)
        Me.cbMaHoaDon.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày lập:"
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.Enabled = False
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLap.Location = New System.Drawing.Point(456, 14)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(96, 20)
        Me.dtpNgayLap.TabIndex = 3
        '
        'dgvDanhSachSach
        '
        Me.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSach.Location = New System.Drawing.Point(19, 40)
        Me.dgvDanhSachSach.Name = "dgvDanhSachSach"
        Me.dgvDanhSachSach.Size = New System.Drawing.Size(533, 172)
        Me.dgvDanhSachSach.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mã sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(195, 229)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(150, 20)
        Me.txtMaSach.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(195, 255)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.ReadOnly = True
        Me.txtTenSach.Size = New System.Drawing.Size(150, 20)
        Me.txtTenSach.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Thể loại:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(195, 307)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.ReadOnly = True
        Me.txtTacGia.Size = New System.Drawing.Size(150, 20)
        Me.txtTacGia.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(195, 333)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(150, 20)
        Me.txtSoLuong.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(195, 359)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(150, 20)
        Me.txtDonGia.TabIndex = 6
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(86, 385)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 8
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(382, 385)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Location = New System.Drawing.Point(195, 281)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.ReadOnly = True
        Me.txtTheLoai.Size = New System.Drawing.Size(150, 20)
        Me.txtTheLoai.TabIndex = 9
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(227, 385)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmQuanLyHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 420)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTheLoai)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvDanhSachSach)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMaHoaDon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuanLyHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ HÓA ĐƠN"
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMaHoaDon As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgayLap As DateTimePicker
    Friend WithEvents dgvDanhSachSach As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents btnThem As Button
End Class
