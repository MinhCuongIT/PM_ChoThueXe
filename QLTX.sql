USE master
go

If DB_ID('QLTX') is not null
	DROP database QLTX
GO
create database QLTX
GO
USE QLTX
GO


Create Table TaiKhoan
(
	ID char(50),
	Pass char(50),
	Quyen char(10),			-- admin or customer		
	HOTEN nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(100),
	SDT char(11),
	Constraint PK_TAIKHOAN
	Primary Key(ID)
)

Go

Create Table Xe
(
	Ma int,
	TenXe nvarchar(100),
	LoaiXe nvarchar(50),
	GiaThue float,				-- Đơn vị Dollar/ngay
	TrangThai nvarchar(20),		-- Rãnh or Bận  	
	IMG char(10),				-- Tên file Ảnh
	Constraint PK_Xe
	Primary Key(Ma)
)

Go

Create Table ThueXe
(
	ID char(50),
	MaXe int,
	NgayNhan date,
	NgayTra date,
	GiaThue float,
	TrangThai int,				-- 0: chưa duyệt, 1: Đồng ý cho thuê, 2: Hủy đơn
	Constraint PK_ThueXe
	Primary Key(ID,MaXe)
)

Go

Create Table HoaDon
(
	ID char(50),
	TienThanhToan float,		-- Dollar 
	Constraint PK_HoaDon
	Primary Key(ID)
)

Go

Alter Table ThueXe
	Add Constraint FK_ThueXe_TaiKhoan
	Foreign Key(ID)
	References TaiKhoan(ID)

Alter Table ThueXe
	Add Constraint FK_ThueXe_Xe
	Foreign Key(MaXe)
	References Xe(Ma)

Alter Table HoaDon
	Add Constraint FK_HoaDon_TaiKhoan
	Foreign Key(ID)
	References TaiKhoan(ID)


Go
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(01,N'Toyota ',N'4 chỗ',40,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(02,N'Toyota ',N'7 chỗ',50,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(03,N'Toyota ',N'7 chỗ',40,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(04,N'Mazda',N'4 chỗ',60,N'Bận','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(05,N'Mazda',N'7 chỗ',90,N'Bận','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(06,N'Honda',N'4 chỗ',80,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(07,N'Honda',N'7 chỗ',50,N'Bận','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(08,N'Mercedes',N'4 chỗ',120,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(09,N'Mercedes',N'4 chỗ',150,N'Rãnh','F:\QLXe');
insert into Xe(Ma,TenXe,LoaiXe,GiaThue,TrangThai,IMG) values(010,N'Mercedes',N'7 chỗ',180,N'Rãnh','F:\QLXe');

Go 
insert into TaiKhoan(ID,Pass,Quyen,HOTEN,DiaChi,NgaySinh,SDT) values('tranminhcuong','123456','admin',N'Trần Minh Cường',N'Q1','10/10/1997','0123456789');
insert into TaiKhoan(ID,Pass,Quyen,HOTEN,DiaChi,NgaySinh,SDT) values('chauvannhat','123456','customer',N'Châu Văn Nhật',N'Q10','04/10/1998','0123121789');
insert into TaiKhoan(ID,Pass,Quyen,HOTEN,DiaChi,NgaySinh,SDT) values('todongluu','123456','customer',N'Tô Đồng lưu',N'Q11','10/10/1998','0125221789');
insert into TaiKhoan(ID,Pass,Quyen,HOTEN,DiaChi,NgaySinh,SDT) values('luunhathan','123456','admin',N'Lưu Nhất Hàn',N'Q4','10/05/1998','0145446789');
insert into TaiKhoan(ID,Pass,Quyen,HOTEN,DiaChi,NgaySinh,SDT) values('nguyennhatdinh','123456','admin',N'Nguyễn Nhật Dinh',N'Q1','04/10/1997','0125546789');

Go
insert into ThueXe(ID,MaXe,NgayNhan,NgayTra,GiaThue,TrangThai) values('tranminhcuong',01,'20/10/2018','22/10/2018',120,'Đang chờ');
insert into ThueXe(ID,MaXe,NgayNhan,NgayTra,GiaThue,TrangThai) values('tranminhcuong',08,'20/10/2018','21/10/2018',240,'Đồng ý cho thuê');

Go
insert into HoaDon(ID,TienThanhToan) values('tranminhcuong',120);