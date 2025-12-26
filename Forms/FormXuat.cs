using App_QL_kho.Services;
using App_QL_kho.Data;
using App_QL_kho.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App_QL_kho
{
    public partial class FormXuat : Form
    {
        private CameraQR camera;
        private QR_AND_BAR qrService = new QR_AND_BAR();
        public string lastScannedCode = ""; // Lưu mã để tránh quét trùng lặp

        public FormXuat()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupTextBoxes();
            this.btn_xuat.Click += btn_xuat_Click;
            dgv_banxuat.SelectionChanged += Dgv_banxuat_SelectionChanged;
        }

        private void SetupDataGridView()
        {
            dgv_banxuat.AutoGenerateColumns = false;
            dgv_banxuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Column1.DataPropertyName = "TenSP";
            Column2.DataPropertyName = "SoLuong";
            Column3.DataPropertyName = "GiaXuat";
            Column4.DataPropertyName = "QRCode";
        }

        private void SetupTextBoxes()
        {
            txt_tensanpham.ReadOnly = true;
            txt_giaban.ReadOnly = true;
            txt_sanpham.ReadOnly = false; // Chỉ cho phép sửa số lượng xuất
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camera = new CameraQR(cb_camera, pictureBox, this);
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            try
            {
                using (var db = new Model1())
                {
                    dgv_banxuat.DataSource = db.SanPhams.Select(s => new Model_PhieuXuat
                    {
                        MaSP = s.MaSP,
                        TenSP = s.TenSP,
                        SoLuong = s.SoLuong,
                        GiaXuat = s.GiaXuat,
                        BarCode = s.BarCode,
                        QRCode = s.QRCode
                    }).ToList();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối: " + ex.Message); }
        }

        // KHI CHỌN DÒNG TRÊN BẢNG THÌ HIỆN QR/BARCODE
        private void Dgv_banxuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_banxuat.SelectedRows.Count > 0)
            {
                var item = dgv_banxuat.SelectedRows[0].DataBoundItem as Model_PhieuXuat;
                if (item != null)
                {
                    txt_tensanpham.Text = item.TenSP;
                    txt_giaban.Text = item.GiaXuat?.ToString("N0");
                    txt_sanpham.Text = "1";
                    txt_sanpham.Tag = item.MaSP;

                    // Hiện ảnh QR và Barcode tương ứng
                    if (pictureBox_QR.Image != null) pictureBox_QR.Image.Dispose();
                    if (pictureBox_barcode.Image != null) pictureBox_barcode.Image.Dispose();
                    pictureBox_QR.Image = qrService.GenerateQRCode(item.QRCode);
                    pictureBox_barcode.Image = qrService.GenerateBarcode(item.BarCode);
                }
            }
        }

        // KHI QUÉT CAMERA THÀNH CÔNG
        public void HandleScannedResult(string code)
        {
            using (var db = new Model1())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.BarCode == code || s.QRCode == code);
                if (sp != null)
                {
                    // Chọn dòng tương ứng trên Grid để kích hoạt SelectionChanged hiện mã
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
                else { lastScannedCode = ""; }
            }
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            if (txt_sanpham.Tag == null) { MessageBox.Show("Chọn sản phẩm!"); return; }
            int maSP = (int)txt_sanpham.Tag;
            if (!int.TryParse(txt_sanpham.Text, out int slXuat) || slXuat <= 0) return;

            using (var db = new Model1())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var sp = db.SanPhams.Find(maSP);
                        if (sp == null || sp.SoLuong < slXuat) { MessageBox.Show("Không đủ hàng!"); return; }

                        sp.SoLuong -= slXuat;
                        var tonKho = db.TonKhoes.Find(maSP);
                        if (tonKho != null) tonKho.SoLuong -= slXuat;

                        var px = new PhieuXuat { NgayXuat = DateTime.Now, GhiChu = "Xuất hàng camera" };
                        db.PhieuXuats.Add(px);
                        db.SaveChanges();

                        db.CT_PhieuXuat.Add(new CT_PhieuXuat { MaPX = px.MaPX, MaSP = maSP, SoLuong = slXuat });
                        db.LichSuNhapXuats.Add(new LichSuNhapXuat { MaSP = maSP, MaPX = px.MaPX, Ngay = DateTime.Now, Loai = "XUẤT", SoLuong = slXuat });

                        db.SaveChanges();
                        trans.Commit();
                        MessageBox.Show("Thành công!");
                        lastScannedCode = ""; LoadDataToGrid();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message));
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e) => camera.Start();
        private void btnStop_Click(object sender, EventArgs e) => camera.Stop();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => camera.Stop();
    }
}