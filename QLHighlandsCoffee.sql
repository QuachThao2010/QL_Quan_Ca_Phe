use master
go
if(exists (select*from sysdatabases where name='ManagerHighlandsCoffee'))
	Drop database ManagerHighlandsCoffee
create database ManagerHighlandsCoffee

use ManagerHighlandsCoffee
go
CREATE TABLE KhuyenMai
(	
	MaKhuyenMai Nvarchar(20) PRIMARY KEY not null,
	PhanTram int not null,
	NgayBatDau Datetime,
	NgayKetThuc Datetime
)
CREATE TABLE DanhMuc
(	MaDM Nvarchar(20) PRIMARY KEY not null,
	TenDM Nvarchar(30) not null
)
CREATE TABLE HangHoa
(	MaHang Nvarchar(20)PRIMARY KEY not null,
	TenHang Nvarchar(50) not null,
	MoTa Nvarchar(150) not null,
	AnhHang Image,
	MaDM Nvarchar(20) not null,
	FOREIGN KEY(MaDM) references DanhMuc(MaDM)
	on update cascade on delete cascade
)
CREATE TABLE SizeHang
(	
	Size Nvarchar(20) PRIMARY KEY not null
)
CREATE TABLE HangBan
(	MaHang Nvarchar(20) not null,
	Size Nvarchar(20) not null,
	DonGia Float not null,
	PRIMARY KEY(MaHang,Size),
	FOREIGN KEY(MaHang) references HangHoa(MaHang)
	on update cascade on delete cascade,
	FOREIGN KEY(Size) references SizeHang(Size)
	on update cascade on delete cascade,
)
CREATE TABLE CaLamViec
(	MaCLV Nvarchar(20)PRIMARY KEY not null,
	GioBatDau Float not null,
	GioKetThuc Float not null,
	LuongGio Float not null,
	LuongQL Float not null
)

CREATE TABLE NhanVien
(	MaNV Nvarchar(20)PRIMARY KEY not null,
	TenNV Nvarchar(50) not null,
	GioiTinh Nvarchar(50) not null,
	SDT Nvarchar(50) not null,
	DiaChi Nvarchar(150) not null,
	AnhNV Image,
	ChucVu Nvarchar(100) not null,
	MaCLV nvarchar(20) not null
)

CREATE TABLE BangChamCong
(
	MaNV Nvarchar(20) not null,
	MaCLV Nvarchar(20) not null,
	TenNV Nvarchar(50) not null,
	NgayLam Datetime not null,
	GioVao Float,
	GioRa Float,
	Cong Float,
	PRIMARY KEY(MaNV,MaCLV,NgayLam,GioVao,GioRa),
	FOREIGN KEY(MaNV) references NhanVien(MaNV)
	on update cascade on delete cascade,
	FOREIGN KEY(MaCLV) references CaLamViec(MaCLV)
	on update cascade on delete cascade
)
CREATE TABLE BangUngLuong
(
	MaNV Nvarchar(20) not null,
	MaCLV Nvarchar(20) not null,
	LuongThang Nvarchar(20) not null,
	LuongNam Nvarchar(20) not null,
	TamUng Float,
	PRIMARY KEY(MaNV,MaCLV,LuongThang, LuongNam),
	FOREIGN KEY(MaNV) references NhanVien(MaNV)
	on update cascade on delete cascade,
	FOREIGN KEY(MaCLV) references CaLamViec(MaCLV)
	on update cascade on delete cascade
)
CREATE TABLE Luong
(	MaNV Nvarchar(20) not null,
	MaCLV Nvarchar(20) not null,
	NgayCong Float,
	Thuong Float,
	TongLuong Float,
	TamUng Float,
	LuongThang Nvarchar(20) not null,
	LuongNam Nvarchar(20) not null,
	PRIMARY KEY(MaNV,MaCLV,LuongThang, LuongNam),
	FOREIGN KEY(MaNV) references NhanVien(MaNV)
	on update cascade on delete cascade,
	FOREIGN KEY(MaCLV) references CaLamViec(MaCLV)
	on update cascade on delete cascade
)
CREATE TABLE KhachHang
(	MaKH  Int IDENTITY PRIMARY KEY,
	TenKH Nvarchar(50) not null,
	GioiTinh Nvarchar(50) not null,
	SDT Nvarchar(50) not null,
	DiaChi Nvarchar(150) not null,
	DiemTichLuy int
)
CREATE TABLE Ban
(	MaBan Nvarchar(20)PRIMARY KEY not null,
	TrangThai Nvarchar(50) not null
)
CREATE TABLE HoaDon
(	MaHoaDon Int IDENTITY PRIMARY KEY,
	NgayLap Datetime,
	TongTien Float not null,
	GiamGia Float,
	TruDiemTL Int,
	MaNV Nvarchar(20) not null,
	MaKH int,
	MaBan Nvarchar(20),
	FOREIGN KEY(MaNV) references NhanVien(MaNV)
	on update cascade on delete cascade,
	FOREIGN KEY(MaKH) references KhachHang(MaKH)
	on update cascade on delete cascade,
	FOREIGN KEY(MaBan) references Ban(MaBan)
	on update cascade on delete cascade
)
CREATE TABLE ChiTietHoaDon
(	
	MaHoaDon Int,
	MaHang Nvarchar(20) not null,
	Size Nvarchar(20) not null,
	SoLuong int not null,
	PRIMARY KEY(MaHoaDon,MaHang,Size),
	FOREIGN KEY(MaHoaDon) references HoaDon(MaHoaDon)
	on update cascade on delete cascade,
	FOREIGN KEY(MaHang,Size) references HangBan(MaHang,Size)
	on update cascade on delete cascade,
)
CREATE TABLE NhaCC
(
	MaNCC Nvarchar(20) PRIMARY KEY not null,
	TenNCC Nvarchar(100) not null,
	SDT Nvarchar(50) not null,
	DiaChi Nvarchar(150) not null,
	
)
CREATE TABLE NguyenLieu
(
	MaNL Nvarchar(20) PRIMARY KEY not null,
	TenNL Nvarchar(50) not null,
	MaNCC Nvarchar(20)not null,
	DonViTinh nvarchar(20) not null,
	DonGiaNhap Float not null,
)
CREATE TABLE DonDatHang
(	MaDDH INT IDENTITY(1,1) PRIMARY KEY not null,
	MaNV Nvarchar(20) not null,
	MaNCC Nvarchar(20) not null,
	NgayLap Datetime,
	TongTien Float not null,
	NguoiNhap Nvarchar(50),
	TrangThai Nvarchar(30) not null,
	FOREIGN KEY(MaNCC) references NhaCC(MaNCC)
	on update cascade on delete cascade,
	FOREIGN KEY(MaNV) references NhanVien(MaNV)
	on update cascade on delete cascade
)
CREATE TABLE ChiTietDatHang
(	MaDDH INT not null,
	MaNL Nvarchar(20) not null,
	SoLuongNhap int not null,
	PRIMARY KEY (MaDDH, MaNL),
	FOREIGN KEY(MaDDH) references DonDatHang(MaDDH)
	on update cascade on delete cascade,
	FOREIGN KEY(MaNL) references NguyenLieu(MaNL)
	on update cascade on delete cascade
)

CREATE TABLE TaiKhoan
(	TenTK Nvarchar(20)PRIMARY KEY not null,
	MatKhau Nvarchar(50) not null
)




