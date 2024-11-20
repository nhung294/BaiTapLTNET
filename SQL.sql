CREATE DATABASE MobileShopp;
GO
USE MobileShopp;
-- Bảng Sản phẩm
CREATE TABLE SanPham (
    id INT PRIMARY KEY IDENTITY(1,1),
    tenSP NVARCHAR(100) NOT NULL,
    gia DECIMAL(18, 2) NOT NULL,
    hangSX NVARCHAR(100) NOT NULL
);

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    id INT PRIMARY KEY IDENTITY(1,1),
    tenKH NVARCHAR(100) NOT NULL,
    diachi NVARCHAR(200),
    sdt NVARCHAR(15)
);

-- Bảng Đơn hàng
CREATE TABLE DonHang (
    id INT PRIMARY KEY IDENTITY(1,1),
    khachhangid INT NOT NULL,
    sanphamid INT NOT NULL,
    soluong INT NOT NULL,
    ngaymua DATE NOT NULL,
    FOREIGN KEY (khachhangid) REFERENCES KhachHang(id),
    FOREIGN KEY (sanphamid) REFERENCES SanPham(id)
);

-- Bảng Người dùng
CREATE TABLE NguoiDung (
    id INT PRIMARY KEY IDENTITY(1,1),
    tendangnhap NVARCHAR(50) NOT NULL UNIQUE,
    matkhau NVARCHAR(50) NOT NULL
);
-- Dữ liệu mẫu cho bảng Sản phẩm
INSERT INTO SanPham (tenSP, gia, hangSX) VALUES 
('iPhone 13', 20000000, 'Apple'),
('Galaxy S21', 15000000, 'Samsung'),
('Xperia 5', 12000000, 'Sony'),
('Redmi Note 10', 5000000, 'Xiaomi'),
('Pixel 6', 18000000, 'Google');

-- Dữ liệu mẫu cho bảng Khách hàng
INSERT INTO KhachHang (tenKH, diachi, sdt) VALUES
('Nguyễn Văn A', '123 Đường A, TP.HCM', '0901234567'),
('Trần Thị B', '456 Đường B, Hà Nội', '0987654321'),
('Lê Văn C', '789 Đường C, Đà Nẵng', '0912345678');

-- Dữ liệu mẫu cho bảng Đơn hàng
INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES
(1, 1, 2, '2024-10-15'),
(2, 3, 1, '2024-11-01'),
(3, 4, 3, '2024-11-15');

-- Dữ liệu mẫu cho bảng Người dùng
INSERT INTO NguoiDung (tendangnhap, matkhau) VALUES
('admin', 'admin123'),
('user1', 'password1');
