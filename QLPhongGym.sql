create database QLPhongGym
use QLPhongGym
go

--Tạo các bảng
-- Bảng NhanVien
CREATE TABLE NhanVien (
    NhanVienID INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    NgayVaoLam DATE
);
GO

-- Bảng TaiKhoan, liên kết với bảng NhanVien
CREATE TABLE TaiKhoan (
    TaiKhoanID INT IDENTITY(1,1) PRIMARY KEY,
    TenDN NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(50),
    NhanVienID INT,
    Quyen NVARCHAR(50),
    FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
GO

-- Bảng HuanLuyenVien, liên kết với bảng NhanVien
CREATE TABLE HuanLuyenVien (
    HLV_ID INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienID INT,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenMon NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
GO

-- Bảng ChiNhanh
CREATE TABLE ChiNhanh (
    ChiNhanhID INT IDENTITY(1,1) PRIMARY KEY,
    TenDiaDiem NVARCHAR(100), -- Ví dụ: Cti Bình Tân, Cti Bình Thạnh
    DiaDiem NVARCHAR(100), -- Ví dụ: Bình Tân, Bình Thạnh
    MoTa NVARCHAR(255)
);
GO

-- Bảng TheKhachHang
CREATE TABLE TheKhachHang (
    TheKhachHangID INT IDENTITY(1,1) PRIMARY KEY, -- Mã thẻ thành viên
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    CCCD VARCHAR(25),
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(15),
    DiaChi NVARCHAR(255),
    LoaiThanhVien NVARCHAR(50), -- Ví dụ: Classic, Royal
    ThoiGianHieuLuc DATETIME, -- Thời gian hiệu lực của thẻ
    SoBuoiTapCungPT INT DEFAULT 0
);
GO

-- Bảng GoiTap
CREATE TABLE GoiTap (
    GoiTapID INT IDENTITY(1,1) PRIMARY KEY,
    ThoiGian INT,
    GiaTien DECIMAL(18, 2),
    Mota NVARCHAR(100)
);
GO

-- Bảng ThuePT
CREATE TABLE ThuePT (
    GoiThuePTID INT IDENTITY(1,1) PRIMARY KEY,
    SoBuoiThue INT,
    GiaTien DECIMAL(18, 2),
    Mota NVARCHAR(100)
);
GO

-- Bảng HoaDon, liên kết với TheKhachHang, NhanVien, GoiTap, ThuePT
CREATE TABLE HoaDon (
    HoaDonID INT IDENTITY(1,1) PRIMARY KEY,
    TheKhachHangID INT,
    NhanVienID INT,
    NgayThanhToan DATE,
    LoaiHoaDon NVARCHAR(100), -- Ví dụ: Thanh toán mới, gia hạn
    GoiTapID INT,
    GoiThuePTID INT,
    TongTien DECIMAL(18, 2),
    FOREIGN KEY (TheKhachHangID) REFERENCES TheKhachHang(TheKhachHangID),
    FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID),
    FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID),
    FOREIGN KEY (GoiThuePTID) REFERENCES ThuePT(GoiThuePTID)
);
GO

-- Bảng LichTap
CREATE TABLE LichTap (
    LichTapID INT IDENTITY(1,1) PRIMARY KEY,
    HLV_ID INT,
    ThoiGianBatDau TIME,
    ThoiGianKetThuc TIME,
    NgayBatDau DATETIME,
    TrangThai NVARCHAR(50), -- Ví dụ: Đã đặt, trống
    FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID)
);
GO

-- Bảng liên kết ChiNhanh - LichTap để thể hiện mối quan hệ nhiều-nhiều
CREATE TABLE ChiTiet_ChiNhanh_LichTap (
    ChiNhanhID INT,
    LichTapID INT,
    PRIMARY KEY (ChiNhanhID, LichTapID),
    FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID),
    FOREIGN KEY (LichTapID) REFERENCES LichTap(LichTapID)
);
GO

-- Bảng DangKyLichTap, liên kết với TheKhachHang và LichTap
CREATE TABLE DangKyLichTap (
    DangKyHLV_ID INT IDENTITY(1,1) PRIMARY KEY,
    TheKhachHangID INT,
    LichTapID INT,
    FOREIGN KEY (TheKhachHangID) REFERENCES TheKhachHang(TheKhachHangID),
    FOREIGN KEY (LichTapID) REFERENCES LichTap(LichTapID)
);
GO

-- Bảng ThietBi
CREATE TABLE ThietBi (
    ThietBiID INT IDENTITY(1,1) PRIMARY KEY,
    TenThietBi NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255),
    TrangThai NVARCHAR(50) -- Ví dụ: Hoạt động, bảo trì
);
GO

-- Bảng liên kết ChiNhanh - ThietBi để thể hiện mối quan hệ nhiều-nhiều
CREATE TABLE ChiTiet_ChiNhanh_ThietBi (
    ChiNhanhID INT,
    ThietBiID INT,
    PRIMARY KEY (ChiNhanhID, ThietBiID),
    FOREIGN KEY (ChiNhanhID) REFERENCES ChiNhanh(ChiNhanhID),
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);
GO

-- Bảng SuDungThietBi, liên kết với ThietBi
CREATE TABLE SuDungThietBi (
    SuDungID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    ThoiGianBatDau DATE,
    ThoiGianKetThuc DATE,
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);
GO

-- Bảng LichSuBaoTri, liên kết với ThietBi
CREATE TABLE LichSuBaoTri (
    BaoTriID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    NgayBaoTri DATE,
    MoTa NVARCHAR(255),
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);
GO



--Thêm dữ liệu

	-- Thêm dữ liệu vào bảng NhanVien
	INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, NgayVaoLam) VALUES
	(N'Nguyễn Văn A', N'Quản lý', '0912345678', 'nguyenvana@example.com', '2023-01-15'),
	(N'Lê Thị B', N'Nhân viên lễ tân', '0987654321', 'lethib@example.com', '2022-12-01'),
	(N'Trần Văn C', N'Nhân viên bán hàng', '0911122233', 'tranvanc@example.com', '2023-02-20'),
	(N'Phạm Thị D', N'Nhân viên kế toán', '0933445566', 'phamthid@example.com', '2023-03-10'),
	(N'Võ Văn E', N'Nhân viên chăm sóc khách hàng', '0944556677', 'vovane@example.com', '2023-04-05');

	-- Thêm dữ liệu vào bảng TaiKhoan
	INSERT INTO TaiKhoan (TenDN, MatKhau, NhanVienID, Quyen) VALUES
	(N'nguyenvana', 'password123', 1, N'Admin'),
	(N'lethib', 'password456', 2, N'User'),
	(N'tranvanc', 'password789', 3, N'User'),
	(N'phamthid', 'password012', 4, N'User'),
	(N'vovane', 'password345', 5, N'User');

	-- Thêm dữ liệu vào bảng HuanLuyenVien
	INSERT INTO HuanLuyenVien (NhanVienID, HoTen, ChuyenMon, SoDienThoai, Email) VALUES
	(1, N'Nguyễn Văn A', N'Tập thể hình', '0912345678', 'hlv_nguyenvana@example.com'),
	(2, N'Lê Thị B', N'Aerobics', '0987654321', 'hlv_lethib@example.com'),
	(3, N'Trần Văn C', N'Yoga', '0911122233', 'hlv_tranvanc@example.com'),
	(4, N'Phạm Thị D', N'Zumba', '0933445566', 'hlv_phamthid@example.com'),
	(5, N'Võ Văn E', N'Training Fitness', '0944556677', 'hlv_vovane@example.com');

	-- Thêm dữ liệu vào bảng ChiNhanh
	INSERT INTO ChiNhanh (TenDiaDiem, DiaDiem, MoTa) VALUES
	(N'Chi nhánh Bình Tân', N'Bình Tân', N'Trung tâm phòng tập hiện đại ở Bình Tân'),
	(N'Chi nhánh Bình Thạnh', N'Bình Thạnh', N'Phòng tập đạt chuẩn ở Bình Thạnh'),
	(N'Chi nhánh Quận 1', N'Quận 1', N'Chi nhánh tại trung tâm thành phố'),
	(N'Chi nhánh Phú Nhuận', N'Phú Nhuận', N'Không gian tập luyện thoải mái'),
	(N'Chi nhánh Gò Vấp', N'Gò Vấp', N'Phòng tập thể hình hiện đại');

	-- Thêm dữ liệu vào bảng TheKhachHang
	INSERT INTO TheKhachHang (HoTen, NgaySinh, CCCD, GioiTinh, SoDienThoai, DiaChi, LoaiThanhVien, ThoiGianHieuLuc, SoBuoiTapCungPT) VALUES
	(N'Trần Văn K', '1990-05-15', '123456789012', N'Nam', '0901234567', N'Quận 1, TP.HCM', N'Classic', '2024-05-15', 10),
	(N'Nguyễn Thị L', '1985-08-20', '234567890123', N'Nữ', '0907654321', N'Bình Thạnh, TP.HCM', N'Royal', '2025-08-20', 15),
	(N'Phạm Văn M', '1992-11-10', '345678901234', N'Nam', '0900987654', N'Gò Vấp, TP.HCM', N'Classic', '2023-11-10', 8),
	(N'Lê Thị N', '1998-03-25', '456789012345', N'Nữ', '0900123456', N'Phú Nhuận, TP.HCM', N'Royal', '2024-03-25', 20),
	(N'Võ Văn P', '1987-07-05', '567890123456', N'Nam', '0906543210', N'Bình Tân, TP.HCM', N'Classic', '2025-07-05', 5);

	-- Thêm dữ liệu vào bảng GoiTap
	INSERT INTO GoiTap (ThoiGian, GiaTien, Mota) VALUES
	(30, 300000, N'Gói tập cơ bản 30 ngày'),
	(90, 850000, N'Gói tập tiêu chuẩn 90 ngày'),
	(180, 1500000, N'Gói tập nâng cao 180 ngày'),
	(365, 2700000, N'Gói tập chuyên nghiệp 365 ngày'),
	(7, 100000, N'Gói tập thử 7 ngày');

	-- Thêm dữ liệu vào bảng ThuePT
	INSERT INTO ThuePT (SoBuoiThue, GiaTien, Mota) VALUES
	(5, 500000, N'Gói thuê PT 5 buổi'),
	(10, 950000, N'Gói thuê PT 10 buổi'),
	(20, 1800000, N'Gói thuê PT 20 buổi'),
	(30, 2500000, N'Gói thuê PT 30 buổi'),
	(3, 300000, N'Gói thuê PT 3 buổi');

	-- Thêm dữ liệu vào bảng HoaDon
	INSERT INTO HoaDon (TheKhachHangID, NhanVienID, NgayThanhToan, LoaiHoaDon, GoiTapID, GoiThuePTID, TongTien) VALUES
	(1, 1, '2023-10-01', N'Thanh toán mới', 1, 1, 800000),
	(2, 2, '2023-11-01', N'Gia hạn', 2, 2, 1800000),
	(3, 3, '2023-12-01', N'Thanh toán mới', 3, 3, 2300000),
	(4, 4, '2023-10-15', N'Gia hạn', 4, 4, 4000000),
	(5, 5, '2023-11-20', N'Thanh toán mới', 5, 5, 400000);

	-- Thêm dữ liệu vào bảng LichTap
	INSERT INTO LichTap (HLV_ID, ThoiGianBatDau, ThoiGianKetThuc, NgayBatDau, TrangThai) VALUES
	(1, '08:00', '09:00', '2023-11-01', N'Đã đặt'),
	(2, '10:00', '11:00', '2023-11-02', N'Trống'),
	(3, '14:00', '15:00', '2023-11-03', N'Đã đặt'),
	(4, '16:00', '17:00', '2023-11-04', N'Trống'),
	(5, '18:00', '19:00', '2023-11-05', N'Đã đặt');

	-- Thêm dữ liệu vào bảng ChiTiet_ChiNhanh_LichTap
	INSERT INTO ChiTiet_ChiNhanh_LichTap (ChiNhanhID, LichTapID) VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(4, 4),
	(5, 5);

	-- Thêm dữ liệu vào bảng DangKyLichTap
	INSERT INTO DangKyLichTap (TheKhachHangID, LichTapID) VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(4, 4),
	(5, 5);

	-- Thêm dữ liệu vào bảng ThietBi
	INSERT INTO ThietBi (TenThietBi, MoTa, TrangThai) VALUES
	(N'Máy chạy bộ', N'Thiết bị tập chạy bộ', N'Hoạt động'),
	(N'Tạ tay', N'Tạ tay các loại', N'Hoạt động'),
	(N'Dụng cụ tập bụng', N'Dụng cụ hỗ trợ tập bụng', N'Bảo trì'),
	(N'Xe đạp', N'Thiết bị xe đạp tại chỗ', N'Hoạt động'),
	(N'Dây kháng lực', N'Dây tập kháng lực', N'Bảo trì');

	-- Thêm dữ liệu vào bảng ChiTiet_ChiNhanh_ThietBi
	INSERT INTO ChiTiet_ChiNhanh_ThietBi (ChiNhanhID, ThietBiID) VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(4, 4),
	(5, 5);

	-- Thêm dữ liệu vào bảng SuDungThietBi
	INSERT INTO SuDungThietBi (ThietBiID, ThoiGianBatDau, ThoiGianKetThuc) VALUES
	(1, '2023-11-01', N'2025-11-01'),
	(2,'2023-11-02', N'2026-11-01'),
	(3, '2023-11-03', N'2027-11-01'),
	(4, '2023-11-04', N'2028-11-01'),
	(5, '2023-11-05', N'2029-11-01');

	-- Thêm dữ liệu vào bảng LichSuBaoTri
	INSERT INTO LichSuBaoTri (ThietBiID, NgayBaoTri, MoTa) VALUES
	(1, '2023-11-01', N'Kiểm tra và bảo trì định kỳ'),
	(2, '2023-10-15', N'Bảo trì thường xuyên'),
	(3, '2023-11-05', N'Thêm dầu mỡ và kiểm tra ốc vít'),
	(4, '2023-09-01', N'Bảo trì định kỳ 3 tháng/lần'),
	(5, '2023-11-03', N'Kiểm tra độ an toàn');


-- Trigger
CREATE TRIGGER trg_UpdateSoBuoiTapCungPT_And_ThoiGianHieuLuc
ON [dbo].[HoaDon]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật SoBuoiTapCungPT dựa vào GoiThuePTID
    UPDATE kh
    SET kh.SoBuoiTapCungPT = kh.SoBuoiTapCungPT + pt.SoBuoiThue
    FROM [dbo].[TheKhachHang] kh
    INNER JOIN inserted i ON kh.TheKhachHangID = i.TheKhachHangID
    INNER JOIN [dbo].[ThuePT] pt ON i.GoiThuePTID = pt.GoiThuePTID
    WHERE i.GoiThuePTID IS NOT NULL;

    -- Cập nhật ThoiGianHieuLuc dựa vào GoiTapID
    UPDATE kh
    SET kh.ThoiGianHieuLuc = DATEADD(DAY, gt.ThoiGian, ISNULL(kh.ThoiGianHieuLuc, GETDATE()))
    FROM [dbo].[TheKhachHang] kh
    INNER JOIN inserted i ON kh.TheKhachHangID = i.TheKhachHangID
    INNER JOIN [dbo].[GoiTap] gt ON i.GoiTapID = gt.GoiTapID
    WHERE i.GoiTapID IS NOT NULL;
END;
GO


-- 
ALTER TABLE ThietBi
ADD NgayNhap DATE NOT NULL DEFAULT GETDATE(),
    GiaNhap DECIMAL(18, 2) NOT NULL DEFAULT 0.0;