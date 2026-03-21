USE StadiumTicketBooking;
GO

/* =========================================
   0. XÓA DỮ LIỆU CŨ
========================================= */
DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM Ve;
DELETE FROM Ghe;
DELETE FROM KhuVuc;
DELETE FROM SuKien;
DELETE FROM KhachHang;
DELETE FROM NhanVien;
DELETE FROM VaiTro;
DELETE FROM SanVanDong;
GO

/* =========================================
   1. RESET IDENTITY
========================================= */
DBCC CHECKIDENT ('HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('HoaDon', RESEED, 0);
DBCC CHECKIDENT ('Ve', RESEED, 0);
DBCC CHECKIDENT ('Ghe', RESEED, 0);
DBCC CHECKIDENT ('KhuVuc', RESEED, 0);
DBCC CHECKIDENT ('SuKien', RESEED, 0);
DBCC CHECKIDENT ('KhachHang', RESEED, 0);
DBCC CHECKIDENT ('NhanVien', RESEED, 0);
DBCC CHECKIDENT ('VaiTro', RESEED, 0);
DBCC CHECKIDENT ('SanVanDong', RESEED, 0);
GO

/* =========================================
   2. VAI TRÒ
========================================= */
INSERT INTO VaiTro (TenVaiTro)
VALUES
(N'Admin'),
(N'Nhân viên');
GO

/* =========================================
   3. NHÂN VIÊN
========================================= */
INSERT INTO NhanVien (VaiTroID, HoVaTen, TenDangNhap, MatKhau, DienThoai, HinhAnh)
VALUES
(1, N'Nguyễn Hoàng Uy', 'admin', '123', '0901000001', 'admin.jpg'),
(2, N'Trần Minh Khang', 'nv01', '123', '0901000002', 'nv01.jpg'),
(2, N'Lê Thị Hồng', 'nv02', '123', '0901000003', 'nv02.jpg'),
(2, N'Phạm Quốc Bảo', 'nv03', '123', '0901000004', 'nv03.jpg'),
(2, N'Võ Nhật Nam', 'nv04', '123', '0901000005', 'nv04.jpg');
GO

/* =========================================
   4. KHÁCH HÀNG
========================================= */
INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, Email, NgayTao, TrangThai)
VALUES
(N'Nguyễn Văn An', '0911111111', N'TP.HCM', 'kh01', '123', 'an@gmail.com', GETDATE(), 1),
(N'Trần Thị Bình', '0922222222', N'Đồng Nai', 'kh02', '123', 'binh@gmail.com', GETDATE(), 1),
(N'Lê Hoàng Nam', '0933333333', N'Bình Dương', 'kh03', '123', 'nam@gmail.com', GETDATE(), 1),
(N'Phạm Thu Trang', '0944444444', N'Cần Thơ', 'kh04', '123', 'trang@gmail.com', GETDATE(), 1),
(N'Võ Minh Tâm', '0955555555', N'Long An', 'kh05', '123', 'tam@gmail.com', GETDATE(), 1),
(N'Ngô Gia Hân', '0966666666', N'Hà Nội', 'kh06', '123', 'han@gmail.com', GETDATE(), 1),
(N'Bùi Khánh Ly', '0977777777', N'Đà Nẵng', 'kh07', '123', 'ly@gmail.com', GETDATE(), 1);
GO

/* =========================================
   5. SÂN VẬN ĐỘNG
========================================= */
INSERT INTO SanVanDong (TenSan, DiaChi, HinhAnh)
VALUES
(N'Sân vận động Mỹ Đình', N'Hà Nội', 'mydinh.jpg'),
(N'Sân vận động Thống Nhất', N'TP.HCM', 'thongnhat.jpg'),
(N'Sân vận động Hàng Đẫy', N'Hà Nội', 'hangday.jpg');
GO

/* =========================================
   6. KHU VỰC
========================================= */
INSERT INTO KhuVuc (SanVanDongID, TenKhuVuc, HeSoGia)
VALUES
(1, N'Khán đài A', 1.5),
(1, N'Khán đài B', 1.3),
(1, N'Khán đài C', 1.1),
(1, N'Khán đài D', 1.0),

(2, N'Khán đài A', 1.4),
(2, N'Khán đài B', 1.2),
(2, N'Khán đài C', 1.0),

(3, N'Khán đài A', 1.3),
(3, N'Khán đài B', 1.1),
(3, N'Khán đài C', 1.0);
GO

/* =========================================
   7. GHẾ
   Mỗi khu vực 10 ghế
========================================= */
INSERT INTO Ghe (KhuVucID, SoGhe)
VALUES
-- Sân 1 - Khu 1
(1, 'A01'), (1, 'A02'), (1, 'A03'), (1, 'A04'), (1, 'A05'),
(1, 'A06'), (1, 'A07'), (1, 'A08'), (1, 'A09'), (1, 'A10'),

-- Sân 1 - Khu 2
(2, 'B01'), (2, 'B02'), (2, 'B03'), (2, 'B04'), (2, 'B05'),
(2, 'B06'), (2, 'B07'), (2, 'B08'), (2, 'B09'), (2, 'B10'),

-- Sân 1 - Khu 3
(3, 'C01'), (3, 'C02'), (3, 'C03'), (3, 'C04'), (3, 'C05'),
(3, 'C06'), (3, 'C07'), (3, 'C08'), (3, 'C09'), (3, 'C10'),

-- Sân 1 - Khu 4
(4, 'D01'), (4, 'D02'), (4, 'D03'), (4, 'D04'), (4, 'D05'),
(4, 'D06'), (4, 'D07'), (4, 'D08'), (4, 'D09'), (4, 'D10'),

-- Sân 2 - Khu 5
(5, 'A01'), (5, 'A02'), (5, 'A03'), (5, 'A04'), (5, 'A05'),
(5, 'A06'), (5, 'A07'), (5, 'A08'), (5, 'A09'), (5, 'A10'),

-- Sân 2 - Khu 6
(6, 'B01'), (6, 'B02'), (6, 'B03'), (6, 'B04'), (6, 'B05'),
(6, 'B06'), (6, 'B07'), (6, 'B08'), (6, 'B09'), (6, 'B10'),

-- Sân 2 - Khu 7
(7, 'C01'), (7, 'C02'), (7, 'C03'), (7, 'C04'), (7, 'C05'),
(7, 'C06'), (7, 'C07'), (7, 'C08'), (7, 'C09'), (7, 'C10'),

-- Sân 3 - Khu 8
(8, 'A01'), (8, 'A02'), (8, 'A03'), (8, 'A04'), (8, 'A05'),
(8, 'A06'), (8, 'A07'), (8, 'A08'), (8, 'A09'), (8, 'A10'),

-- Sân 3 - Khu 9
(9, 'B01'), (9, 'B02'), (9, 'B03'), (9, 'B04'), (9, 'B05'),
(9, 'B06'), (9, 'B07'), (9, 'B08'), (9, 'B09'), (9, 'B10'),

-- Sân 3 - Khu 10
(10, 'C01'), (10, 'C02'), (10, 'C03'), (10, 'C04'), (10, 'C05'),
(10, 'C06'), (10, 'C07'), (10, 'C08'), (10, 'C09'), (10, 'C10');
GO

/* =========================================
   8. SỰ KIỆN
========================================= */
INSERT INTO SuKien (SanVanDongID, TenSuKien, ThoiGian, GiaCoBan)
VALUES
(1, N'Việt Nam vs Thái Lan', '2026-04-10 19:30:00', 300000),
(1, N'Liveshow Âm nhạc mùa hè', '2026-04-20 18:30:00', 250000),
(1, N'Chung kết Cúp quốc gia', '2026-05-03 18:00:00', 350000),

(2, N'CLB TP.HCM vs Hà Nội FC', '2026-04-15 17:00:00', 220000),
(2, N'Festival Thể thao Thành phố', '2026-05-01 08:00:00', 150000),

(3, N'Giải bóng đá sinh viên', '2026-04-25 15:00:00', 120000),
(3, N'Đại nhạc hội cuối tuần', '2026-05-10 19:00:00', 180000);
GO

/* =========================================
   9. TẠO VÉ THEO SỰ KIỆN + GHẾ
========================================= */

-- Sự kiện 1 - sân 1
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    1,
    g.ID,
    CAST(300000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk1.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 1;

-- Sự kiện 2 - sân 1
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    2,
    g.ID,
    CAST(250000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk2.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 1;

-- Sự kiện 3 - sân 1
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    3,
    g.ID,
    CAST(350000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk3.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 1;

-- Sự kiện 4 - sân 2
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    4,
    g.ID,
    CAST(220000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk4.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 2;

-- Sự kiện 5 - sân 2
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    5,
    g.ID,
    CAST(150000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk5.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 2;

-- Sự kiện 6 - sân 3
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    6,
    g.ID,
    CAST(120000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk6.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 3;

-- Sự kiện 7 - sân 3
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
SELECT 
    7,
    g.ID,
    CAST(180000 * kv.HeSoGia AS INT),
    N'Trống',
    've_sk7.jpg'
FROM Ghe g
INNER JOIN KhuVuc kv ON g.KhuVucID = kv.ID
WHERE kv.SanVanDongID = 3;
GO

/* =========================================
   10. HÓA ĐƠN
   Có cả 2 kiểu:
   - Nhân viên lập hóa đơn
   - Khách tự đặt vé online (NhanVienID = NULL)
========================================= */
INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChu)
VALUES
(2, 1, '2026-03-21 09:00:00', N'Khách mua trực tiếp tại quầy'),
(3, 2, '2026-03-21 09:15:00', N'Khách thanh toán tiền mặt'),
(NULL, 3, '2026-03-21 09:30:00', N'Khách tự đặt vé online'),
(4, 4, '2026-03-21 10:00:00', N'Nhân viên hỗ trợ đặt vé'),
(NULL, 5, '2026-03-21 10:20:00', N'Khách đặt vé qua hệ thống'),
(5, 6, '2026-03-21 10:45:00', N'Khách mua tại quầy'),
(NULL, 7, '2026-03-21 11:00:00', N'Khách tự đặt và thanh toán online');
GO

/* =========================================
   11. CHI TIẾT HÓA ĐƠN
========================================= */
-- Hóa đơn 1
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 1, ID, GiaVe FROM Ve WHERE SuKienID = 1 AND GheID = 1;

INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 1, ID, GiaVe FROM Ve WHERE SuKienID = 1 AND GheID = 2;

-- Hóa đơn 2
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 2, ID, GiaVe FROM Ve WHERE SuKienID = 2 AND GheID = 11;

-- Hóa đơn 3 - khách tự đặt
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 3, ID, GiaVe FROM Ve WHERE SuKienID = 4 AND GheID = 41;

INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 3, ID, GiaVe FROM Ve WHERE SuKienID = 4 AND GheID = 42;

-- Hóa đơn 4
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 4, ID, GiaVe FROM Ve WHERE SuKienID = 3 AND GheID = 21;

-- Hóa đơn 5 - khách tự đặt
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 5, ID, GiaVe FROM Ve WHERE SuKienID = 6 AND GheID = 71;

INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 5, ID, GiaVe FROM Ve WHERE SuKienID = 6 AND GheID = 72;

-- Hóa đơn 6
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 6, ID, GiaVe FROM Ve WHERE SuKienID = 5 AND GheID = 51;

-- Hóa đơn 7 - khách tự đặt
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 7, ID, GiaVe FROM Ve WHERE SuKienID = 7 AND GheID = 81;

INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
SELECT 7, ID, GiaVe FROM Ve WHERE SuKienID = 7 AND GheID = 82;
GO

/* =========================================
   12. CẬP NHẬT TRẠNG THÁI VÉ ĐÃ BÁN
========================================= */
UPDATE Ve
SET TrangThai = N'Đã bán'
WHERE ID IN (SELECT VeID FROM HoaDon_ChiTiet);
GO
SELECT * FROM VaiTro;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM SanVanDong;
SELECT * FROM KhuVuc;
SELECT * FROM Ghe;
SELECT * FROM SuKien;
SELECT * FROM Ve;
SELECT * FROM HoaDon;
SELECT * FROM HoaDon_ChiTiet;