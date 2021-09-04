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
    public partial class frmReportBangChamCong : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmReportBangChamCong()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmReportBangChamCong_Load(object sender, EventArgs e)
        {
            var combo = from n in db.NhanViens
                        select n;        
            comboBoxMaNV.DataSource = combo.ToList();
            comboBoxMaNV.DisplayMember = "MaNV";
            var combo1 = from n in db.CaLamViecs
                         select n;
            comboBoxThang.Text = DateTime.Now.Month + "";
            txtNam.Text = DateTime.Now.Year + "";
            // TODO: This line of code loads data into the 'DataSetBCC.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetBCC.DataTable1, comboBoxMaNV.Text, int.Parse(txtNam.Text), int.Parse(comboBoxThang.Text));

            this.reportViewer1.RefreshReport();
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaNV_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxMaNV.Text != "" && comboBoxThang.Text!="" && txtNam.Text!="")
            {
                this.DataTable1TableAdapter.Fill(this.DataSetBCC.DataTable1, comboBoxMaNV.Text, int.Parse(txtNam.Text), int.Parse(comboBoxThang.Text));

                this.reportViewer1.RefreshReport();
            }
        }

        private void comboBoxThang_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxMaNV.Text != "" && comboBoxThang.Text != "" && txtNam.Text != "")
            {
                this.DataTable1TableAdapter.Fill(this.DataSetBCC.DataTable1, comboBoxMaNV.Text, int.Parse(txtNam.Text), int.Parse(comboBoxThang.Text));

                this.reportViewer1.RefreshReport();
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxMaNV.Text != "" && comboBoxThang.Text != "" && txtNam.Text != "")
            {
                this.DataTable1TableAdapter.Fill(this.DataSetBCC.DataTable1, comboBoxMaNV.Text, int.Parse(txtNam.Text), int.Parse(comboBoxThang.Text));

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
