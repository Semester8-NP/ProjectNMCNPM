Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class PhieuThuTienDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of PhieuThuTienDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maPhieuThuTien],[maKhachHang],[ngayThuTien],[soTienThu] "
        query &= " FROM [tblPhieuThuTien] "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New PhieuThuTienDTO(reader("maPhieuThuTien"), reader("maKhachHang"), reader("ngayThuTien"), reader("soTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaKhachHang(iMaKhachHang As Integer, ByRef list As List(Of PhieuThuTienDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maPhieuThuTien],[maKhachHang],[ngayThuTien],[soTienThu] "
        query &= " FROM [tblPhieuThuTien] "
        query &= " WHERE [maKhachHang] = @maKhachHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKhachHang", iMaKhachHang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New PhieuThuTienDTO(reader("maPhieuThuTien"), reader("maKhachHang"), reader("ngayThuTien"), reader("soTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Phiếu thu tiền theo khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= " Select TOP 1 [maPhieuThuTien] "
        query &= " From [tblPhieuThuTien] "
        query &= " Order By [maPhieuThuTien] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("maPhieuThuTien")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "DAL - Lấy ID kế tiếp của Phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieu As PhieuThuTienDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblPhieuThuTien] ([maPhieuThuTien],[maKhachHang],[ngayThuTien],[soTienThu]) "
        query &= " VALUES (@maPhieuThuTien, @maKhachHang, @ngayThuTien, @soTienThu) "

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieu.MaPhieuThuTien = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuThuTien", phieu.MaPhieuThuTien)
                    .Parameters.AddWithValue("@maKhachHang", phieu.MaKhachHang)
                    .Parameters.AddWithValue("@ngayThuTien", phieu.NgayThuTien)
                    .Parameters.AddWithValue("@soTienThu", phieu.SoTienThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm Phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
