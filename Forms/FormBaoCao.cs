using App_QL_kho.Data;
using App_QL_kho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace App_QL_kho.Forms
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
            this.Load += FormBaoCao_Load;
            // Tự động cập nhật khi thay đổi thời gian
            dtp_FromDate.ValueChanged += (s, e) => LoadAllStatistics();
            dtp_ToDate.ValueChanged += (s, e) => LoadAllStatistics();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // Mặc định xem tháng hiện tại
            dtp_FromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp_ToDate.Value = DateTime.Now;
            LoadAllStatistics();
        }

        private void LoadAllStatistics()
        {
            using (var db = new Model1())
            {
                DateTime fromDate = dtp_FromDate.Value.Date;
                DateTime toDate = dtp_ToDate.Value.Date.AddDays(1).AddTicks(-1);

                // --- 1. XỬ LÝ DỮ LIỆU THEO THÁNG (Hiển thị từng ngày trong tháng) ---
                var dataTheoNgay = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat >= fromDate && ct.PhieuXuat.NgayXuat <= toDate)
                    .GroupBy(ct => ct.PhieuXuat.NgayXuat.Value.Day)
                    .Select(g => new { Ngay = g.Key, DoanhThu = g.Sum(x => x.SoLuong * (x.SanPham.GiaXuat ?? 0)) })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                UpdateChart(chart_thang, dataTheoNgay.Select(x => x.Ngay.ToString()).ToArray(),
                            dataTheoNgay.Select(x => (double)x.DoanhThu).ToArray(), "Doanh thu theo ngày");

                // --- 2. XỬ LÝ DỮ LIỆU THEO NĂM (Hiển thị từng tháng trong năm) ---
                int currentYear = DateTime.Now.Year;
                var dataTheoThang = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat.Value.Year == currentYear)
                    .GroupBy(ct => ct.PhieuXuat.NgayXuat.Value.Month)
                    .Select(g => new { Thang = g.Key, DoanhThu = g.Sum(x => x.SoLuong * (x.SanPham.GiaXuat ?? 0)) })
                    .OrderBy(x => x.Thang)
                    .ToList();

                UpdateChart(chart_nam, dataTheoThang.Select(x => "T" + x.Thang).ToArray(),
                            dataTheoThang.Select(x => (double)x.DoanhThu).ToArray(), "Doanh thu theo tháng");

                // --- 3. TÍNH TỔNG TIỀN CHO CÁC TEXTBOX ---

                // Tính cho Tháng đang chọn trên DateTimePicker
                decimal tongNhapThang = db.CT_PhieuNhap
                    .Where(ct => ct.PhieuNhap.NgayNhap >= fromDate && ct.PhieuNhap.NgayNhap <= toDate)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaNhap)) ?? 0;

                decimal tongXuatThang = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat >= fromDate && ct.PhieuXuat.NgayXuat <= toDate)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaXuat)) ?? 0;

                // Tính cho cả Năm hiện tại
                decimal tongNhapNam = db.CT_PhieuNhap
                    .Where(ct => ct.PhieuNhap.NgayNhap.Value.Year == currentYear)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaNhap)) ?? 0;

                decimal tongXuatNam = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat.Value.Year == currentYear)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaXuat)) ?? 0;

                // Hiển thị lên TextBox (định dạng tiền tệ VNĐ)
                txt_gianhap_thang.Text = tongNhapThang.ToString("N0") + " đ"; // Giá nhập tháng
                txt_giaban_thang.Text = tongXuatThang.ToString("N0") + " đ"; // Giá bán tháng
                txt_gianhap_nam.Text = tongNhapNam.ToString("N0") + " đ";   // Giá nhập năm
                txt_giaban_nam.Text = tongXuatNam.ToString("N0") + " đ";   // Giá bán năm
            }
        }

        private void UpdateChart(Chart chart, string[] xValues, double[] yValues, string seriesName)
        {
            chart.Series.Clear();
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Column, // Biểu đồ cột
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true // Hiện số trên đầu cột
            };

            for (int i = 0; i < xValues.Length; i++)
            {
                series.Points.AddXY(xValues[i], yValues[i]);
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "Thời gian";
            chart.ChartAreas[0].AxisY.Title = "Số tiền (VNĐ)";
        }

        private void cb_chitietbaocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_chitietbaocao.SelectedIndex == -1) return;

            string selectedItem = cb_chitietbaocao.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Báo cáo theo tháng":
                    using (BaoCao_thang frm = new BaoCao_thang())
                    {
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowDialog();
                    }
                    break;

                case "Báo cáo theo năm":
                    using (BaoCaoNam frm = new BaoCaoNam())
                    {
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowDialog();
                    }
                    break;
            }
            cb_chitietbaocao.SelectedIndex = -1;
        }
    }
}