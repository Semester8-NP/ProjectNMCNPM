Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class KhachHangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo] "
        query &= " FROM [tblKhachHang] "

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
                            list.Add(New KhachHangDTO(reader("maKhachHang"), reader("hoTen"), reader("dienThoai"),
                                                         reader("email"), reader("diaChi"), reader("soTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByHoTen(strHoTen As String, ByRef list As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo] "
        query &= " FROM [tblKhachHang] "
        query &= " WHERE [hoTen] = @hoTen "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoTen", strHoTen)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New KhachHangDTO(reader("maKhachHang"), reader("hoTen"), reader("dienThoai"),
                                                         reader("email"), reader("diaChi"), reader("soTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy khách hàng theo tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByDieuKien(iDieuKien As Integer, ByRef list As List(Of KhachHangDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo] "
        query &= " FROM [tblKhachHang] "
        query &= " WHERE [soTienNo] > @soTienNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@soTienNo", iDieuKien)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New KhachHangDTO(reader("maKhachHang"), reader("hoTen"), reader("dienThoai"),
                                                         reader("email"), reader("diaChi"), reader("soTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy khách hàng theo điều kiện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(kh As KhachHangDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblKhachHang] SET"
        query &= " [maKhachHang] = @maKhachHang "
        query &= " ,[hoTen] = @hoTen "
        query &= " ,[dienThoai] = @dienThoai "
        query &= " ,[email] = @email "
        query &= " ,[diaChi] = @diaChi "
        query &= " ,[soTienNo] = @soTienNo "
        query &= " WHERE "
        query &= " [maKhachHang] = @maKhachHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKhachHang", kh.MaKhachHang)
                    .Parameters.AddWithValue("@hoTen", kh.HoTen)
                    .Parameters.AddWithValue("@dienThoai", kh.DienThoai)
                    .Parameters.AddWithValue("@email", kh.Email)
                    .Parameters.AddWithValue("@diaChi", kh.DiaChi)
                    .Parameters.AddWithValue("@soTienNo", kh.SoTienNo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= " Select TOP 1 [maKhachHang] "
        query &= " From [tblKhachHang] "
        query &= " Order By [maKhachHang] DESC "

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
                            idOnDB = reader("maKhachHang")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "DAL - Lấy ID kế tiếp của khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(kh As KhachHangDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblKhachHang] ([maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo]) "
        query &= " VALUES (@maKhachHang,@hoTen,@dienThoai,@email,@diaChi,@soTienNo) "

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        kh.MaKhachHang = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKhachHang", kh.MaKhachHang)
                    .Parameters.AddWithValue("@hoTen", kh.HoTen)
                    .Parameters.AddWithValue("@dienThoai", kh.DienThoai)
                    .Parameters.AddWithValue("@email", kh.Email)
                    .Parameters.AddWithValue("@diaChi", kh.DiaChi)
                    .Parameters.AddWithValue("@soTienNo", kh.SoTienNo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm Khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(iMaKhachHang As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblKhacHang] "
        query &= " WHERE "
        query &= " [maKhachHang] = @maKhachHang "

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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Xóa khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function isExists(strHoTem As String, strDienThoai As String, ByRef list As List(Of KhachHangDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo] "
        query &= " FROM [tblKhachHang] "
        query &= " WHERE "
        query &= " [hoTen] = @hoTen "
        query &= " and [dienThoai] = @dienThoai "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoTen", strHoTem)
                    .Parameters.AddWithValue("@dienThoai", strDienThoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New KhachHangDTO(reader("maKhachHang"), reader("hoTen"), reader("dienThoai"),
                                                         reader("email"), reader("diaChi"), reader("soTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - lấy Khách hàng để kiểm tra không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function updateSoTienNo(iMaKhachHang As Integer, iSoTien As Integer) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblKhachHang] SET"
        query &= " [soTienNo] = @soTienNo "
        query &= " WHERE "
        query &= " [maKhachHang] = @maKhachHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKhachHang", iMaKhachHang)
                    .Parameters.AddWithValue("@soTienNo", iSoTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật số tiền nợ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectSoTienNo_ByMaKhachHang(iMaKhachHang As Integer, ByRef iSoTienNo As Integer) As Result
        Dim query As String = String.Empty
        query &= " SELECT [soTienNo] "
        query &= " FROM [tblKhachHang] "
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
                        While reader.Read()
                            iSoTienNo = reader("soTienNo")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy số tiền nợ theo mã khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
