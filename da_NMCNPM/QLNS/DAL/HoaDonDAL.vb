Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class HoaDonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of HoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maHoaDon],[maKhachHang],[ngayLap] "
        query &= " FROM [tblHoaDon] "

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
                            list.Add(New HoaDonDTO(reader("maHoaDon"), reader("maKhachHang"), reader("ngayLap")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaKhachHang(iMaKhachHang As Integer, ByRef list As List(Of HoaDonDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maHoaDon],[maKhachHang],[ngayLap] "
        query &= " FROM [tblHoaDon] "
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
                            list.Add(New HoaDonDTO(reader("maHoaDon"), reader("maKhachHang"), reader("ngayLap")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Hóa đơn theo Khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaHoaDon(iMaHoaDon As Integer, ByRef hoaDon As HoaDonDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maHoaDon],[maKhachHang],[ngayLap] "
        query &= " FROM [tblHoaDon] "
        query &= " WHERE [maHoaDon] = @maHoaDon "

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
                        While reader.Read()
                            hoaDon.MaHoaDon = reader("maHoaDon")
                            hoaDon.MaKhachHang = reader("maKhachHang")
                            hoaDon.NgapLap = reader("ngayLap")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Hóa đơn theo mã hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= " Select TOP 1 [maHoaDon] "
        query &= " From [tblHoaDon] "
        query &= " Order By [maHoaDon] DESC "

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
                            idOnDB = reader("maHoaDon")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "DAL - Lấy ID kế tiếp của Hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hoaDon As HoaDonDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblHoaDon] ([maHoaDon],[maKhachHang],[ngayLap]) "
        query &= " VALUES (@maHoaDon,@maKhachHang,@ngayLap) "

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        hoaDon.MaHoaDon = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", hoaDon.MaHoaDon)
                    .Parameters.AddWithValue("@maKhachHang", hoaDon.MaKhachHang)
                    .Parameters.AddWithValue("@ngayLap", hoaDon.NgapLap)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm Hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
