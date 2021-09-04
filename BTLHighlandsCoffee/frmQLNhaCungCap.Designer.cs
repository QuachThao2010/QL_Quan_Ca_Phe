
namespace BTLHighlandsCoffee
{
    partial class frmQLNhaCungCap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimNhaCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnThemNhaCC = new FontAwesome.Sharp.IconButton();
            this.btnXoaNhaCC = new FontAwesome.Sharp.IconButton();
            this.btnSuaNhaCC = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhaCC);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(630, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(955, 586);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Location = new System.Drawing.Point(4, 138);
            this.dgvNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCC.Size = new System.Drawing.Size(951, 502);
            this.dgvNhaCC.TabIndex = 1;
            this.dgvNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimNhaCC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 111);
            this.panel1.TabIndex = 0;
            // 
            // txtTimNhaCC
            // 
            this.txtTimNhaCC.Location = new System.Drawing.Point(308, 36);
            this.txtTimNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimNhaCC.Name = "txtTimNhaCC";
            this.txtTimNhaCC.Size = new System.Drawing.Size(233, 30);
            this.txtTimNhaCC.TabIndex = 1;
            this.txtTimNhaCC.TextChanged += new System.EventHandler(this.txtTimNhaCC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tìm tên nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Địa chỉ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnThemNhaCC);
            this.groupBox1.Controls.Add(this.btnXoaNhaCC);
            this.groupBox1.Controls.Add(this.btnSuaNhaCC);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTenNhaCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(242, 220);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(276, 30);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(242, 168);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(276, 30);
            this.txtDienThoai.TabIndex = 3;
            this.txtDienThoai.Validated += new System.EventHandler(this.txtDienThoai_Validated);
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Location = new System.Drawing.Point(242, 116);
            this.txtTenNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(276, 30);
            this.txtTenNhaCC.TabIndex = 2;
            this.txtTenNhaCC.Validated += new System.EventHandler(this.txtTenNhaCC_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(238, 68);
            this.lbMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(0, 23);
            this.lbMa.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 45;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(388, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThemNhaCC
            // 
            this.btnThemNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhaCC.FlatAppearance.BorderSize = 0;
            this.btnThemNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhaCC.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThemNhaCC.IconColor = System.Drawing.Color.Black;
            this.btnThemNhaCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNhaCC.IconSize = 60;
            this.btnThemNhaCC.Location = new System.Drawing.Point(92, 328);
            this.btnThemNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhaCC.Name = "btnThemNhaCC";
            this.btnThemNhaCC.Size = new System.Drawing.Size(78, 64);
            this.btnThemNhaCC.TabIndex = 5;
            this.btnThemNhaCC.UseVisualStyleBackColor = false;
            this.btnThemNhaCC.Click += new System.EventHandler(this.btnThemNhaCC_Click);
            // 
            // btnXoaNhaCC
            // 
            this.btnXoaNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaNhaCC.FlatAppearance.BorderSize = 0;
            this.btnXoaNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNhaCC.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaNhaCC.IconColor = System.Drawing.Color.Black;
            this.btnXoaNhaCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaNhaCC.IconSize = 60;
            this.btnXoaNhaCC.Location = new System.Drawing.Point(294, 316);
            this.btnXoaNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNhaCC.Name = "btnXoaNhaCC";
            this.btnXoaNhaCC.Size = new System.Drawing.Size(66, 73);
            this.btnXoaNhaCC.TabIndex = 7;
            this.btnXoaNhaCC.UseVisualStyleBackColor = false;
            this.btnXoaNhaCC.Click += new System.EventHandler(this.btnXoaNhaCC_Click);
            // 
            // btnSuaNhaCC
            // 
            this.btnSuaNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaNhaCC.FlatAppearance.BorderSize = 0;
            this.btnSuaNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNhaCC.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSuaNhaCC.IconColor = System.Drawing.Color.Black;
            this.btnSuaNhaCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNhaCC.IconSize = 65;
            this.btnSuaNhaCC.Location = new System.Drawing.Point(202, 324);
            this.btnSuaNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNhaCC.Name = "btnSuaNhaCC";
            this.btnSuaNhaCC.Size = new System.Drawing.Size(63, 65);
            this.btnSuaNhaCC.TabIndex = 6;
            this.btnSuaNhaCC.UseVisualStyleBackColor = false;
            this.btnSuaNhaCC.Click += new System.EventHandler(this.btnSuaNhaCC_Click);
            // 
            // frmQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1585, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNhaCungCap";
            this.Text = "QLNhaCungCap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLNhaCungCap_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimNhaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.Label lbMa;
        private FontAwesome.Sharp.IconButton btnThemNhaCC;
        private FontAwesome.Sharp.IconButton btnXoaNhaCC;
        private FontAwesome.Sharp.IconButton btnSuaNhaCC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnClear;
    }
}