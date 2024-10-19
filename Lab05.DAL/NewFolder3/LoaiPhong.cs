namespace Lab05.DAL.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
            CoSoVatChatPhongs = new HashSet<CoSoVatChatPhong>();
            DacTrungPhongs = new HashSet<DacTrungPhong>();
            TienNghiPhongs = new HashSet<TienNghiPhong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiPhong { get; set; }

        public decimal? DienTichPhong { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public int? SoNguoi { get; set; }

        [StringLength(100)]
        public string HinhAnh { get; set; }

        public decimal? GiaPhong { get; set; }

        [StringLength(100)]
        public string TenLoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoSoVatChatPhong> CoSoVatChatPhongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DacTrungPhong> DacTrungPhongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TienNghiPhong> TienNghiPhongs { get; set; }
    }
}
