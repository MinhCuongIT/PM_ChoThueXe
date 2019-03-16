USE [master]
GO
-- database quản lý thuê xe
CREATE DATABASE QL_ThueXe
GO

USE QL_ThueXe
GO
--bảng user 
CREATE TABLE USERS
(
	UserID int IDENTITY(1,1) NOT NULL,
	UserName nvarchar(45) null,
	Position bit null,
	Password nvarchar(20) NULL,
	Type int null,
	Constraint PK_Users primary key (UserID)
)
--bảng xe
CREATE TABLE CARS
(
	CarId int IDENTITY (1,1) NOT NULL,
	Brand nvarchar(20) NULL,
	Model nvarchar(20) NULL,
	ProductYear nvarchar(20) NULL,
	Plate nvarchar(20) NULL,
	Fuel nvarchar(20) NULL,
	GearBox nvarchar(20) NULL,
	Price nvarchar(20) NULL,
	Constraint PK_Cars primary key (CarId)
)
--bảng khách hàng
CREATE TABLE CUSTOMERS
(
	CustomerId int IDENTITY(1,1) NOT NULL,
	Name nvarchar(30) NULL,
	CMND nvarchar(20) NULL,
	Addr nvarchar(80) NULL,
	PhoneNumber nvarchar(20) NULL,
	Constraint PK_Customers primary key (CustomerID)
)
--bảng cho thuê
CREATE TABLE RENT
(
	RentID int IDENTITY(1,1) NOT NULL,
	CustomerID int NULL,
	CarID int NULL,
	RentDate date NULL,
	ReturnDate date NULL,
	Constraint PK_Rent primary key (RentID)
)

--Thêm khóa ngoại
ALTER TABLE RENT ADD CONSTRAINT FK_RENT_CUSTOMERS FOREIGN KEY (CustomerID) REFERENCES CUSTOMERS(CustomerID)
ALTER TABLE RENT ADD CONSTRAINT FK_RENT_CARS FOREIGN KEY (CarID) REFERENCES CARS(CarID)

--Thêm data
--Bảng Xe
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'BMW', N'7 50i', N'2014', N'34TC8191', N'PETROL', N'AUTOMATIC', N'700')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'OPEL', N'VECTRA', N'2000', N'34O1200', N'DIESEL', N'Manuel', N'50')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'CITROEN ', N'C4', N'2008', N'34RT543', N'PETROL', N'MANUEL', N'90')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'VOLKSWAGEN', N'EOS', N'2012', N'23RT548', N'Diesel', N'Automatic', N'480')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'VOLKSWAGEN', N'POLO', N'2010', N'23RT547', N'Khí Gas', N'Automatic', N'260')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'VOLKSWAGEN', N'JETTA', N'2009', N'23RT543', N'Điện', N'Số Tự Động', N'220')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'AUDI', N'A4', N'2009', N'34BL788', N'Diesel', N'Automatic', N'380')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'HONDA', N'CRV', N'2018', N'93B110906', N'Petrol', N'Automatic', N'800')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'Toyota', N'Vios', N'2010', N'93B15382', N'Xăng', N'Số Sàn', N'200')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'Mekong', N'paso990', N'2012', N'51C16505', N'Xăng', N'Số Sàn', N'1000')
INSERT [dbo].[CARS] ([Brand], [Model], [ProductYear], [Plate], [Fuel], [GearBox], [Price]) VALUES (N'Audi', N'Q7', N'2018', N'16A1232', N'Xăng', N'Số Kết Hợp', N'800')
--Bảng khách hàng
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Trần Minh Tấn', N'28647353', N'Lạng Sơn', N'0974638463')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lâm Trung Hiếu', N'28756354', N'Quảng Bình', N'0978656432')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Nguyễn Văn Khang', N'28653145', N'Lâm Đồng', N'01235120154')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lương Khả Siêu', N'28746124', N'Yên Bái', N'02713567421')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lâm Tấn Phát', N'28546951', N'Đồng Tháp', N'0245138413')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lương Văn Dũng', N'28648451', N'Bình Dương', N'0875213562')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Trần Văn Hồng', N'28451672', N'Bình Phước', N'01682457135')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Trần Minh Cường', N'285602700', N'Bình Phước', N'0975206769')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Phan Văn Khải', N'283374653', N'Long Khánh', N'0987645363')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lâm Tâm Như', N'286452725', N'Thượng Hải', N'097865363')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Trần Văn Dũng', N'278274746', N'Bình Phước', N'0129234378')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lê Thị Mỹ Duyên', N'28349854', N'Long Hưng', N'0983736333')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Chung Tấn Phát', N'2839734943', N'Bình Mỹ', N'09238473')
INSERT [dbo].[CUSTOMERS] ([Name], [CMND], [Addr], [PhoneNumber]) VALUES (N'Lê Đình Duẩn', N'285756474', N'Trường Thọ, Q Thủ Đức', N'0934847353')
--Bảng thuê xe
INSERT [dbo].[RENT] ([CustomerID], [CarID], [RentDate], [ReturnDate]) VALUES (2, 3, CAST(N'2018-12-13' AS Date), CAST(N'2018-12-27' AS Date))
INSERT [dbo].[RENT] ([CustomerID], [CarID], [RentDate], [ReturnDate]) VALUES (5, 6, CAST(N'2018-12-13' AS Date), CAST(N'2018-12-14' AS Date))
INSERT [dbo].[RENT] ([CustomerID], [CarID], [RentDate], [ReturnDate]) VALUES (3, 1, CAST(N'2018-11-11' AS Date), CAST(N'2018-12-17' AS Date))
INSERT [dbo].[RENT] ([CustomerID], [CarID], [RentDate], [ReturnDate]) VALUES (4, 6, CAST(N'2018-12-16' AS Date), CAST(N'2018-12-16' AS Date))
--Bảng Tài khoản
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'admin', 0, N'admin', 0)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'ql1', 0, N'ql', 1)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'kh1', 0, N'kh', 2)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'khachhang', 0, N'1111', 2)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'minhcuong', 0, N'1234', 0)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'administrator', 0, N'ad', 0)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'khachhang00', 0, N'1111', 2)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'kh01', 0, N'1111', 2)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'quanly00', 0, N'1111', 1)
INSERT [dbo].[USERS] ([UserName], [Position], [Password], [Type]) VALUES (N'cuongcuong', 0, N'1234', 2)
