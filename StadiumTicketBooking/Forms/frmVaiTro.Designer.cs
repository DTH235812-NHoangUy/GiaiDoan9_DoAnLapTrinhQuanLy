using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmVaiTro
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
            grpTTVT = new GroupBox();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtVaiTro = new TextBox();
            txtID = new TextBox();
            lblVaiTro = new Label();
            lblID = new Label();
            groupVaiTro = new GroupBox();
            dgvVaiTro = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            grpTTVT.SuspendLayout();
            groupVaiTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaiTro).BeginInit();
            SuspendLayout();
            // 
            // grpTTVT
            // 
            grpTTVT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTVT.Controls.Add(btnTimKiem);
            grpTTVT.Controls.Add(btnXuat);
            grpTTVT.Controls.Add(btnNhap);
            grpTTVT.Controls.Add(btnThoat);
            grpTTVT.Controls.Add(btnHuy);
            grpTTVT.Controls.Add(btnLuu);
            grpTTVT.Controls.Add(btnSua);
            grpTTVT.Controls.Add(btnXoa);
            grpTTVT.Controls.Add(btnThem);
            grpTTVT.Controls.Add(txtVaiTro);
            grpTTVT.Controls.Add(txtID);
            grpTTVT.Controls.Add(lblVaiTro);
            grpTTVT.Controls.Add(lblID);
            grpTTVT.Location = new Point(20, 15);
            grpTTVT.Name = "grpTTVT";
            grpTTVT.Size = new Size(1240, 180);
            grpTTVT.TabIndex = 0;
            grpTTVT.TabStop = false;
            grpTTVT.Text = "Thông tin vai trò";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1045, 118);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1045, 72);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 40);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1045, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 40);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(875, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(875, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(875, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(705, 118);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(705, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(705, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(130, 88);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(520, 27);
            txtVaiTro.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 38);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(520, 27);
            txtID.TabIndex = 2;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new Point(30, 93);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(56, 20);
            lblVaiTro.TabIndex = 1;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(30, 43);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // groupVaiTro
            // 
            groupVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupVaiTro.Controls.Add(dgvVaiTro);
            groupVaiTro.Location = new Point(20, 210);
            groupVaiTro.Name = "groupVaiTro";
            groupVaiTro.Size = new Size(1240, 480);
            groupVaiTro.TabIndex = 1;
            groupVaiTro.TabStop = false;
            groupVaiTro.Text = "Danh sách vai trò";
            // 
            // dgvVaiTro
            // 
            dgvVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVaiTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaiTro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVaiTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaiTro.ColumnHeadersHeight = 40;
            dgvVaiTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVaiTro.Columns.AddRange(new DataGridViewColumn[] { colID, colVaiTro });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVaiTro.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVaiTro.Location = new Point(10, 30);
            dgvVaiTro.MultiSelect = false;
            dgvVaiTro.Name = "dgvVaiTro";
            dgvVaiTro.RowHeadersVisible = false;
            dgvVaiTro.RowHeadersWidth = 51;
            dgvVaiTro.RowTemplate.Height = 32;
            dgvVaiTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaiTro.Size = new Size(1220, 440);
            dgvVaiTro.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 25F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.FillWeight = 75F;
            colVaiTro.HeaderText = "Tên Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // frmVaiTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(groupVaiTro);
            Controls.Add(grpTTVT);
            Font = new Font("Segoe UI", 9F);
            Name = "frmVaiTro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Vai Trò";
            Load += frmVaiTro_Load;
            grpTTVT.ResumeLayout(false);
            grpTTVT.PerformLayout();
            groupVaiTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVaiTro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTVT;
        private GroupBox groupVaiTro;
        private Label lblVaiTro;
        private Label lblID;
        private DataGridView dgvVaiTro;
        private Button btnTimKiem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtVaiTro;
        private TextBox txtID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVaiTro;
    }
}