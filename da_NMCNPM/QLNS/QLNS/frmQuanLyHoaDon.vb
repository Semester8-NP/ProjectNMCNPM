Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLyHoaDon
    Private khBus As KhachHangBUS
    Private hdBus As HoaDonBUS
    Private banSachBus As BanSachBUS
    Private tlBus As TheLoaiBUS

    Private Sub frmQuanLyHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        khBus = New KhachHangBUS()
        hdBus = New HoaDonBUS()
        banSachBus = New BanSachBUS()
        tlBus = New TheLoaiBUS()

        Dim listKhachHang = New List(Of KhachHangDTO)
        Dim result As Result
        result = khBus.selectAll(listKhachHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbKhachHang.DataSource = New BindingSource(listKhachHang, String.Empty)
        cbKhachHang.DisplayMember = "HoTen"
        cbKhachHang.ValueMember = "MaKhachHang"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbKhachHang.DataSource)
        myCurrencyManager.Refresh()
        If (listKhachHang.Count > 0) Then
            cbKhachHang.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKhachHang.SelectedIndexChanged
        Dim listHoaDon = New List(Of HoaDonDTO)
        Dim result As Result

        'get maKhachHang
        Dim khachHang = CType(cbKhachHang.SelectedItem, KhachHangDTO)

        'get listHoadon
        result = hdBus.selectAll_ByMaKhachHang(khachHang.MaKhachHang, listHoaDon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Hóa đơn theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'show combobox
        cbMaHoaDon.DataSource = New BindingSource(listHoaDon, String.Empty)
        cbMaHoaDon.DisplayMember = "MaHoaDon"
        cbMaHoaDon.ValueMember = "MaHoaDon"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbMaHoaDon.DataSource)
        myCurrencyManager.Refresh()
        If (listHoaDon.Count > 0) Then
            cbMaHoaDon.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbMaHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaHoaDon.SelectedIndexChanged
        'get maHoaDon
        Dim hoaDon = CType(cbMaHoaDon.SelectedItem, HoaDonDTO)

        'load dgv
        loadChiTietHoaDon(hoaDon.MaHoaDon)

        'load dtp
        dtpNgayLap.Value = hoaDon.NgapLap
    End Sub

    Private Sub loadChiTietHoaDon(iMaHoaDon As Integer)
        'get listSach
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = banSachBus.selectSach_ByMaHoaDon(iMaHoaDon, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo Mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'get chitiethoadon->soluong sachban
        Dim listChiTiet = New List(Of BanSachDTO)
        result = banSachBus.selectAll_ByMaHoaDon(iMaHoaDon, listChiTiet)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi tiết theo Mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'update soluongban
        Dim i As Integer
        i = 0
        For Each item As SachDTO In listSach
            item.SoLuong = listChiTiet.ElementAt(i).SoLuong
            i = i + 1
        Next

        'load dgv
        dgvDanhSachSach.Columns.Clear()
        dgvDanhSachSach.DataSource = Nothing

        dgvDanhSachSach.AutoGenerateColumns = False
        dgvDanhSachSach.AllowUserToAddRows = False
        dgvDanhSachSach.DataSource = listSach

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvDanhSachSach.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên sách"
        clTenSach.DataPropertyName = "TenSach"
        dgvDanhSachSach.Columns.Add(clTenSach)

        'Dim clTheLoai = New DataGridViewTextBoxColumn()
        'clTheLoai.Name = "TheLoai"
        'clTheLoai.HeaderText = "Thể loại"
        'clTheLoai.DataPropertyName = "TheLoai"
        'dgvDanhSachSach.Columns.Add(clTheLoai)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "TacGia"
        clTacGia.HeaderText = "Tác giả"
        clTacGia.DataPropertyName = "TacGia"
        dgvDanhSachSach.Columns.Add(clTacGia)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số lượng"
        clSoLuong.DataPropertyName = "SoLuong"
        dgvDanhSachSach.Columns.Add(clSoLuong)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvDanhSachSach.Columns.Add(clDonGia)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub dgvDanhSachSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachSach.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachSach.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachSach.RowCount) Then
            Try
                Dim sach = CType(dgvDanhSachSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = sach.MaSach
                txtTenSach.Text = sach.TenSach
                txtTacGia.Text = sach.TacGia
                txtSoLuong.Text = sach.SoLuong
                txtDonGia.Text = sach.DonGia
                txtTheLoai.Text = getTenTheLoai(sach.MaTheLoai)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Function getTenTheLoai(iMaTheLoai As Integer) As String
        Dim tl As TheLoaiDTO
        tl = New TheLoaiDTO()
        Dim result As Result
        result = tlBus.select_ByMaTheLoai(iMaTheLoai, tl)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thể loại theo Mã thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return 0
        End If
        Return tl.TenTheLoai
    End Function
End Class