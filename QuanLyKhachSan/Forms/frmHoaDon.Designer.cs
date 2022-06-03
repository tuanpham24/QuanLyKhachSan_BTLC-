namespace QuanLyKhachSan.Forms
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.radioButtonDaTT = new System.Windows.Forms.RadioButton();
            this.radioButtonChuaTT = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(0, 217);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 29;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(794, 233);
            this.dataGridViewHoaDon.TabIndex = 0;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSize = true;
            this.MaHD.Location = new System.Drawing.Point(25, 27);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(56, 20);
            this.MaHD.TabIndex = 1;
            this.MaHD.Text = "Mã HD";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(123, 20);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(260, 27);
            this.txtMaHD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(123, 70);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(260, 27);
            this.txtMaPhong.TabIndex = 7;
            // 
            // dateTimePickerNgayXuat
            // 
            this.dateTimePickerNgayXuat.Location = new System.Drawing.Point(502, 18);
            this.dateTimePickerNgayXuat.MaxDate = new System.DateTime(2098, 11, 30, 0, 0, 0, 0);
            this.dateTimePickerNgayXuat.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNgayXuat.Name = "dateTimePickerNgayXuat";
            this.dateTimePickerNgayXuat.Size = new System.Drawing.Size(269, 27);
            this.dateTimePickerNgayXuat.TabIndex = 9;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(502, 70);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(269, 27);
            this.txtTongTien.TabIndex = 10;
            // 
            // radioButtonDaTT
            // 
            this.radioButtonDaTT.AutoSize = true;
            this.radioButtonDaTT.Location = new System.Drawing.Point(123, 122);
            this.radioButtonDaTT.Name = "radioButtonDaTT";
            this.radioButtonDaTT.Size = new System.Drawing.Size(124, 24);
            this.radioButtonDaTT.TabIndex = 12;
            this.radioButtonDaTT.TabStop = true;
            this.radioButtonDaTT.Text = "Đã thanh toán";
            this.radioButtonDaTT.UseVisualStyleBackColor = true;
            // 
            // radioButtonChuaTT
            // 
            this.radioButtonChuaTT.AutoSize = true;
            this.radioButtonChuaTT.Location = new System.Drawing.Point(253, 122);
            this.radioButtonChuaTT.Name = "radioButtonChuaTT";
            this.radioButtonChuaTT.Size = new System.Drawing.Size(139, 24);
            this.radioButtonChuaTT.TabIndex = 13;
            this.radioButtonChuaTT.TabStop = true;
            this.radioButtonChuaTT.Text = "Chưa thanh toán";
            this.radioButtonChuaTT.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(23, 173);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 27);
            this.txtSearch.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(477, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(677, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(577, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.radioButtonChuaTT);
            this.Controls.Add(this.radioButtonDaTT);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dateTimePickerNgayXuat);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewHoaDon;
        private Label MaHD;
        private TextBox txtMaHD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaPhong;
        private DateTimePicker dateTimePickerNgayXuat;
        private TextBox txtTongTien;
        private RadioButton radioButtonDaTT;
        private RadioButton radioButtonChuaTT;
        private TextBox txtSearch;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnSearch;
    }
}