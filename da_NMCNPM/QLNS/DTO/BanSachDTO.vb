Public Class BanSachDTO
    Private iMaHoaDon As Integer
    Private iMaSach As Integer
    Private iSoLuong As Integer

    Public Sub New()
        iMaHoaDon = 0
        iMaSach = 0
        iSoLuong = 0
    End Sub

    Public Sub New(iMaHoaDon As Integer, iMaSach As Integer, iSoLuong As Integer)
        Me.iMaHoaDon = iMaHoaDon
        Me.iMaSach = iMaSach
        Me.iSoLuong = iSoLuong
    End Sub

    Public Property MaHoaDon() As Integer
        Get
            Return iMaHoaDon
        End Get
        Set(ByVal value As Integer)
            iMaHoaDon = value
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
