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
    public partial class frmNhapHang : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        List<ChiTietDatHangLuuTam> list = new List<ChiTietDatHangLuuTam>();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            hienThiDSDon();
        }
        private void hienThiDSDon()
        {
            var query = from s in db.DonDatHangs
                        select new
                        {
                            s.MaDDH,
                            s.MaNV,
                            s.NgayLap,
                            s.NhaCC.TenNCC,
                            s.TongTien,
                            s.TrangThai
                        };
            dgvDonDatHang.DataSource = query.ToList();
            dgvDonDatHang.Columns[0].HeaderText = "Mã đơn đặt";
            dgvDonDatHang.Columns[1].HeaderText = "Người lập";
            dgvDonDatHang.Columns[2].HeaderText = "Ngày lập";
            dgvDonDatHang.Columns[3].HeaderText = "Nhà cung cấp";
            dgvDonDatHang.Columns[4].HeaderText = "Tổng tiền";
            dgvDonDatHang.Columns[5].HeaderText = "Trạng thái";
            dgvDonDatHang.Columns[0].Width = 100;
            dgvDonDatHang.Columns[1].Width = 100;
            dgvDonDatHang.Columns[2].Width = 150;
            dgvDonDatHang.Columns[3].Width = 200;
            dgvDonDatHang.Columns[4].Width = 150;
            dgvDonDatHang.Columns[5].Width = 200;
        }

        private void txtTimDon_TextChanged(object sender, EventArgs e)
        {
            if(txtTimDon.Text == "")
            {
                hienThiDSDon();
            }
            else
            {
                var query = from s in db.DonDatHangs
                            where s.MaDDH.ToString().StartsWith(txtTimDon.Text)
                            select new
                            {
                                s.MaDDH,
                                s.MaNV,
                                s.NgayLap,
                                s.NhaCC.TenNCC,
                                s.TongTien,
                                s.TrangThai
                            };
                dgvDonDatHang.DataSource = query.ToList();
                dgvDonDatHang.Columns[0].HeaderText = "Mã đơn đặt";
                dgvDonDatHang.Columns[1].HeaderText = "Người lập";
                dgvDonDatHang.Columns[2].HeaderText = "Ngày lập";
                dgvDonDatHang.Columns[3].HeaderText = "Nhà cung cấp";
                dgvDonDatHang.Columns[4].HeaderText = "Tổng tiền";
                dgvDonDatHang.Columns[5].HeaderText = "Trạng thái";
                dgvDonDatHang.Columns[0].Width = 100;
                dgvDonDatHang.Columns[1].Width = 100;
                dgvDonDatHang.Columns[2].Width = 150;
                dgvDonDatHang.Columns[3].Width = 200;
                dgvDonDatHang.Columns[4].Width = 150;
                dgvDonDatHang.Columns[5].Width = 200;
            }
        }

        private void hienThiHangNhap()
        {
            var query = from s in db.ChiTietDatHangs
                        where s.MaDDH.ToString() == lbMaDonDat.Text
                        select s;
            //add vao danh sach tạm
            foreach (var item in query)
            {
                ChiTietDatHangLuuTam ct = new ChiTietDatHangLuuTam();
                ct.maNL = item.MaNL;
                ct.tenNL = item.NguyenLieu.TenNL;
                ct.soLuong = item.SoLuongNhap;
                ct.donViTinh = item.NguyenLieu.DonViTinh;
                ct.donGia = item.NguyenLieu.DonGiaNhap;
                list.Add(ct);
            }
            //hien thi len datagridview
            dgvDSHangNhap.Rows.Clear();
            int index = 0;
            if (list.Count != 0)
            {
                dgvDSHangNhap.RowCount = list.Count();
                foreach (var item in list)
                {
                    dgvDSHangNhap.Rows[index].Cells[0].Value = item.maNL.ToString();
                    dgvDSHangNhap.Rows[index].Cells[1].Value = item.tenNL.ToString();
                    dgvDSHangNhap.Rows[index].Cells[2].Value = item.soLuong.ToString();
                    dgvDSHangNhap.Rows[index].Cells[3].Value = null;
                    dgvDSHangNhap.Rows[index].Cells[4].Value = item.donViTinh.ToString();
                    dgvDSHangNhap.Rows[index].Cells[5].Value = item.donGia.ToString();
                    index++;
                }
            }
        }
        private void dgvDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hien thi thong tin
            list.Clear();
            dgvDSHangNhap.Rows.Clear();
            int index = e.RowIndex;
            lbMaDonDat.Text = dgvDonDatHang.Rows[index].Cells[0].Value.ToString();
            lbNhanVien.Text = dgvDonDatHang.Rows[index].Cells[1].Value.ToString();
            lbNgayLap.Text = dgvDonDatHang.Rows[index].Cells[2].Value.ToString();
            lbNhaCC.Text = dgvDonDatHang.Rows[index].Cells[3].Value.ToString();
            lbTongTien.Text = dgvDonDatHang.Rows[index].Cells[4].Value.ToString();
            lbTrangThai.Text = dgvDonDatHang.Rows[index].Cells[5].Value.ToString();
            //hien thi danh sach
            hienThiHangNhap();
            DonDatHang dd = (from s in db.DonDatHangs
                             where s.MaDDH.ToString() == lbMaDonDat.Text
                             select s).FirstOrDefault();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (lbMaDonDat.Text == "")
            {
                MessageBox.Show("Chọn đơn muốn nhập!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DonDatHang dd = (from s in db.DonDatHangs
                                 where s.MaDDH.ToString() == lbMaDonDat.Text
                                 select s).FirstOrDefault();
                if (dd.TrangThai.StartsWith("Đã giao ngày"))
                {
                    MessageBox.Show("Đơn hàng này đã giao", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    int dem = 0;
                    for (int index = 0; index < list.Count; index++)
                    {
                        if (dgvDSHangNhap.Rows[index].Cells[3].Value == null)
                        {
                            MessageBox.Show("Tất cả loại hàng phải có số lượng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dem++;
                            break;
                        }
                        if (dgvDSHangNhap.Rows[index].Cells[3].Style.BackColor == Color.Yellow)
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại thực nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dem++;
                            break;
                        }
                    }
                    if (dem == 0)
                    {
                        double tong = 0;
                        ChiTietDatHang ctxoa;
                        do
                        {
                            ctxoa = (from s in db.ChiTietDatHangs
                                     where s.MaDDH.ToString() == lbMaDonDat.Text
                                     select s).FirstOrDefault();
                            if (ctxoa != null)
                            {
                                db.ChiTietDatHangs.Remove(ctxoa);
                                db.SaveChanges();
                            }
                        } while (ctxoa != null);

                        //Cap nhat lai bang CHITIETDATHANG

                        foreach (var item in list)
                        {
                            ChiTietDatHang ct = new ChiTietDatHang();
                            ct.MaDDH = int.Parse(lbMaDonDat.Text);
                            ct.MaNL = item.maNL;
                            ct.SoLuongNhap = item.soLuong;
                            db.ChiTietDatHangs.Add(ct);
                            db.SaveChanges();
                            tong += item.soLuong * item.donGia;
                        }
                        lbTongTien.Text = tong.ToString();
                        lbTrangThai.Text = "Đã giao" + DateTime.Now.ToShortDateString();
                        //cap nhat lai bang DONDATHANG
                        DonDatHang ddat = (from s in db.DonDatHangs
                                           where s.MaDDH.ToString() == lbMaDonDat.Text
                                           select s).FirstOrDefault();
                        ddat.TongTien = tong;
                        TaiKhoan tk = (TaiKhoan)this.Tag;
                        NhanVien nv = (from s in db.NhanViens
                                       where s.MaNV == tk.TenTK
                                       select s).FirstOrDefault();
                        ddat.NguoiNhap = nv.TenNV;
                        ddat.TrangThai = "Đã giao ngày " + DateTime.Now.ToShortDateString();
                        db.SaveChanges();
                        hienThiDSDon();
                        //dgvDSHangNhap.Rows.Clear();
                        btnXemChiTiet.Enabled = true;
                    }
                }
            }
        }
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if(lbMaDonDat.Text == "")
            {
                MessageBox.Show("Chọn đơn muốn hủy!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int ma = int.Parse(lbMaDonDat.Text);
                DonDatHang dd = (from s in db.DonDatHangs
                                 where s.MaDDH == ma
                                 select s).FirstOrDefault();
                if(dd.TrangThai.StartsWith("Đã giao ngày "))
                {
                    MessageBox.Show("Đơn đã giao không thể hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dd.TrangThai = "Đã hủy ngày " + DateTime.Now.ToShortDateString();
                    db.SaveChanges();
                    hienThiDSDon();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lbMaDonDat.Text == "")
            {
                MessageBox.Show("Chọn đơn muốn xem!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DonDatHang dd = (from s in db.DonDatHangs
                                 where s.MaDDH.ToString() == lbMaDonDat.Text
                                 select s).FirstOrDefault();
                frmChiTietPhieuNhap f = new frmChiTietPhieuNhap();
                f.Tag = dd;
                f.Show();
            }
        }

        bool change = false;
        private void dgvDSHangNhap_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int index = dgvDSHangNhap.CurrentCell.RowIndex;
            if (dgvDSHangNhap.Rows[index].Cells[3].Value != null && index < list.Count)
            {
                try
                {
                    int soLuong = int.Parse(dgvDSHangNhap.Rows[index].Cells[2].Value.ToString());
                    int thucNhap = int.Parse(dgvDSHangNhap.Rows[index].Cells[3].Value.ToString());
                    if (thucNhap > soLuong)
                    {
                        //MessageBox.Show("Chỉ nhập đủ hoặc ít hơn số lượng theo chứng từ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvDSHangNhap.Rows[index].Cells[3].Style.BackColor = Color.Yellow;
                        dgvDSHangNhap.Rows[index].Cells[3].ToolTipText = "Chỉ nhập đủ hoặc ít hơn số lượng theo chứng từ";
                    }
                    else if (thucNhap == 0)
                    {
                        //MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvDSHangNhap.Rows[index].Cells[3].Style.BackColor = Color.Yellow;
                        dgvDSHangNhap.Rows[index].Cells[3].ToolTipText = "Số lượng nhập phải lớn hơn 0";
                    }
                    else
                    {
                        dgvDSHangNhap.Rows[index].Cells[3].Style.BackColor = Color.White;
                        list[index].soLuong = thucNhap;
                        dgvDSHangNhap.Rows[index].Cells[6].Value = list[index].soLuong * list[index].donGia;
                        dgvDSHangNhap.Rows[index].Cells[3].ToolTipText = dgvDSHangNhap.Rows[index].Cells[2].ToString();
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Số lượng phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvDSHangNhap.CurrentCell.Style.BackColor = Color.Yellow;
                    dgvDSHangNhap.Rows[index].Cells[3].ToolTipText = "Số lượng phải là số nguyên";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
