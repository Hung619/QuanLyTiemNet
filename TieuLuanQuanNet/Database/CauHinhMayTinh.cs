namespace TieuLuanQuanNet.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHinhMayTinh")]
    public partial class CauHinhMayTinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauHinhMayTinh()
        {
            DanhSachMayTrams = new HashSet<DanhSachMayTram>();
        }

        [Key]
        [StringLength(50)]
        public string CauHinh { get; set; }

        [Required]
        [StringLength(100)]
        public string CPU { get; set; }

        [Required]
        [StringLength(50)]
        public string RAM { get; set; }

        [Required]
        [StringLength(50)]
        public string HardDrive { get; set; }

        [Required]
        [StringLength(100)]
        public string OperatingSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachMayTram> DanhSachMayTrams { get; set; }
    }
}
