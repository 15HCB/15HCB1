using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTOLayer;
using DAOLayer;
using BUSLayer;

namespace KhachSan
{
    public partial class frmTraCuuPhieuThue : Form
    {
        public frmTraCuuPhieuThue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_maphong.Checked == true)
                {

                    int maphong = int.Parse(txt_maphong.Text);
                    dgv_timkiem.AutoGenerateColumns = false;
                    dgv_timkiem.DataSource = BUS_PhieuThue.DSTimMaPhong(maphong);
                    txt_maphong.Text = "";

                }
                else if (rdb_ngaythue.Checked == true)
                {
                    DateTime ngaythue = dtpngaythue.Value;
                    dgv_timkiem.AutoGenerateColumns = false;
                    dgv_timkiem.DataSource = BUS_PhieuThue.DSTimNgayThue(ngaythue);
                }
                else if (rdb_tenkh.Checked == true)
                {


                    string tenkh = txt_tenkh.Text;
                    dgv_timkiem.AutoGenerateColumns = false;
                    dgv_timkiem.DataSource = BUS_PhieuThue.DSTimTenKH(tenkh);
                    txt_tenkh.Text = "";
                }


                else
                {
                    MessageBox.Show("chưa chọn yêu cầu tìm kiếm");
                }
            }
            catch
            {
                MessageBox.Show("Chua nhap thong tin tra cuu!!!");
            }
           
        }

        private void frmTraCuuPhieuThue_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_timkiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_timkiem.Columns[7].Index)
            {
                frmHoaDon frm = new frmHoaDon();
                DataGridViewRow row = dgv_timkiem.CurrentRow;
                frm.Tag = row;
                frm.ShowDialog();
            }
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            dgv_timkiem.AutoGenerateColumns = false;
            dgv_timkiem.DataSource = BUS_PhieuThue.DSphieu();
        }

 
    }
}
