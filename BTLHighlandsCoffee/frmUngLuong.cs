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
    public partial class frmUngLuong : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmUngLuong()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string thang = cboThang.Text;
            var query1 = from c in db.BangUngLuongs
                         where c.LuongThang.Equals(thang)
                         select new
                         {
                             LuongThang = c.LuongThang,
                             LuongNam = c.LuongNam,
                             MaNV = c.MaNV,
                             MaCa = c.MaCLV,
                             TamUng = c.TamUng
                         };
            dgvUngLuong.DataSource = query1.ToList();
            cboThang.Text = DateTime.Now.Month + "";
            txtNam.Text = DateTime.Now.Year + "";

        }
        private void frmUngLuong_Load(object sender, EventArgs e)
        {
            HienThi();
            var combo = from n in db.NhanViens
                        select n;
            cbomanv.DataSource = combo.ToList();
            cbomanv.DisplayMember = "MaNV";

            var combo1 = from n in db.CaLamViecs
                         select n;
            cbolocca.DataSource = combo1.ToList();
            cbolocca.DisplayMember = "MaCLV";
        }
        private void ClearTextBox()
        {
            cbomanv.Text = "";
            cboThang.Text = "";
            txtNam.Text = "";
            txtmaca.Text = "";
            txttienung.Text = "";
        }
        private bool DieuKienUng()
        {
            //double cong = db.Luongs.Select(n => n.NgayCong).Where(n=>n.);
            float thang = float.Parse(cboThang.Text);
            float nam = float.Parse(txtNam.Text);
            BangChamCong tim = db.BangChamCongs.Where(s => s.MaNV == cbomanv.Text && s.MaCLV == txtmaca.Text && s.NgayLam.Month == thang && s.NgayLam.Year == nam).FirstOrDefault();
            if (tim != null)
            {
                double cong = db.BangChamCongs.AsEnumerable().Where(n => n.MaNV == cbomanv.Text && n.MaCLV == txtmaca.Text && n.NgayLam.Month == thang && n.NgayLam.Year == nam).Sum(n => n.Cong);

                CaLamViec tim2 = db.CaLamViecs.Where(s => s.MaCLV == txtmaca.Text).FirstOrDefault();
                double luonggio = tim2.LuongGio;
                float tien = float.Parse(txttienung.Text);
                if (cong * luonggio > tien)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        private void iconbtnthemluong_Click(object sender, EventArgs e)
        {
            if (Check())
            {

                BangUngLuong bcc = db.BangUngLuongs.Where(s => s.MaNV == cbomanv.Text && s.MaCLV == txtmaca.Text && s.LuongThang == cboThang.Text && s.LuongNam == txtNam.Text).FirstOrDefault();
                if (bcc == null)
                {
                    if (DieuKienUng())
                    {
                        BangUngLuong spMoi = new BangUngLuong();
                        spMoi.LuongThang = cboThang.Text.ToString();
                        spMoi.LuongNam = txtNam.Text;
                        spMoi.MaNV = cbomanv.Text;
                        spMoi.MaCLV = txtmaca.Text;
                        spMoi.TamUng = float.Parse(txttienung.Text);
                        db.BangUngLuongs.Add(spMoi);
                        db.SaveChanges();
                        HienThi();
                        ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Không đủ điều kiện ứng!");
                    }

                }
                else
                {
                    MessageBox.Show("Nhân viên " + cbomanv.Text + " ca " + txtmaca.Text + " đã ứng lương trong tháng " + cboThang.Text);
                }

            }

        }
        private bool Check()
        {
            if (cboThang.Text == "")
            {
                errorProvider1.SetError(cboThang, "Bạn phải chọn lương tháng");
                return false;
            }
            if (txtNam.Text == "")
            {
                errorProvider1.SetError(txtNam, "Bạn phải nhập năm");
                txtNam.Focus();
                return false;
            }
            else
            {
                try
                {
                    float nc = float.Parse(txtNam.Text);
                    if (nc < 2000)
                    {
                        errorProvider1.SetError(txtNam, "Nhập năm > năm 2000");
                        txtNam.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtNam, "Nhập năm là số");
                    txtNam.Focus();
                    return false;
                }
            }
            if (cbomanv.Text == "")
            {
                errorProvider1.SetError(cbomanv, "Bạn phải chọn mã nhân viên");
                return false;
            }
            if (txttienung.Text == "")
            {
                errorProvider1.SetError(txttienung, "Bạn phải số tiền ứng!");
                txttienung.Focus();
                return false;
            }
            else
            {
                try
                {
                    float nc = float.Parse(txttienung.Text);
                    if (nc < 0)
                    {
                        errorProvider1.SetError(txttienung, "Nhập ngày công lớn hơn 0");
                        txttienung.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txttienung, "Nhập ngày công là số");
                    txttienung.Focus();
                    return false;
                }
            }
            return true;
        }

        private void cbomanv_TextChanged(object sender, EventArgs e)
        {
            var x = from n in db.NhanViens
                    where n.MaNV == cbomanv.Text
                    select new
                    {
                        n.MaNV,
                        n.MaCLV
                    };
            if (cbomanv.Text == x.Select(n => n.MaNV).SingleOrDefault())
            {
                txtmaca.Text = x.Select(n => n.MaCLV).SingleOrDefault();
            }
        }

        private void iconbtnlocca_Click(object sender, EventArgs e)
        {
            var query = from c in db.BangUngLuongs
                        where c.MaCLV == txtmaca.Text
                        select new
                        {
                            LuongThang = c.LuongThang,
                            LuongNam = c.LuongNam,
                            MaNV = c.MaNV,
                            MaCa = c.MaCLV,
                            TamUng = c.TamUng
                        };
            dgvUngLuong.DataSource = query.ToList();
        }

        private void cboThang_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboThang, "");
        }

        private void txtNam_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNam, "");
        }

        private void cbomanv_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbomanv, "");
        }

        private void txtmaca_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmaca, "");
        }

        private void txttienung_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txttienung, "");
        }

        private void iconbtnsualuong_Click(object sender, EventArgs e)
        {
            BangUngLuong nvSua = db.BangUngLuongs.SingleOrDefault(sp => sp.MaNV == cbomanv.Text && sp.MaCLV == txtmaca.Text && sp.LuongThang == cboThang.Text && sp.LuongNam == txtNam.Text);

            nvSua.LuongThang = cboThang.Text;
            nvSua.LuongNam = txtNam.Text;
            nvSua.MaCLV = txtmaca.Text;
            nvSua.TamUng = float.Parse(txttienung.Text);
            db.SaveChanges();
            HienThi();
            MessageBox.Show("Sửa thành công!!");
        }

        private void iconbtnxoaluong_Click(object sender, EventArgs e)
        {
            BangUngLuong nvXoa = (from sp in db.BangUngLuongs
                                  where sp.MaNV == cbomanv.Text && sp.MaCLV == txtmaca.Text && sp.LuongThang == cboThang.Text && sp.LuongNam == txtNam.Text
                                  select sp).FirstOrDefault();

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                db.BangUngLuongs.Remove(nvXoa);
                db.SaveChanges();
                HienThi();
                MessageBox.Show("Xóa thành công!");
                ClearTextBox();
            }
        }

        private void iconbtnhthi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvUngLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cboThang.Text = dgvUngLuong.Rows[index].Cells[0].Value.ToString();
            txtNam.Text = dgvUngLuong.Rows[index].Cells[1].Value.ToString();
            cbomanv.Text = dgvUngLuong.Rows[index].Cells[2].Value.ToString();
            txtmaca.Text = dgvUngLuong.Rows[index].Cells[3].Value.ToString();
            txttienung.Text = dgvUngLuong.Rows[index].Cells[4].Value.ToString();
        }

        private void iconbtninluong_Click(object sender, EventArgs e)
        {
            frmReportUngLuong f = new frmReportUngLuong();
            f.ShowDialog();
        }
    }
}
