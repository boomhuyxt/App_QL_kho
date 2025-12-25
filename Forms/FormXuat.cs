using App_QL_kho.Services;
using App_QL_kho.Data;
using App_QL_kho.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace App_QL_kho
{
    public partial class FormXuat : Form
    {
        private CameraQR camera;
        private QR_AND_BAR qrService = new QR_AND_BAR();

        public FormXuat()
        {
            InitializeComponent();
            SetupDataGridView();
            dgv_banxuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_banxuat.SelectionChanged += Dgv_banxuat_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo camera truyền FormXuat hiện tại (this) vào
            camera = new CameraQR(cb_camera, pictureBox, txt_tensanpham, this);
            LoadDataToGrid();
        }
        // Trong file FormXuat.cs
        private void SetupDataGridView()
        {
            dgv_banxuat.AutoGenerateColumns = false; // Tắt tự tạo cột
            Column1.DataPropertyName = "TenSP";
            Column2.DataPropertyName = "SoLuong";
            Column3.DataPropertyName = "GiaXuat";
            Column4.DataPropertyName = "QRCode";
        }

        private void LoadDataToGrid()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Lấy dữ liệu từ bảng SanPham đổ vào Model_PhieuXuat
                    var data = db.SanPhams.Select(s => new Model_PhieuXuat
                    {
                        MaSP = s.MaSP,
                        TenSP = s.TenSP,
                        SoLuong = s.SoLuong,
                        GiaXuat = s.GiaXuat,
                        BarCode = s.BarCode,
                        QRCode = s.QRCode
                    }).ToList();

                    // Đưa dữ liệu vào các cột đã tạo sẵn trong Designer
                    dgv_banxuat.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Hàm xử lý khi camera quét được mã
        public void HandleScannedResult(string code)
        {
            using (var db = new Model1())
            {
                // Tìm sản phẩm trùng với Barcode hoặc QRCode quét được
                var sp = db.SanPhams.FirstOrDefault(s => s.BarCode == code || s.QRCode == code);

                if (sp != null)
                {
                    // Đổ dữ liệu vào các TextBox theo đúng thiết kế của bạn
                    txt_tensanpham.Text = sp.TenSP;
                    txt_sanpham.Text = sp.SoLuong.ToString(); // Số lượng tồn
                    txt_giaban.Text = sp.GiaXuat?.ToString("N0"); // Giá bán

                    // Hiện mã lên PictureBox
                    pictureBox_QR.Image = qrService.GenerateQRCode(sp.QRCode);
                    pictureBox1.Image = qrService.GenerateBarcode(sp.BarCode);

                    // Di chuyển vùng chọn trên Grid đến sản phẩm đó
                    foreach (DataGridViewRow row in dgv_banxuat.Rows)
                    {
                        var item = row.DataBoundItem as Model_PhieuXuat;
                        if (item != null && item.MaSP == sp.MaSP)
                        {
                            row.Selected = true;
                            dgv_banxuat.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            }
        }

        private void Dgv_banxuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_banxuat.SelectedRows.Count > 0)
            {
                var item = dgv_banxuat.SelectedRows[0].DataBoundItem as Model_PhieuXuat;
                if (item != null)
                {
                    txt_tensanpham.Text = item.TenSP;
                    txt_sanpham.Text = item.SoLuong.ToString();
                    txt_giaban.Text = item.GiaXuat?.ToString("N0");

                    if (!string.IsNullOrEmpty(item.QRCode))
                        pictureBox_QR.Image = qrService.GenerateQRCode(item.QRCode);
                    if (!string.IsNullOrEmpty(item.BarCode))
                        pictureBox1.Image = qrService.GenerateBarcode(item.BarCode);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e) => camera.Start();
        private void btnStop_Click(object sender, EventArgs e) => camera.Stop();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => camera.Stop();
    }
}