using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{
    public partial class frmTaoDonHang : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        List<ChiTietDatHangLuuTam> listHang = new List<ChiTietDatHangLuuTam>();
        public frmTaoDonHang()
        {
            InitializeComponent();
        }

        private void cbNhaCC_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbNhaCC, "");
        }

        private void txtTenHang_Validated(object sender, EventArgs e)
        {
        }
        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoLuong, "");
        }
        private bool validData()
        {
            if (cbNhaCC.Text == "")
            {
                errorProvider1.SetError(cbNhaCC, "Chưa chọn nhà cung cấp");
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                errorProvider1.SetError(txtSoLuong, "Số lượng không được để trống");
                txtSoLuong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int soLuong = int.Parse(txtSoLuong.Text);
                    if (soLuong <= 0)
                    {
                        errorProvider1.SetError(txtSoLuong, "Bạn phải nhập số lượng > 0");
                        txtSoLuong.Focus();
                        txtSoLuong.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtSoLuong, "Bạn phải nhập số lượng là số nguyên");
                    txtSoLuong.Focus();
                    txtSoLuong.SelectAll();
                    return false;
                }
            }
            return true;
        }
        private void frmQLHangNhap_Load(object sender, EventArgs e)
        {
            BindingList<NhaCC> _comboItems = new BindingList<NhaCC>();
            var cbquery = from s in db.NhaCCs
                          select s;
            foreach (var item in cbquery)
            {
                _comboItems.Add(item);
            }
            cbNhaCC.DataSource = _comboItems;
            cbNhaCC.DisplayMember = "TenNCC";
            cbNhaCC.ValueMember = "MaNCC";
            cbNhaCC.SelectedValue = -1;
            TaiKhoan tk = (TaiKhoan)this.Tag;
            lbNhanVien.Text = tk.TenTK;
            lbNgayLap.Text = DateTime.Now.ToString();
        }

        private void Display()
        {
            dgvNguyenLieu.Columns[0].HeaderText = "Mã hàng";
            dgvNguyenLieu.Columns[1].HeaderText = "Tên hàng";
            dgvNguyenLieu.Columns[2].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[3].HeaderText = "Đơn giá nhập";
            dgvNguyenLieu.Columns[0].Width = 150;
            dgvNguyenLieu.Columns[1].Width = 300;
            dgvNguyenLieu.Columns[2].Width = 150;
            dgvNguyenLieu.Columns[3].Width = 170;
        }

        private void cbNhaCC_TextChanged(object sender, EventArgs e)
        {
            if (cbNhaCC.Text != "")
            {
                string nhacc = cbNhaCC.SelectedValue.ToString();
                NhaCC n = (from s in db.NhaCCs
                           where s.MaNCC == nhacc
                           select s).FirstOrDefault();
                if (n != null)
                {
                    lbDienThoai.Text = n.SDT;
                    lbDiaChi.Text = n.DiaChi;
                }
                var query1 = from s in db.NguyenLieux
                             where s.MaNCC == nhacc
                             select new
                             {
                                 s.MaNL,
                                 s.TenNL,
                                 s.DonViTinh,
                                 s.DonGiaNhap,
                             };
                dgvNguyenLieu.DataSource = query1.ToList();
                Display();
            }
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            if (cbNhaCC.Text == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nhacc = cbNhaCC.SelectedValue.ToString();
                if (txtTenHang.Text != "")
                {
                    var query1 = from s in db.NguyenLieux
                                 where s.TenNL.Contains(txtTenHang.Text) && s.MaNCC == nhacc
                                 select new
                                 {
                                     s.MaNL,
                                     s.TenNL,
                                     s.DonViTinh,
                                     s.DonGiaNhap,
                                 };
                    dgvNguyenLieu.DataSource = query1.ToList();
                    Display();
                }
                else
                {
                    NhaCC n = (from s in db.NhaCCs
                               where s.MaNCC == nhacc
                               select s).FirstOrDefault();
                    lbDienThoai.Text = n.SDT;
                    lbDiaChi.Text = n.DiaChi;
                    var query1 = from s in db.NguyenLieux
                                 where s.MaNCC == nhacc
                                 select new
                                 {
                                     s.MaNL,
                                     s.TenNL,
                                     s.DonViTinh,
                                     s.DonGiaNhap,
                                 };
                    dgvNguyenLieu.DataSource = query1.ToList();
                    Display();
                }
            }  
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            if(lbMaHang.Text == "")
            {
                MessageBox.Show("Kích chọn hàng muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var item in listHang)
                {
                    if (item.maNL == lbMaHang.Text)
                    {
                        item.soLuong = int.Parse(txtSoLuong.Text);
                    }
                }
                viewDSHangTam();
                tinhTong();
                reSet();
            }
        }

        private void dgvChiTietDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            lbMaHang.Text = dgvChiTietLuuTam.Rows[index].Cells[0].Value.ToString();
            lbTenHang.Text = dgvChiTietLuuTam.Rows[index].Cells[1].Value.ToString();
            lbDonViTinh.Text = dgvChiTietLuuTam.Rows[index].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvChiTietLuuTam.Rows[index].Cells[3].Value.ToString();
            lbDonGiaNhap.Text = dgvChiTietLuuTam.Rows[index].Cells[4].Value.ToString();
        }

        private void viewDSHangTam()
        {
            dgvChiTietLuuTam.Rows.Clear();
            int index = 0;
            if (listHang.Count != 0)
            {
                dgvChiTietLuuTam.RowCount = listHang.Count();
                foreach (var item in listHang)
                {
                    dgvChiTietLuuTam.Rows[index].Cells[0].Value = item.maNL.ToString();
                    dgvChiTietLuuTam.Rows[index].Cells[1].Value = item.tenNL.ToString();
                    dgvChiTietLuuTam.Rows[index].Cells[2].Value = item.donViTinh.ToString();
                    dgvChiTietLuuTam.Rows[index].Cells[3].Value = item.soLuong.ToString();
                    dgvChiTietLuuTam.Rows[index].Cells[4].Value = item.donGia.ToString();
                    dgvChiTietLuuTam.Rows[index].Cells[5].Value = (item.donGia * item.soLuong).ToString();
                    index++;
                }
            }
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (lbMaHang.Text == "")
            {
                MessageBox.Show("Kích chọn hàng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var item in listHang)
                {
                    if (item.maNL == lbMaHang.Text)
                    {
                        listHang.Remove(item);
                        break;
                    }
                }
                viewDSHangTam();
                tinhTong();
                reSet();
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                if (lbMaHang.Text == "")
                {
                    MessageBox.Show("Kích chọn hàng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChiTietDatHangLuuTam ct = new ChiTietDatHangLuuTam();
                    ct.maNL = lbMaHang.Text;
                    ct.tenNL = lbTenHang.Text;
                    ct.soLuong = int.Parse(txtSoLuong.Text);
                    ct.donViTinh = lbDonViTinh.Text;
                    ct.donGia = float.Parse(lbDonGiaNhap.Text);
                    int dem = 0;
                    foreach (var item in listHang)
                    {
                        if (item.maNL == lbMaHang.Text)
                        {
                            MessageBox.Show("Hàng bị trùng trong một đơn đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dem++;
                        }
                    }
                    if (dem == 0)
                        listHang.Add(ct);
                    viewDSHangTam();
                    tinhTong();
                    reSet();
                }
            }
        }

        private void tinhTong() 
        {
            //tinh tong tien cua don dat
            double tong = 0;
            foreach (var item in listHang)
            {
                tong += item.soLuong * item.donGia;
            }
            lbTongTien.Text = tong.ToString();
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            if (listHang.Count !=0)
            {
                if(lbMaDonDat.Text == "")
                {
                    //them vao bang DONDATHANG
                    DonDatHang dd = new DonDatHang();
                    dd.MaNV = lbNhanVien.Text;
                    dd.NgayLap = DateTime.Parse(lbNgayLap.Text); 
                    dd.MaNCC = cbNhaCC.SelectedValue.ToString();
                    dd.TongTien = float.Parse(lbTongTien.Text);
                    dd.TrangThai = lbTrangThai.Text;
                    db.DonDatHangs.Add(dd);
                    db.SaveChanges();
                    //them vao bang CHITIETDONDAT
                    foreach (var item in listHang)
                    {
                        ChiTietDatHang ct = new ChiTietDatHang();
                        ct.MaDDH = dd.MaDDH;
                        ct.MaNL = item.maNL;
                        ct.SoLuongNhap = item.soLuong;
                        db.ChiTietDatHangs.Add(ct);
                        db.SaveChanges();
                    }
                    //kiem tra va thong bao them don thanh cong
                    DonDatHang donnew = (from s in db.DonDatHangs
                                         where s.MaDDH == dd.MaDDH
                                         select s).FirstOrDefault();
                    if (donnew != null)
                    {
                        btnHoanTat.Enabled = true;
                        MessageBox.Show("Đơn hàng đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbMaDonDat.Text = dd.MaDDH.ToString();
                    }
                    else
                        MessageBox.Show("Thêm đơn  thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Nhấn hoàn tất để hoàn thành đơn đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đơn hàng chưa có mặt hàng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnInDon_Click(object sender, EventArgs e)
        {
            DonDatHang dd = (from s in db.DonDatHangs
                             where s.MaDDH.ToString() == lbMaDonDat.Text
                             select s).FirstOrDefault();
            if (dd == null)
            {
                MessageBox.Show("Tạo đơn đặt hàng trước khi xem chi tiết đơn");
                return;
            }
            else
            {
                frmXemChiTietDonDat f = new frmXemChiTietDonDat();
                f.Tag = dd;
                f.Show();
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            lbMaHang.Text = dgvNguyenLieu.Rows[index].Cells[0].Value.ToString();
            lbTenHang.Text = dgvNguyenLieu.Rows[index].Cells[1].Value.ToString();
            lbDonViTinh.Text = dgvNguyenLieu.Rows[index].Cells[2].Value.ToString();
            lbDonGiaNhap.Text = dgvNguyenLieu.Rows[index].Cells[3].Value.ToString();
        }
        private void reSet()
        {
            lbMaHang.Text = "";
            lbTenHang.Text = "";
            txtSoLuong.Clear();
            lbDonViTinh.Text = "";
            lbDonGiaNhap.Text = "";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reSet();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            lbMaDonDat.Text = "";
            reSet();
            cbNhaCC.SelectedIndex = -1;
            lbDienThoai.Text = "";
            lbDiaChi.Text = "";
            lbTongTien.Text = "";
        }

        private void dgvChiTietLuuTam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
