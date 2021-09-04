using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{
    public partial class frmDangNhap : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public static string tendn;
        public frmDangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void txtTenDangNhap_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenDangNhap, "");
        }

        private void txtMatKhau_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMatKhau, "");
        }
        private bool ValidData()
        {
            if (txtTenDangNhap.Text == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Bạn phải nhập tên đăng nhập");
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                errorProvider1.SetError(txtMatKhau, "Bạn phải nhập mật khẩu");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                TaiKhoan tk = (from s in db.TaiKhoans
                               where s.TenTK == txtTenDangNhap.Text && s.MatKhau == txtMatKhau.Text
                               select s).FirstOrDefault();
                if(tk == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Đăng nhập thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tk.TenTK.StartsWith("NV"))
                {
                    this.Hide();
                    tendn = txtTenDangNhap.Text;
                    txtTenDangNhap.Text = txtMatKhau.Text = "";
                    frmMainNV main = new frmMainNV();
                    main.Tag = tk;
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    tendn = txtTenDangNhap.Text;
                    txtTenDangNhap.Text = txtMatKhau.Text = "";
                    frmMain main = new frmMain();
                    main.Tag = tk;
                    main.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
