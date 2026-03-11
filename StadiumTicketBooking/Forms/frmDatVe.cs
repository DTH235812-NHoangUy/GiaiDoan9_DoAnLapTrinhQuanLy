using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDatVe : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        private class VeChonTam
        {
            public int VeID { get; set; }
            public string TenSuKien { get; set; } = string.Empty;
            public string SoGhe { get; set; } = string.Empty;
            public string TenKhuVuc { get; set; } = string.Empty;
            public int GiaVe { get; set; }
        }

        private readonly List<VeChonTam> gioVe = new List<VeChonTam>();

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void CaiDatNut(KryptonButton btn, Image icon, string text)
        {
            btn.Values.Image = icon;
            btn.Values.Text = text;
        }

        private void CaiDatIconNut()
        {
            CaiDatNut(btnTaoMoi, Properties.Resources.add_24, "Tạo mới");
            CaiDatNut(btnThanhToan, Properties.Resources.save_24, "Thanh toán");
            CaiDatNut(btnHuyDon, Properties.Resources.cancel_24, "Hủy đơn");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnChonVe, Properties.Resources.add_24, "Chọn vé");
            CaiDatNut(btnBoVe, Properties.Resources.delete_24, "Bỏ vé");
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiKhachHang();
            TaiSuKien();
            TaoMoiDon();
        }

        private void TaiKhachHang()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";
        }

        private void TaiSuKien()
        {
            var dsSuKien = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenSuKien + " - " + x.SanVanDong.TenSan
                })
                .ToList();

            cboSuKien.DataSource = dsSuKien;
            cboSuKien.DisplayMember = "TenHienThi";
            cboSuKien.ValueMember = "ID";
        }

        private void TaoMoiDon()
        {
            gioVe.Clear();
            txtMaHoaDonTam.Text = "HD-TAM-" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            dtpNgayLap.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;
            CapNhatGridVeDaChon();
            CapNhatTongTien();
            TaiVeTrong();
        }

        private void TaiVeTrong()
        {
            dgvVeTrong.AutoGenerateColumns = false;

            if (cboSuKien.SelectedValue == null)
            {
                dgvVeTrong.DataSource = null;
                return;
            }

            int suKienId;
            if (!int.TryParse(cboSuKien.SelectedValue.ToString(), out suKienId))
            {
                dgvVeTrong.DataSource = null;
                return;
            }

            var dsDaChon = gioVe.Select(x => x.VeID).ToList();

            var listVeTrong = context.Ve
                .Where(x => x.SuKienID == suKienId && x.TrangThai == "Trống")
                .Select(x => new
                {
                    x.ID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.Ghe.KhuVuc.SanVanDong.TenSan,
                    x.GiaVe,
                    x.TrangThai
                })
                .ToList()
                .Where(x => !dsDaChon.Contains(x.ID))
                .ToList();

            dgvVeTrong.DataSource = null;
            dgvVeTrong.DataSource = listVeTrong;
        }

        private void CapNhatGridVeDaChon()
        {
            dgvVeDaChon.AutoGenerateColumns = false;
            dgvVeDaChon.DataSource = null;
            dgvVeDaChon.DataSource = gioVe
                .Select(x => new
                {
                    VeID = x.VeID,
                    x.TenSuKien,
                    x.SoGhe,
                    x.TenKhuVuc,
                    GiaVe = x.GiaVe
                })
                .ToList();
        }

        private void CapNhatTongTien()
        {
            txtTongTien.Text = gioVe.Sum(x => x.GiaVe).ToString("N0");
        }

        private void cboSuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiVeTrong();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            if (dgvVeTrong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int veId;
            if (!int.TryParse(dgvVeTrong.CurrentRow.Cells["colVeID"].Value?.ToString(), out veId))
            {
                MessageBox.Show("Không xác định được vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gioVe.Any(x => x.VeID == veId))
            {
                MessageBox.Show("Vé này đã được chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeChonTam ve = new VeChonTam
            {
                VeID = veId,
                TenSuKien = dgvVeTrong.CurrentRow.Cells["colTenSuKien"].Value?.ToString() ?? "",
                SoGhe = dgvVeTrong.CurrentRow.Cells["colSoGhe"].Value?.ToString() ?? "",
                TenKhuVuc = dgvVeTrong.CurrentRow.Cells["colTenKhuVuc"].Value?.ToString() ?? "",
                GiaVe = Convert.ToInt32(dgvVeTrong.CurrentRow.Cells["colGiaVe"].Value ?? 0)
            };

            gioVe.Add(ve);
            CapNhatGridVeDaChon();
            CapNhatTongTien();
            TaiVeTrong();
        }

        private void btnBoVe_Click(object sender, EventArgs e)
        {
            if (dgvVeDaChon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần bỏ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int veId;
            if (!int.TryParse(dgvVeDaChon.CurrentRow.Cells["colVeIDDaChon"].Value?.ToString(), out veId))
            {
                MessageBox.Show("Không xác định được vé cần bỏ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = gioVe.FirstOrDefault(x => x.VeID == veId);
            if (item != null)
            {
                gioVe.Remove(item);
                CapNhatGridVeDaChon();
                CapNhatTongTien();
                TaiVeTrong();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiDon();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đơn đang chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TaoMoiDon();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKhachHang.Focus();
                return;
            }

            if (gioVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var nhanVien = context.NhanVien.FirstOrDefault();
                if (nhanVien == null)
                {
                    MessageBox.Show("Chưa có nhân viên nào trong hệ thống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HoaDon hoaDon = new HoaDon
                {
                    NhanVienID = nhanVien.ID,
                    KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                    NgayLap = dtpNgayLap.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                context.HoaDon.Add(hoaDon);
                context.SaveChanges();

                foreach (var item in gioVe)
                {
                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                    {
                        HoaDonID = hoaDon.ID,
                        VeID = item.VeID,
                        DonGiaBan = item.GiaVe
                    };
                    context.HoaDon_ChiTiet.Add(ct);

                    var ve = context.Ve.Find(item.VeID);
                    if (ve != null)
                    {
                        ve.TrangThai = "Đã bán";
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Thanh toán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaoMoiDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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