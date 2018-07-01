Imports DAL
Imports DTO
Imports Utility

Public Class QuiDinhBUS
    Private qdDAL As QuiDinhDAL

    Public Sub New()
        qdDAL = New QuiDinhDAL()
    End Sub

    Public Sub New(connectionString As String)
        qdDAL = New QuiDinhDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef quydinh As List(Of QuiDinhDTO)) As Result
        Return qdDAL.selectALL(quydinh)
    End Function

    Public Function update(qd As QuiDinhDTO) As Result
        Return qdDAL.update(qd)
    End Function
End Class
