Imports DAL
Imports DTO
Imports Utility

Public Class TheLoaiBUS
    Private tlDAL As TheLoaiDAL

    Public Sub New()
        tlDAL = New TheLoaiDAL()
    End Sub

    Public Sub New(connectionString As String)
        tlDAL = New TheLoaiDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return tlDAL.selectALL(listTheLoai)
    End Function

    Public Function selectAll_ByMaTheLoai(iMaTheLoai As Integer, ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return tlDAL.selectALL_ByMaTheLoai(iMaTheLoai, listTheLoai)
    End Function

    Public Function select_ByMaTheLoai(iMaTheLoai As Integer, ByRef tl As TheLoaiDTO) As Result
        Return tlDAL.select_ByMaTheLoai(iMaTheLoai, tl)
    End Function

    Public Function selectMaTheLoai_ByTenTheLoai(strTenTheLoai As String, ByRef iMaTheLoai As Integer) As Result
        Return tlDAL.selectMaTheLoai_ByTenTheLoai(strTenTheLoai, iMaTheLoai)
    End Function

    Public Function selectAll_ByTenTheLoai(strTenTheLoai As String, ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return tlDAL.selectALL_ByTenTheLoai(strTenTheLoai, listTheLoai)
    End Function

    Public Function update(tl As TheLoaiDTO) As Result
        Return tlDAL.update(tl)
    End Function

    Public Function isValidName(tl As TheLoaiDTO) As Boolean
        If (tl.TenTheLoai.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function delete(maTheLoai As Integer) As Result
        Return tlDAL.delete(maTheLoai)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return tlDAL.getNextID(nextID)
    End Function

    Public Function insert(tl As TheLoaiDTO) As Result
        Return tlDAL.insert(tl)
    End Function
End Class
