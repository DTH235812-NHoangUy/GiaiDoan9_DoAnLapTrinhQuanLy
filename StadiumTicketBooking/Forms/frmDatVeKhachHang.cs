using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDatVeKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private readonly int khachHangIDDangNhap = 0;
        private readonly string hoVaTenKhachHang = "";

        private class VeChonTam
        {
            public int VeID { get; set; }
            public string TenSuKien { get; set; } = string.Empty;
            public string SoGhe { get; set; } = string.Empty;
            public string TenKhuVuc { get; set; } = string.Empty;
            public string TenSan { get; set; } = string.Empty;
            public int GiaVe { get; set; }
        }

        private readonly List<VeChonTam> gioVe = new List<VeChonTam>();

        public frmDatVeKhachHang()
        {
            InitializeComponent();
        }

        public frmDatVeKhachHang(int khachHangID, string hoVaTen)
        {
            InitializeComponent();
            khachHangIDDangNhap = khachHangID;
            hoVaTenKhachHang = hoVaTen ?? "";
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
            CaiDatNut(btnThanhToan, Properties.Resources.save_24, "Thanh toán");
            CaiDatNut(btnHuyDon, Properties.Resources.cancel_24, "Hủy đơn");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnChonVe, Properties.Resources.add_24, "Chọn vé");
            CaiDatNut(btnBoVe, Properties.Resources.delete_24, "Bỏ vé");
            CaiDatNut(btnHoaDonCuaToi, Properties.Resources.search_24, "Hóa đơn của tôi");
        }

        private void frmDatVeKhachHang_Load(object sender, EventArgs e)
        {
            if (khachHangIDDangNhap <= 0)
            {
                MessageBox.Show("Không xác định được khách hàng đang đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            CaiDatIconNut();
            DinhDangGrid();
            txtKhachHang.Text = hoVaTenKhachHang;
            TaiSuKien();
            LamMoiDonDatVe();
        }

        private void DinhDangGrid()
        {
            dgvVeTrong.AutoGenerateColumns = false;
            dgvVeDaChon.AutoGenerateColumns = false;

            dgvVeTrong.AllowUserToAddRows = false;
            dgvVeTrong.AllowUserToDeleteRows = false;
            dgvVeTrong.MultiSelect = false;
            dgvVeTrong.ReadOnly = true;
            dgvVeTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeTrong.RowHeadersVisible = false;

            dgvVeDaChon.AllowUserToAddRows = false;
            dgvVeDaChon.AllowUserToDeleteRows = false;
            dgvVeDaChon.MultiSelect = false;
            dgvVeDaChon.ReadOnly = true;
            dgvVeDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeDaChon.RowHeadersVisible = false;

            if (dgvVeTrong.Columns["colGiaVe"] != null)
            {
                dgvVeTrong.Columns["colGiaVe"].DefaultCellStyle.Format = "N0";
                dgvVeTrong.Columns["colGiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvVeDaChon.Columns["colGiaVeDaChon"] != null)
            {
                dgvVeDaChon.Columns["colGiaVeDaChon"].DefaultCellStyle.Format = "N0";
                dgvVeDaChon.Columns["colGiaVeDaChon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void TaiSuKien()
        {
            var dsSuKien = context.SuKien
                .AsNoTracking()
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

            if (dsSuKien.Count > 0)
                cboSuKien.SelectedIndex = 0;
            else
                cboSuKien.SelectedIndex = -1;
        }

        private int LaySuKienIdDangChon()
        {
            if (cboSuKien.SelectedValue == null)
                return 0;

            if (cboSuKien.SelectedValue is int id)
                return id;

            int.TryParse(cboSuKien.SelectedValue.ToString(), out id);
            return id;
        }

        private void LamMoiDonDatVe()
        {
            gioVe.Clear();
            dtpNgayLap.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;
            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void TaiVeTrong()
        {
            int suKienId = LaySuKienIdDangChon();
            if (suKienId <= 0)
            {
                dgvVeTrong.DataSource = null;
                return;
            }

            var dsVeIdTrongGio = gioVe.Select(x => x.VeID).ToList();

            var veDaBan = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Select(x => x.VeID)
                .ToList();

            var listVeTrong = context.Ve
                .AsNoTracking()
                .Where(x => x.SuKienID == suKienId
                         && !veDaBan.Contains(x.ID)
                         && !dsVeIdTrongGio.Contains(x.ID))
                .Select(x => new
                {
                    x.ID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.Ghe.KhuVuc.SanVanDong.TenSan,
                    x.GiaVe,
                    TrangThai = "Còn trống"
                })
                .OrderBy(x => x.SoGhe)
                .ToList();

            dgvVeTrong.DataSource = null;
            dgvVeTrong.DataSource = listVeTrong;
            DinhDangGrid();
        }

        private void TaiGioVe()
        {
            var ds = gioVe
                .Select(x => new
                {
                    VeID = x.VeID,
                    TenSuKien = x.TenSuKien,
                    SoGhe = x.SoGhe,
                    TenKhuVuc = x.TenKhuVuc,
                    GiaVe = x.GiaVe
                })
                .ToList();

            dgvVeDaChon.DataSource = null;
            dgvVeDaChon.DataSource = ds;
            DinhDangGrid();
        }

        private void CapNhatTongTien()
        {
            txtTongTien.Text = gioVe.Sum(x => x.GiaVe).ToString("N0");
        }

        private void cboSuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioVe.Clear();
            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            if (dgvVeTrong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVeTrong.CurrentRow.Cells["colVeID"].Value?.ToString(), out int veId))
            {
                MessageBox.Show("Không xác định được vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gioVe.Any(x => x.VeID == veId))
            {
                MessageBox.Show("Vé này đã có trong giỏ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeChonTam ve = new VeChonTam
            {
                VeID = veId,
                TenSuKien = dgvVeTrong.CurrentRow.Cells["colTenSuKien"].Value?.ToString() ?? "",
                SoGhe = dgvVeTrong.CurrentRow.Cells["colSoGhe"].Value?.ToString() ?? "",
                TenKhuVuc = dgvVeTrong.CurrentRow.Cells["colTenKhuVuc"].Value?.ToString() ?? "",
                TenSan = dgvVeTrong.CurrentRow.Cells["colTenSan"].Value?.ToString() ?? "",
                GiaVe = Convert.ToInt32(dgvVeTrong.CurrentRow.Cells["colGiaVe"].Value ?? 0)
            };

            gioVe.Add(ve);
            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void btnBoVe_Click(object sender, EventArgs e)
        {
            if (dgvVeDaChon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần bỏ khỏi giỏ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVeDaChon.CurrentRow.Cells["colVeIDDaChon"].Value?.ToString(), out int veId))
            {
                MessageBox.Show("Không xác định được vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var veTrongGio = gioVe.FirstOrDefault(x => x.VeID == veId);
            if (veTrongGio != null)
            {
                gioVe.Remove(veTrongGio);
                TaiVeTrong();
                TaiGioVe();
                CapNhatTongTien();
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (gioVe.Count == 0 && string.IsNullOrWhiteSpace(txtGhiChu.Text))
            {
                MessageBox.Show("Hiện không có dữ liệu để hủy.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn hủy dữ liệu đang chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LamMoiDonDatVe();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vé để thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dsVeId = gioVe.Select(x => x.VeID).ToList();

            var veDaBan = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(x => dsVeId.Contains(x.VeID))
                .Select(x => x.VeID)
                .ToList();

            if (veDaBan.Count > 0)
            {
                MessageBox.Show("Một hoặc nhiều vé đã được người khác mua trước. Vui lòng tải lại danh sách vé.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TaiVeTrong();
                return;
            }

            if (MessageBox.Show("Xác nhận thanh toán các vé đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            using var trans = context.Database.BeginTransaction();
            try
            {
                HoaDon hd = new HoaDon
                {
                    NhanVienID = null,
                    KhachHangID = khachHangIDDangNhap,
                    NgayLap = dtpNgayLap.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                context.HoaDon.Add(hd);
                context.SaveChanges();

                foreach (var item in gioVe)
                {
                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                    {
                        HoaDonID = hd.ID,
                        VeID = item.VeID,
                        DonGiaBan = item.GiaVe
                    };
                    context.HoaDon_ChiTiet.Add(ct);

                    var ve = context.Ve.Find(item.VeID);
                    if (ve != null)
                    {
                        ve.TrangThai = "Đã bán";
                        context.Ve.Update(ve);
                    }
                }

                context.SaveChanges();
                trans.Commit();

                DialogResult rs = MessageBox.Show(
                    $"Thanh toán thành công.\nMã hóa đơn: {hd.ID}\nTổng tiền: {txtTongTien.Text} VNĐ\n\nBạn có muốn xem chi tiết hóa đơn không?",
                    "Thành công",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (rs == DialogResult.Yes)
                {
                    frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(hd.ID, 0, khachHangIDDangNhap, "KhachHang");
                    f.ShowDialog();
                }

                LamMoiDonDatVe();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDonCuaToi_Click(object sender, EventArgs e)
        {
            using (frmHoaDonKhachHang f = new frmHoaDonKhachHang(khachHangIDDangNhap, hoVaTenKhachHang))
            {
                f.ShowDialog();
            }
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
    }
}