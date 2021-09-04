
namespace BTLHighlandsCoffee
{
     partial class frmMainNV
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.iconHighlands = new FontAwesome.Sharp.IconButton();
            this.btnBanHang = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.blView = new System.Windows.Forms.Label();
            this.iconView = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Brown;
            this.pnlMenu.Controls.Add(this.iconButton2);
            this.pnlMenu.Controls.Add(this.iconHighlands);
            this.pnlMenu.Controls.Add(this.btnBanHang);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 981);
            this.pnlMenu.TabIndex = 0;
            // 
            // iconHighlands
            // 
            this.iconHighlands.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconHighlands.FlatAppearance.BorderSize = 0;
            this.iconHighlands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHighlands.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconHighlands.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconHighlands.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconHighlands.IconColor = System.Drawing.Color.SeaShell;
            this.iconHighlands.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHighlands.IconSize = 35;
            this.iconHighlands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHighlands.Location = new System.Drawing.Point(0, 203);
            this.iconHighlands.Name = "iconHighlands";
            this.iconHighlands.Size = new System.Drawing.Size(260, 60);
            this.iconHighlands.TabIndex = 14;
            this.iconHighlands.Text = "Quản lý khuyến mãi";
            this.iconHighlands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHighlands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHighlands.UseVisualStyleBackColor = true;
            this.iconHighlands.Click += new System.EventHandler(this.btnQLKhuyenMai_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBanHang.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnBanHang.IconColor = System.Drawing.Color.SeaShell;
            this.btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanHang.IconSize = 35;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(0, 143);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(260, 60);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 143);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BTLHighlandsCoffee.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(260, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(918, 931);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.iconButton1);
            this.pnlTop.Controls.Add(this.lblTenTaiKhoan);
            this.pnlTop.Controls.Add(this.blView);
            this.pnlTop.Controls.Add(this.iconView);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(260, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(918, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Brown;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(590, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 50);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(633, 0);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(285, 50);
            this.lblTenTaiKhoan.TabIndex = 2;
            this.lblTenTaiKhoan.Text = "Tài Khoản";
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blView
            // 
            this.blView.AutoSize = true;
            this.blView.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blView.ForeColor = System.Drawing.Color.Gainsboro;
            this.blView.Location = new System.Drawing.Point(70, 15);
            this.blView.Name = "blView";
            this.blView.Size = new System.Drawing.Size(191, 27);
            this.blView.TabIndex = 1;
            this.blView.Text = "HighlandsCoffee";
            // 
            // iconView
            // 
            this.iconView.BackColor = System.Drawing.Color.Brown;
            this.iconView.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.iconView.IconColor = System.Drawing.Color.White;
            this.iconView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconView.Location = new System.Drawing.Point(31, 15);
            this.iconView.Name = "iconView";
            this.iconView.Size = new System.Drawing.Size(32, 32);
            this.iconView.TabIndex = 0;
            this.iconView.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.iconButton2.IconColor = System.Drawing.Color.SeaShell;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 263);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(260, 60);
            this.iconButton2.TabIndex = 15;
            this.iconButton2.Text = "HighlandsCoffee";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconHighlands_Click);
            // 
            // frmMainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 981);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMainNV";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label blView;
        private FontAwesome.Sharp.IconPictureBox iconView;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconHighlands;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}