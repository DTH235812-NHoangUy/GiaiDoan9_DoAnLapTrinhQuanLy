using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private string vaiTro = "";
        private bool dangTaiDuLieu = false;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        public frmKhachHang(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro ?? "";
        }

        private bool LaAdmin()
        {
            return (vaiTro ?? "").Trim().ToLower() == "admin";
        }

        private bool LaNhanVien()
        {
            string vt = (vaiTro ?? "").Trim().ToLower();
            return vt == "nhanvien" || vt == "nhân viên";
        }

        private void CaiDatNut(Button btn, Image icon, string text)
        {
            btn.Image = icon;
            btn.Text = text;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CaiDatIconNut()
        {
            CaiDatNut(btnThem, Properties.Resources.add_24, "Thêm");
            CaiDatNut(btnSua, Properties.Resources.edit_24, "Sửa");
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnLuu, Properties.Resources.save_24, "Lưu");
            CaiDatNut(btnHuy, Properties.Resources.cancel_24, "Hủy");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnTimKiem, Properties.Resources.search_24, "Tìm kiếm");
            CaiDatNut(btnNhap, Properties.Resources.import_24, "Nhập");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất");
        }

        private void BatTatNhapLieu(bool giaTri)
        {
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            txtID.ReadOnly = true;
        }

        private void BatTatNutKhiNhapLieu(bool dangNhapLieu)
        {
            btnLuu.Enabled = dangNhapLieu;
            btnHuy.Enabled = dangNhapLieu;

            btnThem.Enabled = !dangNhapLieu;
            btnSua.Enabled = !dangNhapLieu;
            btnXoa.Enabled = !dangNhapLieu;
            btnThoat.Enabled = !dangNhapLieu;
            btnNhap.Enabled = !dangNhapLieu;
            btnXuat.Enabled = !dangNhapLieu;
            btnTimKiem.Enabled = !dangNhapLieu;
            dgvKhachHang.Enabled = !dangNhapLieu;
        }

        private void ApDungPhanQuyen()
        {
            if (LaAdmin())
            {
                // Admin chỉ được bật/tắt trạng thái
                BatTatNhapLieu(false);

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                chkTrangThai.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);

                btnThoat.Enabled = true;
                btnNhap.Enabled = true;
                btnXuat.Enabled = true;
                btnTimKiem.Enabled = true;
                dgvKhachHang.Enabled = true;
            }
            else if (LaNhanVien())
            {
                // Nhân viên được thêm/sửa/xóa, không được đổi trạng thái
                BatTatNhapLieu(false);

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                chkTrangThai.Enabled = false;

                btnThoat.Enabled = true;
                btnNhap.Enabled = true;
                btnXuat.Enabled = true;
                btnTimKiem.Enabled = true;
                dgvKhachHang.Enabled = true;
            }
        }

        private void HienThiCheDoAdmin()
        {
            if (!LaAdmin()) return;

            BatTatNhapLieu(false);

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            chkTrangThai.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThoat.Enabled = true;
            btnNhap.Enabled = true;
            btnXuat.Enabled = true;
            btnTimKiem.Enabled = true;
            dgvKhachHang.Enabled = true;
        }

        private void XoaDuLieuNhap()
        {
            dangTaiDuLieu = true;

            txtID.Text = "";
            txtHoVaTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            chkTrangThai.Checked = true;

            dangTaiDuLieu = false;
        }

        private void GanBinding(BindingSource bindingSource)
        {
            dangTaiDuLieu = true;

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            chkTrangThai.DataBindings.Clear();
            chkTrangThai.DataBindings.Add("Checked", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);

            dangTaiDuLieu = false;
        }

        private void TaiDuLieu()
        {
            dgvKhachHang.AutoGenerateColumns = false;

            var ds = context.KhachHang
                .OrderBy(x => x.ID)
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;

            GanBinding(bindingSource);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bindingSource;
        }

        private void TaiDuLieu(object dataSource)
        {
            dgvKhachHang.AutoGenerateColumns = false;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;

            GanBinding(bindingSource);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bindingSource;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiDuLieu();
            ApDungPhanQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin không được thêm khách hàng.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            xuLyThem = true;

            BatTatNhapLieu(true);
            BatTatNutKhiNhapLieu(true);
            XoaDuLieuNhap();

            chkTrangThai.Enabled = false;
            chkTrangThai.Checked = true;

            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin không được sửa thông tin khách hàng.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;

            BatTatNhapLieu(true);
            BatTatNutKhiNhapLieu(true);

            chkTrangThai.Enabled = false;

            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin không được xóa khách hàng.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được khách hàng cần xóa!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKhachHang = dgvKhachHang.CurrentRow.Cells["colHoVaTen"].Value?.ToString() ?? "";

            DialogResult kq = MessageBox.Show(
                $"Xác nhận xóa khách hàng: {tenKhachHang}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes) return;

            try
            {
                var kh = context.KhachHang.Find(idXoa);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    ApDungPhanQuyen();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đang có hóa đơn liên quan!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (LaAdmin())
                {
                    if (!int.TryParse(txtID.Text, out int idAdmin))
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật trạng thái!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var khAdmin = context.KhachHang.Find(idAdmin);
                    if (khAdmin == null)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    khAdmin.TrangThai = chkTrangThai.Checked;
                    context.SaveChanges();

                    MessageBox.Show("Cập nhật trạng thái hoạt động thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    HienThiCheDoAdmin();
                    return;
                }

                string hoVaTen = txtHoVaTen.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();

                if (string.IsNullOrWhiteSpace(hoVaTen))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoVaTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Focus();
                    return;
                }

                if (xuLyThem)
                {
                    bool trungTenDangNhap = context.KhachHang.Any(x => x.TenDangNhap == tenDangNhap);
                    if (trungTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    bool daTonTai = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai);

                    if (daTonTai)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHoVaTen.Focus();
                        return;
                    }

                    KhachHang kh = new KhachHang
                    {
                        HoVaTen = hoVaTen,
                        DienThoai = string.IsNullOrWhiteSpace(dienThoai) ? null : dienThoai,
                        DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi,
                        Email = string.IsNullOrWhiteSpace(email) ? null : email,
                        TenDangNhap = tenDangNhap,
                        MatKhau = matKhau,
                        NgayTao = DateTime.Now,
                        TrangThai = true
                    };

                    context.KhachHang.Add(kh);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được khách hàng cần sửa!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungTenDangNhap = context.KhachHang.Any(x =>
                        x.TenDangNhap == tenDangNhap &&
                        x.ID != idSua);

                    if (trungTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    bool trungDuLieu = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHoVaTen.Focus();
                        return;
                    }

                    var kh = context.KhachHang.Find(idSua);
                    if (kh != null)
                    {
                        kh.HoVaTen = hoVaTen;
                        kh.DienThoai = string.IsNullOrWhiteSpace(dienThoai) ? null : dienThoai;
                        kh.DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi;
                        kh.Email = string.IsNullOrWhiteSpace(email) ? null : email;
                        kh.TenDangNhap = tenDangNhap;
                        kh.MatKhau = matKhau;

                        context.KhachHang.Update(kh);
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Lưu thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                ApDungPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TaiDuLieu();

            if (LaAdmin())
                HienThiCheDoAdmin();
            else
                ApDungPhanQuyen();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập từ khóa tìm kiếm (họ tên, điện thoại, địa chỉ, email, tên đăng nhập):",
                "Tìm kiếm khách hàng",
                "");

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                TaiDuLieu();
                ApDungPhanQuyen();
                return;
            }

            string lower = searchTerm.Trim().ToLower();

            var ketQua = context.KhachHang
                .Where(x =>
                    (x.HoVaTen ?? "").ToLower().Contains(lower) ||
                    (x.DienThoai ?? "").ToLower().Contains(lower) ||
                    (x.DiaChi ?? "").ToLower().Contains(lower) ||
                    (x.Email ?? "").ToLower().Contains(lower) ||
                    (x.TenDangNhap ?? "").ToLower().Contains(lower))
                .OrderBy(x => x.ID)
                .ToList();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                TaiDuLieu(ketQua);
            }

            ApDungPhanQuyen();
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu) return;

            if (LaAdmin() && !string.IsNullOrWhiteSpace(txtID.Text))
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu) return;

            if (LaAdmin())
            {
                HienThiCheDoAdmin();
            }
        }
    }
}