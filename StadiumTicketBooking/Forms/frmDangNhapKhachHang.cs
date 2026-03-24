using System;
using System.Linq;
using System.Windows.Forms;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDangNhapKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private readonly int? suKienIDDuocChon = null;

        public frmDangNhapKhachHang()
        {
            InitializeComponent();
        }

        public frmDangNhapKhachHang(int suKienID)
        {
            InitializeComponent();
            suKienIDDuocChon = suKienID;
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
                MessageBox.Show(
                    "Vui lòng nhập tên đăng nhập.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            // 1. Tìm theo tên đăng nhập trước
            var kh = context.KhachHang
                .FirstOrDefault(x => x.TenDangNhap == tenDangNhap);

            if (kh == null)
            {
                MessageBox.Show(
                    "Tên đăng nhập không tồn tại.",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectAll();
                return;
            }

            // 2. Kiểm tra trạng thái hoạt động
            if (!kh.TrangThai)
            {
                MessageBox.Show(
                    "Tài khoản của bạn đã bị khóa.",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra mật khẩu
            if (kh.MatKhau != matKhau)
            {
                MessageBox.Show(
                    "Sai mật khẩu.",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
                return;
            }

            UserSession.KhachHangID = kh.ID;
            UserSession.HoVaTen = kh.HoVaTen;
            UserSession.TenDangNhap = kh.TenDangNhap;
            UserSession.DaDangNhap = true;

            MessageBox.Show(
                "Đăng nhập thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (suKienIDDuocChon.HasValue)
            {
                using (frmDatVeKhachHang f = new frmDatVeKhachHang(kh.ID, kh.HoVaTen, suKienIDDuocChon.Value))
                {
                    Hide();
                    f.ShowDialog();
                    Show();
                }
            }
            else
            {
                using (frmMainKhachHang f = new frmMainKhachHang(kh))
                {
                    Hide();
                    f.ShowDialog();
                    Show();
                }
            }
        }

        private void btnMoDangKy_Click(object sender, EventArgs e)
        {
            using (frmDangKyKhachHang f = new frmDangKyKhachHang())
            {
                f.ShowDialog();
            }

            txtMatKhau.Clear();
            txtTenDangNhap.Focus();

            if (suKienIDDuocChon.HasValue)
            {
                MessageBox.Show(
                    "Đăng ký xong. Vui lòng đăng nhập để tiếp tục đặt vé cho sự kiện đã chọn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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