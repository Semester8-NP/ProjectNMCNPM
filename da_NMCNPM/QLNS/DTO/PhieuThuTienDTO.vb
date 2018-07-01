Public Class PhieuThuTienDTO
    Private iMaPhieuThuTien As Integer
    Private iMaKhachHang As Integer
    Private dateNgayThuTien As DateTime
    Private iSoTienThu As Integer

    Public Sub New()
        iMaPhieuThuTien = 0
        iMaKhachHang = 0
        dateNgayThuTien = DateTime.Today
        iSoTienThu = 0
    End Sub

    Public Sub New(iMaPhieuThuTien As Integer, iMaKhachHang As Integer, dateNgayThuTien As DateTime, iSoTienThu As Integer)
        Me.iMaPhieuThuTien = iMaPhieuThuTien
        Me.iMaKhachHang = iMaKhachHang
        Me.dateNgayThuTien = dateNgayThuTien
        Me.iSoTienThu = iSoTienThu
    End Sub

    Public Property MaPhieuThuTien() As Integer
        Get
            Return iMaPhieuThuTien
        End Get
        Set(ByVal value As Integer)
            iMaPhieuThuTien = value
        End Set
    End Property

    Public Property MaKhachHang() As Integer
        Get
            Return iMaKhachHang
        End Get
        Set(ByVal value As Integer)
            iMaKhachHang = value
        End Set
    End Property

    Public Property NgayThuTien() As DateTime
        Get
            Return dateNgayThuTien
        End Get
        Set(ByVal value As DateTime)
            dateNgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu() As Integer
        Get
            Return iSoTienThu
        End Get
        Set(ByVal value As Integer)
            iSoTienThu = value
        End Set
    End Property
End Class
