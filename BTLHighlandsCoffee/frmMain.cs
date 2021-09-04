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
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public static string maNV;
        public static string tendangnhap;
        public frmMain()
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
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Tag = maNV;
            f.Show();
            // sendtaikhoan(manhanvien);
        }

        private void btnQLMenu_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmHang f = new frmHang();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
        }

        private void btnThongKeDT_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLNhanVien f = new frmQLNhanVien();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLLuong_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLLuong f = new frmQLLuong();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLBan f = new frmQLBan();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            this.btnchamcong.Controls.Clear();
            frmQLTaiKhoan f = new frmQLTaiKhoan();
            addForm(f);
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLKhachHang f = new frmQLKhachHang();
            TaiKhoan tk = (TaiKhoan)this.Tag;
            f.Tag = tk;
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLHangNhap_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            timer1.Start();
        }
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
            this.btnchamcong.Controls.Add(f);
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
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnQLNhaCC_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLNhaCungCap f = new frmQLNhaCungCap();
            addForm(f);
        }

        private void btnQLNguyenLieu_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLNguyenLieu f = new frmQLNguyenLieu();
            addForm(f);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLCa f = new frmQLCa();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void iconHighlands_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmHighlands f = new frmHighlands();
            addForm(f);
        }
        private bool menu2;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (menu2)
            {
                btnQLHangNhap.IconChar = IconChar.CaretUp;
                pnlDropDown.Height += 10;
                if (pnlDropDown.Size == pnlDropDown.MaximumSize)
                {
                    timer1.Stop();
                    menu2 = false;
                }
            }
            else
            {
                btnQLHangNhap.IconChar = IconChar.CaretDown;
                pnlDropDown.Height -= 10;
                if (pnlDropDown.Size == pnlDropDown.MinimumSize)
                {
                    timer1.Stop();
                    menu2 = true;
                }
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmTaoDonHang hangNhap = new frmTaoDonHang();
            TaiKhoan tk = (TaiKhoan)this.Tag;
            hangNhap.Tag = tk;
            addForm(hangNhap);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmNhapHang f = new frmNhapHang();
            TaiKhoan tk = (TaiKhoan)this.Tag;
            f.Tag = tk;
            addForm(f);
        }
        private bool drop;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (drop)
            {
                btnLuong.IconChar= IconChar.CaretDown;
                panelLuong.Height +=10;
                if (panelLuong.Size == panelLuong.MaximumSize)
                {
                    timer2.Stop();
                    drop = false;
                }
            }
            else
            {
                btnLuong.IconChar = IconChar.CaretUp;
                panelLuong.Height -= 10;
                if (panelLuong.Size == panelLuong.MinimumSize)
                {
                    timer2.Stop();
                    drop = true;
                }
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUngluong_Click(object sender, EventArgs e)
        {
            /*ActivateBtn(sender, RGBcolor.cl1);
            frmUngLuong ungluong = new frmUngLuong();
            TaiKhoan tk = (TaiKhoan)this.Tag;
            ungluong.Tag = tk;
            addForm(ungluong);*/
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            /*ActivateBtn(sender, RGBcolor.cl1);
            frmQLLuong luong = new frmQLLuong();
            TaiKhoan tk = (TaiKhoan)this.Tag;
            luong.Tag = tk;
            addForm(luong);*/
        }

        private void iconButton2_Click_2(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmBangChamCong f = new frmBangChamCong();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnungluong_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmUngLuong f = new frmUngLuong();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }

        private void btnluongnv_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            frmQLLuong f = new frmQLLuong();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.btnchamcong.Controls.Clear();
            this.btnchamcong.Controls.Add(f);
            f.Show();
        }
    }
}

