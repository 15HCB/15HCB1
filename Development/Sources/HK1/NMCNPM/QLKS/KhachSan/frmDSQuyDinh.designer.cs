namespace KhachSan
{
    partial class frmDSQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSQuyDinh));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaQD = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.txt_heso = new System.Windows.Forms.TextBox();
            this.txt_tenqd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_dsquydinh = new System.Windows.Forms.DataGridView();
            this.MaQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsquydinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH QUY ĐỊNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaQD);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_heso);
            this.groupBox1.Controls.Add(this.txt_tenqd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(137, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 247);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin quy định";
            // 
            // lblMaQD
            // 
            this.lblMaQD.AutoSize = true;
            this.lblMaQD.Location = new System.Drawing.Point(169, 35);
            this.lblMaQD.Name = "lblMaQD";
            this.lblMaQD.Size = new System.Drawing.Size(66, 13);
            this.lblMaQD.TabIndex = 10;
            this.lblMaQD.Text = "Mã quy định";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.White;
            this.btn_capnhat.BackgroundImage = global::KhachSan.Properties.Resources._1381868021_accepted_481;
            this.btn_capnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_capnhat.Location = new System.Drawing.Point(280, 195);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(86, 36);
            this.btn_capnhat.TabIndex = 9;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.BackgroundImage = global::KhachSan.Properties.Resources._1381868281_32378;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Location = new System.Drawing.Point(172, 195);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 36);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(172, 119);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(208, 52);
            this.txt_ghichu.TabIndex = 6;
            this.txt_ghichu.Text = "";
            // 
            // txt_heso
            // 
            this.txt_heso.Location = new System.Drawing.Point(172, 92);
            this.txt_heso.Name = "txt_heso";
            this.txt_heso.Size = new System.Drawing.Size(208, 20);
            this.txt_heso.TabIndex = 5;
            // 
            // txt_tenqd
            // 
            this.txt_tenqd.Location = new System.Drawing.Point(172, 64);
            this.txt_tenqd.Name = "txt_tenqd";
            this.txt_tenqd.Size = new System.Drawing.Size(208, 20);
            this.txt_tenqd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hệ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên quy định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã quy định";
            // 
            // dgv_dsquydinh
            // 
            this.dgv_dsquydinh.AllowUserToAddRows = false;
            this.dgv_dsquydinh.AllowUserToDeleteRows = false;
            this.dgv_dsquydinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsquydinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQD,
            this.TenQD,
            this.HeSo,
            this.GhiChu,
            this.Xoa});
            this.dgv_dsquydinh.Location = new System.Drawing.Point(125, 73);
            this.dgv_dsquydinh.Name = "dgv_dsquydinh";
            this.dgv_dsquydinh.ReadOnly = true;
            this.dgv_dsquydinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsquydinh.Size = new System.Drawing.Size(496, 184);
            this.dgv_dsquydinh.TabIndex = 10;
            this.dgv_dsquydinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsquydinh_CellContentClick);
            this.dgv_dsquydinh.SelectionChanged += new System.EventHandler(this.dgv_dsquydinh_SelectionChanged);
            // 
            // MaQD
            // 
            this.MaQD.DataPropertyName = "MaQD";
            this.MaQD.HeaderText = "Mã quy định";
            this.MaQD.Name = "MaQD";
            this.MaQD.ReadOnly = true;
            // 
            // TenQD
            // 
            this.TenQD.DataPropertyName = "TenQD";
            this.TenQD.HeaderText = "Tên quy định";
            this.TenQD.Name = "TenQD";
            this.TenQD.ReadOnly = true;
            // 
            // HeSo
            // 
            this.HeSo.DataPropertyName = "HeSo";
            this.HeSo.HeaderText = "Hệ Số";
            this.HeSo.Name = "HeSo";
            this.HeSo.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.FillWeight = 50F;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Text = "delete";
            this.Xoa.ToolTipText = "delete";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // frmDSQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(739, 553);
            this.Controls.Add(this.dgv_dsquydinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDSQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Quy Định";
            this.Load += new System.EventHandler(this.QuanLiQuyDinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsquydinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_heso;
        private System.Windows.Forms.TextBox txt_tenqd;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_dsquydinh;
        private System.Windows.Forms.Label lblMaQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;

    }
}