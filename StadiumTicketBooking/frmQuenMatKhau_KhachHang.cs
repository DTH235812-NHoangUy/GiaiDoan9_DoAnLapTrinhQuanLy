using System;
using System.Linq;
using System.Windows.Forms;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmQuenMatKhauKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        public frmQuenMatKhauKhachHang()
        {
            InitializeComponent();
        }

        private void frmQuenMatKhauKhachHang_Load(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = '●';
            txtNhapLaiMatKhau.PasswordChar = '●';
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhauMoi.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '●';
                txtNhapLaiMatKhau.PasswordChar = '●';
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            var khachHang = context.KhachHang
                .FirstOrDefault(x => x.TenDangNhap == tenDangNhap && x.DienThoai == soDienThoai);

            if (khachHang == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc số điện thoại không đúng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            khachHang.MatKhau = matKhauMoi;
            context.SaveChanges();

            MessageBox.Show("Khôi phục mật khẩu thành công. Vui lòng đăng nhập lại.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}