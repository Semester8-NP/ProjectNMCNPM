Imports BUS
Imports DTO
Imports Utility

Public Class frmTraCuu
    Private tlBus As TheLoaiBUS
    Private sachBus As SachBUS

    Private listSach = New List(Of SachDTO)
    '-----------------------------------------------------------------------------------------
    'form
    Private Sub frmTraCuu_Load(sender As Object, e As EventArgs) Handles Me.Load
        tlBus = New TheLoaiBUS()
        sachBus = New SachBUS()

        'load list sách
        Dim result As Result
        result = sachBus.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        loadListSach(listSach)

        'Load list thể loại
        Dim listPhuongThuc = New List(Of TraCuuDTO)
        createListPhuongThuc(listPhuongThuc)

        cbPhuongThuc.DataSource = New BindingSource(listPhuongThuc, String.Empty)
        cbPhuongThuc.DisplayMember = "TenPhuongThuc"
        cbPhuongThuc.ValueMember = "MaPhuongThuc"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbPhuongThuc.DataSource)
        myCurrencyManager.Refresh()
        If (listPhuongThuc.Count > 0) Then
            cbPhuongThuc.SelectedIndex = 0
        End If
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

    Private Sub cbPhuongThuc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPhuongThuc.SelectedIndexChanged
        Dim phuongThuc = CType(cbPhuongThuc.SelectedItem, TraCuuDTO)
        Select Case phuongThuc.MaPhuongThuc
            Case 1
                loadDataCompleteTenSach()
            Case 2
                loadDataCompleteTheLoai()
            Case 3
                loadDataCompleteTacGia()
        End Select
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        'check data
        If (txtTimKiem.Text.Length < 1) Then
            MessageBox.Show("Chưa nhập thông tin tìm kiếm. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'search
        Dim phuongThuc = CType(cbPhuongThuc.SelectedItem, TraCuuDTO)
        Select Case phuongThuc.MaPhuongThuc
            Case 1
                searchTheoTen()
            Case 2
                searchTheoTheLoai()
            Case 3
                searchTheoTacGia()
        End Select
    End Sub

    '----------------------------------------------------------------------------------------
    'function
    'for show txtTheLoai
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

    'show dgv
    Private Sub loadListSach(listSach As List(Of SachDTO))
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

    Private Sub createListPhuongThuc(list As List(Of TraCuuDTO))
        Dim pt1 As TraCuuDTO
        Dim pt2 As TraCuuDTO
        Dim pt3 As TraCuuDTO

        pt1 = New TraCuuDTO(1, "Tìm kiếm theo tên sách")
        pt2 = New TraCuuDTO(2, "Tìm kiếm theo thể loại")
        pt3 = New TraCuuDTO(3, "Tìm kiếm theo tác giả")

        list.Add(pt1)
        list.Add(pt2)
        list.Add(pt3)
    End Sub

    '++++++++++++++
    'load data complete for txtTimKiem

    Private Sub loadDataCompleteTenSach()
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

        txtTimKiem.AutoCompleteCustomSource = listStrSach
    End Sub

    Private Sub loadDataCompleteTheLoai()
        'Get list theloai
        Dim listTemp = New List(Of TheLoaiDTO)
        Dim result As Result
        result = tlBus.selectAll(listTemp)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Get auto completement string
        Dim listStr = New AutoCompleteStringCollection()

        For Each item As TheLoaiDTO In listTemp
            listStr.Add(item.TenTheLoai)
        Next

        txtTimKiem.AutoCompleteCustomSource = listStr
    End Sub

    Private Sub loadDataCompleteTacGia()
        'Get list theloai
        Dim listTemp = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll(listTemp)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Get auto completement string
        Dim listStr = New AutoCompleteStringCollection()

        For Each item As SachDTO In listTemp
            listStr.Add(item.TacGia)
        Next

        txtTimKiem.AutoCompleteCustomSource = listStr
    End Sub

    '++++++++++++++
    'execute search for btnTimKiem

    Private Sub searchTheoTen()
        'get data
        Dim strText As String
        strText = txtTimKiem.Text

        'get the current cell location
        Dim pos As Integer
        pos = getCurrentInList_ByTenSach(strText)

        'load dgv
        Dim clname As String
        clname = "TenSach"
        dgvDanhSachSach.CurrentCell = dgvDanhSachSach.Item(clname, pos)
        dgvDanhSachSach.CurrentCell.Selected = True
        loadListSach(listSach)
    End Sub

    Private Sub searchTheoTheLoai()
        'get data
        Dim strText As String
        strText = txtTimKiem.Text

        'get the current cell location
        Dim ListTemp As List(Of SachDTO)
        ListTemp = getCurrentInList_ByTheLoai(strText)

        'load dgv
        loadListSach(ListTemp)
    End Sub

    Private Sub searchTheoTacGia()
        'get data
        Dim strText As String
        strText = txtTimKiem.Text

        'get the current cell location
        Dim ListTemp As List(Of SachDTO)
        ListTemp = getCurrentInList_ByTacGia(strText)

        'load dgv
        loadListSach(ListTemp)
    End Sub

    '++++++++++++++
    'reload thong tin sach
    Private Function getCurrentInList_ByTenSach(strText As String) As Integer
        Dim pos As Integer
        pos = 0

        For Each item As SachDTO In listSach
            If (String.Compare(strText, item.TenSach, True) = 0) Then
                Return pos
            End If
            pos = pos + 1
        Next
        MessageBox.Show("Lấy vị trí không thành công. Vui lòng kiểm tra lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return 0
    End Function

    Private Function getCurrentInList_ByTheLoai(strText As String) As List(Of SachDTO)
        Dim listTemp As List(Of SachDTO)
        listTemp = New List(Of SachDTO)

        'get list the loai
        Dim iMaTheLoai As Integer
        Dim result As Result
        result = tlBus.selectMaTheLoai_ByTenTheLoai(strText, iMaTheLoai)

        For Each item As SachDTO In listSach
            If (iMaTheLoai = item.MaTheLoai) Then
                listTemp.Add(item)
            End If
        Next

        Return listTemp
    End Function

    Private Function getCurrentInList_ByTacGia(strText As String) As List(Of SachDTO)
        Dim listTemp As List(Of SachDTO)
        listTemp = New List(Of SachDTO)

        For Each item As SachDTO In listSach
            If (String.Compare(strText, item.TacGia, True) = 0) Then
                listTemp.Add(item)
            End If
        Next

        Return listTemp
    End Function
End Class