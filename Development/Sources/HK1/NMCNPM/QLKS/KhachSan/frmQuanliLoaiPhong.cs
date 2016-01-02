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
    public partial class frmQuanliLoaiPhong : Form
    {
        public frmQuanliLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmQuanliLoaiPhong_Load(object sender, EventArgs e)
        {
            cbb_trangthai.DataSource = BUS_TinhTrangLoaiPhong.dsTinhTrang();
            cbb_trangthai.DisplayMember = "TenTT";
            cbb_trangthai.ValueMember = "MaTT";
            dgv_dsloai.AutoGenerateColumns = false;
            dgv_dsloai.DataSource = BUS_LoaiPhong.DSLoai();

        }


        private void dgv_dsloai_SelectionChanged(object sender, EventArgs e)
        {
            lblMaLoai.Text = dgv_dsloai.CurrentRow.Cells["MaLoaiPhong"].Value.ToString();
            txt_tenloai.Text = dgv_dsloai.CurrentRow.Cells["TenLoaiPhong"].Value.ToString();
            txt_dongia.Text = dgv_dsloai.CurrentRow.Cells["DonGia"].Value.ToString();
            cbb_trangthai.SelectedValue = dgv_dsloai.CurrentRow.Cells["TrangThai"].Value;
        }
 
        private void dgv_dsloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //MessageBox.Show(dgv_dsloai[0, e.RowIndex].Value.ToString());
                    string command = dgv_dsloai.Columns[e.ColumnIndex].Name;
                    if (command == "Xoa")
                    {
                        int malp = int.Parse(dgv_dsloai[0, e.RowIndex].Value.ToString());

                        BUS_LoaiPhong.XoaLoaiPhong(malp);
                        MessageBox.Show("xóa thành công");

                        dgv_dsloai.DataSource = BUS_LoaiPhong.DSLoai();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("xóa thất bại");

            }
               
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenloai = txt_tenloai.Text;
                float dongia = float.Parse(txt_dongia.Text.ToString());
                int tt = int.Parse(cbb_trangthai.SelectedValue.ToString());

                BUS_LoaiPhong.ThemLoaiPhong(tenloai, dongia, tt);

                MessageBox.Show("Thêm thành công!!!");
                txt_tenloai.Text = "";
                txt_dongia.Text = "";

                dgv_dsloai.AutoGenerateColumns = false;
                dgv_dsloai.DataSource = BUS_LoaiPhong.DSLoai();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!! ");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maloai = int.Parse(lblMaLoai.Text.ToString());
                string tenloai = txt_tenloai.Text;
                float dongia = float.Parse(txt_dongia.Text.ToString());
                int tt = int.Parse(cbb_trangthai.SelectedValue.ToString());

                BUS_LoaiPhong.CapNhatLoaiPhong(maloai, tenloai, dongia, tt);
                
                MessageBox.Show("Cập nhật thành công!!!");
                txt_tenloai.Text = "";
                txt_dongia.Text = "";

                dgv_dsloai.AutoGenerateColumns = false;
                dgv_dsloai.DataSource = BUS_LoaiPhong.DSLoai();
            }
            catch 
            {
                MessageBox.Show("Cập nhật thất bại!!!");
            }
        }
  
    }
}
