using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using StadiumTicketBooking.Data;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Reports
{
    public partial class frmInHoaDon : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private readonly int id;

        private readonly string reportsFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports")
        );

        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file report:\n" + reportPath,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var hoaDon = context.HoaDon
                    .Include(x => x.NhanVien)
                    .Include(x => x.KhachHang)
                    .SingleOrDefault(x => x.ID == id);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cần in.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSachChiTiet = context.HoaDon_ChiTiet
                    .Include(x => x.Ve)
                        .ThenInclude(v => v.SuKien)
                    .Include(x => x.Ve)
                        .ThenInclude(v => v.Ghe)
                            .ThenInclude(g => g.KhuVuc)
                                .ThenInclude(kv => kv.SanVanDong)
                    .Where(x => x.HoaDonID == id)
                    .Select(x => new DanhSachHoaDon_ChiTiet
                    {
                        ID = x.ID,
                        HoaDonID = x.HoaDonID,
                        VeID = x.VeID,
                        TenSuKien = x.Ve.SuKien.TenSuKien,
                        TenSan = x.Ve.Ghe.KhuVuc.SanVanDong.TenSan,
                        ViTriGhe = x.Ve.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + x.Ve.Ghe.SoGhe,
                        SoLuongBan = 1,
                        DonGiaBan = x.DonGiaBan,
                        ThanhTien = x.DonGiaBan
                    })
                    .ToList();

                if (danhSachChiTiet.Count == 0)
                {
                    MessageBox.Show("Hóa đơn chưa có chi tiết để in.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenNhanVien = "Khách hàng tự đặt";
                if (hoaDon.NhanVien != null)
                    tenNhanVien = hoaDon.NhanVien.HoVaTen;

                string tenKhachHang = hoaDon.KhachHang != null
                    ? hoaDon.KhachHang.HoVaTen
                    : "Khách lẻ";

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = reportPath;

                var reportDataSource = new ReportDataSource("HoaDon_ChiTiet", danhSachChiTiet);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                var param = new List<ReportParameter>
                {
                    new ReportParameter("HoaDonID", hoaDon.ID.ToString()),
                    new ReportParameter("NgayLap", hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm")),
                    new ReportParameter("NhanVien_Ten", tenNhanVien),
                    new ReportParameter("KhachHang_Ten", tenKhachHang),
                    new ReportParameter("GhiChu", hoaDon.GhiChu ?? "")
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi in hóa đơn:\n" + ex.Message +
                    "\n\nInner: " + ex.InnerException?.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}