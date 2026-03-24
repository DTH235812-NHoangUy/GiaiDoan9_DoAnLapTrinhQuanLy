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
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtGiaVe = new TextBox();
            txtID = new TextBox();
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
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(119, 240);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 28);
            cboTrangThai.TabIndex = 20;
            // 
            // cboGhe
            // 
            cboGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGhe.FormattingEnabled = true;
            cboGhe.Location = new Point(97, 138);
            cboGhe.Name = "cboGhe";
            cboGhe.Size = new Size(260, 28);
            cboGhe.TabIndex = 19;
            // 
            // cboSuKien
            // 
            cboSuKien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuKien.FormattingEnabled = true;
            cboSuKien.Location = new Point(97, 88);
            cboSuKien.Name = "cboSuKien";
            cboSuKien.Size = new Size(308, 28);
            cboSuKien.TabIndex = 18;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1025, 226);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(160, 40);
            btnDoiAnh.TabIndex = 17;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
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
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 15;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(97, 193);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(260, 27);
            txtGiaVe.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(22, 243);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(77, 20);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblGiaVe
            // 
            lblGiaVe.AutoSize = true;
            lblGiaVe.Location = new Point(22, 193);
            lblGiaVe.Name = "lblGiaVe";
            lblGiaVe.Size = new Size(52, 20);
            lblGiaVe.TabIndex = 3;
            lblGiaVe.Text = "Giá vé:";
            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Location = new Point(22, 138);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(38, 20);
            lblGhe.TabIndex = 2;
            lblGhe.Text = "Ghế:";
            // 
            // lblSuKien
            // 
            lblSuKien.AutoSize = true;
            lblSuKien.Location = new Point(22, 88);
            lblSuKien.Name = "lblSuKien";
            lblSuKien.Size = new Size(58, 20);
            lblSuKien.TabIndex = 1;
            lblSuKien.Text = "Sự kiện:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(22, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpVe
            // 
            grpVe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpVe.Controls.Add(dgvVe);
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
            dgvVe.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvVe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVe.GridColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVe.ColumnHeadersHeight = 40;
            dgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVe.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSuKien, colSoGhe, colTenKhuVuc, colTenSan, colGiaVe, colTrangThai, colHinhAnh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11F, FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVe.DefaultCellStyle = dataGridViewCellStyle2;
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
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtGiaVe;
        private TextBox txtID;
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