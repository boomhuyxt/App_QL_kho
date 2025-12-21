namespace App_QL_kho.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuNhapXuat")]
    public partial class LichSuNhapXuat
    {
        [Key]
        public int MaLS { get; set; }

        public int MaSP { get; set; }

        public int? MaPN { get; set; }

        public int? MaPX { get; set; }

        public DateTime? Ngay { get; set; }

        [Required]
        [StringLength(10)]
        public string Loai { get; set; }

        public int SoLuong { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
