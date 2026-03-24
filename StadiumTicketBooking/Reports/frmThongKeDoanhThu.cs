using Microsoft.Reporting.WinForms;
using StadiumTicketBooking.Data.Entity;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            try
            {
                using (var context = new StadiumDbContext())
                {
                    var data = context.HoaDon
                        .Select(hd => new
                        {
                            HoaDonID = hd.ID,
                            NgayLap = hd.NgayLap,
                            TenNhanVien = hd.NhanVien != null ? hd.NhanVien.HoVaTen : "Khách tự đặt",
                            TenKhachHang = hd.KhachHang != null ? hd.KhachHang.HoVaTen : "",
                            SoLuongVe = hd.HoaDon_ChiTiet.Count(),
                            TongTien = hd.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.DonGiaBan) ?? 0,
                            GhiChu = hd.GhiChu
                        })
                        .OrderByDescending(x => x.HoaDonID)
                        .ToList();

                    reportViewer1.Reset();
                    reportViewer1.LocalReport.DataSources.Clear();

                    string reportPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeDoanhThu.rdlc");

                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show(
                            "Không tìm thấy file report:\n" + reportPath +
                            "\n\nHãy chỉnh file rptThongKeDoanhThu.rdlc:" +
                            "\n- Build Action = Content" +
                            "\n- Copy to Output Directory = Copy if newer",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Add(
                        new ReportDataSource("ThongKeDoanhThu", data)
                    );

                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;

                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo thống kê doanh thu.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}