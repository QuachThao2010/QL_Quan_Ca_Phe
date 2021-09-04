using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{
    public partial class frmChiTietLuuTamHoaDon : Form
    {
        public static List<ChiTietHoaDonLuuTam> li = new List<ChiTietHoaDonLuuTam>();
        /*string maban, tenhang, size;
        int gia, soluong;*/
        public frmChiTietLuuTamHoaDon()
        {
            InitializeComponent();
        }
        private void frmChiTietLuuTamHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = li;
        }
    }
}
