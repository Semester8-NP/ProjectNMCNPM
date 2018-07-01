Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class TheLoaiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef listHocKy As List(Of TheLoaiDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maTheLoai], [tenTheLoai] "
        query &= " FROM [tblTheLoai] "
        query &= " ORDER BY [maTheLoai] "

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
                        listHocKy.Clear()
                        While reader.Read()
                            listHocKy.Add(New TheLoaiDTO(reader("maTheLoai"), reader("tenTheLoai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaTheLoai(iMaTheLoai As Integer, ByRef listHocKy As List(Of TheLoaiDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maTheLoai], [tenTheLoai] "
        query &= " FROM [tblTheLoai] "
        query &= " WHERE  [maTheLoai] = @maTheLoai"

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
                        listHocKy.Clear()
                        While reader.Read()
                            listHocKy.Add(New TheLoaiDTO(reader("maTheLoai"), reader("tenTheLoai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Thể loại theo mã thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_ByMaTheLoai(iMaTheLoai As Integer, ByRef tl As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maTheLoai], [tenTheLoai] "
        query &= " FROM [tblTheLoai] "
        query &= " WHERE  [maTheLoai] = @maTheLoai"

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
                        While reader.Read()
                            tl.MaTheLoai = reader("maTheLoai")
                            tl.TenTheLoai = reader("tenTheLoai")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy Thể loại theo mã thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectMaTheLoai_ByTenTheLoai(strTenTheLoai As String, ByRef iMaTheLoai As Integer) As Result
        Dim query As String = String.Empty
        query &= " SELECT TOP 1 [maTheLoai] "
        query &= " FROM [tblTheLoai] "
        query &= " WHERE  [tenTheLoai] = @tenTheLoai"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenTheLoai", strTenTheLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            iMaTheLoai = reader("maTheLoai")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy mã Thể loại theo tên thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByTenTheLoai(strTenTheLoai As String, ByRef listHocKy As List(Of TheLoaiDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maTheLoai], [tenTheLoai] "
        query &= " FROM [tblTheLoai] "
        query &= " WHERE  [tenTheLoai] = @tenTheLoai"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenTheLoai", strTenTheLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHocKy.Clear()
                        While reader.Read()
                            listHocKy.Add(New TheLoaiDTO(reader("maTheLoai"), reader("tenTheLoai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy tất cả Thể loại theo tên thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tl As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblTheLoai] SET "
        query &= " [tenTheLoai] = @tenTheLoai "
        query &= " WHERE "
        query &= " [maTheLoai] = @maTheLoai "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maTheLoai", tl.MaTheLoai)
                    .Parameters.AddWithValue("@tenTheLoai", tl.TenTheLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Cập nhật thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(iMaTheLoai As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTheLoai] "
        query &= " WHERE "
        query &= " [maTheLoai] = @maTheLoai "

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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa năm học không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= " Select TOP 1 [maTheLoai] "
        query &= " From [tblTheLoai] "
        query &= " Order By [maTheLoai] DESC "

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
                            idOnDB = reader("maTheLoai")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "DAL - Lấy ID kế tiếp của thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(tl As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblTheLoai] ([maTheLoai], [tenTheLoai]) "
        query &= " VALUES (@maTheLoai,@tenTheLoai) "

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        tl.MaTheLoai = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maTheLoai", tl.MaTheLoai)
                    .Parameters.AddWithValue("@tenTheLoai", tl.TenTheLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Thêm Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
