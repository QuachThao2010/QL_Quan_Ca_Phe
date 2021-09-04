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
    public partial class frmQLNhaCungCap : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void QLNhaCungCap_Load(object sender, EventArgs e)
        {
            hienThiDS();
        }
        private void DisPlay()
        {
            dgvNhaCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Điện thoại";
            dgvNhaCC.Columns[0].Width = 200;
            dgvNhaCC.Columns[1].Width = 250;
            dgvNhaCC.Columns[2].Width = 300;
            dgvNhaCC.Columns[3].Width = 200;
        }
        private void hienThiDS()
        {
            var query = from s in db.NhaCCs
                        select new
                        {
                            s.MaNCC,
                            s.TenNCC,
                            s.DiaChi,
                            s.SDT
                        };
            dgvNhaCC.DataSource = query.ToList();
            DisPlay();
        }
        private void txtTimNhaCC_TextChanged(object sender, EventArgs e)
        {
            if(txtTimNhaCC.Text == "")
            {
                hienThiDS();
            }
            else
            {
                var query = from s in db.NhaCCs
                            where s.TenNCC.StartsWith(txtTimNhaCC.Text)
                            select new
                            {
                                s.MaNCC,
                                s.TenNCC,
                                s.DiaChi,
                                s.SDT
                            };
                dgvNhaCC.DataSource = query.ToList();
                DisPlay();
            }
        }

        private void txtTenNhaCC_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenNhaCC, "");
        }

        private void txtDienThoai_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDienThoai, "");
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDiaChi, "");
        }
        private bool validData()
        {
            if(txtTenNhaCC.Text == "")
            {
                errorProvider1.SetError(txtTenNhaCC, "Chưa nhập tên nhà cung cấp");
                txtTenNhaCC.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Chưa nhập địa chỉ nhà cung cấp");
                txtDiaChi.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                errorProvider1.SetError(txtDienThoai, "Chưa nhập số điện thoại nhà cung cấp");
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }//kiem tra du lieu nguoi dung
        private void sinhMa()
        {
            String maNhaCC = "";
            List<NhaCC> dsNhaCC = (from s in db.NhaCCs
                        select s).ToList();
            if(dsNhaCC.Count == 0)
            {
                maNhaCC = "NhCC001";
            }
            else
            {
                string ma = dsNhaCC[dsNhaCC.Count - 1].MaNCC.ToString();
                ma = ma.Substring(4, 3);
                int dem = Convert.ToInt32(ma);
                dem = dem + 1;
                if (dem < 10)
                {
                    maNhaCC = "NhCC00";
                }
                else if (dem < 100)
                {
                    maNhaCC = "NhCC0";
                }
                else
                {
                    maNhaCC = "NhCC";
                }
                maNhaCC = maNhaCC + dem.ToString();
            }
            lbMa.Text = maNhaCC;
        }
        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                if(lbMa.Text == null)
                {
                    NhaCC ncc = new NhaCC();
                    sinhMa();
                    ncc.MaNCC = lbMa.Text;
                    ncc.TenNCC = txtTenNhaCC.Text;
                    ncc.DiaChi = txtDiaChi.Text;
                    ncc.SDT = txtDienThoai.Text;
                    db.NhaCCs.Add(ncc);
                    db.SaveChanges();
                    hienThiDS();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reSet();
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại! Nhấn clear để thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSuaNhaCC_Click(object sender, EventArgs e)
        {
            if (lbMa.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhaCC ncc = (from s in db.NhaCCs
                             where s.MaNCC == lbMa.Text
                             select s).FirstOrDefault();
                ncc.TenNCC = txtTenNhaCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.SDT = txtDienThoai.Text;
                db.SaveChanges();
                hienThiDS();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reSet();
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            lbMa.Text = dgvNhaCC.Rows[index].Cells[0].Value.ToString();
            txtTenNhaCC.Text = dgvNhaCC.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.Rows[index].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvNhaCC.Rows[index].Cells[3].Value.ToString();
        }

        private void btnXoaNhaCC_Click(object sender, EventArgs e)
        {
            if(lbMa.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhaCC ncc = (from s in db.NhaCCs
                             where s.MaNCC == lbMa.Text
                             select s).FirstOrDefault();
                db.NhaCCs.Remove(ncc);
                db.SaveChanges();
                hienThiDS();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reSet();
            }
        }
        private void reSet()
        {
            lbMa.Text = "";
            txtTenNhaCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtTimNhaCC.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reSet();
        }
    }
}
