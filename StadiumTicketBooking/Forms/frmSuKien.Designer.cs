using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmSuKien
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
            grpTTSuKien = new GroupBox();
            cboSanVanDong = new ComboBox();
            dtpThoiGian = new DateTimePicker();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            txtGiaCoBan = new KryptonTextBox();
            txtTenSuKien = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblGiaCoBan = new Label();
            lblThoiGian = new Label();
            lblTenSuKien = new Label();
            lblSanVanDong = new Label();
            lblID = new Label();
            grpSuKien = new GroupBox();
            dgvSuKien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colSanVanDong = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            colGiaCoBan = new DataGridViewTextBoxColumn();
            grpTTSuKien.SuspendLayout();
            grpSuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuKien).BeginInit();
            SuspendLayout();
            // 
            // grpTTSuKien
            // 
            grpTTSuKien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTSuKien.BackColor = Color.White;
            grpTTSuKien.Controls.Add(cboSanVanDong);
            grpTTSuKien.Controls.Add(dtpThoiGian);
            grpTTSuKien.Controls.Add(btnXuat);
            grpTTSuKien.Controls.Add(btnNhap);
            grpTTSuKien.Controls.Add(btnTimKiem);
            grpTTSuKien.Controls.Add(btnThoat);
            grpTTSuKien.Controls.Add(btnHuy);
            grpTTSuKien.Controls.Add(btnLuu);
            grpTTSuKien.Controls.Add(btnSua);
            grpTTSuKien.Controls.Add(btnXoa);
            grpTTSuKien.Controls.Add(btnThem);
            grpTTSuKien.Controls.Add(txtGiaCoBan);
            grpTTSuKien.Controls.Add(txtTenSuKien);
            grpTTSuKien.Controls.Add(txtID);
            grpTTSuKien.Controls.Add(lblGiaCoBan);
            grpTTSuKien.Controls.Add(lblThoiGian);
            grpTTSuKien.Controls.Add(lblTenSuKien);
            grpTTSuKien.Controls.Add(lblSanVanDong);
            grpTTSuKien.Controls.Add(lblID);
            grpTTSuKien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTSuKien.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTSuKien.Location = new Point(20, 15);
            grpTTSuKien.Name = "grpTTSuKien";
            grpTTSuKien.Size = new Size(1240, 275);
            grpTTSuKien.TabIndex = 0;
            grpTTSuKien.TabStop = false;
            grpTTSuKien.Text = "Thông tin sự kiện";
            // 
            // cboSanVanDong
            // 
            cboSanVanDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanVanDong.Font = new Font("Segoe UI", 10F);
            cboSanVanDong.FormattingEnabled = true;
            cboSanVanDong.Location = new Point(150, 132);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(260, 31);
            cboSanVanDong.TabIndex = 19;
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiGian.Font = new Font("Segoe UI", 10F);
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.Location = new Point(150, 182);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(260, 30);
            dtpThoiGian.TabIndex = 18;
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
            btnXuat.TabIndex = 17;
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
            btnNhap.TabIndex = 16;
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
            btnTimKiem.TabIndex = 15;
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
            btnThoat.TabIndex = 14;
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
            btnHuy.TabIndex = 13;
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
            btnLuu.TabIndex = 12;
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
            btnSua.TabIndex = 11;
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
            btnXoa.TabIndex = 10;
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
            btnThem.TabIndex = 9;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaCoBan
            // 
            txtGiaCoBan.Location = new Point(150, 232);
            txtGiaCoBan.Name = "txtGiaCoBan";
            txtGiaCoBan.Size = new Size(260, 34);
            txtGiaCoBan.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtGiaCoBan.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtGiaCoBan.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtGiaCoBan.StateCommon.Border.Rounding = 6F;
            txtGiaCoBan.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtGiaCoBan.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtGiaCoBan.TabIndex = 8;
            // 
            // txtTenSuKien
            // 
            txtTenSuKien.Location = new Point(150, 82);
            txtTenSuKien.Name = "txtTenSuKien";
            txtTenSuKien.Size = new Size(260, 34);
            txtTenSuKien.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtTenSuKien.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtTenSuKien.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtTenSuKien.StateCommon.Border.Rounding = 6F;
            txtTenSuKien.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtTenSuKien.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtTenSuKien.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
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
            txtID.TabIndex = 6;
            // 
            // lblGiaCoBan
            // 
            lblGiaCoBan.AutoSize = true;
            lblGiaCoBan.Font = new Font("Segoe UI", 10F);
            lblGiaCoBan.ForeColor = Color.FromArgb(45, 52, 54);
            lblGiaCoBan.Location = new Point(30, 238);
            lblGiaCoBan.Name = "lblGiaCoBan";
            lblGiaCoBan.Size = new Size(96, 23);
            lblGiaCoBan.TabIndex = 4;
            lblGiaCoBan.Text = "Giá cơ bản:";
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Font = new Font("Segoe UI", 10F);
            lblThoiGian.ForeColor = Color.FromArgb(45, 52, 54);
            lblThoiGian.Location = new Point(30, 188);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(85, 23);
            lblThoiGian.TabIndex = 3;
            lblThoiGian.Text = "Thời gian:";
            // 
            // lblTenSuKien
            // 
            lblTenSuKien.AutoSize = true;
            lblTenSuKien.Font = new Font("Segoe UI", 10F);
            lblTenSuKien.ForeColor = Color.FromArgb(45, 52, 54);
            lblTenSuKien.Location = new Point(30, 88);
            lblTenSuKien.Name = "lblTenSuKien";
            lblTenSuKien.Size = new Size(98, 23);
            lblTenSuKien.TabIndex = 2;
            lblTenSuKien.Text = "Tên sự kiện:";
            // 
            // lblSanVanDong
            // 
            lblSanVanDong.AutoSize = true;
            lblSanVanDong.Font = new Font("Segoe UI", 10F);
            lblSanVanDong.ForeColor = Color.FromArgb(45, 52, 54);
            lblSanVanDong.Location = new Point(30, 138);
            lblSanVanDong.Name = "lblSanVanDong";
            lblSanVanDong.Size = new Size(119, 23);
            lblSanVanDong.TabIndex = 1;
            lblSanVanDong.Text = "Sân vận động:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(45, 52, 54);
            lblID.Location = new Point(30, 38);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpSuKien
            // 
            grpSuKien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSuKien.BackColor = Color.White;
            grpSuKien.Controls.Add(dgvSuKien);
            grpSuKien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSuKien.ForeColor = Color.FromArgb(45, 62, 80);
            grpSuKien.Location = new Point(20, 305);
            grpSuKien.Name = "grpSuKien";
            grpSuKien.Size = new Size(1240, 385);
            grpSuKien.TabIndex = 1;
            grpSuKien.TabStop = false;
            grpSuKien.Text = "Danh sách sự kiện";
            // 
            // dgvSuKien
            // 
            dgvSuKien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuKien.BackgroundColor = Color.White;
            dgvSuKien.BorderStyle = BorderStyle.None;
            dgvSuKien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuKien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvSuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuKien.ColumnHeadersHeight = 40;
            dgvSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSuKien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSuKien, colSanVanDong, colThoiGian, colGiaCoBan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 230, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuKien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSuKien.EnableHeadersVisualStyles = false;
            dgvSuKien.GridColor = Color.FromArgb(230, 230, 230);
            dgvSuKien.Location = new Point(10, 30);
            dgvSuKien.MultiSelect = false;
            dgvSuKien.Name = "dgvSuKien";
            dgvSuKien.RowHeadersVisible = false;
            dgvSuKien.RowHeadersWidth = 51;
            dgvSuKien.RowTemplate.Height = 35;
            dgvSuKien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuKien.Size = new Size(1220, 345);
            dgvSuKien.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSuKien
            // 
            colTenSuKien.DataPropertyName = "TenSuKien";
            colTenSuKien.FillWeight = 30F;
            colTenSuKien.HeaderText = "Tên Sự Kiện";
            colTenSuKien.MinimumWidth = 6;
            colTenSuKien.Name = "colTenSuKien";
            // 
            // colSanVanDong
            // 
            colSanVanDong.DataPropertyName = "TenSan";
            colSanVanDong.FillWeight = 25F;
            colSanVanDong.HeaderText = "Sân Vận Động";
            colSanVanDong.MinimumWidth = 6;
            colSanVanDong.Name = "colSanVanDong";
            // 
            // colThoiGian
            // 
            colThoiGian.DataPropertyName = "ThoiGian";
            colThoiGian.FillWeight = 20F;
            colThoiGian.HeaderText = "Thời Gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            // 
            // colGiaCoBan
            // 
            colGiaCoBan.DataPropertyName = "GiaCoBan";
            colGiaCoBan.FillWeight = 15F;
            colGiaCoBan.HeaderText = "Giá Cơ Bản";
            colGiaCoBan.MinimumWidth = 6;
            colGiaCoBan.Name = "colGiaCoBan";
            // 
            // frmSuKien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpSuKien);
            Controls.Add(grpTTSuKien);
            Font = new Font("Segoe UI", 9F);
            Name = "frmSuKien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sự Kiện";
            Load += frmSuKien_Load;
            grpTTSuKien.ResumeLayout(false);
            grpTTSuKien.PerformLayout();
            grpSuKien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuKien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTSuKien;
        private ComboBox cboSanVanDong;
        private DateTimePicker dtpThoiGian;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnTimKiem;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonTextBox txtGiaCoBan;
        private KryptonTextBox txtTenSuKien;
        private KryptonTextBox txtID;
        private Label lblGiaCoBan;
        private Label lblThoiGian;
        private Label lblTenSuKien;
        private Label lblSanVanDong;
        private Label lblID;
        private GroupBox grpSuKien;
        private DataGridView dgvSuKien;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colSanVanDong;
        private DataGridViewTextBoxColumn colThoiGian;
        private DataGridViewTextBoxColumn colGiaCoBan;
    }
}