using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmTrangChu
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
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            grpSuKien = new GroupBox();
            pnlEvent1 = new Panel();
            lblTenSK1 = new Label();
            lblSan1 = new Label();
            lblThoiGian1 = new Label();
            lblGia1 = new Label();
            btnDatVe1 = new Button();
            pnlEvent2 = new Panel();
            lblTenSK2 = new Label();
            lblSan2 = new Label();
            lblThoiGian2 = new Label();
            lblGia2 = new Label();
            btnDatVe2 = new Button();
            pnlEvent3 = new Panel();
            lblTenSK3 = new Label();
            lblSan3 = new Label();
            lblThoiGian3 = new Label();
            lblGia3 = new Label();
            btnDatVe3 = new Button();
            grpChucNang = new GroupBox();
            btnNhanVien = new Button();
            btnKhachDangNhap = new Button();
            btnDangKy = new Button();
            btnTaiQuay = new Button();
            btnThoat = new Button();
            lblFooter = new Label();
            pnlTimKiem.SuspendLayout();
            grpSuKien.SuspendLayout();
            pnlEvent1.SuspendLayout();
            pnlEvent2.SuspendLayout();
            pnlEvent3.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Cursor = Cursors.Hand;
            lblTieuDe.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(25, 55, 109);
            lblTieuDe.Location = new Point(0, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1200, 50);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ ĐẶT VÉ SÂN VẬN ĐỘNG";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Click += lblTieuDe_Click;
            // 
            // lblPhuDe
            // 
            lblPhuDe.Font = new Font("Segoe UI", 11F);
            lblPhuDe.ForeColor = Color.DimGray;
            lblPhuDe.Location = new Point(0, 70);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(1200, 30);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Đặt vé nhanh chóng - quản lý thuận tiện - theo dõi sự kiện dễ dàng";
            lblPhuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.BorderStyle = BorderStyle.FixedSingle;
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Location = new Point(80, 120);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1040, 60);
            pnlTimKiem.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(20, 13);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên sự kiện hoặc sân vận động...";
            txtTimKiem.Size = new Size(830, 32);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(25, 135, 84);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(870, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpSuKien
            // 
            grpSuKien.Controls.Add(pnlEvent1);
            grpSuKien.Controls.Add(pnlEvent2);
            grpSuKien.Controls.Add(pnlEvent3);
            grpSuKien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpSuKien.ForeColor = Color.FromArgb(25, 55, 109);
            grpSuKien.Location = new Point(80, 200);
            grpSuKien.Name = "grpSuKien";
            grpSuKien.Size = new Size(720, 420);
            grpSuKien.TabIndex = 3;
            grpSuKien.TabStop = false;
            grpSuKien.Text = "SỰ KIỆN NỔI BẬT";
            // 
            // pnlEvent1
            // 
            pnlEvent1.BackColor = Color.White;
            pnlEvent1.BorderStyle = BorderStyle.FixedSingle;
            pnlEvent1.Controls.Add(lblTenSK1);
            pnlEvent1.Controls.Add(lblSan1);
            pnlEvent1.Controls.Add(lblThoiGian1);
            pnlEvent1.Controls.Add(lblGia1);
            pnlEvent1.Controls.Add(btnDatVe1);
            pnlEvent1.Location = new Point(20, 35);
            pnlEvent1.Name = "pnlEvent1";
            pnlEvent1.Size = new Size(680, 105);
            pnlEvent1.TabIndex = 0;
            // 
            // lblTenSK1
            // 
            lblTenSK1.AutoSize = true;
            lblTenSK1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenSK1.ForeColor = Color.FromArgb(20, 39, 90);
            lblTenSK1.Location = new Point(18, 10);
            lblTenSK1.Name = "lblTenSK1";
            lblTenSK1.Size = new Size(0, 28);
            lblTenSK1.TabIndex = 0;
            // 
            // lblSan1
            // 
            lblSan1.AutoSize = true;
            lblSan1.Font = new Font("Segoe UI", 10F);
            lblSan1.Location = new Point(18, 42);
            lblSan1.Name = "lblSan1";
            lblSan1.Size = new Size(0, 23);
            lblSan1.TabIndex = 1;
            // 
            // lblThoiGian1
            // 
            lblThoiGian1.AutoSize = true;
            lblThoiGian1.Font = new Font("Segoe UI", 10F);
            lblThoiGian1.Location = new Point(18, 68);
            lblThoiGian1.Name = "lblThoiGian1";
            lblThoiGian1.Size = new Size(0, 23);
            lblThoiGian1.TabIndex = 2;
            // 
            // lblGia1
            // 
            lblGia1.AutoSize = true;
            lblGia1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGia1.ForeColor = Color.Firebrick;
            lblGia1.Location = new Point(360, 42);
            lblGia1.Name = "lblGia1";
            lblGia1.Size = new Size(0, 23);
            lblGia1.TabIndex = 3;
            // 
            // btnDatVe1
            // 
            btnDatVe1.BackColor = Color.FromArgb(40, 167, 69);
            btnDatVe1.FlatStyle = FlatStyle.Flat;
            btnDatVe1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatVe1.ForeColor = Color.White;
            btnDatVe1.Location = new Point(550, 33);
            btnDatVe1.Name = "btnDatVe1";
            btnDatVe1.Size = new Size(125, 40);
            btnDatVe1.TabIndex = 4;
            btnDatVe1.Text = "Đặt vé";
            btnDatVe1.UseVisualStyleBackColor = false;
            btnDatVe1.Click += btnDatVe1_Click;
            // 
            // pnlEvent2
            // 
            pnlEvent2.BackColor = Color.White;
            pnlEvent2.BorderStyle = BorderStyle.FixedSingle;
            pnlEvent2.Controls.Add(lblTenSK2);
            pnlEvent2.Controls.Add(lblSan2);
            pnlEvent2.Controls.Add(lblThoiGian2);
            pnlEvent2.Controls.Add(lblGia2);
            pnlEvent2.Controls.Add(btnDatVe2);
            pnlEvent2.Location = new Point(20, 155);
            pnlEvent2.Name = "pnlEvent2";
            pnlEvent2.Size = new Size(680, 105);
            pnlEvent2.TabIndex = 1;
            // 
            // lblTenSK2
            // 
            lblTenSK2.AutoSize = true;
            lblTenSK2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenSK2.ForeColor = Color.FromArgb(20, 39, 90);
            lblTenSK2.Location = new Point(18, 10);
            lblTenSK2.Name = "lblTenSK2";
            lblTenSK2.Size = new Size(0, 28);
            lblTenSK2.TabIndex = 0;
            // 
            // lblSan2
            // 
            lblSan2.AutoSize = true;
            lblSan2.Font = new Font("Segoe UI", 10F);
            lblSan2.Location = new Point(18, 42);
            lblSan2.Name = "lblSan2";
            lblSan2.Size = new Size(0, 23);
            lblSan2.TabIndex = 1;
            // 
            // lblThoiGian2
            // 
            lblThoiGian2.AutoSize = true;
            lblThoiGian2.Font = new Font("Segoe UI", 10F);
            lblThoiGian2.Location = new Point(18, 68);
            lblThoiGian2.Name = "lblThoiGian2";
            lblThoiGian2.Size = new Size(0, 23);
            lblThoiGian2.TabIndex = 2;
            // 
            // lblGia2
            // 
            lblGia2.AutoSize = true;
            lblGia2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGia2.ForeColor = Color.Firebrick;
            lblGia2.Location = new Point(360, 42);
            lblGia2.Name = "lblGia2";
            lblGia2.Size = new Size(0, 23);
            lblGia2.TabIndex = 3;
            // 
            // btnDatVe2
            // 
            btnDatVe2.BackColor = Color.FromArgb(40, 167, 69);
            btnDatVe2.FlatStyle = FlatStyle.Flat;
            btnDatVe2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatVe2.ForeColor = Color.White;
            btnDatVe2.Location = new Point(550, 33);
            btnDatVe2.Name = "btnDatVe2";
            btnDatVe2.Size = new Size(125, 40);
            btnDatVe2.TabIndex = 4;
            btnDatVe2.Text = "Đặt vé";
            btnDatVe2.UseVisualStyleBackColor = false;
            btnDatVe2.Click += btnDatVe2_Click;
            // 
            // pnlEvent3
            // 
            pnlEvent3.BackColor = Color.White;
            pnlEvent3.BorderStyle = BorderStyle.FixedSingle;
            pnlEvent3.Controls.Add(lblTenSK3);
            pnlEvent3.Controls.Add(lblSan3);
            pnlEvent3.Controls.Add(lblThoiGian3);
            pnlEvent3.Controls.Add(lblGia3);
            pnlEvent3.Controls.Add(btnDatVe3);
            pnlEvent3.Location = new Point(20, 275);
            pnlEvent3.Name = "pnlEvent3";
            pnlEvent3.Size = new Size(680, 105);
            pnlEvent3.TabIndex = 2;
            // 
            // lblTenSK3
            // 
            lblTenSK3.AutoSize = true;
            lblTenSK3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenSK3.ForeColor = Color.FromArgb(20, 39, 90);
            lblTenSK3.Location = new Point(18, 10);
            lblTenSK3.Name = "lblTenSK3";
            lblTenSK3.Size = new Size(0, 28);
            lblTenSK3.TabIndex = 0;
            // 
            // lblSan3
            // 
            lblSan3.AutoSize = true;
            lblSan3.Font = new Font("Segoe UI", 10F);
            lblSan3.Location = new Point(18, 42);
            lblSan3.Name = "lblSan3";
            lblSan3.Size = new Size(0, 23);
            lblSan3.TabIndex = 1;
            // 
            // lblThoiGian3
            // 
            lblThoiGian3.AutoSize = true;
            lblThoiGian3.Font = new Font("Segoe UI", 10F);
            lblThoiGian3.Location = new Point(18, 68);
            lblThoiGian3.Name = "lblThoiGian3";
            lblThoiGian3.Size = new Size(0, 23);
            lblThoiGian3.TabIndex = 2;
            // 
            // lblGia3
            // 
            lblGia3.AutoSize = true;
            lblGia3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGia3.ForeColor = Color.Firebrick;
            lblGia3.Location = new Point(360, 42);
            lblGia3.Name = "lblGia3";
            lblGia3.Size = new Size(0, 23);
            lblGia3.TabIndex = 3;
            // 
            // btnDatVe3
            // 
            btnDatVe3.BackColor = Color.FromArgb(40, 167, 69);
            btnDatVe3.FlatStyle = FlatStyle.Flat;
            btnDatVe3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatVe3.ForeColor = Color.White;
            btnDatVe3.Location = new Point(550, 29);
            btnDatVe3.Name = "btnDatVe3";
            btnDatVe3.Size = new Size(125, 40);
            btnDatVe3.TabIndex = 4;
            btnDatVe3.Text = "Đặt vé";
            btnDatVe3.UseVisualStyleBackColor = false;
            btnDatVe3.Click += btnDatVe3_Click;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnNhanVien);
            grpChucNang.Controls.Add(btnKhachDangNhap);
            grpChucNang.Controls.Add(btnDangKy);
            grpChucNang.Controls.Add(btnTaiQuay);
            grpChucNang.Controls.Add(btnThoat);
            grpChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpChucNang.ForeColor = Color.FromArgb(25, 55, 109);
            grpChucNang.Location = new Point(830, 200);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(290, 420);
            grpChucNang.TabIndex = 4;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "TRUY CẬP HỆ THỐNG";
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(52, 73, 94);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(25, 45);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(240, 45);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân viên / Admin";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachDangNhap
            // 
            btnKhachDangNhap.BackColor = Color.FromArgb(25, 135, 84);
            btnKhachDangNhap.FlatStyle = FlatStyle.Flat;
            btnKhachDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhachDangNhap.ForeColor = Color.White;
            btnKhachDangNhap.Location = new Point(25, 110);
            btnKhachDangNhap.Name = "btnKhachDangNhap";
            btnKhachDangNhap.Size = new Size(240, 45);
            btnKhachDangNhap.TabIndex = 1;
            btnKhachDangNhap.Text = "Khách hàng đăng nhập";
            btnKhachDangNhap.UseVisualStyleBackColor = false;
            btnKhachDangNhap.Click += btnKhachDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Goldenrod;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(25, 175);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(240, 45);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Khách hàng đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnTaiQuay
            // 
            btnTaiQuay.BackColor = Color.MediumPurple;
            btnTaiQuay.FlatStyle = FlatStyle.Flat;
            btnTaiQuay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaiQuay.ForeColor = Color.White;
            btnTaiQuay.Location = new Point(25, 240);
            btnTaiQuay.Name = "btnTaiQuay";
            btnTaiQuay.Size = new Size(240, 45);
            btnTaiQuay.TabIndex = 3;
            btnTaiQuay.Text = "Đặt vé tại quầy";
            btnTaiQuay.UseVisualStyleBackColor = false;
            btnTaiQuay.Click += btnTaiQuay_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gainsboro;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(25, 305);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(240, 45);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.DimGray;
            lblFooter.Location = new Point(0, 640);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1200, 25);
            lblFooter.TabIndex = 5;
            lblFooter.Text = "Hệ thống hỗ trợ khách hàng tự đặt vé và nhân viên đặt vé tại quầy";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1200, 680);
            Controls.Add(lblFooter);
            Controls.Add(grpChucNang);
            Controls.Add(grpSuKien);
            Controls.Add(pnlTimKiem);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ hệ thống đặt vé sân vận động";
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            grpSuKien.ResumeLayout(false);
            pnlEvent1.ResumeLayout(false);
            pnlEvent1.PerformLayout();
            pnlEvent2.ResumeLayout(false);
            pnlEvent2.PerformLayout();
            pnlEvent3.ResumeLayout(false);
            pnlEvent3.PerformLayout();
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblTieuDe;
        private Label lblPhuDe;
        private Panel pnlTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private GroupBox grpSuKien;
        private Panel pnlEvent1;
        private Label lblTenSK1;
        private Label lblSan1;
        private Label lblThoiGian1;
        private Label lblGia1;
        private Button btnDatVe1;
        private Panel pnlEvent2;
        private Label lblTenSK2;
        private Label lblSan2;
        private Label lblThoiGian2;
        private Label lblGia2;
        private Button btnDatVe2;
        private Panel pnlEvent3;
        private Label lblTenSK3;
        private Label lblSan3;
        private Label lblThoiGian3;
        private Label lblGia3;
        private Button btnDatVe3;
        private GroupBox grpChucNang;
        private Button btnNhanVien;
        private Button btnKhachDangNhap;
        private Button btnDangKy;
        private Button btnTaiQuay;
        private Button btnThoat;
        private Label lblFooter;
    }
}