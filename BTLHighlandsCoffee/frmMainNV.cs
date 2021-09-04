using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BTLHighlandsCoffee
{
    public partial class frmMainNV : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public static string maNV;
        public static string tendangnhap;
        public frmMainNV()
        {
            InitializeComponent();
            leftBtn = new Panel();
            leftBtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBtn);

        }
        private struct RGBcolor
        {
            public static Color cl1 = Color.FromArgb(255, 255, 255);
        }
        private void ActivateBtn(object senderBtn, Color cl)
        {

            if (senderBtn != null)
            {
                disableBtn();
                //nut
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(139, 69, 19);
                currentBtn.ForeColor = cl;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = cl;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //vien
                leftBtn.BackColor = cl;
                leftBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();
                //child
                iconView.IconChar = currentBtn.IconChar;
                iconView.IconColor = cl;
                blView.Text = currentBtn.Text;
            }
        }
        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(165, 42, 42);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmBanHang f = new frmBanHang();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(f);
            f.Tag = maNV;
            f.Show();
            // sendtaikhoan(manhanvien);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLNhanVien f = new frmQLNhanVien();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(f);
            f.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {

            ActivateBtn(sender, RGBcolor.cl1);
            frmQLKhachHang f = new frmQLKhachHang();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(f);
            f.Show();
            
        }

       /* private void btnQLHangNhap_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
        }*/
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHighlands f = new frmHighlands();
            addForm(f);
            TaiKhoan tk = (TaiKhoan)this.Tag;
            NhanVien login = db.NhanViens.Where(p => p.MaNV == tk.TenTK).FirstOrDefault();
            lblTenTaiKhoan.Text = login.TenNV;
            tendangnhap = lblTenTaiKhoan.Text;
            maNV = tk.TenTK;
        }
        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            f.Show();
        }
        private void frmMain_Deactivate(object sender, EventArgs e)
        {
           /* frmDangNhap f = new frmDangNhap();
            f.Show();*/
        }



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<HoaDonLuuTam> dsHD = frmLuuTamHoaDon.li;
            if (dsHD.Count!=0)
            {
                MessageBox.Show("Thanh toán hết hóa đơn trước khi đăng xuất");
                e.Cancel = true;
                return;
            }
            else
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.No)
                {
                    e.Cancel = true;

                }
            }
        }

        private void btnQLKhuyenMai_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLKhuyenMai f = new frmQLKhuyenMai();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(f);
            f.Show();
        }


       
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLCa f = new frmQLCa();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(f);
            f.Show();
        }

        private void iconHighlands_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmHighlands f = new frmHighlands();
            addForm(f);
        }

    }
}

