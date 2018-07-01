<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemThuTien
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThuTien = New System.Windows.Forms.TextBox()
        Me.dgvDanhSachKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnThemPhieuThuTien = New System.Windows.Forms.Button()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã phiếu thu tiền:"
        '
        'txtMaPhieuThuTien
        '
        Me.txtMaPhieuThuTien.Enabled = False
        Me.txtMaPhieuThuTien.Location = New System.Drawing.Point(254, 423)
        Me.txtMaPhieuThuTien.Name = "txtMaPhieuThuTien"
        Me.txtMaPhieuThuTien.Size = New System.Drawing.Size(152, 20)
        Me.txtMaPhieuThuTien.TabIndex = 3
        '
        'dgvDanhSachKhachHang
        '
        Me.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachHang.Location = New System.Drawing.Point(16, 14)
        Me.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang"
        Me.dgvDanhSachKhachHang.Size = New System.Drawing.Size(603, 164)
        Me.dgvDanhSachKhachHang.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày thu tiền: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Số tiền thu:"
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(254, 475)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(152, 20)
        Me.txtSoTienThu.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mã khách hàng:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Enabled = False
        Me.txtMaKhachHang.Location = New System.Drawing.Point(254, 218)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(152, 20)
        Me.txtMaKhachHang.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Họ tên:"
        '
        'txtHoTen
        '
        Me.txtHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtHoTen.Location = New System.Drawing.Point(254, 244)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(152, 20)
        Me.txtHoTen.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Điện thoại:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(254, 270)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(152, 20)
        Me.txtDienThoai.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(169, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Địa chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.AcceptsReturn = True
        Me.txtDiaChi.Location = New System.Drawing.Point(254, 296)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(152, 20)
        Me.txtDiaChi.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(254, 322)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(152, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 355)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Số tiền nợ:"
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Enabled = False
        Me.txtSoTienNo.Location = New System.Drawing.Point(254, 348)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.Size = New System.Drawing.Size(152, 20)
        Me.txtSoTienNo.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(234, 189)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "THÔNG TIN KHÁCH HÀNG"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(239, 378)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "---------------------------------------"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(224, 398)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(157, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "THÔNG TIN PHIẾU THU TIỀN"
        '
        'btnThemPhieuThuTien
        '
        Me.btnThemPhieuThuTien.Location = New System.Drawing.Point(229, 501)
        Me.btnThemPhieuThuTien.Name = "btnThemPhieuThuTien"
        Me.btnThemPhieuThuTien.Size = New System.Drawing.Size(134, 23)
        Me.btnThemPhieuThuTien.TabIndex = 11
        Me.btnThemPhieuThuTien.Text = "Thêm phiếu thu tiền"
        Me.btnThemPhieuThuTien.UseVisualStyleBackColor = True
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(254, 449)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(152, 20)
        Me.dtpNgayThuTien.TabIndex = 12
        '
        'frmThemThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 533)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.btnThemPhieuThuTien)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtSoTienNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMaKhachHang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDanhSachKhachHang)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.txtMaPhieuThuTien)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmThemThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THÊM PHIẾU THU TIỀN"
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaPhieuThuTien As TextBox
    Friend WithEvents dgvDanhSachKhachHang As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnThemPhieuThuTien As Button
    Friend WithEvents dtpNgayThuTien As DateTimePicker
End Class
