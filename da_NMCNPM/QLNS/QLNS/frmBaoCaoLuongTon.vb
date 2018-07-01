Imports BUS
Imports DTO
Imports Utility


Public Class frmBaoCaoLuongTon
    Private khBus As KhachHangBUS

    Private Sub frmBaoCaoLuongTon_Load(sender As Object, e As EventArgs) Handles Me.Load
        khBus = New KhachHangBUS()

        txtDieuKien.Text = 0
    End Sub

    Private Sub loadListKhachHang(iDieuKien As Integer)
        Dim listKhachHang = New List(Of KhachHangDTO)
        Dim result As Result
        result = khBus.selectALL_ByDieuKien(iDieuKien, listKhachHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachKhachHang.Columns.Clear()
        dgvDanhSachKhachHang.DataSource = Nothing

        dgvDanhSachKhachHang.AutoGenerateColumns = False
        dgvDanhSachKhachHang.AllowUserToAddRows = False
        dgvDanhSachKhachHang.DataSource = listKhachHang

        Dim clMaKhachHang = New DataGridViewTextBoxColumn()
        clMaKhachHang.Name = "MaKhachHang"
        clMaKhachHang.HeaderText = "Mã khách hàng"
        clMaKhachHang.DataPropertyName = "MaKhachHang"
        dgvDanhSachKhachHang.Columns.Add(clMaKhachHang)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "HoTen"
        clHoTen.HeaderText = "Họ tên"
        clHoTen.DataPropertyName = "HoTen"
        dgvDanhSachKhachHang.Columns.Add(clHoTen)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvDanhSachKhachHang.Columns.Add(clDienThoai)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvDanhSachKhachHang.Columns.Add(clEmail)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvDanhSachKhachHang.Columns.Add(clDiaChi)

        Dim clSoTienNo = New DataGridViewTextBoxColumn()
        clSoTienNo.Name = "SoTienNo"
        clSoTienNo.HeaderText = "Số tiền nợ"
        clSoTienNo.DataPropertyName = "SoTienNo"
        dgvDanhSachKhachHang.Columns.Add(clSoTienNo)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachKhachHang.DataSource)
        myCurrencyManager.Refresh()

        If (listKhachHang.Count < 1) Then
            txtMaKhachHang.Text = String.Empty
            txtHoTen.Text = String.Empty
            txtDienThoai.Text = String.Empty
            txtEmail.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtSoTienNo.Text = String.Empty
        End If
    End Sub

    Private Sub dgvDanhSachKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachKhachHang.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhachHang.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhachHang.RowCount) Then
            Try
                Dim kh = CType(dgvDanhSachKhachHang.Rows(currentRowIndex).DataBoundItem, KhachHangDTO)
                txtMaKhachHang.Text = kh.MaKhachHang
                txtHoTen.Text = kh.HoTen
                txtDienThoai.Text = kh.DienThoai
                txtEmail.Text = kh.Email
                txtDiaChi.Text = kh.DiaChi
                txtSoTienNo.Text = kh.SoTienNo
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub txtDieuKien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDieuKien.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDieuKien_TextChanged(sender As Object, e As EventArgs) Handles txtDieuKien.TextChanged
        If (txtDieuKien.Text.Length > 0) Then
            loadListKhachHang(Integer.Parse(txtDieuKien.Text))
        End If
    End Sub
End Class