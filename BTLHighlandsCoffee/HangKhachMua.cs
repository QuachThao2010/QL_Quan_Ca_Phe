using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHighlandsCoffee
{
    class HangKhachMua:IEquatable<HangKhachMua>
    {
        public string Ten { set; get; }
        public string Size { set; get; }
        public int Gia { set; get; }
        public int SoLuong { set; get; }
        public HangKhachMua() {}
        public HangKhachMua(string ten,string size)
        {
            this.Ten = ten;
            this.Size = size;
        }
        public HangKhachMua(string ten, int soluong)
        {
            this.Ten = ten;
            this.SoLuong= soluong;
        }
        public HangKhachMua( string ten, string size, int gia, int soluong)
        {
            this.Ten = ten;
            this.Size = size;
            this.Gia = gia;
            this.SoLuong = soluong;
        }

        public bool Equals(HangKhachMua other)
        {
            if (!this.Ten.Equals(other.Ten))
                return false;
            if (!this.Size.Equals(other.Size))
                return false;
            return true;
          
        }
    }
}
