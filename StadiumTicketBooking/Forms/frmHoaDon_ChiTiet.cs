using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using StadiumTicketBooking.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        private int id = 0;
        private int nhanVienIDDangNhap = 0;
        private int khachHangIDDangNhap = 0;
        private string vaiTro = "";

        private int khachHangIDTam = 0;
        private string ghiChuTam = "";
        private bool moTuDatVe = false;

        private BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public bool DaLuuThanhCong { get; private set; } = false;
        public bool DaXoaHoaDon { get; private set; } = false;

        public List<DanhSachHoaDon_ChiTiet> DanhSachChiTietSauKhiSua { get; private set; }
            = new List<DanhSachHoaDon_ChiTiet>();

        public int KhachHangIDSauKhiSua { get; private set; } = 0;
        public string GhiChuSauKhiSua { get; private set; } = "";

        public frmHoaDon_ChiTiet() : this(0, 0, 0, "")
        {
        }

        public frmHoaDon_ChiTiet(string vaiTro) : this(0, 0, 0, vaiTro)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon) : this(maHoaDon, 0, 0, "")
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon, string vaiTro) : this(maHoaDon, 0, 0, vaiTro)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon, int nhanVienID, string vaiTro)
            : this(maHoaDon, nhanVienID, 0, vaiTro)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon, int nhanVienID, int khachHangID, string vaiTro)
        {
            InitializeComponent();
            id = maHoaDon;
            nhanVienIDDangNhap = nhanVienID;
            khachHangIDDangNhap = khachHangID;
            this.vaiTro = vaiTro ?? "";
        }

        public frmHoaDon_ChiTiet(
            int nhanVienID,
            string vaiTro,
            int khachHangID,
            string ghiChu,
            List<DanhSachHoaDon_ChiTiet> dsChiTietTam)
            : this(0, nhanVienID, khachHangID, vaiTro)
        {
            moTuDatVe = true;
            khachHangIDTam = khachHangID;
            ghiChuTam = ghiChu ?? "";
            hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(
                dsChiTietTam ?? new List<DanhSachHoaDon_ChiTiet>());
        }

        private bool LaAdmin()
        {
            string role = vaiTro.Trim().ToLower();
            return role == "admin";
        }

        private bool LaNhanVien()
        {
            string role = vaiTro.Trim().ToLower();
            return role == "nhanvien" || role == "nhân viên";
        }

        private bool LaKhachHang()
        {
            string role = vaiTro.Trim().ToLower();
            return role == "khachhang" || role == "khách hàng";
        }

        private bool CoTheSuaHoaDon(HoaDon hoaDon)
        {
            if (hoaDon == null)
                return false;

            if (LaAdmin())
                return false;

            if (LaKhachHang())
                return hoaDon.KhachHangID == khachHangIDDangNhap;

            if (LaNhanVien())
            {
                return hoaDon.NhanVienID.HasValue
                       && hoaDon.NhanVienID.Value == nhanVienIDDangNhap;
            }

            return false;
        }

        private int LayNhanVienLapHoaDon()
        {
            if (LaNhanVien())
                return nhanVienIDDangNhap;

            if (cboNhanVien.SelectedValue == null)
                return 0;

            int maNhanVien;
            return int.TryParse(cboNhanVien.SelectedValue.ToString(), out maNhanVien) ? maNhanVien : 0;
        }

        private void ApDungPhanQuyen()
        {
            cboNhanVien.Enabled = false;
            cboKhachHang.Enabled = false;
            txtGhiChuHoaDon.Enabled = false;

            if (LaAdmin())
            {
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            if (moTuDatVe)
            {
                if (LaNhanVien())
                {
                    cboNhanVien.Enabled = false;
                }
                else if (LaKhachHang())
                {
                    cboNhanVien.Enabled = false;
                    cboKhachHang.Enabled = false;
                }

                return;
            }

            btnLuuHoaDon.Enabled = false;
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
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnLuuHoaDon, Properties.Resources.save_24, "Lưu hóa đơn");
            CaiDatNut(btnInHoaDon, Properties.Resources.save_24, "In hóa đơn...");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, moTuDatVe ? "Quay lại đặt vé" : "Thoát");
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhDataGridView();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = hoaDonChiTiet;

            TaiDanhMucComboBox();

            if (id != 0)
            {
                TaiHoaDonCanSua();
            }
            else if (moTuDatVe)
            {
                DoDuLieuTamTuDatVe();
            }

            BatTatChucNang();
            ApDungPhanQuyen();
            CapNhatTongTienTamTinh();
        }

        private void TaiDanhMucComboBox()
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
        }

        private void DoDuLieuTamTuDatVe()
        {
            if (khachHangIDTam > 0)
                cboKhachHang.SelectedValue = khachHangIDTam;

            txtGhiChuHoaDon.Text = ghiChuTam ?? "";
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void CauHinhDataGridView()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;

            if (dataGridView.Columns["DonGiaBan"] != null)
            {
                dataGridView.Columns["DonGiaBan"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["DonGiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView.Columns["SoLuongBan"] != null)
            {
                dataGridView.Columns["SoLuongBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView.Columns["ThanhTien"] != null)
            {
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void LayNhanVienVaoComboBox()
        {
            if (LaNhanVien() && moTuDatVe)
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .Where(x => x.ID == nhanVienIDDangNhap)
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "ID";
                cboNhanVien.DisplayMember = "HoVaTen";

                if (dsNhanVien.Count > 0)
                    cboNhanVien.SelectedValue = nhanVienIDDangNhap;
                else
                    cboNhanVien.SelectedIndex = -1;
            }
            else
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "ID";
                cboNhanVien.DisplayMember = "HoVaTen";

                if (id == 0)
                    cboNhanVien.SelectedIndex = -1;
            }
        }

        private void LayKhachHangVaoComboBox()
        {
            if (LaKhachHang() && khachHangIDDangNhap > 0)
            {
                var dsKhachHang = context.KhachHang
                    .AsNoTracking()
                    .Where(x => x.ID == khachHangIDDangNhap)
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboKhachHang.DataSource = dsKhachHang;
                cboKhachHang.ValueMember = "ID";
                cboKhachHang.DisplayMember = "HoVaTen";

                if (dsKhachHang.Count > 0)
                    cboKhachHang.SelectedValue = khachHangIDDangNhap;
                else
                    cboKhachHang.SelectedIndex = -1;
            }
            else
            {
                var dsKhachHang = context.KhachHang
                    .AsNoTracking()
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboKhachHang.DataSource = dsKhachHang;
                cboKhachHang.ValueMember = "ID";
                cboKhachHang.DisplayMember = "HoVaTen";

                if (id == 0 && !moTuDatVe)
                    cboKhachHang.SelectedIndex = -1;
            }
        }

        private void TaiHoaDonCanSua()
        {
            var hoaDon = context.HoaDon
                .AsNoTracking()
                .SingleOrDefault(r => r.ID == id);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (LaKhachHang() && khachHangIDDangNhap > 0 && hoaDon.KhachHangID != khachHangIDDangNhap)
            {
                MessageBox.Show("Bạn không có quyền xem hóa đơn này.", "Phân quyền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            if (hoaDon.NhanVienID.HasValue && hoaDon.NhanVienID.Value > 0)
                cboNhanVien.SelectedValue = hoaDon.NhanVienID.Value;
            else
                cboNhanVien.SelectedIndex = -1;

            cboKhachHang.SelectedValue = hoaDon.KhachHangID;
            txtGhiChuHoaDon.Text = hoaDon.GhiChu ?? "";

            var dsChiTiet = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(r => r.HoaDonID == id)
                .Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    VeID = r.VeID,
                    TenSuKien = r.Ve.SuKien.TenSuKien,
                    TenSan = r.Ve.Ghe.KhuVuc.SanVanDong.TenSan,
                    ViTriGhe = r.Ve.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + r.Ve.Ghe.SoGhe,
                    SoLuongBan = 1,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = r.DonGiaBan
                })
                .ToList();

            hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(dsChiTiet);
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void BatTatChucNang()
        {
            bool coDuLieu = hoaDonChiTiet.Count > 0;

            if (LaAdmin())
            {
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            if (moTuDatVe)
            {
                btnLuuHoaDon.Enabled = coDuLieu;
                btnXoa.Enabled = coDuLieu;
                return;
            }

            btnLuuHoaDon.Enabled = false;
            btnXoa.Enabled = coDuLieu;
        }

        private void CapNhatTongTienTamTinh()
        {
            int tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            if (id == 0)
                Text = $"Hóa đơn chi tiết - Tạm tính: {tongTien:N0}";
            else
                Text = $"Hóa đơn chi tiết - Tổng tiền: {tongTien:N0}";
        }

        private void LamMoiSauThayDoiChiTiet()
        {
            BatTatChucNang();
            ApDungPhanQuyen();
            CapNhatTongTienTamTinh();
            dataGridView.Refresh();
        }

        private void XoaChiTietTamKhiMoTuDatVe()
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.CurrentRow.Cells["VeID"]?.Value == null)
            {
                MessageBox.Show("Không lấy được mã vé cần xóa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa vé này khỏi danh sách?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int maVe = Convert.ToInt32(dataGridView.CurrentRow.Cells["VeID"].Value);
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.VeID == maVe);

            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
                LamMoiSauThayDoiChiTiet();
            }
        }

        private void XoaChiTietDaLuu()
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Không xác định được hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView.CurrentRow.Cells["ID"]?.Value == null ||
                dataGridView.CurrentRow.Cells["VeID"]?.Value == null)
            {
                MessageBox.Show("Không lấy được dữ liệu chi tiết hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int chiTietID = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            int veID = Convert.ToInt32(dataGridView.CurrentRow.Cells["VeID"].Value);

            var hoaDon = context.HoaDon.FirstOrDefault(x => x.ID == id);
            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CoTheSuaHoaDon(hoaDon))
            {
                MessageBox.Show("Bạn không có quyền xóa vé trong hóa đơn này.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa vé này khỏi hóa đơn không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var ct = context.HoaDon_ChiTiet.FirstOrDefault(x => x.ID == chiTietID);
                if (ct == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ve = context.Ve.FirstOrDefault(x => x.ID == veID);
                if (ve != null)
                {
                    ve.TrangThai = "Còn trống";
                }

                context.HoaDon_ChiTiet.Remove(ct);
                context.SaveChanges();

                var dsConLai = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.HoaDonID == id)
                    .ToList();

                if (dsConLai.Count == 0)
                {
                    var hd = context.HoaDon.FirstOrDefault(x => x.ID == id);
                    if (hd != null)
                    {
                        context.HoaDon.Remove(hd);
                        context.SaveChanges();
                    }

                    DaXoaHoaDon = true;

                    MessageBox.Show("Đã xóa vé cuối cùng. Hóa đơn đã được xóa.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                    return;
                }

                var dsChiTiet = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Where(r => r.HoaDonID == id)
                    .Select(r => new DanhSachHoaDon_ChiTiet
                    {
                        ID = r.ID,
                        HoaDonID = r.HoaDonID,
                        VeID = r.VeID,
                        TenSuKien = r.Ve.SuKien.TenSuKien,
                        TenSan = r.Ve.Ghe.KhuVuc.SanVanDong.TenSan,
                        ViTriGhe = r.Ve.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + r.Ve.Ghe.SoGhe,
                        SoLuongBan = 1,
                        DonGiaBan = r.DonGiaBan,
                        ThanhTien = r.DonGiaBan
                    })
                    .ToList();

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(dsChiTiet);
                dataGridView.DataSource = hoaDonChiTiet;

                LamMoiSauThayDoiChiTiet();

                MessageBox.Show("Đã xóa vé khỏi hóa đơn thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa vé thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (moTuDatVe)
                XoaChiTietTamKhiMoTuDatVe();
            else
                XoaChiTietDaLuu();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (!moTuDatVe)
            {
                MessageBox.Show("Hóa đơn đã lập chỉ được xem, không được lưu chỉnh sửa tại màn hình này.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được lưu.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboKhachHang.SelectedIndex < 0 || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có vé nào.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nhanVienLapHoaDon = LayNhanVienLapHoaDon();
            if (nhanVienLapHoaDon <= 0 && !LaKhachHang())
            {
                MessageBox.Show("Không xác định được nhân viên lập hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var dsVeDangLuu = hoaDonChiTiet.Select(x => x.VeID).ToList();

                bool coVeBiTrung = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Any(x => dsVeDangLuu.Contains(x.VeID) && x.HoaDonID != id);

                if (coVeBiTrung)
                {
                    MessageBox.Show("Có vé đã được bán bởi hóa đơn khác. Vui lòng tải lại dữ liệu.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (id != 0)
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cần lưu.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!CoTheSuaHoaDon(hd))
                    {
                        MessageBox.Show("Bạn không có quyền sửa hóa đơn này.",
                            "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (LaNhanVien() && nhanVienLapHoaDon > 0)
                        hd.NhanVienID = nhanVienLapHoaDon;

                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text)
                        ? null
                        : txtGhiChuHoaDon.Text.Trim();

                    var dsCu = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(dsCu);

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            VeID = item.VeID,
                            DonGiaBan = item.DonGiaBan
                        });
                    }

                    context.SaveChanges();
                }
                else
                {
                    HoaDon hd = new HoaDon
                    {
                        NhanVienID = LaKhachHang() ? null : nhanVienLapHoaDon,
                        KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                        NgayLap = DateTime.Now,
                        GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text)
                            ? null
                            : txtGhiChuHoaDon.Text.Trim()
                    };

                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = hd.ID,
                            VeID = item.VeID,
                            DonGiaBan = item.DonGiaBan
                        });
                    }

                    context.SaveChanges();
                    id = hd.ID;
                }

                DaLuuThanhCong = true;

                int tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

                MessageBox.Show(
                    $"Đã lưu hóa đơn thành công!\nMã hóa đơn: {id}\nTổng tiền: {tongTien:N0} VNĐ",
                    "Hoàn tất",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("Chưa có hóa đơn để in.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmInHoaDon f = new frmInHoaDon(id);
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (moTuDatVe)
            {
                if (cboKhachHang.SelectedValue != null)
                    KhachHangIDSauKhiSua = Convert.ToInt32(cboKhachHang.SelectedValue);

                GhiChuSauKhiSua = txtGhiChuHoaDon.Text.Trim();
                DanhSachChiTietSauKhiSua = hoaDonChiTiet.ToList();

                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}