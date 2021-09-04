
namespace BTLHighlandsCoffee
{
    partial class frmQLCa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconbtnxoaca = new FontAwesome.Sharp.IconButton();
            this.dgvCa = new System.Windows.Forms.DataGridView();
            this.iconbtnsuaca = new FontAwesome.Sharp.IconButton();
            this.txtluongca = new System.Windows.Forms.TextBox();
            this.iconbtnthemca = new FontAwesome.Sharp.IconButton();
            this.txtgiokt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiobd = new System.Windows.Forms.TextBox();
            this.txtmaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconbtnxoaca);
            this.groupBox1.Controls.Add(this.dgvCa);
            this.groupBox1.Controls.Add(this.iconbtnsuaca);
            this.groupBox1.Controls.Add(this.txtluongca);
            this.groupBox1.Controls.Add(this.iconbtnthemca);
            this.groupBox1.Controls.Add(this.txtgiokt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtgiobd);
            this.groupBox1.Controls.Add(this.txtmaca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(392, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 701);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ CA";
            // 
            // iconbtnxoaca
            // 
            this.iconbtnxoaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnxoaca.FlatAppearance.BorderSize = 0;
            this.iconbtnxoaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnxoaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnxoaca.ForeColor = System.Drawing.Color.White;
            this.iconbtnxoaca.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnxoaca.IconColor = System.Drawing.Color.White;
            this.iconbtnxoaca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnxoaca.IconSize = 40;
            this.iconbtnxoaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnxoaca.Location = new System.Drawing.Point(444, 612);
            this.iconbtnxoaca.Name = "iconbtnxoaca";
            this.iconbtnxoaca.Size = new System.Drawing.Size(127, 44);
            this.iconbtnxoaca.TabIndex = 26;
            this.iconbtnxoaca.Text = "Xóa";
            this.iconbtnxoaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnxoaca.UseVisualStyleBackColor = false;
            this.iconbtnxoaca.Click += new System.EventHandler(this.iconbtnxoaca_Click);
            // 
            // dgvCa
            // 
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.GioBD,
            this.GioKT,
            this.LuongCa});
            this.dgvCa.Location = new System.Drawing.Point(19, 276);
            this.dgvCa.Name = "dgvCa";
            this.dgvCa.RowHeadersWidth = 51;
            this.dgvCa.RowTemplate.Height = 50;
            this.dgvCa.Size = new System.Drawing.Size(664, 288);
            this.dgvCa.TabIndex = 13;
            this.dgvCa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCa_CellClick);
            // 
            // iconbtnsuaca
            // 
            this.iconbtnsuaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnsuaca.FlatAppearance.BorderSize = 0;
            this.iconbtnsuaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnsuaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnsuaca.ForeColor = System.Drawing.Color.White;
            this.iconbtnsuaca.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnsuaca.IconColor = System.Drawing.Color.White;
            this.iconbtnsuaca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnsuaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnsuaca.Location = new System.Drawing.Point(255, 612);
            this.iconbtnsuaca.Name = "iconbtnsuaca";
            this.iconbtnsuaca.Size = new System.Drawing.Size(125, 44);
            this.iconbtnsuaca.TabIndex = 25;
            this.iconbtnsuaca.Text = "Sửa";
            this.iconbtnsuaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnsuaca.UseVisualStyleBackColor = false;
            this.iconbtnsuaca.Click += new System.EventHandler(this.iconbtnsuaca_Click);
            // 
            // txtluongca
            // 
            this.txtluongca.Location = new System.Drawing.Point(306, 197);
            this.txtluongca.Name = "txtluongca";
            this.txtluongca.Size = new System.Drawing.Size(197, 28);
            this.txtluongca.TabIndex = 12;
            // 
            // iconbtnthemca
            // 
            this.iconbtnthemca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconbtnthemca.FlatAppearance.BorderSize = 0;
            this.iconbtnthemca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnthemca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnthemca.ForeColor = System.Drawing.Color.White;
            this.iconbtnthemca.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnthemca.IconColor = System.Drawing.Color.White;
            this.iconbtnthemca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnthemca.IconSize = 40;
            this.iconbtnthemca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnthemca.Location = new System.Drawing.Point(86, 612);
            this.iconbtnthemca.Name = "iconbtnthemca";
            this.iconbtnthemca.Size = new System.Drawing.Size(127, 44);
            this.iconbtnthemca.TabIndex = 24;
            this.iconbtnthemca.Text = "Thêm";
            this.iconbtnthemca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnthemca.UseVisualStyleBackColor = false;
            this.iconbtnthemca.Click += new System.EventHandler(this.iconbtnthemca_Click);
            // 
            // txtgiokt
            // 
            this.txtgiokt.Location = new System.Drawing.Point(306, 141);
            this.txtgiokt.Name = "txtgiokt";
            this.txtgiokt.Size = new System.Drawing.Size(197, 28);
            this.txtgiokt.TabIndex = 11;
            this.txtgiokt.Validated += new System.EventHandler(this.txtgiokt_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ bắt đầu";
            // 
            // txtgiobd
            // 
            this.txtgiobd.Location = new System.Drawing.Point(306, 89);
            this.txtgiobd.Name = "txtgiobd";
            this.txtgiobd.Size = new System.Drawing.Size(197, 28);
            this.txtgiobd.TabIndex = 10;
            this.txtgiobd.Validated += new System.EventHandler(this.txtgiobd_Validated);
            // 
            // txtmaca
            // 
            this.txtmaca.Location = new System.Drawing.Point(306, 38);
            this.txtmaca.Name = "txtmaca";
            this.txtmaca.Size = new System.Drawing.Size(197, 28);
            this.txtmaca.TabIndex = 9;
            this.txtmaca.Validated += new System.EventHandler(this.txtmaca_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lương ca NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giờ kết thúc";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.Width = 130;
            // 
            // GioBD
            // 
            this.GioBD.DataPropertyName = "GioBD";
            this.GioBD.HeaderText = "Giờ BĐ";
            this.GioBD.MinimumWidth = 6;
            this.GioBD.Name = "GioBD";
            // 
            // GioKT
            // 
            this.GioKT.DataPropertyName = "GioKT";
            this.GioKT.HeaderText = "Giờ KT";
            this.GioKT.MinimumWidth = 6;
            this.GioKT.Name = "GioKT";
            // 
            // LuongCa
            // 
            this.LuongCa.DataPropertyName = "LuongCa";
            this.LuongCa.HeaderText = "Lương ca";
            this.LuongCa.MinimumWidth = 6;
            this.LuongCa.Name = "LuongCa";
            this.LuongCa.Width = 170;
            // 
            // frmQLCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1259, 746);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLCa";
            this.Text = "frmQLCa";
            this.Load += new System.EventHandler(this.frmQLCa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCa;
        private System.Windows.Forms.TextBox txtluongca;
        private System.Windows.Forms.TextBox txtgiokt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiobd;
        private System.Windows.Forms.TextBox txtmaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconbtnxoaca;
        private FontAwesome.Sharp.IconButton iconbtnsuaca;
        private FontAwesome.Sharp.IconButton iconbtnthemca;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCa;
    }
}