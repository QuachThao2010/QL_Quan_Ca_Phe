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
    public partial class frmQLTaiKhoan : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            hienThiDL();
        }
        private void hienThiDL()
        {
            var query = from s in db.TaiKhoans
                        select new
                        {
                            s.TenTK,
                            s.MatKhau
                        };
            dgvTaiKhoan.DataSource = query.ToList();
            dgvTaiKhoan.Columns[0].HeaderText = "Tên tài khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns[0].Width = 200;
            dgvTaiKhoan.Columns[1].Width = 250;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                TaiKhoan tk = (from s in db.TaiKhoans
                               where s.TenTK == txtTenTaiKhoan.Text
                               select s).FirstOrDefault();
                NhanVien nv = (from s in db.NhanViens
                               where s.MaNV == txtTenTaiKhoan.Text
                               select s).FirstOrDefault();
                if (tk == null && nv != null)
                {
                    TaiKhoan tknew = new TaiKhoan();
                    tknew.TenTK = txtTenTaiKhoan.Text;
                    tknew.MatKhau = txtMatKhau.Text;
                    db.TaiKhoans.Add(tknew);
                    db.SaveChanges();
                    hienThiDL();
                    reSet();
                }
                else if(tk != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(nv == null)
                {
                    MessageBox.Show("Tên tài khoản phải là mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                TaiKhoan tk = (from s in db.TaiKhoans
                               where s.TenTK == txtTenTaiKhoan.Text
                               select s).FirstOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Tên tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tk.TenTK = txtTenTaiKhoan.Text;
                    tk.MatKhau = txtMatKhau.Text;
                    db.SaveChanges();
                    hienThiDL();
                    reSet();
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                TaiKhoan tk = (from s in db.TaiKhoans
                               where s.TenTK == txtTenTaiKhoan.Text
                               select s).FirstOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Tên tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.TaiKhoans.Remove(tk);
                    db.SaveChanges();
                    hienThiDL();
                    reSet();
                }
        }

        private void txtTenTaiKhoan_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenTaiKhoan, "");
        }

        private void txtMatKhau_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMatKhau, "");
        }
        private bool validData()
        {
            if (txtTenTaiKhoan.Text == "")
            {
                errorProvider1.SetError(txtTenTaiKhoan, "Bạn chưa nhập tên tài khoản");
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                errorProvider1.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu");
                return false;
            }
            return true;
        }//kiểm tra dữ liệu người dùng

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[index].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[index].Cells[1].Value.ToString();
        }
        private void reSet()
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
    }
}
