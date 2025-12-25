using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QL_kho.Models
{
    public class Model_PhieuXuat
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal? GiaXuat { get; set; }
        public string BarCode { get; set; }
        public string QRCode { get; set; }
    }
}
