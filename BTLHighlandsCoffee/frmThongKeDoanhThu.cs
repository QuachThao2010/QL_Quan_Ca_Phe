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
using System.Windows.Forms.DataVisualization.Charting;

namespace BTLHighlandsCoffee
{
    public partial class frmThongKeDoanhThu : Form
    {
        ManagerHighlandsCoffeeEntities db = new ManagerHighlandsCoffeeEntities();
        ChiTietHoaDon cthd = new ChiTietHoaDon();
        DateTime start, end;
       // string ngaylap = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        List<HangThongKe> list = new List<HangThongKe>();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            CenterToScreen();
            
        }
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            start = first;
            end = last;
            rad7ngay.Checked = true;
            radCot.Checked = true;
            btnBieuDo_Click(sender, e);

        }

        public int CheckInList(string mahang, List<HangThongKe> li)
        {
            for(int i = 0; i < li.Count; i++)
            {
                if (li[i].Ma == mahang)
                    return i;
            }
            return -1;
        }

        public List<HangThongKe> GetAllHangByDate(DateTime dateStart, DateTime dateFinnish)
        {
            List<HangThongKe> li = new List<HangThongKe>();
            var hd = db.HoaDons.Select(x => x);//lấy ra tất cả hóa đơn
            foreach (var x in hd)//duyệt danh sách hóa đơn
            {
                DateTime ngaylap = x.NgayLap.Value.Date;
                if (DateTime.Compare(ngaylap, dateStart) >= 0 && DateTime.Compare(ngaylap, dateFinnish) <= 0)//kiểm tra ngày trong khoảng cần tìm
                {
                    int mahd = x.MaHoaDon;
                    //lấy ra tất cả sản phẩm bán trong khoảng thời gian trên
                    var record = db.ChiTietHoaDons.Join(db.HangHoas, ct => ct.MaHang, hh => hh.MaHang,
                        (ct, hh) => new
                        {
                            chitiet = ct,
                            hangban = hh
                        }).Where(p => p.chitiet.MaHoaDon == mahd).Select(p => new
                        {
                            mahang = p.hangban.MaHang,
                            tenhang = p.hangban.TenHang,
                            soluongban = p.chitiet.SoLuong

                        });
                    foreach (var item in record)//duyệt và thêm vào list
                    {
                        string mahang = item.mahang;
                        string tenhang = item.tenhang;
                        int soluongban = item.soluongban;
                        int index = CheckInList(mahang, li);
                        if(index==-1)//Nếu mặt hàng chưa có thì thêm vào list
                        {
                            HangThongKe them = new HangThongKe(mahang, tenhang,soluongban);
                            li.Add(them);
                        }        
                        else//Đã có thì có  thì cộng thêm số lượng
                        {
                            li[index].SoLuong += soluongban;
                                   
                        }

                    }

                }
                var list = db.HangBans.Join(db.HangHoas, hb => hb.MaHang, hh => hh.MaHang,
                (hb, hh) =>new {
                        hh.MaHang,
                        hh.TenHang 
                }).ToList();
                foreach (var item in list)
                {
                    int index = CheckInList(item.MaHang, li);
                    if (index == -1)
                    {
                        HangThongKe them = new HangThongKe(item.MaHang, item.TenHang, 0);
                        li.Add(them);
                    }
                }

            }
            return li;
        }

        public void HienThi(DateTime dateStart, DateTime dateFinnish)
        {
            list.Sort();
            dgvSoLuongBan.DataSource = list.Select(p => new
            {
                mahang = p.Ma,
                tenhang = p.Ten,
                soluongban = p.SoLuong
            }).ToList();
            if (list.Count <= 0)
            {
                
                lblDoanhThu.Text = " 0 VNĐ";
                lblBanChay.Text = "______";
            }
            else
            {
                double DoanhThu = 0;
                var hd = db.HoaDons.Select(x => x);//lấy ra tất cả hóa đơn
                foreach (var x in hd)//duyệt danh sách hóa đơn
                {
                    DateTime ngaylap = x.NgayLap.Value.Date;
                    if (DateTime.Compare(ngaylap, dateStart) >= 0 && DateTime.Compare(ngaylap, dateFinnish) <= 0)//kiểm tra ngày trong khoảng cần tìm
                    {
                        DoanhThu += x.TongTien-x.GiamGia-x.TruDiemTL;
                    }
                }
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                lblDoanhThu.Text = DoanhThu.ToString("#,###.###", cul.NumberFormat) + " VNĐ";
                string ten = "";
                foreach(HangThongKe item in list)
                {
                    if(item.SoLuong==list[0].SoLuong)
                        ten+= item.Ten + ", ";
                }
                ten=ten.Substring(0,ten.Length - 2);
                lblBanChay.Text = ten;
                lblSLMax.Text=list[0].SoLuong+" sản phẩm";
                
            }
        }

        private void btnKhoang_Click(object sender, EventArgs e)
        {
            start = timeBD.Value.Date;
            end = timeKT.Value.Date;
            if (start.CompareTo(end) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo");
                return;
            }
            list = GetAllHangByDate(start, end);
            HienThi(start, end);
        }

        private void btnThangNay_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month;
            var last = today;
            start = first;
            end = DateTime.Today;
            list = GetAllHangByDate(first, last);
            HienThi(first, last);
        }

        private void btnThangTruoc_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            start = first;
            end = last;
            list = GetAllHangByDate(first, last);
            HienThi(first, last);
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            DateTime ngayhientai = DateTime.Today;
            start = ngayhientai;
            end = ngayhientai;
            list = GetAllHangByDate(start,end);
            HienThi(start, end);
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            chartDoanhThu.Series["Doanh thu"].Points.Clear();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tổng doanh thu(triệu đồng)";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            if (radCot.Checked == true)
            {
                chartDoanhThu.Series[0].ChartType = SeriesChartType.Column;
            }
            else
            {
                chartDoanhThu.Series[0].ChartType = SeriesChartType.Line;
            }
            if (rad7ngay.Checked == true)
            {
                chartDoanhThu.Titles.Clear();
                Title t = chartDoanhThu.Titles.Add("BIỂU ĐỒ DOANH THU 7 NGÀY GẦN ĐÂY");
                t.ForeColor = Color.Red;
                t.Font = new Font("Arial", 12.0f);
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Maximum = 3;
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
                for (int i = 1; i <= 7; i++)
                {
                    DateTime now = DateTime.Today;
                    DateTime day = now.AddDays(-i);
                    double DoanhThu = 0;
                    var hd = db.HoaDons.Select(x => x);  //lấy ra tất cả hóa đơn
                    foreach (var x in hd)                //duyệt danh sách hóa đơn
                    {
                        DateTime ngaylap = x.NgayLap.Value.Date;
                        if (DateTime.Compare(ngaylap, day) >= 0 && DateTime.Compare(ngaylap, day) <= 0)//kiểm tra ngày trong khoảng cần tìm
                        {
                             DoanhThu += x.TongTien-x.GiamGia-x.TruDiemTL;
                        }
                    }
                    chartDoanhThu.Series["Doanh thu"].Points.AddXY(day.ToShortDateString(),
                        DoanhThu / 1000000);
                }
            }
            if (rad3thang.Checked == true)
            {
                chartDoanhThu.Titles.Clear();
                Title t = chartDoanhThu.Titles.Add("BIỂU ĐỒ DOANH THU 3 THÁNG GẦN ĐÂY ");
                t.ForeColor = Color.Red;
                t.Font = new Font("Arial", 12.0f);
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Maximum = 10;
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
                for (int i = 0; i <= 2; i++)
                {
                    DateTime today = DateTime.Today;
                    var month = new DateTime(today.Year, today.Month, 1);
                    var first = month.AddMonths(-i);
                    var last = first.AddMonths(1).AddDays(-1);
                    //textBox1.Text = first + "";
                    double DoanhThu = 0;
                    var hd = db.HoaDons.Select(x => x);//lấy ra tất cả hóa đơn
                    foreach (var x in hd)//duyệt danh sách hóa đơn
                    {
                        DateTime ngaylap = x.NgayLap.Value.Date;
                        if (DateTime.Compare(ngaylap, first) >= 0 && DateTime.Compare(ngaylap, last) <= 0)//kiểm tra ngày trong khoảng cần tìm
                        {
                            DoanhThu += x.TongTien - x.GiamGia - x.TruDiemTL;

                        }
                    }
                    chartDoanhThu.Series["Doanh thu"].Points.AddXY(first.Month,
                        DoanhThu / 1000000);
                }
            }

        }

        public void exportExcelFile()
        {
            int rowIndex = 2;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            excelApp.Range["A2", "C2"].Merge();
            excelApp.Cells[rowIndex, 1].Font.Bold = true;
            excelApp.Cells[rowIndex, 1].Font.Size = 14;
            excelApp.Cells[rowIndex, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 1] = "HighlandsCoffee";
            rowIndex++;
            excelApp.Range["A3", "D3"].Merge();
            excelApp.Cells[rowIndex, 1].Font.Bold = true;
            excelApp.Cells[rowIndex, 1] = "Địa chỉ: Tầng Hầm B2, 72A, Nguyễn Trãi,";
            rowIndex++;
            excelApp.Range["A4", "D4"].Merge();
            excelApp.Cells[rowIndex, 1].Font.Bold = true;
            excelApp.Cells[rowIndex, 1] = "Quận Thanh Xuân, Hà Nội";
            rowIndex = rowIndex + 2;
            excelApp.Cells[rowIndex, 4].Font.Bold = true;
            excelApp.Cells[rowIndex, 4].Font.Size= 20;
            excelApp.Cells[rowIndex, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 4] = "BÁO CÁO DOANH THU";
            rowIndex++;
            if (DateTime.Compare(start, end) != 0)
            {
                excelApp.Cells[rowIndex, 1].Font.Bold = true;
                excelApp.Cells[rowIndex, 1] = "Thời gian bắt đầu: ";
                excelApp.Cells[rowIndex, 2].Font.Bold = true;
                excelApp.Cells[rowIndex, 2] = start.ToShortDateString();
                rowIndex++;
                excelApp.Cells[rowIndex, 1].Font.Bold = true;
                excelApp.Cells[rowIndex, 1] = "Thời gian kết thúc: ";
                excelApp.Cells[rowIndex, 2].Font.Bold = true;
                excelApp.Cells[rowIndex, 2] = end.ToShortDateString();
                rowIndex++;
            }
            else
            {
                excelApp.Cells[rowIndex, 1].Font.Bold = true;
                excelApp.Cells[rowIndex, 1] = "Ngày: ";
                excelApp.Cells[rowIndex, 2].Font.Bold = true;
                excelApp.Cells[rowIndex, 2] = start.ToShortDateString();
                rowIndex++;
            }
            rowIndex++;
            excelApp.Cells[rowIndex, 4].Font.Size = 12;
            excelApp.Cells[rowIndex, 4].Font.Bold = true;
            excelApp.Cells[rowIndex, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Range["B6", "E5"].Merge();
            excelApp.Cells[rowIndex, 4] = "THỐNG KÊ HÀNG BÁN";
            rowIndex+=2;
            //header table
            excelApp.Cells[rowIndex, 2] = "STT";
            excelApp.Cells[rowIndex, 2].Interior.Color = System.Drawing.Color.DimGray;
            excelApp.Cells[rowIndex, 2].Font.Color= System.Drawing.Color.White;
            excelApp.Cells[rowIndex, 2].Font.Bold = true;
            excelApp.Cells[rowIndex, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 2].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelApp.Cells[rowIndex, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            for (int i = 1; i < dgvSoLuongBan.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i + 2].Interior.Color = System.Drawing.Color.DimGray;
                excelApp.Cells[rowIndex, i + 2].Font.Color = System.Drawing.Color.White;
                excelApp.Cells[rowIndex, i + 2].Font.Bold = true;
                excelApp.Cells[rowIndex, i + 2].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                excelApp.Cells[rowIndex, i + 2] = dgvSoLuongBan.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            int count = 1;
            for(int i = 0; i < dgvSoLuongBan.Rows.Count; i++)
            {
                excelApp.Cells[i + rowIndex, 2] = count;
                excelApp.Cells[i + rowIndex, 2].Interior.Color = System.Drawing.Color.Gainsboro;
                excelApp.Cells[i + rowIndex, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                excelApp.Cells[i + rowIndex, 2].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                for (int j = 0; j < dgvSoLuongBan.Columns.Count; j++)
                {
                    excelApp.Cells[i + rowIndex, j + 3].Interior.Color = System.Drawing.Color.Gainsboro;
                    excelApp.Cells[i + rowIndex, j + 3] = dgvSoLuongBan.Rows[i].Cells[j].Value + "";
                    excelApp.Cells[i + rowIndex, j + 3].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    excelApp.Cells[i + rowIndex, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                }
                count++;
            }
            rowIndex += count + 1;
            excelApp.Range["A29", "G29"].Merge();
            excelApp.Range["A30", "G30"].Merge();
            excelApp.Cells[rowIndex, 1].Font.Bold = true;
            excelApp.Cells[rowIndex, 1] = "Doanh thu: "+lblDoanhThu.Text;
            //excelApp.Cells[rowIndex, 2] = lblDoanhThu.Text;
            rowIndex ++;
            excelApp.Range["A31", "G31"].Merge();
            excelApp.Cells[rowIndex, 1].Font.Bold = true;
            excelApp.Cells[rowIndex, 1] = "Sản phẩm bán chạy nhất: "+lblBanChay.Text+ "/ "+lblSLMax.Text;
            rowIndex ++;
            rowIndex = rowIndex + 3;
            excelApp.Cells[rowIndex, 5].Font.Bold = true;
            excelApp.Cells[rowIndex, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 5] = "Người lập";
            rowIndex++;
            excelApp.Cells[rowIndex, 5].Font.Bold = true;
            excelApp.Cells[rowIndex, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 5] = "(Ký, ghi rõ họ tên)";
            rowIndex = rowIndex + 2;
            excelApp.Cells[rowIndex, 5].Font.Bold = true;
            excelApp.Cells[rowIndex, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            excelApp.Cells[rowIndex, 5] = frmMain.tendangnhap;
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }

        private void btnDoanhThuNV_Click(object sender, EventArgs e)
        {
            frmDoanhSoNhanVien f = new frmDoanhSoNhanVien();
            f.ShowDialog();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exportExcelFile();
        }

    }
}
