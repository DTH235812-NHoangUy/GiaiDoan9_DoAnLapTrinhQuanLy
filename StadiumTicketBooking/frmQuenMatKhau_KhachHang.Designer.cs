namespace StadiumTicketBooking.Forms
{
    partial class frmQuenMatKhauKhachHang
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblMoTa = new Label();
            lblTitleLeft = new Label();
            panelRight = new Panel();
            chkHienMatKhau = new CheckBox();
            btnDong = new Button();
            btnKhoiPhuc = new Button();
            txtNhapLaiMatKhau = new TextBox();
            lblNhapLaiMatKhau = new Label();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(24, 39, 68);
            panelLeft.Controls.Add(lblMoTa);
            panelLeft.Controls.Add(lblTitleLeft);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(360, 560);
            panelLeft.TabIndex = 0;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoTa.ForeColor = Color.White;
            lblMoTa.Location = new Point(46, 280);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(250, 75);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Khôi phục mật khẩu khách hàng\r\nbằng tên đăng nhập và số điện thoại\r\nđã đăng ký trong hệ thống.";
            // 
            // lblTitleLeft
            // 
            lblTitleLeft.AutoSize = true;
            lblTitleLeft.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleLeft.ForeColor = Color.White;
            lblTitleLeft.Location = new Point(42, 150);
            lblTitleLeft.Name = "lblTitleLeft";
            lblTitleLeft.Size = new Size(265, 100);
            lblTitleLeft.TabIndex = 0;
            lblTitleLeft.Text = "KHÔI PHỤC\r\nMẬT KHẨU";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(chkHienMatKhau);
            panelRight.Controls.Add(btnDong);
            panelRight.Controls.Add(btnKhoiPhuc);
            panelRight.Controls.Add(txtNhapLaiMatKhau);
            panelRight.Controls.Add(lblNhapLaiMatKhau);
            panelRight.Controls.Add(txtMatKhauMoi);
            panelRight.Controls.Add(lblMatKhauMoi);
            panelRight.Controls.Add(txtSoDienThoai);
            panelRight.Controls.Add(lblSoDienThoai);
            panelRight.Controls.Add(txtTenDangNhap);
            panelRight.Controls.Add(lblTenDangNhap);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(360, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 560);
            panelRight.TabIndex = 1;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkHienMatKhau.Location = new Point(80, 396);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(126, 27);
            chkHienMatKhau.TabIndex = 10;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(244, 67, 54);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(272, 445);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(160, 48);
            btnDong.TabIndex = 9;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnKhoiPhuc
            // 
            btnKhoiPhuc.BackColor = Color.FromArgb(46, 91, 230);
            btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            btnKhoiPhuc.FlatStyle = FlatStyle.Flat;
            btnKhoiPhuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoiPhuc.ForeColor = Color.White;
            btnKhoiPhuc.Location = new Point(80, 445);
            btnKhoiPhuc.Name = "btnKhoiPhuc";
            btnKhoiPhuc.Size = new Size(160, 48);
            btnKhoiPhuc.TabIndex = 8;
            btnKhoiPhuc.Text = "Khôi phục";
            btnKhoiPhuc.UseVisualStyleBackColor = false;
            btnKhoiPhuc.Click += btnKhoiPhuc_Click;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhapLaiMatKhau.Location = new Point(80, 345);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(352, 32);
            txtNhapLaiMatKhau.TabIndex = 7;
            // 
            // lblNhapLaiMatKhau
            // 
            lblNhapLaiMatKhau.AutoSize = true;
            lblNhapLaiMatKhau.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblNhapLaiMatKhau.Location = new Point(80, 315);
            lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            lblNhapLaiMatKhau.Size = new Size(154, 25);
            lblNhapLaiMatKhau.TabIndex = 6;
            lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauMoi.Location = new Point(80, 262);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(352, 32);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhauMoi.Location = new Point(80, 232);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(122, 25);
            lblMatKhauMoi.TabIndex = 4;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(80, 179);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(352, 32);
            txtSoDienThoai.TabIndex = 3;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoDienThoai.Location = new Point(80, 149);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(119, 25);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(80, 96);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(352, 32);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenDangNhap.Location = new Point(80, 66);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(139, 25);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(24, 39, 68);
            lblTitle.Location = new Point(80, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 46);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Quên mật khẩu";
            // 
            // frmQuenMatKhauKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 560);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmQuenMatKhauKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu khách hàng";
            Load += frmQuenMatKhauKhachHang_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblMoTa;
        private Label lblTitleLeft;
        private Panel panelRight;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private TextBox txtMatKhauMoi;
        private Label lblMatKhauMoi;
        private TextBox txtNhapLaiMatKhau;
        private Label lblNhapLaiMatKhau;
        private Button btnKhoiPhuc;
        private Button btnDong;
        private CheckBox chkHienMatKhau;
        private Label lblTitle;
    }
}