using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmDatVe
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            grpThongTinDatVe = new GroupBox();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            cboSuKien = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            txtTongTien = new TextBox();
            txtGhiChu = new TextBox();
            lblNhanVien = new Label();
            lblKhachHang = new Label();
            lblSuKien = new Label();
            lblNgayLap = new Label();
            lblTongTien = new Label();
            lblGhiChu = new Label();
            btnThanhToan = new Button();
            btnHuyDon = new Button();
            btnThoat = new Button();
            grpVeTrong = new GroupBox();
            dgvVeTrong = new DataGridView();
            colVeID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colGiaVe = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            btnChonVe = new Button();
            grpVeDaChon = new GroupBox();
            dgvVeDaChon = new DataGridView();
            colVeIDDaChon = new DataGridViewTextBoxColumn();
            colTenSuKienDaChon = new DataGridViewTextBoxColumn();
            colSoGheDaChon = new DataGridViewTextBoxColumn();
            colTenKhuVucDaChon = new DataGridViewTextBoxColumn();
            colGiaVeDaChon = new DataGridViewTextBoxColumn();
            btnBoVe = new Button();
            grpThongTinDatVe.SuspendLayout();
            grpVeTrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeTrong).BeginInit();
            grpVeDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeDaChon).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinDatVe
            // 
            grpThongTinDatVe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinDatVe.Controls.Add(cboNhanVien);
            grpThongTinDatVe.Controls.Add(cboKhachHang);
            grpThongTinDatVe.Controls.Add(cboSuKien);
            grpThongTinDatVe.Controls.Add(dtpNgayLap);
            grpThongTinDatVe.Controls.Add(txtTongTien);
            grpThongTinDatVe.Controls.Add(txtGhiChu);
            grpThongTinDatVe.Controls.Add(lblNhanVien);
            grpThongTinDatVe.Controls.Add(lblKhachHang);
            grpThongTinDatVe.Controls.Add(lblSuKien);
            grpThongTinDatVe.Controls.Add(lblNgayLap);
            grpThongTinDatVe.Controls.Add(lblTongTien);
            grpThongTinDatVe.Controls.Add(lblGhiChu);
            grpThongTinDatVe.Controls.Add(btnThanhToan);
            grpThongTinDatVe.Controls.Add(btnHuyDon);
            grpThongTinDatVe.Controls.Add(btnThoat);
            grpThongTinDatVe.Location = new Point(20, 15);
            grpThongTinDatVe.Name = "grpThongTinDatVe";
            grpThongTinDatVe.Size = new Size(1240, 220);
            grpThongTinDatVe.TabIndex = 0;
            grpThongTinDatVe.TabStop = false;
            grpThongTinDatVe.Text = "Thông tin đặt vé";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(170, 31);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(300, 28);
            cboNhanVien.TabIndex = 0;
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(170, 78);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(300, 28);
            cboKhachHang.TabIndex = 1;
            // 
            // cboSuKien
            // 
            cboSuKien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuKien.FormattingEnabled = true;
            cboSuKien.Location = new Point(170, 125);
            cboSuKien.Name = "cboSuKien";
            cboSuKien.Size = new Size(300, 28);
            cboSuKien.TabIndex = 2;
            cboSuKien.SelectedIndexChanged += cboSuKien_SelectedIndexChanged;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(650, 31);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(220, 27);
            dtpNgayLap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(650, 78);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(220, 27);
            txtTongTien.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(650, 125);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(220, 27);
            txtGhiChu.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(30, 34);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(78, 20);
            lblNhanVien.TabIndex = 100;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(30, 81);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(89, 20);
            lblKhachHang.TabIndex = 101;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // lblSuKien
            // 
            lblSuKien.AutoSize = true;
            lblSuKien.Location = new Point(30, 128);
            lblSuKien.Name = "lblSuKien";
            lblSuKien.Size = new Size(60, 20);
            lblSuKien.TabIndex = 102;
            lblSuKien.Text = "Sự kiện:";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(530, 34);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(72, 20);
            lblNgayLap.TabIndex = 103;
            lblNgayLap.Text = "Ngày lập:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(530, 81);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(75, 20);
            lblTongTien.TabIndex = 104;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(530, 128);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(61, 20);
            lblGhiChu.TabIndex = 105;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(930, 28);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(130, 40);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuyDon
            // 
            btnHuyDon.Location = new Point(1080, 28);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(130, 40);
            btnHuyDon.TabIndex = 7;
            btnHuyDon.Text = "Hủy đơn";
            btnHuyDon.UseVisualStyleBackColor = true;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1005, 82);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 40);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grpVeTrong
            // 
            grpVeTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpVeTrong.Controls.Add(dgvVeTrong);
            grpVeTrong.Controls.Add(btnChonVe);
            grpVeTrong.Location = new Point(5, 250);
            grpVeTrong.Name = "grpVeTrong";
            grpVeTrong.Size = new Size(639, 440);
            grpVeTrong.TabIndex = 1;
            grpVeTrong.TabStop = false;
            grpVeTrong.Text = "Danh sách vé còn trống";
            // 
            // dgvVeTrong
            // 
            dgvVeTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVeTrong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvVeTrong.ColumnHeadersHeight = 35;
            dgvVeTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVeTrong.Columns.AddRange(new DataGridViewColumn[] { colVeID, colTenSuKien, colSoGhe, colTenKhuVuc, colTenSan, colGiaVe, colTrangThai });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvVeTrong.DefaultCellStyle = dataGridViewCellStyle6;
            dgvVeTrong.Location = new Point(20, 30);
            dgvVeTrong.MultiSelect = false;
            dgvVeTrong.Name = "dgvVeTrong";
            dgvVeTrong.RowHeadersVisible = false;
            dgvVeTrong.RowHeadersWidth = 51;
            dgvVeTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeTrong.Size = new Size(609, 354);
            dgvVeTrong.TabIndex = 0;
            dgvVeTrong.DoubleClick += btnChonVe_Click;
            // 
            // colVeID
            // 
            colVeID.DataPropertyName = "ID";
            colVeID.FillWeight = 8F;
            colVeID.HeaderText = "ID";
            colVeID.MinimumWidth = 6;
            colVeID.Name = "colVeID";
            // 
            // colTenSuKien
            // 
            colTenSuKien.DataPropertyName = "TenSuKien";
            colTenSuKien.FillWeight = 25F;
            colTenSuKien.HeaderText = "Sự Kiện";
            colTenSuKien.MinimumWidth = 6;
            colTenSuKien.Name = "colTenSuKien";
            // 
            // colSoGhe
            // 
            colSoGhe.DataPropertyName = "SoGhe";
            colSoGhe.FillWeight = 12F;
            colSoGhe.HeaderText = "Ghế";
            colSoGhe.MinimumWidth = 6;
            colSoGhe.Name = "colSoGhe";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 18F;
            colTenKhuVuc.HeaderText = "Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 18F;
            colTenSan.HeaderText = "Sân";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colGiaVe
            // 
            colGiaVe.DataPropertyName = "GiaVe";
            colGiaVe.FillWeight = 12F;
            colGiaVe.HeaderText = "Giá Vé";
            colGiaVe.MinimumWidth = 6;
            colGiaVe.Name = "colGiaVe";
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 15F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // btnChonVe
            // 
            btnChonVe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChonVe.Location = new Point(479, 390);
            btnChonVe.Name = "btnChonVe";
            btnChonVe.Size = new Size(150, 40);
            btnChonVe.TabIndex = 1;
            btnChonVe.Text = "Chọn vé";
            btnChonVe.UseVisualStyleBackColor = true;
            btnChonVe.Click += btnChonVe_Click;
            // 
            // grpVeDaChon
            // 
            grpVeDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpVeDaChon.Controls.Add(dgvVeDaChon);
            grpVeDaChon.Controls.Add(btnBoVe);
            grpVeDaChon.Location = new Point(650, 250);
            grpVeDaChon.Name = "grpVeDaChon";
            grpVeDaChon.Size = new Size(610, 440);
            grpVeDaChon.TabIndex = 2;
            grpVeDaChon.TabStop = false;
            grpVeDaChon.Text = "Danh sách vé đã chọn";
            // 
            // dgvVeDaChon
            // 
            dgvVeDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVeDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvVeDaChon.ColumnHeadersHeight = 35;
            dgvVeDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVeDaChon.Columns.AddRange(new DataGridViewColumn[] { colVeIDDaChon, colTenSuKienDaChon, colSoGheDaChon, colTenKhuVucDaChon, colGiaVeDaChon });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvVeDaChon.DefaultCellStyle = dataGridViewCellStyle8;
            dgvVeDaChon.Location = new Point(10, 30);
            dgvVeDaChon.MultiSelect = false;
            dgvVeDaChon.Name = "dgvVeDaChon";
            dgvVeDaChon.RowHeadersVisible = false;
            dgvVeDaChon.RowHeadersWidth = 51;
            dgvVeDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeDaChon.Size = new Size(590, 350);
            dgvVeDaChon.TabIndex = 0;
            // 
            // colVeIDDaChon
            // 
            colVeIDDaChon.DataPropertyName = "VeID";
            colVeIDDaChon.FillWeight = 10F;
            colVeIDDaChon.HeaderText = "ID";
            colVeIDDaChon.MinimumWidth = 6;
            colVeIDDaChon.Name = "colVeIDDaChon";
            // 
            // colTenSuKienDaChon
            // 
            colTenSuKienDaChon.DataPropertyName = "TenSuKien";
            colTenSuKienDaChon.FillWeight = 30F;
            colTenSuKienDaChon.HeaderText = "Sự Kiện";
            colTenSuKienDaChon.MinimumWidth = 6;
            colTenSuKienDaChon.Name = "colTenSuKienDaChon";
            // 
            // colSoGheDaChon
            // 
            colSoGheDaChon.DataPropertyName = "SoGhe";
            colSoGheDaChon.FillWeight = 15F;
            colSoGheDaChon.HeaderText = "Ghế";
            colSoGheDaChon.MinimumWidth = 6;
            colSoGheDaChon.Name = "colSoGheDaChon";
            // 
            // colTenKhuVucDaChon
            // 
            colTenKhuVucDaChon.DataPropertyName = "TenKhuVuc";
            colTenKhuVucDaChon.FillWeight = 20F;
            colTenKhuVucDaChon.HeaderText = "Khu Vực";
            colTenKhuVucDaChon.MinimumWidth = 6;
            colTenKhuVucDaChon.Name = "colTenKhuVucDaChon";
            // 
            // colGiaVeDaChon
            // 
            colGiaVeDaChon.DataPropertyName = "GiaVe";
            colGiaVeDaChon.FillWeight = 15F;
            colGiaVeDaChon.HeaderText = "Giá Vé";
            colGiaVeDaChon.MinimumWidth = 6;
            colGiaVeDaChon.Name = "colGiaVeDaChon";
            // 
            // btnBoVe
            // 
            btnBoVe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoVe.Location = new Point(450, 390);
            btnBoVe.Name = "btnBoVe";
            btnBoVe.Size = new Size(150, 40);
            btnBoVe.TabIndex = 1;
            btnBoVe.Text = "Bỏ vé";
            btnBoVe.UseVisualStyleBackColor = true;
            btnBoVe.Click += btnBoVe_Click;
            // 
            // frmDatVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(grpVeDaChon);
            Controls.Add(grpVeTrong);
            Controls.Add(grpThongTinDatVe);
            Font = new Font("Segoe UI", 9F);
            Name = "frmDatVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Vé";
            Load += frmDatVe_Load;
            grpThongTinDatVe.ResumeLayout(false);
            grpThongTinDatVe.PerformLayout();
            grpVeTrong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeTrong).EndInit();
            grpVeDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeDaChon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinDatVe;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private ComboBox cboSuKien;
        private DateTimePicker dtpNgayLap;
        private TextBox txtTongTien;
        private TextBox txtGhiChu;
        private Label lblNhanVien;
        private Label lblKhachHang;
        private Label lblSuKien;
        private Label lblNgayLap;
        private Label lblTongTien;
        private Label lblGhiChu;
        private Button btnThanhToan;
        private Button btnHuyDon;
        private Button btnThoat;

        private GroupBox grpVeTrong;
        private DataGridView dgvVeTrong;
        private Button btnChonVe;

        private GroupBox grpVeDaChon;
        private DataGridView dgvVeDaChon;
        private Button btnBoVe;

        private DataGridViewTextBoxColumn colVeID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colGiaVe;
        private DataGridViewTextBoxColumn colTrangThai;

        private DataGridViewTextBoxColumn colVeIDDaChon;
        private DataGridViewTextBoxColumn colTenSuKienDaChon;
        private DataGridViewTextBoxColumn colSoGheDaChon;
        private DataGridViewTextBoxColumn colTenKhuVucDaChon;
        private DataGridViewTextBoxColumn colGiaVeDaChon;
    }
}