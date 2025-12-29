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
        // Danh sách gốc để phục vụ việc lọc và tìm kiếm
        private List<PhanQuyenNguoiDung> danhSachGoc = new List<PhanQuyenNguoiDung>();

        public FormNguoiDung()
        {
            InitializeComponent();
            // Đăng ký các sự kiện
            this.Load += FormNguoiDung_Load;
            this.txt_timkiemTen.TextChanged += Txt_timkiemTen_TextChanged;

            // Đăng ký sự kiện cho các RadioButton
            ADMIN.CheckedChanged += RadioButton_CheckedChanged;
            QUANLY.CheckedChanged += RadioButton_CheckedChanged;
            NHANVIEN.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDung();
        }

        // 1. Truyền dữ liệu từ model PhanQuyenNguoiDung vào dgv_nguoidung
        private void LoadDataNguoiDung()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Thêm .AsNoTracking() để bỏ qua bộ nhớ đệm, lấy dữ liệu vừa cập nhật
                    var rawData = db.NguoiDungs.AsNoTracking().Select(nd => new
                    {
                        nd.TenDangNhap,
                        nd.Email,
                        nd.NgayTao,
                        nd.TrangThai,
                        TenVaiTroes = nd.VaiTroes.Select(v => v.TenVaiTro)
                    }).ToList();

                    danhSachGoc = rawData.Select(x => new PhanQuyenNguoiDung
                    {
                        TenNguoiDung = x.TenDangNhap,
                        Email = x.Email,
                        NgayTao = x.NgayTao,
                        TrangThai = x.TrangThai,
                        VaiTro = string.Join(", ", x.TenVaiTroes)
                    }).ToList();

                    HienThiLenDgv(danhSachGoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void HienThiLenDgv(List<PhanQuyenNguoiDung> ds)
        {
            dgv_nguoidung.Rows.Clear();
            int stt = 1;
            foreach (var item in ds)
            {
                // Xác định văn bản cho cột HIỆN TRẠNG
                string statusText = (item.TrangThai == true) ? "Hoạt động" : "Đã chặn";

                // Thêm hàng theo ĐÚNG THỨ TỰ CỘT: 
                // 1. STT | 2. HỌ TÊN | 3. EMAIL | 4. NGÀY TẠO | 5. VAI TRÒ | 6. HIỆN TRẠNG
                dgv_nguoidung.Rows.Add(
                    stt++,                             // STT
                    item.TenNguoiDung,                 // HỌ TÊN
                    item.Email,                        // EMAIL
                    item.NgayTao?.ToString("dd/MM/yyyy"), // NGÀY TẠO
                    item.VaiTro,                       // VAI TRÒ
                    statusText                         // HIỆN TRẠNG
                );
            }
        }

        // 2. Chức năng tìm kiếm tương đối theo tên (txt_timkiemTen)
        private void Txt_timkiemTen_TextChanged(object sender, EventArgs e)
        {
            ThucHienLocTongHop();
        }

        // 3. Chức năng lọc theo RadioButton (ADMIN, QUANLY, NHANVIEN)
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ThucHienLocTongHop();
            }
        }

        // Hàm bổ trợ để kết hợp cả Tìm kiếm và Lọc RadioButton
        private void ThucHienLocTongHop()
        {
            string keyword = txt_timkiemTen.Text.ToLower().Trim();
            var filtered = danhSachGoc.AsEnumerable();

            // Lọc theo tên (tương đối)
            if (!string.IsNullOrEmpty(keyword))
            {
                filtered = filtered.Where(x => x.TenNguoiDung.ToLower().Contains(keyword));
            }

            // Lọc theo RadioButton quyền
            if (ADMIN.Checked) filtered = filtered.Where(x => x.VaiTro.Contains("ADMIN"));
            else if (QUANLY.Checked) filtered = filtered.Where(x => x.VaiTro.Contains("QUẢN LÝ"));
            else if (NHANVIEN.Checked) filtered = filtered.Where(x => x.VaiTro.Contains("NHÂN VIÊN"));

            HienThiLenDgv(filtered.ToList());
        }


        // 5. Chức năng btn_chan chuyển trạng thái thành "Đã chặn"
        private void btn_chan_Click(object sender, EventArgs e)
        {

            if (dgv_nguoidung.CurrentRow == null) return;

            // Lấy tên đăng nhập từ cột HỌ TÊN (Index 1) để tìm trong DB
            string tenND = dgv_nguoidung.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn chặn người dùng {tenND}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new Model1())
                    {
                        var user = db.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == tenND);
                        if (user != null)
                        {
                            user.TrangThai = false;
                            db.SaveChanges(); // Lưu vào SQL

                            // QUAN TRỌNG: Cập nhật lại Grid ngay lập tức
                            LoadDataNguoiDung();
                            MessageBox.Show($"Đã chặn thành công người dùng: {tenND}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_nguoidung.CurrentRow != null)
            {
                // Lấy tên đăng nhập ở cột Index 1
                string tenND = dgv_nguoidung.CurrentRow.Cells[1].Value.ToString();

                // Sử dụng khối using để đảm bảo form con được giải phóng sau khi đóng
                using (FormCapNhatThongTin frm = new FormCapNhatThongTin(tenND))
                {
                    // QUAN TRỌNG: Chỉ Load lại dữ liệu khi nút Cập nhật ở Form con trả về OK
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataNguoiDung(); // Hàm này phải lấy được dữ liệu mới nhất
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!");
            }
        }
    }
}