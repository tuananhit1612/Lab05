namespace Lab05.DAL.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSuaChua")]
    public partial class ChiTietSuaChua
    {
        [Key]
        public int MaSuaChua { get; set; }

        public int? MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public int? MaLoaiPhong { get; set; }

        public TimeSpan? ThoiGianBatDau { get; set; }

        public TimeSpan? ThoiGianKetThuc { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public decimal? ChiPhi { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
