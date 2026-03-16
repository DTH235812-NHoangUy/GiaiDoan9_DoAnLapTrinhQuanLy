using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmGhe
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
            grpTTGhe = new GroupBox();
            cboKhuVuc = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSoGhe = new TextBox();
            txtID = new TextBox();
            lblSoGhe = new Label();
            lblKhuVuc = new Label();
            lblID = new Label();
            grpGhe = new GroupBox();
            dgvGhe = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            grpTTGhe.SuspendLayout();
            grpGhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGhe).BeginInit();
            SuspendLayout();
            // 
            // grpTTGhe
            // 
            grpTTGhe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTGhe.Controls.Add(cboKhuVuc);
            grpTTGhe.Controls.Add(btnXuat);
            grpTTGhe.Controls.Add(btnNhap);
            grpTTGhe.Controls.Add(btnTimKiem);
            grpTTGhe.Controls.Add(btnThoat);
            grpTTGhe.Controls.Add(btnHuy);
            grpTTGhe.Controls.Add(btnLuu);
            grpTTGhe.Controls.Add(btnSua);
            grpTTGhe.Controls.Add(btnXoa);
            grpTTGhe.Controls.Add(btnThem);
            grpTTGhe.Controls.Add(txtSoGhe);
            grpTTGhe.Controls.Add(txtID);
            grpTTGhe.Controls.Add(lblSoGhe);
            grpTTGhe.Controls.Add(lblKhuVuc);
            grpTTGhe.Controls.Add(lblID);
            grpTTGhe.Location = new Point(20, 15);
            grpTTGhe.Name = "grpTTGhe";
            grpTTGhe.Size = new Size(1240, 210);
            grpTTGhe.TabIndex = 0;
            grpTTGhe.TabStop = false;
            grpTTGhe.Text = "Thông tin ghế";
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(150, 132);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(260, 28);
            cboKhuVuc.TabIndex = 15;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoGhe
            // 
            txtSoGhe.Location = new Point(150, 82);
            txtSoGhe.Name = "txtSoGhe";
            txtSoGhe.Size = new Size(260, 27);
            txtSoGhe.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 4;
            // 
            // lblSoGhe
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Location = new Point(30, 85);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(58, 20);
            lblSoGhe.TabIndex = 2;
            lblSoGhe.Text = "Số ghế:";
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.Location = new Point(30, 135);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(64, 20);
            lblKhuVuc.TabIndex = 1;
            lblKhuVuc.Text = "Khu vực:";
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
            // grpGhe
            // 
            grpGhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpGhe.Controls.Add(dgvGhe);
            grpGhe.Location = new Point(20, 240);
            grpGhe.Name = "grpGhe";
            grpGhe.Size = new Size(1240, 450);
            grpGhe.TabIndex = 1;
            grpGhe.TabStop = false;
            grpGhe.Text = "Danh sách ghế";
            // 
            // dgvGhe
            // 
            dgvGhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGhe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGhe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvGhe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGhe.ColumnHeadersHeight = 35;
            dgvGhe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGhe.Columns.AddRange(new DataGridViewColumn[] { colID, colSoGhe, colTenKhuVuc, colTenSan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGhe.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGhe.Location = new Point(10, 30);
            dgvGhe.MultiSelect = false;
            dgvGhe.Name = "dgvGhe";
            dgvGhe.RowHeadersVisible = false;
            dgvGhe.RowHeadersWidth = 51;
            dgvGhe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGhe.Size = new Size(1220, 410);
            dgvGhe.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colSoGhe
            // 
            colSoGhe.DataPropertyName = "SoGhe";
            colSoGhe.FillWeight = 20F;
            colSoGhe.HeaderText = "Số Ghế";
            colSoGhe.MinimumWidth = 6;
            colSoGhe.Name = "colSoGhe";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 30F;
            colTenKhuVuc.HeaderText = "Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 40F;
            colTenSan.HeaderText = "Sân Vận Động";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // frmGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpGhe);
            Controls.Add(grpTTGhe);
            Font = new Font("Segoe UI", 9F);
            Name = "frmGhe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Ghế";
            Load += frmGhe_Load;
            grpTTGhe.ResumeLayout(false);
            grpTTGhe.PerformLayout();
            grpGhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGhe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTGhe;
        private ComboBox cboKhuVuc;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSoGhe;
        private TextBox txtID;
        private Label lblSoGhe;
        private Label lblKhuVuc;
        private Label lblID;
        private GroupBox grpGhe;
        private DataGridView dgvGhe;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
    }
}