using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHighlandsCoffee
{
    public class HangThongKe:IComparable<HangThongKe>
    {
        public string Ma { set; get; }
        public string Ten { set; get; }
        public int SoLuong { set; get; }
        public HangThongKe() { }
        public HangThongKe(string ma, string ten, int soluong)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.SoLuong = soluong;
        }

        public int CompareTo(HangThongKe other)
        {
            return other.SoLuong.CompareTo(this.SoLuong);
        }

        /* public bool Equals(HangThongKe other)
         {
             return this.Ma.Equals(other.Ma);
         }*/
    }
}
