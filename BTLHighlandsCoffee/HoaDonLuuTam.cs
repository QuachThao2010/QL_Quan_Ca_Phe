using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHighlandsCoffee
{
    public class HoaDonLuuTam:IEquatable<HoaDonLuuTam>
    {
        public string MaNV { set; get; }
        public int MaKH { set; get; }
        public string MaBan { set; get; }
        public string NgayLap { set; get; }
        public int TongTien { set; get; }
        public int GiamGia { set; get; }
        public int TruDTL { set; get; }
        public int DTL { set; get; }
        public HoaDonLuuTam() { }
        public HoaDonLuuTam(string maban) {
            this.MaBan = maban;
        }
        public bool Equals(HoaDonLuuTam other)
        {
            return this.MaBan.Equals(other.MaBan);
        }
    }
}
