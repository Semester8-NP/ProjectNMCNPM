Public Class PhieuNhapSachDTO
    Private iMaPhieuNhapSach As Integer
    Private dateNgayNhap As DateTime

    Public Sub New()
        iMaPhieuNhapSach = 0
        dateNgayNhap = DateTime.Today
    End Sub

    Public Sub New(iMaPhieuNhapSach As Integer, dateNgayNhap As DateTime)
        Me.iMaPhieuNhapSach = iMaPhieuNhapSach
        Me.dateNgayNhap = dateNgayNhap
    End Sub

    Public Property MaPhieuNhapSach() As Integer
        Get
            Return iMaPhieuNhapSach
        End Get
        Set(ByVal value As Integer)
            iMaPhieuNhapSach = value
        End Set
    End Property

    Public Property NgayNhap() As DateTime
        Get
            Return dateNgayNhap
        End Get
        Set(ByVal value As DateTime)
            dateNgayNhap = value
        End Set
    End Property
End Class
