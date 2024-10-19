namespace Lab05.DAL.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DacTrungPhong")]
    public partial class DacTrungPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DacTrungPhong()
        {
            LoaiPhongs = new HashSet<LoaiPhong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDacTrungPhong { get; set; }

        [StringLength(100)]
        public string TenDacTrungPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiPhong> LoaiPhongs { get; set; }
    }
}
