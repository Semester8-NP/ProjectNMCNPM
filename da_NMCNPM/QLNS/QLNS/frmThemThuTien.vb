Imports BUS
Imports DTO
Imports Utility

Public Class frmThemThuTien
    Private khBus As KhachHangBUS
    Private qdBus As QuiDinhBUS
    Private phieuThuTienBus As PhieuThuTienBUS

    Private listKhachHang = New List(Of KhachHangDTO)
    Private kh As KhachHangDTO 'current kh

    Private Sub frmThemThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KhachHangBUS()
        kh = New KhachHangDTO()
        qdBus = New QuiDinhBUS()
        phieuThuTienBus = New PhieuThuTienBUS

        'get list khachhang
        Dim result As Result
        result = khBus.selectAll(listKhachHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Load list khachhang
        loadListKhachHang()

        'load goi y hoten khachhang
        loadDataComplete()

        'load nextID
        Dim nextID As Integer
        result = khBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaPhieuThuTien.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub loadListKhachHang()
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
    End Sub

    Private Sub loadDataComplete()
        'Get auto completement string
        Dim listStrKhachHang = New AutoCompleteStringCollection()

        For Each item As KhachHangDTO In listKhachHang
            listStrKhachHang.Add(item.HoTen)
        Next

        txtHoTen.AutoCompleteCustomSource = listStrKhachHang
    End Sub

    Private Sub dgvDanhSachKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachKhachHang.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhachHang.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhachHang.RowCount) Then
            Try
                kh = CType(dgvDanhSachKhachHang.Rows(currentRowIndex).DataBoundItem, KhachHangDTO)
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

    Private Sub txtSoTienThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoTienThu.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHoTen_LostFocus(sender As Object, e As EventArgs) Handles txtHoTen.LostFocus
        'Get list khachhang
        Dim listTemp = New List(Of KhachHangDTO)
        Dim result As Result
        result = khBus.selectALL_ByHoTen(txtHoTen.Text, listTemp)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khách hàng theo tên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        If (listTemp.Count <> 1) Then
            MessageBox.Show("Không tồn tại khách hàng này. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Get the current cell location.
        kh = listTemp.ElementAt(0)
        Dim pos As Integer
        pos = getCurrentInList(kh)

        'load dgv
        Dim clname As String
        clname = "HoTen"
        dgvDanhSachKhachHang.CurrentCell = dgvDanhSachKhachHang.Item(clname, pos)
        dgvDanhSachKhachHang.CurrentCell.Selected = True
        loadListKhachHang()
    End Sub

    Private Function getCurrentInList(kh As KhachHangDTO)
        Dim pos As Integer
        pos = 0
        For Each item As KhachHangDTO In listKhachHang
            If (kh.MaKhachHang = item.MaKhachHang) Then
                Return pos
            End If
            pos = pos + 1
        Next
        MessageBox.Show("Lấy vị trí không thành công. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return 0
    End Function

    Private Sub btnThemPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btnThemPhieuThuTien.Click
        'check data
        If (txtSoTienThu.Text < 1) Then
            MessageBox.Show("Chưa nhập số tiền thu. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSoTienThu.Focus()
            Return
        End If

        'get quidinh
        Dim quiDinh As QuiDinhDTO
        Dim listQuiDinh = New List(Of QuiDinhDTO)
        Dim result As Result
        result = qdBus.selectALL(listQuiDinh)
        If (Result.FlagResult = True) Then
            quiDinh = listQuiDinh.ElementAt(0)
        Else
            MessageBox.Show("Lấy qui định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'check quidinh
        Dim soTienThu As Double
        soTienThu = Double.Parse(txtSoTienThu.Text)
        If (quiDinh.DieuKienTienThu = 1) Then
            If (soTienThu > Double.Parse(kh.SoTienNo)) Then
                MessageBox.Show("Vi phạm qui định: Số tiền thu không vượt quá số tiền khách nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        End If

        'insert phieuthutien
        Dim phieu As PhieuThuTienDTO
        phieu = New PhieuThuTienDTO()
        phieu.MaPhieuThuTien = Integer.Parse(txtMaPhieuThuTien.Text)
        phieu.MaKhachHang = kh.MaKhachHang
        phieu.NgayThuTien = dtpNgayThuTien.Value
        phieu.SoTienThu = Integer.Parse(txtSoTienThu.Text)
        result = phieuThuTienBus.insert(phieu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            'update sotienno
            Dim soTienUpdate As Integer
            soTienUpdate = Integer.Parse(Double.Parse(kh.SoTienNo) - soTienThu)
            result = khBus.updateSoTienNo(kh.MaKhachHang, soTienUpdate)
            If (result.FlagResult = False) Then
                MessageBox.Show("update số tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Thêm phiếu thu tiền thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
    End Sub
End Class