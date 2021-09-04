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
    public partial class frmReportUngLuong : Form
    {
        public frmReportUngLuong()
        {
            InitializeComponent();
        }

        private void frmReportUngLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetUngLuong.DataTableUngLuong' table. You can move, or remove it, as needed.
            this.DataTableUngLuongTableAdapter.Fill(this.DataSetUngLuong.DataTableUngLuong);

            this.reportViewer1.RefreshReport();
        }
    }
}
