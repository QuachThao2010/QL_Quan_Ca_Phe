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
    
    public partial class HangBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangBan()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    
        public string MaHang { get; set; }
        public string Size { get; set; }
        public double DonGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual SizeHang SizeHang { get; set; }
    }
}