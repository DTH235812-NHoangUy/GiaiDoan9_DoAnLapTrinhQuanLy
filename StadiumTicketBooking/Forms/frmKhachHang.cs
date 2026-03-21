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
            return vaiTro.Trim().ToLower() == "admin";
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

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvKhachHang.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void ApDungPhanQuyen()
        {
            if (LaAdmin())
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtHoVaTen.Enabled = false;
                txtDienThoai.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
                chkTrangThai.Enabled = false;
            }
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            chkTrangThai.Checked = true;
        }

        private void GanBinding(BindingSource bindingSource)
        {
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
        }

        private void TaiDuLieu()
        {
            dgvKhachHang.AutoGenerateColumns = false;

            var listKhachHang = context.KhachHang
                .OrderBy(x => x.ID)
                .ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listKhachHang
            };

            GanBinding(bindingSource);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bindingSource;
        }

        private void TaiDuLieu(object dataSource)
        {
            dgvKhachHang.AutoGenerateColumns = false;

            BindingSource bindingSource = new BindingSource
            {
                DataSource = dataSource
            };

            GanBinding(bindingSource);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bindingSource;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            BatTatChucNang(false);
            TaiDuLieu();
            ApDungPhanQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được thêm.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            xuLyThem = true;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được sửa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được khách hàng cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKhachHang = dgvKhachHang.CurrentRow.Cells["colHoVaTen"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa khách hàng: {tenKhachHang}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var kh = context.KhachHang.Find(idXoa);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                    ApDungPhanQuyen();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đang có hóa đơn liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được lưu.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string hoVaTen = txtHoVaTen.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool trangThai = chkTrangThai.Checked;

            if (string.IsNullOrWhiteSpace(hoVaTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    bool trungTenDangNhap = context.KhachHang.Any(x => x.TenDangNhap == tenDangNhap);
                    if (trungTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    bool daTonTai = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai);

                    if (daTonTai)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        TrangThai = trangThai
                    };

                    context.KhachHang.Add(kh);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được khách hàng cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungTenDangNhap = context.KhachHang.Any(x =>
                        x.TenDangNhap == tenDangNhap &&
                        x.ID != idSua);

                    if (trungTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    bool trungDuLieu = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        kh.TrangThai = trangThai;

                        context.KhachHang.Update(kh);
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                BatTatChucNang(false);
                ApDungPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            TaiDuLieu();
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
                BatTatChucNang(false);
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
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                TaiDuLieu(ketQua);
            }

            BatTatChucNang(false);
            ApDungPhanQuyen();
        }
    }
}