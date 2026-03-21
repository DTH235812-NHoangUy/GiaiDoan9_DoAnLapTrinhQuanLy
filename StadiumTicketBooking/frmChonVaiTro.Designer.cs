using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmChonVaiTro
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
            lblTitle = new Label();
            lblSubTitle = new Label();
            grpLuaChon = new GroupBox();
            btnThoat = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            grpLuaChon.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1012, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ ĐẶT VÉ SÂN VẬN ĐỘNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Dock = DockStyle.Top;
            lblSubTitle.Font = new Font("Segoe UI", 10F);
            lblSubTitle.Location = new Point(0, 70);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(1012, 35);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Vui lòng chọn loại đăng nhập";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpLuaChon
            // 
            grpLuaChon.Controls.Add(btnThoat);
            grpLuaChon.Controls.Add(btnKhachHang);
            grpLuaChon.Controls.Add(btnNhanVien);
            grpLuaChon.Location = new Point(263, 139);
            grpLuaChon.Name = "grpLuaChon";
            grpLuaChon.Size = new Size(500, 220);
            grpLuaChon.TabIndex = 2;
            grpLuaChon.TabStop = false;
            grpLuaChon.Text = "Lựa chọn";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(160, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 45);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhachHang.Location = new Point(270, 70);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(180, 50);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.Location = new Point(50, 70);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(180, 50);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân viên / Admin";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // frmChonVaiTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 462);
            Controls.Add(grpLuaChon);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmChonVaiTro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn vai trò đăng nhập";
            grpLuaChon.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblSubTitle;
        private GroupBox grpLuaChon;
        private Button btnThoat;
        private Button btnKhachHang;
        private Button btnNhanVien;
    }
}