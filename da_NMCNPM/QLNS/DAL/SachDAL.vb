Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of SachDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "

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
                            list.Add(New SachDTO(reader("maSach"), reader("tenSach"), reader("maTheLoai"),
                                                         reader("tacGia"), reader("soLuong"), reader("donGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaTheLoai(iMaTheLoai As Integer, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE [maTheLoai] = @maTheLoai "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maTheLoai", iMaTheLoai)
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
                    Return New Result(False, "DAL - Lấy tất cả Sách theo Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_BySoLuong(iSoLuong As Integer, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE [soLuong] > @soLuong "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@soLuong", iSoLuong)
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
                    Return New Result(False, "DAL - Lấy tất cả Sách theo Số lượng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByTenSach(strTenSach As String, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE [tenSach] = @tenSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenSach", strTenSach)
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
                    Return New Result(False, "DAL - Lấy tất cả Sách theo Tên sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(sach As SachDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [maSach] = @maSach "
        query &= " ,[tenSach] = @tenSach "
        query &= " ,[maTheLoai] = @maTheLoai "
        query &= " ,[tacGia] = @tacGia "
        query &= " ,[soLuong] = @soLuong "
        query &= " ,[donGia] = @donGia "
        query &= " WHERE "
        query &= " [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", sach.MaSach)
                    .Parameters.AddWithValue("@tenSach", sach.TenSach)
                    .Parameters.AddWithValue("@maTheLoai", sach.MaTheLoai)
                    .Parameters.AddWithValue("@tacGia", sach.TacGia)
                    .Parameters.AddWithValue("@soLuong", sach.SoLuong)
                    .Parameters.AddWithValue("@donGia", sach.DonGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function isExists(strTenSach As String, iMaTheLoai As Integer, strTacGia As String, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE "
        query &= " [tenSach] = @tenSach "
        query &= " and [maTheLoai] = @maTheLoai "
        query &= " and [tacGia] = @tacGia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenSach", strTenSach)
                    .Parameters.AddWithValue("@maTheLoai", iMaTheLoai)
                    .Parameters.AddWithValue("@tacGia", strTacGia)
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
                    Return New Result(False, "DAL - lấy Sách để kiểm tra không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= " Select TOP 1 [maSach] "
        query &= " From [tblSach] "
        query &= " Order By [maSach] DESC "

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
                            idOnDB = reader("maSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "DAL - Lấy ID kế tiếp của sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(sach As SachDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblSach] ([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia]) "
        query &= " VALUES (@maSach,@tenSach,@maTheLoai,@tacGia,@soLuong,@donGia) "

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        sach.MaSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", sach.MaSach)
                    .Parameters.AddWithValue("@tenSach", sach.TenSach)
                    .Parameters.AddWithValue("@maTheLoai", sach.MaTheLoai)
                    .Parameters.AddWithValue("@tacGia", sach.TacGia)
                    .Parameters.AddWithValue("@soLuong", sach.SoLuong)
                    .Parameters.AddWithValue("@donGia", sach.DonGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function checkMaSach(iMaSach As Integer, ByRef list As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia] "
        query &= " FROM [tblSach] "
        query &= " WHERE "
        query &= " [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", iMaSach)
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
                    Return New Result(False, "DAL - lấy Sách để kiểm tra theo ID không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function updateSoLuong(iMaSach As Integer, iSoLuong As Integer) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET "
        query &= " [soLuong] = @soLuong "
        query &= " WHERE "
        query &= " [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", iMaSach)
                    .Parameters.AddWithValue("@soLuong", iSoLuong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Cập nhật Số lượng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectSoLuong_ByMaSach(iMaSach As Integer, ByRef iSoLuong As Integer) As Result
        Dim query As String = String.Empty
        query &= " SELECT [soLuong] "
        query &= " FROM [tblSach] "
        query &= " WHERE [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", iMaSach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            iSoLuong = reader("soLuong")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy số lượng theo mã sách Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
