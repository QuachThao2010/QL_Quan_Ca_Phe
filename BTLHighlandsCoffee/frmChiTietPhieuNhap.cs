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
    public partial class frmChiTietPhieuNhap : Form
    {
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetChiTietDatHang.DataTable1' table. You can move, or remove it, as needed.
            DonDatHang dd = (DonDatHang)this.Tag;
            this.DataTable1TableAdapter.Fill(this.DataSetChiTietDatHang.DataTable1,dd.MaDDH);
            this.reportViewer1.RefreshReport();
        }
    }
}
