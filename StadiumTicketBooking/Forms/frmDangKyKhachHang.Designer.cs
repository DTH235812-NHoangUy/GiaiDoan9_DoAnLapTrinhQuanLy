using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmDangKyKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblMoTa = new Label();
            lblHeThong = new Label();
            panelRight = new Panel();
            chkTrangThai = new CheckBox();
            chkHienMatKhau = new CheckBox();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnDangKy = new Button();
            txtNhapLaiMatKhau = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtHoVaTen = new TextBox();
            lblNhapLaiMatKhau = new Label();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblDienThoai = new Label();
            lblHoVaTen = new Label();
            lblDangKy = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 41, 59);
            panelLeft.Controls.Add(lblMoTa);
            panelLeft.Controls.Add(lblHeThong);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(453, 720);
            panelLeft.TabIndex = 0;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.ForeColor = Color.Gainsboro;
            lblMoTa.Location = new Point(43, 325);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(314, 69);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Tạo tài khoản khách hàng để đặt vé online,\r\nxem hóa đơn, theo dõi vé đã mua\r\nvà quản lý thông tin cá nhân.";
            // 
            // lblHeThong
            // 
            lblHeThong.AutoSize = true;
            lblHeThong.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeThong.ForeColor = Color.White;
            lblHeThong.Location = new Point(40, 165);
            lblHeThong.Name = "lblHeThong";
            lblHeThong.Size = new Size(356, 92);
            lblHeThong.TabIndex = 0;
            lblHeThong.Text = "HỆ THỐNG\r\nĐẶT VÉ SÂN VẬN ĐỘNG";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(chkTrangThai);
            panelRight.Controls.Add(chkHienMatKhau);
            panelRight.Controls.Add(btnThoat);
            panelRight.Controls.Add(btnLamMoi);
            panelRight.Controls.Add(btnDangKy);
            panelRight.Controls.Add(txtNhapLaiMatKhau);
            panelRight.Controls.Add(txtMatKhau);
            panelRight.Controls.Add(txtTenDangNhap);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(txtDiaChi);
            panelRight.Controls.Add(txtDienThoai);
            panelRight.Controls.Add(txtHoVaTen);
            panelRight.Controls.Add(lblNhapLaiMatKhau);
            panelRight.Controls.Add(lblMatKhau);
            panelRight.Controls.Add(lblTenDangNhap);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(lblDiaChi);
            panelRight.Controls.Add(lblDienThoai);
            panelRight.Controls.Add(lblHoVaTen);
            panelRight.Controls.Add(lblDangKy);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(453, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(507, 720);
            panelRight.TabIndex = 1;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Font = new Font("Segoe UI", 9.5F);
            chkTrangThai.Location = new Point(90, 539);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(107, 25);
            chkTrangThai.TabIndex = 7;
            chkTrangThai.Text = "Hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 9.5F);
            chkHienMatKhau.Location = new Point(90, 570);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(124, 25);
            chkHienMatKhau.TabIndex = 8;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(239, 68, 68);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(330, 618);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(104, 54);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(30, 41, 59);
            btnLamMoi.Location = new Point(210, 618);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(104, 54);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(37, 99, 235);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(90, 618);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(104, 54);
            btnDangKy.TabIndex = 9;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Font = new Font("Segoe UI", 11F);
            txtNhapLaiMatKhau.Location = new Point(90, 490);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(344, 32);
            txtNhapLaiMatKhau.TabIndex = 6;
            txtNhapLaiMatKhau.KeyDown += txtNhapLaiMatKhau_KeyDown;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(90, 420);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(344, 32);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(90, 350);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(344, 32);
            txtTenDangNhap.TabIndex = 4;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(90, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 32);
            txtEmail.TabIndex = 3;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 11F);
            txtDiaChi.Location = new Point(90, 210);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(344, 32);
            txtDiaChi.TabIndex = 2;
            txtDiaChi.KeyDown += txtDiaChi_KeyDown;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 11F);
            txtDienThoai.Location = new Point(90, 140);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(344, 32);
            txtDienThoai.TabIndex = 1;
            txtDienThoai.KeyDown += txtDienThoai_KeyDown;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 11F);
            txtHoVaTen.Location = new Point(90, 70);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(344, 32);
            txtHoVaTen.TabIndex = 0;
            txtHoVaTen.KeyDown += txtHoVaTen_KeyDown;
            // 
            // lblNhapLaiMatKhau
            // 
            lblNhapLaiMatKhau.AutoSize = true;
            lblNhapLaiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNhapLaiMatKhau.Location = new Point(90, 460);
            lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            lblNhapLaiMatKhau.Size = new Size(153, 23);
            lblNhapLaiMatKhau.TabIndex = 6;
            lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatKhau.Location = new Point(90, 390);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(82, 23);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenDangNhap.Location = new Point(90, 320);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(131, 23);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(90, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiaChi.Location = new Point(90, 180);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(61, 23);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDienThoai.Location = new Point(90, 110);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(87, 23);
            lblDienThoai.TabIndex = 1;
            lblDienThoai.Text = "Điện thoại";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHoVaTen.Location = new Point(90, 40);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(82, 23);
            lblHoVaTen.TabIndex = 0;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDangKy.ForeColor = Color.FromArgb(30, 41, 59);
            lblDangKy.Location = new Point(90, -62);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(0, 41);
            lblDangKy.TabIndex = 99;
            // 
            // frmDangKyKhachHang
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 720);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangKyKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký khách hàng";
            Load += frmDangKyKhachHang_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelLeft;
        private Label lblMoTa;
        private Label lblHeThong;
        private Panel panelRight;
        private CheckBox chkTrangThai;
        private CheckBox chkHienMatKhau;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnDangKy;
        private TextBox txtNhapLaiMatKhau;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private Label lblNhapLaiMatKhau;
        private Label lblMatKhau;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblDienThoai;
        private Label lblHoVaTen;
        private Label lblDangKy;
    }
}