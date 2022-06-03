namespace QuanLyKhachSan
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.QuanLyToolStripMenuItem,
            this.TroGiupToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(959, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhapToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // DangNhapToolStripMenuItem
            // 
            this.DangNhapToolStripMenuItem.Name = "DangNhapToolStripMenuItem";
            this.DangNhapToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.DangNhapToolStripMenuItem.Text = "Đăng nhập";
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KhachHangToolStripMenuItem,
            this.PhongToolStripMenuItem,
            this.HoaDonToolStripMenuItem,
            this.DichVuToolStripMenuItem,
            this.NhanVienToolStripMenuItem});
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.QuanLyToolStripMenuItem.Text = "Quản lý ";
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.KhachHangToolStripMenuItem.Text = "Khách Hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // PhongToolStripMenuItem
            // 
            this.PhongToolStripMenuItem.Name = "PhongToolStripMenuItem";
            this.PhongToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.PhongToolStripMenuItem.Text = "Phòng";
            this.PhongToolStripMenuItem.Click += new System.EventHandler(this.PhongToolStripMenuItem_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.HoaDonToolStripMenuItem.Text = "Hóa đơn";
            this.HoaDonToolStripMenuItem.Click += new System.EventHandler(this.HoaDonToolStripMenuItem_Click);
            // 
            // DichVuToolStripMenuItem
            // 
            this.DichVuToolStripMenuItem.Name = "DichVuToolStripMenuItem";
            this.DichVuToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.DichVuToolStripMenuItem.Text = "Dịch vụ";
            this.DichVuToolStripMenuItem.Click += new System.EventHandler(this.DichVuToolStripMenuItem_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.NhanVienToolStripMenuItem.Text = "Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // TroGiupToolStripMenuItem
            // 
            this.TroGiupToolStripMenuItem.Name = "TroGiupToolStripMenuItem";
            this.TroGiupToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.TroGiupToolStripMenuItem.Text = "Trợ giúp?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 539);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(959, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý khách sạn";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem HeThongToolStripMenuItem;
        private ToolStripMenuItem QuanLyToolStripMenuItem;
        private ToolStripMenuItem KhachHangToolStripMenuItem;
        private ToolStripMenuItem PhongToolStripMenuItem;
        private ToolStripMenuItem HoaDonToolStripMenuItem;
        private ToolStripMenuItem DichVuToolStripMenuItem;
        private ToolStripMenuItem NhanVienToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem DangNhapToolStripMenuItem;
        private ToolStripMenuItem DangXuatToolStripMenuItem;
        private ToolStripMenuItem TroGiupToolStripMenuItem;
    }
}