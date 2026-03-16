using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmSuKien : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId = 0;

        public frmSuKien()
        {
            InitializeComponent();
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

            txtTenSuKien.Enabled = giaTri;
            cboSanVanDong.Enabled = giaTri;
            dtpThoiGian.Enabled = giaTri;
            txtGiaCoBan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvSuKien.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtTenSuKien.Text = string.Empty;
            txtGiaCoBan.Text = string.Empty;
            dtpThoiGian.Value = DateTime.Now;

            if (cboSanVanDong.Items.Count > 0)
                cboSanVanDong.SelectedIndex = 0;
        }

        private void TaiDanhSachSanVanDong()
        {
            cboSanVanDong.DataSource = context.SanVanDong.ToList();
            cboSanVanDong.DisplayMember = "TenSan";
            cboSanVanDong.ValueMember = "ID";
        }

        private void TaiDuLieu()
        {
            dgvSuKien.AutoGenerateColumns = false;

            var listSuKien = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    x.TenSuKien,
                    TenSan = x.SanVanDong.TenSan,
                    x.SanVanDongID,
                    x.ThoiGian,
                    x.GiaCoBan
                })
                .ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listSuKien
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtTenSuKien.DataBindings.Clear();
            txtTenSuKien.DataBindings.Add("Text", bindingSource, "TenSuKien", false, DataSourceUpdateMode.Never);

            cboSanVanDong.DataBindings.Clear();
            cboSanVanDong.DataBindings.Add("SelectedValue", bindingSource, "SanVanDongID", false, DataSourceUpdateMode.Never);

            dtpThoiGian.DataBindings.Clear();
            dtpThoiGian.DataBindings.Add("Value", bindingSource, "ThoiGian", true, DataSourceUpdateMode.Never);

            txtGiaCoBan.DataBindings.Clear();
            txtGiaCoBan.DataBindings.Add("Text", bindingSource, "GiaCoBan", false, DataSourceUpdateMode.Never);

            dgvSuKien.DataSource = null;
            dgvSuKien.DataSource = bindingSource;
        }

        private void TaiDuLieu(object dataSource)
        {
            dgvSuKien.AutoGenerateColumns = false;

            BindingSource bindingSource = new BindingSource
            {
                DataSource = dataSource
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtTenSuKien.DataBindings.Clear();
            txtTenSuKien.DataBindings.Add("Text", bindingSource, "TenSuKien", false, DataSourceUpdateMode.Never);

            cboSanVanDong.DataBindings.Clear();
            cboSanVanDong.DataBindings.Add("SelectedValue", bindingSource, "SanVanDongID", false, DataSourceUpdateMode.Never);

            dtpThoiGian.DataBindings.Clear();
            dtpThoiGian.DataBindings.Add("Value", bindingSource, "ThoiGian", true, DataSourceUpdateMode.Never);

            txtGiaCoBan.DataBindings.Clear();
            txtGiaCoBan.DataBindings.Add("Text", bindingSource, "GiaCoBan", false, DataSourceUpdateMode.Never);

            dgvSuKien.DataSource = null;
            dgvSuKien.DataSource = bindingSource;
        }

        private void frmSuKien_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiDanhSachSanVanDong();
            BatTatChucNang(false);
            TaiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            currentId = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtTenSuKien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSuKien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvSuKien.CurrentRow.Cells["colID"].Value?.ToString(), out currentId))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                txtTenSuKien.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được sự kiện cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSuKien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvSuKien.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được sự kiện cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenSuKien = dgvSuKien.CurrentRow.Cells["colTenSuKien"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa sự kiện: {tenSuKien}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var sk = context.SuKien.Find(idXoa);
                if (sk != null)
                {
                    context.SuKien.Remove(sk);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa sự kiện này vì đang có vé hoặc dữ liệu liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSuKien = txtTenSuKien.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenSuKien))
            {
                MessageBox.Show("Vui lòng nhập tên sự kiện!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSuKien.Focus();
                return;
            }

            if (!int.TryParse(txtGiaCoBan.Text.Trim(), out int giaCoBan) || giaCoBan < 0)
            {
                MessageBox.Show("Giá cơ bản không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaCoBan.Focus();
                return;
            }

            if (cboSanVanDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sân vận động!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSanVanDong.Focus();
                return;
            }

            int sanVanDongId = Convert.ToInt32(cboSanVanDong.SelectedValue);
            DateTime thoiGian = dtpThoiGian.Value;

            try
            {
                if (xuLyThem)
                {
                    bool daTonTai = context.SuKien.Any(x =>
                        x.TenSuKien == tenSuKien &&
                        x.SanVanDongID == sanVanDongId &&
                        x.ThoiGian == thoiGian);

                    if (daTonTai)
                    {
                        MessageBox.Show("Sự kiện này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenSuKien.Focus();
                        return;
                    }

                    SuKien sk = new SuKien
                    {
                        TenSuKien = tenSuKien,
                        SanVanDongID = sanVanDongId,
                        ThoiGian = thoiGian,
                        GiaCoBan = giaCoBan
                    };

                    context.SuKien.Add(sk);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được sự kiện cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.SuKien.Any(x =>
                        x.TenSuKien == tenSuKien &&
                        x.SanVanDongID == sanVanDongId &&
                        x.ThoiGian == thoiGian &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Sự kiện này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenSuKien.Focus();
                        return;
                    }

                    var sk = context.SuKien.Find(idSua);
                    if (sk != null)
                    {
                        sk.TenSuKien = tenSuKien;
                        sk.SanVanDongID = sanVanDongId;
                        sk.ThoiGian = thoiGian;
                        sk.GiaCoBan = giaCoBan;
                        context.SuKien.Update(sk);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                BatTatChucNang(false);
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
                "Nhập từ khóa tìm kiếm (tên sự kiện, sân vận động, thời gian, giá cơ bản):",
                "Tìm kiếm sự kiện",
                "");

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                TaiDuLieu();
                BatTatChucNang(false);
                return;
            }

            string lower = searchTerm.Trim().ToLower();

            var ketQua = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    x.TenSuKien,
                    TenSan = x.SanVanDong.TenSan,
                    x.SanVanDongID,
                    x.ThoiGian,
                    x.GiaCoBan
                })
                .ToList()
                .Where(x =>
                    (x.TenSuKien ?? "").ToLower().Contains(lower) ||
                    (x.TenSan ?? "").ToLower().Contains(lower) ||
                    x.ThoiGian.ToString("dd/MM/yyyy HH:mm").ToLower().Contains(lower) ||
                    x.GiaCoBan.ToString().ToLower().Contains(lower))
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
        }
    }
}