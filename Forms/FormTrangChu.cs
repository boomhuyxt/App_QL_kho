using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using App_QL_kho.Data;
using App_QL_kho.Models;

namespace App_QL_kho
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
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
            FilterData(); 
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
                    // Lấy toàn bộ danh sách sản phẩm làm gốc
                    var query = db.SanPhams.AsQueryable();

                    // 1. Lọc theo tên sản phẩm (nếu có nhập)
                    if (!string.IsNullOrWhiteSpace(txt_sanPham.Text))
                    {
                        string search = txt_sanPham.Text.ToLower();
                        query = query.Where(x => x.TenSP.ToLower().Contains(search));
                    }

                    // 2. Lọc theo nhóm sản phẩm (nếu chọn nhóm cụ thể)
                    if (cmb_nhomSP.SelectedValue != null && (int)cmb_nhomSP.SelectedValue != -1)
                    {
                        int maNhom = (int)cmb_nhomSP.SelectedValue;
                        query = query.Where(x => x.MaNhom == maNhom);
                    }

                    // Thực thi truy vấn và chuyển đổi sang Model hiển thị
                    var resultList = query.ToList()
                                         .Select((x, index) => new Model_TrangChu
                                         {
                                             Stt = index + 1,
                                             MaSP = x.MaSP,
                                             // Lấy tên nhóm từ navigation property
                                             TenNhom = x.NhomSanPham?.TenNhom ?? "Chưa phân nhóm",
                                             TenSP = x.TenSP,
                                             TonKho = x.SoLuong,
                                             GiaBan = x.GiaXuat,
                                             // Vẫn lấy ngày nhập mới nhất để tham khảo nhưng không dùng để lọc mất sản phẩm
                                             NgayNhapGanNhat = db.CT_PhieuNhap
                                                                 .Where(ct => ct.MaSP == x.MaSP)
                                                                 .Max(ct => (DateTime?)ct.PhieuNhap.NgayNhap)
                                         }).ToList();

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