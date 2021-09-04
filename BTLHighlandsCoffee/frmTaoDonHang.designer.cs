
namespace BTLHighlandsCoffee
{
    partial class frmTaoDonHang
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
            this.components = new System.ComponentModel.Container();
            this.gbChiTietDon = new System.Windows.Forms.GroupBox();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemDon = new System.Windows.Forms.Button();
            this.btnInDon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvChiTietLuuTam = new System.Windows.Forms.DataGridView();
            this.maNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbDonGiaNhap = new System.Windows.Forms.Label();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.btnThemHang = new FontAwesome.Sharp.IconButton();
            this.btnXoaHang = new FontAwesome.Sharp.IconButton();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnSuaHang = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbMaDonDat = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbChiTietDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuuTam)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChiTietDon
            // 
            this.gbChiTietDon.BackColor = System.Drawing.Color.Wheat;
            this.gbChiTietDon.Controls.Add(this.dgvNguyenLieu);
            this.gbChiTietDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChiTietDon.Location = new System.Drawing.Point(850, 186);
            this.gbChiTietDon.Margin = new System.Windows.Forms.Padding(4);
            this.gbChiTietDon.Name = "gbChiTietDon";
            this.gbChiTietDon.Padding = new System.Windows.Forms.Padding(4);
            this.gbChiTietDon.Size = new System.Drawing.Size(795, 638);
            this.gbChiTietDon.TabIndex = 2;
            this.gbChiTietDon.TabStop = false;
            this.gbChiTietDon.Text = "Danh sách hàng";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(4, 27);
            this.dgvNguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(787, 607);
            this.dgvNguyenLieu.TabIndex = 0;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(164, 200);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(234, 30);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.Validated += new System.EventHandler(this.txtSoLuong_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đơn vị tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 299);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đơn giá:";
            // 
            // btnThemDon
            // 
            this.btnThemDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemDon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDon.ForeColor = System.Drawing.Color.White;
            this.btnThemDon.Location = new System.Drawing.Point(79, 669);
            this.btnThemDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDon.Name = "btnThemDon";
            this.btnThemDon.Size = new System.Drawing.Size(142, 51);
            this.btnThemDon.TabIndex = 3;
            this.btnThemDon.Text = "Thêm đơn";
            this.btnThemDon.UseVisualStyleBackColor = false;
            this.btnThemDon.Click += new System.EventHandler(this.btnThemDon_Click);
            // 
            // btnInDon
            // 
            this.btnInDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInDon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDon.ForeColor = System.Drawing.Color.White;
            this.btnInDon.Location = new System.Drawing.Point(287, 669);
            this.btnInDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInDon.Name = "btnInDon";
            this.btnInDon.Size = new System.Drawing.Size(244, 51);
            this.btnInDon.TabIndex = 3;
            this.btnInDon.Text = "Xem chi tiết đơn";
            this.btnInDon.UseVisualStyleBackColor = false;
            this.btnInDon.Click += new System.EventHandler(this.btnInDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.dgvChiTietLuuTam);
            this.groupBox2.Controls.Add(this.lbMaHang);
            this.groupBox2.Controls.Add(this.lbTenHang);
            this.groupBox2.Controls.Add(this.lbDonGiaNhap);
            this.groupBox2.Controls.Add(this.lbDonViTinh);
            this.groupBox2.Controls.Add(this.btnThemHang);
            this.groupBox2.Controls.Add(this.btnXoaHang);
            this.groupBox2.Controls.Add(this.btnHoanTat);
            this.groupBox2.Controls.Add(this.btnInDon);
            this.groupBox2.Controls.Add(this.btnThemDon);
            this.groupBox2.Controls.Add(this.btnSuaHang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(850, 761);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng đặt";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(328, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 41);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvChiTietLuuTam
            // 
            this.dgvChiTietLuuTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietLuuTam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNL,
            this.tenNL,
            this.donVi,
            this.soLuong,
            this.donGia,
            this.TT});
            this.dgvChiTietLuuTam.Location = new System.Drawing.Point(8, 397);
            this.dgvChiTietLuuTam.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietLuuTam.Name = "dgvChiTietLuuTam";
            this.dgvChiTietLuuTam.RowHeadersWidth = 51;
            this.dgvChiTietLuuTam.RowTemplate.Height = 24;
            this.dgvChiTietLuuTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietLuuTam.Size = new System.Drawing.Size(838, 241);
            this.dgvChiTietLuuTam.TabIndex = 2;
            this.dgvChiTietLuuTam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDatHang_CellClick);
            this.dgvChiTietLuuTam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietLuuTam_CellContentClick);
            // 
            // maNL
            // 
            this.maNL.HeaderText = "Mã hàng";
            this.maNL.MinimumWidth = 6;
            this.maNL.Name = "maNL";
            this.maNL.Width = 105;
            // 
            // tenNL
            // 
            this.tenNL.HeaderText = "Tên hàng";
            this.tenNL.MinimumWidth = 6;
            this.tenNL.Name = "tenNL";
            this.tenNL.Width = 200;
            // 
            // donVi
            // 
            this.donVi.HeaderText = "Đơn vị tính";
            this.donVi.MinimumWidth = 6;
            this.donVi.Name = "donVi";
            this.donVi.Width = 120;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 110;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá ";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.Width = 120;
            // 
            // TT
            // 
            this.TT.HeaderText = "Thành tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.Width = 125;
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Location = new System.Drawing.Point(159, 109);
            this.lbMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(0, 23);
            this.lbMaHang.TabIndex = 13;
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(159, 153);
            this.lbTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(0, 23);
            this.lbTenHang.TabIndex = 13;
            // 
            // lbDonGiaNhap
            // 
            this.lbDonGiaNhap.AutoSize = true;
            this.lbDonGiaNhap.Location = new System.Drawing.Point(159, 299);
            this.lbDonGiaNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonGiaNhap.Name = "lbDonGiaNhap";
            this.lbDonGiaNhap.Size = new System.Drawing.Size(0, 23);
            this.lbDonGiaNhap.TabIndex = 13;
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Location = new System.Drawing.Point(159, 249);
            this.lbDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(0, 23);
            this.lbDonViTinh.TabIndex = 13;
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.Color.Transparent;
            this.btnThemHang.FlatAppearance.BorderSize = 0;
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThemHang.IconColor = System.Drawing.Color.Black;
            this.btnThemHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHang.IconSize = 60;
            this.btnThemHang.Location = new System.Drawing.Point(47, 338);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(66, 63);
            this.btnThemHang.TabIndex = 11;
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaHang.FlatAppearance.BorderSize = 0;
            this.btnXoaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHang.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaHang.IconColor = System.Drawing.Color.Black;
            this.btnXoaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaHang.IconSize = 60;
            this.btnXoaHang.Location = new System.Drawing.Point(227, 324);
            this.btnXoaHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(66, 91);
            this.btnXoaHang.TabIndex = 3;
            this.btnXoaHang.UseVisualStyleBackColor = false;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(594, 669);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(183, 51);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnSuaHang
            // 
            this.btnSuaHang.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaHang.FlatAppearance.BorderSize = 0;
            this.btnSuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHang.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSuaHang.IconColor = System.Drawing.Color.Black;
            this.btnSuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaHang.IconSize = 65;
            this.btnSuaHang.Location = new System.Drawing.Point(132, 331);
            this.btnSuaHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaHang.Name = "btnSuaHang";
            this.btnSuaHang.Size = new System.Drawing.Size(66, 76);
            this.btnSuaHang.TabIndex = 3;
            this.btnSuaHang.UseVisualStyleBackColor = false;
            this.btnSuaHang.Click += new System.EventHandler(this.btnSuaHang_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tìm kiếm hàng nhập:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mã hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(239, 57);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(234, 30);
            this.txtTenHang.TabIndex = 8;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            this.txtTenHang.Validated += new System.EventHandler(this.txtTenHang_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đơn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(974, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(974, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.cbNhaCC);
            this.groupBox1.Controls.Add(this.lbDienThoai);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbNhanVien);
            this.groupBox1.Controls.Add(this.lbMaDonDat);
            this.groupBox1.Controls.Add(this.lbNgayLap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1641, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt";
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(227, 83);
            this.cbNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(225, 31);
            this.cbNhaCC.TabIndex = 8;
            this.cbNhaCC.TextChanged += new System.EventHandler(this.cbNhaCC_TextChanged);
            this.cbNhaCC.Validated += new System.EventHandler(this.cbNhaCC_Validated);
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(746, 94);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(0, 23);
            this.lbDienThoai.TabIndex = 7;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(1092, 91);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 23);
            this.lbDiaChi.TabIndex = 7;
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Location = new System.Drawing.Point(751, 44);
            this.lbNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(0, 23);
            this.lbNhanVien.TabIndex = 7;
            // 
            // lbMaDonDat
            // 
            this.lbMaDonDat.AutoSize = true;
            this.lbMaDonDat.Location = new System.Drawing.Point(160, 44);
            this.lbMaDonDat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaDonDat.Name = "lbMaDonDat";
            this.lbMaDonDat.Size = new System.Drawing.Size(0, 23);
            this.lbMaDonDat.TabIndex = 7;
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Location = new System.Drawing.Point(1090, 44);
            this.lbNgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(0, 23);
            this.lbNgayLap.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTrangThai);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(850, 832);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 74);
            this.panel1.TabIndex = 3;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(226, 47);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(101, 23);
            this.lbTrangThai.TabIndex = 3;
            this.lbTrangThai.Text = "Chưa giao";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(466, 47);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(21, 23);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tổng tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng thái đơn hàng:";
            // 
            // frmTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1658, 983);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbChiTietDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoDonHang";
            this.Text = "frmQLHangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLHangNhap_Load);
            this.gbChiTietDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuuTam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbChiTietDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnXoaHang;
        private System.Windows.Forms.Button btnInDon;
        private System.Windows.Forms.Button btnThemDon;
        private FontAwesome.Sharp.IconButton btnSuaHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnThemHang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Label lbDonGiaNhap;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbMaDonDat;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvChiTietLuuTam;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn donVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.Button btnHoanTat;
    }
}