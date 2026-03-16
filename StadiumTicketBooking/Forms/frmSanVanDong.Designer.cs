using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmSanVanDong
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
            grpTTSVD = new GroupBox();
            btnDoiAnh = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            txtDiaChi = new TextBox();
            txtTenSan = new TextBox();
            txtID = new TextBox();
            lblDiaChi = new Label();
            lblTenSan = new Label();
            lblID = new Label();
            grpSanVanDong = new GroupBox();
            dgvSanVanDong = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTSVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpSanVanDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).BeginInit();
            SuspendLayout();
            // 
            // grpTTSVD
            // 
            grpTTSVD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTSVD.Controls.Add(btnDoiAnh);
            grpTTSVD.Controls.Add(btnTimKiem);
            grpTTSVD.Controls.Add(btnXuat);
            grpTTSVD.Controls.Add(btnNhap);
            grpTTSVD.Controls.Add(btnThoat);
            grpTTSVD.Controls.Add(btnHuy);
            grpTTSVD.Controls.Add(btnLuu);
            grpTTSVD.Controls.Add(btnSua);
            grpTTSVD.Controls.Add(btnXoa);
            grpTTSVD.Controls.Add(btnThem);
            grpTTSVD.Controls.Add(picHinhAnh);
            grpTTSVD.Controls.Add(txtDiaChi);
            grpTTSVD.Controls.Add(txtTenSan);
            grpTTSVD.Controls.Add(txtID);
            grpTTSVD.Controls.Add(lblDiaChi);
            grpTTSVD.Controls.Add(lblTenSan);
            grpTTSVD.Controls.Add(lblID);
            grpTTSVD.Location = new Point(20, 15);
            grpTTSVD.Name = "grpTTSVD";
            grpTTSVD.Size = new Size(1240, 215);
            grpTTSVD.TabIndex = 0;
            grpTTSVD.TabStop = false;
            grpTTSVD.Text = "Thông tin sân vận động";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.Location = new Point(985, 160);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(180, 38);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 118);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 72);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 7;
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
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(985, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(180, 125);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(130, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(260, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(130, 82);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(260, 27);
            txtTenSan.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(260, 27);
            txtID.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(30, 135);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 14;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenSan
            // 
            lblTenSan.AutoSize = true;
            lblTenSan.Location = new Point(30, 85);
            lblTenSan.Name = "lblTenSan";
            lblTenSan.Size = new Size(59, 20);
            lblTenSan.TabIndex = 15;
            lblTenSan.Text = "Tên sân:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(30, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 16;
            lblID.Text = "ID:";
            // 
            // grpSanVanDong
            // 
            grpSanVanDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSanVanDong.Controls.Add(dgvSanVanDong);
            grpSanVanDong.Location = new Point(20, 245);
            grpSanVanDong.Name = "grpSanVanDong";
            grpSanVanDong.Size = new Size(1240, 445);
            grpSanVanDong.TabIndex = 1;
            grpSanVanDong.TabStop = false;
            grpSanVanDong.Text = "Danh sách sân vận động";
            // 
            // dgvSanVanDong
            // 
            dgvSanVanDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanVanDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanVanDong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSanVanDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanVanDong.ColumnHeadersHeight = 40;
            dgvSanVanDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSanVanDong.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSan, colDiaChi, colHinhAnh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSanVanDong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSanVanDong.Location = new Point(10, 30);
            dgvSanVanDong.MultiSelect = false;
            dgvSanVanDong.Name = "dgvSanVanDong";
            dgvSanVanDong.RowHeadersVisible = false;
            dgvSanVanDong.RowHeadersWidth = 51;
            dgvSanVanDong.RowTemplate.Height = 70;
            dgvSanVanDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanVanDong.Size = new Size(1220, 405);
            dgvSanVanDong.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 15F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 25F;
            colTenSan.HeaderText = "Tên Sân";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 30F;
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.FillWeight = 30F;
            colHinhAnh.HeaderText = "Hình ảnh sân vận động";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanVanDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpSanVanDong);
            Controls.Add(grpTTSVD);
            Font = new Font("Segoe UI", 9F);
            Name = "frmSanVanDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sân Vận Động";
            Load += frmSanVanDong_Load;
            grpTTSVD.ResumeLayout(false);
            grpTTSVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpSanVanDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTSVD;
        private Label lblID;
        private Label lblTenSan;
        private Label lblDiaChi;
        private TextBox txtID;
        private TextBox txtTenSan;
        private TextBox txtDiaChi;
        private PictureBox picHinhAnh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnDoiAnh;
        private GroupBox grpSanVanDong;
        private DataGridView dgvSanVanDong;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewImageColumn colHinhAnh;
    }
}