using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnDangXuat = new Button();
            btnVaiTro = new Button();
            btnNhanVien = new Button();
            btnSanVanDong = new Button();
            btnKhuVuc = new Button();
            btnGhe = new Button();
            btnSuKien = new Button();
            btnVe = new Button();
            btnKhachHang = new Button();
            btnChiTietHoaDon = new Button();
            btnHoaDon = new Button();
            btnDatVe = new Button();
            btnTrangChu = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTop = new Panel();
            lblVaiTro = new Label();
            lblNguoiDung = new Label();
            lblTenHeThong = new Label();
            panelBody = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 41, 59);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnVaiTro);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnSanVanDong);
            panelMenu.Controls.Add(btnKhuVuc);
            panelMenu.Controls.Add(btnGhe);
            panelMenu.Controls.Add(btnSuKien);
            panelMenu.Controls.Add(btnVe);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnChiTietHoaDon);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnDatVe);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(274, 960);
            panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.Location = new Point(0, 896);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(274, 64);
            btnDangXuat.TabIndex = 12;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnVaiTro
            // 
            btnVaiTro.Dock = DockStyle.Top;
            btnVaiTro.Location = new Point(0, 841);
            btnVaiTro.Name = "btnVaiTro";
            btnVaiTro.Size = new Size(274, 64);
            btnVaiTro.TabIndex = 11;
            btnVaiTro.Text = "Vai trò";
            btnVaiTro.UseVisualStyleBackColor = true;
            btnVaiTro.Click += btnVaiTro_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.Location = new Point(0, 777);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(274, 64);
            btnNhanVien.TabIndex = 10;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnSanVanDong
            // 
            btnSanVanDong.Dock = DockStyle.Top;
            btnSanVanDong.Location = new Point(0, 713);
            btnSanVanDong.Name = "btnSanVanDong";
            btnSanVanDong.Size = new Size(274, 64);
            btnSanVanDong.TabIndex = 9;
            btnSanVanDong.Text = "Sân vận động";
            btnSanVanDong.UseVisualStyleBackColor = true;
            btnSanVanDong.Click += btnSanVanDong_Click;
            // 
            // btnKhuVuc
            // 
            btnKhuVuc.Dock = DockStyle.Top;
            btnKhuVuc.Location = new Point(0, 649);
            btnKhuVuc.Name = "btnKhuVuc";
            btnKhuVuc.Size = new Size(274, 64);
            btnKhuVuc.TabIndex = 8;
            btnKhuVuc.Text = "Khu vực";
            btnKhuVuc.UseVisualStyleBackColor = true;
            btnKhuVuc.Click += btnKhuVuc_Click;
            // 
            // btnGhe
            // 
            btnGhe.Dock = DockStyle.Top;
            btnGhe.Location = new Point(0, 585);
            btnGhe.Name = "btnGhe";
            btnGhe.Size = new Size(274, 64);
            btnGhe.TabIndex = 7;
            btnGhe.Text = "Ghế";
            btnGhe.UseVisualStyleBackColor = true;
            btnGhe.Click += btnGhe_Click;
            // 
            // btnSuKien
            // 
            btnSuKien.Dock = DockStyle.Top;
            btnSuKien.Location = new Point(0, 521);
            btnSuKien.Name = "btnSuKien";
            btnSuKien.Size = new Size(274, 64);
            btnSuKien.TabIndex = 6;
            btnSuKien.Text = "Sự kiện";
            btnSuKien.UseVisualStyleBackColor = true;
            btnSuKien.Click += btnSuKien_Click;
            // 
            // btnVe
            // 
            btnVe.Dock = DockStyle.Top;
            btnVe.Location = new Point(0, 457);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(274, 64);
            btnVe.TabIndex = 5;
            btnVe.Text = "Vé";
            btnVe.UseVisualStyleBackColor = true;
            btnVe.Click += btnVe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.Location = new Point(0, 393);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(274, 64);
            btnKhachHang.TabIndex = 4;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.Dock = DockStyle.Top;
            btnChiTietHoaDon.Location = new Point(0, 329);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(274, 64);
            btnChiTietHoaDon.TabIndex = 3;
            btnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            btnChiTietHoaDon.UseVisualStyleBackColor = true;
            btnChiTietHoaDon.Click += btnChiTietHoaDon_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.Location = new Point(0, 265);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(274, 64);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Dock = DockStyle.Top;
            btnDatVe.Location = new Point(0, 191);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(274, 74);
            btnDatVe.TabIndex = 1;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.Location = new Point(0, 127);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(274, 64);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(15, 23, 42);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(274, 127);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(274, 127);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "STADIUM\r\nTICKET BOOKING";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblVaiTro);
            panelTop.Controls.Add(lblNguoiDung);
            panelTop.Controls.Add(lblTenHeThong);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(274, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1212, 100);
            panelTop.TabIndex = 1;
            // 
            // lblVaiTro
            // 
            lblVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.Location = new Point(848, 56);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(113, 23);
            lblVaiTro.TabIndex = 2;
            lblVaiTro.Text = "Vai trò: Trống";
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Font = new Font("Segoe UI", 10F);
            lblNguoiDung.Location = new Point(816, 19);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(239, 23);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.Text = "Người dùng: Chưa đăng nhập";
            // 
            // lblTenHeThong
            // 
            lblTenHeThong.AutoSize = true;
            lblTenHeThong.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenHeThong.ForeColor = Color.FromArgb(30, 41, 59);
            lblTenHeThong.Location = new Point(23, 27);
            lblTenHeThong.Name = "lblTenHeThong";
            lblTenHeThong.Size = new Size(448, 37);
            lblTenHeThong.TabIndex = 0;
            lblTenHeThong.Text = "QUẢN LÝ ĐẶT VÉ SÂN VẬN ĐỘNG";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(241, 245, 249);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(274, 100);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1212, 860);
            panelBody.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(panelBody);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý đặt vé sân vận động";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Label lblLogo;
        private Button btnTrangChu;
        private Button btnDatVe;
        private Button btnHoaDon;
        private Button btnChiTietHoaDon;
        private Button btnKhachHang;
        private Button btnVe;
        private Button btnSuKien;
        private Button btnGhe;
        private Button btnKhuVuc;
        private Button btnSanVanDong;
        private Button btnNhanVien;
        private Button btnVaiTro;
        private Button btnDangXuat;
        private Panel panelTop;
        private Label lblTenHeThong;
        private Label lblNguoiDung;
        private Label lblVaiTro;
        private Panel panelBody;
    }
}