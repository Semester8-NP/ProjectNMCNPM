Imports BUS
Imports DTO

Public Class frmQuiDinh
    Dim qdBus As QuiDinhBUS
    Dim quydinh As QuiDinhDTO

    Private Sub frmQuiDinh_Load(sender As Object, e As EventArgs) Handles Me.Load
        qdBus = New QuiDinhBUS()
        Dim listQuyDinh = New List(Of QuiDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If

        quydinh = listQuyDinh(0)
        txtSoLuongNhapItNhat.Text = quydinh.SoLuongNhapItNhat
        txtDieuKienSoLuongNhap.Text = quydinh.DieuKienSoLuongNhap
        txtDieuKienTienNo.Text = quydinh.DieuKienTienNo
        txtDieuKienSoLuongBan.Text = quydinh.DieuKienSoLuongBan
        If (quydinh.DieuKienTienThu = 1) Then
            cbDieuKienTienThu.Checked = True
        Else
            cbDieuKienTienThu.Checked = False
        End If

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            quydinh.SoLuongNhapItNhat = Integer.Parse(txtSoLuongNhapItNhat.Text)
            quydinh.DieuKienSoLuongNhap = Integer.Parse(txtDieuKienSoLuongNhap.Text)
            quydinh.DieuKienTienNo = Integer.Parse(txtDieuKienTienNo.Text)
            quydinh.DieuKienSoLuongBan = Integer.Parse(txtDieuKienSoLuongBan.Text)
            If (cbDieuKienTienThu.Checked = True) Then
                quydinh.DieuKienTienThu = 1
            Else
                quydinh.DieuKienTienThu = 0
            End If

            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub txtDieuKienSoLuongBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDieuKienSoLuongBan.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDieuKienSoLuongNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDieuKienSoLuongNhap.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDieuKienTienNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDieuKienTienNo.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoLuongNhapItNhat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongNhapItNhat.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or
            Char.IsWhiteSpace(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True) Then
            e.Handled = True
        End If
    End Sub
End Class