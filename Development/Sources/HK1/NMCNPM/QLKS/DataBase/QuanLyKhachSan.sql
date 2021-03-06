CREATE DATABASE QuanLyKhachSan
USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[MaQD] [int] IDENTITY(1,1) NOT NULL,
	[TenQD] [nvarchar](50) NULL,
	[HeSo] [float] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_QuyDinh] PRIMARY KEY CLUSTERED 
(
	[MaQD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QuyDinh] ON
INSERT [dbo].[QuyDinh] ([MaQD], [TenQD], [HeSo], [GhiChu]) VALUES (1, N'Nước Ngoài', 1.5, N'Phụ thu thêm 50%')
INSERT [dbo].[QuyDinh] ([MaQD], [TenQD], [HeSo], [GhiChu]) VALUES (2, N'Khách hàng thứ 3', 1.25, N'Phụ thu thêm 25%')
SET IDENTITY_INSERT [dbo].[QuyDinh] OFF
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](20) NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (1, N'Admin')
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (2, N'Quản Lí')
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (3, N'Tiếp Tân')
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (4, N'Kế toán')
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[LoaiKH] [int] NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
	[HeSo] [float] NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[LoaiKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiKhachHang] ([LoaiKH], [TenLoaiKH], [HeSo]) VALUES (1, N'Nội địa', 1)
INSERT [dbo].[LoaiKhachHang] ([LoaiKH], [TenLoaiKH], [HeSo]) VALUES (2, N'Nước Ngoài', 1.5)
/****** Object:  Table [dbo].[TinhTrangPT]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TinhTrangPT](
	[MaTT] [int] NOT NULL,
	[TenTT] [varchar](50) NULL,
 CONSTRAINT [PK_TinhTrangPT] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TinhTrangPT] ([MaTT], [TenTT]) VALUES (0, N'Ðã thanh toán')
INSERT [dbo].[TinhTrangPT] ([MaTT], [TenTT]) VALUES (1, N'Chua thanh toán')
/****** Object:  Table [dbo].[TinhTrangPhong]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangPhong](
	[MaTT] [int] NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhTrangPhong] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TinhTrangPhong] ([MaTT], [TinhTrang]) VALUES (1, N'Rảnh')
INSERT [dbo].[TinhTrangPhong] ([MaTT], [TinhTrang]) VALUES (2, N'Bận')
INSERT [dbo].[TinhTrangPhong] ([MaTT], [TinhTrang]) VALUES (3, N'Đang sữa chửa')
INSERT [dbo].[TinhTrangPhong] ([MaTT], [TinhTrang]) VALUES (4, N'Xóa')
/****** Object:  Table [dbo].[TinhTrangNV]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangNV](
	[MaTT] [int] NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhTrangNV] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TinhTrangNV] ([MaTT], [TinhTrang]) VALUES (1, N'Mở')
INSERT [dbo].[TinhTrangNV] ([MaTT], [TinhTrang]) VALUES (2, N'Khóa')
INSERT [dbo].[TinhTrangNV] ([MaTT], [TinhTrang]) VALUES (3, N'Xóa')
/****** Object:  Table [dbo].[TinhTrangLoaiPhong]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangLoaiPhong](
	[MaTT] [int] NOT NULL,
	[TenTT] [nchar](10) NULL,
 CONSTRAINT [PK_TinhTrangLoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TinhTrangLoaiPhong] ([MaTT], [TenTT]) VALUES (0, N'Đã xóa    ')
INSERT [dbo].[TinhTrangLoaiPhong] ([MaTT], [TenTT]) VALUES (1, N'Active    ')
/****** Object:  StoredProcedure [dbo].[spqd_xoaqd]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spqd_xoaqd]
@ma int
as
begin
delete  QuyDinh where MaQD=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[spqd_themqd]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spqd_themqd]
@tenqd nvarchar(30), @heso float, @ghichu nvarchar(100)
as
begin
insert into QuyDinh(TenQD, HeSo,GhiChu) values(@tenqd,@heso,@ghichu)
end
GO
/****** Object:  StoredProcedure [dbo].[spqd_suaqd]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spqd_suaqd]
@maqd int, @tenqd nvarchar(50), @heso float, @ghichu nvarchar(100)
as
begin
update QuyDinh set TenQD=@tenqd, HeSo=@HeSo,GhiChu=@ghichu where MaQD=@maqd
end
GO
/****** Object:  StoredProcedure [dbo].[spqd_phuThu]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spqd_phuThu]
as
	select HeSo from QuyDinh where TenQD = N'Khách hàng thứ 3'
GO
/****** Object:  StoredProcedure [dbo].[spqd_dsquydinh]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spqd_dsquydinh]
as
begin
select * from QuyDinh
end
GO
/****** Object:  StoredProcedure [dbo].[spqd_dsHeSo]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spqd_dsHeSo]
as
	select tenQD, HeSo from QuyDinh where TenQD <> N'Khách hàng thứ 3'
GO
/****** Object:  StoredProcedure [dbo].[spp_dsTinhTrang]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_dsTinhTrang]
as
select * from TinhTrangPhong
GO
/****** Object:  StoredProcedure [dbo].[splkh_dsLoaiKH]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splkh_dsLoaiKH]
as
select LoaiKh, tenloaikh from LoaiKhachHang
GO
/****** Object:  StoredProcedure [dbo].[splk_themloaikh]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splk_themloaikh]
@maloai int, @tenloai nvarchar(30), @heso float
as
begin
insert into LoaiKhachHang (LoaiKH,TenLoaiKH,HeSo) values (@maloai, @tenloai,@heso)
end
GO
/****** Object:  StoredProcedure [dbo].[spkh_capnhatkh]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spkh_capnhatkh]
@maloai int,@tenloai nvarchar(30), @heso float
as
begin
update LoaiKhachHang set TenLoaiKH=@tenloai, HeSo=@heso where LoaiKH=@maloai
end
GO
/****** Object:  StoredProcedure [dbo].[spnv_dsTinhTrangNV]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spnv_dsTinhTrangNV]
as
	select * From TinhTrangNV
GO
/****** Object:  StoredProcedure [dbo].[spltk_dsLoaiNV]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spltk_dsLoaiNV]
as
	select * From LoaiNhanVien
GO
/****** Object:  StoredProcedure [dbo].[splp_TrangThai]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splp_TrangThai]
as select * from TinhTrangLoaiPhong
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[Pass] [varchar](20) NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [varchar](20) NULL,
	[SDT] [varchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TinhTrang] [int] NULL,
	[LoaiNV] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'AD001', N'12345', N'Đặng Thị Quỳnh', N'12345678', N'01654535492', N'Nguyễn Trãi', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'KT001', N'12345', N'Kim Tình', N'346346', N'346324', N'vsegheber', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'KT113', N'123456', N'Võ My', N'1322423', N'24354353', N'Bình Thuận', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'KT123', N'12345', N'Trịnh Thị Kim tình', N'12345', N'01654535492', N'Nguyễn Trãi. P3, Q5', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'KT312', N'12345', N'ABCDSF', N'13234234', N'24325443645', N'Trâng hưng đạo', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'QL001', N'12345', N'Đặng thị quỳnh', N'23455432', N'23465434', N'dfuyhga;ẻ', 1, 2)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'TT001', N'12345', N'Võ hoàng nam', N'3452387', N'25223523', N'vẻiguwov', 1, 3)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'TT002', N'12345', N'võ lê quỳnh my', N'3451346', N'435324613', N'sdtuhe', 3, 3)
INSERT [dbo].[NhanVien] ([MaNV], [Pass], [HoTen], [CMND], [SDT], [DiaChi], [TinhTrang], [LoaiNV]) VALUES (N'TT012', N'12345', N'Nguyễn Văn Nhân', N'12345678', N'0173234243', N'Trần hugw Đạo', 1, 3)
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (1, N'phòng D', 200000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (2, N'phòng A', 120000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (3, N'phòngD', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (4, N'Phòng E', 200000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (5, N'phòng F', 300000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (6, N'phòng G', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (7, N'phòng H', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (9, N'phòngD', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (10, N'phòngD', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (11, N'phòng H', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (12, N'phòng S1', 200000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (13, N'Phòng S', 200000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (14, N'phòng D', 200000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [TrangThai]) VALUES (15, N'phòng B', 170000, 1)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [varchar](9) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[LoaiKH] [int] NULL,
 CONSTRAINT [PK_KhachHang_1] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'112233490', N'quỳnh', N'Quận 9, tpHCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'121312324', N'Quỳnh', N'Trâgsdg', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'122323234', N'Nguyễn Văn A', N'Trần Bình Trọng, Q3, Tp HCM', 2)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'122324345', N'Nguyễn Nguyên Đăng', N'122/12 A, Nguyễn Trãi, Phường 3, Quận 5', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'12312323', N'Jessica Ngô', N'Phạm Ngũ Lão, Phường 10', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'123123234', N'Trần Khải', N'Trần Hưng Đạo, Phường 5, Quận 5', 2)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'12312423', N'szfsdgrs', N'szfasdf', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'123231323', N'Trịnh Thị Kim Tình', N'122/12A Nguyễn Trãi, Phường 3, Quận 5, Tp HCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'123234234', N'David Trần', N'Ba Đình, Hà Nội', 2)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'12342342', N'sểgesr', N'sfssr', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'123454321', N'Quy Dang', N'sfdgfd', 2)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'12345567', N'Trần Thi', N'Trần hưng đạo', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'1234567', N'szfdfgdx', N'zfdzfgd', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'123456789', N'Kim Tinh', N'Nguywn fsfd', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'13123234', N'Trần Minh Nguyệt', N'Nơ TRang Long, Quận Bình Thạnh, Tp HCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'13242343', N'Nguyễn Thiện Thuật', N'Nguyễn Thị Minh Khai, Q1, TpHCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'23131242', N'szgfsrgsdgrs', N'sfsfsdf', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'232343432', N'Lâm Nhật Vượng', N'Nguyễn Thông', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'23242342', N'Trần Minh Nguyệt', N'Nơ Trang Long, Bình Thạnh, tp HCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'23243223', N'sdrgsdrgs', N'ưsfgdgdgd', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'233545344', N'Trần Minh Nguyệt', N'Nơ Trang Long, Q.Bình Thạnh, TP HCM', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'234231123', N'Cao Thái Đạt', N'Vĩnh Phúc', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'2342453', N'sgsdfgsd', N'sfss', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'242342', N'sdgsdgr', N'fsrgsdg', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'323243', N'ságsdrg', N'sfssd', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'32432542', N'2323', N'ửewrqw', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'353553', N'Trần Minh', N'Ba Đình, Hà Tây', 1)
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DiaChi], [LoaiKH]) VALUES (N'43313211', N'Trần Thánh', N'Q1, tp HCM', 1)
/****** Object:  Table [dbo].[Phong]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [int] NULL,
	[TinhTrang] [int] NULL,
	[SoNguoi] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Phong] ON
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (1, N'phòng đơn', 2, 1, 2, N'dvsrhe')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (2, N'phòng doi', 3, 2, 2, N'vdsrgwes')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (3, N'phòng VIP', 3, 1, 2, N'sdfghbaer')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (4, N'phòng VIP', 3, 1, 2, N'd;fhgai')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (5, N'phòng đơn', 1, 4, 2, N's;drgs')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (6, N'phòng đôi', 2, 2, 2, N'dfugadfb')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (7, N'phòng đơn', 1, 3, 2, N'dfhvasr')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (8, N'Phong doi', 1, 1, 2, N'sdfsfvds')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (9, N'phòng don', 1, 2, 2, N'vdsrgwes')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (10, N'phòng  ddooi', 2, 1, 2, N'dvsrhe')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (11, N'phòng VIP', 3, 1, 2, N'sdfghbaer')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (12, N'phòng Đôi', 2, 1, 2, N'sdfghbaer')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (13, N'phòng đơn', 2, 1, 2, N'dvsrhe')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (14, N'phòng Đôi', 4, 1, 3, N'Được ở 3 người có tính phụ thu')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (15, N'Phòng Thường', 7, 1, 2, N'Không có')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [SoNguoi], [GhiChu]) VALUES (16, N'phòng bình thường', 11, 2, 2, N'dvsrhe')
SET IDENTITY_INSERT [dbo].[Phong] OFF
/****** Object:  StoredProcedure [dbo].[sptk_timnhanvien]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_timnhanvien]
@hoten nvarchar(50)
as
	select * from nhanvien where hoten like '%' + @hoten + '%'
GO
/****** Object:  StoredProcedure [dbo].[sptk_themtaikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_themtaikhoan]
 @manv varchar(10), @pass varchar(20), @hoten nvarchar(50),@cmnd varchar(20),@sdt varchar(20), @diachi nvarchar(100),@tinhtrang int, @loainv int
as
begin
insert into NhanVien(MaNV,Pass,HoTen,CMND,SDT,DiaChi,TinhTrang,LoaiNV) values(@manv, @pass,@hoten,@cmnd,@sdt,@diachi,@tinhtrang,@loainv)
end
GO
/****** Object:  StoredProcedure [dbo].[sptk_laytaikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_laytaikhoan]
@manv varchar(10),
@pass varchar(20)
as
begin
	select manv, pass, LoaiNV, TinhTrang from NhanVien where manv = @manv and pass = @pass
end
GO
/****** Object:  StoredProcedure [dbo].[sptk_khoataikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_khoataikhoan]
@matk varchar(10)
  as

 begin
update NhanVien set TinhTrang ='0' where MaNV =@matk
 end
GO
/****** Object:  StoredProcedure [dbo].[sptk_dstaikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_dstaikhoan]
as
begin
	select *
	from NhanVien
	where TinhTrang <>3
end
GO
/****** Object:  StoredProcedure [dbo].[sptk_capnhatTTNhanVien]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sptk_capnhatTTNhanVien]
@manv varchar(10), @pass varchar(20), @cmnd varchar(20), @sdt varchar(20), @diachi nvarchar(100)
as
	update NhanVien set Pass = @pass, CMND = @cmnd, SDT = @sdt, DiaChi = @diachi where MaNV = @manv
GO
/****** Object:  StoredProcedure [dbo].[sptk_capnhattaikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptk_capnhattaikhoan]
 @manv varchar(10),@tinhtrang int, @loainv int
as
begin
update NhanVien set TinhTrang=@tinhtrang, LoaiNV=@loainv where MaNV = @manv
end
GO
/****** Object:  StoredProcedure [dbo].[sptk_1taikhoan]    Script Date: 10/24/2013 17:14:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sptk_1taikhoan]
@matk varchar(10)
as
begin
select * from NhanVien where MaNV=@matk
end
GO
/****** Object:  StoredProcedure [dbo].[splp_themloaiphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[splp_themloaiphong]
 @tenloaiphong nvarchar(50),@gia float, @tinhtrang int
as
begin

insert into LoaiPhong(TenLoaiPhong,DonGia,TrangThai) values(@tenloaiphong,@gia,@tinhtrang)
end
GO
/****** Object:  StoredProcedure [dbo].[splp_thaydoithongtin]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[splp_thaydoithongtin]
@matk varchar(10), @pass varchar(20), @hoten nvarchar(50),@cmnd varchar(20),@sdt varchar(20), @diachi nvarchar(100)
as

begin
update NhanVien set Pass=@pass, HoTen=@hoten,CMND=@cmnd,SDT=@sdt,DiaChi=@diachi where MaNV=@matk
end
GO
/****** Object:  StoredProcedure [dbo].[splp_SuaLoaiPhong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[splp_SuaLoaiPhong]
@maloai int, @tenloai nvarchar(30), @dongia float, @tinhtrang int
as
begin
update LoaiPhong set TenLoaiPhong=@tenloai, DonGia=@dongia, TrangThai=@tinhtrang where MaLoaiPhong=@maloai
end
GO
/****** Object:  StoredProcedure [dbo].[splp_dslphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[splp_dslphong]
as
begin
select * from LoaiPhong where TrangThai = 1
end
GO
/****** Object:  StoredProcedure [dbo].[splp_dsLoaiPhong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splp_dsLoaiPhong]
as
	select MaLoaiPhong, TenLoaiPhong from LoaiPhong
GO
/****** Object:  StoredProcedure [dbo].[splp_chitietloai]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splp_chitietloai]
@maloai int
as
begin
select * from LoaiPhong where MaLoaiPhong=@maloai
end
GO
/****** Object:  StoredProcedure [dbo].[splp_xoaloaiphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[splp_xoaloaiphong]
@maloai int
as
begin

 update LoaiPhong set TrangThai='0' where MaLoaiPhong=@maloai
end
GO
/****** Object:  StoredProcedure [dbo].[spkh_XoaKH]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spkh_XoaKH]
@cmnd varchar(9)
as
	delete KhachHang where CMND = @cmnd
GO
/****** Object:  StoredProcedure [dbo].[spkh_ThemKH]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spkh_ThemKH]
@cmnd varchar(20), @tenkh nvarchar(50), @diachi nvarchar(100), @loaikh int
as
	insert into KhachHang (CMND, TenKH, DiaChi, LoaiKH) values (@cmnd, @tenkh,  @diachi, @loaikh)
GO
/****** Object:  StoredProcedure [dbo].[spkh_dsCMND]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spkh_dsCMND] 
@cmnd varchar(9)
as 
	select cmnd from KhachHang where CMND = @cmnd
GO
/****** Object:  StoredProcedure [dbo].[spkh_ChiTietKH]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spkh_ChiTietKH]
@cmnd varchar(9)
as 
	select * from KhachHang where cmnd = @cmnd
GO
/****** Object:  StoredProcedure [dbo].[sphd_capnhatPhong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sphd_capnhatPhong]
@maphong int
as
	update Phong set TinhTrang = 1 where MaPhong = @maphong
GO
/****** Object:  StoredProcedure [dbo].[spp_xoaphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_xoaphong]
@maphong int
as
begin

 update Phong set TinhTrang='4' where MaPhong =@maphong
end
GO
/****** Object:  StoredProcedure [dbo].[spp_tracuutinhtrang]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spp_tracuutinhtrang]
@tinhtrang int
as
begin
select * from Phong where TinhTrang=@tinhtrang
end
GO
/****** Object:  StoredProcedure [dbo].[spp_tracuuloai]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spp_tracuuloai]
@maloai int
as
begin
select * from Phong where LoaiPhong=@maloai and TinhTrang='1'
end
GO
/****** Object:  StoredProcedure [dbo].[spp_tracuugia]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_tracuugia]
@gia float
as
begin

select p.MaPhong,p.TenPhong,p.LoaiPhong,p.TinhTrang,p.SoNguoi,p.GhiChu from Phong p, LoaiPhong lp where p.LoaiPhong=lp.MaLoaiPhong and lp.DonGia=@gia
end
GO
/****** Object:  StoredProcedure [dbo].[spp_timPhongTrong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_timPhongTrong]
@key nvarchar(50)
as
begin
	select p.MaPhong, p.TenPhong, l.TenLoaiPhong, l.DonGia
	from Phong p, LoaiPhong l 
	where p.TinhTrang ='1' and p.LoaiPhong = l.MaLoaiPhong and p.TenPhong like '%' + @key + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[spp_themphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_themphong]
@tenphong nvarchar(50),@loaiphong int, @songuoi int, @ghichu nvarchar(100)
as
begin
insert into Phong (TenPhong,LoaiPhong,TinhTrang,SoNguoi,GhiChu)values ( @tenphong,@loaiphong,'1',@songuoi,@ghichu)
end
GO
/****** Object:  StoredProcedure [dbo].[spp_dspphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_dspphong]
as
begin
select * from Phong where TinhTrang <> 4
end
GO
/****** Object:  StoredProcedure [dbo].[spp_dsphongtrong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_dsphongtrong]
as
begin
	select p.MaPhong, p.TenPhong, l.TenLoaiPhong, l.DonGia
	from Phong p, LoaiPhong l 
	where p.TinhTrang =1 and p.LoaiPhong = l.MaLoaiPhong
end
GO
/****** Object:  StoredProcedure [dbo].[spp_CapNhatTTP]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_CapNhatTTP]
@maphong int 
as
	update Phong set TinhTrang = 2 where MaPhong = @maphong
GO
/****** Object:  StoredProcedure [dbo].[spp_capnhatphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_capnhatphong]
@ma int,@tenphong nvarchar(50),@loaiphong int,@tinhtrang int, @songuoi int, @ghichu nvarchar(100)
as
begin

 update Phong set TenPhong=@tenphong, LoaiPhong=@loaiphong,TinhTrang=@tinhtrang, SoNguoi=@songuoi, GhiChu=@ghichu where MaPhong=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[spp_1phong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spp_1phong]
@maphong int
as
begin
select * from Phong where MaPhong=@maphong
end
GO
/****** Object:  Table [dbo].[PhieuThue]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThue](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[NgayThue] [datetime] NULL,
	[MaPhong] [int] NULL,
	[MaNV] [varchar](10) NULL,
	[SoNguoi] [int] NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_PhieuThue] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuThue] ON
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (31, CAST(0x0000A25800A2AD9F AS DateTime), 8, N'TT001', 1, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (32, CAST(0x0000A25800A316EE AS DateTime), 9, N'TT001', 1, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (33, CAST(0x0000A25800A41356 AS DateTime), 4, N'TT001', 2, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (34, CAST(0x0000A25800000000 AS DateTime), 1, N'TT001', 2, 1)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (35, CAST(0x0000A25900952B28 AS DateTime), 10, N'TT001', 2, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (36, CAST(0x0000A2590097AAE5 AS DateTime), 6, N'TT001', 1, 1)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (37, CAST(0x0000A25A00985831 AS DateTime), 11, N'TT001', 3, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (38, CAST(0x0000A25A017AE44A AS DateTime), 11, N'TT001', 2, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (39, CAST(0x0000A25E0097CD47 AS DateTime), 3, N'TT001', 2, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (40, CAST(0x0000A25E0099658B AS DateTime), 9, N'TT001', 1, 1)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (41, CAST(0x0000A25E0099EAE5 AS DateTime), 8, N'TT001', 1, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (42, CAST(0x0000A260008388F1 AS DateTime), 8, N'TT001', 1, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (43, CAST(0x0000A26000870C10 AS DateTime), 11, N'TT001', 1, 0)
INSERT [dbo].[PhieuThue] ([MaPhieu], [NgayThue], [MaPhong], [MaNV], [SoNguoi], [TinhTrang]) VALUES (44, CAST(0x0000A2600087F4B9 AS DateTime), 1, N'TT001', 2, 0)
SET IDENTITY_INSERT [dbo].[PhieuThue] OFF
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](9) NULL,
	[MaPhieuThue] [int] NULL,
	[NgayLap] [datetime] NULL,
	[DonGia] [float] NULL,
	[SoNgayThue] [int] NULL,
	[TriGia] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (6, N'KT001', N'123456789', 31, CAST(0x0000A25A008DEAD7 AS DateTime), 200000, 3, 900000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (7, N'KT001', N'234231123', 37, CAST(0x0000A25A009937AA AS DateTime), 200000, 2, 2250000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (8, N'KT001', N'13242343', 38, CAST(0x0000A25A017B470B AS DateTime), 200000, 2, 1200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (9, N'KT001', N'123454321', 32, CAST(0x0000A25E00953689 AS DateTime), 200000, 2, 600000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (10, N'KT001', N'233545344', 41, CAST(0x0000A25E009B4C4D AS DateTime), 200000, 2, 600000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (11, N'KT001', N'121312324', 44, CAST(0x0000A26000888437 AS DateTime), 200000, 2, 1200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (12, N'KT001', N'23131242', 44, CAST(0x0000A260008891D7 AS DateTime), 200000, 2, 1200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (13, N'KT001', N'123234234', 39, CAST(0x0000A261008D4B2C AS DateTime), 200000, 2, 1200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (14, N'KT001', N'123231323', 42, CAST(0x0000A261008D63F6 AS DateTime), 200000, 2, 600000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (15, N'KT001', N'12345567', 43, CAST(0x0000A261008D7037 AS DateTime), 200000, 1, 300000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (16, N'KT001', N'12345567', 43, CAST(0x0000A261008D7037 AS DateTime), 200000, 1, 300000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (17, N'KT001', N'1234567', 33, CAST(0x0000A261008DD92D AS DateTime), 200000, 1, 600000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [MaPhieuThue], [NgayLap], [DonGia], [SoNgayThue], [TriGia]) VALUES (18, N'KT001', N'12312323', 35, CAST(0x0000A261008EE613 AS DateTime), 120000, 2, 720000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
/****** Object:  Table [dbo].[CTPhieuThue]    Script Date: 10/24/2013 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPhieuThue](
	[CMND] [varchar](9) NOT NULL,
	[MaPT] [int] NOT NULL,
 CONSTRAINT [PK_CTPhieuThue] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC,
	[MaPT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'121312324', 44)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'122323234', 38)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'122324345', 35)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'12312323', 35)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'123123234', 37)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'12312423', 40)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'123231323', 42)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'123234234', 39)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'123454321', 32)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'12345567', 43)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'1234567', 33)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'123456789', 31)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'13123234', 36)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'13242343', 38)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'23131242', 44)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'232343432', 37)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'233545344', 41)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'234231123', 37)
INSERT [dbo].[CTPhieuThue] ([CMND], [MaPT]) VALUES (N'43313211', 39)
/****** Object:  StoredProcedure [dbo].[sphd_capnhatPT]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sphd_capnhatPT]
@mapt int
as
	update PhieuThue set TinhTrang = 0 where MaPhieu = @mapt
GO
/****** Object:  StoredProcedure [dbo].[sppt_themphieuthue]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_themphieuthue]
  @ngaythue datetime, @maphong int, @manv varchar(10), @songuoi int
 as
 begin
 
 insert into PhieuThue(NgayThue,MaPhong,MaNV,SoNguoi, TinhTrang) values (@ngaythue,@maphong,@manv,@songuoi, 1)
select MAX(MaPhieu) as mapt from PhieuThue
 end
GO
/****** Object:  StoredProcedure [dbo].[sppt_thanhtoanphieuthue]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_thanhtoanphieuthue]
  @maphieu int
  as
 begin
 
 update PhieuThue set TinhTrang='1' where MaPhieu = @maphieu
 end
GO
/****** Object:  StoredProcedure [dbo].[sppt_timkiemphieu]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sppt_timkiemphieu]
@maphieu int, @ngaythue datetime, @maphong int
as
begin
select * from PhieuThue where MaPhieu=@maphieu and NgayThue=@ngaythue and MaPhong=@maphong

end
GO
/****** Object:  StoredProcedure [dbo].[sppt_timkh]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_timkh]
  @tenkh nvarchar(50)
  as 
  begin  
 SELECT pt.MaPhieu,kh.CMND, kh.TenKH, pt.NgayThue,pt.MaPhong,pt.SoNguoi, l.DonGia
  FROM PhieuThue pt, CTPhieuThue ct, KhachHang kh, Phong p, LoaiPhong l
  where pt.MaPhieu=ct.MaPT  and ct.CMND= kh.CMND and kh.TenKH like '%' + @tenkh + '%' and pt.TinhTrang = 1 and pt.MaPhong = p.MaPhong and p.LoaiPhong = l.MaLoaiPhong
  end
GO
/****** Object:  StoredProcedure [dbo].[sppt_DSphieuthue]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_DSphieuthue]
as
begin
 SELECT pt.MaPhieu, kh.CMND, kh.TenKH, pt.MaPhong, pt.NgayThue, pt.SoNguoi, l.DonGia
  FROM PhieuThue pt, CTPhieuThue ct, KhachHang kh, Phong p, LoaiPhong l
  where pt.MaPhieu=ct.MaPT  and ct.CMND= kh.CMND and pt.TinhTrang = 1 and pt.MaPhong = p.MaPhong and p.LoaiPhong = l.MaLoaiPhong

end
GO
/****** Object:  StoredProcedure [dbo].[sppt_timngay]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_timngay]
  @ngaythue date
  as 
  begin  
   SELECT pt.MaPhieu,kh.CMND, kh.TenKH, pt.NgayThue,pt.MaPhong,pt.SoNguoi, l.DonGia
  FROM PhieuThue pt, CTPhieuThue ct, KhachHang kh, Phong p, LoaiPhong l
  where pt.MaPhieu=ct.MaPT  and ct.CMND= kh.CMND and pt.NgayThue=@ngaythue and pt.TinhTrang = 1 and pt.MaPhong = p.MaPhong and p.LoaiPhong = l.MaLoaiPhong
  end
GO
/****** Object:  StoredProcedure [dbo].[sppt_timmaphong]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sppt_timmaphong]
  @maphong int
  as 
  begin  
  SELECT pt.MaPhieu,kh.CMND, kh.TenKH, pt.NgayThue,pt.MaPhong,pt.SoNguoi, l.DonGia
  FROM PhieuThue pt, CTPhieuThue ct, KhachHang kh, Phong p, LoaiPhong l
  where pt.MaPhieu=ct.MaPT  and ct.CMND= kh.CMND and pt.MaPhong=@maphong and pt.TinhTrang = 1 and pt.MaPhong = p.MaPhong and p.LoaiPhong = l.MaLoaiPhong
  
  	end
GO
/****** Object:  StoredProcedure [dbo].[sphd_ThemHD]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sphd_ThemHD]
@manv varchar(10), @makh varchar(10), @maphieuthue int, @ngaylap datetime, @dongia float, @songay int,  @trigia float
as
begin
	insert into HoaDon (MaNV, MaKH, MaPhieuThue, NgayLap, DonGia, SoNgayThue, TriGia) values (@manv, @makh, @maphieuthue, @ngaylap, @dongia, @songay, @trigia)
end
GO
/****** Object:  StoredProcedure [dbo].[sphd_laphoadon]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sphd_laphoadon]
  @manv varchar(10), @makh int,@ngaylap datetime, @trigia float,@songay int,@dongia float,@maphieu int
 as
 begin
 insert into HoaDon(MaNV, MaKH,NgayLap,TriGia,SoNgayThue,DonGia,MaPhieuThue)values (@manv,@makh,@ngaylap,@trigia,@songay,@dongia,@maphieu)
 end
GO
/****** Object:  StoredProcedure [dbo].[spct_themCTPhieu]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spct_themCTPhieu]
@cmnd varchar(9), @mapt int
as 
	insert into CTPhieuThue (cmnd, MaPT) values (@cmnd, @mapt)
GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoMatDo]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BaoCaoMatDo]
@thang int, 
 @nam int
as
begin
select pt.MaPhong, SUM (hd.SoNgayThue)as SoNgayThue  
from  PhieuThue pt, HoaDon hd 
where pt.MaPhieu=hd.MaPhieuThue and @nam=YEAR(hd.NgayLap) and @thang=MONTH(hd.NgayLap)
group by (pt.MaPhong)
		
		end
GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoDoanhThu]    Script Date: 10/24/2013 17:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BaoCaoDoanhThu]
 @thang int,
 @nam int
as
	begin
		select lp.TenLoaiPhong,sum (hd.TriGia) as tongdoanhthu
		from PhieuThue pt, HoaDon hd, LoaiPhong lp, Phong p
		where pt.MaPhieu=hd.MaPhieuThue and pt.MaPhong=pt.MaPhong and lp.MaLoaiPhong= p.LoaiPhong and @nam=YEAR(hd.NgayLap) and @thang=MONTH(hd.NgayLap)
		group by(lp.TenLoaiPhong)
	end
GO
/****** Object:  ForeignKey [FK_CTPhieuThue_KhachHang]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[CTPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuThue_KhachHang] FOREIGN KEY([CMND])
REFERENCES [dbo].[KhachHang] ([CMND])
GO
ALTER TABLE [dbo].[CTPhieuThue] CHECK CONSTRAINT [FK_CTPhieuThue_KhachHang]
GO
/****** Object:  ForeignKey [FK_CTPhieuThue_PhieuThue]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[CTPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuThue_PhieuThue] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PhieuThue] ([MaPhieu])
GO
ALTER TABLE [dbo].[CTPhieuThue] CHECK CONSTRAINT [FK_CTPhieuThue_PhieuThue]
GO
/****** Object:  ForeignKey [FK_HoaDon_PhieuThue]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuThue] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PhieuThue] ([MaPhieu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuThue]
GO
/****** Object:  ForeignKey [FK_KhachHang_LoaiKhachHang]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([LoaiKH])
REFERENCES [dbo].[LoaiKhachHang] ([LoaiKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
/****** Object:  ForeignKey [FK_LoaiPhong_TinhTrangLoaiPhong]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[LoaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_LoaiPhong_TinhTrangLoaiPhong] FOREIGN KEY([TrangThai])
REFERENCES [dbo].[TinhTrangLoaiPhong] ([MaTT])
GO
ALTER TABLE [dbo].[LoaiPhong] CHECK CONSTRAINT [FK_LoaiPhong_TinhTrangLoaiPhong]
GO
/****** Object:  ForeignKey [FK_NhanVien_LoaiNhanVien]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNhanVien] FOREIGN KEY([LoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoai])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNhanVien]
GO
/****** Object:  ForeignKey [FK_NhanVien_TinhTrangNV]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TinhTrangNV] FOREIGN KEY([TinhTrang])
REFERENCES [dbo].[TinhTrangNV] ([MaTT])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TinhTrangNV]
GO
/****** Object:  ForeignKey [FK_PhieuThue_NhanVien]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThue_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuThue] CHECK CONSTRAINT [FK_PhieuThue_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuThue_Phong]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThue_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[PhieuThue] CHECK CONSTRAINT [FK_PhieuThue_Phong]
GO
/****** Object:  ForeignKey [FK_PhieuThue_TinhTrangPT]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThue_TinhTrangPT] FOREIGN KEY([TinhTrang])
REFERENCES [dbo].[TinhTrangPT] ([MaTT])
GO
ALTER TABLE [dbo].[PhieuThue] CHECK CONSTRAINT [FK_PhieuThue_TinhTrangPT]
GO
/****** Object:  ForeignKey [FK_Phong_LoaiPhong]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
/****** Object:  ForeignKey [FK_Phong_TinhTrangPhong]    Script Date: 10/24/2013 17:14:25 ******/
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_TinhTrangPhong] FOREIGN KEY([TinhTrang])
REFERENCES [dbo].[TinhTrangPhong] ([MaTT])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_TinhTrangPhong]
GO
