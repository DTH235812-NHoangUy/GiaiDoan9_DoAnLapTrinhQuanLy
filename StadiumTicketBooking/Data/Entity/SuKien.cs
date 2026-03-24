using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace StadiumTicketBooking.Data.Entity
{
    public class SuKien
    {
        public int ID { get; set; }
        public int SanVanDongID { get; set; }
        public string TenSuKien { get; set; } = null!;
        public DateTime ThoiGian { get; set; }
        public int GiaCoBan { get; set; }

        public bool NoiBat { get; set; }
        public DateTime? NgayBatDauNoiBat { get; set; }
        public DateTime? NgayKetThucNoiBat { get; set; }

        public virtual SanVanDong SanVanDong { get; set; } = null!;
        public virtual ObservableCollectionListSource<Ve> Ve { get; } = new();
    }
}