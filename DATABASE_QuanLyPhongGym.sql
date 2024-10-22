-- Bảng quản lý loại khách hàng
CREATE TABLE LoaiKhachHang (
    LoaiKhachHangID INT IDENTITY(1,1) PRIMARY KEY,   -- Mã loại khách hàng
    TenLoai NVARCHAR(50) NOT NULL,                  -- Tên loại khách hàng (ví dụ: Thường, Thành viên)
    MoTa NVARCHAR(MAX)                              -- Mô tả loại khách hàng
);

-- Bảng quản lý khách hàng
CREATE TABLE KhachHang (
    KhachHangID INT IDENTITY(1,1) PRIMARY KEY,       -- Mã khách hàng
    HoTen NVARCHAR(100) NOT NULL,                    -- Họ tên khách hàng
    NgaySinh DATE,                                   -- Ngày sinh
    GioiTinh NVARCHAR(10),                           -- Giới tính (Nam/Nữ/Khác)
    SoDienThoai NVARCHAR(15) UNIQUE,                 -- Số điện thoại liên lạc (đảm bảo không trùng)
    Email NVARCHAR(100) UNIQUE,                      -- Địa chỉ email (đảm bảo không trùng)
    DiaChi NVARCHAR(MAX),                            -- Địa chỉ nhà
    LoaiKhachHangID INT NOT NULL,                    -- Khóa ngoại đến bảng LoaiKhachHang
    CONSTRAINT FK_LoaiKhachHang FOREIGN KEY (LoaiKhachHangID) REFERENCES LoaiKhachHang(LoaiKhachHangID)
);

-- Bảng quản lý nhân viên
CREATE TABLE NhanVien (
    NhanVienID INT IDENTITY(1,1) PRIMARY KEY,        -- Mã nhân viên
    HoTen NVARCHAR(100) NOT NULL,                    -- Họ tên nhân viên
    ChucVu NVARCHAR(50),                             -- Chức vụ (ví dụ: Lễ tân, Quản lý)
    SoDienThoai NVARCHAR(15) UNIQUE,                 -- Số điện thoại
    Email NVARCHAR(100) UNIQUE,                      -- Địa chỉ email
    NgayVaoLam DATE NOT NULL                         -- Ngày bắt đầu làm việc
);

-- Bảng quản lý huấn luyện viên (PT)
CREATE TABLE HuanLuyenVien (
    HLV_ID INT IDENTITY(1,1) PRIMARY KEY,            -- Mã huấn luyện viên
    HoTen NVARCHAR(100) NOT NULL,                    -- Họ tên huấn luyện viên
    ChuyenMon NVARCHAR(MAX),                         -- Chuyên môn của huấn luyện viên
    SoDienThoai NVARCHAR(15) UNIQUE,                 -- Số điện thoại liên lạc (đảm bảo không trùng)
    Email NVARCHAR(100) UNIQUE,                      -- Địa chỉ email (đảm bảo không trùng)
    NhanVienID INT,                                  -- Khóa ngoại đến bảng NhanVien (nếu huấn luyện viên là nhân viên)
    CONSTRAINT FK_NhanVien FOREIGN KEY (NhanVienID) REFERENCES NhanVien(NhanVienID)
);

-- Bảng quản lý gói tập
CREATE TABLE GoiTap (
    GoiTapID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã gói tập
    TenGoiTap NVARCHAR(100) NOT NULL,                -- Tên gói tập (ví dụ: Gói 1 tháng, Gói 3 tháng)
    MoTa NVARCHAR(MAX),                              -- Mô tả gói tập
    Gia DECIMAL(10, 2) NOT NULL                      -- Giá của gói tập
);

-- Bảng quản lý hội viên (quản lý đăng ký gói tập của khách hàng)
CREATE TABLE HoiVien (
    HoiVienID INT IDENTITY(1,1) PRIMARY KEY,         -- Mã hội viên
    KhachHangID INT NOT NULL,                        -- Khóa ngoại đến bảng KhachHang
    GoiTapID INT NOT NULL,                           -- Khóa ngoại đến bảng GoiTap
    NgayBatDau DATE NOT NULL,                        -- Ngày bắt đầu hội viên
    NgayKetThuc DATE,                                -- Ngày kết thúc hội viên
    TrangThai NVARCHAR(20) NOT NULL,                 -- Trạng thái hội viên (Đang hoạt động/Hết hạn)
    CONSTRAINT FK_KhachHang_HoiVien FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    CONSTRAINT FK_GoiTap_HoiVien FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID)
);

-- Bảng quản lý lịch học và đặt chỗ lớp học
CREATE TABLE LichHoc (
    LichHocID INT IDENTITY(1,1) PRIMARY KEY,         -- Mã lịch học
    LopHocID INT NOT NULL,                           -- Khóa ngoại đến lớp học
    HLV_ID INT NOT NULL,                             -- Khóa ngoại đến huấn luyện viên
    NgayHoc DATE NOT NULL,                           -- Ngày diễn ra lớp học
    ThoiGianBatDau TIME NOT NULL,                    -- Thời gian bắt đầu lớp học
    ThoiGianKetThuc TIME NOT NULL,                   -- Thời gian kết thúc lớp học
    CONSTRAINT FK_LopHoc_LichHoc FOREIGN KEY (LopHocID) REFERENCES LopHoc(LopHocID),
    CONSTRAINT FK_HLV_LichHoc FOREIGN KEY (HLV_ID) REFERENCES HuanLuyenVien(HLV_ID)
);

--Bảng lớp học
CREATE TABLE LopHoc (
    LopHocID INT IDENTITY(1,1) PRIMARY KEY,         -- Mã lớp học
    TenLop NVARCHAR(100) NOT NULL,                 -- Tên lớp học (ví dụ: Yoga, Spinning)
    MoTa NVARCHAR(255)                             -- Mô tả về lớp học
);


-- Bảng quản lý đặt chỗ lớp học của khách hàng
CREATE TABLE DatChoLopHoc (
    DatChoID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã đặt chỗ
    KhachHangID INT NOT NULL,                        -- Khóa ngoại đến khách hàng
    LichHocID INT NOT NULL,                          -- Khóa ngoại đến lịch học
    CONSTRAINT FK_KhachHang_DatCho FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    CONSTRAINT FK_LichHoc_DatCho FOREIGN KEY (LichHocID) REFERENCES LichHoc(LichHocID)
);

-- Bảng quản lý hóa đơn
CREATE TABLE HoaDon (
    HoaDonID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã hóa đơn
    KhachHangID INT NOT NULL,                        -- Khóa ngoại đến khách hàng
    GoiTapID INT NOT NULL,                           -- Khóa ngoại đến gói tập
    SoTien DECIMAL(10, 2) NOT NULL,                  -- Số tiền thanh toán
    NgayThanhToan DATE NOT NULL,                     -- Ngày thanh toán
    LoaiHoaDon NVARCHAR(50) NOT NULL,                -- Loại hóa đơn (Đăng ký mới / Gia hạn)
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    CONSTRAINT FK_HoaDon_GoiTap FOREIGN KEY (GoiTapID) REFERENCES GoiTap(GoiTapID)
);

-- Bảng quản lý thiết bị tập
CREATE TABLE ThietBi (
    ThietBiID INT IDENTITY(1,1) PRIMARY KEY,         -- Mã thiết bị
    TenThietBi NVARCHAR(100) NOT NULL,               -- Tên thiết bị
    MoTa NVARCHAR(MAX),                              -- Mô tả thiết bị
    TrangThai NVARCHAR(20) NOT NULL                  -- Trạng thái thiết bị (Hoạt động/Hỏng/Đang sửa)
);

-- Bảng quản lý lịch sử bảo trì thiết bị
CREATE TABLE LichSuBaoTri (
    BaoTriID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã bảo trì
    ThietBiID INT NOT NULL,                          -- Khóa ngoại đến bảng ThietBi
    NgayBaoTri DATE NOT NULL,                        -- Ngày bảo trì
    MoTa NVARCHAR(MAX),                              -- Mô tả bảo trì
    CONSTRAINT FK_ThietBi_BaoTri FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);

-- Bảng quản lý phòng tập
CREATE TABLE PhongTap (
    PhongTapID INT IDENTITY(1,1) PRIMARY KEY,        -- Mã phòng tập
    TenPhong NVARCHAR(100) NOT NULL,                 -- Tên phòng tập
    MoTa NVARCHAR(MAX)                               -- Mô tả phòng tập
);

-- Bảng quản lý lịch sử sử dụng thiết bị của khách hàng
CREATE TABLE SuDungThietBi (
    SuDungID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã sử dụng
    KhachHangID INT NOT NULL,                        -- Khóa ngoại đến khách hàng
    ThietBiID INT NOT NULL,                          -- Khóa ngoại đến thiết bị
    ThoiGianBatDau DATETIME NOT NULL,                -- Thời gian bắt đầu sử dụng
    ThoiGianKetThuc DATETIME,                        -- Thời gian kết thúc sử dụng
    CONSTRAINT FK_KhachHang_ThietBi FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    CONSTRAINT FK_ThietBi FOREIGN KEY (ThietBiID) REFERENCES ThietBi(ThietBiID)
);

-- Bảng quản lý phản hồi của khách hàng
CREATE TABLE PhanHoi (
    PhanHoiID INT IDENTITY(1,1) PRIMARY KEY,         -- Mã phản hồi
    KhachHangID INT NOT NULL,                        -- Khóa ngoại đến bảng KhachHang
    NoiDung NVARCHAR(MAX) NOT NULL,                  -- Nội dung phản hồi
    NgayPhanHoi DATE NOT NULL,                       -- Ngày phản hồi
    CONSTRAINT FK_KhachHang_PhanHoi FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);
