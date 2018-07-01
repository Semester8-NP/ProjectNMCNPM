Imports BUS
Imports DTO
Imports Utility

Public Class frmThemPhieuNhapSach
    Private phieuNhapSachBus As PhieuNhapSachBUS
    Private nhapSachBus As NhapSachBUS
    Private sachBus As SachBUS
    Private theLoaiBus As TheLoaiBUS
    Private quiDinhBus As QuiDinhBUS

    Private listSach As List(Of SachDTO)
    Private sachId As Integer
    Private quiDinh As QuiDinhDTO

    Private Sub frmThemPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles Me.Load
        phieuNhapSachBus = New PhieuNhapSachBUS()
        nhapSachBus = New NhapSachBUS()
        sachBus = New SachBUS()
        theLoaiBus = New TheLoaiBUS()
        quiDinhBus = New QuiDinhBUS()
        listSach = New List(Of SachDTO)

        ' Get Next ID PhieuNhapSach
        Dim nextID As Integer
        Dim result As Result
        result = phieuNhapSachBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaPhieuNhapSach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Get Next ID Sach
        result = sachBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            sachId = nextID
        Else
            MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Load list thể loại
        Dim listTheLoai = New List(Of TheLoaiDTO)
        result = theLoaiBus.selectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbTheLoai.DataSource = New BindingSource(listTheLoai, String.Empty)
        cbTheLoai.DisplayMember = "TenTheLoai"
        cbTheLoai.ValueMember = "MaTheLoai"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTheLoai.DataSource)
        myCurrencyManager.Refresh()
        If (listTheLoai.Count > 0) Then
            cbTheLoai.SelectedIndex = 0
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
    End Sub

    Private Sub btnThemSach_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click
        Dim result As Result
        Dim sach As SachDTO
        sach = New SachDTO()

        '1. Check data
        If (txtTenSach.Text.Length < 1) Then
            MessageBox.Show("Chưa nhập tên sách. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenSach.Focus()
            Return
        End If

        If (txtTacGia.Text.Length < 1) Then
            MessageBox.Show("Chưa nhập tác giả. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTacGia.Focus()
            Return
        End If

        '2. Mapping data from GUI control
        sach.TenSach = txtTenSach.Text
        sach.TacGia = txtTacGia.Text
        Dim theLoai = CType(cbTheLoai.SelectedItem, TheLoaiDTO)
        sach.MaTheLoai = theLoai.MaTheLoai

        '3. Insert to data grid view
        Dim listTemp = New List(Of SachDTO)
        result = sachBus.isExists(txtTenSach.Text, theLoai.MaTheLoai, txtTacGia.Text, listTemp)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy sách kiểm tra không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            Dim i As Integer
            i = listTemp.Count
            'MessageBox.Show("true" + i.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'list = 0 -> new Sach
            If (i = 0) Then
                If (txtSoLuong.Text.Length < 1) Then
                    MessageBox.Show("Chưa nhập số lượng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSoLuong.Focus()
                    Return
                End If

                If (txtDonGia.Text.Length < 1) Then
                    MessageBox.Show("Chưa nhập đơn giá. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDonGia.Focus()
                    Return
                End If

                If (Integer.Parse(txtSoLuong.Text) < quiDinh.SoLuongNhapItNhat) Then
                    MessageBox.Show("Sai qui định. Số lượng ít nhất là: " + quiDinh.SoLuongNhapItNhat.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSoLuong.Focus()
                    Return
                End If

                'load data grid view
                MessageBox.Show("Sách này chưa có trong cơ sở dữ liệu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                sach.SoLuong = Integer.Parse(txtSoLuong.Text)
                sach.DonGia = Integer.Parse(txtDonGia.Text)
                sach.MaSach = sachId
                listSach.Add(sach)
                loadListSach(listSach)

                'update sachId
                sachId = sachId + 1
            End If

            'list = 1 -> old sach
            If (i = 1) Then
                If (txtSoLuong.Text.Length < 1) Then
                    MessageBox.Show("Chưa nhập số lượng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSoLuong.Focus()
                    Return
                End If

                'Kiem tra dieu kien
                Dim temp As SachDTO
                temp = listTemp.ElementAt(0)
                If (temp.SoLuong > quiDinh.DieuKienSoLuongNhap) Then
                    MessageBox.Show("Không thể nhập thêm sách vì số lượng vượt quá số lượng qui định.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenSach.Text = String.Empty
                    txtTacGia.Text = String.Empty
                    txtSoLuong.Text = String.Empty
                    txtDonGia.Text = String.Empty
                    Return
                End If

                If (Integer.Parse(txtSoLuong.Text) < quiDinh.SoLuongNhapItNhat) Then
                    MessageBox.Show("Sai qui định. Số lượng ít nhất là: " + quiDinh.SoLuongNhapItNhat.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSoLuong.Focus()
                    Return
                End If

                'load data grid view
                listTemp.ElementAt(0).SoLuong = Integer.Parse(txtSoLuong.Text)
                listSach.Add(listTemp.ElementAt(0))
                loadListSach(listSach)
            End If
        End If
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
    End Sub

    Private Sub btnThemPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btnThemPhieuNhapSach.Click
        'insert phieu nhap sach
        Dim phieu As PhieuNhapSachDTO
        phieu = New PhieuNhapSachDTO()

        '1. Mapping data from GUI control
        phieu.MaPhieuNhapSach = Convert.ToInt32(txtMaPhieuNhapSach.Text)
        phieu.NgayNhap = dtpNgayNhap.Value

        '2. Bussiness...
        If (listSach.Count < 1) Then
            MessageBox.Show("Chưa có sách cần nhập. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenSach.Focus()
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = phieuNhapSachBus.insert(phieu)
        If (result.FlagResult = True) Then
            'NHAP SACH
            Dim i As Integer
            For i = 0 To (listSach.Count() - 1)
                'check sach
                Dim listTemp = New List(Of SachDTO)
                result = sachBus.checkMaSach(listSach.ElementAt(i).MaSach, listTemp)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy sách kiểm tra không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                'new sach -> insert csdl Sach -> insert csdl NhapSach
                If (listTemp.Count = 0) Then
                    'insert csdl Sach
                    result = sachBus.insert(listSach.ElementAt(i))
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Thêm Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If

                    'insert csdl NhapSach
                    result = nhapSachBus.insert(phieu, listSach.ElementAt(i), listSach.ElementAt(i).SoLuong)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Thêm NhapSach không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If
                    Me.Close()
                End If

                'old sach -> insert csdl NhapSach, update soLuong
                If (listTemp.Count = 1) Then
                    'insert csdl NhapSach
                    result = nhapSachBus.insert(phieu, listSach.ElementAt(i), listSach.ElementAt(i).SoLuong)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Thêm NhapSach không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If

                    'update soLuong
                    Dim soLuongUpdate As Integer
                    Dim soLuongDB As Integer
                    result = sachBus.selectSoLuong_ByMaSach(listSach.ElementAt(i).MaSach, soLuongDB)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Lấy số lượng theo mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If
                    soLuongUpdate = soLuongDB + listSach.ElementAt(i).SoLuong

                    result = sachBus.updateSoLuong(listSach.ElementAt(i).MaSach, soLuongUpdate)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Update số lượng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                        Return
                    End If
                    Me.Close()
                End If
            Next
        Else
            MessageBox.Show("Thêm Phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

End Class