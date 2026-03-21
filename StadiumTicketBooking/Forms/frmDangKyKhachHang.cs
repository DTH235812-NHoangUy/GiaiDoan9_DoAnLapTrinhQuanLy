using System;
using System.Linq;
using System.Windows.Forms;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDangKyKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        public frmDangKyKhachHang()
        {
            InitializeComponent();
        }

        private void frmDangKyKhachHang_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
            txtNhapLaiMatKhau.PasswordChar = '●';
            chkHienMatKhau.Checked = false;
            chkTrangThai.Checked = true;
            txtHoVaTen.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char kyTu = chkHienMatKhau.Checked ? '\0' : '●';
            txtMatKhau.PasswordChar = kyTu;
            txtNhapLaiMatKhau.PasswordChar = kyTu;
        }

        private void txtHoVaTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDienThoai.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiaChi.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTenDangNhap.Focus();
                e.SuppressKeyPress = true;
            }
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
                txtNhapLaiMatKhau.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNhapLaiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtHoVaTen.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            bool trangThai = chkTrangThai.Checked;

            if (string.IsNullOrWhiteSpace(hoVaTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }

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

            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
                return;
            }

            bool trungTenDangNhap = context.KhachHang.Any(x => x.TenDangNhap == tenDangNhap);
            if (trungTenDangNhap)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectAll();
                return;
            }

            bool daTonTai = context.KhachHang.Any(x =>
                x.HoVaTen == hoVaTen &&
                x.DienThoai == dienThoai);

            if (daTonTai)
            {
                MessageBox.Show("Khách hàng này đã tồn tại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                txtHoVaTen.SelectAll();
                return;
            }

            try
            {
                KhachHang kh = new KhachHang
                {
                    HoVaTen = hoVaTen,
                    DienThoai = string.IsNullOrWhiteSpace(dienThoai) ? null : dienThoai,
                    DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi,
                    Email = string.IsNullOrWhiteSpace(email) ? null : email,
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    NgayTao = DateTime.Now,
                    TrangThai = trangThai
                };

                context.KhachHang.Add(kh);
                context.SaveChanges();

                MessageBox.Show("Đăng ký thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult hoi = MessageBox.Show(
                    "Bạn có muốn đăng nhập ngay không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoi == DialogResult.Yes)
                {
                    using (frmDangNhapKhachHang f = new frmDangNhapKhachHang())
                    {
                        Hide();
                        f.ShowDialog();
                        Show();
                    }
                }
                else
                {
                    LamMoiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LamMoiDuLieu()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMatKhau.Clear();
            chkTrangThai.Checked = true;
            chkHienMatKhau.Checked = false;
            txtHoVaTen.Focus();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}