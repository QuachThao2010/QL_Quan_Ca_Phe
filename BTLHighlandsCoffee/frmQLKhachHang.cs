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
    public partial class frmQLKhachHang : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        int makhachhang, diemtichluy;
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            hienThiDL();
            SetBounds(Screen.GetWorkingArea(this).Width - Width, Screen.GetWorkingArea(this).Height - Height, Width, Height);
           // rdNu.Checked = true;
            string tendangnhap = frmDangNhap.tendn;
            if(tendangnhap.StartsWith("QL"))
            {
                iconbtnLayThongTin.Visible = false;//ẨN
            }
            if(tendangnhap.StartsWith("NV"))
            { 
                iconbtnLayThongTin.Visible = true;//HIỆN
            }
           
            
        }
        private void hienThiDL()
        {
            var query = from s in db.KhachHangs
                        select new
                        {
                            s.MaKH,
                            s.TenKH,
                            s.GioiTinh,
                            s.SDT,
                            s.DiaChi,
                            s.DiemTichLuy
                        };
            dgvKhachHang.DataSource = query.ToList();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[5].HeaderText = "Điểm tích lũy";
            dgvKhachHang.Columns[0].Width = 130;
            dgvKhachHang.Columns[1].Width = 250;
            dgvKhachHang.Columns[2].Width = 120;
            dgvKhachHang.Columns[3].Width = 200;
            dgvKhachHang.Columns[4].Width = 160;
            dgvKhachHang.Columns[5].Width = 200;
        }


        private void txtTenKH_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenKH, "");
        }

        private void txtDienThoai_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDienThoai, "");
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDiaChi, "");
        }
     

        private bool ValidData()
        {
            if (txtTenKH.Text == "")
            {
                errorProvider1.SetError(txtTenKH, "Tên khách hàng không được bỏ trống");
                txtTenKH.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                errorProvider1.SetError(txtDienThoai, "Điện thoại không được để trống");
                txtDienThoai.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Địa chỉ không được để trống");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }//kiểm tra dữ liệu người dùng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {

                KhachHang kh = (from s in db.KhachHangs
                                where s.MaKH.ToString() == txtMaKH.Text
                                select s).FirstOrDefault();
                if (kh == null)
                {
                    KhachHang khthem = new KhachHang();
                    khthem.TenKH = txtTenKH.Text;
                    if (rdNu.Checked)
                    {
                        khthem.GioiTinh = "Nữ";
                    }
                    if (rdNam.Checked)
                    {
                        khthem.GioiTinh = "Nam";
                    }
                    khthem.SDT = txtDienThoai.Text;
                    khthem.DiaChi = txtDiaChi.Text;
                    khthem.DiemTichLuy = int.Parse(txtDiem.Text);
                    db.KhachHangs.Add(khthem);
                    db.SaveChanges();
                    hienThiDL();
                    reSet();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = (from s in db.KhachHangs
                            where s.MaKH.ToString()== txtMaKH.Text
                            select s).FirstOrDefault();
            if (kh==null)
            {
                MessageBox.Show("Không có khách nào có mã là: " + txtMaKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kh.TenKH = txtTenKH.Text;
                if (rdNu.Checked)
                {
                    kh.GioiTinh = "Nữ";
                }
                if (rdNam.Checked)
                {
                    kh.GioiTinh = "Nam";
                }
                kh.SDT = txtDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.DiemTichLuy = int.Parse(txtDiem.Text);
                db.SaveChanges();
                hienThiDL();
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Enabled = false;
            int index = e.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            if (dgvKhachHang.Rows[index].Cells[2].Value.ToString() == "Nữ")
            {
                rdNu.Checked = true;
            }
            if (dgvKhachHang.Rows[index].Cells[2].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            txtDienThoai.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
            txtDiem.Text = dgvKhachHang.Rows[index].Cells[5].Value.ToString();
            makhachhang = int.Parse(txtMaKH.Text);
            diemtichluy = int.Parse(txtDiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = (from s in db.KhachHangs
                            where s.MaKH.ToString() == txtMaKH.Text
                            select s).FirstOrDefault();
            if (kh == null)
            {
                MessageBox.Show("Không có khách nào có mã là: " + txtMaKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn xóa khách hàng này?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
                hienThiDL();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var query = (from s in db.KhachHangs
                         where s.SDT == txtTim.Text
                         select new
                         {
                             s.MaKH,
                             s.TenKH,
                             s.GioiTinh,
                             s.SDT,
                             s.DiaChi,
                             s.DiemTichLuy
                         });
            dgvKhachHang.DataSource = query.ToList();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[5].HeaderText = "Điểm tích lũy";
            dgvKhachHang.Columns[0].Width = 130;
            dgvKhachHang.Columns[1].Width = 250;
            dgvKhachHang.Columns[2].Width = 120;
            dgvKhachHang.Columns[3].Width = 200;
            dgvKhachHang.Columns[4].Width = 170;
            dgvKhachHang.Columns[5].Width = 200;
            txtTim.SelectAll();
            txtTim.Focus();

        }
        private void reSet()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtDiem.Text = "0";
            txtMaKH.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reSet();
        }
        //Gửi thông tin khách hàng sang phần thanh toán
        public delegate void SendInfor(int makh, int diemtl);
        public SendInfor send;

        private void frmQLKhachHang_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var query = (from s in db.KhachHangs
                         where s.SDT.StartsWith(txtTim.Text)
                         select new
                         {
                             s.MaKH,
                             s.TenKH,
                             s.GioiTinh,
                             s.SDT,
                             s.DiaChi,
                             s.DiemTichLuy
                         });
            dgvKhachHang.DataSource = query.ToList();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[5].HeaderText = "Điểm tích lũy";
            dgvKhachHang.Columns[0].Width = 130;
            dgvKhachHang.Columns[1].Width = 250;
            dgvKhachHang.Columns[2].Width = 120;
            dgvKhachHang.Columns[3].Width = 200;
            dgvKhachHang.Columns[4].Width = 170;
            dgvKhachHang.Columns[5].Width = 200;
        }

        private void btnLayThongTIn_Click(object sender, EventArgs e)
        {
                int makh = makhachhang;
                int diemtl = diemtichluy;
                send(makh, diemtl);
                this.Close();
            
        }
    }
}
