using System;
using System.Linq;
using System.Windows.Forms;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            Load += frmTrangChu_Load;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu(string tuKhoa = "")
        {
            try
            {
                using (var db = new StadiumDbContext())
                {
                    DateTime homNay = DateTime.Now;

                    var query = db.SuKien
                        .Where(sk => sk.ThoiGian >= homNay);

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        tuKhoa = tuKhoa.Trim().ToLower();

                        query = query.Where(sk =>
                            sk.TenSuKien.ToLower().Contains(tuKhoa) ||
                            sk.SanVanDong.TenSan.ToLower().Contains(tuKhoa));
                    }
                    else
                    {
                        query = query.Where(sk =>
                            sk.NoiBat &&
                            sk.NgayBatDauNoiBat.HasValue &&
                            sk.NgayKetThucNoiBat.HasValue &&
                            sk.NgayBatDauNoiBat.Value <= homNay &&
                            sk.NgayKetThucNoiBat.Value >= homNay);
                    }

                    var ds = query
                        .OrderBy(sk => sk.ThoiGian)
                        .Select(sk => new
                        {
                            sk.ID,
                            sk.TenSuKien,
                            sk.ThoiGian,
                            sk.GiaCoBan,
                            TenSan = sk.SanVanDong.TenSan
                        })
                        .Take(3)
                        .ToList();

                    HienThiSuKien(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                CaiDatMacDinh();
            }
        }

        private void HienThiSuKien(dynamic ds)
        {
            CaiDatMacDinh();

            pnlEvent1.Visible = false;
            pnlEvent2.Visible = false;
            pnlEvent3.Visible = false;

            if (ds.Count == 0)
            {
                pnlEvent1.Visible = true;
                lblTenSK1.Text = "Không tìm thấy sự kiện phù hợp";
                lblSan1.Text = "";
                lblThoiGian1.Text = "";
                lblGia1.Text = "";
                btnDatVe1.Tag = null;
                btnDatVe1.Enabled = false;
                return;
            }

            if (ds.Count > 0)
            {
                pnlEvent1.Visible = true;
                lblTenSK1.Text = ds[0].TenSuKien;
                lblSan1.Text = "Sân: " + ds[0].TenSan;
                lblThoiGian1.Text = "Thời gian: " + ds[0].ThoiGian.ToString("dd/MM/yyyy HH:mm");
                lblGia1.Text = "Giá từ: " + ds[0].GiaCoBan.ToString("N0") + " VNĐ";
                btnDatVe1.Tag = ds[0].ID;
                btnDatVe1.Enabled = true;
            }

            if (ds.Count > 1)
            {
                pnlEvent2.Visible = true;
                lblTenSK2.Text = ds[1].TenSuKien;
                lblSan2.Text = "Sân: " + ds[1].TenSan;
                lblThoiGian2.Text = "Thời gian: " + ds[1].ThoiGian.ToString("dd/MM/yyyy HH:mm");
                lblGia2.Text = "Giá từ: " + ds[1].GiaCoBan.ToString("N0") + " VNĐ";
                btnDatVe2.Tag = ds[1].ID;
                btnDatVe2.Enabled = true;
            }

            if (ds.Count > 2)
            {
                pnlEvent3.Visible = true;
                lblTenSK3.Text = ds[2].TenSuKien;
                lblSan3.Text = "Sân: " + ds[2].TenSan;
                lblThoiGian3.Text = "Thời gian: " + ds[2].ThoiGian.ToString("dd/MM/yyyy HH:mm");
                lblGia3.Text = "Giá từ: " + ds[2].GiaCoBan.ToString("N0") + " VNĐ";
                btnDatVe3.Tag = ds[2].ID;
                btnDatVe3.Enabled = true;
            }
        }

        private void CaiDatMacDinh()
        {
            lblTenSK1.Text = "Chưa có sự kiện";
            lblSan1.Text = "";
            lblThoiGian1.Text = "";
            lblGia1.Text = "";
            btnDatVe1.Tag = null;
            btnDatVe1.Enabled = false;

            lblTenSK2.Text = "Chưa có sự kiện";
            lblSan2.Text = "";
            lblThoiGian2.Text = "";
            lblGia2.Text = "";
            btnDatVe2.Tag = null;
            btnDatVe2.Enabled = false;

            lblTenSK3.Text = "Chưa có sự kiện";
            lblSan3.Text = "";
            lblThoiGian3.Text = "";
            lblGia3.Text = "";
            btnDatVe3.Tag = null;
            btnDatVe3.Enabled = false;

            pnlEvent1.Visible = true;
            pnlEvent2.Visible = true;
            pnlEvent3.Visible = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
                TaiDuLieu();
            else
                TaiDuLieu(tuKhoa);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDuLieu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            Hide();
        }

        private void btnKhachDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhapKhachHang f = new frmDangNhapKhachHang();
            f.Show();
            Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (frmDangKyKhachHang f = new frmDangKyKhachHang())
            {
                f.ShowDialog();
            }
        }

        private void btnDatVe1_Click(object sender, EventArgs e)
        {
            MoDangNhapKhachHang(btnDatVe1, lblTenSK1.Text);
        }

        private void btnDatVe2_Click(object sender, EventArgs e)
        {
            MoDangNhapKhachHang(btnDatVe2, lblTenSK2.Text);
        }

        private void btnDatVe3_Click(object sender, EventArgs e)
        {
            MoDangNhapKhachHang(btnDatVe3, lblTenSK3.Text);
        }

        private void MoDangNhapKhachHang(Button btn, string tenSuKien)
        {
            if (btn.Tag == null)
            {
                MessageBox.Show(
                    "Sự kiện này hiện chưa khả dụng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int suKienID = Convert.ToInt32(btn.Tag);

            DialogResult rs = MessageBox.Show(
                $"Bạn đang chọn sự kiện:\n{tenSuKien}\n\nKhách hàng cần đăng nhập hoặc đăng ký để tự đặt vé.\nBạn có muốn chuyển tới màn hình đăng nhập khách hàng không?",
                "Đặt vé sự kiện",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                frmDangNhapKhachHang f = new frmDangNhapKhachHang(suKienID);
                f.Show();
                Hide();
            }
        }

        private void btnTaiQuay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Đặt vé tại quầy sẽ do nhân viên đăng nhập hệ thống để thao tác đặt vé.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}