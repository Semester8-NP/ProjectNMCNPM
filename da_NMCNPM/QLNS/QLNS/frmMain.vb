Public Class frmMain
    Private ConnectionString As String

    Private Sub QuảnLýThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThểLoạiToolStripMenuItem.Click
        Dim frm As frmQuanLyTheLoai = New frmQuanLyTheLoai()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiToolStripMenuItem.Click
        Dim frm As frmThemTheLoai = New frmThemTheLoai()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuiĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuiĐịnhToolStripMenuItem.Click
        Dim frm As frmQuiDinh = New frmQuiDinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
        Dim frm As frmQuanLySach = New frmQuanLySach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frm As frmQuanLyPhieuNhapSach = New frmQuanLyPhieuNhapSach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frm As frmThemPhieuNhapSach = New frmThemPhieuNhapSach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        Dim frm As frmQuanLyKhachHang = New frmQuanLyKhachHang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHóaĐơnToolStripMenuItem.Click
        Dim frm As frmQuanLyHoaDon = New frmQuanLyHoaDon()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHóaĐơnToolStripMenuItem.Click
        Dim frm As frmThemHoaDon = New frmThemHoaDon()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmThemThuTien = New frmThemThuTien()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmQuanLyThuTien = New frmQuanLyThuTien()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TraCứuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TraCứuToolStripMenuItem1.Click
        Dim frm As frmTraCuu = New frmTraCuu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SáchTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchTồnToolStripMenuItem.Click
        'dat ten lon 2 form nay @@
        Dim frm As frmBaoCaoCongNo = New frmBaoCaoCongNo()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CôngNợToolStripMenuItem.Click
        'dat ten lon 2 form nay @@
        Dim frm As frmBaoCaoLuongTon = New frmBaoCaoLuongTon()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class