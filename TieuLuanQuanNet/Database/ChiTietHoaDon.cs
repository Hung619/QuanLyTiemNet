namespace TieuLuanQuanNet.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoCTHD { get; set; }

        public int? MaHoaDon { get; set; }

        public int? MaDichVu { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
