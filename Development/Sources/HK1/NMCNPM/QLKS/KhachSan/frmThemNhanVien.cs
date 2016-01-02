using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTOLayer;
using BUSLayer;

namespace KhachSan
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            cbbLoaiNV.DataSource = BUS_LoaiNhanVien.dsLoaiNV();
            cbbLoaiNV.DisplayMember = "TenLoai";
            cbbLoaiNV.ValueMember = "MaLoai";
            cbbTinhTrang.DataSource = BUS_TinhTrangNV.dsTinhTrang();
            cbbTinhTrang.DisplayMember = "TinhTrang";
            cbbTinhTrang.ValueMember = "MaTT";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNV.Text;
                string pass = txtPass.Text;
                string hoten = txtHoTen.Text;
                string cmnd = txtCMND.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                int loainv = int.Parse(cbbLoaiNV.SelectedValue.ToString());
                int tinhtrang = int.Parse(cbbTinhTrang.SelectedValue.ToString());
                
                BUS_NhanVien.ThemNV(ma, pass, hoten, cmnd, sdt, diachi, tinhtrang, loainv);

                MessageBox.Show("Thêm thành công!!!");

                txtMaNV.Text = "";
                txtPass.Text = "";
                txtHoTen.Text = "";
                txtCMND.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                cbbTinhTrang.SelectedValue = "Choose...";
                cbbLoaiNV.SelectedValue = "Choose...";
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại!!!");
              
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }



    }
}
