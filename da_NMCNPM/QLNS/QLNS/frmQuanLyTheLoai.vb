Imports BUS
Imports DTO
Imports Utility

Public Class frmQuanLyTheLoai
    Private tlBus As TheLoaiBUS

    Private Sub frmQuanLyTheLoai_Load(sender As Object, e As EventArgs) Handles Me.Load
        tlBus = New TheLoaiBUS()

        'Load list thể loại
        loadListTheLoai()
    End Sub

    Private Sub loadListTheLoai()
        Dim listTheLoai = New List(Of TheLoaiDTO)
        Dim result As Result
        result = tlBus.selectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTheLoai.Columns.Clear()
        dgvDanhSachTheLoai.DataSource = Nothing

        dgvDanhSachTheLoai.AutoGenerateColumns = False
        dgvDanhSachTheLoai.AllowUserToAddRows = False
        dgvDanhSachTheLoai.DataSource = listTheLoai

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaTheLoai"
        clMaLoai.HeaderText = "Mã thể loại"
        clMaLoai.DataPropertyName = "MaTheLoai"
        dgvDanhSachTheLoai.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenTheLoai"
        clTenLoai.HeaderText = "Tên thể loại"
        clTenLoai.DataPropertyName = "TenTheLoai"
        dgvDanhSachTheLoai.Columns.Add(clTenLoai)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTheLoai.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub dgvDanhSachTheLoai_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTheLoai.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTheLoai.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoai.RowCount) Then
            Try
                Dim tl = CType(dgvDanhSachTheLoai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                txtMaTheLoai.Text = tl.MaTheLoai
                txtTenTheLoai.Text = tl.TenTheLoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTheLoai.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoai.RowCount) Then
            Try
                Dim tl As TheLoaiDTO
                tl = New TheLoaiDTO()

                '1. Mapping data from GUI control
                tl.MaTheLoai = Convert.ToInt32(txtMaTheLoai.Text)
                tl.TenTheLoai = txtTenTheLoai.Text

                '2. Business .....
                If (tlBus.isValidName(tl) = False) Then
                    MessageBox.Show("Tên Thể loại không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenTheLoai.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = tlBus.update(tl)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListTheLoai()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTheLoai.Rows(currentRowIndex).Selected = True
                    Try
                        tl = CType(dgvDanhSachTheLoai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                        txtMaTheLoai.Text = tl.MaTheLoai
                        txtTenTheLoai.Text = tl.TenTheLoai
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTheLoai.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoai.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Thể loại có mã: " + txtMaTheLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = tlBus.delete(Convert.ToInt32(txtMaTheLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListTheLoai()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachTheLoai.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachTheLoai.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim tl = CType(dgvDanhSachTheLoai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                                    txtMaTheLoai.Text = tl.MaTheLoai
                                    txtTenTheLoai.Text = tl.TenTheLoai
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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