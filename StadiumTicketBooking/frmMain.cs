using System;
using System.Drawing;
using System.Windows.Forms;
using StadiumTicketBooking.Reports;

namespace StadiumTicketBooking.Forms
{
    public partial class frmMain : Form
    {
        private int nhanVienID = 0;
        private string tenDangNhap = "";
        private string vaiTro = "";
        private Form formHienTai = null;
        private Button btnDangChon = null;

        public int NhanVienIDHienTai => nhanVienID;
        public string TenDangNhapHienTai => tenDangNhap;
        public string VaiTroHienTai => vaiTro;

        public frmMain()
        {
            InitializeComponent();
            CaiDatMenu();
        }

        public frmMain(int nhanVienID, string tenDangNhap, string vaiTro)
        {
            InitializeComponent();
            this.nhanVienID = nhanVienID;
            this.tenDangNhap = tenDangNhap;
            this.vaiTro = vaiTro;
            CaiDatMenu();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiThongTinDangNhap();
            PhanQuyenTheoVaiTro();
            HienThiTrangChu();
            KichHoatButtonMenu(btnTrangChu);
        }

        private void CaiDatMenu()
        {
            CaiDatButtonMenu(btnTrangChu);
            CaiDatButtonMenu(btnDatVe);
            CaiDatButtonMenu(btnHoaDon);
            CaiDatButtonMenu(btnChiTietHoaDon);
            CaiDatButtonMenu(btnKhachHang);
            CaiDatButtonMenu(btnVe);
            CaiDatButtonMenu(btnDanhSachVe);
            CaiDatButtonMenu(btnThongKeDoanhThu);
            CaiDatButtonMenu(btnSuKien);
            CaiDatButtonMenu(btnGhe);
            CaiDatButtonMenu(btnKhuVuc);
            CaiDatButtonMenu(btnSanVanDong);
            CaiDatButtonMenu(btnNhanVien);
            CaiDatButtonMenu(btnVaiTro);
            CaiDatButtonMenu(btnDangXuat);
        }

        private void CaiDatButtonMenu(Button btn)
        {
            btn.BackColor = Color.FromArgb(30, 41, 59);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);

            btn.MouseEnter -= BtnMenu_MouseEnter;
            btn.MouseLeave -= BtnMenu_MouseLeave;
            btn.MouseEnter += BtnMenu_MouseEnter;
            btn.MouseLeave += BtnMenu_MouseLeave;
        }

        private void DatLaiButtonMenu()
        {
            DatStyleMacDinh(btnTrangChu);
            DatStyleMacDinh(btnDatVe);
            DatStyleMacDinh(btnHoaDon);
            DatStyleMacDinh(btnChiTietHoaDon);
            DatStyleMacDinh(btnKhachHang);
            DatStyleMacDinh(btnVe);
            DatStyleMacDinh(btnDanhSachVe);
            DatStyleMacDinh(btnThongKeDoanhThu);
            DatStyleMacDinh(btnSuKien);
            DatStyleMacDinh(btnGhe);
            DatStyleMacDinh(btnKhuVuc);
            DatStyleMacDinh(btnSanVanDong);
            DatStyleMacDinh(btnNhanVien);
            DatStyleMacDinh(btnVaiTro);
            DatStyleMacDinh(btnDangXuat);
        }

        private void DatStyleMacDinh(Button btn)
        {
            if (btn == null) return;

            btn.BackColor = Color.FromArgb(30, 41, 59);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void KichHoatButtonMenu(Button btn)
        {
            if (btn == null) return;

            DatLaiButtonMenu();

            btnDangChon = btn;
            btn.BackColor = Color.FromArgb(51, 65, 85);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void BtnMenu_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != btnDangChon)
                btn.BackColor = Color.FromArgb(51, 65, 85);
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != btnDangChon)
                btn.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void HienThiThongTinDangNhap()
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                tenDangNhap = "Nguyễn Hoàng Uy";

            if (string.IsNullOrWhiteSpace(vaiTro))
                vaiTro = "Admin";

            string role = vaiTro.Trim().ToLower();

            if (role == "admin")
            {
                lblNguoiDung.Text = "Admin: " + tenDangNhap;
                lblVaiTro.Text = "";
            }
            else if (role == "nhanvien" || role == "nhân viên")
            {
                lblNguoiDung.Text = "Nhân viên: " + tenDangNhap;
                lblVaiTro.Text = "";
            }
            else
            {
                lblNguoiDung.Text = "Người dùng: " + tenDangNhap;
                lblVaiTro.Text = "Vai trò: " + vaiTro;
            }
        }

        private void PhanQuyenTheoVaiTro()
        {
            string role = vaiTro.Trim().ToLower();

            if (role == "admin")
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = false;
                btnHoaDon.Visible = true;
                btnChiTietHoaDon.Visible = false;
                btnKhachHang.Visible = true;
                btnVe.Visible = true;
                btnDanhSachVe.Visible = true;
                btnThongKeDoanhThu.Visible = true;
                btnSuKien.Visible = true;
                btnGhe.Visible = true;
                btnKhuVuc.Visible = true;
                btnSanVanDong.Visible = true;
                btnNhanVien.Visible = true;
                btnVaiTro.Visible = true;
                btnDangXuat.Visible = true;
            }
            else if (role == "nhanvien" || role == "nhân viên")
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = true;
                btnHoaDon.Visible = true;
                btnChiTietHoaDon.Visible = false;
                btnKhachHang.Visible = true;
                btnVe.Visible = false;
                btnDanhSachVe.Visible = false;
                btnThongKeDoanhThu.Visible = false;
                btnSuKien.Visible = false;
                btnGhe.Visible = false;
                btnKhuVuc.Visible = false;
                btnSanVanDong.Visible = false;
                btnNhanVien.Visible = false;
                btnVaiTro.Visible = false;
                btnDangXuat.Visible = true;
            }
            else
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = false;
                btnHoaDon.Visible = false;
                btnChiTietHoaDon.Visible = false;
                btnKhachHang.Visible = false;
                btnVe.Visible = false;
                btnDanhSachVe.Visible = false;
                btnThongKeDoanhThu.Visible = false;
                btnSuKien.Visible = false;
                btnGhe.Visible = false;
                btnKhuVuc.Visible = false;
                btnSanVanDong.Visible = false;
                btnNhanVien.Visible = false;
                btnVaiTro.Visible = false;
                btnDangXuat.Visible = true;
            }
        }

        private void MoFormCon(Form frm)
        {
            if (formHienTai != null)
                formHienTai.Close();

            formHienTai = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(frm);
            panelBody.Tag = frm;

            frm.Show();
            frm.BringToFront();
        }

        private void HienThiTrangChu()
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
                formHienTai = null;
            }

            panelBody.Controls.Clear();

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(30, 41, 59);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = "Chào mừng đến với hệ thống quản lý đặt vé sân vận động";

            panelBody.Controls.Add(lbl);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnTrangChu);
            HienThiTrangChu();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnDatVe);
            MoFormCon(new frmDatVe(nhanVienID, vaiTro));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnHoaDon);
            MoFormCon(new frmHoaDon(nhanVienID, vaiTro));
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnChiTietHoaDon);
            MoFormCon(new frmHoaDon_ChiTiet(0, nhanVienID, vaiTro));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnKhachHang);
            MoFormCon(new frmKhachHang(vaiTro));
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnVe);
            MoFormCon(new frmVe());
        }

        private void btnDanhSachVe_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnDanhSachVe);
            MoFormCon(new frmDanhSachVe());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnThongKeDoanhThu);
            MoFormCon(new frmThongKeDoanhThu());
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnSuKien);
            MoFormCon(new frmSuKien());
        }

        private void btnGhe_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnGhe);
            MoFormCon(new frmGhe());
        }

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnKhuVuc);
            MoFormCon(new frmKhuVuc());
        }

        private void btnSanVanDong_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnSanVanDong);
            MoFormCon(new frmSanVanDong());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnNhanVien);
            MoFormCon(new frmNhanVien());
        }

        private void btnVaiTro_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnVaiTro);
            MoFormCon(new frmVaiTro());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            KichHoatButtonMenu(btnDangXuat);

            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                Close();
            }
            else
            {
                if (formHienTai == null)
                    KichHoatButtonMenu(btnTrangChu);
            }
        }
    }
}