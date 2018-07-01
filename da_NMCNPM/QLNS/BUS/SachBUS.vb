Imports DAL
Imports DTO
Imports Utility

Public Class SachBUS
    Private dal As SachDAL

    Public Sub New()
        dal = New SachDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New SachDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of SachDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectALL_BySoLuong(iSoLuong As Integer, ByRef list As List(Of SachDTO)) As Result
        Return dal.selectALL_BySoLuong(iSoLuong, list)
    End Function

    Public Function selectAll_ByMaTheLoai(iMaTheLoai As Integer, ByRef list As List(Of SachDTO)) As Result
        Return dal.selectALL_ByMaTheLoai(iMaTheLoai, list)
    End Function

    Public Function selectAll_ByTenSach(strTenSach As String, ByRef list As List(Of SachDTO)) As Result
        Return dal.selectALL_ByTenSach(strTenSach, list)
    End Function

    Public Function update(value As SachDTO) As Result
        Return dal.update(value)
    End Function

    Public Function isValidName(value As SachDTO) As Boolean
        If (value.TenSach.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidTacGia(value As SachDTO) As Boolean
        If (value.TacGia.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function isExists(strTenSach As String, iMaTheLoai As Integer, strTacGia As String, ByRef list As List(Of SachDTO)) As Result
        Return dal.isExists(strTenSach, iMaTheLoai, strTacGia, list)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dal.getNextID(nextID)
    End Function

    Public Function insert(sach As SachDTO) As Result
        Return dal.insert(sach)
    End Function

    Public Function checkMaSach(iMaSach As Integer, ByRef list As List(Of SachDTO)) As Result
        Return dal.checkMaSach(iMaSach, list)
    End Function

    Public Function updateSoLuong(iMaSach As Integer, iSoLuong As Integer) As Result
        Return dal.updateSoLuong(iMaSach, iSoLuong)
    End Function

    Public Function selectSoLuong_ByMaSach(iMaSach As Integer, ByRef iSoLuong As Integer) As Result
        Return dal.selectSoLuong_ByMaSach(iMaSach, iSoLuong)
    End Function
End Class
