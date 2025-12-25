namespace App_QL_kho.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CT_PhieuNhap = new HashSet<CT_PhieuNhap>();
            CT_PhieuXuat = new HashSet<CT_PhieuXuat>();
            LichSuNhapXuats = new HashSet<LichSuNhapXuat>();
        }

        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(150)]
        public string TenSP { get; set; }

        public int MaNhom { get; set; }

        public int SoLuong { get; set; }

        public decimal? GiaNhap { get; set; }

        public decimal? GiaXuat { get; set; }

        [Required]
        [StringLength(100)]
        public string BarCode { get; set; }

        [Required]
        [StringLength(255)]
        public string QRCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuNhap> CT_PhieuNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuXuat> CT_PhieuXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuNhapXuat> LichSuNhapXuats { get; set; }

        public virtual NhomSanPham NhomSanPham { get; set; }

        public virtual TonKho TonKho { get; set; }
    }
}
