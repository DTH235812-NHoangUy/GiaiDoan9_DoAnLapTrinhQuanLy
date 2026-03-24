using Microsoft.Reporting.WinForms;
using StadiumTicketBooking.Data.Entity;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Reports
{
    public partial class frmDanhSachVe : Form
    {
        public frmDanhSachVe()
        {
            InitializeComponent();
        }

        private void frmDanhSachVe_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            try
            {
                using (var context = new StadiumDbContext())
                {
                    var data = (from v in context.Ve
                                join sk in context.SuKien on v.SuKienID equals sk.ID
                                join g in context.Ghe on v.GheID equals g.ID
                                join kv in context.KhuVuc on g.KhuVucID equals kv.ID
                                join svd in context.SanVanDong on sk.SanVanDongID equals svd.ID
                                select new
                                {
                                    VeID = v.ID,
                                    TenSuKien = sk.TenSuKien,
                                    TenSan = svd.TenSan,
                                    TenKhuVuc = kv.TenKhuVuc,
                                    SoGhe = g.SoGhe,
                                    GiaVe = v.GiaVe,
                                    TrangThai = v.TrangThai
                                }).ToList();

                    reportViewer1.Reset();
                    reportViewer1.LocalReport.DataSources.Clear();

                    string reportPath = Path.Combine(Application.StartupPath, "Reports", "rptDanhSachVe.rdlc");

                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show(
                            "Không tìm thấy file report:\n" + reportPath +
                            "\n\nHãy chỉnh file rptDanhSachVe.rdlc:" +
                            "\n- Build Action = Content" +
                            "\n- Copy to Output Directory = Copy if newer",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DanhSachVe", data));

                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;

                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}