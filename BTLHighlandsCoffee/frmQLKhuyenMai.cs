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
    public partial class frmQLKhuyenMai : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        string makm;
        public frmQLKhuyenMai()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void frmQLKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();    
            //dateTimeKetThuc.Value = DateTime.Today;
            //dateTimeBatDau.Value = DateTime.Today;
            timeBD.ShowUpDown = true;
            timeKT.ShowUpDown = true;
            timeBD.Text = "00:00:00";
            timeKT.Text = "23:59:59";
        }
        public void LoadData()
        {
            dgvKhuyenMai.DataSource = db.KhuyenMais.Select(km => new
            {
                MaKM = km.MaKhuyenMai,
                PhanTramKM = km.PhanTram,
                NgayBatDau = km.NgayBatDau,
                NgayKetThuc=km.NgayKetThuc
            }).ToList();
            
        }
        public void TaoMaKhuyenMai()
        {
            List<KhuyenMai> dsKhuyenMai = db.KhuyenMais.Select(s => s).ToList();
            if (dsKhuyenMai.Count ==0)
            {
                makm = "KM001";
                return;
            }
            string t = dsKhuyenMai[dsKhuyenMai.Count - 1].MaKhuyenMai.ToString().Substring(2, 3);
            int dem;
            dem = Convert.ToInt32(t);
            dem = dem + 1;
            if (dem< 10)
            {
                makm = "KM00";
            }
            else if (dem< 100)
            {
                makm = "KM0";
            }
            else
            {
                makm = "KM";
            }
             makm = makm + dem.ToString();

        }
        private void iconbtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPhanTram.Text == "")
                {
                    MessageBox.Show("Phần trăm khuyến mãi không được để trống");
                    return;
                }
                KhuyenMai km = new KhuyenMai();
                TaoMaKhuyenMai();
                km.MaKhuyenMai = makm;
                km.PhanTram = int.Parse(txtPhanTram.Text);
                km.NgayBatDau = dateTimeBatDau.Value.Date + timeBD.Value.TimeOfDay;
                km.NgayKetThuc = dateTimeKetThuc.Value.Date + timeKT.Value.TimeOfDay;
                db.KhuyenMais.Add(km);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Tạo thành công chương trình khuyến mãi", "Thông báo");
            }catch(Exception ex)
            {
                MessageBox.Show("Phần trăm khuyến mãi là số nguyên");
                return;
            }
        }

        private void iconbtnSua_Click(object sender, EventArgs e)
        {
            KhuyenMai km = db.KhuyenMais.Where(s => s.MaKhuyenMai == makm).FirstOrDefault();
            if (km != null)
            {
                km.PhanTram = int.Parse(txtPhanTram.Text);
                km.NgayBatDau = dateTimeBatDau.Value.Date+timeBD.Value.TimeOfDay;
                km.NgayKetThuc = dateTimeKetThuc.Value.Date+timeKT.Value.TimeOfDay;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công chương trình khuyến mãi", "Thông báo");
                Clear();
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvKhuyenMai.Rows[index];
            makm = selectedRow.Cells[0].Value.ToString();
            txtPhanTram.Text = selectedRow.Cells[1].Value.ToString();
           /* KhuyenMai find = db.KhuyenMais.Where(s => s.MaKhuyenMai == makm).FirstOrDefault();
            dateTimeBatDau.Value = find.NgayBatDau.Date;
            dateTimeKetThuc.Value = find.NgayKetThuc.Date;
            timeBD.Text = find.NgayBatDau.TimeOfDay+"";
            timeKT.Text = find.NgayKetThuc.TimeOfDay + "";*/
            
        }

        private void iconbtnXoa_Click(object sender, EventArgs e)
        {
            KhuyenMai km = db.KhuyenMais.Where(s => s.MaKhuyenMai == makm).FirstOrDefault();
            if (km != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa chương trình khuyến mãi này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    db.KhuyenMais.Remove(km);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Chương trình khuyến mãi đã được hủy", "Thông báo");
                    Clear();

                }
            }
        }
        public void Clear()
        {
           
            txtPhanTram.Text = "";
            dateTimeBatDau.Value = DateTime.Today;
            dateTimeKetThuc.Value = DateTime.Today;
            timeBD.Text = "00:00:00";
            timeKT.Text = "23:59:59";
        }
        private void iconbtnHuy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dateTimeBatDau_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayhientai = DateTime.Today;
            DateTime bd = dateTimeBatDau.Value.Date+timeBD.Value.TimeOfDay;
            DateTime kt= dateTimeKetThuc.Value.Date + timeKT.Value.TimeOfDay;
            if (bd< ngayhientai)
            {
                MessageBox.Show("Ngày bắt đầu khuyến mãi phải lớn hơn hoặc bằng ngày hiện tại", "Thông báo");
                dateTimeBatDau.Value = ngayhientai;
            }
            if (bd > kt)
            {
                MessageBox.Show("Ngày bắt đầu khuyến mãi phải nhỏ hơn ngày kết thúc", "Thông báo");
                dateTimeBatDau.Value = ngayhientai;
            }
        }

        private void dateTimeKetThuc_ValueChanged(object sender, EventArgs e)
        {
            DateTime bd = dateTimeBatDau.Value.Date + timeBD.Value.TimeOfDay;
            DateTime kt = dateTimeKetThuc.Value.Date+timeKT.Value.TimeOfDay;
            if (kt < bd)
            {
                MessageBox.Show("Thời gian kết thúc khuyến mãi phải lớn hơn thời gian bắt đầu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dateTimeKetThuc.Value = bd;
            }
        }
    }
}
