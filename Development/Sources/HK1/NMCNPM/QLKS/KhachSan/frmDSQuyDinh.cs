using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUSLayer;
using DTOLayer;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class frmDSQuyDinh : Form
    {
        public frmDSQuyDinh()
        {
            InitializeComponent();
        }

        private void QuanLiQuyDinh_Load(object sender, EventArgs e)
        {
            dgv_dsquydinh.AutoGenerateColumns = false;
            dgv_dsquydinh.DataSource = BUS_QuyDinh.DSDanhSach();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenqdinh = txt_tenqd.Text;
                float heso = float.Parse(txt_heso.Text);
                string ghichu = txt_ghichu.Text;

                BUS_QuyDinh.ThemQuyDinh(tenqdinh, heso, ghichu);
                MessageBox.Show("Thêm quy định thành công");
                dgv_dsquydinh.DataSource = BUS_QuyDinh.DSDanhSach();
                txt_tenqd.Text = "";
                txt_heso.Text = "";
                txt_ghichu.Text = "";

            }
            catch 
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {

                int ma = int.Parse(dgv_dsquydinh.CurrentRow.Cells[0].Value.ToString());

                string ten = txt_tenqd.Text;
                float heso = float.Parse(txt_heso.Text);
                string ghichu = txt_ghichu.Text;
                BUS_QuyDinh.SuaQD(ma, ten, heso, ghichu);

                MessageBox.Show("câp nhật thành công");
                dgv_dsquydinh.DataSource = BUS_QuyDinh.DSDanhSach();

                lblMaQD.Text = "";
                txt_tenqd.Text = "";
                txt_heso.Text = "";
                txt_ghichu.Text = "";
            }
            catch
            {
                MessageBox.Show("Cap nhat that bai");
            }

        }

        

        private void dgv_dsquydinh_SelectionChanged(object sender, EventArgs e)
        {
            lblMaQD.Text = dgv_dsquydinh.CurrentRow.Cells["MaQD"].Value.ToString();
            txt_tenqd.Text = dgv_dsquydinh.CurrentRow.Cells["TenQD"].Value.ToString();
            txt_heso.Text = dgv_dsquydinh.CurrentRow.Cells["HeSo"].Value.ToString();
            txt_ghichu.Text = dgv_dsquydinh.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void dgv_dsquydinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string command = dgv_dsquydinh.Columns[e.ColumnIndex].Name;
                    if (command == "Xoa")
                    {
                        int ma = int.Parse(dgv_dsquydinh[0, e.RowIndex].Value.ToString());

                        BUS_QuyDinh.XoaQD(ma);
                        MessageBox.Show("xóa thành công");

                        dgv_dsquydinh.DataSource = BUS_QuyDinh.DSDanhSach();
                    }
                }
            }
            catch
            {
                MessageBox.Show("xóa thất bại");

            }
        }
       
    }
}
