using StadiumTicketBooking.Data.Entity;
using System;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmMainKhachHang : Form
    {
        private KhachHang khachHangDangNhap;

        public frmMainKhachHang(KhachHang kh)
        {
            InitializeComponent();
            khachHangDangNhap = kh;
        }

        private void frmMainKhachHang_Load(object sender, EventArgs e)
        {
            if (khachHangDangNhap != null)
            {
                lblXinChao.Text = "Xin chào, " + khachHangDangNhap.HoVaTen;
                lblThongTin.Text = "Tên đăng nhập: " + khachHangDangNhap.TenDangNhap;
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            frmDatVeKhachHang f = new frmDatVeKhachHang(
                khachHangDangNhap.ID,
                khachHangDangNhap.HoVaTen
            );
            f.ShowDialog();
        }

        private void btnHoaDonCuaToi_Click(object sender, EventArgs e)
        {
            frmHoaDonKhachHang f = new frmHoaDonKhachHang(
                khachHangDangNhap.ID,
                khachHangDangNhap.HoVaTen
            );
            f.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn tạo thêm frmDoiMatKhauKhachHang rồi nối vào đây.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Nếu đã có form đổi mật khẩu thì dùng:
            // frmDoiMatKhauKhachHang f = new frmDoiMatKhauKhachHang(khachHangDangNhap.ID);
            // f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                this.Close();
            }
        }

        private void frmMainKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["frmChonVaiTro"] == null &&
                e.CloseReason == CloseReason.UserClosing)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
            }
        }
    }
}