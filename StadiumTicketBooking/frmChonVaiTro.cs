using System;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmChonVaiTro : Form
    {
        public frmChonVaiTro()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmDangNhapKhachHang f = new frmDangNhapKhachHang();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}