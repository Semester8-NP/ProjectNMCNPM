Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLyThuTien
    Private khBus As KhachHangBUS
    Private phieuBus As PhieuThuTienBUS

    Private Sub frmQuanLyThuTien_Load(sender As Object, e As EventArgs) Handles Me.Load
        khBus = New KhachHangBUS()
        phieuBus = New PhieuThuTienBUS()

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
        'get khachhang
        Dim kh = CType(cbKhachHang.SelectedItem, KhachHangDTO)

        'load dgv
        loadListPhieuThuTien(kh.MaKhachHang)
    End Sub

    Private Sub loadListPhieuThuTien(iMaKhachHang As Integer)
        'get listphieuthutien
        Dim listPhieu = New List(Of PhieuThuTienDTO)
        Dim result As Result
        result = phieuBus.selectALL_ByMaKhachHang(iMaKhachHang, listPhieu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo Mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'load dgv
        dgvDanhSachPhieu.Columns.Clear()
        dgvDanhSachPhieu.DataSource = Nothing

        dgvDanhSachPhieu.AutoGenerateColumns = False
        dgvDanhSachPhieu.AllowUserToAddRows = False
        dgvDanhSachPhieu.DataSource = listPhieu

        Dim clMaPhieuThuTien = New DataGridViewTextBoxColumn()
        clMaPhieuThuTien.Name = "MaPhieuThuTien"
        clMaPhieuThuTien.HeaderText = "Mã phiếu thu tiền"
        clMaPhieuThuTien.DataPropertyName = "MaPhieuThuTien"
        dgvDanhSachPhieu.Columns.Add(clMaPhieuThuTien)

        Dim clMaKhachHang = New DataGridViewTextBoxColumn()
        clMaKhachHang.Name = "MaKhachHang"
        clMaKhachHang.HeaderText = "Mã khách hàng"
        clMaKhachHang.DataPropertyName = "MaKhachHang"
        dgvDanhSachPhieu.Columns.Add(clMaKhachHang)

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        clNgayThuTien.Name = "NgayThuTien"
        clNgayThuTien.HeaderText = "Ngày thu tiền"
        clNgayThuTien.DataPropertyName = "NgayThuTien"
        dgvDanhSachPhieu.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số tiền thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvDanhSachPhieu.Columns.Add(clSoTienThu)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachPhieu.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub dgvDanhSachPhieu_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachPhieu.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachPhieu.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhieu.RowCount) Then
            Try
                Dim phieu = CType(dgvDanhSachPhieu.Rows(currentRowIndex).DataBoundItem, PhieuThuTienDTO)
                txtMaPhieuThuTien.Text = phieu.MaKhachHang
                txtSoTienThu.Text = phieu.SoTienThu
                dtpNgayThuTien.Value = phieu.NgayThuTien
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class