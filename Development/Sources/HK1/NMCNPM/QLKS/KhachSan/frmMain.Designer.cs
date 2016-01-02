namespace KhachSan
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDSNV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDSPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhongTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDSLoaiP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDSQD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTCPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTCPhieuThue = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHeThong,
            this.btnQLNhanVien,
            this.btnQLPhong,
            this.btnQLLoaiPhong,
            this.btnQLQuyDinh,
            this.btnBaoCao,
            this.btnTraCuu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(793, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnTTCaNhan,
            this.btnThoat});
            this.btnHeThong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.Navy;
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(72, 19);
            this.btnHeThong.Text = "Hệ Thống";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(172, 22);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(172, 22);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTTCaNhan
            // 
            this.btnTTCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTTCaNhan.Name = "btnTTCaNhan";
            this.btnTTCaNhan.Size = new System.Drawing.Size(172, 22);
            this.btnTTCaNhan.Text = "Thông tin cá nhân";
            this.btnTTCaNhan.Click += new System.EventHandler(this.btnTTCaNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDSNV,
            this.btnThemNV});
            this.btnQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.Navy;
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(127, 19);
            this.btnQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // btnDSNV
            // 
            this.btnDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(186, 22);
            this.btnDSNV.Text = "Danh sách nhân viên";
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(186, 22);
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDSPhong,
            this.btnPhongTrong});
            this.btnQLPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhong.ForeColor = System.Drawing.Color.Navy;
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Size = new System.Drawing.Size(104, 19);
            this.btnQLPhong.Text = "Quản Lý Phòng";
            // 
            // btnDSPhong
            // 
            this.btnDSPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDSPhong.Name = "btnDSPhong";
            this.btnDSPhong.Size = new System.Drawing.Size(200, 22);
            this.btnDSPhong.Text = "Danh sách phòng";
            this.btnDSPhong.Click += new System.EventHandler(this.btnDSPhong_Click);
            // 
            // btnPhongTrong
            // 
            this.btnPhongTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPhongTrong.Name = "btnPhongTrong";
            this.btnPhongTrong.Size = new System.Drawing.Size(200, 22);
            this.btnPhongTrong.Text = "Danh sách phòng trống";
            this.btnPhongTrong.Click += new System.EventHandler(this.btnPhongTrong_Click);
            // 
            // btnQLLoaiPhong
            // 
            this.btnQLLoaiPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDSLoaiP});
            this.btnQLLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLoaiPhong.ForeColor = System.Drawing.Color.Navy;
            this.btnQLLoaiPhong.Name = "btnQLLoaiPhong";
            this.btnQLLoaiPhong.Size = new System.Drawing.Size(131, 19);
            this.btnQLLoaiPhong.Text = "Quản Lý Loại Phòng";
            // 
            // btnDSLoaiP
            // 
            this.btnDSLoaiP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDSLoaiP.Name = "btnDSLoaiP";
            this.btnDSLoaiP.Size = new System.Drawing.Size(190, 22);
            this.btnDSLoaiP.Text = "Danh sách loại phòng";
            this.btnDSLoaiP.Click += new System.EventHandler(this.btnDSLoaiP_Click);
            // 
            // btnQLQuyDinh
            // 
            this.btnQLQuyDinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDSQD});
            this.btnQLQuyDinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLQuyDinh.ForeColor = System.Drawing.Color.Navy;
            this.btnQLQuyDinh.Name = "btnQLQuyDinh";
            this.btnQLQuyDinh.Size = new System.Drawing.Size(122, 19);
            this.btnQLQuyDinh.Text = "Quản Lý Quy Định";
            // 
            // btnDSQD
            // 
            this.btnDSQD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDSQD.Name = "btnDSQD";
            this.btnDSQD.Size = new System.Drawing.Size(180, 22);
            this.btnDSQD.Text = "Danh sách quy định";
            this.btnDSQD.Click += new System.EventHandler(this.btnDSQD_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Navy;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(87, 19);
            this.btnBaoCao.Text = "Lập Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTCPhong,
            this.btnTCPhieuThue});
            this.btnTraCuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Navy;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(65, 19);
            this.btnTraCuu.Text = "Tra Cứu";
            // 
            // btnTCPhong
            // 
            this.btnTCPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTCPhong.Name = "btnTCPhong";
            this.btnTCPhong.Size = new System.Drawing.Size(133, 22);
            this.btnTCPhong.Text = "Phòng";
            this.btnTCPhong.Click += new System.EventHandler(this.btnTCPhong_Click);
            // 
            // btnTCPhieuThue
            // 
            this.btnTCPhieuThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTCPhieuThue.Name = "btnTCPhieuThue";
            this.btnTCPhieuThue.Size = new System.Drawing.Size(133, 22);
            this.btnTCPhieuThue.Text = "Phiếu thuê";
            this.btnTCPhieuThue.Click += new System.EventHandler(this.btnTCPhieuThue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::KhachSan.Properties.Resources.dark_blue_background_wide__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(793, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý khách sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHeThong;
        private System.Windows.Forms.ToolStripMenuItem btnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem btnTTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem btnQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnDSNV;
        private System.Windows.Forms.ToolStripMenuItem btnThemNV;
        private System.Windows.Forms.ToolStripMenuItem btnQLPhong;
        private System.Windows.Forms.ToolStripMenuItem btnDSPhong;
        private System.Windows.Forms.ToolStripMenuItem btnPhongTrong;
        private System.Windows.Forms.ToolStripMenuItem btnQLLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem btnDSLoaiP;
        private System.Windows.Forms.ToolStripMenuItem btnQLQuyDinh;
        private System.Windows.Forms.ToolStripMenuItem btnDSQD;
        private System.Windows.Forms.ToolStripMenuItem btnBaoCao;
        private System.Windows.Forms.ToolStripMenuItem btnTraCuu;
        private System.Windows.Forms.ToolStripMenuItem btnTCPhong;
        private System.Windows.Forms.ToolStripMenuItem btnTCPhieuThue;
        private System.Windows.Forms.Label label1;

    }
}