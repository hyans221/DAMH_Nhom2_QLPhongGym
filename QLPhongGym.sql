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
    Email NVARCHAR(100) UNIQUE
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
	LoaiHoaDon NVARCHAR(10), --Thanh toán mới, gia hạn
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
	FOREIGN KEY (PhongTapID) REFERENCES PhongTap(PhongTapID)
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
-- Bảng NhanVien
INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, NgayVaoLam)
VALUES 
('Nguyen Van A', 'Nhân viên', '0123456789', 'vana@example.com', '2022-01-01'),
('Le Thi B', 'Quản lý', '0987654321', 'leb@example.com', '2022-02-01'),
('Tran Van C', 'Nhân viên', '0912345678', 'tranc@example.com', '2022-03-01'),
('Pham Thi D', 'Nhân viên', '0934567890', 'phamd@example.com', '2022-04-01'),
('Doan Van E', 'Quản lý', '0945678901', 'doane@example.com', '2022-05-01'),
('Ngo Thi F', 'Nhân viên', '0923456789', 'ngof@example.com', '2022-06-01'),
('Vu Van G', 'Nhân viên', '0913456789', 'vug@example.com', '2022-07-01'),
('Ly Thi H', 'Quản lý', '0901234567', 'lyh@example.com', '2022-08-01'),
('Dang Van I', 'Nhân viên', '0986543210', 'dangi@example.com', '2022-09-01'),
('Hoang Thi J', 'Nhân viên', '0971234567', 'hoangj@example.com', '2022-10-01');

-- Bảng TaiKhoan
INSERT INTO TaiKhoan (TenDN, MatKhau, NhanVienID, Quyen)
VALUES 
('vana', 'pass123', 1, 'Admin'),
('leb', 'pass123', 2, 'User'),
('tranc', 'pass123', 3, 'User'),
('phamd', 'pass123', 4, 'Admin'),
('doane', 'pass123', 5, 'User'),
('ngof', 'pass123', 6, 'User'),
('vug', 'pass123', 7, 'User'),
('lyh', 'pass123', 8, 'Admin'),
('dangi', 'pass123', 9, 'User'),
('hoangj', 'pass123', 10, 'User');

-- Bảng HuanLuyenVien
INSERT INTO HuanLuyenVien (NhanVienID, HoTen, ChuyenMon, SoDienThoai, Email)
VALUES 
(1, 'Nguyen Van A', 'Thể hình', '0123456789', 'vana@example.com'),
(2, 'Le Thi B', 'Yoga', '0987654321', 'leb@example.com'),
(3, 'Tran Van C', 'Thể lực', '0912345678', 'tranc@example.com'),
(4, 'Pham Thi D', 'Kickboxing', '0934567890', 'phamd@example.com'),
(5, 'Doan Van E', 'Pilates', '0945678901', 'doane@example.com'),
(6, 'Ngo Thi F', 'Aerobics', '0923456789', 'ngof@example.com'),
(7, 'Vu Van G', 'Crossfit', '0913456789', 'vug@example.com'),
(8, 'Ly Thi H', 'Cardio', '0901234567', 'lyh@example.com'),
(9, 'Dang Van I', 'Zumba', '0986543210', 'dangi@example.com'),
(10, 'Hoang Thi J', 'Dance', '0971234567', 'hoangj@example.com');

-- Bảng ChiNhanh
INSERT INTO ChiNhanh (TenDiaDiem, DiaDiem, MoTa)
VALUES 
('Chi nhánh Bình Tân', 'Bình Tân', 'Phòng tập hiện đại'),
('Chi nhánh Bình Thạnh', 'Bình Thạnh', 'Không gian thoáng mát'),
('Chi nhánh Quận 1', 'Quận 1', 'Trang bị cao cấp'),
('Chi nhánh Quận 3', 'Quận 3', 'Nằm ở trung tâm'),
('Chi nhánh Quận 5', 'Quận 5', 'Gần các khu mua sắm'),
('Chi nhánh Thủ Đức', 'Thủ Đức', 'Khuôn viên rộng rãi'),
('Chi nhánh Phú Nhuận', 'Phú Nhuận', 'Dịch vụ chuyên nghiệp'),
('Chi nhánh Tân Bình', 'Tân Bình', 'Giao thông thuận tiện'),
('Chi nhánh Gò Vấp', 'Gò Vấp', 'Môi trường thân thiện'),
('Chi nhánh Quận 7', 'Quận 7', 'View đẹp, thoáng đãng');

-- Bảng TheKhachHang
INSERT INTO TheKhachHang (HoTen, NgaySinh, CCCD, GioiTinh, SoDienThoai, DiaChi, LoaiThanhVien, ThoiGianHieuLuc, SoBuoiTapCungPT)
VALUES 
('Nguyen A', '1990-01-01', '012345678912', 'Nam', '0912345678', 'Bình Tân', 'Classic', '2023-12-31', 10),
('Le B', '1992-02-02', '012345678913', 'Nữ', '0912345679', 'Bình Thạnh', 'Royal', '2024-12-31', 15),
-- Thêm 8 bản ghi khác tương tự

-- Bảng GoiTap
INSERT INTO GoiTap (ThoiGian, GiaTien, MoTa)
VALUES 
(3, 500000, 'Gói 3 tháng'),
(6, 900000, 'Gói 6 tháng'),
(12, 1600000, 'Gói 12 tháng'),
-- Thêm 7 bản ghi khác tương tự

-- Bảng ThuePT
INSERT INTO ThuePT (SoBuoiThue, GiaTien, MoTa)
VALUES 
(5, 200000, 'Gói thuê 5 buổi'),
(10, 350000, 'Gói thuê 10 buổi'),
-- Thêm 8 bản ghi khác tương tự

-- Bảng HoaDon
INSERT INTO HoaDon (TheKhachHangID, NhanVienID, NgayThanhToan, LoaiHoaDon, GoiTapID, GoiThuePTID, TongTien)
VALUES 
(1, 1, '2023-01-01', 'Thanh toán mới', 1, 1, 700000),
(2, 2, '2023-02-01', 'Gia hạn', 2, 2, 1200000),
-- Thêm 8 bản ghi khác tương tự

-- Bảng LichTap
INSERT INTO LichTap (HLV_ID, ChiNhanhID, ThoiGianBatDau, ThoiGianKetThuc, TrangThai)
VALUES 
(1, 1, '08:00:00', '09:00:00', 'Đã đặt'),
(2, 2, '10:00:00', '11:00:00', 'Trống'),
-- Thêm 8 bản ghi khác tương tự

-- Bảng DangKyLichTap
INSERT INTO DangKyLichTap (TheKhachHangID, LichTapID)
VALUES 
(1, 1),
(2, 2),
-- Thêm 8 bản ghi khác tương tự

-- Bảng PhongTap
INSERT INTO PhongTap (TenPhong, ChiNhanhID)
VALUES 
('Phòng Gym A', 1),
('Phòng Gym B', 2),
-- Thêm 8 bản ghi khác tương tự

-- Bảng ThietBi
INSERT INTO ThietBi (TenThietBi, PhongTapID, MoTa, TrangThai)
VALUES 
('Máy chạy bộ', 1, 'Máy hiện đại', 'Sẵn sàng'),
('Xe đạp tập', 2, 'Xe bền bỉ', 'Đang sử dụng'),
-- Thêm 8 bản ghi khác tương tự

-- Bảng SuDungThietBi
INSERT INTO SuDungThietBi (ThietBiID, ThoiGianBatDau, ThoiGianKetThuc)
VALUES 
(1, '2023-01-01', '2023-01-15'),
(2, '2023-01-10', '2023-01-20'),
-- Thêm 8 bản ghi khác tương tự

-- Bảng LichSuBaoTri
INSERT INTO LichSuBaoTri (ThietBiID, NgayBaoTri, MoTa)
VALUES 
(1, '2023-01-05', 'Bảo trì định kỳ'),
(2, '2023-01-12', 'Thay dây đai'),
-- Thêm 8 bản ghi khác tương tự
