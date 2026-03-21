using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using StadiumTicketBooking.Reports;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDonKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private readonly int khachHangIDDangNhap = 0;
        private readonly string hoVaTenKhachHang = "";

        public frmHoaDonKhachHang()
        {
            InitializeComponent();
        }

        public frmHoaDonKhachHang(int khachHangID, string hoVaTen)
        {
            InitializeComponent();
            khachHangIDDangNhap = khachHangID;
            hoVaTenKhachHang = hoVaTen ?? "";
        }

        private void frmHoaDonKhachHang_Load(object sender, EventArgs e)
        {
            if (khachHangIDDangNhap <= 0)
            {
                MessageBox.Show("Không xác định được khách hàng đang đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblKhachHang.Text = "Khách hàng: " + hoVaTenKhachHang;

            CauHinhDataGridView();
            TaiDanhSachHoaDon();
        }

        private void CauHinhDataGridView()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.RowHeadersVisible = false;

            if (dgvHoaDon.Columns["colNgayLap"] != null)
            {
                dgvHoaDon.Columns["colNgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvHoaDon.Columns["colNgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvHoaDon.Columns["colTongTien"] != null)
            {
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Format = "N0";
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.ForeColor = Color.Blue;
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }

            if (dgvHoaDon.Columns["colXemChiTiet"] != null)
                dgvHoaDon.Columns["colXemChiTiet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgvHoaDon.Columns["colInHoaDon"] != null)
                dgvHoaDon.Columns["colInHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void TaiDanhSachHoaDon()
        {
            try
            {
                var ds = context.HoaDon
                    .AsNoTracking()
                    .Include(x => x.HoaDon_ChiTiet)
                    .Where(x => x.KhachHangID == khachHangIDDangNhap)
                    .OrderByDescending(x => x.ID)
                    .Select(x => new
                    {
                        x.ID,
                        x.NgayLap,
                        x.GhiChu,
                        TongTien = x.HoaDon_ChiTiet.Sum(ct => (double?)ct.DonGiaBan) ?? 0,
                        XemChiTiet = "Xem chi tiết",
                        InHoaDon = "In hóa đơn"
                    })
                    .ToList();

                dgvHoaDon.DataSource = null;
                dgvHoaDon.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được lịch sử hóa đơn.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int LayHoaDonDangChon()
        {
            if (dgvHoaDon.CurrentRow == null || dgvHoaDon.CurrentRow.Cells["colID"].Value == null)
                return 0;

            return Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["colID"].Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiDanhSachHoaDon();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int hoaDonID = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["colID"].Value);

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colXemChiTiet")
            {
                using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(hoaDonID, 0, khachHangIDDangNhap, "KhachHang"))
                {
                    f.ShowDialog();
                }

                TaiDanhSachHoaDon();
            }
            else if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colInHoaDon")
            {
                using (frmInHoaDon f = new frmInHoaDon(hoaDonID))
                {
                    f.ShowDialog();
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}