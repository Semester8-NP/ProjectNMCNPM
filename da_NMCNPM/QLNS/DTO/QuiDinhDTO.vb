Public Class QuiDinhDTO
    Private iSoLuongNhapItNhat As Integer
    Private iDieuKienSoLuongNhap As Integer
    Private iDieuKienTienNo As Integer
    Private iDieuKienSoLuongBan As Integer
    Private iDieuKienTienThu As Integer

    Public Sub New()
        iSoLuongNhapItNhat = 0
        iDieuKienSoLuongNhap = 0
        iDieuKienTienNo = 0
        iDieuKienSoLuongBan = 0
        iDieuKienTienThu = 0
    End Sub

    Public Sub New(iSoLuongNhapItNhat As Integer, iDieuKienSoLuongNhap As Integer, iDieuKienTienNo As Integer,
                   iDieuKienSoLuongBan As Integer, iDieuKienTienThu As Integer)
        Me.iSoLuongNhapItNhat = iSoLuongNhapItNhat
        Me.iDieuKienSoLuongNhap = iDieuKienSoLuongNhap
        Me.iDieuKienTienNo = iDieuKienTienNo
        Me.iDieuKienSoLuongBan = iDieuKienSoLuongBan
        Me.iDieuKienTienThu = iDieuKienTienThu
    End Sub

    Public Property SoLuongNhapItNhat As Integer
        Get
            Return iSoLuongNhapItNhat
        End Get
        Set(value As Integer)
            iSoLuongNhapItNhat = value
        End Set
    End Property

    Public Property DieuKienSoLuongNhap As Integer
        Get
            Return iDieuKienSoLuongNhap
        End Get
        Set(value As Integer)
            iDieuKienSoLuongNhap = value
        End Set
    End Property

    Public Property DieuKienTienNo As Integer
        Get
            Return iDieuKienTienNo
        End Get
        Set(value As Integer)
            iDieuKienTienNo = value
        End Set
    End Property

    Public Property DieuKienSoLuongBan As Integer
        Get
            Return iDieuKienSoLuongBan
        End Get
        Set(value As Integer)
            iDieuKienSoLuongBan = value
        End Set
    End Property

    Public Property DieuKienTienThu As Integer
        Get
            Return iDieuKienTienThu
        End Get
        Set(value As Integer)
            iDieuKienTienThu = value
        End Set
    End Property
End Class
