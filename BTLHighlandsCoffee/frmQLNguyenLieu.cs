using ExcelDataReader;
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
    
    public partial class frmQLNguyenLieu : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        public frmQLNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmQLNguyenLieu_Load(object sender, EventArgs e)
        {
            BindingList<NhaCC> _comboItems = new BindingList<NhaCC>();
            var cbquery = from s in db.NhaCCs
                          select s;
            foreach (var item in cbquery)
            {
                _comboItems.Add(item);
            }
            cbNhaCC.DataSource = _comboItems;
            cbChonNhaCC.DataSource = _comboItems;
            cbNhaCC.DisplayMember = "TenNCC";
            cbNhaCC.ValueMember = "MaNCC";
            cbChonNhaCC.DisplayMember = "TenNCC";
            cbChonNhaCC.ValueMember = "MaNCC";
            cbNhaCC.SelectedIndex = -1;
            cbChonNhaCC.SelectedIndex = -1;
            hienThiDS();
        }

        private void txtTenNL_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenNL, "");
        }

        private void cbNhaCC_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbNhaCC, "");
        }

        private void txtDonVi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonVi, "");
        }

        private void txtDonGia_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonGia, "");
        }
        private void cbSheet_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbSheet, "");
        }

        private void cbChonNhaCC_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbChonNhaCC, "");
        }
        private bool validData()
        {
            if(txtTenNL.Text == "")
            {
                errorProvider1.SetError(txtTenNL, "Chưa nhập tên nguyên liệu");
                txtTenNL.Focus();
                return false;
            }
            if (cbNhaCC.Text == "")
            {
                errorProvider1.SetError(cbNhaCC, "Chưa chọn tên nguyên liệu");
                return false;
            }
            if (txtDonVi.Text == "")
            {
                errorProvider1.SetError(txtDonVi, "Chưa nhập đơn vị tính");
                txtTenNL.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Chưa nhập đơn giá");
                txtDonGia.Focus();
                return false;
            }
            else
            {
                try
                {
                    double dongia = double.Parse(txtDonGia.Text);
                    if(dongia <= 0)
                    {
                        errorProvider1.SetError(txtDonGia, "Đơn giá phải lớn hơn 0");
                        txtDonGia.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtDonGia, "Đơn giá phải là số thực");
                    txtDonGia.SelectAll();
                    return false;
                }

            }
            return true;
        }
        private bool checkImport()
        {
            if(cbSheet.Text == "")
            {
                errorProvider1.SetError(cbSheet, "Chưa chọn sheet import");
                return false;
            }
            if (cbChonNhaCC.Text == "")
            {
                errorProvider1.SetError(cbChonNhaCC, "Chưa chọn nhà cung cấp cho danh sách nguyên liệu");
                return false;
            }
            return true;
        }
        private void sinhMa()
        {
            String maNL = "";
            List<NguyenLieu> dsNL = (from s in db.NguyenLieux
                                   select s).ToList();
            if (dsNL.Count == 0)
            {
                maNL = "NL001";
            }
            else
            {
                string ma = dsNL[dsNL.Count - 1].MaNL.ToString();
                ma = ma.Substring(2, 3);
                int dem = Convert.ToInt32(ma);
                dem = dem + 1;
                if (dem < 10)
                {
                    maNL = "NL00";
                }
                else if (dem < 100)
                {
                    maNL = "NL0";
                }
                else
                {
                    maNL = "NL";
                }
                maNL = maNL + dem.ToString();
            }
            lbMaNguyenLieu.Text = maNL;
        }
        private void hienThiDS()

        {
            var query = from s in db.NguyenLieux
                        join nhacc in db.NhaCCs on s.MaNCC equals nhacc.MaNCC
                        select new
                        {
                            s.MaNL,
                            s.TenNL,
                            nhacc.TenNCC,
                            s.DonViTinh,
                            s.DonGiaNhap
                        };
            dgvNguyenLieu.DataSource = query.ToList();
            DisPlay();
        }
        private void DisPlay()
        {
            dgvNguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[2].HeaderText = "Nhà cung cấp";
            dgvNguyenLieu.Columns[3].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[4].HeaderText = "Đơn giá";
            dgvNguyenLieu.Columns[0].Width = 200;
            dgvNguyenLieu.Columns[1].Width = 300;
            dgvNguyenLieu.Columns[2].Width = 200;
            dgvNguyenLieu.Columns[3].Width = 120;
            dgvNguyenLieu.Columns[4].Width = 150;
        }
        private void reSet()
        {
            lbMaNguyenLieu.Text = "";
            txtTenNL.Clear();
            txtDonGia.Clear();
            txtDonVi.Clear();
            cbNhaCC.SelectedIndex = -1;
            cbChonNhaCC.SelectedIndex = -1;
            txtFileName.Clear();
            cbSheet.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                NguyenLieu nltim = (from s in db.NguyenLieux
                                 where s.MaNL == lbMaNguyenLieu.Text 
                                 || (s.TenNL == txtTenNL.Text && s.MaNCC == cbNhaCC.SelectedValue.ToString() 
                                 && s.DonViTinh == txtDonVi.Text && s.DonGiaNhap.ToString() == txtDonGia.Text)
                                 select s).FirstOrDefault();
                if(nltim == null)
                {
                    NguyenLieu nl = new NguyenLieu();
                    sinhMa();
                    nl.MaNL = lbMaNguyenLieu.Text;
                    nl.TenNL = txtTenNL.Text;
                    nl.MaNCC = cbNhaCC.SelectedValue.ToString();
                    nl.DonViTinh = txtDonVi.Text;
                    nl.DonGiaNhap = double.Parse(txtDonGia.Text);
                    db.NguyenLieux.Add(nl);
                    db.SaveChanges();
                    hienThiDS();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reSet();
                }
                else
                {
                    MessageBox.Show("Nguyên liệu đã tồn tại nhấn clear để thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lbMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Chọn nguyên liệu muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NguyenLieu nl = (from s in db.NguyenLieux
                                 where s.MaNL == lbMaNguyenLieu.Text
                                 select s).FirstOrDefault();
                nl.TenNL = txtTenNL.Text;
                nl.MaNCC = cbNhaCC.SelectedValue.ToString();
                nl.DonViTinh = txtDonVi.Text;
                nl.DonGiaNhap = double.Parse(txtDonGia.Text);
                db.SaveChanges();
                hienThiDS();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reSet();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lbMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Chọn nguyên liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NguyenLieu nl = (from s in db.NguyenLieux
                                 where s.MaNL == lbMaNguyenLieu.Text
                                 select s).FirstOrDefault();
                db.NguyenLieux.Remove(nl);
                db.SaveChanges();
                hienThiDS();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reSet();
            }
        }

        private void txtTimNL_TextChanged(object sender, EventArgs e)
        {
            if(txtTimNL.Text == "" )
            {
                hienThiDS();
            }
            else 
            {
                var query = from s in db.NguyenLieux
                            where s.TenNL.Contains(txtTimNL.Text)
                            select new
                            {
                                s.MaNL,
                                s.TenNL,
                                s.MaNCC,
                                s.DonViTinh,
                                s.DonGiaNhap
                            };
                dgvNguyenLieu.DataSource = query.ToList();
                DisPlay();
            }
        }
        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            lbMaNguyenLieu.Text = dgvNguyenLieu.Rows[index].Cells[0].Value.ToString();
            txtTenNL.Text = dgvNguyenLieu.Rows[index].Cells[1].Value.ToString();
            string ten = dgvNguyenLieu.Rows[index].Cells[2].Value.ToString();
            NhaCC ncc = (from s in db.NhaCCs
                         where s.TenNCC == ten
                         select s).FirstOrDefault();
            cbNhaCC.Text = ncc.TenNCC;
            txtDonVi.Text = dgvNguyenLieu.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dgvNguyenLieu.Rows[index].Cells[4].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reSet();
        }

        DataTableCollection tableCollection;
        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 workbook|*.xls|Excel workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet ketqua = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = ketqua.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable item in tableCollection)
                            {
                                cbSheet.Items.Add(item.TableName);// add vao combosheet
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (checkImport() && txtFileName.Text != "")
            {
                DataTable data = tableCollection[cbSheet.SelectedItem.ToString()];
                dgvNguyenLieu.DataSource = data;
                foreach (DataRow item in data.Rows)
                {
                    double dongia = double.Parse(item[2].ToString());
                    string ten = item[0].ToString();
                    string donvi = item[1].ToString();
                    NguyenLieu nltim1 = (from s in db.NguyenLieux
                                         where (s.TenNL == ten && s.MaNCC == cbChonNhaCC.SelectedValue.ToString()
                                         && s.DonViTinh == donvi && s.DonGiaNhap == dongia)
                                         select s).FirstOrDefault();
                    NguyenLieu nltim2 = (from s in db.NguyenLieux
                                        where s.TenNL == ten && s.MaNCC == cbChonNhaCC.SelectedValue.ToString()
                                        select s).FirstOrDefault();
                    NguyenLieu nltim3 = (from s in db.NguyenLieux
                                         where s.TenNL == ten && s.MaNCC == cbChonNhaCC.SelectedValue.ToString() && s.DonViTinh == donvi
                                         select s).FirstOrDefault();
                    if ( nltim2 == null)
                    {
                        NguyenLieu add = new NguyenLieu();
                        sinhMa();
                        add.MaNL = lbMaNguyenLieu.Text;
                        add.TenNL = ten;
                        add.DonViTinh = donvi;
                        add.DonGiaNhap = dongia;
                        add.MaNCC = cbChonNhaCC.SelectedValue.ToString();
                        db.NguyenLieux.Add(add);
                        db.SaveChanges();
                    }
                    if(nltim2 != null)
                    {
                        nltim2.DonViTinh = donvi;
                        nltim2.DonGiaNhap = dongia;
                        db.SaveChanges();
                    }
                    if(nltim3 != null)
                    {
                        nltim3.DonGiaNhap = dongia;
                        db.SaveChanges();
                    }
                }
                hienThiDS();
            }
        }
    }
}
