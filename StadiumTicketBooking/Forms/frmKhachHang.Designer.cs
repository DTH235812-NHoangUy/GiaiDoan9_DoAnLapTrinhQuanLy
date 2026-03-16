using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmKhachHang
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
            grpTTKhachHang = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtHoVaTen = new TextBox();
            txtID = new TextBox();
            lblDiaChi = new Label();
            lblDienThoai = new Label();
            lblHoVaTen = new Label();
            lblID = new Label();
            grpKhachHang = new GroupBox();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            grpTTKhachHang.SuspendLayout();
            grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grpTTKhachHang
            // 
            grpTTKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTKhachHang.Controls.Add(btnXuat);
            grpTTKhachHang.Controls.Add(btnNhap);
            grpTTKhachHang.Controls.Add(btnTimKiem);
            grpTTKhachHang.Controls.Add(btnThoat);
            grpTTKhachHang.Controls.Add(btnHuy);
            grpTTKhachHang.Controls.Add(btnLuu);
            grpTTKhachHang.Controls.Add(btnSua);
            grpTTKhachHang.Controls.Add(btnXoa);
            grpTTKhachHang.Controls.Add(btnThem);
            grpTTKhachHang.Controls.Add(txtDiaChi);
            grpTTKhachHang.Controls.Add(txtDienThoai);
            grpTTKhachHang.Controls.Add(txtHoVaTen);
            grpTTKhachHang.Controls.Add(txtID);
            grpTTKhachHang.Controls.Add(lblDiaChi);
            grpTTKhachHang.Controls.Add(lblDienThoai);
            grpTTKhachHang.Controls.Add(lblHoVaTen);
            grpTTKhachHang.Controls.Add(lblID);
            grpTTKhachHang.Location = new Point(20, 15);
            grpTTKhachHang.Name = "grpTTKhachHang";
            grpTTKhachHang.Size = new Size(1240, 235);
            grpTTKhachHang.TabIndex = 0;
            grpTTKhachHang.TabStop = false;
            grpTTKhachHang.Text = "Thông tin khách hàng";
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
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 182);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(260, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(150, 132);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(260, 27);
            txtDienThoai.TabIndex = 6;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(150, 82);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(260, 27);
            txtHoVaTen.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 27);
            txtID.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(30, 185);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(30, 135);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(79, 20);
            lblDienThoai.TabIndex = 2;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Location = new Point(30, 85);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(75, 20);
            lblHoVaTen.TabIndex = 1;
            lblHoVaTen.Text = "Họ và tên:";
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
            // grpKhachHang
            // 
            grpKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpKhachHang.Controls.Add(dgvKhachHang);
            grpKhachHang.Location = new Point(20, 265);
            grpKhachHang.Name = "grpKhachHang";
            grpKhachHang.Size = new Size(1240, 425);
            grpKhachHang.TabIndex = 1;
            grpKhachHang.TabStop = false;
            grpKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeight = 40;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Location = new Point(10, 30);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 35;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1220, 385);
            dgvKhachHang.TabIndex = 0;
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
            colHoVaTen.FillWeight = 30F;
            colHoVaTen.HeaderText = "Họ Và Tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.FillWeight = 20F;
            colDienThoai.HeaderText = "Điện Thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 40F;
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpKhachHang);
            Controls.Add(grpTTKhachHang);
            Font = new Font("Segoe UI", 9F);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Hàng";
            Load += frmKhachHang_Load;
            grpTTKhachHang.ResumeLayout(false);
            grpTTKhachHang.PerformLayout();
            grpKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTKhachHang;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private TextBox txtID;
        private Label lblDiaChi;
        private Label lblDienThoai;
        private Label lblHoVaTen;
        private Label lblID;
        private GroupBox grpKhachHang;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoVaTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
    }
}