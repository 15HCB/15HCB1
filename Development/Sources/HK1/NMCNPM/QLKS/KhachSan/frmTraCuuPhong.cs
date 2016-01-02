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
    public partial class frmTraCuuPhong : Form
    {
       
        public frmTraCuuPhong()
        {
            InitializeComponent();
        }

        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();

        private void frmTraCuuPhong_Load(object sender, EventArgs e)
        {
            dgv_thongtin.AutoGenerateColumns = false;
            // danh sách loai phòng
            cbb_loaiphong.DataSource = BUS_LoaiPhong.DSLoai();
            cbb_loaiphong.DisplayMember = "TenLoaiPhong";
            cbb_loaiphong.ValueMember = "MaLoaiPhong";

            /// tình trang phòng
            cbb_tinhtrang.DataSource = BUS_TinhTrangPhong.dsTinhTrangPhong();
            cbb_tinhtrang.DisplayMember = "TinhTrang";
            cbb_tinhtrang.ValueMember = "MaTT";
            
            // giá tiền
            cbb_giatien.DataSource = BUS_LoaiPhong.DSLoai();
            cbb_giatien.DisplayMember = "DonGia";
            cbb_giatien.ValueMember = "DonGia";
            
            if (Session.loainv == 2)
            {
                dgv_thongtin.Columns[6].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int loai = int.Parse(cbb_loaiphong.SelectedValue.ToString());
                int tinhtrang = int.Parse(cbb_tinhtrang.SelectedValue.ToString());
                float gia = float.Parse(cbb_giatien.SelectedValue.ToString());
                if (rdb_loai.Checked == true)
                {
                    dgv_thongtin.DataSource = BUS_Phong.TimLoaiPhong(loai);
                }
                else if (rdb_tinhtrang.Checked == true)
                {
                    dgv_thongtin.DataSource = BUS_Phong.TimTTPhong(tinhtrang);
                }

                else if (rdb_gia.Checked == true)
                {
                    dgv_thongtin.DataSource = BUS_Phong.TimGiaPhong(gia);
                }
            }
            catch{
                MessageBox.Show("Moi ban chon 1 tieu chi tra cuu");
            }
        }

        private void dgv_thongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_thongtin.Columns[6].Index)
            {
                frmPhieuThue frm = new frmPhieuThue();
                DataGridViewRow row = dgv_thongtin.CurrentRow;
                frm.Tag = row;
                frm.ShowDialog();
            }
        }

        

      
       
        

    }
}
