namespace KhachSan
{
    partial class frmTraCuuPhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuThue));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.rdb_ngaythue = new System.Windows.Forms.RadioButton();
            this.dtpngaythue = new System.Windows.Forms.DateTimePicker();
            this.rdb_tenkh = new System.Windows.Forms.RadioButton();
            this.rdb_maphong = new System.Windows.Forms.RadioButton();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.dgv_timkiem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemDS);
            this.groupBox1.Controls.Add(this.rdb_ngaythue);
            this.groupBox1.Controls.Add(this.dtpngaythue);
            this.groupBox1.Controls.Add(this.rdb_tenkh);
            this.groupBox1.Controls.Add(this.rdb_maphong);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Location = new System.Drawing.Point(50, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tra Cứu";
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackgroundImage = global::KhachSan.Properties.Resources._1381866046_104036;
            this.btnXemDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.ForeColor = System.Drawing.Color.Red;
            this.btnXemDS.Location = new System.Drawing.Point(527, 85);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(108, 41);
            this.btnXemDS.TabIndex = 20;
            this.btnXemDS.Text = "Xem Danh Sách";
            this.btnXemDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // rdb_ngaythue
            // 
            this.rdb_ngaythue.AutoSize = true;
            this.rdb_ngaythue.Location = new System.Drawing.Point(27, 92);
            this.rdb_ngaythue.Name = "rdb_ngaythue";
            this.rdb_ngaythue.Size = new System.Drawing.Size(81, 17);
            this.rdb_ngaythue.TabIndex = 19;
            this.rdb_ngaythue.TabStop = true;
            this.rdb_ngaythue.Text = " Ngày Thuê";
            this.rdb_ngaythue.UseVisualStyleBackColor = true;
            // 
            // dtpngaythue
            // 
            this.dtpngaythue.Location = new System.Drawing.Point(123, 92);
            this.dtpngaythue.Name = "dtpngaythue";
            this.dtpngaythue.Size = new System.Drawing.Size(200, 20);
            this.dtpngaythue.TabIndex = 18;
            // 
            // rdb_tenkh
            // 
            this.rdb_tenkh.AutoSize = true;
            this.rdb_tenkh.Location = new System.Drawing.Point(388, 42);
            this.rdb_tenkh.Name = "rdb_tenkh";
            this.rdb_tenkh.Size = new System.Drawing.Size(107, 17);
            this.rdb_tenkh.TabIndex = 17;
            this.rdb_tenkh.TabStop = true;
            this.rdb_tenkh.Text = "Tên Khách Hàng";
            this.rdb_tenkh.UseVisualStyleBackColor = true;
            // 
            // rdb_maphong
            // 
            this.rdb_maphong.AutoSize = true;
            this.rdb_maphong.Checked = true;
            this.rdb_maphong.Location = new System.Drawing.Point(27, 43);
            this.rdb_maphong.Name = "rdb_maphong";
            this.rdb_maphong.Size = new System.Drawing.Size(74, 17);
            this.rdb_maphong.TabIndex = 16;
            this.rdb_maphong.TabStop = true;
            this.rdb_maphong.Text = "Mã Phòng";
            this.rdb_maphong.UseVisualStyleBackColor = true;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(501, 41);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(220, 20);
            this.txt_tenkh.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KhachSan.Properties.Resources._1381866454_860671;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(400, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tra cứu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(123, 43);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(200, 20);
            this.txt_maphong.TabIndex = 4;
            // 
            // dgv_timkiem
            // 
            this.dgv_timkiem.AllowUserToAddRows = false;
            this.dgv_timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaKH,
            this.TenKH,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dgv_timkiem.Location = new System.Drawing.Point(50, 224);
            this.dgv_timkiem.Name = "dgv_timkiem";
            this.dgv_timkiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_timkiem.Size = new System.Drawing.Size(745, 204);
            this.dgv_timkiem.TabIndex = 11;
            this.dgv_timkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_timkiem_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhieu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "CMND";
            this.MaKH.HeaderText = "CMND";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = false;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NgayThue";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày Thuê";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoNguoi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số người";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "LapHoaDon";
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Lập hóa đơn";
            this.dataGridViewButtonColumn1.ToolTipText = "Lập hóa đơn";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(308, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "DANH SÁCH PHIẾU THUÊ";
            // 
            // frmTraCuuPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(842, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra Cứu Phiếu Thuê";
            this.Load += new System.EventHandler(this.frmTraCuuPhieuThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.RadioButton rdb_tenkh;
        private System.Windows.Forms.RadioButton rdb_maphong;
        private System.Windows.Forms.DataGridView dgv_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpngaythue;
        private System.Windows.Forms.RadioButton rdb_ngaythue;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}