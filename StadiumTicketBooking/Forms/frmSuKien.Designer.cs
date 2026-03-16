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
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtGiaCoBan = new TextBox();
            txtTenSuKien = new TextBox();
            txtID = new TextBox();
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
            cboSanVanDong.FormattingEnabled = true;
            cboSanVanDong.Location = new Point(150, 132);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(260, 28);
            cboSanVanDong.TabIndex = 19;
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.Location = new Point(150, 182);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(260, 27);
            dtpThoiGian.TabIndex = 18;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 17;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 10;
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
            // txtGiaCoBan
            // 
            txtGiaCoBan.Location = new Point(150, 232);
            txtGiaCoBan.Name = "txtGiaCoBan";
            txtGiaCoBan.Size = new Size(260, 27);
            txtGiaCoBan.TabIndex = 8;
            // 
            // txtTenSuKien
            // 
            txtTenSuKien.Location = new Point(150, 82);
            txtTenSuKien.Name = "txtTenSuKien";
            txtTenSuKien.Size = new Size(260, 27);
            txtTenSuKien.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 6;
            // 
            // lblGiaCoBan
            // 
            lblGiaCoBan.AutoSize = true;
            lblGiaCoBan.Location = new Point(30, 235);
            lblGiaCoBan.Name = "lblGiaCoBan";
            lblGiaCoBan.Size = new Size(86, 20);
            lblGiaCoBan.TabIndex = 4;
            lblGiaCoBan.Text = "Giá cơ bản:";
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Location = new Point(30, 185);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(74, 20);
            lblThoiGian.TabIndex = 3;
            lblThoiGian.Text = "Thời gian:";
            // 
            // lblTenSuKien
            // 
            lblTenSuKien.AutoSize = true;
            lblTenSuKien.Location = new Point(30, 85);
            lblTenSuKien.Name = "lblTenSuKien";
            lblTenSuKien.Size = new Size(88, 20);
            lblTenSuKien.TabIndex = 2;
            lblTenSuKien.Text = "Tên sự kiện:";
            // 
            // lblSanVanDong
            // 
            lblSanVanDong.AutoSize = true;
            lblSanVanDong.Location = new Point(30, 135);
            lblSanVanDong.Name = "lblSanVanDong";
            lblSanVanDong.Size = new Size(104, 20);
            lblSanVanDong.TabIndex = 1;
            lblSanVanDong.Text = "Sân vận động:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(30, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpSuKien
            // 
            grpSuKien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSuKien.Controls.Add(dgvSuKien);
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
            dgvSuKien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuKien.ColumnHeadersHeight = 40;
            dgvSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSuKien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSuKien, colSanVanDong, colThoiGian, colGiaCoBan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuKien.DefaultCellStyle = dataGridViewCellStyle2;
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
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtGiaCoBan;
        private TextBox txtTenSuKien;
        private TextBox txtID;
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