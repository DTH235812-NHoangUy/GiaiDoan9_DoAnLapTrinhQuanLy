using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StadiumTicketBooking.Data.Entity
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int? NhanVienID { get; set; }   // sửa chỗ này
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public string? GhiChu { get; set; }

        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien? NhanVien { get; set; } = null!;   // sửa chỗ này
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
    }

    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public string HoVaTenNhanVien { get; set; } = "Khách hàng tự đặt";
        public string HoVaTenKhachHang { get; set; } = null!;
        public DateTime NgayLap { get; set; }
        public string? GhiChu { get; set; }
        public double TongTienHoaDon { get; set; }
        public string XemChiTiet { get; set; } = "Xem chi tiết";
    }
}