Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLyKhachHang
    Private khBus As KhachHangBUS

    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        khBus = New KhachHangBUS()

        'Load list khachhang
        loadListKhachHang()
    End Sub

    Private Sub loadListKhachHang()
        Dim listKhachHang = New List(Of KhachHangDTO)
        Dim result As Result
        result = khBus.selectAll(listKhachHang)
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

    Private Sub txtSoTienNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoTienNo.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhachHang.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhachHang.RowCount) Then
            Try
                Dim kh As KhachHangDTO
                kh = New KhachHangDTO()

                '1. Check data
                If (txtHoTen.Text.Length < 1) Then
                    MessageBox.Show("Chưa nhập họ tên. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtHoTen.Focus()
                    Return
                End If

                If (txtHoTen.Text.Length < 1) Then
                    MessageBox.Show("Chưa nhập điện thoại. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtHoTen.Focus()
                    Return
                End If

                '2. Mapping data from GUI control
                kh.MaKhachHang = Integer.Parse(txtMaKhachHang.Text)
                kh.HoTen = txtHoTen.Text
                kh.DienThoai = txtDienThoai.Text
                kh.Email = txtEmail.Text
                kh.DiaChi = txtDiaChi.Text
                kh.SoTienNo = Integer.Parse(txtSoTienNo.Text)

                '3. Insert to DB
                Dim result As Result
                result = khBus.update(kh)
                If (result.FlagResult = True) Then
                    ' Re-Load 
                    loadListKhachHang()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachKhachHang.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachKhachHang.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachKhachHang.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Khách hàng có mã: " + txtMaKhachHang.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = khBus.delete(Convert.ToInt32(txtMaKhachHang.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListKhachHang()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachKhachHang.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachKhachHang.Rows(currentRowIndex).Selected = True
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
                            MessageBox.Show("Xóa Khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
    End Sub
End Class