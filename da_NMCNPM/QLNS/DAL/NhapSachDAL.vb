Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class NhapSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of NhapSachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maPhieuNhapSach],[maSach],[soLuong] "
        query &= " FROM [tblNhapSach] "

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
                            list.Add(New NhapSachDTO(reader("maPhieuNhapSach"), reader("maSach"), reader("soLuong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả thông tin nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectSach_ByMaPhieuNhapSach(iMaPhieuNhapSach As Integer, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE [maSach] IN "
        query &= " (SELECT [maSach] FROM [tblNhapSach] WHERE [maPhieuNhapSach] = @maPhieuNhapSach)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuNhapSach", iMaPhieuNhapSach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New SachDTO(reader("maSach"), reader("tenSach"), reader("maTheLoai"),
                                                         reader("tacGia"), reader("soLuong"), reader("donGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả sách thông qua phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieu As PhieuNhapSachDTO, sach As SachDTO, iSoLuong As Integer) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblNhapSach] ([maPhieuNhapSach],[maSach],[soLuong]) "
        query &= " VALUES (@maPhieuNhapSach,@maSach,@soLuong) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuNhapSach", phieu.MaPhieuNhapSach)
                    .Parameters.AddWithValue("@maSach", sach.MaSach)
                    .Parameters.AddWithValue("@soLuong", iSoLuong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm csdl nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
