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
    public partial class frmQLBan : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLBan()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            var query = from b in db.Bans
                        select new
                        {
                            MaBan=b.MaBan,
                            TrangThai=b.TrangThai
                        };
            dgvBan.DataSource = query.ToList();
        }
        private void frmQLBan_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private bool check()
        {
            if (txtmaban.Text == "")
            {
                MessageBox.Show("Mã bàn không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                txtmaban.Focus();
                return false;
            }
            else
            {
                if (cboTrangthai.Text == "")
                {
                    MessageBox.Show("Trạng thái bàn không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    return false;
                }
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Ban b = db.Bans.SingleOrDefault(sp => sp.MaBan == txtmaban.Text);
                if (b != null)
                {
                    MessageBox.Show("Mã " + txtmaban.Text + " đã có trong danh sách");
                }
                else
                {
                    try
                    {
                        Ban ban = new Ban();
                        ban.MaBan = txtmaban.Text;
                        ban.TrangThai = cboTrangthai.SelectedItem.ToString();
                        db.Bans.Add(ban);
                        db.SaveChanges();
                        HienThiDuLieu();
                        MessageBox.Show("Thêm thành công");
                        txtmaban.Text = "";
                        cboTrangthai.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Ban ban = (from s in db.Bans
                              where s.MaBan == txtmaban.Text
                              select s).FirstOrDefault();
            if (ban != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bàn này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    db.Bans.Remove(ban);
                    db.SaveChanges();
                    HienThiDuLieu();
                    MessageBox.Show("Xóa thành công!");
                    txtmaban.Text = "";
                    cboTrangthai.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Mã " + txtmaban.Text + " không có trong danh sách, Không thể xóa!");
            }
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmaban.Text = dgvBan.Rows[index].Cells[0].Value.ToString();
            cboTrangthai.Text = dgvBan.Rows[index].Cells[1].Value.ToString();
        }
    }
}
