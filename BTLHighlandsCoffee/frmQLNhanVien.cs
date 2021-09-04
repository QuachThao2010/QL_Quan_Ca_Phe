using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{
    public partial class frmQLNhanVien : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            var query = from n in db.NhanViens
                        select new
                        {
                            MaNV = n.MaNV,
                            TenNV = n.TenNV,
                            GioiTinh = n.GioiTinh,
                            SDT = n.SDT,
                            DiaChi = n.DiaChi,
                            ChucVu = n.ChucVu,
                            CaLam = n.MaCLV,
                            AnhNV = n.AnhNV
                        };
            dgvNhanVien.DataSource = query.ToList();
            dgvNhanVien.Columns[0].Width = 80;
            dgvNhanVien.Columns[1].Width = 170;
            dgvNhanVien.Columns[2].Width = 70;
            dgvNhanVien.Columns[3].Width = 100;
            dgvNhanVien.Columns[4].Width = 200;
            dgvNhanVien.Columns[5].Width = 110;
            dgvNhanVien.Columns[6].Width = 100;
            dgvNhanVien.Columns[7].Width = 120;

        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            var combo1 = from n in db.CaLamViecs
                         select n;
            cboCalam.DataSource = combo1.ToList();
            cboCalam.DisplayMember = "MaCLV";
        }
        private void ClearTextBox()
        {
            txtmaNV.Text = "";
            txttennv.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            txtsdt.Text = "";
            txtdiachi.Text = "";
            cbochucvu.Text = "";
            cboCalam.Text = "";
            pictureNV.Image = default;
        }
        private bool check()
        {
            if (pictureNV.Image == default)
            {
                MessageBox.Show("Bạn cần chọn ảnh!");
                return false;
            }
            else
            {
                if (txtmaNV.Text == "")
                {
                    MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    txtmaNV.Focus();
                    return false;
                }
                else
                {
                    if (txttennv.Text == "")
                    {
                        MessageBox.Show("Tên nhân viên không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        txttennv.Focus();
                        return false;
                    }
                    else
                    {
                        if (radNam.Checked == false && radNu.Checked == false)
                        {
                            MessageBox.Show("Giới tính không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (txtsdt.Text == "")
                            {
                                MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                txtsdt.Focus();
                                return false;
                            }
                            else
                            {
                                if (cbochucvu.Text == "")
                                {
                                    MessageBox.Show("Chức vụ không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                    return false;
                                }
                                else
                                {
                                    if (cboCalam.Text == "")
                                    {
                                        MessageBox.Show("Ca làm không được để trống!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            return true;
        }
        
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                NhanVien nv = db.NhanViens.SingleOrDefault(sp => sp.MaNV == txtmaNV.Text);
                if (nv != null)
                {
                    MessageBox.Show("Mã " + txtmaNV.Text + " đã có trong danh sách");
                }
                else
                {
                    try
                    {
                        byte[] b = ImageToByteArray(pictureNV.Image);
                        NhanVien nvMoi = new NhanVien();
                        nvMoi.MaNV = txtmaNV.Text;
                        nvMoi.TenNV = txttennv.Text;
                        if (radNam.Checked)
                            nvMoi.GioiTinh = "Nam";
                        if (radNu.Checked)
                            nvMoi.GioiTinh = "Nữ";
                        nvMoi.SDT = txtsdt.Text;
                        nvMoi.DiaChi = txtdiachi.Text;
                        nvMoi.ChucVu = cbochucvu.Text;
                        nvMoi.MaCLV = cboCalam.Text;
                        nvMoi.AnhNV = b;
                        db.NhanViens.Add(nvMoi);

                        db.SaveChanges();
                        HienThiDuLieu();
                        MessageBox.Show("Thêm thành công");
                        ClearTextBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
            }


        }
        byte[] ImageToByteArray(Image image)
        {
            //throw new NotImplementedException();
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteToArray(byte[] b)
        {

            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void btnhienthi_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void pictureNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureNV.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void txttim_Enter(object sender, EventArgs e)
        {
            if (txttim.Text == "--Mã nhân viên--")
            {
                txttim.Text = null;
            }
            txttim.ForeColor = Color.Black;
        }

        private void txttim_Leave(object sender, EventArgs e)
        {
            if (txttim.Text == "")
            {
                txttim.Text = "--Mã nhân viên--";
            }
            txttim.ForeColor = Color.DarkGray;
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NhanVien nvSua = db.NhanViens.SingleOrDefault(sp => sp.MaNV == txtmaNV.Text);
            if (nvSua != null)
            {
                byte[] b = ImageToByteArray(pictureNV.Image);
                nvSua.TenNV = txttennv.Text;
                if (radNam.Checked)
                    nvSua.GioiTinh = "Nam";
                if (radNu.Checked)
                    nvSua.GioiTinh = "Nữ";
                nvSua.SDT = txtsdt.Text;
                nvSua.DiaChi = txtdiachi.Text;
                nvSua.AnhNV = b;
                nvSua.ChucVu = cbochucvu.Text;
                nvSua.MaCLV = cboCalam.Text;
                db.SaveChanges();
                HienThiDuLieu();
                MessageBox.Show("Sửa thành công!!");
            }
            else
            {
                MessageBox.Show("Mã " + txtmaNV.Text + " không có trong danh sách, không thể sửa!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NhanVien nvXoa = (from s in db.NhanViens
                             where s.MaNV == txtmaNV.Text
                             select s).FirstOrDefault();
            if (nvXoa != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    db.NhanViens.Remove(nvXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                    MessageBox.Show("Xóa thành công!");
                    ClearTextBox();
                }

            }
            else
            {
                MessageBox.Show("Mã " + txtmaNV.Text + " không có trong danh sách, Không thể xóa!");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            var query = from s in db.NhanViens
                        where s.MaNV == txttim.Text
                        select new
                        {
                            s.MaNV,
                            s.TenNV,
                            s.GioiTinh,
                            s.SDT,
                            s.DiaChi,
                            s.ChucVu,
                            s.MaCLV,
                            s.AnhNV
                        };
            dgvNhanVien.DataSource = query.ToList();
        }

        private void btnxoatrang_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvNhanVien.Rows[index];
            txtmaNV.Text = selectedRow.Cells[0].Value.ToString();
            txttennv.Text = selectedRow.Cells[1].Value.ToString();
            string gioitinh = selectedRow.Cells[2].Value.ToString();
            if (gioitinh.Equals("Nam"))
                radNam.Checked = true;
            if (gioitinh.Equals("Nữ"))
                radNu.Checked = true;
            txtsdt.Text = selectedRow.Cells[3].Value.ToString();
            txtdiachi.Text = selectedRow.Cells[4].Value.ToString();
            cbochucvu.Text = selectedRow.Cells[5].Value.ToString();
            cboCalam.Text = selectedRow.Cells[6].Value.ToString();
            byte[] b = (byte[])selectedRow.Cells[7].Value;
            pictureNV.Image = ByteToArray(b);
        }
    }
}
