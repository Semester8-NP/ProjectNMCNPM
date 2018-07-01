Public Class NhapSachDTO
    Private iMaPhieuNhapSach As Integer
    Private iMaSach As Integer
    Private iSoLuong As Integer

    Public Sub New()
        iMaPhieuNhapSach = 0
        iMaSach = 0
        iSoLuong = 0
    End Sub

    Public Sub New(iMaPhieuNhapSach As Integer, iMaSach As Integer, iSoLuong As Integer)
        Me.iMaPhieuNhapSach = iMaPhieuNhapSach
        Me.iMaSach = iMaSach
        Me.iSoLuong = iSoLuong
    End Sub

    Public Property MaPhieuNhapSach() As Integer
        Get
            Return iMaPhieuNhapSach
        End Get
        Set(ByVal value As Integer)
            iMaPhieuNhapSach = value
        End Set
    End Property

    Public Property MaSach() As Integer
        Get
            Return iMaSach
        End Get
        Set(ByVal value As Integer)
            iMaSach = value
        End Set
    End Property

    Public Property SoLuong() As Integer
        Get
            Return iSoLuong
        End Get
        Set(ByVal value As Integer)
            iSoLuong = value
        End Set
    End Property
End Class
