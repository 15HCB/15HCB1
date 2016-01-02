namespace KhachSan
{
    partial class frmDSPhongTrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSPhongTrong));
            this.dgvDSPhongTrong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLapPT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnFesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhongTrong
            // 
            this.dgvDSPhongTrong.AllowUserToAddRows = false;
            this.dgvDSPhongTrong.AllowUserToDeleteRows = false;
            this.dgvDSPhongTrong.AllowUserToOrderColumns = true;
            this.dgvDSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.TenLoaiPhong,
            this.DonGia,
            this.btnLapPT});
            this.dgvDSPhongTrong.Location = new System.Drawing.Point(31, 66);
            this.dgvDSPhongTrong.MultiSelect = false;
            this.dgvDSPhongTrong.Name = "dgvDSPhongTrong";
            this.dgvDSPhongTrong.ReadOnly = true;
            this.dgvDSPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhongTrong.Size = new System.Drawing.Size(543, 273);
            this.dgvDSPhongTrong.TabIndex = 50;
            this.dgvDSPhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhongTrong_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // btnLapPT
            // 
            this.btnLapPT.HeaderText = "";
            this.btnLapPT.Name = "btnLapPT";
            this.btnLapPT.ReadOnly = true;
            this.btnLapPT.Text = "Lập Phiếu Thuê";
            this.btnLapPT.ToolTipText = "Lập Phiếu Thuê";
            this.btnLapPT.UseColumnTextForButtonValue = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(31, 38);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(159, 22);
            this.txtTim.TabIndex = 51;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::KhachSan.Properties.Resources._1381866454_860671;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTim.Location = new System.Drawing.Point(217, 21);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 40);
            this.btnTim.TabIndex = 52;
            this.btnTim.Text = "Tìm nhanh";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnFesh
            // 
            this.btnFesh.BackColor = System.Drawing.Color.White;
            this.btnFesh.BackgroundImage = global::KhachSan.Properties.Resources._1381869569_48111;
            this.btnFesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFesh.Location = new System.Drawing.Point(475, 22);
            this.btnFesh.Name = "btnFesh";
            this.btnFesh.Size = new System.Drawing.Size(84, 38);
            this.btnFesh.TabIndex = 53;
            this.btnFesh.Text = "Refesh";
            this.btnFesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFesh.UseVisualStyleBackColor = false;
            this.btnFesh.Click += new System.EventHandler(this.btnFesh_Click);
            // 
            // frmDSPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(591, 358);
            this.Controls.Add(this.btnFesh);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dgvDSPhongTrong);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDSPhongTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách phòng trống";
            this.Load += new System.EventHandler(this.frmDSPhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhongTrong;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewButtonColumn btnLapPT;
        private System.Windows.Forms.Button btnFesh;
    }
}