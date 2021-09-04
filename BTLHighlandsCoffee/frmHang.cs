using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHighlandsCoffee
{
    public partial class frmHang : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        HangHoa h = new HangHoa();
        DanhMuc dm = new DanhMuc();
        string mahang, madanhmuc;

        public frmHang()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void DisplayData()
        {
            dgvDanhMuc.DataSource = db.DanhMucs.Select(p => new
            {
                MaDM = p.MaDM,
                TenDM = p.TenDM
            }).ToList();
            dgvDanhMuc.Columns[0].Width = 240;
            dgvDanhMuc.Columns[1].Width = 450;
            //
            dgvHangHoa.DataSource = db.HangHoas.Select(h => new
            {
                MaHang = h.MaHang,
                TenHang = h.TenHang,
                MoTa = h.MoTa,
                DanhMuc = h.DanhMuc.TenDM,
                Anh = h.AnhHang
                
            }).ToList();
            var dsdm = db.DanhMucs.Select(dm => dm.TenDM).ToList();
            comboBoxDM.DataSource = dsdm;
            dgvHangHoa.Columns[0].Width = 99;
            dgvHangHoa.Columns[1].Width = 150;
            dgvHangHoa.Columns[2].Width = 350;
            dgvHangHoa.Columns[3].Width = 150;
            dgvHangHoa.Columns[4].Width = 150;
        }

        private void Hang_Load(object sender, EventArgs e)
        {
            DisplayData();
            txtBanh.Visible = false;
        }

        public bool Check()
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                return false;
            if (string.IsNullOrWhiteSpace(richTextBoxMoTa.Text))
                return false;
            if (comboBoxDM.Text == "")
                return false;
            return true;
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên sản phẩm";
            txtTimKiem.ForeColor = Color.DarkGray;
            DisplayData();         
        }

        public void TaoMaHang()
        {
            List<HangHoa> dsHangHoa = db.HangHoas.Select(s => s).ToList();
            if (dsHangHoa.Count == 0)
            {
                mahang = "H001";
            }
            else
            {
                string t = dsHangHoa[dsHangHoa.Count - 1].MaHang.ToString();
                t = t.Substring(1, 3);
                int dem = Convert.ToInt32(t);
                dem = dem + 1;
                if (dem < 10)
                {
                    mahang = "H00";
                }
                else if (dem < 100)
                {
                    mahang = "H0";
                }
                else
                {
                    mahang = "H";
                }
                mahang = mahang + dem.ToString();
            }
        }

        public void TaoMaDanhMuc()
        {
            List<DanhMuc> dsDanhMuc = db.DanhMucs.Select(s => s).ToList();
            if (dsDanhMuc.Count == 0)
            {
                madanhmuc = "DM001";
            }
            else
            {
                string t = dsDanhMuc[dsDanhMuc.Count - 1].MaDM.ToString().Substring(2, 3);
                int dem;
                dem = Convert.ToInt32(t);
                dem = dem + 1;
                if (dem < 10)
                {
                    madanhmuc = "DM00";
                }
                else if (dem < 100)
                {
                    madanhmuc = "DM0";
                }
                else
                {
                    madanhmuc = "DM";
                }
                madanhmuc = madanhmuc + dem.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Nhập tên hàng cần thêm!");
                ActiveControl = txtTenHang;
                return;
            }
            if (string.IsNullOrWhiteSpace(richTextBoxMoTa.Text))
            {
                MessageBox.Show("Nhập mô tả của mặt hàng!");
                ActiveControl = richTextBoxMoTa;
                return;
            }
            if (comboBoxDM.Text == "")
            {
                MessageBox.Show("Chọn danh mục của mặt hàng này trong menu");
                ActiveControl = comboBoxDM;
                return;
            }
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("Bạn chưa thêm ảnh hàng!");
                ActiveControl = pictureBox1;
                return;
            }
            if (comboBoxDM.Text == "Bánh")
            {
                if (txtBanh.Text == "")
                {
                    MessageBox.Show("Nhập đơn giá của sản phẩm trước khi thêm");
                    return;
                }
            }
            else
            {
                if (txtS.Text == "" || txtM.Text == "" || txtL.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ đơn giá của sản phẩm trước khi thêm");
                    return;
                }
            }

            TaoMaHang();
            string tenhang = txtTenHang.Text;
            HangHoa check = db.HangHoas.Where(s => s.TenHang == tenhang).FirstOrDefault();//Kiểm tra mặt hàng đã có hay chưa
            if (check == null)
            {
               /* try
                {*/
                    byte[] b = ImageToByteArray(pictureBox1.Image);
                    hh.MaHang = mahang;
                    hh.TenHang = txtTenHang.Text;
                    hh.MoTa = richTextBoxMoTa.Text;
                    hh.AnhHang = b;
                    string tendm = comboBoxDM.SelectedItem.ToString();
                    DanhMuc tim = db.DanhMucs.Where(d => d.TenDM.Equals(tendm)).SingleOrDefault();
                    hh.MaDM = tim.MaDM;
                    if(hh.MaDM=="DM006")
                    {
                        //Nếu là bánh thì chỉ có một loại đơn giá
                        HangBan hb = new HangBan();
                        hb.MaHang = mahang;
                        hb.Size = "Bánh";
                        hb.DonGia = int.Parse(txtBanh.Text);
                        db.HangBans.Add(hb);

                    }
                    else
                    {
                        //Thêm đơn giá size S, M, L của sản phẩm vào bảng HangBan
                        //S
                        HangBan hbs = new HangBan();
                        hbs.MaHang = mahang;
                        hbs.Size = "S";
                        hbs.DonGia = int.Parse(txtS.Text);
                        db.HangBans.Add(hbs);
                        //M
                        HangBan hbm = new HangBan();
                        hbm.MaHang = mahang;
                        hbm.Size = "M";
                        hbm.DonGia = int.Parse(txtM.Text);
                        db.HangBans.Add(hbm);
                        //L
                        HangBan hbl = new HangBan();
                        hbl.MaHang = mahang;
                        hbl.Size = "L";
                        hbl.DonGia = int.Parse(txtL.Text);
                        if (hbs.DonGia > hbm.DonGia || hbs.DonGia > hbl.DonGia || hbl.DonGia < hbs.DonGia || hbl.DonGia < hbm.DonGia)
                        {
                            MessageBox.Show("Đơn giá tăng dần theo size S-M-L");
                            return;
                        }
                        else
                        {
                            db.HangBans.Add(hbl);
                        }
                    }
                    db.HangHoas.Add(hh);
                    db.SaveChanges();
                    DisplayData();
                    Clear();
                    MessageBox.Show("Thêm sản phẩm thành công");

            /*}
                catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
                return;
            }*/
        }
            else
            {
                MessageBox.Show("Tên hàng bị trùng. Không thể thêm");
            }

        }

        byte[] ImageToByteArray(Image img)
        {
            /*try
            {*/
                MemoryStream m = new MemoryStream();
                img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                return m.ToArray();
            /*}catch(Exception ex)
            {
                MessageBox.Show("Chưa có ảnh hàng!");
                return;
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        Image ByteToArray(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dgvHangHoa.Rows[index];
                mahang = selectRow.Cells[0].Value.ToString();
                txtTenHang.Text = selectRow.Cells[1].Value.ToString();
                richTextBoxMoTa.Text = selectRow.Cells[2].Value.ToString();
                string madm = selectRow.Cells[3].Value + "";

                if (madm.CompareTo("Cà phê pha phin") == 0)
                {
                    comboBoxDM.SelectedIndex = 0;
                }
                if (madm.CompareTo("Cà phê Espresso") == 0)
                {
                    comboBoxDM.SelectedIndex = 1;
                }
                if (madm.CompareTo("Phindi") == 0)
                {
                    comboBoxDM.SelectedIndex = 2;
                }
                if (madm.CompareTo("Trà") == 0)
                {
                    comboBoxDM.SelectedIndex = 3;
                }
                if (madm.CompareTo("Freeze") == 0)
                {
                    comboBoxDM.SelectedIndex = 4;
                }
                if (madm.CompareTo("Bánh") == 0)
                {
                    comboBoxDM.SelectedIndex = 5;
                }
                if (madm.CompareTo("Thức uống khác") == 0)
                {
                    comboBoxDM.SelectedIndex = 6;
                }
                byte[] b = (byte[])selectRow.Cells[4].Value;
                pictureBox1.Image = ByteToArray(b);
                if(madm.CompareTo("Bánh") == 0)
                {
                    HangBan tim = db.HangBans.Where(hb => hb.MaHang == mahang).FirstOrDefault();
                    txtBanh.Text = tim.DonGia + "";
                }
                else
                {
                    HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == mahang && hb.Size == "S").FirstOrDefault();
                    txtS.Text = tim1.DonGia+"";
                    HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == mahang  && hb.Size == "M").FirstOrDefault();
                    txtM.Text = tim2.DonGia + "";
                    HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == mahang && hb.Size == "L").FirstOrDefault();
                    txtL.Text = tim3.DonGia + "";
                }
            }catch(Exception ex)
            {
                return;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenhang = txtTenHang.Text;
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Nhập tên sản phẩm cần sửa");
                return;
            }
            if(richTextBoxMoTa.Text=="" && pictureBox1.Image==null && comboBoxDM.Text=="" && txtBanh.Text==""
                && txtL.Text=="" && txtM.Text=="" && txtS.Text == "")
            {
                MessageBox.Show("Nhập thông tin cần sửa");
                return;
            }
            if (mahang == "")
            {
                HangHoa find = db.HangHoas.Where(s => s.TenHang == txtTenHang.Text).FirstOrDefault();
                if (find == null)
                {
                    MessageBox.Show(""+txtTenHang.Text+" không có trong danh sách. Không thể sửa");
                    return;
                }
                else
                {
                    if (richTextBoxMoTa.Text == "") { }
                    else
                    {
                        find.MoTa = richTextBoxMoTa.Text;
                    }
                    if (pictureBox1.Image == null) { }
                    else
                    {
                        byte[] b = ImageToByteArray(pictureBox1.Image);
                        find.AnhHang = b;
                    }
                    string tendm, madm;
                    if (comboBoxDM.Text == "") { }
                    else
                    {
                        tendm = comboBoxDM.SelectedItem.ToString();
                        DanhMuc t = db.DanhMucs.Where(d => d.TenDM.Equals(tendm)).SingleOrDefault();
                        madm = t.MaDM;
                        if (find.MaDM == "DM006" && tendm != "Bánh")
                        {
                            MessageBox.Show("Đây là bánh. Không thể cho vào danh mục khác");
                            comboBoxDM.Text = "Bánh";
                            return;
                        }
                        else if (find.MaDM != "DM006" && tendm == "Bánh")
                        {
                            MessageBox.Show("Đây là đồ uống. Không thể cho vào danh mục bánh");
                            comboBoxDM.Text = find.DanhMuc.TenDM;
                            return;
                        }
                        else
                        {
                            find.MaDM = madm;
                        }
                    }
                    if (find.MaDM == "DM006")
                    {
                        //Nếu là bánh thì chỉ có một loại đơn giá
                        HangBan tim4 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "Bánh").FirstOrDefault();
                        if (txtBanh.Text == "") { }
                        else
                        {
                            tim4.DonGia = int.Parse(txtBanh.Text);
                        }

                    }
                    else
                    {
                        //Sửa đơn giá size S, M, L của sản phẩm vào bảng HangBan
                        double dgS, dgM, dgL;
                        //S
                        if (txtS.Text == "")
                        {

                            HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "S").FirstOrDefault();
                            dgS = tim1.DonGia;

                        }
                        else
                        {
                            HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "S").FirstOrDefault();
                            tim1.DonGia = int.Parse(txtS.Text);
                            dgS = int.Parse(txtS.Text);
                        }
                        //M
                        if (txtM.Text == "")
                        {
                            HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "M").FirstOrDefault();
                            dgM = tim2.DonGia;
                        }
                        else
                        {
                            HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "M").FirstOrDefault();
                            tim2.DonGia = int.Parse(txtM.Text);
                            dgM = int.Parse(txtM.Text);
                        }
                        //L
                        if (txtL.Text == "")
                        {
                            HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "L").FirstOrDefault();
                            dgL = tim3.DonGia;
                        }
                        else
                        {
                            HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "L").FirstOrDefault();
                            tim3.DonGia = int.Parse(txtL.Text);
                            dgL = int.Parse(txtL.Text);
                        }
                        if (dgS > dgM || dgS > dgL || dgL < dgS || dgL < dgM)
                        {
                            MessageBox.Show("Đơn giá tăng dần theo size S-M-L");
                            return;
                        }

                    }

                }
            }
            else
            {
                HangHoa find = db.HangHoas.Where(s => s.MaHang == mahang).FirstOrDefault();
                if (txtTenHang.Text == "") { }
                else
                {
                    string tencu = find.TenHang;
                    string tenmoi = txtTenHang.Text;
                    HangHoa checkten = db.HangHoas.Where(s => s.TenHang == txtTenHang.Text).FirstOrDefault();
                    if (checkten == null || tencu == tenmoi)
                    {
                        find.TenHang = txtTenHang.Text;
                    }
                    else
                    {
                        MessageBox.Show("Tên bị trùng. Không thể sửa");
                        return;
                    }
                }
                if (richTextBoxMoTa.Text == "") { }
                else
                {
                    find.MoTa = richTextBoxMoTa.Text;
                }
                if (pictureBox1.Image == null) { }
                else
                {
                    byte[] b = ImageToByteArray(pictureBox1.Image);
                    find.AnhHang = b;
                }
                string tendm, madm;
                if (comboBoxDM.Text == "") { }
                else
                {
                    tendm = comboBoxDM.SelectedItem.ToString();
                    DanhMuc t = db.DanhMucs.Where(d => d.TenDM.Equals(tendm)).SingleOrDefault();
                    madm = t.MaDM;
                    if (find.MaDM == "DM006" && tendm != "Bánh")
                    {
                        MessageBox.Show("Đây là bánh. Không thể cho vào danh mục khác");
                        comboBoxDM.Text = "Bánh";
                        return;
                    }
                    else if (find.MaDM != "DM006" && tendm == "Bánh") {
                        MessageBox.Show("Đây là đồ uống. Không thể cho vào danh mục bánh");
                        comboBoxDM.Text = find.DanhMuc.TenDM;
                        return;
                    }
                    else
                    {
                        find.MaDM = madm;
                    }
                }
                if (find.MaDM == "DM006")
                {
                    //Nếu là bánh thì chỉ có một loại đơn giá
                    HangBan tim4 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "Bánh").FirstOrDefault();
                    if (txtBanh.Text == "") { }
                    else
                    {   
                        tim4.DonGia = int.Parse(txtBanh.Text);
                    }

                }
                else
                {
                    //Sửa đơn giá size S, M, L của sản phẩm vào bảng HangBan
                    double dgS, dgM, dgL;
                    //S
                    if (txtS.Text == "")
                    {

                        HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "S").FirstOrDefault();
                        dgS = tim1.DonGia;

                    }
                    else
                    {
                        HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "S").FirstOrDefault();
                        tim1.DonGia = int.Parse(txtS.Text);
                        dgS = int.Parse(txtS.Text);
                    }
                    //M
                    if (txtM.Text == "")
                    {
                        HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "M").FirstOrDefault();
                        dgM = tim2.DonGia;
                    }
                    else
                    {
                        HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "M").FirstOrDefault();
                        tim2.DonGia = int.Parse(txtM.Text);
                        dgM = int.Parse(txtM.Text);
                    }
                    //L
                    if (txtL.Text == "")
                    {
                        HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "L").FirstOrDefault();
                        dgL = tim3.DonGia;
                    }
                    else
                    {
                        HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == find.MaHang && hb.Size == "L").FirstOrDefault();
                        tim3.DonGia = int.Parse(txtL.Text);
                        dgL = int.Parse(txtL.Text);
                    }
                    if (dgS > dgM || dgS > dgL || dgL < dgS || dgL < dgM)
                    {
                        MessageBox.Show("Đơn giá tăng dần theo size S-M-L");
                        return;
                    }

                }

            }
            db.SaveChanges();
            DisplayData();
            Clear();
            mahang = "";
            MessageBox.Show("Sửa thông tin hàng thành công");             
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HangHoa hh = null;
            string tenhang = txtTenHang.Text;
            if (string.IsNullOrWhiteSpace(tenhang))
            {
                MessageBox.Show("Nhập tên hàng cần xóa");
            }
            else
            {
                hh = db.HangHoas.Where(s => s.TenHang == tenhang).FirstOrDefault();
                if (hh != null)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        try
                        {
                            db.HangHoas.Remove(hh);
                            db.SaveChanges();
                            DisplayData();
                            Clear();
                            MessageBox.Show("Xóa thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(""+ tenhang + " không có trong danh sách hàng hóa. Không thể xóa!");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnHTDanhMuc_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = db.DanhMucs.Select(p => new
            {
                MaDM = p.MaDM,
                TenDM = p.TenDM
            }).ToList();
            dgvDanhMuc.Columns[0].Width = 120;
            dgvDanhMuc.Columns[1].Width = 250;
            
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống");
                return;
            }
            TaoMaDanhMuc();
            try
            {
                DanhMuc check = db.DanhMucs.Where(s => s.TenDM == txtTenDM.Text).FirstOrDefault();
                if (check == null)
                {
                    DanhMuc them =new DanhMuc();
                    them.MaDM = madanhmuc;
                    them.TenDM = txtTenDM.Text;
                    db.DanhMucs.Add(them);
                    db.SaveChanges();
                    DisplayData();
                    Clear();
                    MessageBox.Show("Thêm danh mục thành công");
                }
                else
                {
                    MessageBox.Show("Danh mục " + txtTenDM.Text + " đã có trong danh sách. Không thể thêm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDM.Text == "")
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                    return;
                }
                DanhMuc check = db.DanhMucs.Where(s => s.TenDM == txtTenDM.Text).FirstOrDefault();
                if (check == null)
                {
                        dm = db.DanhMucs.Where(s => s.MaDM == madanhmuc).FirstOrDefault();
                        if (dm == null)
                        {
                            MessageBox.Show("Chọn danh mục cần sửa trong danh sách");
                            return;
                        }
                        dm.TenDM = txtTenDM.Text;
                        db.Entry(dm).State = EntityState.Modified;
                        db.SaveChanges();
                        DisplayData();
                        Clear();
                        MessageBox.Show("Sửa thông tin danh mục thành công");
                }
                else
                    {
                        MessageBox.Show("Tên danh mục " + txtTenDM.Text + " bị trùng. Không thể sửa!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Nhập tên danh mục cần xóa");
            }
            else
            {
                dm = db.DanhMucs.Where(s => s.TenDM == txtTenDM.Text).FirstOrDefault();
                if (dm != null)
                {

                    if (MessageBox.Show("Bạn chắc chắn muốn xóa mặt danh mục này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        try
                        {
                            db.DanhMucs.Remove(dm);
                            db.SaveChanges();
                            DisplayData();
                            Clear();
                            MessageBox.Show("Xóa thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Danh mục " + txtTenDM + " không có trong danh sách danh mục !");
                }
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDanhMuc.Rows[index];
            madanhmuc = selectedRow.Cells[0].Value.ToString();
            txtTenDM.Text=selectedRow.Cells[1].Value.ToString();
            dgvHangHoa.DataSource = db.HangHoas.Select(h => new
            {
                MaHang = h.MaHang,
                TenHang = h.TenHang,
                MoTa = h.MoTa,
                DanhMuc = h.DanhMuc.TenDM,
                Anh = h.AnhHang
            }).Where(x => x.DanhMuc.Contains(txtTenDM.Text)).ToList();
            dgvHangHoa.Columns[0].Width = 100;
            dgvHangHoa.Columns[1].Width = 155;
            dgvHangHoa.Columns[2].Width = 350;
            dgvHangHoa.Columns[3].Width = 165;
            dgvHangHoa.Columns[4].Width = 150;

        }

        public void Clear()
        {
            txtTenDM.Text = txtTenHang.Text = txtTenDM.Text = richTextBoxMoTa.Text = comboBoxDM.Text = "";
            pictureBox1.Image = null;
            txtBanh.Text = txtS.Text = txtM.Text = txtL.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void comboBoxDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDM.Text == "Bánh")
            {
                txtBanh.Visible= true;
                txtS.Visible = false;
                txtM.Visible = false;
                txtL.Visible = false;
                lblS.Visible = false;
                lblM.Visible = false;
                lblL.Visible = false;
               
            }
            else
            {
                txtBanh.Visible = false;
                txtS.Visible = true;
                txtM.Visible = true;
                txtL.Visible = true;
                lblS.Visible = true;
                lblM.Visible = true;
                lblL.Visible = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == ""||txtTimKiem.Text=="Nhập tên sản phẩm")
            {
                DisplayData();
            }
            else
            {
                dgvHangHoa.DataSource = db.HangHoas.Select(h => new
                {
                    MaHang = h.MaHang,
                    TenHang = h.TenHang,
                    MoTa = h.MoTa,
                    DanhMuc = h.DanhMuc.TenDM,
                    Anh = h.AnhHang
                }).Where(x => x.TenHang.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
                dgvHangHoa.Columns[0].Width = 100;
                dgvHangHoa.Columns[1].Width = 155;
                dgvHangHoa.Columns[2].Width = 350;
                dgvHangHoa.Columns[3].Width = 165;
                dgvHangHoa.Columns[4].Width = 150;
            }

        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            List<HangHoa> li = db.HangHoas.Select(s => s).ToList();
            int somathang = li.Count;
            int sodong = dgvHangHoa.Rows.Count;
            if (dgvHangHoa.Rows.Count == 0 || dgvHangHoa.Rows.Count == somathang) 
            {
                txtTimKiem.Text = "Nhập tên sản phẩm";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
            
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên sản phẩm")
            {
                txtTimKiem.Text = null;
            }
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTenHang.Text.ToLower().Contains("bánh"))
            {
                txtBanh.Visible = true;
                txtS.Visible = false;
                txtM.Visible = false;
                txtL.Visible = false;
                lblS.Visible = false;
                lblM.Visible = false;
                lblL.Visible = false;
                HangHoa hang = db.HangHoas.Where(s => s.TenHang == txtTenHang.Text).FirstOrDefault();
                if (hang != null)
                {
                    richTextBoxMoTa.Text = hang.MoTa;
                    byte[] b = (byte[])hang.AnhHang;
                    pictureBox1.Image = ByteToArray(b);
                    comboBoxDM.Text = hang.DanhMuc.TenDM;
                    HangBan tim4 = db.HangBans.Where(hb => hb.MaHang == hang.MaHang && hb.Size == "Bánh").FirstOrDefault();
                    txtBanh.Text = tim4.DonGia + "";
                }
            }
            else
            {
                txtBanh.Visible = false;
                txtS.Visible = true;
                txtM.Visible = true;
                txtL.Visible = true;
                lblS.Visible = true;
                lblM.Visible = true;
                lblL.Visible = true;
                HangHoa hang = db.HangHoas.Where(s => s.TenHang == txtTenHang.Text).FirstOrDefault();
                if (hang != null)
                {
                    richTextBoxMoTa.Text = hang.MoTa;
                    byte[] b = (byte[])hang.AnhHang;
                    pictureBox1.Image = ByteToArray(b);
                    comboBoxDM.Text = hang.DanhMuc.TenDM;
                    //S
                    HangBan tim1 = db.HangBans.Where(hb => hb.MaHang == hang.MaHang && hb.Size == "S").FirstOrDefault();
                    txtS.Text=tim1.DonGia+"";
                    //M
                    HangBan tim2 = db.HangBans.Where(hb => hb.MaHang == hang.MaHang && hb.Size == "M").FirstOrDefault();
                    txtM.Text = tim2.DonGia + "";
                    //L
                    HangBan tim3 = db.HangBans.Where(hb => hb.MaHang == hang.MaHang && hb.Size == "L").FirstOrDefault();
                    txtL.Text = tim3.DonGia + "";
                }
                else
                {
                    richTextBoxMoTa.Text = comboBoxDM.Text = "";
                    pictureBox1.Image = null;
                    txtBanh.Text = txtS.Text = txtM.Text = txtL.Text = "";
                }
            }

        }
    }
}
