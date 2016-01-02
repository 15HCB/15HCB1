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
using DAOLayer;
namespace KhachSan
{
    public partial class frmDSPhongTrong : Form
    {
        public frmDSPhongTrong()
        {
            InitializeComponent();
        }

        private void frmDSPhongTrong_Load(object sender, EventArgs e)
        {
            dgvDSPhongTrong.AutoGenerateColumns = false;
            dgvDSPhongTrong.DataSource = BUS_Phong.DSPhongTrong();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text;
            dgvDSPhongTrong.AutoGenerateColumns = false;
            dgvDSPhongTrong.DataSource = BUS_Phong.TimPhongTrong(key);
            txtTim.Text = "";
        }

        private void dgvDSPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDSPhongTrong.Columns[4].Index)
            {
                frmPhieuThue frm = new frmPhieuThue();
                DataGridViewRow row = dgvDSPhongTrong.CurrentRow;
                frm.Tag = row;
                frm.ShowDialog();
                
            }
        }        

        private void btnFesh_Click(object sender, EventArgs e)
        {
            dgvDSPhongTrong.AutoGenerateColumns = false;
            dgvDSPhongTrong.DataSource = BUS_Phong.DSPhongTrong();
        }
    }
}
