Imports DAL
Imports DTO
Imports Utility

Public Class NhapSachBUS
    Private dal As NhapSachDAL

    Public Sub New()
        dal = New NhapSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New NhapSachDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of NhapSachDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function selectSach_ByMaPhieuNhapSach(iMaPhieuNhapSach As Integer, ByRef list As List(Of SachDTO)) As Result
        Return dal.selectSach_ByMaPhieuNhapSach(iMaPhieuNhapSach, list)
    End Function

    Public Function insert(phieu As PhieuNhapSachDTO, sach As SachDTO, iSoLuong As Integer) As Result
        Return dal.insert(phieu, sach, iSoLuong)
    End Function
End Class
