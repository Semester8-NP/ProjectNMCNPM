Imports BUS
Imports DTO
Imports Utility

Public Class frmThemHoaDon
    Private hoaDonBus As HoaDonBUS
    Private banSachBus As BanSachBUS
    Private sachBus As SachBUS
    Private khachHangBus As KhachHangBUS
    Private quiDinhBus As QuiDinhBUS
    Private theLoaiBus As TheLoaiBUS

    Private listSach As List(Of SachDTO)
    Private sachId As Integer
    Private quiDinh As QuiDinhDTO
    Dim sach As SachDTO 'load data

    Dim kh As KhachHangDTO 'check khachhang
    Dim xacMinh As Boolean

    Private Sub frmThemHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        hoaDonBus = New HoaDonBUS()
        banSachBus = New BanSachBUS()
        sachBus = New SachBUS()
        khachHangBus = New KhachHangBUS()
        quiDinhBus = New QuiDinhBUS()
        theLoaiBus = New TheLoaiBUS()

        listSach = New List(Of SachDTO)
        quiDinh = New QuiDinhDTO()

        kh = New KhachHangDTO()
        xacMinh = False

        'Load today
        dtpNgayLap.Value = DateTime.Today

        ' Get Next ID HoaDon
        Dim nextID As Integer
        Dim result As Result
        result = hoaDonBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaHoaDon.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Get quy dinh
        Dim listQuiDinh = New List(Of QuiDinhDTO)
        result = quiDinhBus.selectALL(listQuiDinh)
        If (result.FlagResult = True) Then
            quiDinh = listQuiDinh.ElementAt(0)
        Else
            MessageBox.Show("Lấy qui định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'load goi y ten sach
        loadDataComplete()

        'Construct listSach and SachId
        listSach.Clear()
        sachId = 0
    End Sub

    Private Sub loadDataComplete()
        'Get list Sach
        Dim listTempSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll(listTempSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Get auto completement string
        Dim listStrSach = New AutoCompleteStringCollection()

        For Each item As SachDTO In listTempSach
            listStrSach.Add(item.TenSach)
        Next

        txtTenSach.AutoCompleteCustomSource = listStrSach
    End Sub

    Private Sub txtTenSach_LostFocus(sender As Object, e As EventArgs) Handles txtTenSach.LostFocus
        'Get list Sach
        Dim listTemp = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll_ByTenSach(txtTenSach.Text, listTemp)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả sách theo tên sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        If (listTemp.Count <> 1) Then
            MessageBox.Show("Không tồn tại sách này. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'load data
        sach = listTemp.ElementAt(0)
        txtMaSach.Text = sach.MaSach
        txtTacGia.Text = sach.TacGia
        txtDonGia.Text = sach.DonGia

        'get ten the loai
        Dim listTL = New List(Of TheLoaiDTO)
        result = theLoaiBus.selectAll_ByMaTheLoai(sach.MaTheLoai, listTL)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thể loại không thành công. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        Dim tl As TheLoaiDTO
        tl = listTL.ElementAt(0)
        txtTheLoai.Text = tl.TenTheLoai
    End Sub

    Private Sub btnThemSach_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click
        'check data
        If (txtMaSach.Text.Length < 1) Then
            MessageBox.Show("Sách không hợp lệ. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenSach.Focus()
            Return
        End If

        If (txtSoLuong.Text.Length < 1) Then
            MessageBox.Show("Chưa nhập số lượng. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSoLuong.Focus()
            Return
        End If

        'check quiDinh
        If (sach.SoLuong - Integer.Parse(txtSoLuong.Text) < quiDinh.DieuKienSoLuongBan) Then
            MessageBox.Show("Sai qui định bán hàng. Số lượng sách này được bán tối đa là: " + (sach.SoLuong - quiDinh.DieuKienSoLuongBan).ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSoLuong.Focus()
            Return
        End If

        sach.SoLuong = Integer.Parse(txtSoLuong.Text)
        listSach.Add(sach) ' add list
        sachId = sachId + 1 ' update sach id

        'load list sach
        loadListSach(listSach)
    End Sub

    Public Sub loadListSach(listSach As List(Of SachDTO))
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

        'load view textbox
        txtTenSach.Text = String.Empty
        txtTacGia.Text = String.Empty
        txtSoLuong.Text = String.Empty
        txtDonGia.Text = String.Empty
        txtMaSach.Text = String.Empty
        txtTheLoai.Text = String.Empty
    End Sub

    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
                    Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnXacMinh_Click(sender As Object, e As EventArgs) Handles btnXacMinh.Click
        If (xacMinh = False) Then
            'check data khachhang
            If (txtHoTen.Text.Length < 1) Then
                MessageBox.Show("Chưa nhập tên khách hàng. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHoTen.Focus()
                Return
            End If

            If (txtDienThoai.Text.Length < 1) Then
                MessageBox.Show("Chưa nhập số điện thoại khách hàng. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHoTen.Focus()
                Return
            End If

            'Kiem tra csdl khachhang
            Dim listTemp = New List(Of KhachHangDTO)
            Dim result As Result
            result = khachHangBus.isExists(txtHoTen.Text, txtDienThoai.Text, listTemp)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy khách hàng kiểm tra không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            'Khach hang moi
            If (listTemp.Count = 0) Then
                'get next id khach hang
                Dim nextID As Integer
                result = khachHangBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    kh.MaKhachHang = nextID
                Else
                    MessageBox.Show("Lấy ID kế tiếp của khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                'map data
                kh.HoTen = txtHoTen.Text
                kh.DienThoai = txtDienThoai.Text
                kh.DiaChi = txtDiaChi.Text
                kh.Email = txtEmail.Text
                kh.SoTienNo = 0

                'insert db
                result = khachHangBus.insert(kh)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Thêm Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                'show thong tin
                showThongTinKhachHang(kh)
            End If

            'khach hang cu
            If (listTemp.Count = 1) Then
                'get khachhang
                kh = listTemp.ElementAt(0)

                'show thong tin
                showThongTinKhachHang(kh)
            End If

            If (kh.SoTienNo > quiDinh.DieuKienTienNo) Then
                MessageBox.Show("Khách hàng này có số tiền nợ vượt quá số nợ qui định là : " + quiDinh.DieuKienTienNo.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            Else
                'khoa du lieu
                blockDuLieu(True)

                'Pre xac minh
                btnXacMinh.Text = "Pre-Xác minh"
                xacMinh = True
            End If
        Else
            'mo khoa du lieu
            blockDuLieu(False)

            'xac minh
            btnXacMinh.Text = "Xác minh"
            xacMinh = False
        End If
    End Sub

    Private Sub showThongTinKhachHang(kg As KhachHangDTO)
        txtMaKhachHang.Text = kh.MaKhachHang
        txtHoTen.Text = kh.HoTen
        txtDienThoai.Text = kh.DienThoai
        txtDiaChi.Text = kh.DiaChi
        txtEmail.Text = kh.Email
        txtSoTienNo.Text = kh.SoTienNo
    End Sub

    Private Sub blockDuLieu(b As Boolean)
        txtHoTen.ReadOnly = b
        txtDienThoai.ReadOnly = b
        txtDiaChi.ReadOnly = b
        txtEmail.ReadOnly = b
    End Sub

    Private Sub btnThemHoaDon_Click(sender As Object, e As EventArgs) Handles btnThemHoaDon.Click
        Dim result As Result

        'check data hoadon
        If (listSach.Count < 1) Then
            MessageBox.Show("Hóa đơn chưa có dữ liệu. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'check xac minh khach hang
        If (xacMinh = False) Then
            MessageBox.Show("Chưa xác minh dữ liệu khách hàng. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'insert hoadon to db
        Dim hoaDon As HoaDonDTO
        hoaDon = New HoaDonDTO()

        hoaDon.MaHoaDon = Integer.Parse(txtMaHoaDon.Text)
        hoaDon.MaKhachHang = kh.MaKhachHang
        hoaDon.NgapLap = dtpNgayLap.Value

        result = hoaDonBus.insert(hoaDon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'insert chi tiet hoa don
        For Each item As SachDTO In listSach
            result = banSachBus.insert(hoaDon, item)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Chi tiết hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            'update so luong sach
            Dim soLuongUpdate As Integer
            Dim soLuongDB As Integer
            result = sachBus.selectSoLuong_ByMaSach(item.MaSach, soLuongDB)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy số lượng theo mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            soLuongUpdate = soLuongDB - item.SoLuong

            result = sachBus.updateSoLuong(item.MaSach, soLuongUpdate)
            If (result.FlagResult = False) Then
                MessageBox.Show("Update số lượng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            'update so tien no
            Dim soTienUpdate As Integer
            Dim soTienDB As Integer
            result = khachHangBus.selectSoTienNo_ByMaKhachHang(hoaDon.MaKhachHang, soTienDB)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy số lượng theo mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            soTienUpdate = soTienDB + (item.DonGia * item.SoLuong)

            result = khachHangBus.updateSoTienNo(hoaDon.MaKhachHang, soTienUpdate)
            If (result.FlagResult = False) Then
                MessageBox.Show("Update số tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        Next

        'Them hoa don thanh cong
        MessageBox.Show("Thêm hóa đơn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class