using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QL_kho.Models
{
    public class BaoCaoTong
    {
        // Tên sản phẩm lấy từ bảng SanPham
        public string TenSP { get; set; }

        // Số lượng tồn kho hiện tại hoặc số lượng giao dịch
        public int SoLuong { get; set; }

        // Giá nhập của sản phẩm
        public decimal? GiaNhap { get; set; }

        // Giá xuất (giá bán) của sản phẩm
        public decimal? GiaXuat { get; set; }

        public decimal? ThanhTienNhap => (GiaNhap ?? 0) * SoLuong;
        public decimal? ThanhTienXuat => (GiaXuat ?? 0) * SoLuong;
        public decimal? LoiNhuanDuKien => ThanhTienXuat - ThanhTienNhap;
    }
}
