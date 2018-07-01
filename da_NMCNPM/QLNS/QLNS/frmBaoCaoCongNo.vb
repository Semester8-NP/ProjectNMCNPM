Imports BUS
Imports DTO
Imports Utility

Public Class frmBaoCaoCongNo
    Private tlBus As TheLoaiBUS
    Private sachBus As SachBUS

    Private Sub frmBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles Me.Load
        tlBus = New TheLoaiBUS()
        sachBus = New SachBUS()

        tlBus = New TheLoaiBUS()
        sachBus = New SachBUS()

        txtSoTienDieuKien.Text = 0
    End Sub

    Private Sub loadListSach(dieuKien As Integer)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectALL_BySoLuong(dieuKien, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        If (listSach.Count < 1) Then
            txtMaSach.Text = String.Empty
            txtTenSach.Text = String.Empty
            txtTacGia.Text = String.Empty
            txtSoLuong.Text = String.Empty
            txtDonGia.Text = String.Empty
            txtTheLoai.Text = String.Empty
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

    Private Sub txtSoTienDieuKien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoTienDieuKien.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
                    Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoTienDieuKien_TextChanged(sender As Object, e As EventArgs) Handles txtSoTienDieuKien.TextChanged
        If (txtSoTienDieuKien.Text.Length > 0) Then
            loadListSach(Integer.Parse(txtSoTienDieuKien.Text))
        End If
    End Sub
End Class