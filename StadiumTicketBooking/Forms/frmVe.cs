using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmVe : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private bool dangNapDuLieuNoiBo = false;

        private string projectRootFolder = string.Empty;
        private string imagesFolder = string.Empty;
        private string ticketImagesFolder = string.Empty;

        public frmVe()
        {
            InitializeComponent();

            projectRootFolder = GetProjectRootFolder();
            imagesFolder = Path.Combine(projectRootFolder, "Images");
            ticketImagesFolder = Path.Combine(imagesFolder, "AnhVe");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            if (!Directory.Exists(ticketImagesFolder))
                Directory.CreateDirectory(ticketImagesFolder);

            dgvVe.DataError += dgvVe_DataError;
            dgvVe.CellFormatting += dgvVe_CellFormatting;
            dgvVe.SelectionChanged += dgvVe_SelectionChanged;
            cboSuKien.SelectedIndexChanged += cboSuKien_SelectedIndexChanged;
        }

        private void frmVe_Load(object sender, EventArgs e)
        {
            dangNapDuLieuNoiBo = true;

            CaiDatIconNut();
            DinhDangDgvVe();
            TaiDanhSachSuKien();
            TaiDanhSachTrangThai();
            TaiDanhSachGheTheoSuKien();
            BatTatChucNang(false);
            TaiDuLieu();

            dangNapDuLieuNoiBo = false;
        }

        private void DinhDangDgvVe()
        {
            dgvVe.BorderStyle = BorderStyle.None;
            dgvVe.BackgroundColor = Color.White;
            dgvVe.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvVe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVe.GridColor = Color.Gray;

            dgvVe.EnableHeadersVisualStyles = false;
            dgvVe.RowHeadersVisible = false;
            dgvVe.AllowUserToAddRows = false;
            dgvVe.AllowUserToDeleteRows = false;
            dgvVe.ReadOnly = true;
            dgvVe.MultiSelect = false;
            dgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVe.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvVe.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvVe.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dgvVe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVe.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvVe.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVe.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvVe.DefaultCellStyle.Font = new Font("Times New Roman", 11F, FontStyle.Regular);
            dgvVe.DefaultCellStyle.ForeColor = Color.Black;
            dgvVe.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvVe.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVe.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvVe.ColumnHeadersHeight = 40;
            dgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVe.RowTemplate.Height = 42;
        }

        private string GetProjectRootFolder()
        {
            string baseDir = Application.StartupPath;
            DirectoryInfo? dir = new DirectoryInfo(baseDir);

            while (dir != null)
            {
                try
                {
                    if (dir.GetFiles("*.csproj").Length > 0)
                        return dir.FullName;
                }
                catch
                {
                }

                dir = dir.Parent;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private string? FindImagePath(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string path1 = Path.Combine(ticketImagesFolder, fileName);
            if (File.Exists(path1))
                return path1;

            string path2 = Path.Combine(imagesFolder, fileName);
            if (File.Exists(path2))
                return path2;

            try
            {
                string[] files = Directory.GetFiles(imagesFolder, fileName, SearchOption.AllDirectories);
                if (files.Length > 0)
                    return files[0];
            }
            catch
            {
            }

            return null;
        }

        private void ClearPictureBox()
        {
            try
            {
                picHinhAnh.ImageLocation = null;

                if (picHinhAnh.Image != null)
                {
                    Image oldImage = picHinhAnh.Image;
                    picHinhAnh.Image = null;
                    oldImage.Dispose();
                }
            }
            catch
            {
            }
        }

        private void ShowImageToPictureBox(string? imagePath)
        {
            ClearPictureBox();

            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                return;

            try
            {
                byte[] bytes = File.ReadAllBytes(imagePath);
                using (MemoryStream ms = new MemoryStream(bytes))
                using (Image img = Image.FromStream(ms))
                {
                    picHinhAnh.Image = new Bitmap(img);
                }

                picHinhAnh.ImageLocation = imagePath;
            }
            catch
            {
                ClearPictureBox();
            }
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
            CaiDatNut(btnHuy, Properties.Resources.exit_24, "Hủy");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnTimKiem, Properties.Resources.search_24, "Tìm kiếm");
            CaiDatNut(btnNhap, Properties.Resources.import_24, "Nhập");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất");
            CaiDatNut(btnDoiAnh, Properties.Resources.camera_24, "Đổi ảnh");
        }

        private void BatTatChucNang(bool dangXuLy)
        {
            btnLuu.Enabled = dangXuLy;
            btnHuy.Enabled = dangXuLy;

            cboSuKien.Enabled = dangXuLy;
            cboGhe.Enabled = dangXuLy;
            txtGiaVe.Enabled = dangXuLy;
            cboTrangThai.Enabled = false;
            btnDoiAnh.Enabled = dangXuLy;

            btnThem.Enabled = !dangXuLy;
            btnSua.Enabled = !dangXuLy;
            btnXoa.Enabled = !dangXuLy;
            btnThoat.Enabled = !dangXuLy;
            btnNhap.Enabled = !dangXuLy;
            btnXuat.Enabled = !dangXuLy;
            btnTimKiem.Enabled = !dangXuLy;
            dgvVe.Enabled = !dangXuLy;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Clear();
            txtGiaVe.Clear();

            dangNapDuLieuNoiBo = true;

            if (cboSuKien.Items.Count > 0)
                cboSuKien.SelectedIndex = 0;

            TaiDanhSachGheTheoSuKien();

            if (cboGhe.Items.Count > 0)
                cboGhe.SelectedIndex = 0;

            cboTrangThai.Text = "Trống";

            dangNapDuLieuNoiBo = false;

            ClearPictureBox();
        }

        private void TaiDanhSachSuKien(int? selectedSuKienId = null)
        {
            var dsSuKien = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenSuKien + " - " + x.SanVanDong.TenSan
                })
                .OrderBy(x => x.TenHienThi)
                .ToList();

            cboSuKien.DataSource = dsSuKien;
            cboSuKien.DisplayMember = "TenHienThi";
            cboSuKien.ValueMember = "ID";

            if (selectedSuKienId.HasValue && dsSuKien.Any(x => x.ID == selectedSuKienId.Value))
                cboSuKien.SelectedValue = selectedSuKienId.Value;
        }

        private void TaiDanhSachGheTheoSuKien(int? gheDangChon = null)
        {
            int? suKienId = GetSelectedIntValue(cboSuKien.SelectedValue);
            int? sanVanDongId = null;

            if (suKienId.HasValue)
            {
                sanVanDongId = context.SuKien
                    .Where(x => x.ID == suKienId.Value)
                    .Select(x => (int?)x.SanVanDongID)
                    .FirstOrDefault();
            }

            var query = context.Ghe.AsQueryable();

            if (sanVanDongId.HasValue)
            {
                query = query.Where(x => x.KhuVuc.SanVanDongID == sanVanDongId.Value);
            }

            var dsGhe = query
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.SoGhe + " - " + x.KhuVuc.TenKhuVuc + " - " + x.KhuVuc.SanVanDong.TenSan
                })
                .OrderBy(x => x.TenHienThi)
                .ToList();

            cboGhe.DataSource = dsGhe;
            cboGhe.DisplayMember = "TenHienThi";
            cboGhe.ValueMember = "ID";

            if (gheDangChon.HasValue && dsGhe.Any(x => x.ID == gheDangChon.Value))
                cboGhe.SelectedValue = gheDangChon.Value;
            else if (dsGhe.Count > 0)
                cboGhe.SelectedIndex = 0;
            else
                cboGhe.SelectedIndex = -1;
        }

        private void TaiDanhSachTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đã bán");
            cboTrangThai.SelectedIndex = 0;
            cboTrangThai.Enabled = false;
        }

        private string LayTrangThaiThucTe(int veId)
        {
            bool daBan = context.HoaDon_ChiTiet.Any(x => x.VeID == veId);
            return daBan ? "Đã bán" : "Trống";
        }

        private int? GetSelectedIntValue(object? value)
        {
            try
            {
                if (value == null)
                    return null;

                return Convert.ToInt32(value);
            }
            catch
            {
                return null;
            }
        }

        private object? LayGiaTriThuocTinh(object? obj, string propertyName)
        {
            if (obj == null)
                return null;

            PropertyInfo? prop = obj.GetType().GetProperty(propertyName);
            return prop?.GetValue(obj, null);
        }

        private string? LayTenFileAnhDongDangChon()
        {
            if (dgvVe.CurrentRow?.DataBoundItem == null)
                return null;

            object? value = LayGiaTriThuocTinh(dgvVe.CurrentRow.DataBoundItem, "HinhAnh");
            return value?.ToString();
        }

        private void TaiDuLieu()
        {
            dgvVe.AutoGenerateColumns = false;

            var dsVeDaBan = context.HoaDon_ChiTiet
                .Select(x => x.VeID)
                .ToList();

            var listVe = context.Ve
                .OrderBy(x => x.ID)
                .Select(x => new
                {
                    x.ID,
                    x.SuKienID,
                    x.GheID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.SuKien.SanVanDong.TenSan,
                    x.GiaVe,
                    TrangThai = dsVeDaBan.Contains(x.ID) ? "Đã bán" : "Trống",
                    x.HinhAnh
                })
                .ToList();

            GanBinding(listVe);
        }

        private void TaiDuLieu(object dataSource)
        {
            dgvVe.AutoGenerateColumns = false;
            GanBinding(dataSource);
        }

        private void GanBinding(object dataSource)
        {
            dangNapDuLieuNoiBo = true;

            BindingSource bindingSource = new BindingSource
            {
                DataSource = dataSource
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtGiaVe.DataBindings.Clear();
            txtGiaVe.DataBindings.Add("Text", bindingSource, "GiaVe", true, DataSourceUpdateMode.Never, "", "N0");

            cboSuKien.DataBindings.Clear();
            cboSuKien.DataBindings.Add("SelectedValue", bindingSource, "SuKienID", false, DataSourceUpdateMode.Never);

            cboGhe.DataBindings.Clear();
            cboGhe.DataBindings.Add("SelectedValue", bindingSource, "GheID", false, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding bImg = new Binding("Tag", bindingSource, "HinhAnh", true);
            bImg.Format += (s, e) =>
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                    e.Value = FindImagePath(e.Value.ToString());
                else
                    e.Value = null;
            };
            picHinhAnh.DataBindings.Add(bImg);

            dgvVe.DataSource = null;
            dgvVe.DataSource = bindingSource;

            if (dgvVe.Columns["colGiaVe"] != null)
            {
                dgvVe.Columns["colGiaVe"].DefaultCellStyle.Format = "N0";
                dgvVe.Columns["colGiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvVe.Columns["colHinhAnh"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            int? suKienId = GetSelectedIntValue(cboSuKien.SelectedValue);
            int? gheId = GetSelectedIntValue(cboGhe.SelectedValue);

            if (suKienId.HasValue)
                TaiDanhSachGheTheoSuKien(gheId);

            string? filePath = picHinhAnh.Tag?.ToString();
            ShowImageToPictureBox(filePath);

            dangNapDuLieuNoiBo = false;
        }

        private void dgvVe_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvVe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVe.Columns[e.ColumnIndex].Name == "colHinhAnh")
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    string fileName = e.Value.ToString()!;
                    string? imagePath = FindImagePath(fileName);

                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        try
                        {
                            byte[] bytes = File.ReadAllBytes(imagePath);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            using (Image img = Image.FromStream(ms))
                            {
                                e.Value = new Bitmap(img, 55, 40);
                                e.FormattingApplied = true;
                            }
                        }
                        catch
                        {
                            e.Value = null;
                            e.FormattingApplied = true;
                        }
                    }
                    else
                    {
                        e.Value = null;
                        e.FormattingApplied = true;
                    }
                }
                else
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvVe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null)
                return;

            string? fileName = LayTenFileAnhDongDangChon();
            string? imagePath = FindImagePath(fileName);
            ShowImageToPictureBox(imagePath);
        }

        private void cboSuKien_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (dangNapDuLieuNoiBo)
                return;

            int? gheDangChon = GetSelectedIntValue(cboGhe.SelectedValue);
            TaiDanhSachGheTheoSuKien(gheDangChon);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            XoaDuLieuNhap();
            BatTatChucNang(true);
            cboSuKien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);

            int? gheDangChon = GetSelectedIntValue(cboGhe.SelectedValue);
            TaiDanhSachGheTheoSuKien(gheDangChon);

            cboSuKien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVe.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được vé cần xóa!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool dangDuocBan = context.HoaDon_ChiTiet.Any(x => x.VeID == idXoa);
            if (dangDuocBan)
            {
                MessageBox.Show("Không thể xóa vé này vì vé đang nằm trong hóa đơn!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenVe = (dgvVe.CurrentRow.Cells["colTenSuKien"].Value?.ToString() ?? "") +
                           " - " +
                           (dgvVe.CurrentRow.Cells["colSoGhe"].Value?.ToString() ?? "");

            DialogResult dr = MessageBox.Show(
                "Xác nhận xóa vé: " + tenVe + "?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return;

            try
            {
                var ve = context.Ve.Find(idXoa);
                if (ve != null)
                {
                    context.Ve.Remove(ve);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa vé. " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboSuKien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sự kiện!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSuKien.Focus();
                return;
            }

            if (cboGhe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ghế!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGhe.Focus();
                return;
            }

            string giaVeText = txtGiaVe.Text.Trim().Replace(",", "").Replace(".", "");
            if (!int.TryParse(giaVeText, out int giaVe) || giaVe < 0)
            {
                MessageBox.Show("Giá vé không hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaVe.Focus();
                return;
            }

            int suKienId = Convert.ToInt32(cboSuKien.SelectedValue);
            int gheId = Convert.ToInt32(cboGhe.SelectedValue);

            var suKien = context.SuKien.Find(suKienId);
            var ghe = context.Ghe.Find(gheId);

            if (suKien == null || ghe == null)
            {
                MessageBox.Show("Dữ liệu sự kiện hoặc ghế không tồn tại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var khuVuc = context.KhuVuc.Find(ghe.KhuVucID);
            if (khuVuc == null || khuVuc.SanVanDongID != suKien.SanVanDongID)
            {
                MessageBox.Show("Ghế không thuộc sân vận động của sự kiện này!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGhe.Focus();
                return;
            }

            try
            {
                string fileNameOnly = string.IsNullOrWhiteSpace(picHinhAnh.ImageLocation)
                    ? ""
                    : Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    bool daTonTai = context.Ve.Any(x =>
                        x.SuKienID == suKienId &&
                        x.GheID == gheId);

                    if (daTonTai)
                    {
                        MessageBox.Show("Vé của ghế này trong sự kiện đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboGhe.Focus();
                        return;
                    }

                    Ve ve = new Ve
                    {
                        SuKienID = suKienId,
                        GheID = gheId,
                        GiaVe = giaVe,
                        TrangThai = "Trống",
                        HinhAnh = fileNameOnly
                    };

                    context.Ve.Add(ve);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được vé cần sửa!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.Ve.Any(x =>
                        x.SuKienID == suKienId &&
                        x.GheID == gheId &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Vé của ghế này trong sự kiện đã tồn tại!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboGhe.Focus();
                        return;
                    }

                    var ve = context.Ve.Find(idSua);
                    if (ve != null)
                    {
                        ve.SuKienID = suKienId;
                        ve.GheID = gheId;
                        ve.GiaVe = giaVe;
                        ve.TrangThai = LayTrangThaiThucTe(ve.ID);

                        if (!string.IsNullOrWhiteSpace(fileNameOnly))
                            ve.HinhAnh = fileNameOnly;

                        context.Ve.Update(ve);
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Lưu thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            TaiDuLieu();
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập từ khóa tìm kiếm (sự kiện, ghế, khu vực, sân, giá vé, trạng thái):",
                "Tìm kiếm vé",
                "");

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                TaiDuLieu();
                BatTatChucNang(false);
                return;
            }

            string lower = tuKhoa.Trim().ToLower();

            var dsVeDaBan = context.HoaDon_ChiTiet
                .Select(x => x.VeID)
                .ToList();

            var ketQua = context.Ve
                .Select(x => new
                {
                    x.ID,
                    x.SuKienID,
                    x.GheID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.SuKien.SanVanDong.TenSan,
                    x.GiaVe,
                    TrangThai = dsVeDaBan.Contains(x.ID) ? "Đã bán" : "Trống",
                    x.HinhAnh
                })
                .Where(x =>
                    (x.TenSuKien ?? "").ToLower().Contains(lower) ||
                    (x.SoGhe ?? "").ToLower().Contains(lower) ||
                    (x.TenKhuVuc ?? "").ToLower().Contains(lower) ||
                    (x.TenSan ?? "").ToLower().Contains(lower) ||
                    x.GiaVe.ToString().Contains(lower) ||
                    (x.TrangThai ?? "").ToLower().Contains(lower))
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

            BatTatChucNang(false);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh vé";
            openFileDialog.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string sourceFile = openFileDialog.FileName;
                string extension = Path.GetExtension(sourceFile);
                string newFileName = "ve_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + extension;
                string destFile = Path.Combine(ticketImagesFolder, newFileName);

                File.Copy(sourceFile, destFile, true);
                ShowImageToPictureBox(destFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đổi ảnh. " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ClearPictureBox();
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}