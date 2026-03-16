using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmKhuVuc
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
            grpTTKhuVuc = new GroupBox();
            cboSanVanDong = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtHeSoGia = new TextBox();
            txtTenKhuVuc = new TextBox();
            txtID = new TextBox();
            lblHeSoGia = new Label();
            lblTenKhuVuc = new Label();
            lblSanVanDong = new Label();
            lblID = new Label();
            grpKhuVuc = new GroupBox();
            dgvKhuVuc = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colHeSoGia = new DataGridViewTextBoxColumn();
            grpTTKhuVuc.SuspendLayout();
            grpKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).BeginInit();
            SuspendLayout();
            // 
            // grpTTKhuVuc
            // 
            grpTTKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTKhuVuc.Controls.Add(cboSanVanDong);
            grpTTKhuVuc.Controls.Add(btnXuat);
            grpTTKhuVuc.Controls.Add(btnNhap);
            grpTTKhuVuc.Controls.Add(btnTimKiem);
            grpTTKhuVuc.Controls.Add(btnThoat);
            grpTTKhuVuc.Controls.Add(btnHuy);
            grpTTKhuVuc.Controls.Add(btnLuu);
            grpTTKhuVuc.Controls.Add(btnSua);
            grpTTKhuVuc.Controls.Add(btnXoa);
            grpTTKhuVuc.Controls.Add(btnThem);
            grpTTKhuVuc.Controls.Add(txtHeSoGia);
            grpTTKhuVuc.Controls.Add(txtTenKhuVuc);
            grpTTKhuVuc.Controls.Add(txtID);
            grpTTKhuVuc.Controls.Add(lblHeSoGia);
            grpTTKhuVuc.Controls.Add(lblTenKhuVuc);
            grpTTKhuVuc.Controls.Add(lblSanVanDong);
            grpTTKhuVuc.Controls.Add(lblID);
            grpTTKhuVuc.Location = new Point(20, 15);
            grpTTKhuVuc.Name = "grpTTKhuVuc";
            grpTTKhuVuc.Size = new Size(1240, 235);
            grpTTKhuVuc.TabIndex = 0;
            grpTTKhuVuc.TabStop = false;
            grpTTKhuVuc.Text = "Thông tin khu vực";
            // 
            // cboSanVanDong
            // 
            cboSanVanDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanVanDong.FormattingEnabled = true;
            cboSanVanDong.Location = new Point(150, 132);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(260, 28);
            cboSanVanDong.TabIndex = 17;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 15;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHeSoGia
            // 
            txtHeSoGia.Location = new Point(150, 182);
            txtHeSoGia.Name = "txtHeSoGia";
            txtHeSoGia.Size = new Size(260, 27);
            txtHeSoGia.TabIndex = 7;
            // 
            // txtTenKhuVuc
            // 
            txtTenKhuVuc.Location = new Point(150, 82);
            txtTenKhuVuc.Name = "txtTenKhuVuc";
            txtTenKhuVuc.Size = new Size(260, 27);
            txtTenKhuVuc.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 5;
            // 
            // lblHeSoGia
            // 
            lblHeSoGia.AutoSize = true;
            lblHeSoGia.Location = new Point(30, 185);
            lblHeSoGia.Name = "lblHeSoGia";
            lblHeSoGia.Size = new Size(74, 20);
            lblHeSoGia.TabIndex = 3;
            lblHeSoGia.Text = "Hệ số giá:";
            // 
            // lblTenKhuVuc
            // 
            lblTenKhuVuc.AutoSize = true;
            lblTenKhuVuc.Location = new Point(30, 85);
            lblTenKhuVuc.Name = "lblTenKhuVuc";
            lblTenKhuVuc.Size = new Size(90, 20);
            lblTenKhuVuc.TabIndex = 2;
            lblTenKhuVuc.Text = "Tên khu vực:";
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
            // grpKhuVuc
            // 
            grpKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpKhuVuc.Controls.Add(dgvKhuVuc);
            grpKhuVuc.Location = new Point(20, 265);
            grpKhuVuc.Name = "grpKhuVuc";
            grpKhuVuc.Size = new Size(1240, 425);
            grpKhuVuc.TabIndex = 1;
            grpKhuVuc.TabStop = false;
            grpKhuVuc.Text = "Danh sách khu vực";
            // 
            // dgvKhuVuc
            // 
            dgvKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuVuc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhuVuc.ColumnHeadersHeight = 40;
            dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhuVuc.Columns.AddRange(new DataGridViewColumn[] { colID, colTenKhuVuc, colTenSan, colHeSoGia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhuVuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhuVuc.Location = new Point(10, 30);
            dgvKhuVuc.MultiSelect = false;
            dgvKhuVuc.Name = "dgvKhuVuc";
            dgvKhuVuc.RowHeadersVisible = false;
            dgvKhuVuc.RowHeadersWidth = 51;
            dgvKhuVuc.RowTemplate.Height = 35;
            dgvKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuVuc.Size = new Size(1220, 385);
            dgvKhuVuc.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 35F;
            colTenKhuVuc.HeaderText = "Tên Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 35F;
            colTenSan.HeaderText = "Sân Vận Động";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colHeSoGia
            // 
            colHeSoGia.DataPropertyName = "HeSoGia";
            colHeSoGia.FillWeight = 20F;
            colHeSoGia.HeaderText = "Hệ Số Giá";
            colHeSoGia.MinimumWidth = 6;
            colHeSoGia.Name = "colHeSoGia";
            // 
            // frmKhuVuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpKhuVuc);
            Controls.Add(grpTTKhuVuc);
            Font = new Font("Segoe UI", 9F);
            Name = "frmKhuVuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khu Vực";
            Load += frmKhuVuc_Load;
            grpTTKhuVuc.ResumeLayout(false);
            grpTTKhuVuc.PerformLayout();
            grpKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTKhuVuc;
        private ComboBox cboSanVanDong;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtHeSoGia;
        private TextBox txtTenKhuVuc;
        private TextBox txtID;
        private Label lblHeSoGia;
        private Label lblTenKhuVuc;
        private Label lblSanVanDong;
        private Label lblID;
        private GroupBox grpKhuVuc;
        private DataGridView dgvKhuVuc;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colHeSoGia;
    }
}