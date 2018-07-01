Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLySach
    Private sachBus As SachBUS
    Private theLoaiBus As TheLoaiBUS

    Private Sub frmQuanLySach_Load(sender As Object, e As EventArgs) Handles Me.Load
        sachBus = New SachBUS()
        theLoaiBus = New TheLoaiBUS()

        'Load list thể loại
        Dim listTheLoai = New List(Of TheLoaiDTO)
        Dim result As Result
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

        cbTheLoaiCapNhat.DataSource = New BindingSource(listTheLoai, String.Empty)
        cbTheLoaiCapNhat.DisplayMember = "TenTheLoai"
        cbTheLoaiCapNhat.ValueMember = "MaTheLoai"
    End Sub

    Private Sub cbTheLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTheLoai.SelectedIndexChanged
        Try
            Dim theLoai = CType(cbTheLoai.SelectedItem, TheLoaiDTO)
            loadListSach(theLoai.MaTheLoai)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub loadListSach(maTheLoai)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll_ByMaTheLoai(maTheLoai, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSach.Columns.Clear()
        dgvDanhSach.DataSource = Nothing

        dgvDanhSach.AutoGenerateColumns = False
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.DataSource = listSach

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvDanhSach.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên sách"
        clTenSach.DataPropertyName = "TenSach"
        dgvDanhSach.Columns.Add(clTenSach)

        'Dim clTheLoai = New DataGridView()

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "TacGia"
        clTacGia.HeaderText = "Tác giả"
        clTacGia.DataPropertyName = "TacGia"
        dgvDanhSach.Columns.Add(clTacGia)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số lượng"
        clSoLuong.DataPropertyName = "SoLuong"
        dgvDanhSach.Columns.Add(clSoLuong)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvDanhSach.Columns.Add(clDonGia)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub dgvDanhSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSach.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSach.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSach.RowCount) Then
            Try
                Dim sach = CType(dgvDanhSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = sach.MaSach
                txtTenSach.Text = sach.TenSach
                txtTacGia.Text = sach.TacGia
                txtSoLuong.Text = sach.SoLuong
                txtDonGia.Text = sach.DonGia
                cbTheLoaiCapNhat.SelectedIndex = cbTheLoai.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSach.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSach.RowCount) Then
            Try
                Dim sach As SachDTO
                sach = New SachDTO()

                '1. Mapping data from GUI control
                sach.MaSach = Integer.Parse(txtMaSach.Text)
                sach.TenSach = txtTenSach.Text
                sach.TacGia = txtTacGia.Text
                sach.SoLuong = Integer.Parse(txtSoLuong.Text)
                sach.DonGia = Integer.Parse(txtDonGia.Text)
                Dim theLoai = CType(cbTheLoaiCapNhat.SelectedItem, TheLoaiDTO)
                sach.MaTheLoai = theLoai.MaTheLoai

                '2. Business .....
                If (sachBus.isValidName(sach) = False) Then
                    MessageBox.Show("Tên sách không đúng.")
                    txtTenSach.Focus()
                    Return
                End If

                If (sachBus.isValidTacGia(sach) = False) Then
                    MessageBox.Show("Tên tác giả không đúng.")
                    txtTacGia.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = sachBus.update(sach)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListSach(cbTheLoai.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvDanhSach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub
End Class