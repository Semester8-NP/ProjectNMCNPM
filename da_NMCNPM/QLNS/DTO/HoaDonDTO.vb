Public Class HoaDonDTO
    Private iMaHoaDon As Integer
    Private iMaKhachHang As Integer
    Private dateNgapLap As DateTime

    Public Sub New()
        iMaHoaDon = 0
        iMaKhachHang = 0
        dateNgapLap = DateTime.Today
    End Sub

    Public Sub New(iMaHoaDon As Integer, iMaKhachHang As Integer, dateNgapLap As DateTime)
        Me.iMaHoaDon = iMaHoaDon
        Me.iMaKhachHang = iMaKhachHang
        Me.dateNgapLap = dateNgapLap
    End Sub

    Public Property MaHoaDon() As Integer
        Get
            Return iMaHoaDon
        End Get
        Set(ByVal value As Integer)
            iMaHoaDon = value
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

    Public Property NgapLap() As DateTime
        Get
            Return dateNgapLap
        End Get
        Set(ByVal value As DateTime)
            dateNgapLap = value
        End Set
    End Property
End Class
