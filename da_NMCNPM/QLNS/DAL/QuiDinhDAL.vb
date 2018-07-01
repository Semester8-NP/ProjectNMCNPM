Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class QuiDinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef quidinh As List(Of QuiDinhDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [soLuongNhapItNhat], [dieuKienSoLuongNhap], [dieuKienTienNo], [dieuKienSoLuongBan], [dieuKienTienThu] "
        query &= " FROM [tblQuiDinh] "


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
                        quidinh.Clear()
                        While reader.Read()
                            quidinh.Add(New QuiDinhDTO(reader("soLuongNhapItNhat"), reader("dieuKienSoLuongNhap"),
                                                       reader("dieuKienTienNo"), reader("dieuKienSoLuongBan"),
                                                       reader("dieuKienTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "DAL - Lấy Qui Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(qd As QuiDinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblQuiDinh] SET "
        query &= " [soLuongNhapItNhat] = @soLuongNhapItNhat "
        query &= " ,[dieuKienSoLuongNhap] = @dieuKienSoLuongNhap "
        query &= " ,[dieuKienTienNo] = @dieuKienTienNo "
        query &= " ,[dieuKienSoLuongBan] = @dieuKienSoLuongBan "
        query &= " ,[dieuKienTienThu] = @dieuKienTienThu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@soLuongNhapItNhat", qd.SoLuongNhapItNhat)
                    .Parameters.AddWithValue("@dieuKienSoLuongNhap", qd.DieuKienSoLuongNhap)
                    .Parameters.AddWithValue("@dieuKienTienNo", qd.DieuKienTienNo)
                    .Parameters.AddWithValue("@dieuKienSoLuongBan", qd.DieuKienSoLuongBan)
                    .Parameters.AddWithValue("@dieuKienTienThu", qd.DieuKienTienThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
