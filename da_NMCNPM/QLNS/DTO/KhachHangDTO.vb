Public Class KhachHangDTO
    Private iMaKhachHang As Integer
    Private strHoTen As String
    Private strDienThoai As String
    Private strEmail As String
    Private strDiaChi As String
    Private iSoTienNo As Integer

    Public Sub New()
        iMaKhachHang = 0
        strHoTen = String.Empty
        strDienThoai = String.Empty
        strEmail = String.Empty
        strDiaChi = String.Empty
        iSoTienNo = 0
    End Sub

    Public Sub New(iMaKhachHang As Integer, strHoTen As String, strDienThoai As String, strEmail As String,
                   strDiaChi As String, iSoTienNo As Integer)
        Me.iMaKhachHang = iMaKhachHang
        Me.strHoTen = strHoTen
        Me.strDienThoai = strDienThoai
        Me.strEmail = strEmail
        Me.strDiaChi = strDiaChi
        Me.iSoTienNo = iSoTienNo
    End Sub

    Public Property MaKhachHang As Integer
        Get
            Return iMaKhachHang
        End Get
        Set(value As Integer)
            iMaKhachHang = value
        End Set
    End Property

    Public Property HoTen() As String
        Get
            Return strHoTen
        End Get
        Set(ByVal value As String)
            strHoTen = value
        End Set
    End Property

    Public Property DienThoai() As String
        Get
            Return strDienThoai
        End Get
        Set(ByVal value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property SoTienNo As Integer
        Get
            Return iSoTienNo
        End Get
        Set(value As Integer)
            iSoTienNo = value
        End Set
    End Property
End Class
