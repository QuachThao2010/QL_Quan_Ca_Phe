//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTLHighlandsCoffee
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    
        public int MaHoaDon { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public double TongTien { get; set; }
        public double GiamGia { get; set; }
        public int TruDiemTL { get; set; }
        /* public Nullable<double> GiamGia { get; set; }
         public Nullable<int> TruDiemTL { get; set; }*/
        public string MaNV { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string MaBan { get; set; }
    
        public virtual Ban Ban { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
