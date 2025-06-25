namespace TieuLuanQuanNet.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachMayTram")]
    public partial class DanhSachMayTram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhSachMayTram()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMayTram { get; set; }

        [StringLength(30)]
        public string TenMay { get; set; }

        [StringLength(50)]
        public string CauHinh { get; set; }

        public int? TrangThai { get; set; }

        public virtual CauHinhMayTinh CauHinhMayTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
