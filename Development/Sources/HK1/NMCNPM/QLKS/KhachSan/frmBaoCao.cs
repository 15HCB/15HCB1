using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUSLayer;
using DTOLayer;

namespace KhachSan
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            LoadDuLieu1();
        }

        private void btnMatDo_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            LoadDuLieu2();
        }
        private void LoadDuLieu1()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang1.Items.Add(i.ToString());
                
            }
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cmbNam1.Items.Add(i.ToString());
                
            }
        }
        private void LoadDuLieu2()
        {
            for (int i = 1; i <= 12; i++)
            {
                
                cmbThang2.Items.Add(i.ToString());
            }
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                
                cmbNam2.Items.Add(i.ToString());
            }
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cmbThang1.Text);
                int nam = int.Parse(cmbNam1.Text);               
                
                //baocao.rptBaoCaoDoanhThu dt = new baocao.rptBaoCaoDoanhThu();
                //dt.SetParameterValue("@thang", thang);
                //dt.SetParameterValue("@nam", nam);
                //dt.SetParameterValue("labelThang", thang);
                //dt.SetParameterValue("labelNam", nam);                
                
                baocao.BaoCaoDoanhThu frm = new baocao.BaoCaoDoanhThu();
                //frm.rptViewer.ReportSource = dt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cmbThang2.Text);
                int nam = int.Parse(cmbNam2.Text);

                //baocao.rptBaoCaoMatDo dt = new baocao.rptBaoCaoMatDo();
                //dt.SetParameterValue("@thang", thang);
                //dt.SetParameterValue("@nam", nam);
                //dt.SetParameterValue("labelThang", thang);
                //dt.SetParameterValue("labelNam", nam);

                baocao.BaoCaoMatDo frm = new baocao.BaoCaoMatDo();
                //frm.reportViewer.ReportSource = dt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }

    }
}
