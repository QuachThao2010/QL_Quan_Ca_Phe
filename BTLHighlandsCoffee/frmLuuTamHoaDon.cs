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
    public partial class frmLuuTamHoaDon : Form
    {
        public static List<HoaDonLuuTam> li = new List<HoaDonLuuTam>();
        string manhanvien, maban, ngaylap;
        int makhachhang, tongtien, giamgia, trudiemtichluy,diemtichluy;

        private void frmLuuTamHoaDon_Load(object sender, EventArgs e)
        {
            dgvLuuTam.DataSource = li;
            SetBounds(Screen.GetWorkingArea(this).Width - Width, Screen.GetWorkingArea(this).Height - Height, Width, Height);
        }

        private void frmLuuTamHoaDon_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmLuuTamHoaDon()
        {
            InitializeComponent();
            //CenterToScreen();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            sendhoadonluutam(manhanvien,makhachhang,maban,ngaylap,tongtien,giamgia,trudiemtichluy,diemtichluy);
            this.Close();
        }

        private void SetHoaDon(HoaDon luutam)
        {
            List<HoaDon> li = new List<HoaDon>();
            li.Add(luutam);
            dgvLuuTam.DataSource = li;
        }

        private void dgvLuuTam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvLuuTam.Rows[index];
                manhanvien = selectedRow.Cells[0].Value.ToString();
                makhachhang = int.Parse(selectedRow.Cells[1].Value.ToString());
                maban = selectedRow.Cells[2].Value.ToString();
                ngaylap = selectedRow.Cells[3].Value.ToString();
                tongtien = int.Parse(selectedRow.Cells[4].Value.ToString());
                giamgia = int.Parse(selectedRow.Cells[5].Value.ToString());
                trudiemtichluy = int.Parse(selectedRow.Cells[6].Value.ToString());
                diemtichluy = int.Parse(selectedRow.Cells[7].Value.ToString());
            }catch(Exception ex)
            {

            }
        }
        //Gửi thông tin hóa đơn chưa thanh toán sang phần bán hàng để thanh toán
        public delegate void SendHoaDonLuuTam(string manv,int makh,string maban,string ngaylap, int tongtien,int giamgia, int trudtl,int diemtl);
        public SendHoaDonLuuTam sendhoadonluutam;
    }
}
