Imports DAL
Imports DTO
Imports Utility

Public Class HoaDonBUS
    Private dal As HoaDonDAL

    Public Sub New()
        dal = New HoaDonDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New HoaDonDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of HoaDonDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectAll_ByMaKhachHang(iMaKhachHang As Integer, ByRef list As List(Of HoaDonDTO)) As Result
        Return dal.selectALL_ByMaKhachHang(iMaKhachHang, list)
    End Function

    Public Function selectAll_ByMaHoaDon(iMaHoaDon As Integer, ByRef hoaDon As HoaDonDTO) As Result
        Return dal.selectALL_ByMaHoaDon(iMaHoaDon, hoaDon)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dal.getNextID(nextID)
    End Function

    Public Function insert(hoaDon As HoaDonDTO) As Result
        Return dal.insert(hoaDon)
    End Function
End Class
