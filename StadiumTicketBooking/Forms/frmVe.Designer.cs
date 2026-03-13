using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmVe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpTTVe = new GroupBox();
            cboTrangThai = new ComboBox();
            cboGhe = new ComboBox();
            cboSuKien = new ComboBox();
            btnDoiAnh = new KryptonButton();
            picHinhAnh = new PictureBox();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            txtGiaVe = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblTrangThai = new Label();
            lblGiaVe = new Label();
            lblGhe = new Label();
            lblSuKien = new Label();
            lblID = new Label();
            grpVe = new GroupBox();
            dgvVe = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colGiaVe = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVe).BeginInit();
            SuspendLayout();
            // 
            // grpTTVe
            // 
            grpTTVe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTVe.BackColor = Color.White;
            grpTTVe.Controls.Add(cboTrangThai);
            grpTTVe.Controls.Add(cboGhe);
            grpTTVe.Controls.Add(cboSuKien);
            grpTTVe.Controls.Add(btnDoiAnh);
            grpTTVe.Controls.Add(picHinhAnh);
            grpTTVe.Controls.Add(btnXuat);
            grpTTVe.Controls.Add(btnNhap);
            grpTTVe.Controls.Add(btnTimKiem);
            grpTTVe.Controls.Add(btnThoat);
            grpTTVe.Controls.Add(btnHuy);
            grpTTVe.Controls.Add(btnLuu);
            grpTTVe.Controls.Add(btnSua);
            grpTTVe.Controls.Add(btnXoa);
            grpTTVe.Controls.Add(btnThem);
            grpTTVe.Controls.Add(txtGiaVe);
            grpTTVe.Controls.Add(txtID);
            grpTTVe.Controls.Add(lblTrangThai);
            grpTTVe.Controls.Add(lblGiaVe);
            grpTTVe.Controls.Add(lblGhe);
            grpTTVe.Controls.Add(lblSuKien);
            grpTTVe.Controls.Add(lblID);
            grpTTVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTVe.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTVe.Location = new Point(20, 15);
            grpTTVe.Name = "grpTTVe";
            grpTTVe.Size = new Size(1240, 285);
            grpTTVe.TabIndex = 0;
            grpTTVe.TabStop = false;
            grpTTVe.Text = "Thông tin vé";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(119, 240);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 31);
            cboTrangThai.TabIndex = 20;
            // 
            // cboGhe
            // 
            cboGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGhe.Font = new Font("Segoe UI", 10F);
            cboGhe.FormattingEnabled = true;
            cboGhe.Location = new Point(97, 138);
            cboGhe.Name = "cboGhe";
            cboGhe.Size = new Size(260, 31);
            cboGhe.TabIndex = 19;
            // 
            // cboSuKien
            // 
            cboSuKien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuKien.Font = new Font("Segoe UI", 10F);
            cboSuKien.FormattingEnabled = true;
            cboSuKien.Location = new Point(97, 88);
            cboSuKien.Name = "cboSuKien";
            cboSuKien.Size = new Size(308, 31);
            cboSuKien.TabIndex = 18;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1025, 226);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDoiAnh.OverrideDefault.Border.Rounding = 8F;
            btnDoiAnh.Size = new Size(160, 40);
            btnDoiAnh.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnDoiAnh.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDoiAnh.StateCommon.Border.Rounding = 8F;
            btnDoiAnh.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDoiAnh.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiAnh.TabIndex = 17;
            btnDoiAnh.Values.DropDownArrowColor = Color.Empty;
            btnDoiAnh.Values.Text = "Đổi ảnh";
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(1000, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(185, 190);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 16;
            picHinhAnh.TabStop = false;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.OverrideDefault.Border.Rounding = 8F;
            btnXuat.Size = new Size(150, 40);
            btnXuat.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.StateCommon.Border.Rounding = 8F;
            btnXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.TabIndex = 15;
            btnXuat.Values.DropDownArrowColor = Color.Empty;
            btnXuat.Values.Text = "Xuất";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.OverrideDefault.Border.Rounding = 8F;
            btnNhap.Size = new Size(150, 40);
            btnNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.StateCommon.Border.Rounding = 8F;
            btnNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.TabIndex = 14;
            btnNhap.Values.DropDownArrowColor = Color.Empty;
            btnNhap.Values.Text = "Nhập";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.OverrideDefault.Border.Rounding = 8F;
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.StateCommon.Border.Rounding = 8F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(150, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 12;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.OverrideDefault.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.OverrideDefault.Border.Rounding = 8F;
            btnHuy.Size = new Size(150, 40);
            btnHuy.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.StateCommon.Border.Rounding = 8F;
            btnHuy.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuy.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.TabIndex = 11;
            btnHuy.Values.DropDownArrowColor = Color.Empty;
            btnHuy.Values.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.OverrideDefault.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.OverrideDefault.Border.Rounding = 8F;
            btnLuu.Size = new Size(150, 40);
            btnLuu.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.StateCommon.Border.Rounding = 8F;
            btnLuu.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLuu.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.TabIndex = 10;
            btnLuu.Values.DropDownArrowColor = Color.Empty;
            btnLuu.Values.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.OverrideDefault.Border.Rounding = 8F;
            btnSua.Size = new Size(150, 40);
            btnSua.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.StateCommon.Border.Rounding = 8F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.TabIndex = 9;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.OverrideDefault.Border.Rounding = 8F;
            btnXoa.Size = new Size(150, 40);
            btnXoa.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.StateCommon.Border.Rounding = 8F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.TabIndex = 8;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.OverrideDefault.Border.Rounding = 8F;
            btnThem.Size = new Size(150, 40);
            btnThem.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.StateCommon.Border.Rounding = 8F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.TabIndex = 7;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(97, 193);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(260, 34);
            txtGiaVe.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtGiaVe.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtGiaVe.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtGiaVe.StateCommon.Border.Rounding = 6F;
            txtGiaVe.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtGiaVe.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtGiaVe.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 34);
            txtID.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtID.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtID.StateCommon.Border.Rounding = 6F;
            txtID.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtID.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtID.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.ForeColor = Color.FromArgb(45, 52, 54);
            lblTrangThai.Location = new Point(22, 243);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(91, 23);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblGiaVe
            // 
            lblGiaVe.AutoSize = true;
            lblGiaVe.Font = new Font("Segoe UI", 10F);
            lblGiaVe.ForeColor = Color.FromArgb(45, 52, 54);
            lblGiaVe.Location = new Point(22, 193);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(61, 23);
            lblGiaVe.TabIndex = 3;
            lblGiaVe.Text = "Giá vé:";
            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Font = new Font("Segoe UI", 10F);
            lblGhe.ForeColor = Color.FromArgb(45, 52, 54);
            lblGhe.Location = new Point(22, 138);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(45, 23);
            lblGhe.TabIndex = 2;
            lblGhe.Text = "Ghế:";
            // 
            // lblSuKien
            // 
            lblSuKien.AutoSize = true;
            lblSuKien.Font = new Font("Segoe UI", 10F);
            lblSuKien.ForeColor = Color.FromArgb(45, 52, 54);
            lblSuKien.Location = new Point(22, 88);
            lblSuKien.Name = "lblSuKien";
            lblSuKien.Size = new Size(69, 23);
            lblSuKien.TabIndex = 1;
            lblSuKien.Text = "Sự kiện:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(45, 52, 54);
            lblID.Location = new Point(22, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpVe
            // 
            grpVe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpVe.BackColor = Color.White;
            grpVe.Controls.Add(dgvVe);
            grpVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpVe.ForeColor = Color.FromArgb(45, 62, 80);
            grpVe.Location = new Point(20, 315);
            grpVe.Name = "grpVe";
            grpVe.Size = new Size(1240, 375);
            grpVe.TabIndex = 1;
            grpVe.TabStop = false;
            grpVe.Text = "Danh sách vé";
            // 
            // dgvVe
            // 
            dgvVe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVe.BackgroundColor = Color.White;
            dgvVe.BorderStyle = BorderStyle.None;
            dgvVe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVe.ColumnHeadersHeight = 40;
            dgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVe.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSuKien, colSoGhe, colTenKhuVuc, colTenSan, colGiaVe, colTrangThai, colHinhAnh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 230, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVe.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVe.EnableHeadersVisualStyles = false;
            dgvVe.GridColor = Color.FromArgb(230, 230, 230);
            dgvVe.Location = new Point(10, 30);
            dgvVe.MultiSelect = false;
            dgvVe.Name = "dgvVe";
            dgvVe.RowHeadersVisible = false;
            dgvVe.RowHeadersWidth = 51;
            dgvVe.RowTemplate.Height = 42;
            dgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVe.Size = new Size(1220, 335);
            dgvVe.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 8F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSuKien
            // 
            colTenSuKien.DataPropertyName = "TenSuKien";
            colTenSuKien.FillWeight = 20F;
            colTenSuKien.HeaderText = "Sự Kiện";
            colTenSuKien.MinimumWidth = 6;
            colTenSuKien.Name = "colTenSuKien";
            // 
            // colSoGhe
            // 
            colSoGhe.DataPropertyName = "SoGhe";
            colSoGhe.FillWeight = 10F;
            colSoGhe.HeaderText = "Ghế";
            colSoGhe.MinimumWidth = 6;
            colSoGhe.Name = "colSoGhe";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 14F;
            colTenKhuVuc.HeaderText = "Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 18F;
            colTenSan.HeaderText = "Sân Vận Động";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colGiaVe
            // 
            colGiaVe.DataPropertyName = "GiaVe";
            colGiaVe.FillWeight = 10F;
            colGiaVe.HeaderText = "Giá Vé";
            colGiaVe.MinimumWidth = 6;
            colGiaVe.Name = "colGiaVe";
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 10F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.FillWeight = 10F;
            colHinhAnh.HeaderText = "Hình Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Resizable = DataGridViewTriState.True;
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpVe);
            Controls.Add(grpTTVe);
            Font = new Font("Segoe UI", 9F);
            Name = "frmVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Vé";
            Load += frmVe_Load;
            grpTTVe.ResumeLayout(false);
            grpTTVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTVe;
        private ComboBox cboTrangThai;
        private ComboBox cboGhe;
        private ComboBox cboSuKien;
        private KryptonButton btnDoiAnh;
        private PictureBox picHinhAnh;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnTimKiem;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonTextBox txtGiaVe;
        private KryptonTextBox txtID;
        private Label lblTrangThai;
        private Label lblGiaVe;
        private Label lblGhe;
        private Label lblSuKien;
        private Label lblID;
        private GroupBox grpVe;
        private DataGridView dgvVe;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colGiaVe;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewImageColumn colHinhAnh;
    }
}