namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonHang { get; set; }

        [StringLength(50)]
        public string TenDonHang { get; set; }

        public DateTime? NgayDat { get; set; }

        public DateTime? NgayGiao { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        public int? PhiVanChuyen { get; set; }

        public int? TongTien { get; set; }

        [StringLength(50)]
        public string TinhTrangGiaoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
