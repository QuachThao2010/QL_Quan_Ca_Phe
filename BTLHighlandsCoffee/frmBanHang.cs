using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{

    public partial class frmBanHang : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        Ban b = new Ban();
        DanhMuc dm = new DanhMuc();
        HangBan hb = new HangBan();
        HangHoa hh = new HangHoa();
        List<HangKhachMua> listHangMua = new List<HangKhachMua>();
        string tenhang, mahang;
        int phantramkhuyenmai;
        int makhach;
        string ngaylap = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
       
        public frmBanHang()
        {
            InitializeComponent();
            CenterToScreen();
        }
       
        public bool CheckBan(Ban t)
        {
            List<HoaDonLuuTam> listhoadon = frmLuuTamHoaDon.li;
            foreach (HoaDonLuuTam item in listhoadon)
            {
                if (item.MaBan.Contains(t.MaBan))
                    return true;
            }
            return false;
        }

        //Hiển thị bàn
        string mabantruoc;
        public void DisplayDataBan()
        {
            //bỏ bàn mã=0 trong ds bàn hiển thị(bàn này chỉ dành cho khách lẻ)
            List<Ban> dsBan = db.Bans.Select(b => b).ToList();
            Ban khachle = db.Bans.Where(x => x.MaBan == "0").FirstOrDefault();
            dsBan.Remove(khachle);
            List<HoaDonLuuTam> listhoadon = frmLuuTamHoaDon.li;
            foreach (Ban item in dsBan)
            {
                Button b = new Button() { Width = 120, Height = 120 };
                b.Text = "Bàn " + item.MaBan + Environment.NewLine + item.TrangThai;
                //Hiển thị bàn lên
                flpBan.Controls.Add(b);
                b.Font = new Font("Arial", 14);
                switch (item.TrangThai)
                {
                    case "Trống":
                        b.BackColor = Color.Azure;
                        b.ForeColor = Color.Black;
                        b.FlatStyle = FlatStyle.Flat;
                        break;

                    default:
                        b.BackColor = Color.Cyan;
                        b.ForeColor = Color.Black;
                        b.FlatStyle = FlatStyle.Flat;
                        break;
                }
                //Bàn của hóa đơn hiện tại hiển thị màu đỏ
                if (lblMaBan.Text == "______") { }
                else
                {
                    List<Ban> hientai = db.Bans.Where(x => lblMaBan.Text.Contains(x.MaBan)).ToList();
                    if (hientai != null)
                    {
                        foreach (Ban item1 in hientai)
                            if (item.MaBan == item1.MaBan)
                            {
                                b.BackColor = Color.Red;
                                item.TrangThai = "Có người";
                                db.SaveChanges();
                                b.Text = "Bàn " + item.MaBan + Environment.NewLine + "Có người";
                            }
                    }
                }
                //List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
                //Bắt sự kiện click của button
                b.Click += (sender, args) =>
                {
                    //nếu bàn vừa kích trước đó không có hóa đơn thì lại chuyển thành trống
                    Ban truoc = db.Bans.Where(s => s.MaBan == mabantruoc).FirstOrDefault();
                    if (truoc != null)
                    {
                        if (CheckBan(truoc)||mabantruoc==item.MaBan) { }//Bàn trước có trong ds hóa đơn
                        else
                        {
                            if (truoc.TrangThai == "Có người")
                            {
                                truoc.TrangThai = "Trống";
                                db.SaveChanges();
                            }

                        }
                    }
                    HoaDonLuuTam tim = listhoadon.Where(s => s.MaBan.Contains(item.MaBan)).FirstOrDefault();
                    if (tim != null)
                    {
                        if (tim.MaKH == 1)
                        {
                            lblMaKH.Text = "Khách Lẻ";
                            lblDiemTL.Text = "______";
                        }
                        else if (tim.MaKH == 0) //trường hợp chưa chọn hóa đơn lưu tạm mà nhấn Thanh Toán
                        {
                            lblMaKH.Text = "Khách Lẻ";
                            lblDiemTL.Text = "______";
                            lblMaBan.Text = "______";
                        }
                        else
                        {
                            lblMaKH.Text = tim.MaKH + "";
                            lblDiemTL.Text = tim.DTL + "";
                        }

                        lblMaBan.Text = tim.MaBan + "";
                        txtGiamGia.Text = tim.GiamGia + "";
                        txtTruDiem.Text = tim.TruDTL + "";
                        lblTongTien.Text = tim.TongTien + "";

                        int tt = (tim.TongTien * (100 - tim.GiamGia) / 100) - tim.TruDTL * 1000;
                        lblThanhToan.Text = tt + "";
                        //Hiển thị lại danh sách hàng khách mua
                        listHangMua.Clear();
                        List<ChiTietHoaDonLuuTam> listnow = frmChiTietLuuTamHoaDon.li;
                        foreach (ChiTietHoaDonLuuTam item2 in listnow)
                        {
                            if (lblMaBan.Text.Contains(item2.MaBan))
                            {
                                string tenhang = item2.TenHang;
                                string chonsize = item2.Size;
                                int gia = item2.Gia;
                                int soluong = item2.SoLuong;
                                HangKhachMua hang = new HangKhachMua(tenhang, chonsize, gia, soluong);
                                if (listHangMua.Contains(hang)) { }
                                else
                                {
                                    listHangMua.Add(hang);
                                }
                            }
                        }
                        DisplayHangMua();
                    }
                    else
                    {
                        if (item.TrangThai.Equals("Trống"))
                        {
                            item.TrangThai = "Có người";
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            lblMaBan.Text = item.MaBan;
                            b.Text = "Bàn " + item.MaBan + Environment.NewLine + "Có người";
                            b.ForeColor = Color.Black;
                            b.FlatStyle = FlatStyle.Flat;
                            b.BackColor = Color.Cyan;
                            listHangMua.Clear();
                            DisplayHangMua();
                        }
                        else
                        {
                            item.TrangThai = "Trống";
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            lblMaBan.Text = "______";
                            b.Text = "Bàn " + item.MaBan + Environment.NewLine + "Trống";
                            b.ForeColor = Color.Black;
                            b.FlatStyle = FlatStyle.Flat;
                            b.BackColor = Color.Azure;

                        }
                    }
                    mabantruoc = item.MaBan;

                };
            }
        }

        //Hiển thị menu để khách order
        public void DisplayDataOrder()
        {
            var dsdm = db.DanhMucs.Select(dm => dm.TenDM).ToList();
            cbDanhMuc.DataSource = dsdm;
            var listtencogia = db.HangBans.Join(db.HangHoas, hb => hb.MaHang, hh => hh.MaHang,
                (hb, hh) => hh.TenHang).ToList();
            //Không hiển thị những hàng chưa có giá bán
            dgvHang.DataSource = db.HangHoas.Select(p => new
            {

                TenHang = p.TenHang,
                Anh = p.AnhHang,
            }).Where(p => listtencogia.Contains(p.TenHang)).ToList();
            dgvHang.Columns[0].Width = 273;
            dgvHang.Columns[1].Width = 150;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            DateTime hientai = DateTime.Now;
            List<KhuyenMai> liKM = db.KhuyenMais.Select(km => km).ToList();
            foreach (KhuyenMai item in liKM)
            {
                if (DateTime.Compare(hientai, item.NgayBatDau) >= 0 && DateTime.Compare(hientai, item.NgayKetThuc) <= 0)//kiểm tra ngày trong khoảng cần tìm
                {
                    phantramkhuyenmai = item.PhanTram;
                    txtGiamGia.Text = phantramkhuyenmai + "";
                    break;
                }
            }
            DisplayDataBan();
            DisplayDataOrder();
            //txtTime.Text = DateTime.Now.ToString();
            List<HoaDon> hd = db.HoaDons.Select(x => x).ToList();
            //txtTime.Text =hd.Count+"";
            txtTruDiem.Enabled = false;
            SetBounds(Screen.GetWorkingArea(this).Width - Width, Screen.GetWorkingArea(this).Height - Height, Width, Height);

            // btnLuuTam.Enabled = false;
            //btnHuyHoaDon.Enabled = false;

        }

        private void btnHienThiHang_Click(object sender, EventArgs e)
        {
            DisplayDataOrder();
        }

        //Phương thức tìm hàng theo tên danh mục
        private void cbDanhMuc_TextChanged(object sender, EventArgs e)
        {
            string ten = cbDanhMuc.SelectedItem.ToString();
            DanhMuc tim = db.DanhMucs.Where(d => d.TenDM.Equals(ten)).SingleOrDefault();
            string madm = tim.MaDM;
            var listtencogia = db.HangBans.Join(db.HangHoas, hb => hb.MaHang, hh => hh.MaHang,
               (hb, hh) => hh.TenHang).ToList();
            dgvHang.DataSource = db.HangHoas.Select(x => new
            {
                TenHang = x.TenHang,
                Anh = x.AnhHang,
                MaDM = x.MaDM
            }).Where(x => x.MaDM.Contains(madm) && listtencogia.Contains(x.TenHang)).ToList();
            dgvHang.Columns[0].Width = 280;
            dgvHang.Columns[1].Width = 160;
            dgvHang.Columns[2].Width = 5;
        }

        public void DisplayHangMua()
        {
            dgvHoaDon.DataSource = listHangMua.ToList();
            dgvHoaDon.Columns[0].Width = 200;
            dgvHoaDon.Columns[1].Width = 100;
            dgvHoaDon.Columns[2].Width = 100;
            dgvHoaDon.Columns[3].Width = 100;
        }

        public void Clear()
        {
            radS.Checked = false;
            radM.Checked = false;
            radL.Checked = false;
            txtDonGia.Text = "";
            numSoLuong.Value = 1;
        }

        public void ClearAll()
        {
            radS.Checked = false;
            radM.Checked = false;
            radL.Checked = false;
            txtDonGia.Text = "";
            numSoLuong.Value = 1;
            txtGiamGia.Text = phantramkhuyenmai + "";
            txtTruDiem.Text = "0";
            lblThanhToan.Text = "0";
            lblTongTien.Text = "0";
            lblMaBan.Text = lblDiemTL.Text = "______";
            lblMaKH.Text = "Khách Lẻ";
            listHangMua.Clear();
            dgvHoaDon.DataSource = listHangMua;
            /*listHangMua = null;
            dgvHoaDon.DataSource =listHangMua;*/

        }

        //Xóa hàng khách đã chọn
        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvHoaDon.Rows[index];
            tenhang = selectedRow.Cells[0].Value.ToString();
            //Check nếu là hàng trong ds lưu tạm thì không đc xóa
            List<ChiTietHoaDonLuuTam> listchitiethoadon = frmChiTietLuuTamHoaDon.li;
            string maban = lblMaBan.Text;
            var check = listchitiethoadon.Where(x => x.MaBan == maban && x.TenHang == tenhang).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Sản phẩm có trong danh sách lưu tạm. Không thể xóa", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            else
            {
                HangKhachMua tim = listHangMua.Find(x => x.Ten == tenhang);
                listHangMua.Remove(tim);
                DisplayHangMua();
                ThanhToan();
            }
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            radL.Checked = radM.Checked = radS.Checked = false;
            txtDonGia.Clear();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvHang.Rows[index];
            tenhang = selectedRow.Cells[0].Value.ToString();
            HangHoa tim = db.HangHoas.Where(d => d.TenHang.Equals(tenhang)).FirstOrDefault();
            mahang = tim.MaHang;
            if (tim.MaDM == "DM006")
            {
                HangBan t = db.HangBans.Where(x => x.MaHang.Equals(mahang)).FirstOrDefault();
                txtDonGia.Text = t.DonGia.ToString();
                radL.Enabled = false;
                radM.Enabled = false;
                radS.Enabled = false;
            }
            else
            {
                radL.Enabled = true;
                radM.Enabled = true;
                radS.Enabled = true;
            }
        }

        private void radS_Click(object sender, EventArgs e)
        {
            hb = db.HangBans.Where(x => x.MaHang.Contains(mahang) && x.Size == "S").FirstOrDefault();
            if (hb != null)
                txtDonGia.Text = hb.DonGia.ToString();
        }

        private void radL_Click(object sender, EventArgs e)
        {
            hb = db.HangBans.Where(x => x.MaHang.Contains(mahang) && x.Size == "L").FirstOrDefault();
            if (hb != null)
                txtDonGia.Text = hb.DonGia.ToString();
        }

        private void radM_Click(object sender, EventArgs e)
        {
            hb = db.HangBans.Where(x => x.MaHang.Contains(mahang) && x.Size == "M").FirstOrDefault();
            if (hb != null)
                txtDonGia.Text = hb.DonGia.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void txtTruDiem_TextChanged(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void txtGiamGia_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtGiamGia.Text == "")
                txtGiamGia.Text = "0";
        }

        private void txtTruDiem_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtTruDiem.Text == "")
                txtTruDiem.Text = "0";
        }

        //Chọn hàng mua
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string chonsize = "Bánh";
                if (radS.Checked == true)
                    chonsize = "S";
                else if (radM.Checked == true)
                    chonsize = "M";
                else if (radL.Checked == true)
                    chonsize = "L";
                else
                {
                    hb = db.HangBans.Where(x => x.MaHang.Contains(mahang) && x.Size == chonsize).FirstOrDefault();
                    if (hb != null)
                        txtDonGia.Text = hb.DonGia.ToString();
                }
                int gia = int.Parse(txtDonGia.Text);
                int soluong = int.Parse(numSoLuong.Value.ToString());
                HangKhachMua hang = new HangKhachMua(tenhang, chonsize, gia, soluong);
                //khách chọn them hàng đã mua(cộng thêm vào số lượng mua của khách)
                List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
                if (listHangMua.Contains(hang))
                {
                    var trung = listHangMua.Find(x => x.Ten == tenhang && x.Size == chonsize);
                    soluong += trung.SoLuong;
                    listHangMua.Remove(trung);
                }
                HangKhachMua hangmoi = new HangKhachMua(tenhang, chonsize, gia, soluong);
                listHangMua.Add(hangmoi);
                //Kiểm tra hóa đơn có trong danh sách lưu tạm không(nếu không có thì được phép xóa hóa đơn này)
                HoaDonLuuTam check = new HoaDonLuuTam(lblMaBan.Text);
                if (luutam.Contains(check))
                {
                    iconbtnHuyHoaDon.Enabled = false;
                }
                else
                {
                    iconbtnHuyHoaDon.Enabled = true;
                }
                DisplayHangMua();
                Clear();
                ThanhToan();
                // dgvTest.DataSource = listHangMua;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Chọn size khách mua !");
                return;
            }

        }

        //Tính tiền khách phải trả
        public void ThanhToan()
        {
            int TongTien = 0;
            /* if (listHangMua != null)
             {*/
            foreach (HangKhachMua item in listHangMua)
            {
                TongTien += item.Gia * item.SoLuong;
            }
            /* }*/
            lblTongTien.Text = TongTien + "";
            int DiemTichLuy;
            if (lblDiemTL.Text.Equals("______"))
                DiemTichLuy = 0;
            else
                DiemTichLuy = int.Parse(lblDiemTL.Text);
            try
            {
                int GiamGia = int.Parse(txtGiamGia.Text);
                int TruDiem = int.Parse(txtTruDiem.Text);
                if (TruDiem > DiemTichLuy) {
                    MessageBox.Show("Trừ điểm tích lũy tối đa là " + lblDiemTL.Text);
                    txtTruDiem.Text = "0";
                    return;
                }

                int ThanhToan;
                ThanhToan = (TongTien * (100 - GiamGia)) / 100 - TruDiem * 1000;
                lblThanhToan.Text = ThanhToan + "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        //Lấy thông tin khách hàng trong csdl
        private void btnLayThongTinKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang form = new frmQLKhachHang();
            form.send = new frmQLKhachHang.SendInfor(SetInfor);
            //this.Controls.Clear();
            /*form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);*/
            form.Show();
        }

        private void SetInfor(int makh, int diemtl)
        {

            lblMaKH.Text = makh + "";
            lblDiemTL.Text = diemtl + "";
            makhach = makh;
            if (diemtl > 100)
                txtTruDiem.Enabled = true;
            else
            {
                txtTruDiem.Text = "0";
                txtTruDiem.Enabled = false;

            }
            if (makh == 1 || makh == 0)
            {
                txtTruDiem.Text = "0";
                txtTruDiem.Enabled = false;
                lblMaKH.Text = "Khách Lẻ";
                lblDiemTL.Text = "______";
            }

        }

        //lưu tạm hóa đơn chưa thanh toán vào List luutam
        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
            List<ChiTietHoaDonLuuTam> listchitiethoadon = frmChiTietLuuTamHoaDon.li;
            try
            {

                string maban = lblMaBan.Text;
                if (listHangMua.Count == 0)
                {
                    MessageBox.Show("Hóa đơn rỗng. Không thể lưu tạm hóa đơn này", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (maban.Equals("______") || maban.Equals("")) {
                    MessageBox.Show("Chưa chọn bàn. Không thể lưu tạm hóa đơn này", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    int tongtien = int.Parse(lblTongTien.Text);
                    int giamgia = (int.Parse(txtGiamGia.Text));
                    int trudiem = int.Parse(txtTruDiem.Text);
                    HoaDonLuuTam hoadon = new HoaDonLuuTam();
                    hoadon.MaNV = (string)this.Tag;
                    hoadon.MaBan = lblMaBan.Text;
                    if (lblMaKH.Text == "Khách Lẻ")
                    {
                        hoadon.MaKH = 1;
                        hoadon.DTL = 0;
                    }
                    else
                        hoadon.MaKH = int.Parse(lblMaKH.Text);
                    hoadon.NgayLap = ngaylap;
                    hoadon.TongTien = tongtien;
                    hoadon.GiamGia = giamgia;
                    hoadon.TruDTL = trudiem;
                    if (lblDiemTL.Text == "______")
                        hoadon.DTL = 0;
                    else
                        hoadon.DTL = int.Parse(lblDiemTL.Text);
                    HoaDonLuuTam tim = luutam.Where(hd => lblMaBan.Text.Contains(hd.MaBan)).FirstOrDefault();
                    if (tim != null)
                        luutam.Remove(tim);
                    luutam.Add(hoadon);
                    frmLuuTamHoaDon.li = luutam;
                    //Luu danh sách hàng mua vào list chitiet, xóa ds hàng mua trong listHangMua
                    foreach (HangKhachMua item in listHangMua)
                    {
                        string tenhang = item.Ten;
                        string size = item.Size;
                        int gia = item.Gia;
                        int soluong = item.SoLuong;
                        ChiTietHoaDonLuuTam chitiet = new ChiTietHoaDonLuuTam(maban, tenhang, size, gia, soluong);
                        if (listchitiethoadon.Contains(chitiet))
                        {
                            var trung = listchitiethoadon.Find(x => x.MaBan == maban && x.TenHang == tenhang && x.Size == size);
                            listchitiethoadon.Remove(trung);
                        }
                        listchitiethoadon.Add(chitiet);
                        frmChiTietLuuTamHoaDon.li = listchitiethoadon;
                    }
                    ClearAll();
                    MessageBox.Show("Đã lưu vào danh sách lưu tạm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa có mã bàn");
            }

        }

        //Xem hóa đơn lưu tạm, chưa thanh toán
        private void button2_Click(object sender, EventArgs e)
        {


            // frmMain main = new frmMain(form);

            frmLuuTamHoaDon form = new frmLuuTamHoaDon();
            form.sendhoadonluutam = new frmLuuTamHoaDon.SendHoaDonLuuTam(SetHoaDon);
            form.Show();

        }

        private void SetHoaDon(string manv, int makh, string maban, string ngaylap, int tongtien, int giamgia, int trudtl, int diemtl)
        {

            if (makh == 1)
            {
                lblMaKH.Text = "Khách Lẻ";
                lblDiemTL.Text = "______";
            }
            else if (makh == 0) //trường hợp chưa chọn hóa đơn lưu tạm mà nhấn Thanh Toán
            {
                lblMaKH.Text = "Khách Lẻ";
                lblDiemTL.Text = "______";
                lblMaBan.Text = "______";
            }
            else
            {
                lblMaKH.Text = makh + "";
                lblDiemTL.Text = diemtl + "";
            }

            lblMaBan.Text = maban;
            txtGiamGia.Text = giamgia + "";
            txtTruDiem.Text = trudtl + "";
            lblTongTien.Text = tongtien + "";

            int tt = (tongtien * (100 - giamgia) / 100) - trudtl * 1000;
            lblThanhToan.Text = tt + "";
            //Hiển thị lại danh sách hàng khách mua
            listHangMua.Clear();
            List<ChiTietHoaDonLuuTam> listnow = frmChiTietLuuTamHoaDon.li;
            foreach (ChiTietHoaDonLuuTam item in listnow)
            {
                if (item.MaBan.Equals(maban))
                {
                    string tenhang = item.TenHang;
                    string chonsize = item.Size;
                    int gia = item.Gia;
                    int soluong = item.SoLuong;
                    HangKhachMua hang = new HangKhachMua(tenhang, chonsize, gia, soluong);
                    listHangMua.Add(hang);
                }
            }
            DisplayHangMua();
            // dgvTest.DataSource = null;
            // dgvTest.DataSource = listHangMua;

        }

        //Thanh toán-Tao hóa đơn, hóa đơn chi tiết của khách trong csdl
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (listHangMua.Count == 0)
            {
                MessageBox.Show("Chọn hàng mua trước khi thanh toán");
            }
            else
            {
                HoaDon newhd = new HoaDon();
                string TenTK = (string)this.Tag;
                newhd.MaNV = TenTK;

                if (lblMaBan.Text == "______")
                    newhd.MaBan = "0";
                else
                {
                    string maban = lblMaBan.Text;
                    maban = maban.Substring(0, 3);
                    newhd.MaBan = maban;

                }
                if (lblMaKH.Text == "Khách Lẻ")
                    newhd.MaKH = 1;
                else
                    newhd.MaKH = int.Parse(lblMaKH.Text);
                newhd.NgayLap = DateTime.Now;
                int tongtien = int.Parse(lblTongTien.Text);
                int giamgia = int.Parse(txtGiamGia.Text);//phần trăm giảm giá
                int trudiemtl = int.Parse(txtTruDiem.Text);
                newhd.TongTien = tongtien;

                newhd.GiamGia = (tongtien * giamgia) / 100;
                newhd.TruDiemTL = trudiemtl * 1000;
                //Thêm hóa đơn vào csdl
                db.HoaDons.Add(newhd);
                db.SaveChanges();
                List<HoaDon> hd = db.HoaDons.Select(x => x).ToList();

                //Thêm chi tiết hóa đơn
                //Duyệt lần lượt danh sách hàng mua thêm vào bảng hóa đơn chi tiết                
                foreach (HangKhachMua h in listHangMua)
                {
                    ChiTietHoaDon chitiet = new ChiTietHoaDon();
                    int index = hd.Count;
                    chitiet.MaHoaDon = hd[index - 1].MaHoaDon;
                    int t = chitiet.MaHoaDon;
                    HangHoa tim = db.HangHoas.Where(x => x.TenHang == h.Ten).FirstOrDefault();
                    chitiet.MaHang = tim.MaHang;
                    chitiet.Size = h.Size;
                    chitiet.SoLuong = h.SoLuong;
                    db.ChiTietHoaDons.Add(chitiet);
                    db.SaveChanges();
                }
                //xóa danh sách hàng mua trong listHangMua
                listHangMua.Clear();
                //xóa hóa đơn đang lưu tạm nếu có
                List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
                luutam.RemoveAll(x => lblMaBan.Text.Contains(x.MaBan));
                frmLuuTamHoaDon.li = luutam;
                //Xóa chi tiết hóa đơn đang lưu tạm nếu có
                List<ChiTietHoaDonLuuTam> listchitiethoadon = frmChiTietLuuTamHoaDon.li;
                listchitiethoadon.RemoveAll(x => lblMaBan.Text.Contains(x.MaBan));
                frmChiTietLuuTamHoaDon.li = listchitiethoadon;
                //Đưa trạng thái bàn về trống nếu có sử dụng
                List<Ban> ds = db.Bans.Select(s => s).ToList();
                foreach (Ban ban2 in ds)
                {
                    if (lblMaBan.Text.Contains(ban2.MaBan))
                        ban2.TrangThai = "Trống";
                    db.SaveChanges();
                }
                ClearAll();
                flpBan.Controls.Clear();
                DisplayDataBan();
                //Cộng điểm tích lũy cho khách nếu khách có trong danh sách khách hàng
                int thanhtoan = (tongtien * (100 - giamgia) / 100) - trudiemtl * 1000;
                int diemcong = thanhtoan / 10000;
                //Trừ điểm tích lũy nếu khách hàng dùng để thanh toán
                diemcong = diemcong - trudiemtl;
                //Sửa lại thông  điểm tích lũy của khách hàng trong csdl
                KhachHang sua = db.KhachHangs.Where(x => x.MaKH == newhd.MaKH).FirstOrDefault();
                if (sua != null)
                {
                    //không tính điểm tích lũy cho khách lẻ(makh=1)
                    if (sua.MaKH == 1) { }
                    else
                    {
                        sua.DiemTichLuy = sua.DiemTichLuy + diemcong;
                        db.Entry(sua).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                frmInHoaDon inhoadon = new frmInHoaDon();
                inhoadon.ShowDialog();

            }

        }

        //Hủy hóa đơn đang được tạo của khách (không được hủy hóa đơn có trong danh sách lưu tạm)
        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            //Kiểm tra hóa đơn có trong danh sách lưu tạm không(nếu không có thì được phép xóa hóa đơn này)
            List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
            HoaDonLuuTam check = luutam.Find(s => lblMaBan.Text.Contains(s.MaBan));
            if (check!=null)
            {
                MessageBox.Show("Hóa đơn đang có trong danh sách lưu tạm. Không thể hủy hóa đơn này", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                //Cập nhật lại trạng thái bàn
                List<Ban> dsBan = db.Bans.Select(s => s).ToList();
                foreach(Ban capnhat in dsBan)
                {
                    if (lblMaBan.Text.Contains(capnhat.MaBan))
                    {
                        capnhat.TrangThai = "Trống";
                        db.SaveChanges();
                    }
                }
                ClearAll();
                flpBan.Controls.Clear();
                DisplayDataBan();
                
                iconbtnHuyHoaDon.Enabled = true;
                
                MessageBox.Show("Hóa đơn đã được hủy");
            }
        }

        private void lblMaBan_TextChanged(object sender, EventArgs e)
        {
            /*Ban capnhat = db.Bans.Where(b => b.MaBan == lblMaBan.Text).FirstOrDefault();
            if (capnhat != null)
            {
                capnhat.TrangThai = "Trống";
                db.SaveChanges();
                flpBan.Controls.Clear();*/
            flpBan.Controls.Clear();
            DisplayDataBan();
            /*}*/
        }

        private void lblDiemTL_TextChanged(object sender, EventArgs e)
        {
            if (lblDiemTL.Text.Equals("______"))
            {
                txtTruDiem.Enabled = false;
            }
            else
            {
                if (int.Parse(lblDiemTL.Text) >= 100)
                {
                    txtTruDiem.Enabled = true;
                }
                else
                {
                    txtTruDiem.Enabled = false;
                }
            }
            checkTL.Checked = false;


        }
    
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmChiTietLuuTamHoaDon f = new frmChiTietLuuTamHoaDon();
            f.ShowDialog();
        }

        public void GhepBan()
        {
            flpBan.Controls.Clear();
            List<Ban> dsBan = db.Bans.Select(b => b).ToList();
            Ban khachle = db.Bans.Where(x => x.MaBan == "0").FirstOrDefault();
            dsBan.Remove(khachle);
            foreach (Ban item in dsBan)
            {
                Button b = new Button() { Width = 120, Height = 120 };
                b.Text = "Bàn " + item.MaBan + Environment.NewLine + item.TrangThai;
                //Hiển thị bàn lên
                flpBan.Controls.Add(b);
                b.Font = new Font("Arial", 14);
                switch (item.TrangThai)
                {
                    case "Trống":
                        b.BackColor = Color.Azure;
                        b.ForeColor = Color.Black;
                        b.FlatStyle = FlatStyle.Flat;
                        break;

                    default:
                        b.BackColor = Color.Cyan;
                        b.ForeColor = Color.Black;
                        b.FlatStyle = FlatStyle.Flat;
                        break;
                }
                //Bàn của hóa đơn hiện tại hiển thị màu đỏ
                if (lblMaBan.Text == "______") { }
                else
                {
                    List<Ban> hientai = db.Bans.Where(x =>lblMaBan.Text.Contains(x.MaBan)).ToList();
                    if (hientai != null)
                    {
                        foreach (Ban ban in hientai)
                        {
                            if (item.MaBan == ban.MaBan)
                            {
                                b.BackColor = Color.Red;
                            }
                        }
                    }
                }
                List<HoaDonLuuTam> luutam = frmLuuTamHoaDon.li;
                //Bắt sự kiện click của button
                b.Click += (sender, args) =>
                {
                    /*HoaDonLuuTam tim = luutam.Where(x => x.MaBan == item.MaBan).FirstOrDefault();
                    if (tim != null)
                    {
                        MessageBox.Show("Bàn này đang có người sử dụng");
                    }
                    else
                    {
                        if (item.TrangThai.Equals("Trống"))
                        {
                            item.TrangThai = "Có người";
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            lblMaBan.Text = item.MaBan;
                            b.Text = "Bàn " + item.MaBan + Environment.NewLine + "Có người";
                            b.ForeColor = Color.Black;
                            b.FlatStyle = FlatStyle.Flat;
                            *//*if (lblMaBan.Text == item.MaBan)
                            {
                                b.BackColor = Color.Red;
                            }
                            else
                            {*//*
                            b.BackColor = Color.Cyan;

                        }
                        else
                        {
                            item.TrangThai = "Trống";
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            lblMaBan.Text = "______";
                            b.Text = "Bàn " + item.MaBan + Environment.NewLine + "Trống";
                            //b.BackColor = Color.Azure;
                            b.ForeColor = Color.Black;
                            b.FlatStyle = FlatStyle.Flat;
                            *//*if (lblMaBan.Text == item.MaBan)
                            {
                                b.BackColor = Color.Red;
                            }
                            else
                            {*//*
                            b.BackColor = Color.Azure;

                        }
                    }*/
                    lblMaBan.Text += ", " + item.MaBan;
                };
                
               // DisplayDataBan();
            }
        }

        private void iconHienThiHD_Click(object sender, EventArgs e)
        {
            frmChiTietLuuTamHoaDon f = new frmChiTietLuuTamHoaDon();
            f.ShowDialog();
        }

        private void checkTL_CheckedChanged(object sender, EventArgs e)
        {
            int maxtru = int.Parse(lblThanhToan.Text) / 1000;
            if (checkTL.Checked == true)
            {
                if (lblDiemTL.Text == "______") { }
                else
                {
                    int dtl = int.Parse(lblDiemTL.Text);
                    if (dtl < 100) { }
                    else
                    {
                        if (dtl >= maxtru)
                            txtTruDiem.Text = maxtru + "";
                        else
                            txtTruDiem.Text = dtl + "";
                    }
                }
            }
            else
            {
                txtTruDiem.Text = "0";
            }
        }

        private void btnGhepBan_Click(object sender, EventArgs e)
        {
            if (lblMaBan.Text == "______")
            {
                MessageBox.Show("Chọn một bàn cần ghép trước. Xong nhấn ghép bàn. Chọn tiếp bàn muốn ghép chung");
                return;
            }
                GhepBan();
        }
    }
  
}
