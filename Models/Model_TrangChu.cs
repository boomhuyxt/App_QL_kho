using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QL_kho.Models
{
    public class Model_TrangChu
    {
        public int Stt { get; set; }
        public int MaSP { get; set; }
        public string TenNhom { get; set; }
        public string TenSP { get; set; }
        public int TonKho { get; set; }
        public decimal? GiaBan { get; set; }
        public DateTime? NgayNhapGanNhat { get; set; }
    }
}
