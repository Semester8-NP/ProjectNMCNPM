Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLyPhieuNhapSach
    Private phieuNhapSachBus As PhieuNhapSachBUS
    Private nhapSachBus As NhapSachBUS
    Private sachBus As SachBUS
    Private theLoaiBus As TheLoaiBUS

    Private Sub frmQuanLyPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles Me.Load
        phieuNhapSachBus = New PhieuNhapSachBUS()
        nhapSachBus = New NhapSachBUS()
        sachBus = New SachBUS()
        theLoaiBus = New TheLoaiBUS()

        'Load list mã phiếu nhập sách
        Dim listPhieuNhapSach = New List(Of PhieuNhapSachDTO)
        Dim result As Result
        result = phieuNhapSachBus.selectAll(listPhieuNhapSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaPhieuNhapSach.DataSource = New BindingSource(listPhieuNhapSach, String.Empty)
        cbMaPhieuNhapSach.DisplayMember = "MaPhieuNhapSach"
        cbMaPhieuNhapSach.ValueMember = "MaPhieuNhapSach"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbMaPhieuNhapSach.DataSource)
        myCurrencyManager.Refresh()
        If (listPhieuNhapSach.Count > 0) Then
            cbMaPhieuNhapSach.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbMaPhieuNhapSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhieuNhapSach.SelectedIndexChanged
        Try
            Dim phieuNhapSach = CType(cbMaPhieuNhapSach.SelectedItem, PhieuNhapSachDTO)
            loadListPhieuNhapSach(phieuNhapSach.MaPhieuNhapSach)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Sub loadListPhieuNhapSach(maPhieuNhapSach As Integer)
        'Load ngay nhap sach
        Dim phieuNhapSach = CType(cbMaPhieuNhapSach.SelectedItem, PhieuNhapSachDTO)
        dtpNgayNhap.Value = phieuNhapSach.NgayNhap

        'Load list nhap sach
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = nhapSachBus.selectSach_ByMaPhieuNhapSach(maPhieuNhapSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo Mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

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

        'Dim clTheLoai = New DataGridView()

        Dim clTheLoai = New DataGridViewTextBoxColumn()
        clTheLoai.Name = "MaTheLoai"
        clTheLoai.HeaderText = "Mã Thể loại"
        clTheLoai.DataPropertyName = "MaTheLoai"
        dgvDanhSachSach.Columns.Add(clTheLoai)

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
                'Load list thể loại
                Dim listTheLoai = New List(Of TheLoaiDTO)
                Dim result As Result
                result = theLoaiBus.selectAll(listTheLoai)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy danh sách thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                cbTheLoaiCapNhat.DataSource = New BindingSource(listTheLoai, String.Empty)
                cbTheLoaiCapNhat.DisplayMember = "TenTheLoai"
                cbTheLoaiCapNhat.ValueMember = "MaTheLoai"

                'Load du lieu
                Dim sach = CType(dgvDanhSachSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = sach.MaSach
                txtTenSach.Text = sach.TenSach
                txtTacGia.Text = sach.TacGia
                txtSoLuong.Text = sach.SoLuong
                txtDonGia.Text = sach.DonGia
                cbTheLoaiCapNhat.SelectedValue = sach.MaTheLoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class