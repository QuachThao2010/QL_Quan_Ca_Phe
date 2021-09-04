
namespace BTLHighlandsCoffee
{
    partial class frmQLBan
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
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconbtnxoa = new FontAwesome.Sharp.IconButton();
            this.iconbtnthem = new FontAwesome.Sharp.IconButton();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBan
            // 
            this.dgvBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.TrangThai});
            this.dgvBan.Location = new System.Drawing.Point(665, 75);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.RowHeadersWidth = 51;
            this.dgvBan.RowTemplate.Height = 24;
            this.dgvBan.Size = new System.Drawing.Size(496, 343);
            this.dgvBan.TabIndex = 17;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.HeaderText = "Mã Bàn";
            this.MaBan.MinimumWidth = 6;
            this.MaBan.Name = "MaBan";
            this.MaBan.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.iconbtnxoa);
            this.groupBox1.Controls.Add(this.iconbtnthem);
            this.groupBox1.Controls.Add(this.cboTrangthai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmaban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(141, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 310);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN BÀN";
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
            this.iconbtnxoa.Location = new System.Drawing.Point(250, 252);
            this.iconbtnxoa.Name = "iconbtnxoa";
            this.iconbtnxoa.Size = new System.Drawing.Size(124, 40);
            this.iconbtnxoa.TabIndex = 19;
            this.iconbtnxoa.Text = "Xóa";
            this.iconbtnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnxoa.UseVisualStyleBackColor = false;
            this.iconbtnxoa.Click += new System.EventHandler(this.btnxoa_Click);
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
            this.iconbtnthem.Location = new System.Drawing.Point(80, 252);
            this.iconbtnthem.Name = "iconbtnthem";
            this.iconbtnthem.Size = new System.Drawing.Size(124, 40);
            this.iconbtnthem.TabIndex = 18;
            this.iconbtnthem.Text = "Thêm";
            this.iconbtnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnthem.UseVisualStyleBackColor = false;
            this.iconbtnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cboTrangthai.Location = new System.Drawing.Point(200, 157);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(200, 37);
            this.cboTrangthai.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trạng thái";
            // 
            // txtmaban
            // 
            this.txtmaban.Location = new System.Drawing.Point(200, 96);
            this.txtmaban.Name = "txtmaban";
            this.txtmaban.Size = new System.Drawing.Size(200, 34);
            this.txtmaban.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bàn";
            // 
            // frmQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1267, 578);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLBan";
            this.Text = "frmQLBan";
            this.Load += new System.EventHandler(this.frmQLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private FontAwesome.Sharp.IconButton iconbtnxoa;
        private FontAwesome.Sharp.IconButton iconbtnthem;
    }
}