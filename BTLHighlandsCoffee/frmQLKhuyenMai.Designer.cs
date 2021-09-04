
namespace BTLHighlandsCoffee
{
    partial class frmQLKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBatDau = new System.Windows.Forms.DateTimePicker();
            this.timeKT = new System.Windows.Forms.DateTimePicker();
            this.timeBD = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconbtnSua = new FontAwesome.Sharp.IconButton();
            this.iconbtnHuy = new FontAwesome.Sharp.IconButton();
            this.iconbtnThem = new FontAwesome.Sharp.IconButton();
            this.iconbtnXoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            this.dgvKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvKhuyenMai.AllowUserToOrderColumns = true;
            this.dgvKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvKhuyenMai.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhuyenMai.ColumnHeadersHeight = 50;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvKhuyenMai.Location = new System.Drawing.Point(22, 99);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhuyenMai.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhuyenMai.RowTemplate.Height = 50;
            this.dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(1104, 220);
            this.dgvKhuyenMai.TabIndex = 0;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKM";
            this.Column1.HeaderText = "Mã khuyến mãi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PhanTramKM";
            this.Column2.HeaderText = "Phần trăm khuyến mãi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBatDau";
            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 320;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayKetThuc";
            this.Column4.HeaderText = "Ngày kết thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 320;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTram.Location = new System.Drawing.Point(272, 54);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(106, 34);
            this.txtPhanTram.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thời gian bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời gian kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phần trăm khuyến mãi:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dateTimeKetThuc);
            this.panel1.Controls.Add(this.dateTimeBatDau);
            this.panel1.Controls.Add(this.timeKT);
            this.panel1.Controls.Add(this.timeBD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPhanTram);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(39, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 153);
            this.panel1.TabIndex = 17;
            // 
            // dateTimeKetThuc
            // 
            this.dateTimeKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateTimeKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeKetThuc.Location = new System.Drawing.Point(695, 106);
            this.dateTimeKetThuc.Name = "dateTimeKetThuc";
            this.dateTimeKetThuc.Size = new System.Drawing.Size(192, 34);
            this.dateTimeKetThuc.TabIndex = 20;
            this.dateTimeKetThuc.ValueChanged += new System.EventHandler(this.dateTimeKetThuc_ValueChanged);
            // 
            // dateTimeBatDau
            // 
            this.dateTimeBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimeBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBatDau.Location = new System.Drawing.Point(695, 49);
            this.dateTimeBatDau.Name = "dateTimeBatDau";
            this.dateTimeBatDau.Size = new System.Drawing.Size(192, 34);
            this.dateTimeBatDau.TabIndex = 19;
            this.dateTimeBatDau.ValueChanged += new System.EventHandler(this.dateTimeBatDau_ValueChanged);
            // 
            // timeKT
            // 
            this.timeKT.CustomFormat = "HH:mm:ss";
            this.timeKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeKT.Location = new System.Drawing.Point(918, 106);
            this.timeKT.Name = "timeKT";
            this.timeKT.Size = new System.Drawing.Size(159, 34);
            this.timeKT.TabIndex = 18;
            this.timeKT.Value = new System.DateTime(2021, 8, 20, 8, 1, 34, 0);
            // 
            // timeBD
            // 
            this.timeBD.CustomFormat = "HH:mm:ss";
            this.timeBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBD.Location = new System.Drawing.Point(918, 49);
            this.timeBD.Name = "timeBD";
            this.timeBD.Size = new System.Drawing.Size(159, 34);
            this.timeBD.TabIndex = 17;
            this.timeBD.Value = new System.DateTime(2021, 8, 20, 14, 38, 48, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.iconbtnXoa);
            this.panel2.Controls.Add(this.iconbtnThem);
            this.panel2.Controls.Add(this.iconbtnSua);
            this.panel2.Controls.Add(this.iconbtnHuy);
            this.panel2.Location = new System.Drawing.Point(66, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 100);
            this.panel2.TabIndex = 18;
            // 
            // iconbtnSua
            // 
            this.iconbtnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnSua.FlatAppearance.BorderSize = 0;
            this.iconbtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSua.ForeColor = System.Drawing.Color.White;
            this.iconbtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnSua.IconColor = System.Drawing.Color.White;
            this.iconbtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.Location = new System.Drawing.Point(331, 21);
            this.iconbtnSua.Name = "iconbtnSua";
            this.iconbtnSua.Size = new System.Drawing.Size(140, 53);
            this.iconbtnSua.TabIndex = 10;
            this.iconbtnSua.Text = "Sửa";
            this.iconbtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnSua.UseVisualStyleBackColor = false;
            this.iconbtnSua.Click += new System.EventHandler(this.iconbtnSua_Click);
            // 
            // iconbtnHuy
            // 
            this.iconbtnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnHuy.FlatAppearance.BorderSize = 0;
            this.iconbtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnHuy.ForeColor = System.Drawing.Color.White;
            this.iconbtnHuy.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconbtnHuy.IconColor = System.Drawing.Color.White;
            this.iconbtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnHuy.IconSize = 43;
            this.iconbtnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnHuy.Location = new System.Drawing.Point(781, 21);
            this.iconbtnHuy.Name = "iconbtnHuy";
            this.iconbtnHuy.Size = new System.Drawing.Size(140, 53);
            this.iconbtnHuy.TabIndex = 12;
            this.iconbtnHuy.Text = "Hủy";
            this.iconbtnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnHuy.UseVisualStyleBackColor = false;
            this.iconbtnHuy.Click += new System.EventHandler(this.iconbtnHuy_Click);
            // 
            // iconbtnThem
            // 
            this.iconbtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnThem.FlatAppearance.BorderSize = 0;
            this.iconbtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnThem.ForeColor = System.Drawing.Color.White;
            this.iconbtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconbtnThem.IconColor = System.Drawing.Color.White;
            this.iconbtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnThem.IconSize = 43;
            this.iconbtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnThem.Location = new System.Drawing.Point(105, 21);
            this.iconbtnThem.Name = "iconbtnThem";
            this.iconbtnThem.Size = new System.Drawing.Size(140, 53);
            this.iconbtnThem.TabIndex = 13;
            this.iconbtnThem.Text = "Thêm";
            this.iconbtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnThem.UseVisualStyleBackColor = false;
            this.iconbtnThem.Click += new System.EventHandler(this.iconbtnThem_Click);
            // 
            // iconbtnXoa
            // 
            this.iconbtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnXoa.FlatAppearance.BorderSize = 0;
            this.iconbtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnXoa.ForeColor = System.Drawing.Color.White;
            this.iconbtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnXoa.IconColor = System.Drawing.Color.White;
            this.iconbtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnXoa.IconSize = 43;
            this.iconbtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnXoa.Location = new System.Drawing.Point(555, 21);
            this.iconbtnXoa.Name = "iconbtnXoa";
            this.iconbtnXoa.Size = new System.Drawing.Size(140, 53);
            this.iconbtnXoa.TabIndex = 14;
            this.iconbtnXoa.Text = "Xóa";
            this.iconbtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnXoa.UseVisualStyleBackColor = false;
            this.iconbtnXoa.Click += new System.EventHandler(this.iconbtnXoa_Click);
            // 
            // frmQLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1162, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhuyenMai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLKhuyenMai";
            this.Text = "frmQLKhuyenMai";
            this.Load += new System.EventHandler(this.frmQLKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconbtnSua;
        private FontAwesome.Sharp.IconButton iconbtnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker timeKT;
        private System.Windows.Forms.DateTimePicker timeBD;
        private System.Windows.Forms.DateTimePicker dateTimeBatDau;
        private System.Windows.Forms.DateTimePicker dateTimeKetThuc;
        private FontAwesome.Sharp.IconButton iconbtnXoa;
        private FontAwesome.Sharp.IconButton iconbtnThem;
    }
}