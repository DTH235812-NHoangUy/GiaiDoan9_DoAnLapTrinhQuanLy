using System;
using System.Linq;
using System.Windows.Forms;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDangNhapKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        public frmDangNhapKhachHang()
        {
            InitializeComponent();
        }

        private void frmDangNhapKhachHang_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
            chkHienMatKhau.Checked = false;
            txtTenDangNhap.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '●';
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            var kh = context.KhachHang
                .FirstOrDefault(x => x.TenDangNhap == tenDangNhap
                                  && x.MatKhau == matKhau
                                  && x.TrangThai == true);

            if (kh == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.SelectAll();
                txtMatKhau.Focus();
                return;
            }

            UserSession.KhachHangID = kh.ID;
            UserSession.HoVaTen = kh.HoVaTen;
            UserSession.TenDangNhap = kh.TenDangNhap;
            UserSession.DaDangNhap = true;

            MessageBox.Show("Đăng nhập thành công.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMainKhachHang f = new frmMainKhachHang(kh);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMoDangKy_Click(object sender, EventArgs e)
        {
            using (frmDangKyKhachHang f = new frmDangKyKhachHang())
            {
                f.ShowDialog();
            }
        }

        private void lnkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmQuenMatKhauKhachHang f = new frmQuenMatKhauKhachHang())
            {
                f.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}