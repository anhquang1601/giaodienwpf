namespace WpfApp1.Database
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
        [StringLength(10)]
        public string MaChiTietHD { get; set; }

        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaMon { get; set; }

        public int? SoLuong { get; set; }

        public int? Gia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThucDon ThucDon { get; set; }
    }
}
