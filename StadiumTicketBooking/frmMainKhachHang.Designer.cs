namespace StadiumTicketBooking.Forms
{
    partial class frmMainKhachHang
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
            pnlTop = new Panel();
            lblThongTin = new Label();
            lblXinChao = new Label();
            lblTitle = new Label();
            grpChucNang = new GroupBox();
            btnDangXuat = new Button();
            btnDoiMatKhau = new Button();
            btnHoaDonCuaToi = new Button();
            btnDatVe = new Button();
            lblMoTa = new Label();
            pnlTop.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(28, 41, 63);
            pnlTop.Controls.Add(lblThongTin);
            pnlTop.Controls.Add(lblXinChao);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(984, 140);
            pnlTop.TabIndex = 0;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 11F);
            lblThongTin.ForeColor = Color.White;
            lblThongTin.Location = new Point(37, 96);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(122, 25);
            lblThongTin.TabIndex = 2;
            lblThongTin.Text = "Thông tin KH";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblXinChao.ForeColor = Color.White;
            lblXinChao.Location = new Point(37, 60);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(209, 28);
            lblXinChao.TabIndex = 1;
            lblXinChao.Text = "Xin chào khách hàng";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(29, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(404, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANG CHỦ KHÁCH HÀNG";
            // 
            // grpChucNang
            // 
            grpChucNang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpChucNang.Controls.Add(btnDangXuat);
            grpChucNang.Controls.Add(btnDoiMatKhau);
            grpChucNang.Controls.Add(btnHoaDonCuaToi);
            grpChucNang.Controls.Add(btnDatVe);
            grpChucNang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpChucNang.Location = new Point(105, 233);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(774, 224);
            grpChucNang.TabIndex = 1;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Top;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangXuat.Location = new Point(411, 126);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(200, 55);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Anchor = AnchorStyles.Top;
            btnDoiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDoiMatKhau.Location = new Point(168, 126);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(200, 55);
            btnDoiMatKhau.TabIndex = 2;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnHoaDonCuaToi
            // 
            btnHoaDonCuaToi.Anchor = AnchorStyles.Top;
            btnHoaDonCuaToi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHoaDonCuaToi.Location = new Point(411, 48);
            btnHoaDonCuaToi.Name = "btnHoaDonCuaToi";
            btnHoaDonCuaToi.Size = new Size(200, 55);
            btnHoaDonCuaToi.TabIndex = 1;
            btnHoaDonCuaToi.Text = "Hóa đơn của tôi";
            btnHoaDonCuaToi.UseVisualStyleBackColor = true;
            btnHoaDonCuaToi.Click += btnHoaDonCuaToi_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Anchor = AnchorStyles.Top;
            btnDatVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatVe.Location = new Point(168, 48);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(200, 55);
            btnDatVe.TabIndex = 0;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // lblMoTa
            // 
            lblMoTa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMoTa.Font = new Font("Segoe UI", 12F);
            lblMoTa.Location = new Point(29, 156);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(926, 53);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Chào mừng bạn đến với hệ thống đặt vé sân vận động. Vui lòng chọn chức năng muốn thực hiện.";
            lblMoTa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMainKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(lblMoTa);
            Controls.Add(grpChucNang);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            MinimumSize = new Size(900, 550);
            Name = "frmMainKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ khách hàng";
            WindowState = FormWindowState.Normal;
            FormClosing += frmMainKhachHang_FormClosing;
            Load += frmMainKhachHang_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnHoaDonCuaToi;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Label lblMoTa;
    }
}