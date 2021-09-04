using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHighlandsCoffee
{
    public class ChiTietHoaDonLuuTam:IEquatable<ChiTietHoaDonLuuTam>
    {
        public string MaBan { set; get; }
        public string TenHang { set; get; }
        public string Size { set; get; }
        public int Gia { set; get; }
        public int SoLuong { set; get; }
        public ChiTietHoaDonLuuTam() { }
        public ChiTietHoaDonLuuTam(string maban,string tenhang, string size, int gia, int soluong)
        {
            this.MaBan = maban;
            this.TenHang = tenhang;
            this.Size = size;
            this.Gia = gia;
            this.SoLuong = soluong;
        }

        public bool Equals(ChiTietHoaDonLuuTam other)
        {
            if (!this.MaBan.Equals(other.MaBan))
                return false;
            if (!this.TenHang.Equals(other.TenHang))
                return false;
            if (!this.Size.Equals(other.Size))
                return false;
            return true;
        }
    }
}
