using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace StadiumTicketBooking.Data.Entity
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        // Bổ sung để khách hàng đăng nhập
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string? Email { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public bool TrangThai { get; set; } = true;

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}