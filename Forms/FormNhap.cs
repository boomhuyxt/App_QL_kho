using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using App_QL_kho.Data;
using App_QL_kho.Services;

namespace App_QL_kho.Forms
{
    public partial class FormNhap : Form
    {
        private QR_AND_BAR qrService = new QR_AND_BAR();

        public FormNhap()
        {
            InitializeComponent();
            LoadNhomSanPham();
            // Đảm bảo tên nút trong designer là btnNhap
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);

            // Cấu hình DataGridView nếu bạn chưa tạo cột trong Designer
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            if (dgv_nhapdonhang.ColumnCount == 0)
            {
                dgv_nhapdonhang.Columns.Add("TenSP", "Tên Sản Phẩm");
                dgv_nhapdonhang.Columns.Add("Nhom", "Nhóm");
                dgv_nhapdonhang.Columns.Add("SL", "Số Lượng");
                dgv_nhapdonhang.Columns.Add("GiaN", "Giá Nhập");
                dgv_nhapdonhang.Columns.Add("GiaX", "Giá Xuất");
            }
        }

        private void LoadNhomSanPham()
        {
            try
            {
                using (var db = new Model1())
                {
                    var nhoms = db.NhomSanPhams.ToList();
                    cb_nhomsanpham.DataSource = nhoms;
                    cb_nhomsanpham.DisplayMember = "TenNhom";
                    cb_nhomsanpham.ValueMember = "MaNhom";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhóm: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txt_tensanpham.Clear();
            txt_soluong.Clear();
            txt_gianhap.Clear();
            txt_giaxuat.Clear();
            if (cb_nhomsanpham.Items.Count > 0) cb_nhomsanpham.SelectedIndex = 0;

            if (pictureBoxQR.Image != null) { pictureBoxQR.Image.Dispose(); pictureBoxQR.Image = null; }
            if (pictureBoxBarCord.Image != null) { pictureBoxBarCord.Image.Dispose(); pictureBoxBarCord.Image = null; }

            txt_tensanpham.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txt_tensanpham.Text) || cb_nhomsanpham.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập tên và chọn nhóm sản phẩm!");
                    return;
                }

                // Tạo nội dung mã
                string qrContent = "QR" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string barContent = qrService.RemoveVietnameseDiacritics(txt_tensanpham.Text.Trim());

                // --- PHẦN SỬA LỖI: HIỂN THỊ LÊN GIAO DIỆN ---
                Bitmap bmpQR = qrService.GenerateQRCode(qrContent);
                Bitmap bmpBar = qrService.GenerateBarcode(barContent);

                pictureBoxQR.Image = bmpQR;        // Hiển thị QR Code
                pictureBoxBarCord.Image = bmpBar;  // Hiển thị Barcode
                                                   // ------------------------------------------

                // Lưu hình ảnh vào thư mục
                qrService.SaveImage(bmpQR, "QR_" + qrContent);
                qrService.SaveImage(bmpBar, "BAR_" + barContent);

                using (var db = new Model1())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            // 2. Khởi tạo Sản phẩm
                            var sp = new SanPham
                            {
                                TenSP = txt_tensanpham.Text.Trim(),
                                MaNhom = (int)cb_nhomsanpham.SelectedValue,
                                SoLuong = int.Parse(txt_soluong.Text),
                                GiaNhap = decimal.Parse(txt_gianhap.Text),
                                GiaXuat = decimal.Parse(txt_giaxuat.Text),
                                BarCode = barContent,
                                QRCode = qrContent
                            };

                            db.SanPhams.Add(sp);
                            db.SaveChanges();

                            // 3. Cập nhật Tồn Kho
                            var tk = new TonKho { MaSP = sp.MaSP, SoLuong = sp.SoLuong };
                            db.TonKhoes.Add(tk);

                            // 4. Tạo Phiếu Nhập
                            var pn = new PhieuNhap { NgayNhap = DateTime.Now, GhiChu = "Nhập từ Form" };
                            db.PhieuNhaps.Add(pn);
                            db.SaveChanges();

                            // 5. Chi Tiết Phiếu Nhập
                            var ctpn = new CT_PhieuNhap { MaPN = pn.MaPN, MaSP = sp.MaSP, SoLuong = sp.SoLuong };
                            db.CT_PhieuNhap.Add(ctpn);

                            db.SaveChanges();
                            dbContextTransaction.Commit();

                            // 6. Cập nhật giao diện DataGridView
                            dgv_nhapdonhang.Rows.Add(sp.TenSP, cb_nhomsanpham.Text, sp.SoLuong, sp.GiaNhap, sp.GiaXuat);

                            MessageBox.Show("Nhập hàng thành công!");

                            // Lưu ý: Nếu bạn gọi ClearInputs() ngay lập tức, hình ảnh sẽ bị xóa mất.
                            // Bạn có thể comment dòng dưới đây nếu muốn xem QR sau khi nhập xong.
                            // ClearInputs(); 
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                            MessageBox.Show("Lỗi lưu DB: " + errorMsg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}