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
                // Lấy mốc thời gian từ giao diện
                DateTime fromDate = dtp_FromDate.Value.Date;
                DateTime toDate = dtp_ToDate.Value.Date.AddDays(1).AddTicks(-1); // Hết ngày toDate
                int selectedYear = fromDate.Year; // Lấy năm dựa trên ngày bắt đầu người dùng chọn

                // --- 1. XỬ LÝ BIỂU ĐỒ THÁNG (Cột là NGÀY) ---
                // Lấy dữ liệu bán hàng trong khoảng thời gian chọn, nhóm theo NGÀY
                var dataTheoNgay = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat >= fromDate && ct.PhieuXuat.NgayXuat <= toDate)
                    .GroupBy(ct => ct.PhieuXuat.NgayXuat.Value.Day) // Nhóm theo ngày (1, 2, 3...)
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        DoanhThu = g.Sum(x => x.SoLuong * (x.SanPham.GiaXuat ?? 0))
                    })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                // Cập nhật chart_thang: Trục X là Ngày, Trục Y là Doanh thu
                UpdateChart(chart_thang,
                            dataTheoNgay.Select(x => "Ngày " + x.Ngay).ToArray(),
                            dataTheoNgay.Select(x => (double)x.DoanhThu).ToArray(),
                            "Doanh thu theo ngày");


                // --- 2. XỬ LÝ BIỂU ĐỒ NĂM (Cột là THÁNG) ---
                // Lấy dữ liệu của cả NĂM được chọn (dựa trên selectedYear), nhóm theo THÁNG
                var dataTheoThang = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat.Value.Year == selectedYear)
                    .GroupBy(ct => ct.PhieuXuat.NgayXuat.Value.Month) // Nhóm theo tháng (1, 2...12)
                    .Select(g => new
                    {
                        Thang = g.Key,
                        DoanhThu = g.Sum(x => x.SoLuong * (x.SanPham.GiaXuat ?? 0))
                    })
                    .OrderBy(x => x.Thang)
                    .ToList();

                // Cập nhật chart_nam: Trục X là Tháng, Trục Y là Doanh thu
                UpdateChart(chart_nam,
                            dataTheoThang.Select(x => "Tháng " + x.Thang).ToArray(),
                            dataTheoThang.Select(x => (double)x.DoanhThu).ToArray(),
                            $"Doanh thu năm {selectedYear}");


                // --- 3. TÍNH TOÁN SỐ LIỆU TỔNG QUÁT (Hiển thị ra TextBox) ---

                // Tổng nhập/xuất trong khoảng thời gian chọn (theo ngày/tháng đang filter)
                decimal tongNhapThang = db.CT_PhieuNhap
                    .Where(ct => ct.PhieuNhap.NgayNhap >= fromDate && ct.PhieuNhap.NgayNhap <= toDate)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaNhap)) ?? 0;

                decimal tongXuatThang = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat >= fromDate && ct.PhieuXuat.NgayXuat <= toDate)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaXuat)) ?? 0;

                // Tổng nhập/xuất của cả NĂM được chọn
                decimal tongNhapNam = db.CT_PhieuNhap
                    .Where(ct => ct.PhieuNhap.NgayNhap.Value.Year == selectedYear)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaNhap)) ?? 0;

                decimal tongXuatNam = db.CT_PhieuXuat
                    .Where(ct => ct.PhieuXuat.NgayXuat.Value.Year == selectedYear)
                    .Sum(ct => (decimal?)(ct.SoLuong * ct.SanPham.GiaXuat)) ?? 0;

                // Gán giá trị vào TextBox, định dạng tiền tệ
                txt_gianhap_thang.Text = tongNhapThang.ToString("N0") + " đ";
                txt_giaban_thang.Text = tongXuatThang.ToString("N0") + " đ";
                txt_gianhap_nam.Text = tongNhapNam.ToString("N0") + " đ";
                txt_giaban_nam.Text = tongXuatNam.ToString("N0") + " đ";
            }
        }

        private void UpdateChart(Chart chart, string[] xValues, double[] yValues, string seriesName)
        {
            chart.Series.Clear(); // Xóa dữ liệu cũ
            chart.Legends.Clear(); // Xóa chú thích cũ để tránh trùng lặp

            // Tạo Series mới
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Column, // Loại biểu đồ cột
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true // Hiển thị giá trị trên đầu cột
            };

            // Đổ dữ liệu vào Series
            for (int i = 0; i < xValues.Length; i++)
            {
                series.Points.AddXY(xValues[i], yValues[i]);
            }

            // Thêm Series vào Chart
            chart.Series.Add(series);
            chart.Legends.Add(new Legend("Legend1")); // Thêm lại Legend

            // Cấu hình trục
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "Thời gian";
            chart.ChartAreas[0].AxisY.Title = "Số tiền (VNĐ)";
            chart.ChartAreas[0].RecalculateAxesScale(); // Tính toán lại tỉ lệ trục
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