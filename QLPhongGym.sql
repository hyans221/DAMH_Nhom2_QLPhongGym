create database QLPhongGym
use QLPhongGym
go

--Tạo các bảng
CREATE TABLE NhanVien (
    NhanVienID INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    NgayVaoLam DATE,
);
go
CREATE TABLE TaiKhoan (
    TaiKhoanID INT IDENTITY(1,1) PRIMARY KEY,
    TenDN NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(50),
	NhanVienID int,
	Quyen NVARCHAR(50),
	FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
go
CREATE TABLE HuanLuyenVien (
    HLV_ID INT IDENTITY(1,1) PRIMARY KEY,
	NhanVienID INT,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenMon NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
	FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
go
CREATE TABLE ChiNhanh (
    ChiNhanhID INT IDENTITY(1,1) PRIMARY KEY,
    TenDiaDiem NVARCHAR(100), --Cti Bình tân, Cti Bình Thạnh
	DiaDiem NVARCHAR(100), --Bình tân, Bình thạnh
    MoTa NVARCHAR(255),
);
go
CREATE TABLE TheKhachHang (
    TheKhachHangID INT IDENTITY(1,1) PRIMARY KEY, --Thêm 1 khách hàng mới, cũng là mã thẻ thành viên
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
	CCCD VARCHAR(25),
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(15),
    DiaChi NVARCHAR(255),
	LoaiThanhVien NVARCHAR(50), --Loại thành viên: Classic, Royal 
	ThoiGianHieuLuc datetime, --Thời gian hiệu lực của thẻ
	SoBuoiTapCungPT int default 0,
);
go
CREATE TABLE GoiTap (
    GoiTapID INT IDENTITY(1,1) PRIMARY KEY,
	ThoiGian int,
	GiaTien DECIMAL(18, 2),
	Mota   NVARCHAR(100),
);
go

CREATE TABLE ThuePT (
    GoiThuePTID INT IDENTITY(1,1) PRIMARY KEY,
	SoBuoiThue int,
	GiaTien DECIMAL(18, 2),
	Mota   NVARCHAR(100),
);
go
CREATE TABLE HoaDon (
    HoaDonID INT IDENTITY(1,1) PRIMARY KEY,
    TheKhachHangID INT,
	NhanVienID int,
    NgayThanhToan DATE,
	LoaiHoaDon NVARCHAR(100), --Thanh toán mới, gia hạn
	GoiTapID int,
	GoiThuePTID int,
	FOREIGN KEY (GoiThuePTID) REFERENCES ThuePT(GoiThuePTID),
	TongTien DECIMAL(18, 2),
	FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID),
    FOREIGN KEY (TheKhachHangID) REFERENCES TheKhachHang(TheKhachHangID),
	FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
go
CREATE TABLE LichTap (
    LichTapID INT IDENTITY(1,1) PRIMARY KEY,
    HLV_ID INT,
	ChiNhanhID INT,
    ThoiGianBatDau TIME,
    ThoiGianKetThuc TIME,
	NgayBatDau DATETIME,
	TrangThai NVARCHAR(50), --Đã đặt, trống
    FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID),
	FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID),
);
go
CREATE TABLE DangKyLichTap (
    DangKyHLV_ID INT IDENTITY(1,1) PRIMARY KEY,
    TheKhachHangID INT,
    LichTapID INT,
    FOREIGN KEY (TheKhachHangID) REFERENCES TheKhachHang(TheKhachHangID),
    FOREIGN KEY (LichTapID) REFERENCES LichTap(LichTapID)
);

go
CREATE TABLE ThietBi (
    ThietBiID INT IDENTITY(1,1) PRIMARY KEY,
    TenThietBi NVARCHAR(100) NOT NULL,
	PhongTapID INT, -- phòng thì có nhiều thiết bị để sử dụng
    MoTa NVARCHAR(255),
    TrangThai NVARCHAR(50),
	ChiNhanhID INT,
	FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID)
);
go
CREATE TABLE SuDungThietBi (
    SuDungID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    ThoiGianBatDau DATE,
    ThoiGianKetThuc DATE,
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);
go
CREATE TABLE LichSuBaoTri (
    BaoTriID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    NgayBaoTri DATE,
    MoTa NVARCHAR(255),
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);
go


--Thêm dữ liệu

-- Thêm dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, NgayVaoLam)
VALUES 
(N'Nguyen Van A', N'Nhân viên', '0123456789', 'vana@example.com', '2022-01-01'),
(N'Le Thi B', N'Quản lý', '0987654321', 'leb@example.com', '2022-02-01'),
(N'Tran Van C', N'Nhân viên', '0912345678', 'tranc@example.com', '2022-03-01'),
(N'Pham Thi D', N'Nhân viên', '0934567890', 'phamd@example.com', '2022-04-01'),
(N'Doan Van E', N'Quản lý', '0945678901', 'doane@example.com', '2022-05-01');

-- Thêm dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TenDN, MatKhau, NhanVienID, Quyen)
VALUES 
(N'vana', 'pass123', 1, 'Admin'),
(N'leb', 'pass123', 2, 'User'),
(N'tranc', 'pass123', 3, 'User'),
(N'phamd', 'pass123', 4, 'Admin'),
(N'doane', 'pass123', 5, 'User');

-- Thêm dữ liệu cho bảng HuanLuyenVien
INSERT INTO HuanLuyenVien (NhanVienID, HoTen, ChuyenMon, SoDienThoai, Email)
VALUES 
(1, N'Nguyen Van A', N'Thể hình', '0123456789', 'vana@example.com'),
(2, N'Le Thi B', N'Yoga', '0987654321', 'leb@example.com'),
(3, N'Tran Van C', N'Thể lực', '0912345678', 'tranc@example.com'),
(4, N'Pham Thi D', N'Kickboxing', '0934567890', 'phamd@example.com'),
(5, N'Doan Van E', N'Pilates', '0945678901', 'doane@example.com');

-- Thêm dữ liệu cho bảng ChiNhanh
INSERT INTO ChiNhanh (TenDiaDiem, DiaDiem, MoTa)
VALUES 
(N'Chi nhánh Bình Tân', N'Bình Tân', N'Phòng tập hiện đại'),
(N'Chi nhánh Bình Thạnh', N'Bình Thạnh', N'Không gian thoáng mát'),
(N'Chi nhánh Quận 1', N'Quận 1', N'Trang bị cao cấp'),
(N'Chi nhánh Quận 3', N'Quận 3', N'Nằm ở trung tâm'),
(N'Chi nhánh Quận 5', N'Quận 5', N'Gần các khu mua sắm');

-- Thêm dữ liệu cho bảng TheKhachHang
INSERT INTO TheKhachHang (HoTen, NgaySinh, CCCD, GioiTinh, SoDienThoai, DiaChi, LoaiThanhVien, ThoiGianHieuLuc, SoBuoiTapCungPT)
VALUES 
(N'Nguyen A', '1990-01-01', '012345678912', N'Nam', '0912345678', N'Bình Tân', N'Classic', '2023-12-31', 10),
(N'Le B', '1992-02-02', '012345678913', N'Nữ', '0912345679', N'Bình Thạnh', N'Royal', '2024-12-31', 15),
(N'Tran C', '1991-03-03', '012345678914', N'Nam', '0912345680', N'Quận 1', N'Classic', '2025-01-01', 5),
(N'Pham D', '1993-04-04', '012345678915', N'Nữ', '0912345681', N'Quận 3', N'Royal', '2023-11-30', 20),
(N'Doan E', '1994-05-05', '012345678916', N'Nam', '0912345682', N'Quận 5', N'Classic', '2026-02-28', 8);

-- Thêm dữ liệu cho bảng GoiTap
INSERT INTO GoiTap (ThoiGian, GiaTien, MoTa)
VALUES 
(3, 500000, N'Gói 3 tháng'),
(6, 900000, N'Gói 6 tháng'),
(12, 1600000, N'Gói 12 tháng'),
(1, 100000, N'Gói tháng đầu tiên'),
(24, 3000000, N'Gói 24 tháng');

-- Thêm dữ liệu cho bảng ThuePT
INSERT INTO ThuePT (SoBuoiThue, GiaTien, MoTa)
VALUES 
(5, 200000, N'Gói thuê 5 buổi'),
(10, 350000, N'Gói thuê 10 buổi'),
(15, 500000, N'Gói thuê 15 buổi'),
(20, 700000, N'Gói thuê 20 buổi'),
(25, 850000, N'Gói thuê 25 buổi');

-- Thêm dữ liệu cho bảng HoaDon
INSERT INTO HoaDon (TheKhachHangID, NhanVienID, NgayThanhToan, LoaiHoaDon, GoiTapID, GoiThuePTID, TongTien)
VALUES 
(1, 1, '2023-01-01', N'Thanh toán mới', 1, 1, 700000),
(2, 2, '2023-02-01', N'Gia hạn', 2, 2, 1200000),
(3, 3, '2023-03-01', N'Thanh toán mới', 3, 3, 1800000),
(4, 4, '2023-04-01', N'Gia hạn', 4, 4, 2300000),
(5, 5, '2023-05-01', N'Thanh toán mới', 5, 5, 3200000);

-- Thêm dữ liệu cho bảng LichTap
INSERT INTO LichTap (HLV_ID, ChiNhanhID, ThoiGianBatDau, ThoiGianKetThuc, NgayBatDau, TrangThai)
VALUES 
(1, 1, '08:00', '09:00', '2023-06-01', N'Đã đặt'),
(2, 2, '10:00', '11:00', '2023-06-02', N'Trống'),
(3, 3, '12:00', '13:00', '2023-06-03', N'Đã đặt'),
(4, 4, '14:00', '15:00', '2023-06-04', N'Trống'),
(5, 5, '16:00', '17:00', '2023-06-05', N'Đã đặt');

-- Thêm dữ liệu cho bảng DangKyLichTap
INSERT INTO DangKyLichTap (TheKhachHangID, LichTapID)
VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- Thêm dữ liệu cho bảng ThietBi
INSERT INTO ThietBi (TenThietBi, PhongTapID, MoTa, TrangThai, ChiNhanhID)
VALUES 
(N'Máy chạy bộ', 1, N'Máy hiện đại', N'Sẵn sàng', 1),
(N'Xe đạp tập', 2, N'Xe bền bỉ', N'Đang sử dụng', 2),
(N'Máy tập tạ', 3, N'Máy chất lượng cao', N'Sẵn sàng', 3),
(N'Gậy thể hình', 4, N'Gậy nhẹ, chắc chắn', N'Đang sử dụng', 4),
(N'Tạ tay', 5, N'Tạ chất lượng', N'Sẵn sàng', 5);

-- Thêm dữ liệu cho bảng SuDungThietBi
INSERT INTO SuDungThietBi (ThietBiID, ThoiGianBatDau, ThoiGianKetThuc)
VALUES 
(1, '2023-01-01', '2023-01-15'),
(2, '2023-01-10', '2023-01-20'),
(3, '2023-01-15', '2023-01-25'),
(4, '2023-01-20', '2023-01-30'),
(5, '2023-01-25', '2023-02-04');

-- Thêm dữ liệu cho bảng LichSuBaoTri
INSERT INTO LichSuBaoTri (ThietBiID, NgayBaoTri, MoTa)
VALUES 
(1, '2023-02-01', N'Bảo trì định kỳ'),
(2, '2023-02-05', N'Bảo trì sửa chữa'),
(3, '2023-02-10', N'Bảo trì định kỳ'),
(4, '2023-02-15', N'Bảo trì sửa chữa'),
(5, '2023-02-20', N'Bảo trì định kỳ');
