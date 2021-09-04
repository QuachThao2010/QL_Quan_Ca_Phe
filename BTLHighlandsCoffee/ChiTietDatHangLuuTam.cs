using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHighlandsCoffee
{
    class ChiTietDatHangLuuTam
    {
        public string maNL { set; get; }
        public string tenNL { set; get; }
        public string donViTinh { set; get; }
        public int soLuong { set; get; }
        public double donGia { set; get; }
        public ChiTietDatHangLuuTam() { }
        public ChiTietDatHangLuuTam(string maNL, string tenNL, int soLuong,  string donViTinh, float donGia)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;
            this.soLuong = soLuong;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
        }
    }
}
