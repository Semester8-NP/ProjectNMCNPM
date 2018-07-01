Public Class SachDTO
    Private iMaSach As Integer
    Private strTenSach As String
    Private iMaTheLoai As Integer
    Private strTacGia As String
    Private iSoLuong As Integer
    Private iDonGia As Integer

    Public Sub New()
        iMaSach = 0
        strTenSach = String.Empty
        iMaTheLoai = 0
        strTacGia = String.Empty
        iSoLuong = 0
        iDonGia = 0
    End Sub

    Public Sub New(iMaSach As Integer, strTenSach As String, iMaTheLoai As Integer,
                   strTacGia As String, iSoLuong As Integer, iDonGia As Integer)
        Me.iMaSach = iMaSach
        Me.strTenSach = strTenSach
        Me.iMaTheLoai = iMaTheLoai
        Me.strTacGia = strTacGia
        Me.iSoLuong = iSoLuong
        Me.iDonGia = iDonGia
    End Sub

    Public Property MaSach() As Integer
        Get
            Return iMaSach
        End Get
        Set(ByVal value As Integer)
            iMaSach = value
        End Set
    End Property

    Public Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(ByVal value As String)
            strTenSach = value
        End Set
    End Property

    Public Property MaTheLoai() As Integer
        Get
            Return iMaTheLoai
        End Get
        Set(ByVal value As Integer)
            iMaTheLoai = value
        End Set
    End Property

    Public Property TacGia() As String
        Get
            Return strTacGia
        End Get
        Set(ByVal value As String)
            strTacGia = value
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

    Public Property DonGia() As Integer
        Get
            Return iDonGia
        End Get
        Set(ByVal value As Integer)
            iDonGia = value
        End Set
    End Property
End Class
