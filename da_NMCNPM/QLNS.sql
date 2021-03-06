USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNS]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 5/12/2018 8:42:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTheLoai](
	[maTheLoai] [int] NOT NULL,
	[tenTheLoai] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblQuiDinh]    Script Date: 5/13/2018 9:21:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblQuiDinh](
	[soLuongNhapItNhat] [int] NOT NULL,
	[dieuKienSoLuongNhap] [int] NOT NULL,
	[dieuKienTienNo] [int] NOT NULL,
	[dieuKienSoLuongBan] [int] NOT NULL,
	[dieuKienTienThu] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblSach]    Script Date: 5/14/2018 1:55:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSach](
	[maSach] [int] NOT NULL,
	[tenSach] [nvarchar](200) NOT NULL,
	[maTheLoai] [int] NOT NULL,
	[tacGia] [nvarchar](200) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuNhapSach]    Script Date: 5/15/2018 12:36:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuNhapSach](
	[maPhieuNhapSach] [int] NOT NULL,
	[ngayNhap] [datetime2](7) NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblNhapSach]    Script Date: 5/15/2018 12:37:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNhapSach](
	[maPhieuNhapSach] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuong] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 5/19/2018 6:23:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhachHang](
	[maKhachHang] [int] NOT NULL,
	[hoTen] [nvarchar](50) NOT NULL,
	[dienThoai] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NULL,
	[diaChi] [nvarchar](100) NULL,
	[soTienNo] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/20/2018 11:28:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[maHoaDon] [int] NOT NULL,
	[maKhachHang] [int] NOT NULL,
	[ngayLap] [datetime2](7) NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBanSach]    Script Date: 5/21/2018 3:35:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBanSach](
	[maHoaDon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuong] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuThuTien]    Script Date: 5/29/2018 11:38:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThuTien](
	[maPhieuThuTien] [int] NOT NULL,
	[maKhachHang] [int] NOT NULL,
	[ngayThuTien] [datetime2](7) NOT NULL,
	[soTienThu] [int] NOT NULL
) ON [PRIMARY]

GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblTheLoai]([maTheLoai],[tenTheLoai])VALUES(1,N'Văn học')
INSERT INTO [dbo].[tblTheLoai]([maTheLoai],[tenTheLoai])VALUES(2,N'Tin học')
INSERT INTO [dbo].[tblTheLoai]([maTheLoai],[tenTheLoai])VALUES(3,N'Triết học')
INSERT INTO [dbo].[tblTheLoai]([maTheLoai],[tenTheLoai])VALUES(4,N'Lịch sử')
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblQuiDinh]([soLuongNhapItNhat],[dieuKienSoLuongNhap],[dieuKienTienNo],[dieuKienSoLuongBan],[dieuKienTienThu])
     VALUES (150,300,20000,20,1)
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(1,N'Yui Hatano và lão hàng xóm',1,N'javhd.net',200,1000000)
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(2,N'Maria Ozawa tốt bụng',1,N'javhd.net',100,1500000)
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(3,N'Cô giáo Mao Hamasaki',1,N'javhd.net',270,2100000)
	 
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(4,N'Những nguyên lý cơ bản của VƯƠNG GIA PHÚ',3,N'VƯƠNG GIA PHÚ',1,999999999)
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(5,N'Tư tưởng vĩ đại VƯƠNG GIA PHÚ',3,N'VƯƠNG GIA PHÚ',1,999999999)
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(6,N'Đại phát minh làm thay đổi tư tưởng thế giới: Triết học VƯƠNG GIA PHÚ',3,N'VƯƠNG GIA PHÚ',1,999999999)

INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(7,N'Đại Việt sử ký toàn thư',4,N'Ngô Sỹ Liên',100,300000)
INSERT INTO [dbo].[tblSach]([maSach],[tenSach],[maTheLoai],[tacGia],[soLuong],[donGia])
     VALUES(8,N'Sử Việt - 12 khúc tráng ca',4,N'Dũng Phan',100,2500000)
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblPhieuNhapSach]([maPhieuNhapSach],[ngayNhap])
VALUES(1,convert(datetime,'12/30/2017 00:00:00',101))
INSERT INTO [dbo].[tblPhieuNhapSach]([maPhieuNhapSach],[ngayNhap])
VALUES(2,convert(datetime,'3/8/2017 00:00:00',101))
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(1,1,200)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(1,2,100)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(1,3,270)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(1,7,100)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(1,8,100)

INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(2,4,1)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(2,5,1)
INSERT INTO [dbo].[tblNhapSach]([maPhieuNhapSach],[maSach],[soLuong])
VALUES(2,6,1)
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblKhachHang]([maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo])
VALUES(1,N'Bạch Tuyết',N'0123456',N'bitchtuyet@email.com',N'rừng',0)
INSERT INTO [dbo].[tblKhachHang]([maKhachHang],[hoTen],[dienThoai],[email],[diaChi],[soTienNo])
VALUES(2,N'Lọ lem',N'01234567',N'bitchlem@email.com',N'nhà má nó',0)
GO

USE [QLNS]
GO

INSERT INTO [dbo].[tblHoaDon]([maHoaDon],[maKhachHang],[ngayLap])
VALUES(1,1,convert(datetime,'5/20/2018 00:00:00',101))
GO


USE [QLNS]
GO

INSERT INTO [dbo].[tblPhieuThuTien]([maPhieuThuTien],[maKhachHang],[ngayThuTien],[soTienThu])
VALUES(1,1, convert(datetime,'5/20/2018 00:00:00',101),0)
GO