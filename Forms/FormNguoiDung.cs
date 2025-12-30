using App_QL_kho.Data;
using App_QL_kho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormNguoiDung : Form
    {
        // Danh sách lưu trữ dữ liệu gốc để tìm kiếm và lọc nhanh
        private List<PhanQuyenNguoiDung> danhSachGoc = new List<PhanQuyenNguoiDung>();

        public FormNguoiDung()
        {
            InitializeComponent();

            // Đăng ký các sự kiện hệ thống
            this.Load += FormNguoiDung_Load;
            this.txt_timkiemTen.TextChanged += Txt_timkiemTen_TextChanged;

            // Đăng ký sự kiện lọc cho các RadioButton
            ADMIN.CheckedChanged += RadioButton_CheckedChanged;
            QUANLY.CheckedChanged += RadioButton_CheckedChanged;
            NHANVIEN.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDung();
        }

        private void LoadDataNguoiDung()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Truy vấn Join 3 bảng để lấy danh sách người dùng và các vai trò tương ứng
                    string sql = @"
                SELECT 
                    nd.MaND, 
                    nd.TenDangNhap as TenNguoiDung, 
                    nd.Email, 
                    nd.NgayTao, 
                    nd.TrangThai,
                    STRING_AGG(vt.TenVaiTro, ', ') as TenVaiTro, 
                    MIN(vt.MaVaiTro) as MaVaiTroDauTien
                FROM NguoiDung nd
                LEFT JOIN NguoiDung_VaiTro ndvt ON nd.MaND = ndvt.MaND
                LEFT JOIN VaiTro vt ON ndvt.MaVaiTro = vt.MaVaiTro
                GROUP BY nd.MaND, nd.TenDangNhap, nd.Email, nd.NgayTao, nd.TrangThai";

                    danhSachGoc = db.Database.SqlQuery<PhanQuyenNguoiDung>(sql).ToList();
                    HienThiLenDgv(danhSachGoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        private void HienThiLenDgv(List<PhanQuyenNguoiDung> ds)
        {
            dgv_nguoidung.Rows.Clear();
            int stt = 1;

            foreach (var item in ds)
            {
                string statusText = (item.TrangThai == true) ? "Hoạt động" : "Đã chặn";

                int rowIndex = dgv_nguoidung.Rows.Add(
                    stt++,
                    item.TenNguoiDung,
                    item.Email,
                    item.NgayTao?.ToString("dd/MM/yyyy"),
                    item.TenVaiTro,
                    statusText
                );

                // Kiểm tra trạng thái để đổi màu chữ hàng đó sang Đỏ nếu bị chặn
                if (item.TrangThai == false)
                {
                    dgv_nguoidung.Rows[rowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void Txt_timkiemTen_TextChanged(object sender, EventArgs e)
        {
            ThucHienLocTongHop();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ThucHienLocTongHop();
            }
        }

        private void ThucHienLocTongHop()
        {
            string keyword = txt_timkiemTen.Text.ToLower().Trim();
            var filtered = danhSachGoc.AsEnumerable();

            // 1. Lọc theo từ khóa (Tìm kiếm tương đối trong Tên hoặc Email)
            if (!string.IsNullOrEmpty(keyword))
            {
                filtered = filtered.Where(x =>
                    (x.TenNguoiDung != null && x.TenNguoiDung.ToLower().Contains(keyword)) ||
                    (x.Email != null && x.Email.ToLower().Contains(keyword)));
            }

            // 2. Lọc theo vai trò (RadioButton)
            if (ADMIN.Checked)
                filtered = filtered.Where(x => x.TenVaiTro != null && x.TenVaiTro.ToUpper().Contains("ADMIN"));
            else if (QUANLY.Checked)
                filtered = filtered.Where(x => x.TenVaiTro != null && (x.TenVaiTro.Contains("QUẢN LÝ") || x.TenVaiTro.Contains("QUAN LY")));
            else if (NHANVIEN.Checked)
                filtered = filtered.Where(x => x.TenVaiTro != null && (x.TenVaiTro.Contains("NHÂN VIÊN") || x.TenVaiTro.Contains("NHAN VIEN")));

            HienThiLenDgv(filtered.ToList());
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_nguoidung.CurrentRow != null && dgv_nguoidung.CurrentRow.Cells[1].Value != null)
            {
                string tenND = dgv_nguoidung.CurrentRow.Cells[1].Value.ToString();

                // Sử dụng 'using' để giải phóng tài nguyên Form ngay sau khi dùng
                using (FormCapNhatThongTin frm = new FormCapNhatThongTin(tenND))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataNguoiDung(); // Tải lại dữ liệu mới nhất
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_chan_Click(object sender, EventArgs e)
        {
            if (dgv_nguoidung.CurrentRow == null || dgv_nguoidung.CurrentRow.Cells[1].Value == null) return;

            string tenND = dgv_nguoidung.CurrentRow.Cells[1].Value.ToString();
            string trangThaiHienTai = dgv_nguoidung.CurrentRow.Cells[5].Value.ToString();
            bool trangThaiMoi = (trangThaiHienTai != "Hoạt động");

            string msg = trangThaiMoi ? $"Mở chặn người dùng {tenND}?" : $"Xác nhận chặn người dùng {tenND}?";

            if (MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var user = db.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == tenND);
                        if (user != null)
                        {
                            user.TrangThai = trangThaiMoi;
                            db.SaveChanges();
                            LoadDataNguoiDung(); // Làm mới danh sách
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}