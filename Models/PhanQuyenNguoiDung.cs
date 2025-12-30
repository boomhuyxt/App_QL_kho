using System;

namespace App_QL_kho.Models
{
    public class PhanQuyenNguoiDung
    {
        public int MaND { get; set; } // Thêm trường này
        public string TenNguoiDung { get; set; }
        public string Email { get; set; }
        public DateTime? NgayTao { get; set; }
        public string VaiTro { get; set; } // Hiển thị chuỗi vai trò
        public string TenVaiTro { get; set; }
        public bool? TrangThai { get; set; }
        public int? MaVaiTroDauTien { get; set; }
    }
}