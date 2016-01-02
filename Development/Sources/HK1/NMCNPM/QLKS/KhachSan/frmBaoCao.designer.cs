namespace KhachSan
{
    partial class frmBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDT = new System.Windows.Forms.Button();
            this.cmbNam1 = new System.Windows.Forms.ComboBox();
            this.cmbThang1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMD = new System.Windows.Forms.Button();
            this.cmbNam2 = new System.Windows.Forms.ComboBox();
            this.cmbThang2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMatDo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP BÁO CÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo Cáo Doanh Thu Tháng\r\n Theo Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Báo Cáo \r\nMật Độ Sử Dụng Phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDT);
            this.panel1.Controls.Add(this.cmbNam1);
            this.panel1.Controls.Add(this.cmbThang1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(58, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 134);
            this.panel1.TabIndex = 4;
            // 
            // btnDT
            // 
            this.btnDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDT.Location = new System.Drawing.Point(84, 88);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(75, 23);
            this.btnDT.TabIndex = 2;
            this.btnDT.Text = "Chọn";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // cmbNam1
            // 
            this.cmbNam1.FormattingEnabled = true;
            this.cmbNam1.Location = new System.Drawing.Point(174, 18);
            this.cmbNam1.Name = "cmbNam1";
            this.cmbNam1.Size = new System.Drawing.Size(86, 21);
            this.cmbNam1.TabIndex = 1;
            // 
            // cmbThang1
            // 
            this.cmbThang1.FormattingEnabled = true;
            this.cmbThang1.Location = new System.Drawing.Point(65, 18);
            this.cmbThang1.Name = "cmbThang1";
            this.cmbThang1.Size = new System.Drawing.Size(42, 21);
            this.cmbThang1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tháng :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMD);
            this.panel2.Controls.Add(this.cmbNam2);
            this.panel2.Controls.Add(this.cmbThang2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(376, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 134);
            this.panel2.TabIndex = 5;
            // 
            // btnMD
            // 
            this.btnMD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMD.Location = new System.Drawing.Point(104, 88);
            this.btnMD.Name = "btnMD";
            this.btnMD.Size = new System.Drawing.Size(75, 23);
            this.btnMD.TabIndex = 7;
            this.btnMD.Text = "Chọn";
            this.btnMD.UseVisualStyleBackColor = true;
            this.btnMD.Click += new System.EventHandler(this.btnMD_Click);
            // 
            // cmbNam2
            // 
            this.cmbNam2.FormattingEnabled = true;
            this.cmbNam2.Location = new System.Drawing.Point(178, 20);
            this.cmbNam2.Name = "cmbNam2";
            this.cmbNam2.Size = new System.Drawing.Size(86, 21);
            this.cmbNam2.TabIndex = 6;
            // 
            // cmbThang2
            // 
            this.cmbThang2.FormattingEnabled = true;
            this.cmbThang2.Location = new System.Drawing.Point(69, 20);
            this.cmbThang2.Name = "cmbThang2";
            this.cmbThang2.Size = new System.Drawing.Size(42, 21);
            this.cmbThang2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tháng :";
            // 
            // btnMatDo
            // 
            this.btnMatDo.BackgroundImage = global::KhachSan.Properties.Resources.images;
            this.btnMatDo.Location = new System.Drawing.Point(376, 93);
            this.btnMatDo.Name = "btnMatDo";
            this.btnMatDo.Size = new System.Drawing.Size(81, 82);
            this.btnMatDo.TabIndex = 2;
            this.btnMatDo.UseVisualStyleBackColor = true;
            this.btnMatDo.Click += new System.EventHandler(this.btnMatDo_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KhachSan.Properties.Resources.images__1_;
            this.button1.Location = new System.Drawing.Point(58, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 82);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(691, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMatDo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMatDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNam1;
        private System.Windows.Forms.ComboBox cmbThang1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnMD;
        private System.Windows.Forms.ComboBox cmbNam2;
        private System.Windows.Forms.ComboBox cmbThang2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}