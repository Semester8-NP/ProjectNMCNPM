Public Class TraCuuDTO
    Private iMaPhuongThuc As Integer
    Private strTenPhuongThuc As String

    Public Sub New()
        iMaPhuongThuc = 0
        strTenPhuongThuc = String.Empty
    End Sub

    Public Sub New(iMaPhuongThuc As Integer, strTenPhuongThuc As String)
        Me.iMaPhuongThuc = iMaPhuongThuc
        Me.strTenPhuongThuc = strTenPhuongThuc
    End Sub

    Public Property MaPhuongThuc As Integer
        Get
            Return iMaPhuongThuc
        End Get
        Set(value As Integer)
            iMaPhuongThuc = value
        End Set
    End Property

    Public Property TenPhuongThuc As String
        Get
            Return strTenPhuongThuc
        End Get
        Set(value As String)
            strTenPhuongThuc = value
        End Set
    End Property
End Class
