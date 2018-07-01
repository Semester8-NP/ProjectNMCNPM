<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuNhapSach
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
        Me.txtMaPhieuNhapSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.dgvDanhSachSach = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnThemSach = New System.Windows.Forms.Button()
        Me.btnThemPhieuNhapSach = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã phiếu nhập sách:"
        '
        'txtMaPhieuNhapSach
        '
        Me.txtMaPhieuNhapSach.Enabled = False
        Me.txtMaPhieuNhapSach.Location = New System.Drawing.Point(200, 12)
        Me.txtMaPhieuNhapSach.Name = "txtMaPhieuNhapSach"
        Me.txtMaPhieuNhapSach.Size = New System.Drawing.Size(138, 20)
        Me.txtMaPhieuNhapSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày nhập:"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(200, 38)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(138, 20)
        Me.dtpNgayNhap.TabIndex = 3
        '
        'dgvDanhSachSach
        '
        Me.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSach.Location = New System.Drawing.Point(12, 64)
        Me.dgvDanhSachSach.Name = "dgvDanhSachSach"
        Me.dgvDanhSachSach.Size = New System.Drawing.Size(451, 156)
        Me.dgvDanhSachSach.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(171, 233)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(167, 20)
        Me.txtTenSach.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Thể loại:"
        '
        'cbTheLoai
        '
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(171, 259)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(167, 21)
        Me.cbTheLoai.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(171, 286)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(167, 20)
        Me.txtTacGia.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Số lương:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(171, 312)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(167, 20)
        Me.txtSoLuong.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(171, 338)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(167, 20)
        Me.txtDonGia.TabIndex = 10
        '
        'btnThemSach
        '
        Me.btnThemSach.Location = New System.Drawing.Point(200, 364)
        Me.btnThemSach.Name = "btnThemSach"
        Me.btnThemSach.Size = New System.Drawing.Size(75, 23)
        Me.btnThemSach.TabIndex = 11
        Me.btnThemSach.Text = "Thêm sách"
        Me.btnThemSach.UseVisualStyleBackColor = True
        '
        'btnThemPhieuNhapSach
        '
        Me.btnThemPhieuNhapSach.Location = New System.Drawing.Point(165, 393)
        Me.btnThemPhieuNhapSach.Name = "btnThemPhieuNhapSach"
        Me.btnThemPhieuNhapSach.Size = New System.Drawing.Size(147, 23)
        Me.btnThemPhieuNhapSach.TabIndex = 12
        Me.btnThemPhieuNhapSach.Text = "Thêm phiếu nhập sách"
        Me.btnThemPhieuNhapSach.UseVisualStyleBackColor = True
        '
        'frmThemPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 426)
        Me.Controls.Add(Me.btnThemPhieuNhapSach)
        Me.Controls.Add(Me.btnThemSach)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTheLoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDanhSachSach)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaPhieuNhapSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemPhieuNhapSach"
        Me.Text = "THÊM PHIẾU NHẬP SÁCH"
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaPhieuNhapSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents dgvDanhSachSach As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnThemSach As Button
    Friend WithEvents btnThemPhieuNhapSach As Button
End Class
