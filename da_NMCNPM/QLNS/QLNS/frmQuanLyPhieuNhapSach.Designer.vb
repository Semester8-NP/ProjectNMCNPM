<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhieuNhapSach
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
        Me.cbMaPhieuNhapSach = New System.Windows.Forms.ComboBox()
        Me.dgvDanhSachSach = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.cbTheLoaiCapNhat = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã phiếu nhập sách:"
        '
        'cbMaPhieuNhapSach
        '
        Me.cbMaPhieuNhapSach.FormattingEnabled = True
        Me.cbMaPhieuNhapSach.Location = New System.Drawing.Point(134, 12)
        Me.cbMaPhieuNhapSach.Name = "cbMaPhieuNhapSach"
        Me.cbMaPhieuNhapSach.Size = New System.Drawing.Size(88, 21)
        Me.cbMaPhieuNhapSach.TabIndex = 1
        '
        'dgvDanhSachSach
        '
        Me.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSach.Location = New System.Drawing.Point(24, 39)
        Me.dgvDanhSachSach.Name = "dgvDanhSachSach"
        Me.dgvDanhSachSach.Size = New System.Drawing.Size(473, 150)
        Me.dgvDanhSachSach.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ngày nhập:"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Enabled = False
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(356, 13)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(96, 20)
        Me.dtpNgayNhap.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(179, 202)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(212, 20)
        Me.txtMaSach.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(179, 228)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(212, 20)
        Me.txtTenSach.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Thể loại:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(179, 280)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(212, 20)
        Me.txtTacGia.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(179, 306)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(212, 20)
        Me.txtSoLuong.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(179, 332)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(212, 20)
        Me.txtDonGia.TabIndex = 7
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(204, 360)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 8
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'cbTheLoaiCapNhat
        '
        Me.cbTheLoaiCapNhat.FormattingEnabled = True
        Me.cbTheLoaiCapNhat.Location = New System.Drawing.Point(179, 253)
        Me.cbTheLoaiCapNhat.Name = "cbTheLoaiCapNhat"
        Me.cbTheLoaiCapNhat.Size = New System.Drawing.Size(212, 21)
        Me.cbTheLoaiCapNhat.TabIndex = 9
        '
        'frmQuanLyPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 395)
        Me.Controls.Add(Me.cbTheLoaiCapNhat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachSach)
        Me.Controls.Add(Me.cbMaPhieuNhapSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuanLyPhieuNhapSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ PHIẾU NHẬP SÁCH"
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaPhieuNhapSach As ComboBox
    Friend WithEvents dgvDanhSachSach As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbTheLoaiCapNhat As ComboBox
End Class
