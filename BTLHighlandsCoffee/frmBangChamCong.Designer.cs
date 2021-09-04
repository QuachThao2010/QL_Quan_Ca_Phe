
namespace BTLHighlandsCoffee
{
    partial class frmBangChamCong
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconbtnincong = new FontAwesome.Sharp.IconButton();
            this.iconbtnchamcong = new FontAwesome.Sharp.IconButton();
            this.txtgioRa = new System.Windows.Forms.TextBox();
            this.txtgiovao = new System.Windows.Forms.TextBox();
            this.datengayLam = new System.Windows.Forms.DateTimePicker();
            this.txtmaca = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBangChamCong = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.ChucVu,
            this.CaLam});
            this.dgvNhanVien.Location = new System.Drawing.Point(501, 38);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 50;
            this.dgvNhanVien.Size = new System.Drawing.Size(1134, 393);
            this.dgvNhanVien.TabIndex = 27;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconbtnincong);
            this.groupBox1.Controls.Add(this.iconbtnchamcong);
            this.groupBox1.Controls.Add(this.txtgioRa);
            this.groupBox1.Controls.Add(this.txtgiovao);
            this.groupBox1.Controls.Add(this.datengayLam);
            this.groupBox1.Controls.Add(this.txtmaca);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 405);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // iconbtnincong
            // 
            this.iconbtnincong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnincong.FlatAppearance.BorderSize = 0;
            this.iconbtnincong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnincong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnincong.ForeColor = System.Drawing.Color.White;
            this.iconbtnincong.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconbtnincong.IconColor = System.Drawing.Color.White;
            this.iconbtnincong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnincong.IconSize = 42;
            this.iconbtnincong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnincong.Location = new System.Drawing.Point(215, 331);
            this.iconbtnincong.Name = "iconbtnincong";
            this.iconbtnincong.Size = new System.Drawing.Size(221, 56);
            this.iconbtnincong.TabIndex = 34;
            this.iconbtnincong.Text = "In bảng công";
            this.iconbtnincong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnincong.UseVisualStyleBackColor = false;
            this.iconbtnincong.Click += new System.EventHandler(this.iconbtnincong_Click);
            // 
            // iconbtnchamcong
            // 
            this.iconbtnchamcong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnchamcong.FlatAppearance.BorderSize = 0;
            this.iconbtnchamcong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnchamcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnchamcong.ForeColor = System.Drawing.Color.White;
            this.iconbtnchamcong.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnchamcong.IconColor = System.Drawing.Color.White;
            this.iconbtnchamcong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnchamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnchamcong.Location = new System.Drawing.Point(6, 333);
            this.iconbtnchamcong.Name = "iconbtnchamcong";
            this.iconbtnchamcong.Size = new System.Drawing.Size(193, 54);
            this.iconbtnchamcong.TabIndex = 33;
            this.iconbtnchamcong.Text = "Chấm công";
            this.iconbtnchamcong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnchamcong.UseVisualStyleBackColor = false;
            this.iconbtnchamcong.Click += new System.EventHandler(this.iconbtnsuaca_Click);
            // 
            // txtgioRa
            // 
            this.txtgioRa.Location = new System.Drawing.Point(183, 265);
            this.txtgioRa.Name = "txtgioRa";
            this.txtgioRa.Size = new System.Drawing.Size(253, 30);
            this.txtgioRa.TabIndex = 31;
            this.txtgioRa.Validated += new System.EventHandler(this.txtgioRa_Validated);
            // 
            // txtgiovao
            // 
            this.txtgiovao.Location = new System.Drawing.Point(183, 218);
            this.txtgiovao.Name = "txtgiovao";
            this.txtgiovao.Size = new System.Drawing.Size(253, 30);
            this.txtgiovao.TabIndex = 30;
            this.txtgiovao.Validated += new System.EventHandler(this.txtgiovao_Validated);
            // 
            // datengayLam
            // 
            this.datengayLam.CustomFormat = "dd/MM/yyyy";
            this.datengayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengayLam.Location = new System.Drawing.Point(183, 171);
            this.datengayLam.Name = "datengayLam";
            this.datengayLam.Size = new System.Drawing.Size(253, 30);
            this.datengayLam.TabIndex = 28;
            this.datengayLam.Value = new System.DateTime(2021, 8, 25, 0, 0, 0, 0);
            this.datengayLam.Validated += new System.EventHandler(this.datengayLam_Validated);
            // 
            // txtmaca
            // 
            this.txtmaca.Enabled = false;
            this.txtmaca.Location = new System.Drawing.Point(183, 124);
            this.txtmaca.Name = "txtmaca";
            this.txtmaca.Size = new System.Drawing.Size(253, 30);
            this.txtmaca.TabIndex = 27;
            // 
            // txttennv
            // 
            this.txttennv.Enabled = false;
            this.txttennv.Location = new System.Drawing.Point(183, 77);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(253, 30);
            this.txttennv.TabIndex = 26;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(183, 30);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(253, 30);
            this.txtmanv.TabIndex = 25;
            this.txtmanv.Validated += new System.EventHandler(this.txtmanv_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giờ ra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giờ vào";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày làm";
            // 
            // dgvBangChamCong
            // 
            this.dgvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaCa,
            this.NgayLam,
            this.GioVao,
            this.GioRa,
            this.Cong});
            this.dgvBangChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangChamCong.Location = new System.Drawing.Point(3, 26);
            this.dgvBangChamCong.Name = "dgvBangChamCong";
            this.dgvBangChamCong.RowHeadersWidth = 51;
            this.dgvBangChamCong.RowTemplate.Height = 50;
            this.dgvBangChamCong.Size = new System.Drawing.Size(1607, 324);
            this.dgvBangChamCong.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBangChamCong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1613, 353);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 250;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 350;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.Width = 160;
            // 
            // NgayLam
            // 
            this.NgayLam.DataPropertyName = "NgayLam";
            this.NgayLam.HeaderText = "Ngày làm";
            this.NgayLam.MinimumWidth = 6;
            this.NgayLam.Name = "NgayLam";
            this.NgayLam.Width = 250;
            // 
            // GioVao
            // 
            this.GioVao.DataPropertyName = "GioVao";
            this.GioVao.HeaderText = "Giờ vào";
            this.GioVao.MinimumWidth = 6;
            this.GioVao.Name = "GioVao";
            this.GioVao.Width = 150;
            // 
            // GioRa
            // 
            this.GioRa.DataPropertyName = "GioRa";
            this.GioRa.HeaderText = "Giờ ra";
            this.GioRa.MinimumWidth = 6;
            this.GioRa.Name = "GioRa";
            this.GioRa.Width = 150;
            // 
            // Cong
            // 
            this.Cong.DataPropertyName = "Cong";
            this.Cong.HeaderText = "Số giờ làm";
            this.Cong.MinimumWidth = 6;
            this.Cong.Name = "Cong";
            this.Cong.Width = 245;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 80;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 130;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 150;
            // 
            // CaLam
            // 
            this.CaLam.DataPropertyName = "CaLam";
            this.CaLam.HeaderText = "Ca làm";
            this.CaLam.MinimumWidth = 6;
            this.CaLam.Name = "CaLam";
            this.CaLam.Width = 93;
            // 
            // frmBangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1636, 810);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBangChamCong";
            this.Text = "frmBangChamCong";
            this.Load += new System.EventHandler(this.frmBangChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgioRa;
        private System.Windows.Forms.TextBox txtgiovao;
        private System.Windows.Forms.DateTimePicker datengayLam;
        private System.Windows.Forms.TextBox txtmaca;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBangChamCong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton iconbtnchamcong;
        private FontAwesome.Sharp.IconButton iconbtnincong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cong;
    }
}