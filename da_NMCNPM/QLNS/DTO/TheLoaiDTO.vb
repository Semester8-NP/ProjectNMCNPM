Public Class TheLoaiDTO
    Private iMaTheLoai As Integer
    Private strTenTheLoai As String

    Public Sub New()
        iMaTheLoai = 0
        strTenTheLoai = String.Empty
    End Sub

    Public Sub New(iMaTheLoai As Integer, strTenTheLoai As String)
        Me.iMaTheLoai = iMaTheLoai
        Me.strTenTheLoai = strTenTheLoai
    End Sub

    Public Property MaTheLoai As Integer
        Get
            Return iMaTheLoai
        End Get
        Set(value As Integer)
            iMaTheLoai = value
        End Set
    End Property

    Public Property TenTheLoai As String
        Get
            Return strTenTheLoai
        End Get
        Set(value As String)
            strTenTheLoai = value
        End Set
    End Property
End Class
