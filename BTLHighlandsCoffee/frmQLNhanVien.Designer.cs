
namespace BTLHighlandsCoffee
{
    partial class frmQLNhanVien
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
            this.txttim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCalam = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconbtnxoa = new FontAwesome.Sharp.IconButton();
            this.iconbtnThem = new FontAwesome.Sharp.IconButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureNV = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnsua = new FontAwesome.Sharp.IconButton();
            this.iconbtnxoatrang = new FontAwesome.Sharp.IconButton();
            this.iconbtntim = new FontAwesome.Sharp.IconButton();
            this.iconbtnhienthi = new FontAwesome.Sharp.IconButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbma = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.ForeColor = System.Drawing.Color.DarkGray;
            this.txttim.Location = new System.Drawing.Point(1252, 146);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(177, 34);
            this.txttim.TabIndex = 24;
            this.txttim.Text = "--Mã nhân viên--";
            this.txttim.Enter += new System.EventHandler(this.txttim_Enter);
            this.txttim.Leave += new System.EventHandler(this.txttim_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.lbma);
            this.groupBox1.Controls.Add(this.cboCalam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.iconbtnxoa);
            this.groupBox1.Controls.Add(this.iconbtnThem);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.cbochucvu);
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 494);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // cboCalam
            // 
            this.cboCalam.FormattingEnabled = true;
            this.cboCalam.Items.AddRange(new object[] {
            "Nhân viên pha chế",
            "Nhân viên thu ngân",
            "Quản lý"});
            this.cboCalam.Location = new System.Drawing.Point(202, 358);
            this.cboCalam.Name = "cboCalam";
            this.cboCalam.Size = new System.Drawing.Size(228, 37);
            this.cboCalam.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ca làm";
            // 
            // iconbtnxoa
            // 
            this.iconbtnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnxoa.FlatAppearance.BorderSize = 0;
            this.iconbtnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnxoa.ForeColor = System.Drawing.Color.White;
            this.iconbtnxoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnxoa.IconColor = System.Drawing.Color.White;
            this.iconbtnxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnxoa.IconSize = 40;
            this.iconbtnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnxoa.Location = new System.Drawing.Point(310, 422);
            this.iconbtnxoa.Name = "iconbtnxoa";
            this.iconbtnxoa.Size = new System.Drawing.Size(120, 44);
            this.iconbtnxoa.TabIndex = 16;
            this.iconbtnxoa.Text = "Xóa";
            this.iconbtnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnxoa.UseVisualStyleBackColor = false;
            this.iconbtnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // iconbtnThem
            // 
            this.iconbtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnThem.FlatAppearance.BorderSize = 0;
            this.iconbtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnThem.ForeColor = System.Drawing.Color.White;
            this.iconbtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnThem.IconColor = System.Drawing.Color.White;
            this.iconbtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnThem.IconSize = 40;
            this.iconbtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnThem.Location = new System.Drawing.Point(103, 422);
            this.iconbtnThem.Name = "iconbtnThem";
            this.iconbtnThem.Size = new System.Drawing.Size(120, 44);
            this.iconbtnThem.TabIndex = 14;
            this.iconbtnThem.Text = "Thêm";
            this.iconbtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnThem.UseVisualStyleBackColor = false;
            this.iconbtnThem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(202, 145);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(85, 33);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(319, 145);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(65, 33);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // cbochucvu
            // 
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Items.AddRange(new object[] {
            "Nhân viên pha chế",
            "Nhân viên thu ngân",
            "Quản lý"});
            this.cbochucvu.Location = new System.Drawing.Point(202, 299);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(228, 37);
            this.cbochucvu.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(202, 250);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(228, 34);
            this.txtdiachi.TabIndex = 12;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(202, 196);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(228, 34);
            this.txtsdt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(202, 86);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(228, 34);
            this.txttennv.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chức vụ";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(202, 33);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(228, 34);
            this.txtmaNV.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại";
            // 
            // pictureNV
            // 
            this.pictureNV.BackColor = System.Drawing.Color.Wheat;
            this.pictureNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.pictureNV.IconColor = System.Drawing.SystemColors.ControlText;
            this.pictureNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureNV.IconSize = 145;
            this.pictureNV.Location = new System.Drawing.Point(242, 99);
            this.pictureNV.Name = "pictureNV";
            this.pictureNV.Size = new System.Drawing.Size(145, 195);
            this.pictureNV.TabIndex = 26;
            this.pictureNV.TabStop = false;
            this.pictureNV.Click += new System.EventHandler(this.pictureNV_Click);
            // 
            // iconbtnsua
            // 
            this.iconbtnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnsua.FlatAppearance.BorderSize = 0;
            this.iconbtnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnsua.ForeColor = System.Drawing.Color.White;
            this.iconbtnsua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnsua.IconColor = System.Drawing.Color.White;
            this.iconbtnsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnsua.IconSize = 40;
            this.iconbtnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnsua.Location = new System.Drawing.Point(181, 772);
            this.iconbtnsua.Name = "iconbtnsua";
            this.iconbtnsua.Size = new System.Drawing.Size(120, 44);
            this.iconbtnsua.TabIndex = 15;
            this.iconbtnsua.Text = "Sửa";
            this.iconbtnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnsua.UseVisualStyleBackColor = false;
            this.iconbtnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // iconbtnxoatrang
            // 
            this.iconbtnxoatrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnxoatrang.FlatAppearance.BorderSize = 0;
            this.iconbtnxoatrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnxoatrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnxoatrang.ForeColor = System.Drawing.Color.White;
            this.iconbtnxoatrang.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconbtnxoatrang.IconColor = System.Drawing.Color.White;
            this.iconbtnxoatrang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnxoatrang.IconSize = 40;
            this.iconbtnxoatrang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnxoatrang.Location = new System.Drawing.Point(388, 772);
            this.iconbtnxoatrang.Name = "iconbtnxoatrang";
            this.iconbtnxoatrang.Size = new System.Drawing.Size(120, 44);
            this.iconbtnxoatrang.TabIndex = 17;
            this.iconbtnxoatrang.Text = "Hủy";
            this.iconbtnxoatrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnxoatrang.UseVisualStyleBackColor = false;
            this.iconbtnxoatrang.Click += new System.EventHandler(this.btnxoatrang_Click);
            // 
            // iconbtntim
            // 
            this.iconbtntim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtntim.FlatAppearance.BorderSize = 0;
            this.iconbtntim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtntim.ForeColor = System.Drawing.Color.White;
            this.iconbtntim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconbtntim.IconColor = System.Drawing.Color.White;
            this.iconbtntim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtntim.IconSize = 40;
            this.iconbtntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtntim.Location = new System.Drawing.Point(1448, 136);
            this.iconbtntim.Name = "iconbtntim";
            this.iconbtntim.Size = new System.Drawing.Size(158, 44);
            this.iconbtntim.TabIndex = 18;
            this.iconbtntim.Text = "Tìm kiếm";
            this.iconbtntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtntim.UseVisualStyleBackColor = false;
            this.iconbtntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // iconbtnhienthi
            // 
            this.iconbtnhienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnhienthi.FlatAppearance.BorderSize = 0;
            this.iconbtnhienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnhienthi.ForeColor = System.Drawing.Color.White;
            this.iconbtnhienthi.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconbtnhienthi.IconColor = System.Drawing.Color.White;
            this.iconbtnhienthi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnhienthi.IconSize = 40;
            this.iconbtnhienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnhienthi.Location = new System.Drawing.Point(1079, 136);
            this.iconbtnhienthi.Name = "iconbtnhienthi";
            this.iconbtnhienthi.Size = new System.Drawing.Size(145, 44);
            this.iconbtnhienthi.TabIndex = 27;
            this.iconbtnhienthi.Text = "Hiển thị";
            this.iconbtnhienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnhienthi.UseVisualStyleBackColor = false;
            this.iconbtnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.ChucVu,
            this.CaLam});
            this.dgvNhanVien.Location = new System.Drawing.Point(580, 204);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 160;
            this.dgvNhanVien.Size = new System.Drawing.Size(1026, 612);
            this.dgvNhanVien.TabIndex = 28;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick_1);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 165;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 178;
            // 
            // CaLam
            // 
            this.CaLam.DataPropertyName = "CaLam";
            this.CaLam.HeaderText = "Ca làm";
            this.CaLam.MinimumWidth = 6;
            this.CaLam.Name = "CaLam";
            this.CaLam.Width = 125;
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(197, 37);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(0, 29);
            this.lbma.TabIndex = 19;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1618, 867);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.iconbtnxoatrang);
            this.Controls.Add(this.iconbtnsua);
            this.Controls.Add(this.iconbtnhienthi);
            this.Controls.Add(this.iconbtntim);
            this.Controls.Add(this.pictureNV);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLNhanVien";
            this.Text = "frmQLNhanVien";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconbtnxoatrang;
        private FontAwesome.Sharp.IconButton iconbtnxoa;
        private FontAwesome.Sharp.IconButton iconbtnsua;
        private FontAwesome.Sharp.IconButton iconbtnThem;
        private FontAwesome.Sharp.IconPictureBox pictureNV;
        private FontAwesome.Sharp.IconButton iconbtntim;
        private FontAwesome.Sharp.IconButton iconbtnhienthi;
        private System.Windows.Forms.ComboBox cboCalam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
        private System.Windows.Forms.Label lbma;
    }
}