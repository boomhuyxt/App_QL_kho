using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QL_kho.Models
{
    public class PhanQuyenNguoiDung
    {
        // Lấy từ TenDangNhap trong bảng NguoiDung
        public string TenNguoiDung { get; set; }

        // Lấy từ Email trong bảng NguoiDung
        public string Email { get; set; }

        // Lấy từ NgayTao trong bảng NguoiDung
        public DateTime? NgayTao { get; set; }

        // Lấy từ TenVaiTro trong bảng VaiTro
        // Vì một người dùng có thể có nhiều vai trò (ICollection<VaiTro>), 
        // chuỗi này thường dùng để hiển thị danh sách các vai trò cách nhau bởi dấu phẩy.
        public string VaiTro { get; set; }

        // Trạng thái hoạt động (tùy chọn thêm để quản lý)
        public bool? TrangThai { get; set; }
    }
}
