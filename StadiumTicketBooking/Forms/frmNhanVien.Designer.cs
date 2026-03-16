using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpTTNV = new GroupBox();
            cboVaiTro = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lblVaiTro = new Label();
            lblMatKhau = new Label();
            lblTenDN = new Label();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            txtDienThoai = new TextBox();
            lblDienThoai = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            grpNhanVien = new GroupBox();
            dgvNhanVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpTTNV
            // 
            grpTTNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTNV.Controls.Add(cboVaiTro);
            grpTTNV.Controls.Add(btnXuat);
            grpTTNV.Controls.Add(btnNhap);
            grpTTNV.Controls.Add(btnTimKiem);
            grpTTNV.Controls.Add(btnThoat);
            grpTTNV.Controls.Add(btnHuy);
            grpTTNV.Controls.Add(btnLuu);
            grpTTNV.Controls.Add(btnSua);
            grpTTNV.Controls.Add(btnXoa);
            grpTTNV.Controls.Add(btnThem);
            grpTTNV.Controls.Add(lblVaiTro);
            grpTTNV.Controls.Add(lblMatKhau);
            grpTTNV.Controls.Add(lblTenDN);
            grpTTNV.Controls.Add(txtMatKhau);
            grpTTNV.Controls.Add(txtDangNhap);
            grpTTNV.Controls.Add(btnDoiAnh);
            grpTTNV.Controls.Add(picHinhAnh);
            grpTTNV.Controls.Add(txtDienThoai);
            grpTTNV.Controls.Add(lblDienThoai);
            grpTTNV.Controls.Add(lblHoTen);
            grpTTNV.Controls.Add(txtHoTen);
            grpTTNV.Location = new Point(20, 15);
            grpTTNV.Name = "grpTTNV";
            grpTTNV.Size = new Size(1240, 276);
            grpTTNV.TabIndex = 0;
            grpTTNV.TabStop = false;
            grpTTNV.Text = "Thông tin nhân viên";
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(160, 182);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(230, 28);
            cboVaiTro.TabIndex = 21;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new Point(30, 185);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(56, 20);
            lblVaiTro.TabIndex = 10;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(30, 135);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(74, 20);
            lblMatKhau.TabIndex = 9;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Location = new Point(30, 85);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(110, 20);
            lblTenDN.TabIndex = 8;
            lblTenDN.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(160, 132);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(230, 27);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(160, 82);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(230, 27);
            txtDangNhap.TabIndex = 6;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.Location = new Point(985, 210);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(180, 38);
            btnDoiAnh.TabIndex = 5;
            btnDoiAnh.Text = "Đổi ảnh thẻ";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(985, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(180, 175);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 4;
            picHinhAnh.TabStop = false;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(160, 32);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(230, 27);
            txtDienThoai.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(30, 35);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(79, 20);
            lblDienThoai.TabIndex = 2;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(30, 236);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 226);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(230, 27);
            txtHoTen.TabIndex = 0;
            // 
            // grpNhanVien
            // 
            grpNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNhanVien.Controls.Add(dgvNhanVien);
            grpNhanVien.Location = new Point(20, 303);
            grpNhanVien.Name = "grpNhanVien";
            grpNhanVien.Size = new Size(1240, 405);
            grpNhanVien.TabIndex = 1;
            grpNhanVien.TabStop = false;
            grpNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 40;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colTenDangNhap, colVaiTro, colHinhAnh });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.Location = new Point(10, 30);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 70;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1220, 365);
            dgvNhanVien.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.FillWeight = 22F;
            colHoVaTen.HeaderText = "Họ Và Tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.FillWeight = 18F;
            colDienThoai.HeaderText = "Điện Thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.FillWeight = 20F;
            colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.FillWeight = 15F;
            colVaiTro.HeaderText = "Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHinhAnh.DefaultCellStyle = dataGridViewCellStyle2;
            colHinhAnh.FillWeight = 15F;
            colHinhAnh.HeaderText = "Hình Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Resizable = DataGridViewTriState.True;
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpNhanVien);
            Controls.Add(grpTTNV);
            Font = new Font("Segoe UI", 9F);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += frmNhanVien_Load;
            grpTTNV.ResumeLayout(false);
            grpTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTNV;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private TextBox txtDienThoai;
        private Label lblDienThoai;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblMatKhau;
        private Label lblTenDN;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
        private Label lblVaiTro;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox grpNhanVien;
        private DataGridView dgvNhanVien;
        private ComboBox cboVaiTro;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoVaTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colVaiTro;
        private DataGridViewImageColumn colHinhAnh;
    }
}