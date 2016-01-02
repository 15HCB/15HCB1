namespace KhachSan
{
    partial class frmTraCuuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhong));
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbb_giatien = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_tinhtrang = new System.Windows.Forms.RadioButton();
            this.rdb_gia = new System.Windows.Forms.RadioButton();
            this.rdb_loai = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lapphieu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Location = new System.Drawing.Point(416, 42);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(121, 21);
            this.cbb_tinhtrang.TabIndex = 5;
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Location = new System.Drawing.Point(107, 42);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(121, 21);
            this.cbb_loaiphong.TabIndex = 6;
            // 
            // cbb_giatien
            // 
            this.cbb_giatien.FormattingEnabled = true;
            this.cbb_giatien.Location = new System.Drawing.Point(107, 98);
            this.cbb_giatien.Name = "cbb_giatien";
            this.cbb_giatien.Size = new System.Drawing.Size(121, 21);
            this.cbb_giatien.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_tinhtrang);
            this.groupBox1.Controls.Add(this.rdb_gia);
            this.groupBox1.Controls.Add(this.rdb_loai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbb_giatien);
            this.groupBox1.Controls.Add(this.cbb_loaiphong);
            this.groupBox1.Controls.Add(this.cbb_tinhtrang);
            this.groupBox1.Location = new System.Drawing.Point(100, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tra Cứu";
            // 
            // rdb_tinhtrang
            // 
            this.rdb_tinhtrang.AutoSize = true;
            this.rdb_tinhtrang.Location = new System.Drawing.Point(333, 45);
            this.rdb_tinhtrang.Name = "rdb_tinhtrang";
            this.rdb_tinhtrang.Size = new System.Drawing.Size(77, 17);
            this.rdb_tinhtrang.TabIndex = 11;
            this.rdb_tinhtrang.TabStop = true;
            this.rdb_tinhtrang.Text = "Tình Trạng";
            this.rdb_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // rdb_gia
            // 
            this.rdb_gia.AutoSize = true;
            this.rdb_gia.Location = new System.Drawing.Point(25, 98);
            this.rdb_gia.Name = "rdb_gia";
            this.rdb_gia.Size = new System.Drawing.Size(41, 17);
            this.rdb_gia.TabIndex = 10;
            this.rdb_gia.TabStop = true;
            this.rdb_gia.Text = "Giá";
            this.rdb_gia.UseVisualStyleBackColor = true;
            // 
            // rdb_loai
            // 
            this.rdb_loai.AutoSize = true;
            this.rdb_loai.Location = new System.Drawing.Point(25, 45);
            this.rdb_loai.Name = "rdb_loai";
            this.rdb_loai.Size = new System.Drawing.Size(79, 17);
            this.rdb_loai.TabIndex = 9;
            this.rdb_loai.TabStop = true;
            this.rdb_loai.Text = "Loại Phòng";
            this.rdb_loai.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KhachSan.Properties.Resources._1381866454_86067;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tra cứu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "TRA CỨU PHÒNG";
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.AllowUserToAddRows = false;
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.oai,
            this.tinhtrang,
            this.gia,
            this.Column1,
            this.lapphieu});
            this.dgv_thongtin.Location = new System.Drawing.Point(12, 294);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.Size = new System.Drawing.Size(746, 192);
            this.dgv_thongtin.TabIndex = 10;
            this.dgv_thongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtin_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // oai
            // 
            this.oai.DataPropertyName = "LoaiPhong";
            this.oai.HeaderText = "Loại Phòng";
            this.oai.Name = "oai";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "TinhTrang";
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "SoNguoi";
            this.gia.HeaderText = "Số Người";
            this.gia.Name = "gia";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GhiChu";
            this.Column1.HeaderText = "Ghi Chú";
            this.Column1.Name = "Column1";
            // 
            // lapphieu
            // 
            this.lapphieu.HeaderText = "";
            this.lapphieu.Name = "lapphieu";
            this.lapphieu.Text = "Lập phiếu";
            this.lapphieu.UseColumnTextForButtonValue = true;
            // 
            // frmTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(762, 498);
            this.Controls.Add(this.dgv_thongtin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra Cứu Phòng";
            this.Load += new System.EventHandler(this.frmTraCuuPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_tinhtrang;
        private System.Windows.Forms.ComboBox cbb_loaiphong;
        private System.Windows.Forms.ComboBox cbb_giatien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.RadioButton rdb_tinhtrang;
        private System.Windows.Forms.RadioButton rdb_gia;
        private System.Windows.Forms.RadioButton rdb_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn oai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn lapphieu;
    }
}