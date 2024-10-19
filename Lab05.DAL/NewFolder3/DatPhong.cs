namespace Lab05.DAL.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatPhong")]
    public partial class DatPhong
    {
        [Key]
        public int MaDatPhong { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        public int? MaPhong { get; set; }

        public int? TraTruoc { get; set; }

        public int? MaLoaiPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDatPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDi { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
