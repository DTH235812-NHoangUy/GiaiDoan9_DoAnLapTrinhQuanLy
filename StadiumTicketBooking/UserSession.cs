namespace StadiumTicketBooking
{
    public static class UserSession
    {
        public static int KhachHangID { get; set; }
        public static string HoVaTen { get; set; } = "";
        public static string TenDangNhap { get; set; } = "";
        public static bool DaDangNhap { get; set; } = false;

        public static void DangXuat()
        {
            KhachHangID = 0;
            HoVaTen = "";
            TenDangNhap = "";
            DaDangNhap = false;
        }
    }
}