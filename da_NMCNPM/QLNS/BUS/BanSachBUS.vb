Imports DAL
Imports DTO
Imports Utility

Public Class BanSachBUS
    Private dal As BanSachDAL

    Public Sub New()
        dal = New BanSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New BanSachDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of BanSachDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectSach_ByMaHoaDon(iMaHoaDon As Integer, ByRef list As List(Of SachDTO)) As Result
        Return dal.selectSach_ByMaHoaDon(iMaHoaDon, list)
    End Function

    Public Function selectAll_ByMaHoaDon(iMaHoaDon As Integer, ByRef list As List(Of BanSachDTO)) As Result
        Return dal.selectAll_ByMaHoaDon(iMaHoaDon, list)
    End Function

    Public Function insert(hoaDon As HoaDonDTO, sach As SachDTO) As Result
        Return dal.insert(hoaDon, sach)
    End Function
End Class
