Imports DAL
Imports DTO
Imports Utility

Public Class PhieuThuTienBUS
    Private dal As PhieuThuTienDAL

    Public Sub New()
        dal = New PhieuThuTienDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New PhieuThuTienDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of PhieuThuTienDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectALL_ByMaKhachHang(iMaKhachHang As Integer, ByRef list As List(Of PhieuThuTienDTO)) As Result
        Return dal.selectALL_ByMaKhachHang(iMaKhachHang, list)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dal.getNextID(nextID)
    End Function

    Public Function insert(phieu As PhieuThuTienDTO) As Result
        Return dal.insert(phieu)
    End Function
End Class
