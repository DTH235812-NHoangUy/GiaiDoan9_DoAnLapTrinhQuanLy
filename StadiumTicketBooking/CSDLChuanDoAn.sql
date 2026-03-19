USE StadiumTicketBooking;
GO

-------------------------------------------------
-- 0) XÓA RÀNG BUỘC UNIQUE CŨ NẾU ĐÃ TẠO
-------------------------------------------------
IF EXISTS (
    SELECT 1
    FROM sys.key_constraints
    WHERE name = 'UQ_Ve_SuKien_Ghe'
)
BEGIN
    ALTER TABLE Ve DROP CONSTRAINT UQ_Ve_SuKien_Ghe;
END
GO

IF EXISTS (
    SELECT 1
    FROM sys.key_constraints
    WHERE name = 'UQ_HoaDonChiTiet_Ve'
)
BEGIN
    ALTER TABLE HoaDon_ChiTiet DROP CONSTRAINT UQ_HoaDonChiTiet_Ve;
END
GO

-------------------------------------------------
-- 1) XÓA DỮ LIỆU CŨ
-------------------------------------------------
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

-------------------------------------------------
-- 2) RESET IDENTITY
-------------------------------------------------
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

-------------------------------------------------
-- 3) VAI TRÒ
-------------------------------------------------
INSERT INTO VaiTro (TenVaiTro)
VALUES
(N'Admin'),
(N'NhanVien');
GO

-------------------------------------------------
-- 4) NHÂN VIÊN
-------------------------------------------------
INSERT INTO NhanVien (VaiTroID, HoVaTen, TenDangNhap, MatKhau, DienThoai, HinhAnh)
VALUES
(1, N'Quản trị hệ thống', N'admin', N'123', N'0909000001', N'anh1.jpg'),
(2, N'Nhân viên bán vé 1', N'nhanvien1', N'123', N'0909000002', N'anh1.jpg'),
(2, N'Nhân viên bán vé 2', N'nhanvien2', N'123', N'0909000003', N'anh1.jpg'),
(2, N'Nhân viên bán vé 3', N'nhanvien3', N'123', N'0909000004', N'anh1.jpg');
GO

-------------------------------------------------
-- 5) KHÁCH HÀNG
-------------------------------------------------
INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi)
VALUES
(N'Khách hàng 1', N'0911111111', N'Hà Nội'),
(N'Khách hàng 2', N'0922222222', N'Hải Phòng'),
(N'Khách hàng 3', N'0933333333', N'Đà Nẵng'),
(N'Khách hàng 4', N'0944444444', N'TP.HCM'),
(N'Khách hàng 5', N'0955555555', N'Cần Thơ'),
(N'Khách hàng 6', N'0966666666', N'Nghệ An'),
(N'Khách hàng 7', N'0977777777', N'Nam Định');
GO

-------------------------------------------------
-- 6) SÂN VẬN ĐỘNG
-------------------------------------------------
INSERT INTO SanVanDong (TenSan, DiaChi, HinhAnh)
VALUES
(N'Mỹ Đình', N'Hà Nội', N'mydinh.jpg'),
(N'Thống Nhất', N'TP.HCM', N'thongnhat.jpg');
GO

-------------------------------------------------
-- 7) SỰ KIỆN
-------------------------------------------------
INSERT INTO SuKien (SanVanDongID, TenSuKien, ThoiGian, GiaCoBan)
VALUES
(1, N'Việt Nam vs Thái Lan',    '2026-03-20 19:30:00', 300000),
(1, N'Hà Nội FC vs Hải Phòng',  '2026-03-25 18:00:00', 250000),
(2, N'Việt Nam vs Indonesia',   '2026-04-01 20:00:00', 400000),
(1, N'Hà Nội FC vs Sài Gòn FC', '2026-03-26 19:00:00', 280000),
(2, N'Công An Hà Nội vs Nam Định', '2026-04-05 19:00:00', 320000);
GO

-------------------------------------------------
-- 8) KHU VỰC
-------------------------------------------------
INSERT INTO KhuVuc (SanVanDongID, TenKhuVuc, HeSoGia)
VALUES
(1, N'Khu A', 1.20),
(1, N'Khu B', 1.00),
(1, N'Khu C', 0.80),
(2, N'Khu A', 1.10),
(2, N'Khu B', 1.00),
(2, N'Khu C', 0.90);
GO

-------------------------------------------------
-- 9) GHẾ
-------------------------------------------------
INSERT INTO Ghe (KhuVucID, SoGhe)
VALUES
(1, N'A01'),
(1, N'A02'),
(1, N'A03'),
(2, N'B01'),
(2, N'B02'),
(2, N'B03'),
(3, N'C01'),
(3, N'C02'),

(4, N'A01'),
(4, N'A02'),
(5, N'B01'),
(5, N'B02'),
(6, N'C01'),
(6, N'C02');
GO

-------------------------------------------------
-- 10) VÉ
-------------------------------------------------
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
VALUES
-- Sự kiện 1: Việt Nam vs Thái Lan (Mỹ Đình)
(1, 1, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 2, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 3, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 4, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 5, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 6, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 7, 240000, N'Trống', N'anhvephothong.jpg'),
(1, 8, 240000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 2: Hà Nội FC vs Hải Phòng (Mỹ Đình)
(2, 1, 300000, N'Trống', N'anhvephothong.jpg'),
(2, 2, 300000, N'Trống', N'anhvephothong.jpg'),
(2, 4, 250000, N'Trống', N'anhvephothong.jpg'),
(2, 5, 250000, N'Trống', N'anhvephothong.jpg'),
(2, 7, 200000, N'Trống', N'anhvephothong.jpg'),
(2, 8, 200000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 3: Việt Nam vs Indonesia (Thống Nhất)
(3, 9, 440000, N'Trống', N'anhvephothong.jpg'),
(3, 10, 440000, N'Trống', N'anhvephothong.jpg'),
(3, 11, 400000, N'Trống', N'anhvephothong.jpg'),
(3, 12, 400000, N'Trống', N'anhvephothong.jpg'),
(3, 13, 360000, N'Trống', N'anhvephothong.jpg'),
(3, 14, 360000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 4: Hà Nội FC vs Sài Gòn FC (Mỹ Đình)
(4, 1, 336000, N'Trống', N'anhvephothong.jpg'),
(4, 2, 336000, N'Trống', N'anhvephothong.jpg'),
(4, 4, 280000, N'Trống', N'anhvephothong.jpg'),
(4, 5, 280000, N'Trống', N'anhvephothong.jpg'),
(4, 7, 224000, N'Trống', N'anhvephothong.jpg'),
(4, 8, 224000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 5: Công An Hà Nội vs Nam Định (Thống Nhất)
(5, 9, 352000, N'Trống', N'anhvephothong.jpg'),
(5, 10, 352000, N'Trống', N'anhvephothong.jpg'),
(5, 11, 320000, N'Trống', N'anhvephothong.jpg'),
(5, 12, 320000, N'Trống', N'anhvephothong.jpg'),
(5, 13, 288000, N'Trống', N'anhvephothong.jpg'),
(5, 14, 288000, N'Trống', N'anhvephothong.jpg');
GO

-------------------------------------------------
-- 11) HÓA ĐƠN MẪU ĐỂ TEST NHIỀU TÌNH HUỐNG
-- Lưu ý:
-- Phần này giả sử bảng HoaDon có các cột:
-- (NhanVienID, KhachHangID, NgayLap, TongTien, GhiChu)
-------------------------------------------------
-------------------------------------------------
-- 11) HÓA ĐƠN MẪU ĐỂ TEST NHIỀU TÌNH HUỐNG
-------------------------------------------------
INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChu)
VALUES
(2, 1, '2026-03-13 20:26:00', N'Hóa đơn test 2 vé khu C'),
(2, 2, '2026-03-13 20:35:00', N'Hóa đơn test 3 vé sự kiện 1'),
(3, 3, '2026-03-14 09:10:00', N'Hóa đơn test 2 vé sự kiện 2'),
(3, 4, '2026-03-14 10:00:00', N'Hóa đơn test 2 vé sự kiện 3'),
(4, 5, '2026-03-14 15:20:00', N'Hóa đơn test 1 vé sự kiện 4'),
(2, 6, '2026-03-15 08:45:00', N'Hóa đơn test 3 vé sự kiện 5');
GO

-------------------------------------------------
-- 12) CHI TIẾT HÓA ĐƠN
-- Lưu ý:
-- Phần này giả sử bảng HoaDon_ChiTiet có các cột:
-- (HoaDonID, VeID, DonGiaBan)
-------------------------------------------------
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
VALUES
-- Hóa đơn 1: 2 vé khu C, giống ảnh bạn đang test
(1, 7, 240000),
(1, 8, 240000),

-- Hóa đơn 2: 3 vé sự kiện 1
(2, 1, 360000),
(2, 4, 300000),
(2, 5, 300000),

-- Hóa đơn 3: 2 vé sự kiện 2
(3, 9, 300000),
(3, 11, 250000),

-- Hóa đơn 4: 2 vé sự kiện 3
(4, 15, 440000),
(4, 17, 400000),

-- Hóa đơn 5: 1 vé sự kiện 4
(5, 21, 336000),

-- Hóa đơn 6: 3 vé sự kiện 5
(6, 27, 320000),
(6, 29, 320000),
(6, 31, 288000);
GO

-------------------------------------------------
-- 13) CẬP NHẬT TRẠNG THÁI VÉ ĐÃ BÁN
-------------------------------------------------
UPDATE Ve
SET TrangThai = N'Trống';
GO

UPDATE Ve
SET TrangThai = N'Đã bán'
WHERE ID IN (7,8,1,4,5,9,11,15,17,21,27,29,31);
GO

-------------------------------------------------
-- 14) THÊM RÀNG BUỘC CHỐNG TRÙNG
-------------------------------------------------
ALTER TABLE Ve
ADD CONSTRAINT UQ_Ve_SuKien_Ghe UNIQUE (SuKienID, GheID);
GO

ALTER TABLE HoaDon_ChiTiet
ADD CONSTRAINT UQ_HoaDonChiTiet_Ve UNIQUE (VeID);
GO

-------------------------------------------------
-- 15) KIỂM TRA DỮ LIỆU
-------------------------------------------------
SELECT * FROM VaiTro;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM SanVanDong;
SELECT * FROM SuKien;
SELECT * FROM KhuVuc;
SELECT * FROM Ghe;
SELECT * FROM Ve ORDER BY SuKienID, GheID;
SELECT * FROM HoaDon ORDER BY ID;
SELECT * FROM HoaDon_ChiTiet ORDER BY HoaDonID, ID;
GO
