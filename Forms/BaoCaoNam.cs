using App_QL_kho.Data;
using App_QL_kho.Models;
using App_QL_kho.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class BaoCaoNam : Form
    {
        // Danh sách lưu trữ dữ liệu gốc để phục vụ tìm kiếm tương đối
        private List<BaoCaoTong> originalData = new List<BaoCaoTong>();

        public BaoCaoNam()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += BaoCaoNam_Load;
            this.txt_TimKiem.TextChanged += Txt_TimKiem_TextChanged;
            this.cb_xuat.SelectedIndexChanged += Cb_xuat_SelectedIndexChanged;

            // Thiết lập các ô TextBox chỉ đọc (Read-only)
            txt_tongDanhThu.ReadOnly = true;
            txt_SoluongBanRa.ReadOnly = true;
            txt_SanPhamBanChay.ReadOnly = true;
            txt_SoluongConTon.ReadOnly = true;
        }

        private void BaoCaoNam_Load(object sender, EventArgs e)
        {
            LoadComboBoxExport();
            LoadDataBaoCaoNam();
        }

        private void LoadComboBoxExport()
        {
            cb_xuat.Items.Clear();
            cb_xuat.Items.Add("-- Chọn định dạng xuất --");
            cb_xuat.Items.Add("Excel");
            cb_xuat.Items.Add("PDF");
            cb_xuat.Items.Add("Word");
            cb_xuat.SelectedIndex = 0;
        }

        private void LoadDataBaoCaoNam()
        {
            try
            {
                using (var db = new Model1()) //
                {
                    int currentYear = DateTime.Now.Year;

                    // 1. Lấy dữ liệu cho dgv_baocao: Gom nhóm theo sản phẩm trong năm hiện tại
                    originalData = db.SanPhams.Select(sp => new BaoCaoTong
                    {
                        TenSP = sp.TenSP,
                        // Tổng số lượng bán ra trong năm hiện tại
                        SoLuong = sp.CT_PhieuXuat
                                    .Where(x => x.PhieuXuat.NgayXuat.Value.Year == currentYear)
                                    .Sum(x => (int?)x.SoLuong) ?? 0,
                        GiaNhap = sp.GiaNhap,
                        GiaXuat = sp.GiaXuat
                    }).Where(x => x.SoLuong > 0).ToList(); // Chỉ hiện sản phẩm có phát sinh giao dịch trong năm

                    DisplayDataToGrid(originalData);

                    // 2. Tính toán các ô thống kê báo cáo cho cả Năm

                    // Tổng doanh thu năm (Số lượng xuất * Giá xuất)
                    decimal tongDoanhThuNam = db.CT_PhieuXuat
                        .Where(x => x.PhieuXuat.NgayXuat.Value.Year == currentYear)
                        .Sum(x => (decimal?)x.SoLuong * (x.SanPham.GiaXuat ?? 0)) ?? 0;
                    txt_tongDanhThu.Text = tongDoanhThuNam.ToString("N0") + " VNĐ";

                    // Tổng số lượng bán ra trong năm
                    int tongBanNam = db.CT_PhieuXuat
                        .Where(x => x.PhieuXuat.NgayXuat.Value.Year == currentYear)
                        .Sum(x => (int?)x.SoLuong) ?? 0;
                    txt_SoluongBanRa.Text = tongBanNam.ToString("N0");

                    // Sản phẩm bán chạy nhất trong năm
                    var topSPNam = db.CT_PhieuXuat
                        .Where(x => x.PhieuXuat.NgayXuat.Value.Year == currentYear)
                        .GroupBy(x => x.SanPham.TenSP)
                        .Select(g => new { Ten = g.Key, Tong = g.Sum(x => x.SoLuong) })
                        .OrderByDescending(x => x.Tong)
                        .FirstOrDefault();
                    txt_SanPhamBanChay.Text = topSPNam != null ? topSPNam.Ten : "Không có dữ liệu năm";

                    // Tổng số lượng còn tồn kho hiện tại (giữ nguyên theo kho thực tế)
                    int tongTonHienTai = db.SanPhams.Sum(x => (int?)x.SoLuong) ?? 0;
                    txt_SoluongConTon.Text = tongTonHienTai.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu báo cáo năm: " + ex.Message);
            }
        }

        private void DisplayDataToGrid(List<BaoCaoTong> data)
        {
            dgv_baocao.Rows.Clear();
            int stt = 1;
            foreach (var item in data)
            {
                dgv_baocao.Rows.Add(stt++, item.TenSP, item.SoLuong, item.GiaXuat?.ToString("N0"));
            }
        }

        // --- Thuật toán tìm kiếm tương đối theo tên sản phẩm ---
        private void Txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                DisplayDataToGrid(originalData);
            }
            else
            {
                var filtered = originalData
                    .Where(x => x.TenSP.ToLower().Contains(keyword))
                    .ToList();
                DisplayDataToGrid(filtered);
            }
        }

        // --- Xử lý xuất file tương tự BaoCao_thang ---
        private void Cb_xuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_xuat.SelectedIndex <= 0 || dgv_baocao.Rows.Count == 0) return;

            string selectedType = cb_xuat.SelectedItem.ToString();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "BaoCao_Nam_" + DateTime.Now.Year;
                try
                {
                    if (selectedType == "Excel")
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportService.ExportToExcel(dgv_baocao, sfd.FileName);
                    }
                    else if (selectedType == "PDF")
                    {
                        sfd.Filter = "PDF File|*.pdf";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportService.ExportToPDF(dgv_baocao, sfd.FileName);
                    }
                    else if (selectedType == "Word")
                    {
                        sfd.Filter = "Word Document|*.docx";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportService.ExportToWord(dgv_baocao, sfd.FileName);
                    }

                    if (!string.IsNullOrEmpty(sfd.FileName))
                        MessageBox.Show("Xuất báo cáo năm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message);
                }
                finally
                {
                    cb_xuat.SelectedIndex = 0;
                }
            }
        }
    }
}