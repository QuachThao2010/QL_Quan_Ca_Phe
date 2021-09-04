
namespace BTLHighlandsCoffee
{
    partial class frmQLLuong
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnbangcc = new System.Windows.Forms.GroupBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.LuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbomaca = new System.Windows.Forms.ComboBox();
            this.txttongluong = new System.Windows.Forms.TextBox();
            this.txtmacaa = new System.Windows.Forms.TextBox();
            this.txtngaycong = new System.Windows.Forms.TextBox();
            this.txtluongnam = new System.Windows.Forms.TextBox();
            this.cboLuongthang = new System.Windows.Forms.ComboBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.iconbtninluong = new FontAwesome.Sharp.IconButton();
            this.iconbtnxoa = new FontAwesome.Sharp.IconButton();
            this.iconbtnthem = new FontAwesome.Sharp.IconButton();
            this.iconbtnhienthi = new FontAwesome.Sharp.IconButton();
            this.iconLocCa = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.btnbangcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnbangcc
            // 
            this.btnbangcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbangcc.Controls.Add(this.dgvLuong);
            this.btnbangcc.Controls.Add(this.cbomaca);
            this.btnbangcc.Controls.Add(this.txttongluong);
            this.btnbangcc.Controls.Add(this.txtmacaa);
            this.btnbangcc.Controls.Add(this.txtngaycong);
            this.btnbangcc.Controls.Add(this.txtluongnam);
            this.btnbangcc.Controls.Add(this.cboLuongthang);
            this.btnbangcc.Controls.Add(this.cbomanv);
            this.btnbangcc.Controls.Add(this.iconbtninluong);
            this.btnbangcc.Controls.Add(this.iconbtnxoa);
            this.btnbangcc.Controls.Add(this.iconbtnthem);
            this.btnbangcc.Controls.Add(this.iconbtnhienthi);
            this.btnbangcc.Controls.Add(this.iconLocCa);
            this.btnbangcc.Controls.Add(this.label1);
            this.btnbangcc.Controls.Add(this.label2);
            this.btnbangcc.Controls.Add(this.label3);
            this.btnbangcc.Controls.Add(this.label5);
            this.btnbangcc.Controls.Add(this.label6);
            this.btnbangcc.Controls.Add(this.label8);
            this.btnbangcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbangcc.Location = new System.Drawing.Point(25, 23);
            this.btnbangcc.Name = "btnbangcc";
            this.btnbangcc.Size = new System.Drawing.Size(1320, 695);
            this.btnbangcc.TabIndex = 22;
            this.btnbangcc.TabStop = false;
            this.btnbangcc.Text = "LƯƠNG NHÂN VIÊN";
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LuongThang,
            this.LuongNam,
            this.MaNV,
            this.MaCaa,
            this.NgayCong,
            this.TamUng,
            this.Thuong,
            this.TongLuong});
            this.dgvLuong.Location = new System.Drawing.Point(33, 311);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 40;
            this.dgvLuong.Size = new System.Drawing.Size(1262, 288);
            this.dgvLuong.TabIndex = 45;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick_1);
            // 
            // LuongThang
            // 
            this.LuongThang.DataPropertyName = "LuongThang";
            this.LuongThang.HeaderText = "Tháng";
            this.LuongThang.MinimumWidth = 6;
            this.LuongThang.Name = "LuongThang";
            this.LuongThang.Width = 125;
            // 
            // LuongNam
            // 
            this.LuongNam.DataPropertyName = "LuongNam";
            this.LuongNam.HeaderText = "Năm";
            this.LuongNam.MinimumWidth = 6;
            this.LuongNam.Name = "LuongNam";
            this.LuongNam.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 160;
            // 
            // MaCaa
            // 
            this.MaCaa.DataPropertyName = "MaCa";
            this.MaCaa.HeaderText = "Mã ca";
            this.MaCaa.MinimumWidth = 6;
            this.MaCaa.Name = "MaCaa";
            this.MaCaa.Width = 125;
            // 
            // NgayCong
            // 
            this.NgayCong.DataPropertyName = "NgayCong";
            this.NgayCong.HeaderText = "Tổng giờ làm";
            this.NgayCong.MinimumWidth = 6;
            this.NgayCong.Name = "NgayCong";
            this.NgayCong.Width = 160;
            // 
            // TamUng
            // 
            this.TamUng.DataPropertyName = "TamUng";
            this.TamUng.HeaderText = "Tạm ứng";
            this.TamUng.MinimumWidth = 6;
            this.TamUng.Name = "TamUng";
            this.TamUng.Width = 150;
            // 
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            this.Thuong.HeaderText = "Thưởng";
            this.Thuong.MinimumWidth = 6;
            this.Thuong.Name = "Thuong";
            this.Thuong.Width = 150;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Width = 220;
            // 
            // cbomaca
            // 
            this.cbomaca.FormattingEnabled = true;
            this.cbomaca.Location = new System.Drawing.Point(943, 229);
            this.cbomaca.Name = "cbomaca";
            this.cbomaca.Size = new System.Drawing.Size(200, 30);
            this.cbomaca.TabIndex = 44;
            // 
            // txttongluong
            // 
            this.txttongluong.Location = new System.Drawing.Point(996, 130);
            this.txttongluong.Name = "txttongluong";
            this.txttongluong.ReadOnly = true;
            this.txttongluong.Size = new System.Drawing.Size(197, 28);
            this.txttongluong.TabIndex = 43;
            // 
            // txtmacaa
            // 
            this.txtmacaa.Enabled = false;
            this.txtmacaa.Location = new System.Drawing.Point(584, 131);
            this.txtmacaa.Name = "txtmacaa";
            this.txtmacaa.Size = new System.Drawing.Size(200, 28);
            this.txtmacaa.TabIndex = 42;
            // 
            // txtngaycong
            // 
            this.txtngaycong.Enabled = false;
            this.txtngaycong.Location = new System.Drawing.Point(996, 72);
            this.txtngaycong.Name = "txtngaycong";
            this.txtngaycong.Size = new System.Drawing.Size(197, 28);
            this.txtngaycong.TabIndex = 41;
            // 
            // txtluongnam
            // 
            this.txtluongnam.Location = new System.Drawing.Point(188, 127);
            this.txtluongnam.Name = "txtluongnam";
            this.txtluongnam.Size = new System.Drawing.Size(200, 28);
            this.txtluongnam.TabIndex = 40;
            this.txtluongnam.Validated += new System.EventHandler(this.txtluongnam_Validated_1);
            // 
            // cboLuongthang
            // 
            this.cboLuongthang.FormattingEnabled = true;
            this.cboLuongthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboLuongthang.Location = new System.Drawing.Point(188, 67);
            this.cboLuongthang.Name = "cboLuongthang";
            this.cboLuongthang.Size = new System.Drawing.Size(200, 30);
            this.cboLuongthang.TabIndex = 39;
            this.cboLuongthang.Validated += new System.EventHandler(this.cboLuongthang_Validated_1);
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(590, 70);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(200, 30);
            this.cbomanv.TabIndex = 38;
            this.cbomanv.TextChanged += new System.EventHandler(this.cbomanv_TextChanged);
            this.cbomanv.Validated += new System.EventHandler(this.cbomanv_Validated_1);
            // 
            // iconbtninluong
            // 
            this.iconbtninluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtninluong.FlatAppearance.BorderSize = 0;
            this.iconbtninluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtninluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtninluong.ForeColor = System.Drawing.Color.White;
            this.iconbtninluong.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconbtninluong.IconColor = System.Drawing.Color.White;
            this.iconbtninluong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtninluong.IconSize = 42;
            this.iconbtninluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtninluong.Location = new System.Drawing.Point(970, 621);
            this.iconbtninluong.Name = "iconbtninluong";
            this.iconbtninluong.Size = new System.Drawing.Size(157, 44);
            this.iconbtninluong.TabIndex = 35;
            this.iconbtninluong.Text = "In lương";
            this.iconbtninluong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtninluong.UseVisualStyleBackColor = false;
            this.iconbtninluong.Click += new System.EventHandler(this.iconbtninluong_Click);
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
            this.iconbtnxoa.Location = new System.Drawing.Point(726, 621);
            this.iconbtnxoa.Name = "iconbtnxoa";
            this.iconbtnxoa.Size = new System.Drawing.Size(127, 44);
            this.iconbtnxoa.TabIndex = 31;
            this.iconbtnxoa.Text = "Xóa";
            this.iconbtnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnxoa.UseVisualStyleBackColor = false;
            this.iconbtnxoa.Click += new System.EventHandler(this.iconbtnxoa_Click);
            // 
            // iconbtnthem
            // 
            this.iconbtnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnthem.FlatAppearance.BorderSize = 0;
            this.iconbtnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnthem.ForeColor = System.Drawing.Color.White;
            this.iconbtnthem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnthem.IconColor = System.Drawing.Color.White;
            this.iconbtnthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnthem.IconSize = 40;
            this.iconbtnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnthem.Location = new System.Drawing.Point(477, 621);
            this.iconbtnthem.Name = "iconbtnthem";
            this.iconbtnthem.Size = new System.Drawing.Size(127, 44);
            this.iconbtnthem.TabIndex = 33;
            this.iconbtnthem.Text = "Thêm";
            this.iconbtnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnthem.UseVisualStyleBackColor = false;
            this.iconbtnthem.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconbtnhienthi
            // 
            this.iconbtnhienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnhienthi.FlatAppearance.BorderSize = 0;
            this.iconbtnhienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnhienthi.ForeColor = System.Drawing.Color.White;
            this.iconbtnhienthi.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconbtnhienthi.IconColor = System.Drawing.Color.White;
            this.iconbtnhienthi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnhienthi.IconSize = 40;
            this.iconbtnhienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnhienthi.Location = new System.Drawing.Point(229, 621);
            this.iconbtnhienthi.Name = "iconbtnhienthi";
            this.iconbtnhienthi.Size = new System.Drawing.Size(142, 44);
            this.iconbtnhienthi.TabIndex = 34;
            this.iconbtnhienthi.Text = "Hiển thị";
            this.iconbtnhienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnhienthi.UseVisualStyleBackColor = false;
            this.iconbtnhienthi.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconLocCa
            // 
            this.iconLocCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconLocCa.FlatAppearance.BorderSize = 0;
            this.iconLocCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLocCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLocCa.ForeColor = System.Drawing.Color.White;
            this.iconLocCa.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconLocCa.IconColor = System.Drawing.Color.White;
            this.iconLocCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLocCa.IconSize = 37;
            this.iconLocCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLocCa.Location = new System.Drawing.Point(1168, 219);
            this.iconLocCa.Name = "iconLocCa";
            this.iconLocCa.Size = new System.Drawing.Size(127, 44);
            this.iconLocCa.TabIndex = 30;
            this.iconLocCa.Text = "Lọc ca";
            this.iconLocCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconLocCa.UseVisualStyleBackColor = false;
            this.iconLocCa.Click += new System.EventHandler(this.iconLocCa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tổng lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lương năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lương tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(867, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng giờ làm";
            // 
            // frmQLLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1357, 803);
            this.Controls.Add(this.btnbangcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLLuong";
            this.Text = "frmQLLuong";
            this.Load += new System.EventHandler(this.frmQLLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.btnbangcc.ResumeLayout(false);
            this.btnbangcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox btnbangcc;
        private FontAwesome.Sharp.IconButton iconbtninluong;
        private FontAwesome.Sharp.IconButton iconbtnxoa;
        private FontAwesome.Sharp.IconButton iconbtnthem;
        private FontAwesome.Sharp.IconButton iconbtnhienthi;
        private FontAwesome.Sharp.IconButton iconLocCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.ComboBox cbomaca;
        private System.Windows.Forms.TextBox txttongluong;
        private System.Windows.Forms.TextBox txtmacaa;
        private System.Windows.Forms.TextBox txtngaycong;
        private System.Windows.Forms.TextBox txtluongnam;
        private System.Windows.Forms.ComboBox cboLuongthang;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}