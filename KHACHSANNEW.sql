﻿CREATE DATABASE DoAnKhachSan
GO
CREATE TABLE DICHVU(
	MADV CHAR(8) PRIMARY KEY,
	SANPHAM NVARCHAR(50),
	GIATIEN MONEY,
	SOLUONG INT
)
GO
CREATE TABLE TAIKHOAN(
	MATK CHAR(8) PRIMARY KEY,
	USERNAME NVARCHAR(24),
	LOAINV int check (loainv in(1,2,3)),
	MATKHAU CHAR(10)
)
GO
CREATE TABLE TAPVU
(
	MATV CHAR(8) PRIMARY KEY,
	TENTV NVARCHAR(50),
	SDT INT,
	CCCD CHAR (12),
	DIACHI NVARCHAR (100),
	NGAYSINH DATETIME,
	NGAYVAOLAM DATETIME,
	GIOITINH bit CHECK(GIOITINH IN(0,1)),
	MUCLUONG MONEY,
	MATK CHAR (8),
	FOREIGN KEY (MATK) REFERENCES TAIKHOAN(MATK)
)
GO
CREATE TABLE PHONG
(
	MAPHONG CHAR(8) PRIMARY KEY,
	SOPHONG INT,
	LOAIPHONG NVARCHAR(20),
	GIATIEN MONEY,
	SUCCHUA INT,
	MOTA NVARCHAR(100),
	STA_TUS INT CHECK (STA_TUS IN (1, 2, 3))
)
GO
CREATE TABLE TIEPTAN
(
	MATT CHAR(8) PRIMARY KEY,
	TENTT NVARCHAR(50), 
	SDT INT, 
	CCCD CHAR (12),
	DIACHI NVARCHAR (100),
	NGAYSINH DATETIME,
	NGAYVAOLAM DATETIME,
	GIOITINH bit CHECK(GIOITINH IN(0,1)),
	MUCLUONG MONEY,
	MAKH CHAR(8),
	MATK CHAR (8),
	FOREIGN KEY (MATK) REFERENCES TAIKHOAN(MATK)
)
GO
CREATE TABLE THUNGAN
(
	MATN CHAR(8) PRIMARY KEY, 
	TENTN NVARCHAR(50),
	SDT INT,
	CCCD CHAR (12),
	DIACHI NVARCHAR (100),
	NGAYSINH DATETIME, 
	NGAYVAOLAM DATETIME,
	GIOITINH bit CHECK(GIOITINH IN(0,1)),
	MUCLUONG MONEY,
	MAKH CHAR(8),
	MATK CHAR (8),
	FOREIGN KEY (MATK) REFERENCES TAIKHOAN(MATK)
)
GO
CREATE TABLE KHACHHANG (
	 MAKH CHAR(8) PRIMARY KEY,
	 TENKH NVARCHAR(50),
	 CCCD CHAR(12),
	 SDT INT,
	 NGAYSINH DATETIME, 
	 GIOITINH bit CHECK(GIOITINH IN(0,1)),
	 QUOCTICH NVARCHAR(50),
	 MAPHONG CHAR (8),
	 MATN CHAR (8),
	 MATT CHAR (8)
	 FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG),
     FOREIGN KEY (MATN) REFERENCES THUNGAN(MATN),
     FOREIGN KEY (MATT) REFERENCES TIEPTAN(MATT)
)
GO

CREATE TABLE LICHSUDONDEP
(
	MATV CHAR (8),
	MAPHONG CHAR (8),
	NGAYDON DATETIME,
	PRIMARY KEY(MATV,MAPHONG),
	FOREIGN KEY (MATV) REFERENCES TAPVU(MATV),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
)
GO
CREATE TABLE HOADON
(
	MAHD CHAR(8) PRIMARY KEY, 
	TONGTHANHTOAN MONEY, 
	LOAITHANHTOAN NVARCHAR(20), 
	TINHTRANGTT BIT,
	MAKH CHAR(8),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
)
GO
CREATE TABLE TT_NHANPHONG
(
	MAPHONG CHAR(8) PRIMARY KEY, 
	SOPHONG INT, 
	CCCD CHAR(12), 
	SDT INT,
	MAKH CHAR(8),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
)
GO

CREATE TABLE TT_TRAPHONG
(
	MAPHONG CHAR(8) PRIMARY KEY, 
	SOPHONG INT , 
	CCCD CHAR(12),
	SDT INT,
	MAKH CHAR(8),
	TENKH NVARCHAR(50),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
)
go

CREATE TABLE LISHSU_DATPHONG(
	MAPHONG CHAR(8) PRIMARY KEY,
	MAKH CHAR(8),
	SOPHONG INT,
	GIATIEN MONEY,
	LOAIPHONG NVARCHAR(20),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)

)
go
CREATE TABLE CHITIETHOADON(
	MAHD CHAR(8) PRIMARY KEY,
	TENKH CHAR(50),
	CCCD CHAR(12), 
	SDT INT,
	NGAYSINH DATETIME,
	GIOITINH bit CHECK(GIOITINH IN(0,1)),
	QUOCTICH NVARCHAR(20),
	TONGTHANHTOAN MONEY,
	MAKH CHAR (8),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	foreign key (MAHD) references HOADON(MAHD)
)
go
CREATE TABLE SUDUNG_DICHVU(
	MADV CHAR(8) PRIMARY KEY,
	SANPHAM NVARCHAR(50),
	SOLUONG INT,
	THANHTIEN MONEY,
	MAKH CHAR(8),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	foreign key (MADV) references DICHVU(MADV)
)


INSERT INTO DICHVU (MADV, SANPHAM, GIATIEN, SOLUONG)
VALUES 
('DV001', 'Bánh sandwich', 20000, 10),
('DV002', 'Bánh kem', 50000, 15),
('DV003', 'Bánh mì', 10000, 20),
('DV004', 'Há cảo', 25000, 12),
('DV005', 'Nước ngọt', 10000, 30),
('DV006', 'Bàn chải đánh răng', 5000, 25),
('DV007', 'Bao cao su', 10000, 8),
('DV008', 'Bánh tráng', 15000, 18),
('DV009', 'Trà đá', 12000, 22),
('DV010', 'Cà phê', 25000, 10)

-- Nhập dữ liệu cho bảng TAIKHOAN
-- 10 tài khoản đầu tiên với LOAINV = 1
INSERT INTO TAIKHOAN (MATK, USERNAME, LOAINV, MATKHAU)
VALUES 
('TK001', 'user1', 1, 'password1'),
('TK002', 'user2', 1, 'password2'),
('TK003', 'user3', 1, 'password3'),
('TK004', 'user4', 1, 'password4'),
('TK005', 'user5', 1, 'password5'),
('TK006', 'user6', 1, 'password6'),
('TK007', 'user7', 1, 'password7'),
('TK008', 'user8', 1, 'password8'),
('TK009', 'user9', 1, 'password9'),
('TK010', 'user10', 1, 'password10');

-- 10 tài khoản tiếp theo với LOAINV = 2
INSERT INTO TAIKHOAN (MATK, USERNAME, LOAINV, MATKHAU)
VALUES 
('TK011', 'user11', 2, 'password11'),
('TK012', 'user12', 2, 'password12'),
('TK013', 'user13', 2, 'password13'),
('TK014', 'user14', 2, 'password14'),
('TK015', 'user15', 2, 'password15'),
('TK016', 'user16', 2, 'password16'),
('TK017', 'user17', 2, 'password17'),
('TK018', 'user18', 2, 'password18'),
('TK019', 'user19', 2, 'password19'),
('TK020', 'user20', 2, 'password20');

-- 10 tài khoản cuối cùng với LOAINV = 3
INSERT INTO TAIKHOAN (MATK, USERNAME, LOAINV, MATKHAU)
VALUES 
('TK021', 'user21', 3, 'password21'),
('TK022', 'user22', 3, 'password22'),
('TK023', 'user23', 3, 'password23'),
('TK024', 'user24', 3, 'password24'),
('TK025', 'user25', 3, 'password25'),
('TK026', 'user26', 3, 'password26'),
('TK027', 'user27', 3, 'password27'),
('TK028', 'user28', 3, 'password28'),
('TK029', 'user29', 3, 'password29'),
('TK030', 'user30', 3, 'password30')

INSERT INTO TAPVU (MATV, TENTV, SDT, CCCD, DIACHI, NGAYSINH, NGAYVAOLAM, GIOITINH, MUCLUONG, MATK)
VALUES 
('TV001', 'Nguyễn Văn A', 123456789, '123456789012', '123 ABC, TP. HCM', '1990-01-01', '2024-04-23', 1, 10000000, 'TK001'),
('TV002', 'Nguyễn Thị B', 987654321, '987654321012', '456 XYZ, TP. HCM', '1995-05-05', '2024-04-24', 0, 8000000, 'TK002'),
('TV003', 'Trần Văn C', 135792468, '135792468012', '789 DEF, TP. HCM', '1992-02-02', '2024-04-25', 1, 9000000, 'TK003'),
('TV004', 'Trần Thị D', 246813579, '246813579012', '246 GHI, TP. HCM', '1988-08-08', '2024-04-26', 0, 8500000, 'TK004'),
('TV005', 'Lê Văn E', 369258147, '369258147012', '369 JKL, TP. HCM', '1997-07-07', '2024-04-27', 1, 9500000, 'TK005'),
('TV006', 'Lê Thị F', 147258369, '147258369012', '147 MNO, TP. HCM', '1993-03-03', '2024-04-28', 0, 7500000, 'TK006'),
('TV007', 'Hoàng Văn G', 258369147, '258369147012', '258 PQR, TP. HCM', '1998-06-06', '2024-04-29', 1, 8500000, 'TK007'),
('TV008', 'Hoàng Thị H', 369147258, '369147258012', '369 STU, TP. HCM', '1994-04-04', '2024-04-30', 0, 8200000, 'TK008'),
('TV009', 'Phạm Văn I', 951753852, '951753852012', '951 VWX, TP. HCM', '1985-05-05', '2024-05-01', 1, 8800000, 'TK009'),
('TV010', 'Phạm Thị J', 753951852, '753951852012', '753 YZ, TP. HCM', '1989-09-09', '2024-05-02', 0, 7200000, 'TK010')

INSERT INTO PHONG (MAPHONG, SOPHONG, LOAIPHONG, GIATIEN, SUCCHUA, MOTA, STA_TUS)
VALUES 
('P001', 101, 'Phòng Đơn', 500000, 1, 'Phòng đơn có 1 giường đơn', 1),
('P002', 102, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1),
('P003', 103, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1),
('P004', 104, 'Phòng Gia Đình', 1200000, 4, 'Phòng gia đình có 2 giường đôi', 1),
('P005', 105, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1),
('P006', 106, 'Phòng Đơn', 500000, 1, 'Phòng đơn có 1 giường đơn', 1),
('P007', 107, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1),
('P008', 108, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1),
('P009', 109, 'Phòng Gia Đình', 1200000, 4, 'Phòng gia đình có 2 giường đôi', 1),
('P010', 110, 'Phòng Đôi', 800000, 2, 'Phòng đôi có 1 giường đôi', 1)

INSERT INTO TIEPTAN (MATT, TENTT, SDT, CCCD, DIACHI, NGAYSINH, NGAYVAOLAM, GIOITINH, MUCLUONG, MAKH, MATK)
VALUES 
('TT001', 'Nguyễn Văn A', 123456789, '123456789012', '12 Lê Lợi, Quận 1, TP.HCM', '1990-01-01', '2024-04-22', 1, 5000000, 'KH001', 'TK001'),
('TT002', 'Nguyễn Thị B', 987654321, '987654321012', '34 Nguyễn Huệ, Quận 3, TP.HCM', '1991-02-02', '2024-04-22', 0, 5500000, 'KH002', 'TK002'),
('TT003', 'Trần Văn C', 135792468, '135792468012', '56 Nguyễn Bỉnh Khiêm, Quận 5, TP.HCM', '1992-03-03', '2024-04-22', 1, 6000000, 'KH003', 'TK003'),
('TT004', 'Trần Thị D', 246813579, '246813579012', '78 Lê Duẩn, Quận 10, TP.HCM', '1993-04-04', '2024-04-22', 0, 6500000, 'KH004', 'TK004'),
('TT005', 'Lê Văn E', 369258147, '369258147012', '90 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '1994-05-05', '2024-04-22', 1, 7000000, 'KH005', 'TK005'),
('TT006', 'Lê Thị F', 147258369, '147258369012', '101 Võ Văn Tần, Quận 3, TP.HCM', '1995-06-06', '2024-04-22', 0, 7500000, 'KH006', 'TK006'),
('TT007', 'Hoàng Văn G', 258369147, '258369147012', '112 Hai Bà Trưng, Quận 1, TP.HCM', '1996-07-07', '2024-04-22', 1, 8000000, 'KH007', 'TK007'),
('TT008', 'Hoàng Thị H', 369147258, '369147258012', '123 Trần Hưng Đạo, Quận 10, TP.HCM', '1997-08-08', '2024-04-22', 0, 8500000, 'KH008', 'TK008'),
('TT009', 'Phạm Văn I', 951753852, '951753852012', '134 Đề Thám, Quận 1, TP.HCM', '1998-09-09', '2024-04-22', 1, 9000000, 'KH009', 'TK009'),
('TT010', 'Phạm Thị J', 753951852, '753951852012', '145 Đồng Khởi, Quận 1, TP.HCM', '1999-10-10', '2024-04-22', 0, 9500000, 'KH010', 'TK010');

INSERT INTO THUNGAN (MATN, TENTN, SDT, CCCD, DIACHI, NGAYSINH, NGAYVAOLAM, GIOITINH, MUCLUONG, MAKH, MATK)
VALUES 
('TN001', 'Nguyễn Văn A', 123456789, '123456789012', '12 Lê Lợi, Quận 1, TP.HCM', '1990-01-01', '2024-04-22', 1, 5000000, 'KH001', 'TK011'),
('TN002', 'Nguyễn Thị B', 987654321, '987654321012', '34 Nguyễn Huệ, Quận 3, TP.HCM', '1991-02-02', '2024-04-22', 0, 5500000, 'KH002', 'TK012'),
('TN003', 'Trần Văn C', 135792468, '135792468012', '56 Nguyễn Bỉnh Khiêm, Quận 5, TP.HCM', '1992-03-03', '2024-04-22', 1, 6000000, 'KH003', 'TK013'),
('TN004', 'Trần Thị D', 246813579, '246813579012', '78 Lê Duẩn, Quận 10, TP.HCM', '1993-04-04', '2024-04-22', 0, 6500000, 'KH004', 'TK014'),
('TN005', 'Lê Văn E', 369258147, '369258147012', '90 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '1994-05-05', '2024-04-22', 1, 7000000, 'KH005', 'TK015'),
('TN006', 'Lê Thị F', 147258369, '147258369012', '101 Võ Văn Tần, Quận 3, TP.HCM', '1995-06-06', '2024-04-22', 0, 7500000, 'KH006', 'TK016'),
('TN007', 'Hoàng Văn G', 258369147, '258369147012', '112 Hai Bà Trưng, Quận 1, TP.HCM', '1996-07-07', '2024-04-22', 1, 8000000, 'KH007', 'TK017'),
('TN008', 'Hoàng Thị H', 369147258, '369147258012', '123 Trần Hưng Đạo, Quận 10, TP.HCM', '1997-08-08', '2024-04-22', 0, 8500000, 'KH008', 'TK018'),
('TN009', 'Phạm Văn I', 951753852, '951753852012', '134 Đề Thám, Quận 1, TP.HCM', '1998-09-09', '2024-04-22', 1, 9000000, 'KH009', 'TK019'),
('TN010', 'Phạm Thị J', 753951852, '753951852012', '145 Đồng Khởi, Quận 1, TP.HCM', '1999-10-10', '2024-04-22', 0, 9500000, 'KH010', 'TK020');

INSERT INTO KHACHHANG (MAKH, TENKH, CCCD, SDT, NGAYSINH, GIOITINH, QUOCTICH, MAPHONG, MATN, MATT)
VALUES 
('KH001', 'Nguyễn Văn A', '123456789012', 123456789, '1990-01-01', 1, 'Việt Nam', 'P001', 'TN001', 'TT001'),
('KH002', 'Nguyễn Thị B', '987654321012', 987654321, '1991-02-02', 0, 'Việt Nam', 'P002', 'TN002', 'TT002'),
('KH003', 'Trần Văn C', '135792468012', 135792468, '1992-03-03', 1, 'Việt Nam', 'P003', 'TN003', 'TT003'),
('KH004', 'Trần Thị D', '246813579012', 246813579, '1993-04-04', 0, 'Việt Nam', 'P004', 'TN004', 'TT004'),
('KH005', 'Lê Văn E', '369258147012', 369258147, '1994-05-05', 1, 'Việt Nam', 'P005', 'TN005', 'TT005'),
('KH006', 'Lê Thị F', '147258369012', 147258369, '1995-06-06', 0, 'Việt Nam', 'P006', 'TN006', 'TT006'),
('KH007', 'Hoàng Văn G', '258369147012', 258369147, '1996-07-07', 1, 'Việt Nam', 'P007', 'TN007', 'TT007'),
('KH008', 'Hoàng Thị H', '369147258012', 369147258, '1997-08-08', 0, 'Việt Nam', 'P008', 'TN008', 'TT008'),
('KH009', 'Phạm Văn I', '951753852012', 951753852, '1998-09-09', 1, 'Việt Nam', 'P009', 'TN009', 'TT009'),
('KH010', 'Phạm Thị J', '753951852012', 753951852, '1999-10-10', 0, 'Việt Nam', 'P010', 'TN010', 'TT010');

INSERT INTO LICHSUDONDEP (MATV, MAPHONG, NGAYDON)
VALUES 
('TV001', 'P001', '2024-04-22'),
('TV002', 'P002', '2024-04-22'),
('TV003', 'P003', '2024-04-22'),
('TV004', 'P004', '2024-04-22'),
('TV005', 'P005', '2024-04-22'),
('TV006', 'P006', '2024-04-22'),
('TV007', 'P007', '2024-04-22'),
('TV008', 'P008', '2024-04-22'),
('TV009', 'P009', '2024-04-22'),
('TV010', 'P010', '2024-04-22');

INSERT INTO HOADON (MAHD, TONGTHANHTOAN, LOAITHANHTOAN, TINHTRANGTT, MAKH)
VALUES 
('HD001', 7000000, 'Tiền mặt', 1, 'KH001'),
('HD002', 8600000, 'Chuyển khoản', 1, 'KH002'),
('HD003', 6650000, 'Tiền mặt', 1, 'KH003'),
('HD004', 7800000, 'Chuyển khoản', 1, 'KH004'),
('HD005', 7200000, 'Tiền mặt', 1, 'KH005'),
('HD006', 9500000, 'Chuyển khoản', 1, 'KH006'),
('HD007', 6900000, 'Tiền mặt', 1, 'KH007'),
('HD008', 8050000, 'Chuyển khoản', 1, 'KH008'),
('HD009', 8400000, 'Tiền mặt', 1, 'KH009'),
('HD010', 7600000, 'Chuyển khoản', 1, 'KH010');

INSERT INTO TT_NHANPHONG (MAPHONG, SOPHONG, CCCD, SDT, MAKH)
VALUES 
('P001', 101, '123456789012', 123456789, 'KH001'),
('P002', 102, '987654321012', 987654321, 'KH002'),
('P003', 103, '135792468012', 135792468, 'KH003'),
('P004', 104, '246813579012', 246813579, 'KH004'),
('P005', 105, '369258147012', 369258147, 'KH005'),
('P006', 106, '147258369012', 147258369, 'KH006'),
('P007', 107, '258369147012', 258369147, 'KH007'),
('P008', 108, '369147258012', 369147258, 'KH008'),
('P009', 109, '951753852012', 951753852, 'KH009'),
('P010', 110, '753951852012', 753951852, 'KH010');

INSERT INTO TT_TRAPHONG (MAPHONG, SOPHONG, CCCD, SDT, MAKH, TENKH)
VALUES 
('P001', 101, '123456789012', 123456789, 'KH001', 'Nguyễn Văn A'),
('P002', 102, '987654321012', 987654321, 'KH002', 'Nguyễn Thị B'),
('P003', 103, '135792468012', 135792468, 'KH003', 'Trần Văn C'),
('P004', 104, '246813579012', 246813579, 'KH004', 'Trần Thị D'),
('P005', 105, '369258147012', 369258147, 'KH005', 'Lê Văn E'),
('P006', 106, '147258369012', 147258369, 'KH006', 'Lê Thị F'),
('P007', 107, '258369147012', 258369147, 'KH007', 'Hoàng Văn G'),
('P008', 108, '369147258012', 369147258, 'KH008', 'Hoàng Thị H'),
('P009', 109, '951753852012', 951753852, 'KH009', 'Phạm Văn I'),
('P010', 110, '753951852012', 753951852, 'KH010', 'Phạm Thị J');

INSERT INTO LISHSU_DATPHONG (MAPHONG, MAKH, SOPHONG, GIATIEN, LOAIPHONG)
VALUES 
('P001', 'KH001', 101, 500000, 'Phòng Đơn'),
('P002', 'KH002', 102, 800000, 'Phòng Đôi'),
('P003', 'KH003', 103, 800000, 'Phòng Đôi'),
('P004', 'KH004', 104, 1200000, 'Phòng Gia Đình'),
('P005', 'KH005', 105, 800000, 'Phòng Đôi'),
('P006', 'KH006', 106, 500000, 'Phòng Đơn'),
('P007', 'KH007', 107, 800000, 'Phòng Đôi'),
('P008', 'KH008', 108, 800000, 'Phòng Đôi'),
('P009', 'KH009', 109, 1200000, 'Phòng Gia Đình'),
('P010', 'KH010', 110, 800000, 'Phòng Đôi');

INSERT INTO CHITIETHOADON (MAHD, TENKH, CCCD, SDT, NGAYSINH, GIOITINH, QUOCTICH, TONGTHANHTOAN, MAKH)
VALUES 
('HD001', 'Nguyễn Văn A', '123456789012', 123456789, '1990-01-01', 1, 'Việt Nam', 7000000, 'KH001'),
('HD002', 'Nguyễn Thị B', '987654321012', 987654321, '1995-05-05', 0, 'Việt Nam', 8600000, 'KH002'),
('HD003', 'Trần Văn C', '135792468012', 135792468, '1992-02-02', 1, 'Việt Nam', 6650000, 'KH003'),
('HD004', 'Trần Thị D', '246813579012', 246813579, '1988-08-08', 0, 'Việt Nam', 7800000, 'KH004'),
('HD005', 'Lê Văn E', '369258147012', 369258147, '1997-07-07', 1, 'Việt Nam', 7200000, 'KH005'),
('HD006', 'Lê Thị F', '147258369012', 147258369, '1993-03-03', 0, 'Việt Nam', 9500000, 'KH006'),
('HD007', 'Hoàng Văn G', '258369147012', 258369147, '1998-06-06', 1, 'Việt Nam', 6900000, 'KH007'),
('HD008', 'Hoàng Thị H', '369147258012', 369147258, '1994-04-04', 0, 'Việt Nam', 8050000, 'KH008'),
('HD009', 'Phạm Văn I', '951753852012', 951753852, '1985-05-05', 1, 'Việt Nam', 8400000, 'KH009'),
('HD010', 'Phạm Thị J', '753951852012', 753951852, '1989-09-09', 0, 'Việt Nam', 7600000, 'KH010');

INSERT INTO SUDUNG_DICHVU (MADV, SANPHAM, SOLUONG, THANHTIEN, MAKH)
VALUES 
('DV001', 'Bánh sandwich', 10, 200000, 'KH001'),
('DV002', 'Bánh kem', 5, 300000, 'KH002'),
('DV003', 'Bánh mì', 8, 200000, 'KH003'),
('DV004', 'Há cảo', 15, 450000, 'KH004'),
('DV001', 'Bánh sandwich', 10, 200000, 'KH005'),
('DV002', 'Bánh kem', 5, 300000, 'KH006'),
('DV003', 'Bánh mì', 8, 200000, 'KH007'),
('DV004', 'Há cảo', 15, 450000, 'KH008'),
('DV001', 'Bánh sandwich', 10, 200000, 'KH009'),
('DV002', 'Bánh kem', 5, 300000, 'KH010');


