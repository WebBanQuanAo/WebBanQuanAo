namespace WebBanQuanAo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaQA { get; set; }

        [StringLength(50)]
        public string TenQA { get; set; }

        public int? GiaBan { get; set; }

        [StringLength(50)]
        public string KhuyenMai { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        public int? SoLuongHienCon { get; set; }

        [StringLength(10)]
        public string MaLoaiQA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
