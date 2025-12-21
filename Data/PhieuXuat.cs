namespace App_QL_kho.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuat()
        {
            CT_PhieuXuat = new HashSet<CT_PhieuXuat>();
            LichSuNhapXuats = new HashSet<LichSuNhapXuat>();
        }

        [Key]
        public int MaPX { get; set; }

        public DateTime? NgayXuat { get; set; }

        public int? MaND { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuXuat> CT_PhieuXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuNhapXuat> LichSuNhapXuats { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
