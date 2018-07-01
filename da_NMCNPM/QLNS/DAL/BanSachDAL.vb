Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class BanSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of BanSachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maHoaDon],[maSach],[soLuong] "
        query &= " FROM [tblBanSach] "

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
                            list.Add(New BanSachDTO(reader("maHoaDon"), reader("maSach"), reader("soLuong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả thông tin bán sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectSach_ByMaHoaDon(iMaHoaDon As Integer, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE [maSach] IN "
        query &= " (SELECT [maSach] FROM [tblBanSach] WHERE [maHoaDon] = @maHoaDon)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", iMaHoaDon)
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
                    Return New Result(False, "DAL - Lấy tất cả sách thông qua hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll_ByMaHoaDon(iMaHoaDon As Integer, ByRef list As List(Of BanSachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maHoaDon],[maSach],[soLuong] "
        query &= " FROM [tblBanSach] "
        query &= " WHERE [maHoaDon] = @maHoaDon"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", iMaHoaDon)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New BanSachDTO(reader("maHoaDon"), reader("maSach"), reader("soLuong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả thông tin bán sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hoaDon As HoaDonDTO, sach As SachDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblBanSach] ([maHoaDon],[maSach],[soLuong]) "
        query &= " VALUES (@maHoaDon,@maSach,@soLuong) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", hoaDon.MaHoaDon)
                    .Parameters.AddWithValue("@maSach", sach.MaSach)
                    .Parameters.AddWithValue("@soLuong", sach.SoLuong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm csdl bán sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
