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
    public partial class frmReportLuong : Form
    {
        public frmReportLuong()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmReportLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLuongQLNV.DataTableLuongQLNV' table. You can move, or remove it, as needed.
            this.DataTableLuongQLNVTableAdapter.Fill(this.DataSetLuongQLNV.DataTableLuongQLNV);
            // TODO: This line of code loads data into the 'DataSetLuongNV.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSetLuongNV.DataTable1);
            // TODO: This line of code loads data into the 'DataSetQLLuong.DataTableQLLuong' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSetLuong.DataTableLuong' table. You can move, or remove it, as needed.
            //this.DataTableLuongTableAdapter.Fill(this.DataSetLuong.DataTableLuong);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
