using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmDangNhap
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
            panelLeft = new Panel();
            lblMoTa = new Label();
            lblHeThong = new Label();
            panelRight = new Panel();
            chkHienMatKhau = new CheckBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblDangNhap = new Label();
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
            panelLeft.Size = new Size(453, 667);
            panelLeft.TabIndex = 0;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.ForeColor = Color.Gainsboro;
            lblMoTa.Location = new Point(43, 313);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(292, 46);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Đăng nhập để quản lý vé, hóa đơn,\r\nkhách hàng và các danh mục hệ thống.";
            // 
            // lblHeThong
            // 
            lblHeThong.AutoSize = true;
            lblHeThong.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeThong.ForeColor = Color.White;
            lblHeThong.Location = new Point(40, 160);
            lblHeThong.Name = "lblHeThong";
            lblHeThong.Size = new Size(356, 92);
            lblHeThong.TabIndex = 0;
            lblHeThong.Text = "HỆ THỐNG\r\nĐẶT VÉ SÂN VẬN ĐỘNG";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(chkHienMatKhau);
            panelRight.Controls.Add(btnThoat);
            panelRight.Controls.Add(btnDangNhap);
            panelRight.Controls.Add(txtMatKhau);
            panelRight.Controls.Add(txtTenDangNhap);
            panelRight.Controls.Add(lblMatKhau);
            panelRight.Controls.Add(lblTenDangNhap);
            panelRight.Controls.Add(lblDangNhap);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(453, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(461, 667);
            panelRight.TabIndex = 1;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 9.5F);
            chkHienMatKhau.Location = new Point(82, 433);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(124, 25);
            chkHienMatKhau.TabIndex = 2;
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
            btnThoat.Location = new Point(254, 493);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 56);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(37, 99, 235);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(82, 493);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(160, 56);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(82, 367);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(331, 32);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(82, 233);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(331, 32);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatKhau.Location = new Point(82, 327);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(82, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenDangNhap.Location = new Point(82, 193);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(131, 23);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDangNhap.ForeColor = Color.FromArgb(30, 41, 59);
            lblDangNhap.Location = new Point(80, 93);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(284, 41);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "Đăng nhập hệ thống";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            Load += frmDangNhap_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblMoTa;
        private Label lblHeThong;
        private Panel panelRight;
        private CheckBox chkHienMatKhau;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private Label lblTenDangNhap;
        private Label lblDangNhap;
    }
}