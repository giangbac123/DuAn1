use master
go
drop database QLTHUVIEN
go
CREATE DATABASE QLTHUVIEN
GO
USE QLTHUVIEN
GO
CREATE TABLE NGUOIDUNG
(
	MAND VARCHAR(10) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(50) NOT NULL,
	GIOITINH BIT NOT NULL,
	DIACHI NVARCHAR(255) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	EMAIL VARCHAR(255) NOT NULL,
	CCCD VARCHAR(12) NOT NULL,
	MATKHAU VARCHAR(50) NOT NULL,
	CHUCDANH BIT NOT NULL
)
GO
insert into NGUOIDUNG values ('1','Giang',1,'Tuyen quang','1-1-2000','1','giangkl1582k4@gmail.com','1','1',1)
insert into NGUOIDUNG values ('2',N'Khiếu',1,'Tuyen quang','1-1-2000','1','giangkl1582k4@gmail.com','1','2',0)
insert into NGUOIDUNG values ('3',N'Ngọc',0,'Tuyen quang','1-1-2000','1','giangkl1582k4@gmail.com','1','3',0)

select * from NGUOIDUNG
CREATE TABLE TACGIA
(
	MATG VARCHAR(10) NOT NULL PRIMARY KEY,
	TENTG NVARCHAR(50) NOT NULL
)
GO
insert into TACGIA values
('1',N'Tojiyama'),
('2,',N'Kim lâm'),
('3',N'Ronaldo'),
('4',N'M10'),
('5',N'Nguyễn Ngọc Ngạn')
select * from TACGIA
CREATE TABLE THELOAI
(
	MATL VARCHAR(10) NOT NULL PRIMARY KEY,
	TENTL NVARCHAR(50) NOT NULL
)
GO

insert into THELOAI values
('1',N'hài'),
('2,',N'Buồn'),
('3',N'Manga'),
('4',N'Bựa'),
('5',N'Bi kịch')
select * from THELOAI
CREATE TABLE NHAXUATBAN
(
	MANXB VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNXB NVARCHAR(50) NOT NULL,
	DIACHI NVARCHAR(255) NOT NULL,
	SDT VARCHAR(10) NOT NULL
)
GO
insert into NHAXUATBAN values
('1',N'Kim đồng',N'HN','342'),
('2',N'Hoa hồng',N'hcm','2346432'),
('3',N'Kim đồng',N'HN','342'),
('4',N'Kim đồng',N'HN','342'),
('5',N'Kim đồng',N'HN','342')
select * from NHAXUATBAN
CREATE TABLE SACH
(
	MASACH VARCHAR(10) NOT NULL PRIMARY KEY,
	TENSACH NVARCHAR(50) NOT NULL,
	SOLUONG INT NOT NULL,
	NGAYXB DATE,
	SOTRANG INT,
	GIABAN MONEY NOT NULL,
	TRANGTHAI NVARCHAR(50)
)
GO
insert into SACH  values
('SACH001',N'Cha giàu cha nghèo',1000,'1-1-1900',1023,10000,''),
('SACH002',N'Dragon ball',1000,'1-1-1900',1023,10000,''),
('SACH003',N'Naruto',1000,'1-1-1900',1023,10000,''),
('SACH004',N'Tiếng việt',1000,'1-1-1900',1023,10000,''),
('SACH005',N'Giáo dục',1000,'1-1-1900',1023,10000,''),
('SACH006',N'Sĩ diện',1000,'1-1-1900',1023,10000,'')
CREATE TABLE SACHCT
(
	MASACHCT int identity(1,1) NOT NULL PRIMARY KEY,
	MASACH VARCHAR(10) NOT NULL FOREIGN KEY(MASACH) REFERENCES SACH(MASACH),
	MATG VARCHAR(10) FOREIGN KEY(MATG) REFERENCES TACGIA(MATG),
	MATL VARCHAR(10) FOREIGN KEY(MATL) REFERENCES THELOAI(MATL),
	MANXB VARCHAR(10) FOREIGN KEY(MANXB) REFERENCES NHAXUATBAN(MANXB)
)
GO
CREATE TABLE PHIEUMUON
(
	MAMUON VARCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50) NOT NULL,
	CCCD VARCHAR(12),
	TRANGTHAI NVARCHAR(50)
)
GO
CREATE TABLE PHIEUMUONCT
(
	MAMUONCT int identity(1,1) NOT NULL PRIMARY KEY,
	MAMUON VARCHAR(10) NOT NULL FOREIGN KEY(MAMUON) REFERENCES PHIEUMUON(MAMUON),
	MASACH VARCHAR(10) NOT NULL FOREIGN KEY(MASACH) REFERENCES SACH(MASACH),
	SOLUONG INT NOT NULL,
	NGAYMUON DATE NOT NULL,
	NGAYTRA DATE NOT NULL,
	TIENPHI INT NOT NULL
)
GO
CREATE TABLE PHIEUTRA
(
	MATRA VARCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50) NOT NULL,
	CCCD VARCHAR(12)
)
GO
CREATE TABLE PHIEUTRACT
(
	MATRACT int identity(1,1) NOT NULL PRIMARY KEY,
	MATRA VARCHAR(10) NOT NULL FOREIGN KEY(MATRA) REFERENCES PHIEUTRA(MATRA),
	MASACH VARCHAR(10) NOT NULL FOREIGN KEY(MASACH) REFERENCES SACH(MASACH),
	SOLUONG INT NOT NULL,
	TRANGTHAI NVARCHAR(50),
	NGAYMUON DATE NOT NULL,
	NGAYTRA DATE NOT NULL
)
GO
CREATE TABLE PHIEUTRACT_XUPHAT
(
    MATRACT_XP int identity(1,1) NOT NULL PRIMARY KEY,
    MATRA VARCHAR(10) NOT NULL FOREIGN KEY(MATRA) REFERENCES PHIEUTRA(MATRA),
	MASACH VARCHAR(10) NOT NULL FOREIGN KEY(MASACH) REFERENCES SACH(MASACH),
    SOLUONG INT NOT NULL, -- Số lượng vi phạt (mặc định là 1)
    TIENPHAT INT,        -- Số tiền phạt
    GHICHU NVARCHAR(255)            -- Ghi chú/lý do phạt
)
GO
---Scaffold-DbContext "Data Source=HOANGTHANHGIANG\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models