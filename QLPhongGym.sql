create database QLPhongGym
use QLPhongGym

CREATE TABLE NhanVien (
    NhanVienID INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    NgayVaoLam DATE
);

CREATE TABLE HuanLuyenVien (
    HLV_ID INT IDENTITY(1,1) PRIMARY KEY,
	NhanVienID INT,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenMon NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE
	FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);
CREATE TABLE LoaiKhachHang (
    LoaiKhachHangID INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(50),
    MoTa NVARCHAR(255)
);

CREATE TABLE DichVu (
    DichVuID INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    MoTa NVARCHAR(255)
);

CREATE TABLE KhachHang (
    KhachHangID INT IDENTITY(1,1) PRIMARY KEY,
	LoaiKhachHangID INT,
	DichVuID INT,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    DiaChi NVARCHAR(255),
	FOREIGN KEY (LoaiKhachHangID) REFERENCES LoaiKhachHang(LoaiKhachHangID),
	FOREIGN KEY (DichVuID) REFERENCES DichVu(DichVuID)
);

CREATE TABLE PhongTap (
    PhongTapID INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    MoTa NVARCHAR(255)
);

CREATE TABLE LichHoc (
    LichHocID INT IDENTITY(1,1) PRIMARY KEY,
    HLV_ID INT,
	PhongTapID INT,
    NgayHoc DATE,
    ThoiGianBatDau TIME,
    ThoiGianKetThuc TIME,
    FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID),
	FOREIGN KEY (PhongTapID) REFERENCES PhongTap(PhongTapID)
);

CREATE TABLE DangKyHLV (
    DangKyHLV_ID INT IDENTITY(1,1) PRIMARY KEY,
    KhachHangID INT,
    HLV_ID INT,
    SoBuoi INT,
    TrangThai NVARCHAR(20),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID)
);

CREATE TABLE ThietBi (
    ThietBiID INT IDENTITY(1,1) PRIMARY KEY,
    TenThietBi NVARCHAR(100) NOT NULL,
	PhongTapID INT,
    MoTa NVARCHAR(255),
    TrangThai NVARCHAR(50),
	FOREIGN KEY (PhongTapID) REFERENCES PhongTap(PhongTapID)
);

CREATE TABLE SuDungThietBi (
    SuDungID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    ThoiGianBatDau DATE,
    ThoiGianKetThuc DATE,
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);

CREATE TABLE LichSuBaoTri (
    BaoTriID INT IDENTITY(1,1) PRIMARY KEY,
    ThietBiID INT,
    NgayBaoTri DATE,
    MoTa NVARCHAR(255),
    FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);


CREATE TABLE HoiVien (
    HoiVienID INT IDENTITY(1,1) PRIMARY KEY,
    KhachHangID INT,
    NgayBatDau DATE,
    NgayKetThuc DATE,
    TrangThai NVARCHAR(20),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);



CREATE TABLE PhanHoi (
    PhanHoiID INT IDENTITY(1,1) PRIMARY KEY,
    KhachHangID INT,
    NoiDung NVARCHAR(255),
    NgayPhanHoi DATE,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);



CREATE TABLE LoaiHoaDon (
    LoaiHoaDonID INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiHD NVARCHAR(100),
    MoTa NVARCHAR(255)
);

CREATE TABLE HoaDon (
    HoaDonID INT IDENTITY(1,1) PRIMARY KEY,
    KhachHangID INT,
    GiaTien DECIMAL(18, 2),
    NgayThanhToan DATE,
    LoaiHoaDon_ID INT,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    FOREIGN KEY (LoaiHoaDon_ID) REFERENCES LoaiHoaDon(LoaiHoaDonID)
);

CREATE TABLE GoiTap (
    GoiTapID INT IDENTITY(1,1) PRIMARY KEY,
    TenGoiTap NVARCHAR(100)
);

CREATE TABLE ChiTietHD (
    HoaDonID INT,
    GoiTapID INT,
    PRIMARY KEY (HoaDonID, GoiTapID),
    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(HoaDonID),
    FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID)
);

CREATE TABLE LoaiDichVu(
	MaLoaiDichVu INT IDENTITY(1,1) PRIMARY KEY,
	TenLoaiDichVu NVARCHAR(100),
	HLV_ID INT,
	GoiTapID INT,
	MoTa NVARCHAR(100),
	FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID),
	FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID)
);

INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, NgayVaoLam) VALUES 
(N'Nguyễn Văn Dũng', N'Huấn luyện viên', '0904567890', 'dung@gym.com', '2023-07-20'),
(N'Trần Văn Hải', N'Huấn luyện viên', '0905678901', 'hai@gym.com', '2023-07-20'),
(N'Nguyễn Thị Lan', N'Huấn luyện viên', '0906789012', 'lan@gym.com', '2023-07-20'),
(N'Nguyễn Văn An', N'Quản lý phòng gym', '0901234567', 'nv.an@gym.com', '2023-01-15'),
(N'Trần Thị Bình', N'Lễ tân', '0902345678', 'tt.binh@gym.com', '2023-05-10'),
(N'Lê Văn Cường', N'Nhân viên tư vấn', '0903456789', 'lv.cuong@gym.com', '2023-07-20');


INSERT INTO HuanLuyenVien (NhanVienID, HoTen, ChuyenMon, SoDienThoai, Email) VALUES 
(1, N'Nguyễn Văn Dũng', 'Yoga', '0904567890', 'dung@gym.com'),
(2, N'Trần Văn Hải', 'Fitness', '0905678901', 'hai@gym.com'),
(3, N'Nguyễn Thị Lan', 'Aerobics', '0906789012', 'lan@gym.com');


INSERT INTO LoaiKhachHang (TenLoai, MoTa) VALUES 
('VIP', N'Khách hàng VIP với ưu đãi đặc biệt và quyền truy cập tất cả các dịch vụ'),
(N'Thường', N'Khách hàng phổ thông với quyền truy cập hạn chế'),
(N'Sinh viên', N'Khách hàng là sinh viên với ưu đãi giảm giá');


INSERT INTO DichVu (TenDichVu, MoTa) VALUES 
('Massage', N'Dịch vụ massage thư giãn sau khi tập luyện'),
(N'Xông hơi', N'Dịch vụ xông hơi giúp thư giãn cơ thể'),
(N'Tư vấn dinh dưỡng', N'Dịch vụ tư vấn dinh dưỡng và chế độ ăn uống');

INSERT INTO KhachHang (LoaiKhachHangID, DichVuID, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi) VALUES 
(1, 1, N'Lê Minh Tâm', '1990-04-22', 'Nam', '0907890123', 'lm.tam@gym.com', N'123 Đường A, Hà Nội'),
(2, 2, N'Phạm Thị Hoa', '1995-08-15', N'Nữ', '0908901234', 'pt.hoa@gym.com', N'456 Đường B, Hà Nội'),
(3, 3, N'Nguyễn Văn Long', '2000-11-30', 'Nam', '0909012345', 'nv.long@gym.com', N'789 Đường C, Hà Nội');


INSERT INTO PhongTap (TenPhong, MoTa) VALUES 
(N'Phòng Yoga', N'Phòng tập Yoga với không gian yên tĩnh'),
(N'Phòng Gym', N'Phòng tập thể hình với thiết bị hiện đại'),
(N'Phòng Aerobics', N'Phòng tập Aerobics với âm thanh sôi động');


INSERT INTO LichHoc (HLV_ID, PhongTapID, NgayHoc, ThoiGianBatDau, ThoiGianKetThuc) VALUES 
(1, 1, '2023-11-01', '08:00', '09:00'),
(2, 2, '2023-11-02', '10:00', '11:00'),
(3, 3, '2023-11-03', '18:00', '19:00');


INSERT INTO DangKyHLV (KhachHangID, HLV_ID, SoBuoi, TrangThai) VALUES 
(1, 1, 10, N'Đang hoạt động'),
(2, 2, 8, N'Hoàn thành'),
(3, 3, 5, N'Đã hủy');


INSERT INTO ThietBi (TenThietBi, PhongTapID, MoTa, TrangThai) VALUES 
(N'Máy chạy bộ', 2, N'Máy chạy bộ hiện đại dành cho cardio', N'Sẵn sàng'),
(N'Máy đạp xe', 2, N'Máy đạp xe chuyên dụng', N'Đang bảo trì'),
(N'Dụng cụ Yoga', 1, N'Dụng cụ hỗ trợ các bài tập Yoga', N'Sẵn sàng');


INSERT INTO SuDungThietBi (ThietBiID, ThoiGianBatDau, ThoiGianKetThuc) VALUES 
(1, '2023-11-01', '2023-11-01'),
(2, '2023-11-02', '2023-11-02'),
(3, '2023-11-03', '2023-11-03');


INSERT INTO LichSuBaoTri (ThietBiID, NgayBaoTri, MoTa) VALUES 
(1, '2023-10-15', N'Bảo trì định kỳ máy chạy bộ'),
(2, '2023-10-20', N'Bảo trì máy đạp xe'),
(3, '2023-10-25', N'Bảo trì dụng cụ Yoga');


INSERT INTO HoiVien (KhachHangID, NgayBatDau, NgayKetThuc, TrangThai) VALUES 
(1, '2023-01-01', '2023-12-31', N'Hoạt động'),
(2, '2023-05-01', '2023-11-01', N'Hết hạn'),
(3, '2023-07-01', '2023-10-01', N'Hết hạn');


INSERT INTO PhanHoi (KhachHangID, NoiDung, NgayPhanHoi) VALUES 
(1, N'Dịch vụ massage rất tốt', '2023-11-01'),
(2, N'Phòng tập sạch sẽ và hiện đại', '2023-11-02'),
(3, N'Huấn luyện viên rất nhiệt tình và tận tâm', '2023-11-03');


INSERT INTO LoaiHoaDon (TenLoaiHD, MoTa) VALUES 
(N'Thanh toán tháng', N'Hóa đơn thanh toán theo tháng'),
(N'Thanh toán quý', N'Hóa đơn thanh toán theo quý'),
(N'Thanh toán năm', N'Hóa đơn thanh toán theo năm');


INSERT INTO HoaDon (KhachHangID, GiaTien, NgayThanhToan, LoaiHoaDon_ID) VALUES 
(1, 500000, '2023-01-01', 1),
(2, 1500000, '2023-04-01', 2),
(3, 3000000, '2023-07-01', 3);


INSERT INTO GoiTap (TenGoiTap) VALUES 
(N'Gói Gym cơ bản'),
(N'Gói Yoga nâng cao'),
(N'Gói Aerobics chuyên nghiệp');


INSERT INTO ChiTietHD (HoaDonID, GoiTapID) VALUES 
(1, 1),
(2, 2),
(3, 3);

-- Bảng LoaiDichVu
INSERT INTO LoaiDichVu (TenLoaiDichVu, HLV_ID, GoiTapID, MoTa) VALUES 
(N'Dịch vụ huấn luyện Yoga', 1, 1, N'Huấn luyện viên Yoga cá nhân'),
(N'Dịch vụ huấn luyện Gym', 2, 2, N'Huấn luyện viên Gym chuyên nghiệp'),
(N'Dịch vụ huấn luyện Aerobics', 3, 3, N'Huấn luyện viên Aerobics nâng cao');
