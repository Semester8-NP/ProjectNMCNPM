Imports BUS
Imports DTO
Imports Utility

Public Class frmThemTheLoai
    Private tlBus As TheLoaiBUS

    Private Sub frmThemTheLoai_Load(sender As Object, e As EventArgs) Handles Me.Load
        tlBus = New TheLoaiBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = tlBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaTheLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
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
        result = tlBus.insert(tl)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenTheLoai.Text = String.Empty
            Me.Close()
        Else
            MessageBox.Show("Thêm Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
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
        result = tlBus.insert(tl)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenTheLoai.Text = String.Empty
        Else
            MessageBox.Show("Thêm Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        ' Get Next ID
        Dim nextID As Integer
        result = tlBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaTheLoai.Text = nextID.ToString()
            txtTenTheLoai.Text = String.Empty
        Else
            MessageBox.Show("Lấy ID kế tiếp của Năm học không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class