namespace Lab05.DAL.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int? MaPhong { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public decimal? TraTruoc { get; set; }

        public decimal? GiamTru { get; set; }

        public decimal? PhuThu { get; set; }

        [StringLength(100)]
        public string HinhThucTra { get; set; }

        public decimal? TongTienPhong { get; set; }

        public decimal? TongTienDichVu { get; set; }

        public decimal? ThanhTien { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
