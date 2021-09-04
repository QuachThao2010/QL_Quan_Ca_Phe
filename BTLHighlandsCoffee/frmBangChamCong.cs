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
    public partial class frmBangChamCong : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmBangChamCong()
        {
            InitializeComponent();
        }
        private void HienThiNV()
        {
            var query = from n in db.NhanViens
                        join c in db.CaLamViecs on n.MaCLV equals c.MaCLV
                        select new
                        {
                            MaNV = n.MaNV,
                            TenNV = n.TenNV,
                            GioiTinh = n.GioiTinh,
                            SDT = n.SDT,
                            DiaChi = n.DiaChi,
                            ChucVu = n.ChucVu,
                            CaLam = n.MaCLV,
                            c.GioBatDau,
                            c.GioKetThuc
                        };
            dgvNhanVien.DataSource = query.ToList();
            


        }
        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
            HienThiNV();
            HienThiBCC();
            datengayLam.Text = DateTime.Now + "";
        }
        private void HienThiBCC()
        {
            var query = from b in db.BangChamCongs
                        select new
                        {
                            MaNV = b.MaNV,
                            TenNV = b.TenNV,
                            MaCa = b.MaCLV,
                            NgayLam = b.NgayLam,
                            GioVao = b.GioVao,
                            GioRa = b.GioRa,
                            Cong = b.Cong
                        };
            dgvBangChamCong.DataSource = query.ToList();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmanv.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txttennv.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtmaca.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            txtgiovao.Text = dgvNhanVien.Rows[index].Cells[7].Value.ToString();
            txtgioRa.Text = dgvNhanVien.Rows[index].Cells[8].Value.ToString();
        }
        private double ChamCong()
        {
            float bd = float.Parse(txtgiovao.Text);
            float kt = float.Parse(txtgioRa.Text);
            float GioLam = kt - bd;
            return GioLam;
        }
        private bool checkgio()
        {
            List<BangChamCong> li = db.BangChamCongs.Select(s => s).Where(s => s.MaNV == txtmanv.Text && s.MaCLV == txtmaca.Text &&
           s.NgayLam == datengayLam.Value.Date).ToList();
            foreach (BangChamCong item in li)
            {
                float gio = float.Parse(txtgiovao.Text);
                BangChamCong bang = db.BangChamCongs.Where(s => s.GioVao == gio).FirstOrDefault();
                if (bang != null)
                {
                    if (bang.GioVao < (item.GioRa))
                    {
                        MessageBox.Show("Nhập lại giờ vào khác " + bang.GioVao);
                        return false;
                    }
                }
                else
                {
                    if (gio < (item.GioRa))
                    {
                        MessageBox.Show("Nhập lại giờ vào khác " + gio);
                        return false;
                    }

                }

            }
            return true;
        }

        

        private void txtmanv_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmanv, "");
        }

        private void datengayLam_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(datengayLam, "");
        }

        private void txtgiovao_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtgiovao, "");
        }

        private void txtgioRa_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtgioRa, "");
        }
        private bool check2()
        {
            if (txtmanv.Text == "")
            {
                errorProvider1.SetError(txtmanv, "Bạn phải chọn nhân viên!");
                return false;
            }
            if (txtgiovao.Text == "")
            {
                errorProvider1.SetError(txtgiovao, "Bạn phải nhập giờ vào");
                txtgiovao.Focus();
                return false;
            }
            else
            {
                try
                {
                    float nc = float.Parse(txtgiovao.Text);
                    if (nc < 0 || nc > 19)
                    {
                        errorProvider1.SetError(txtgiovao, "Nhập giờ vào lớn hơn 0 và nhỏ hơn 19");
                        txtgiovao.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtgiovao, "Nhập giờ là số");
                    txtgiovao.Focus();
                    return false;
                }
            }
            if (txtgioRa.Text == "")
            {
                errorProvider1.SetError(txtgioRa, "Bạn phải nhập giờ ra");
                txtgioRa.Focus();
                return false;
            }
            else
            {
                try
                {
                    float nc = float.Parse(txtgioRa.Text);
                    if (nc < 0 || nc > 24 || nc < float.Parse(txtgiovao.Text))
                    {
                        errorProvider1.SetError(txtgioRa, "Nhập giờ ra trong đoạn [0,24] và > giờ vào");
                        txtgioRa.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtgioRa, "Nhập giờ ra là số");
                    txtgioRa.Focus();
                    return false;
                }
            }
            return true;
        }

        

        private void iconbtnsuaca_Click(object sender, EventArgs e)
        {
            if (check2())
            {
                float gio = float.Parse(txtgiovao.Text);
                float ra = float.Parse(txtgioRa.Text);
                BangChamCong check = db.BangChamCongs.Where(s => s.MaNV == txtmanv.Text && s.MaCLV == txtmaca.Text &&
                s.NgayLam == datengayLam.Value.Date && s.GioVao == gio && s.GioRa == ra).FirstOrDefault();
                if (check == null)
                {
                    if (checkgio())
                    {
                        BangChamCong s = new BangChamCong();
                        s.MaNV = txtmanv.Text;
                        s.TenNV = txttennv.Text;
                        s.MaCLV = txtmaca.Text;
                        s.NgayLam = DateTime.Parse(datengayLam.Value.ToShortDateString());
                        s.GioVao = float.Parse(txtgiovao.Text);
                        s.GioRa = float.Parse(txtgioRa.Text);
                        s.Cong = ChamCong();
                        db.BangChamCongs.Add(s);
                        db.SaveChanges();
                        HienThiBCC();
                        txtmanv.Text = "";
                        txttennv.Text = "";
                        txtmaca.Text = "";
                        txtgiovao.Text = "";
                        txtgioRa.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Xin vui lòng chấm công lại!");
                }

            }
        }
        
        private void iconbtnincong_Click(object sender, EventArgs e)
        {
            frmReportBangChamCong f = new frmReportBangChamCong();
            f.ShowDialog();
        }
    }
}
