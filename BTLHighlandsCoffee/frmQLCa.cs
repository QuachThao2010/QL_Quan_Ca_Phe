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
    public partial class frmQLCa : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLCa()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            var query = from c in db.CaLamViecs
                        select new
                        {
                            MaCa = c.MaCLV,
                            GioBD = c.GioBatDau,
                            GioKT = c.GioKetThuc,
                            LuongCa = c.LuongGio,
                            LuongQL = c.LuongQL
                        };
            dgvCa.DataSource = query.ToList();
        }
        private float luongql()
        {
            float luong = float.Parse(txtluongca.Text);
            return luong * 2;
        }
        private void frmQLCa_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void iconbtnthemca_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CaLamViec ca = db.CaLamViecs.SingleOrDefault(s => s.MaCLV == txtmaca.Text);
                if (ca != null)
                {
                    MessageBox.Show("Mã " + txtmaca.Text + " đã có trong danh sách");
                }
                else
                {
                    try
                    {
                        CaLamViec s = new CaLamViec();
                        s.MaCLV = txtmaca.Text;
                        s.GioBatDau = float.Parse(txtgiobd.Text);
                        s.GioKetThuc = float.Parse(txtgiokt.Text);
                        s.LuongGio = float.Parse(txtluongca.Text);
                        s.LuongQL = luongql();
                        db.CaLamViecs.Add(s);
                        db.SaveChanges();
                        HienThi();
                        txtmaca.Text = "";
                        txtgiobd.Text = "";
                        txtgiokt.Text = "";
                        txtluongca.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
            }
        }
        private bool Check()
        {
            if (txtmaca.Text == "")
            {
                errorProvider1.SetError(txtmaca, "Bạn phải nhập mã ca");
                txtmaca.Focus();
                return false;
            }
            if (txtgiobd.Text == "")
            {
                errorProvider1.SetError(txtgiobd, "Bạn phải nhập giờ bắt đầu");
                txtgiobd.Focus();
                return false;
            }
            else
            {
                try
                {
                    float bd = float.Parse(txtgiobd.Text);
                    if (bd < 0 || bd > 24)
                    {
                        errorProvider1.SetError(txtgiobd, "Nhập giờ bắt đầu lớn hơn 0 và nhỏ hơn 24");
                        txtgiobd.Focus();
                        txtgiobd.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtgiobd, "Nhập giờ bắt đầu là số");
                    txtgiobd.Focus();
                    return false;
                }
            }
            if (txtgiokt.Text == "")
            {
                errorProvider1.SetError(txtgiokt, "Bạn phải nhập giờ kết thúc");
                txtgiokt.Focus();
                return false;
            }
            else
            {
                try
                {
                    float kt = float.Parse(txtgiokt.Text);
                    if (kt < 0 || kt > 24)
                    {
                        errorProvider1.SetError(txtgiokt, "Nhập giờ kết thúc lớn hơn 0 và nhỏ hơn 24");
                        txtgiokt.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtgiokt, "Nhập giờ kết thúc là số");
                    txtgiokt.Focus();
                    return false;
                }
            }
            if (txtluongca.Text == "")
            {
                errorProvider1.SetError(txtluongca, "Bạn phải nhập lương ca");
                txtluongca.Focus();
                return false;
            }
            else
            {
                try
                {
                    float luong = float.Parse(txtluongca.Text);
                    if (luong < 0)
                    {
                        errorProvider1.SetError(txtluongca, "Nhập lương ca lớn hơn 0");
                        txtluongca.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtluongca, "Nhập lương ca là số");
                    txtluongca.Focus();
                    return false;
                }


            }
            return true;
        }

        private void txtmaca_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmaca, "");
        }

        private void txtgiobd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtgiobd, "");
        }

        private void txtgiokt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtgiokt, "");
        }

        private void iconbtnsuaca_Click(object sender, EventArgs e)
        {
            CaLamViec spSua = db.CaLamViecs.SingleOrDefault(sp => sp.MaCLV == txtmaca.Text);
            if (spSua != null)
            {
                spSua.GioBatDau = float.Parse(txtgiobd.Text);
                spSua.GioKetThuc = float.Parse(txtgiokt.Text);
                spSua.LuongGio = float.Parse(txtluongca.Text);
                spSua.LuongQL = 2*spSua.LuongGio;
                db.SaveChanges();
                HienThi();
            }
            else
            {
                MessageBox.Show("Mã " + txtmaca.Text + " không có trong danh sách, không thể sửa!");
            }
        }

        private void iconbtnxoaca_Click(object sender, EventArgs e)
        {
            CaLamViec spXoa = (from s in db.CaLamViecs
                               where s.MaCLV == txtmaca.Text
                               select s).FirstOrDefault();
            if (spXoa != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    db.CaLamViecs.Remove(spXoa);
                    db.SaveChanges();
                    HienThi();
                    MessageBox.Show("Xóa thành công!");
                    txtmaca.Text = "";
                    txtgiobd.Text = "";
                    txtgiokt.Text = "";
                    txtluongca.Text = "";
                    //txtluongcaql.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Mã " + txtmaca.Text + " không có trong danh sách, Không thể xóa!");
            }
        }

        private void dgvCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmaca.Text = dgvCa.Rows[index].Cells[0].Value.ToString();
            txtgiobd.Text = dgvCa.Rows[index].Cells[1].Value.ToString();
            txtgiokt.Text = dgvCa.Rows[index].Cells[2].Value.ToString();
            txtluongca.Text = dgvCa.Rows[index].Cells[3].Value.ToString();
        }
    }
}
