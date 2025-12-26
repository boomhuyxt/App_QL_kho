using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using App_QL_kho.Data;
using App_QL_kho.Models;

namespace App_QL_kho.Forms
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
            // Đăng ký sự kiện
            this.Load += FormTrangChu_Load;
            this.txt_sanPham.TextChanged += (s, e) => FilterData();
            this.cmb_nhomSP.SelectedIndexChanged += (s, e) => FilterData();
            this.dtp_thoiGian.ValueChanged += (s, e) => FilterData();
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadComboboxNhom();
            FilterData(); // Load dữ liệu mặc định khi mở form
        }

        // Ánh xạ các cột đã thiết kế sẵn trong Designer với dữ liệu Model
        private void SetupDataGridView()
        {
            dgv_trangchu.AutoGenerateColumns = false;
            Column1.DataPropertyName = "Stt";
            Column2.DataPropertyName = "TenNhom";
            Column3.DataPropertyName = "TenSP";
            Column4.DataPropertyName = "TonKho";
            Column5.DataPropertyName = "GiaBan";
        }

        private void LoadComboboxNhom()
        {
            try
            {
                using (var db = new Model1())
                {
                    var listNhom = db.NhomSanPhams.ToList();
                    listNhom.Insert(0, new NhomSanPham { MaNhom = -1, TenNhom = "Tất cả nhóm" });

                    cmb_nhomSP.DataSource = listNhom;
                    cmb_nhomSP.DisplayMember = "TenNhom";
                    cmb_nhomSP.ValueMember = "MaNhom";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load nhóm sản phẩm: " + ex.Message);
            }
        }

        // Hàm chính để lọc và tìm kiếm dữ liệu
        private void FilterData()
        {
            try
            {
                using (var db = new Model1())
                {
                    DateTime selectedDate = dtp_thoiGian.Value.Date;

                    // Truy vấn lấy dữ liệu thô từ Database
                    var query = from sp in db.SanPhams
                                join nhom in db.NhomSanPhams on sp.MaNhom equals nhom.MaNhom
                                select new
                                {
                                    MaSP = sp.MaSP,
                                    TenNhom = nhom.TenNhom,
                                    TenSP = sp.TenSP,
                                    TonKho = sp.SoLuong,
                                    GiaBan = sp.GiaXuat,
                                    // Lấy ngày nhập mới nhất
                                    NgayNhap = db.CT_PhieuNhap
                                                 .Where(ct => ct.MaSP == sp.MaSP)
                                                 .Max(ct => (DateTime?)ct.PhieuNhap.NgayNhap)
                                };

                    // 1. Lọc theo tên sản phẩm
                    if (!string.IsNullOrWhiteSpace(txt_sanPham.Text))
                    {
                        string search = txt_sanPham.Text.ToLower();
                        query = query.Where(x => x.TenSP.ToLower().Contains(search));
                    }

                    // 2. Lọc theo nhóm sản phẩm
                    if (cmb_nhomSP.SelectedValue != null && (int)cmb_nhomSP.SelectedValue != -1)
                    {
                        string tenNhom = cmb_nhomSP.Text;
                        query = query.Where(x => x.TenNhom == tenNhom);
                    }

                    // 3. Lọc theo thời gian
                    query = query.Where(x => x.NgayNhap >= selectedDate);

                    // TÍNH TOÁN STT TẠI ĐÂY
                    var resultList = query.ToList()
                                         .Select((x, index) => new Model_TrangChu
                                         {
                                             Stt = index + 1, // Tự động tăng STT từ 1
                                             MaSP = x.MaSP,
                                             TenNhom = x.TenNhom,
                                             TenSP = x.TenSP,
                                             TonKho = x.TonKho,
                                             GiaBan = x.GiaBan,
                                             NgayNhapGanNhat = x.NgayNhap
                                         }).ToList();

                    // Gán dữ liệu một lần duy nhất
                    dgv_trangchu.DataSource = resultList;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lọc dữ liệu: " + ex.Message);
            }
        }
    }
}
