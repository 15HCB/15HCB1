using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAOLayer;
using DTOLayer;
using BUSLayer;

namespace KhachSan
{
    public partial class frmDSPhong : Form
    {
        public frmDSPhong()
        {
            InitializeComponent();
        }

        private void frmDSPhong_Load(object sender, EventArgs e)
        {
            cbbLoai.DataSource = BUS_LoaiPhong.LoaiPhong();
            cbbLoai.DisplayMember = "TenLoaiPhong";
            cbbLoai.ValueMember = "MaLoaiPhong";

            cbbTinhTrang.DataSource = BUS_TinhTrangPhong.dsTinhTrangPhong();
            cbbTinhTrang.DisplayMember = "TinhTrang";
            cbbTinhTrang.ValueMember = "MaTT";

            dgvDSPhong.AutoGenerateColumns = false;
            dgvDSPhong.DataSource = BUS_Phong.DSPhong();

        }

        private void dgvDSPhong_SelectionChanged(object sender, EventArgs e)
        {
            lblMaPhong.Text = dgvDSPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txt_ten.Text = dgvDSPhong.CurrentRow.Cells["TenPhong"].Value.ToString();
            cbbLoai.SelectedValue = dgvDSPhong.CurrentRow.Cells["LoaiPhong"].Value;
            cbbTinhTrang.SelectedValue = dgvDSPhong.CurrentRow.Cells["TinhTrang"].Value;
            txt_songuoi.Text = dgvDSPhong.CurrentRow.Cells["SoNguoi"].Value.ToString();
            txt_ghichu.Text = dgvDSPhong.CurrentRow.Cells["GhiChu"].Value.ToString();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenphong = txt_ten.Text;
                int loaiphong = int.Parse(cbbLoai.SelectedValue.ToString());
                int songuoi = int.Parse(txt_songuoi.Text.ToString());
                string ghichu = txt_ghichu.Text;

                BUS_Phong.ThemPhong(tenphong, loaiphong, songuoi, ghichu);
                MessageBox.Show("Them thanh cong!!!");
                dgvDSPhong.DataSource = BUS_Phong.DSPhong();

                lblMaPhong.Text = "";
                txt_ten.Text = "";
                txt_songuoi.Text = "";
                txt_ghichu.Text = "";

            }
            catch
            {
                MessageBox.Show("Them that bai!!!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(dgvDSPhong.CurrentRow.Cells[0].Value.ToString());
            string ten = txt_ten.Text;
            int loai = int.Parse(cbbLoai.SelectedValue.ToString());
            int tinhtrang = int.Parse(cbbTinhTrang.SelectedValue.ToString());
            int songuoi = int.Parse(txt_songuoi.Text.ToString());
            string ghichu = txt_ghichu.Text;

            BUS_Phong.CapNhatPhong(ma, ten, loai, tinhtrang, songuoi, ghichu);
            MessageBox.Show("Cap nhat thanh cong!!!");

            dgvDSPhong.DataSource = BUS_Phong.DSPhong();

            lblMaPhong.Text = "";
            txt_ten.Text = "";
            txt_songuoi.Text = "";
            txt_ghichu.Text = "";
            
        }

       

    }
}
