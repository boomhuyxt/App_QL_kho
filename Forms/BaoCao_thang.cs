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
    public partial class BaoCao_thang : Form
    {
        // Danh sách lưu trữ dữ liệu gốc để phục vụ tìm kiếm tương đối
        private List<BaoCaoTong> originalData = new List<BaoCaoTong>();

        public BaoCao_thang()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += BaoCao_thang_Load;
            this.txt_TimKiem.TextChanged += Txt_TimKiem_TextChanged;
            this.cb_xuat.SelectedIndexChanged += Cb_xuat_SelectedIndexChanged;

            // Thiết lập các ô TextBox chỉ đọc (Read-only)
            txt_tongDanhThu.ReadOnly = true;
            txt_SoluongBanRa.ReadOnly = true;
            txt_SanPhamBanChay.ReadOnly = true;
            txt_SoluongConTon.ReadOnly = true;
        }

        private void BaoCao_thang_Load(object sender, EventArgs e)
        {
            LoadComboBoxExport();
            LoadDataBaoCao();
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

        private void LoadDataBaoCao()
        {
            try
            {
                using (var db = new Model1()) //
                {
                    // 1. Lấy dữ liệu cho DataGridView từ Model BaoCaoTong
                    originalData = db.SanPhams.Select(sp => new BaoCaoTong
                    {
                        TenSP = sp.TenSP, //
                        SoLuong = sp.CT_PhieuXuat.Sum(x => (int?)x.SoLuong) ?? 0, //
                        GiaNhap = sp.GiaNhap, //
                        GiaXuat = sp.GiaXuat  //
                    }).ToList();

                    DisplayDataToGrid(originalData);

                    // 2. Tính toán các ô thống kê báo cáo

                    // Tổng doanh thu (Số lượng xuất * Giá xuất)
                    decimal tongDoanhThu = db.CT_PhieuXuat
                        .Sum(x => (decimal?)x.SoLuong * (x.SanPham.GiaXuat ?? 0)) ?? 0;
                    txt_tongDanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                    // Tổng số lượng bán ra
                    int tongBan = db.CT_PhieuXuat.Sum(x => (int?)x.SoLuong) ?? 0;
                    txt_SoluongBanRa.Text = tongBan.ToString("N0");

                    // Sản phẩm bán chạy nhất
                    var topSP = db.CT_PhieuXuat
                        .GroupBy(x => x.SanPham.TenSP)
                        .Select(g => new { Ten = g.Key, Tong = g.Sum(x => x.SoLuong) })
                        .OrderByDescending(x => x.Tong)
                        .FirstOrDefault();
                    txt_SanPhamBanChay.Text = topSP != null ? topSP.Ten : "Chưa có dữ liệu";

                    // Tổng số lượng còn tồn hiện tại
                    int tongTon = db.SanPhams.Sum(x => (int?)x.SoLuong) ?? 0;
                    txt_SoluongConTon.Text = tongTon.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu báo cáo: " + ex.Message);
            }
        }

        private void DisplayDataToGrid(List<BaoCaoTong> data)
        {
            dgv_baocao.Rows.Clear();
            int stt = 1;
            foreach (var item in data)
            {
                // Đổ dữ liệu vào các cột STT, Tên sản phẩm, Số lượng, Giá bán
                dgv_baocao.Rows.Add(stt++, item.TenSP, item.SoLuong, item.GiaXuat?.ToString("N0"));
            }
        }

        // --- Thuật toán tìm kiếm tương đối ---
        private void Txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                DisplayDataToGrid(originalData);
            }
            else
            {
                // Lọc danh sách: Sản phẩm nào chứa từ khóa sẽ được hiển thị
                var filtered = originalData
                    .Where(x => x.TenSP.ToLower().Contains(keyword))
                    .ToList();
                DisplayDataToGrid(filtered);
            }
        }

        // --- Xử lý xuất file với ExportService ---
        private void Cb_xuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_xuat.SelectedIndex <= 0 || dgv_baocao.Rows.Count == 0) return;

            string selectedType = cb_xuat.SelectedItem.ToString();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
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
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
                finally
                {
                    cb_xuat.SelectedIndex = 0; // Đưa combobox về mặc định
                }
            }
        }
    }
}