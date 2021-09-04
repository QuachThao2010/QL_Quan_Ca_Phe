
namespace BTLHighlandsCoffee
{
    partial class frmThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhoang = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnThangNay = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.timeKT = new System.Windows.Forms.DateTimePicker();
            this.timeBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSoLuongBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSLMax = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblBanChay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rad7ngay = new System.Windows.Forms.RadioButton();
            this.rad3thang = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radCot = new System.Windows.Forms.RadioButton();
            this.radDuong = new System.Windows.Forms.RadioButton();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDoanhThuNV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnKhoang);
            this.panel1.Controls.Add(this.btnThang);
            this.panel1.Controls.Add(this.btnThangNay);
            this.panel1.Controls.Add(this.btnHomNay);
            this.panel1.Controls.Add(this.timeKT);
            this.panel1.Controls.Add(this.timeBD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 108);
            this.panel1.TabIndex = 0;
            // 
            // btnKhoang
            // 
            this.btnKhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKhoang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoang.ForeColor = System.Drawing.Color.White;
            this.btnKhoang.Location = new System.Drawing.Point(588, 62);
            this.btnKhoang.Name = "btnKhoang";
            this.btnKhoang.Size = new System.Drawing.Size(186, 40);
            this.btnKhoang.TabIndex = 7;
            this.btnKhoang.Text = "Trong khoảng";
            this.btnKhoang.UseVisualStyleBackColor = false;
            this.btnKhoang.Click += new System.EventHandler(this.btnKhoang_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThang.FlatAppearance.BorderSize = 0;
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.ForeColor = System.Drawing.Color.White;
            this.btnThang.Location = new System.Drawing.Point(396, 65);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(166, 37);
            this.btnThang.TabIndex = 6;
            this.btnThang.Text = "Tháng trước";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThangTruoc_Click);
            // 
            // btnThangNay
            // 
            this.btnThangNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThangNay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThangNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThangNay.ForeColor = System.Drawing.Color.White;
            this.btnThangNay.Location = new System.Drawing.Point(188, 62);
            this.btnThangNay.Name = "btnThangNay";
            this.btnThangNay.Size = new System.Drawing.Size(173, 40);
            this.btnThangNay.TabIndex = 5;
            this.btnThangNay.Text = "Tháng này";
            this.btnThangNay.UseVisualStyleBackColor = false;
            this.btnThangNay.Click += new System.EventHandler(this.btnThangNay_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHomNay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(-5, 62);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(164, 40);
            this.btnHomNay.TabIndex = 4;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = false;
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // timeKT
            // 
            this.timeKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeKT.CustomFormat = "dd/MM/yyyy";
            this.timeKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeKT.Location = new System.Drawing.Point(494, 2);
            this.timeKT.Name = "timeKT";
            this.timeKT.Size = new System.Drawing.Size(226, 30);
            this.timeKT.TabIndex = 3;
            // 
            // timeBD
            // 
            this.timeBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBD.CustomFormat = "dd/MM/yyyy";
            this.timeBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBD.Location = new System.Drawing.Point(116, 2);
            this.timeBD.Name = "timeBD";
            this.timeBD.Size = new System.Drawing.Size(226, 30);
            this.timeBD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvSoLuongBan);
            this.panel2.Location = new System.Drawing.Point(60, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 309);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(774, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "THỐNG KÊ HÀNG BÁN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSoLuongBan
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoLuongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoLuongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLuongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSoLuongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSoLuongBan.Location = new System.Drawing.Point(0, 46);
            this.dgvSoLuongBan.Name = "dgvSoLuongBan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoLuongBan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoLuongBan.RowHeadersWidth = 51;
            this.dgvSoLuongBan.RowTemplate.Height = 24;
            this.dgvSoLuongBan.Size = new System.Drawing.Size(774, 263);
            this.dgvSoLuongBan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahang";
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenhang";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluongban";
            this.Column3.HeaderText = "Tổng số lượng bán";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnDoanhThuNV);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblSLMax);
            this.panel3.Controls.Add(this.btnExportExcel);
            this.panel3.Controls.Add(this.lblDoanhThu);
            this.panel3.Controls.Add(this.lblBanChay);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(55, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 294);
            this.panel3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số lượng bán:";
            // 
            // lblSLMax
            // 
            this.lblSLMax.AutoSize = true;
            this.lblSLMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLMax.ForeColor = System.Drawing.Color.Black;
            this.lblSLMax.Location = new System.Drawing.Point(288, 106);
            this.lblSLMax.Name = "lblSLMax";
            this.lblSLMax.Size = new System.Drawing.Size(84, 25);
            this.lblSLMax.TabIndex = 14;
            this.lblSLMax.Text = "______";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(569, 212);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(187, 57);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "Xuất File Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lblDoanhThu.Location = new System.Drawing.Point(149, 15);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(84, 25);
            this.lblDoanhThu.TabIndex = 13;
            this.lblDoanhThu.Text = "______";
            // 
            // lblBanChay
            // 
            this.lblBanChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanChay.ForeColor = System.Drawing.Color.Black;
            this.lblBanChay.Location = new System.Drawing.Point(297, 59);
            this.lblBanChay.Name = "lblBanChay";
            this.lblBanChay.Size = new System.Drawing.Size(459, 25);
            this.lblBanChay.TabIndex = 11;
            this.lblBanChay.Text = "______";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mặt hàng bán chạy nhất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Doanh thu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(695, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnBieuDo);
            this.panel4.Controls.Add(this.chartDoanhThu);
            this.panel4.Location = new System.Drawing.Point(878, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 776);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.rad7ngay);
            this.panel6.Controls.Add(this.rad3thang);
            this.panel6.Location = new System.Drawing.Point(27, 482);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 147);
            this.panel6.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kiểu thống kê";
            // 
            // rad7ngay
            // 
            this.rad7ngay.AutoSize = true;
            this.rad7ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad7ngay.Location = new System.Drawing.Point(42, 58);
            this.rad7ngay.Name = "rad7ngay";
            this.rad7ngay.Size = new System.Drawing.Size(181, 29);
            this.rad7ngay.TabIndex = 9;
            this.rad7ngay.TabStop = true;
            this.rad7ngay.Text = "7 ngày gần đây";
            this.rad7ngay.UseVisualStyleBackColor = true;
            // 
            // rad3thang
            // 
            this.rad3thang.AutoSize = true;
            this.rad3thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3thang.Location = new System.Drawing.Point(42, 103);
            this.rad3thang.Name = "rad3thang";
            this.rad3thang.Size = new System.Drawing.Size(188, 29);
            this.rad3thang.TabIndex = 10;
            this.rad3thang.TabStop = true;
            this.rad3thang.Text = "3 tháng gần đây";
            this.rad3thang.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.radCot);
            this.panel5.Controls.Add(this.radDuong);
            this.panel5.Location = new System.Drawing.Point(348, 482);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 147);
            this.panel5.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dạng biểu đồ";
            // 
            // radCot
            // 
            this.radCot.AutoSize = true;
            this.radCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCot.Location = new System.Drawing.Point(77, 58);
            this.radCot.Name = "radCot";
            this.radCot.Size = new System.Drawing.Size(67, 29);
            this.radCot.TabIndex = 12;
            this.radCot.TabStop = true;
            this.radCot.Text = "Cột";
            this.radCot.UseVisualStyleBackColor = true;
            // 
            // radDuong
            // 
            this.radDuong.AutoSize = true;
            this.radDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDuong.Location = new System.Drawing.Point(77, 106);
            this.radDuong.Name = "radDuong";
            this.radDuong.Size = new System.Drawing.Size(96, 29);
            this.radDuong.TabIndex = 11;
            this.radDuong.TabStop = true;
            this.radDuong.Text = "Đường";
            this.radDuong.UseVisualStyleBackColor = true;
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieuDo.ForeColor = System.Drawing.Color.White;
            this.btnBieuDo.Location = new System.Drawing.Point(588, 693);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(180, 58);
            this.btnBieuDo.TabIndex = 8;
            this.btnBieuDo.Text = "Xem Biểu Đồ";
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(17, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(751, 460);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Green;
            title1.Name = "BIỂU ĐỒ THỐNG KÊ DOANH THU";
            this.chartDoanhThu.Titles.Add(title1);
            // 
            // btnDoanhThuNV
            // 
            this.btnDoanhThuNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoanhThuNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoanhThuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuNV.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThuNV.Location = new System.Drawing.Point(22, 212);
            this.btnDoanhThuNV.Name = "btnDoanhThuNV";
            this.btnDoanhThuNV.Size = new System.Drawing.Size(256, 57);
            this.btnDoanhThuNV.TabIndex = 18;
            this.btnDoanhThuNV.Text = "Doanh thu nhân viên";
            this.btnDoanhThuNV.UseVisualStyleBackColor = false;
            this.btnDoanhThuNV.Click += new System.EventHandler(this.btnDoanhThuNV_Click);
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1704, 797);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKhoang;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnThangNay;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.DateTimePicker timeKT;
        private System.Windows.Forms.DateTimePicker timeBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSoLuongBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblBanChay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Button btnBieuDo;
        private System.Windows.Forms.RadioButton rad3thang;
        private System.Windows.Forms.RadioButton rad7ngay;
        private System.Windows.Forms.RadioButton radCot;
        private System.Windows.Forms.RadioButton radDuong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label lblSLMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnDoanhThuNV;
    }
}