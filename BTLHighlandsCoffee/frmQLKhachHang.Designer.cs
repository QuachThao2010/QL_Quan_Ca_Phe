
namespace BTLHighlandsCoffee
{
    partial class frmQLKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnTim = new FontAwesome.Sharp.IconButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.iconbtnClear = new FontAwesome.Sharp.IconButton();
            this.iconbtnXoa = new FontAwesome.Sharp.IconButton();
            this.iconbtnSua = new FontAwesome.Sharp.IconButton();
            this.iconbtnThem = new FontAwesome.Sharp.IconButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconbtnLayThongTin = new FontAwesome.Sharp.IconButton();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gr1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.iconbtnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Location = new System.Drawing.Point(167, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 111);
            this.panel1.TabIndex = 0;
            // 
            // iconbtnTim
            // 
            this.iconbtnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnTim.FlatAppearance.BorderSize = 0;
            this.iconbtnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnTim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnTim.ForeColor = System.Drawing.Color.White;
            this.iconbtnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconbtnTim.IconColor = System.Drawing.Color.White;
            this.iconbtnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnTim.IconSize = 40;
            this.iconbtnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnTim.Location = new System.Drawing.Point(1312, 51);
            this.iconbtnTim.Name = "iconbtnTim";
            this.iconbtnTim.Size = new System.Drawing.Size(142, 40);
            this.iconbtnTim.TabIndex = 14;
            this.iconbtnTim.Text = "Tìm kiếm";
            this.iconbtnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnTim.UseVisualStyleBackColor = false;
            this.iconbtnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(1034, 59);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(247, 32);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // gr1
            // 
            this.gr1.BackColor = System.Drawing.Color.Wheat;
            this.gr1.Controls.Add(this.iconbtnClear);
            this.gr1.Controls.Add(this.iconbtnXoa);
            this.gr1.Controls.Add(this.iconbtnSua);
            this.gr1.Controls.Add(this.iconbtnThem);
            this.gr1.Controls.Add(this.rdNam);
            this.gr1.Controls.Add(this.rdNu);
            this.gr1.Controls.Add(this.txtDiem);
            this.gr1.Controls.Add(this.txtDiaChi);
            this.gr1.Controls.Add(this.txtDienThoai);
            this.gr1.Controls.Add(this.txtTenKH);
            this.gr1.Controls.Add(this.txtMaKH);
            this.gr1.Controls.Add(this.label6);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Controls.Add(this.label1);
            this.gr1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr1.Location = new System.Drawing.Point(0, 127);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(562, 658);
            this.gr1.TabIndex = 1;
            this.gr1.TabStop = false;
            this.gr1.Text = "Thông tin khách hàng";
            // 
            // iconbtnClear
            // 
            this.iconbtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnClear.FlatAppearance.BorderSize = 0;
            this.iconbtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnClear.ForeColor = System.Drawing.Color.White;
            this.iconbtnClear.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconbtnClear.IconColor = System.Drawing.Color.White;
            this.iconbtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnClear.IconSize = 45;
            this.iconbtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnClear.Location = new System.Drawing.Point(298, 541);
            this.iconbtnClear.Name = "iconbtnClear";
            this.iconbtnClear.Size = new System.Drawing.Size(113, 40);
            this.iconbtnClear.TabIndex = 13;
            this.iconbtnClear.Text = "Clear";
            this.iconbtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnClear.UseVisualStyleBackColor = false;
            this.iconbtnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // iconbtnXoa
            // 
            this.iconbtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnXoa.FlatAppearance.BorderSize = 0;
            this.iconbtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnXoa.ForeColor = System.Drawing.Color.White;
            this.iconbtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnXoa.IconColor = System.Drawing.Color.White;
            this.iconbtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnXoa.IconSize = 40;
            this.iconbtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnXoa.Location = new System.Drawing.Point(125, 541);
            this.iconbtnXoa.Name = "iconbtnXoa";
            this.iconbtnXoa.Size = new System.Drawing.Size(113, 40);
            this.iconbtnXoa.TabIndex = 12;
            this.iconbtnXoa.Text = "Xóa";
            this.iconbtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnXoa.UseVisualStyleBackColor = false;
            this.iconbtnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // iconbtnSua
            // 
            this.iconbtnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnSua.FlatAppearance.BorderSize = 0;
            this.iconbtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSua.ForeColor = System.Drawing.Color.White;
            this.iconbtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnSua.IconColor = System.Drawing.Color.White;
            this.iconbtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSua.IconSize = 45;
            this.iconbtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.Location = new System.Drawing.Point(298, 463);
            this.iconbtnSua.Name = "iconbtnSua";
            this.iconbtnSua.Size = new System.Drawing.Size(113, 40);
            this.iconbtnSua.TabIndex = 11;
            this.iconbtnSua.Text = "Sửa";
            this.iconbtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnSua.UseVisualStyleBackColor = false;
            this.iconbtnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // iconbtnThem
            // 
            this.iconbtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnThem.FlatAppearance.BorderSize = 0;
            this.iconbtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnThem.ForeColor = System.Drawing.Color.White;
            this.iconbtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnThem.IconColor = System.Drawing.Color.White;
            this.iconbtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnThem.IconSize = 40;
            this.iconbtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnThem.Location = new System.Drawing.Point(125, 463);
            this.iconbtnThem.Name = "iconbtnThem";
            this.iconbtnThem.Size = new System.Drawing.Size(113, 40);
            this.iconbtnThem.TabIndex = 10;
            this.iconbtnThem.Text = "Thêm";
            this.iconbtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnThem.UseVisualStyleBackColor = false;
            this.iconbtnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(337, 191);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(71, 27);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(252, 193);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(57, 27);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(252, 378);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.ReadOnly = true;
            this.txtDiem.Size = new System.Drawing.Size(231, 32);
            this.txtDiem.TabIndex = 8;
            this.txtDiem.Text = "0";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(252, 315);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 32);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(252, 258);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(231, 32);
            this.txtDienThoai.TabIndex = 6;
            this.txtDienThoai.Validated += new System.EventHandler(this.txtDienThoai_Validated);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(252, 135);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(231, 32);
            this.txtTenKH.TabIndex = 3;
            this.txtTenKH.Validated += new System.EventHandler(this.txtTenKH_Validated);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(252, 80);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(231, 32);
            this.txtMaKH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm tích lũy: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điện thoại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.iconbtnLayThongTin);
            this.groupBox2.Controls.Add(this.dgvKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(568, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 696);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // iconbtnLayThongTin
            // 
            this.iconbtnLayThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnLayThongTin.FlatAppearance.BorderSize = 0;
            this.iconbtnLayThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnLayThongTin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnLayThongTin.ForeColor = System.Drawing.Color.White;
            this.iconbtnLayThongTin.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconbtnLayThongTin.IconColor = System.Drawing.Color.White;
            this.iconbtnLayThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnLayThongTin.IconSize = 40;
            this.iconbtnLayThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnLayThongTin.Location = new System.Drawing.Point(409, 632);
            this.iconbtnLayThongTin.Name = "iconbtnLayThongTin";
            this.iconbtnLayThongTin.Size = new System.Drawing.Size(311, 40);
            this.iconbtnLayThongTin.TabIndex = 14;
            this.iconbtnLayThongTin.Text = "Lấy thông tin khách hàng";
            this.iconbtnLayThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnLayThongTin.UseVisualStyleBackColor = false;
            this.iconbtnLayThongTin.Click += new System.EventHandler(this.btnLayThongTIn_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 47);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1065, 541);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1659, 950);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLKhachHang";
            this.Text = "frmQLKhachHang";
            this.Deactivate += new System.EventHandler(this.frmQLKhachHang_Deactivate);
            this.Load += new System.EventHandler(this.frmQLKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private FontAwesome.Sharp.IconButton iconbtnClear;
        private FontAwesome.Sharp.IconButton iconbtnXoa;
        private FontAwesome.Sharp.IconButton iconbtnSua;
        private FontAwesome.Sharp.IconButton iconbtnThem;
        private FontAwesome.Sharp.IconButton iconbtnLayThongTin;
        private FontAwesome.Sharp.IconButton iconbtnTim;
    }
}