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
    public partial class frmDoanhSoNhanVien : Form
    {
        public frmDoanhSoNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmDoanhSoNhanVien_Load(object sender, EventArgs e)
        {
            string nguoilap = frmMain.tendangnhap;
            // TODO: This line of code loads data into the 'DataSetHoaDon.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSetHoaDon.DataTable3,nguoilap,dateTimeNgay.Text);
            // TODO: This line of code loads data into the 'DataSetHoaDon.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.DataSetHoaDon.NhanVien,nguoilap);
            
            this.reportViewer1.RefreshReport();
        }

        private void dateTimeNgay_ValueChanged(object sender, EventArgs e)
        {
            string nguoilap = frmMain.tendangnhap;
            // TODO: This line of code loads data into the 'DataSetHoaDon.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSetHoaDon.DataTable3, nguoilap, dateTimeNgay.Text);
            // TODO: This line of code loads data into the 'DataSetHoaDon.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.DataSetHoaDon.NhanVien, nguoilap);

            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
