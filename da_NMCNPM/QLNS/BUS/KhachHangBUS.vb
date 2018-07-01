Imports DAL
Imports DTO
Imports Utility

Public Class KhachHangBUS
    Private dal As KhachHangDAL

    Public Sub New()
        dal = New KhachHangDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New KhachHangDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of KhachHangDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectALL_ByDieuKien(iDieuKien As Integer, ByRef list As List(Of KhachHangDTO)) As Result
        Return dal.selectALL_ByDieuKien(iDieuKien, list)
    End Function

    Public Function selectALL_ByHoTen(strHoTen As String, ByRef list As List(Of KhachHangDTO)) As Result
        Return dal.selectALL_ByHoTen(strHoTen, list)
    End Function

    Public Function update(value As KhachHangDTO) As Result
        Return dal.update(value)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dal.getNextID(nextID)
    End Function

    Public Function insert(sach As KhachHangDTO) As Result
        Return dal.insert(sach)
    End Function

    Public Function delete(maKhachHang As Integer) As Result
        Return dal.delete(maKhachHang)
    End Function

    Public Function isExists(strHoTen As String, strDienThoai As String, ByRef list As List(Of KhachHangDTO)) As Result
        Return dal.isExists(strHoTen, strDienThoai, list)
    End Function

    Public Function updateSoTienNo(iMaKhachHang As Integer, iSoTien As Integer) As Result
        Return dal.updateSoTienNo(iMaKhachHang, iSoTien)
    End Function

    Public Function selectSoTienNo_ByMaKhachHang(iMaKhachHang As Integer, ByRef iSoTienNo As Integer) As Result
        Return dal.selectSoTienNo_ByMaKhachHang(iMaKhachHang, iSoTienNo)
    End Function
End Class
