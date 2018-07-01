Imports DAL
Imports DTO
Imports Utility

Public Class PhieuNhapSachBUS
    Private dal As PhieuNhapSachDAL

    Public Sub New()
        dal = New PhieuNhapSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        dal = New PhieuNhapSachDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef list As List(Of PhieuNhapSachDTO)) As Result
        Return dal.selectALL(list)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dal.getNextID(nextID)
    End Function

    Public Function insert(phieu As PhieuNhapSachDTO) As Result
        Return dal.insert(phieu)
    End Function
End Class
