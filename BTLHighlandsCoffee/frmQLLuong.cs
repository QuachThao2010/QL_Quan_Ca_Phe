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
    public partial class frmQLLuong : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLLuong()
        {
            InitializeComponent();
        }

        private void frmQLLuong_Load(object sender, EventArgs e)
        {
            HienThi2();
            var combo = from n in db.NhanViens
                        select n;
            cbomanv.DataSource = combo.ToList();
            cbomanv.DisplayMember = "MaNV";
            var combo1 = from n in db.CaLamViecs
                         select n;
            cbomaca.DataSource = combo1.ToList();
            cbomaca.DisplayMember = "MaCLV";

            cboLuongthang.Text = DateTime.Now.Month + "";
            txtluongnam.Text = DateTime.Now.Year + "";
        }
        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.Show();
        }
        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmBangChamCong f = new frmBangChamCong();
            addForm(f);
        }

        private void iconBangUL_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmUngLuong f = new frmUngLuong();
            addForm(f);
        }

        private void txtluongnam_Validated(object sender, EventArgs e)
        {

        }

        private void cboLuongthang_Validated(object sender, EventArgs e)
        {

        }

        private void cbomanv_Validated(object sender, EventArgs e)
        {

        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbomanv_TextChanged(object sender, EventArgs e)
        {
            var x = from n in db.NhanViens
                    join m in db.Luongs on n.MaNV equals m.MaNV
                    where n.MaNV == cbomanv.Text && m.LuongThang == cboLuongthang.Text && m.LuongNam == txtluongnam.Text
                    select new
                    {
                        n.MaNV,
                        n.MaCLV,
                        m.LuongThang,
                        m.LuongNam

                    };
            /*if (cbomanv.Text == x.Select(n => n.MaNV).SingleOrDefault() && cboLuongthang.Text == x.Select(m => m.LuongThang).SingleOrDefault() &&
                txtluongnam.Text == x.Select(m => m.LuongNam).SingleOrDefault())
            {
                txtmacaa.Text = x.Select(n => n.MaCLV).SingleOrDefault();
            }*/
            var x1 = from n in db.NhanViens
                     where n.MaNV == cbomanv.Text
                     select new
                     {
                         n.MaNV,
                         n.MaCLV
                     };
            if (cbomanv.Text == x1.Select(n => n.MaNV).SingleOrDefault())
            {
                txtmacaa.Text = x1.Select(n => n.MaCLV).SingleOrDefault();
            }
            /*cboLuongthang.Text = DateTime.Now.Month + "";
            txtluongnam.Text = DateTime.Now.Year + "";*/
            float thang = float.Parse(cboLuongthang.SelectedItem.ToString());
            float nam = float.Parse(txtluongnam.Text);

            double t = db.BangChamCongs.AsEnumerable().Where(n => n.MaNV == cbomanv.Text && n.MaCLV == txtmacaa.Text && n.NgayLam.Month == thang && n.NgayLam.Year == nam).Sum(n => n.Cong);

            /*if (cbomanv.Text == x.Select(n => n.MaNV).FirstOrDefault() && cboLuongthang.Text == x.Select(n => n.LuongThang).FirstOrDefault() &&
                txtluongnam.Text == x.Select(n => n.LuongNam).FirstOrDefault() && txtmacaa.Text==x.Select(n=>n.MaCLV).FirstOrDefault())
            {*/
            BangChamCong bang = db.BangChamCongs.Where(n => n.MaNV == cbomanv.Text && n.MaCLV == txtmacaa.Text && n.NgayLam.Month == thang && n.NgayLam.Year == nam).FirstOrDefault();
            if (bang != null)
            {
                txtngaycong.Text = t.ToString();
            }
            else
            {
                txtngaycong.Text = 0 + "";
            }

            /*}
            else
            {
                txtngaycong.Text = "0";
            }*/
        }
        public double ThuongLuong()
        {
            double thuong = 0;
            float nc = float.Parse(txtngaycong.Text);
            if (nc < 20)
                thuong = 0;
            else if (nc < 26)
                thuong = 100000;
            else thuong = 200000;
            return thuong;
        }
        private double Ung()
        {
            BangUngLuong tim1 = db.BangUngLuongs.Where(s => s.MaNV == cbomanv.Text && s.MaCLV == txtmacaa.Text && s.LuongThang == cboLuongthang.Text && s.LuongNam == txtluongnam.Text).SingleOrDefault();
            if (tim1 != null)
            {
                double ung = tim1.TamUng;
                return ung;
            }

            return 0;
        }
        private double TinhLuong()
        {

            CaLamViec tim = db.CaLamViecs.Where(s => s.MaCLV == txtmacaa.Text).FirstOrDefault();
            double luonggio = tim.LuongGio;
            float cong = float.Parse(txtngaycong.Text);
            
                
            return luonggio * cong + ThuongLuong() - Ung();
                
            
            

        }
        public void HienThi2()
        {
            string thang = cboLuongthang.Text;
            var query1 = from c in db.Luongs
                         where c.LuongThang.Equals(thang)
                         select new
                         {
                             LuongThang = c.LuongThang,
                             LuongNam = c.LuongNam,
                             MaNV = c.MaNV,
                             MaCa = c.MaCLV,
                             NgayCong = c.NgayCong,
                             TamUng = c.TamUng,
                             Thuong = c.Thuong,
                             TongLuong = c.TongLuong
                         };
            dgvLuong.DataSource = query1.ToList();
            cboLuongthang.Text = DateTime.Now.Month + "";
            txtluongnam.Text = DateTime.Now.Year + "";

        }
        private void ClearTextBox()
        {
            cbomanv.Text = "";
            cboLuongthang.Text = "";
            txtluongnam.Text = "";
            txtmacaa.Text = "";
            txtngaycong.Text = "";
            txttongluong.Text = "";

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (Check2())
            {
                Luong bcc = db.Luongs.Where(s => s.MaNV == cbomanv.Text && s.MaCLV == txtmacaa.Text && s.LuongThang == cboLuongthang.Text && s.LuongNam == txtluongnam.Text).FirstOrDefault();
                if (bcc == null)
                {
                    Luong spMoi = new Luong();
                    spMoi.LuongThang = cboLuongthang.Text.ToString();
                    spMoi.LuongNam = txtluongnam.Text;
                    spMoi.MaNV = cbomanv.Text;
                    spMoi.MaCLV = txtmacaa.Text;
                    spMoi.NgayCong = float.Parse(txtngaycong.Text);
                    spMoi.TamUng = Ung();
                    spMoi.Thuong = ThuongLuong();
                    spMoi.TongLuong = TinhLuong();
                    txttongluong.Text = TinhLuong().ToString();
                    db.Luongs.Add(spMoi);
                    db.SaveChanges();
                    Luong kitu = (from n in db.Luongs
                                  where n.MaNV == cbomanv.Text
                                  select n).FirstOrDefault();
                    if (kitu.MaNV.StartsWith("QL"))
                    {
                        double l = TinhLuong() * 2;
                        kitu.TongLuong = l;
                        txttongluong.Text = l.ToString();
                        db.SaveChanges();
                    }
                    HienThi2();
                    ClearTextBox();
                }
            }
            else
            {
                MessageBox.Show("Nhân viên " + cbomanv.Text + " ca " + txtmacaa.Text + " đã có lương trong tháng " + cboLuongthang.Text);
            }
        }
        private bool Check2()
        {
            if (cboLuongthang.Text == "")
            {
                errorProvider1.SetError(cboLuongthang, "Bạn phải chọn lương tháng");
                return false;
            }
            if (txtluongnam.Text == "")
            {
                errorProvider1.SetError(txtluongnam, "Bạn phải nhập năm");
                txtluongnam.Focus();
                return false;
            }
            else
            {
                try
                {
                    float nc = float.Parse(txtluongnam.Text);
                    if (nc < 2000)
                    {
                        errorProvider1.SetError(txtngaycong, "Nhập năm > năm 2000");
                        txtluongnam.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtluongnam, "Nhập năm là số");
                    txtluongnam.Focus();
                    return false;
                }
            }
            if (cbomanv.Text == "")
            {
                errorProvider1.SetError(cbomanv, "Bạn phải chọn mã nhân viên");
                return false;
            }
            return true;
        }

        private void cboLuongthang_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboLuongthang, "");
        }

        private void txtluongnam_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtluongnam, "");
        }

        private void cbomanv_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbomanv, "");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            HienThi2();
        }

        private void iconLocCa_Click(object sender, EventArgs e)
        {
            var query = from c in db.Luongs
                        where c.MaCLV == cbomaca.Text
                        select new
                        {
                            LuongThang = c.LuongThang,
                            LuongNam = c.LuongNam,
                            MaNV = c.MaNV,
                            MaCa = c.MaCLV,
                            NgayCong = c.NgayCong,
                            TamUng = c.TamUng,
                            Thuong = c.Thuong,
                            TongLuong = c.TongLuong
                        };
            dgvLuong.DataSource = query.ToList();
        }

        private void iconbtnxoa_Click(object sender, EventArgs e)
        {

            Luong nvXoa = (from s in db.Luongs
                           where s.MaNV == cbomanv.Text
                           select s).FirstOrDefault();

            if (MessageBox.Show("Bạn chắc chắn muốn xóa lương nhân viên này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                db.Luongs.Remove(nvXoa);
                db.SaveChanges();
                HienThi2();
                MessageBox.Show("Xóa thành công!");
                ClearTextBox();
            }
        }

        private void dgvLuong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cboLuongthang.Text = dgvLuong.Rows[index].Cells[0].Value.ToString();
            txtluongnam.Text = dgvLuong.Rows[index].Cells[1].Value.ToString();
            cbomanv.Text = dgvLuong.Rows[index].Cells[2].Value.ToString();
            txtmacaa.Text = dgvLuong.Rows[index].Cells[3].Value.ToString();
            txtngaycong.Text = dgvLuong.Rows[index].Cells[4].Value.ToString();
            //txtthuong.Text = dgvLuong.Rows[index].Cells[5].Value.ToString();
            txttongluong.Text = dgvLuong.Rows[index].Cells[7].Value.ToString();
        }

        private void iconbtninluong_Click(object sender, EventArgs e)
        {
            
            frmReportLuong f = new frmReportLuong();
            f.ShowDialog();
        }
    }
}
