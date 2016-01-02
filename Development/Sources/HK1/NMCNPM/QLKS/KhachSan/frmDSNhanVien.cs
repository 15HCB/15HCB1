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
    public partial class frmDSNhanVien : Form
    {
        
        public frmDSNhanVien()
        {
            InitializeComponent();
        

        }

        private void frmDSNhanVien_Load(object sender, EventArgs e)
        {
            cbbLoaiNV.DataSource = BUS_LoaiNhanVien.dsLoaiNV();
            cbbLoaiNV.DisplayMember = "TenLoai";
            cbbLoaiNV.ValueMember = "MaLoai";
            cbbTinhTrang.DataSource = BUS_TinhTrangNV.dsTinhTrang();
            cbbTinhTrang.DisplayMember = "TinhTrang";
            cbbTinhTrang.ValueMember = "MaTT";       
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDSNhanVien.AutoGenerateColumns = false;
            dgvDSNhanVien.DataSource = BUS_NhanVien.DSNhanVien();
        }
        private void dgvDSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            lblMaNV.Text = dgvDSNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            lblHoTen.Text = dgvDSNhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            lblCMNV.Text = dgvDSNhanVien.CurrentRow.Cells["CMND"].Value.ToString();
            lblSDT.Text = dgvDSNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            lblDiaChi.Text = dgvDSNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbbTinhTrang.SelectedValue = dgvDSNhanVien.CurrentRow.Cells["TinhTrang"].Value;
            cbbLoaiNV.SelectedValue = dgvDSNhanVien.CurrentRow.Cells["LoaiNV"].Value;            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = lblMaNV.Text;
                int loainv = int.Parse(cbbLoaiNV.SelectedValue.ToString());
                int tinhtrang = int.Parse(cbbTinhTrang.SelectedValue.ToString());

                BUS_NhanVien.CapNhatNV(manv, tinhtrang, loainv);
                MessageBox.Show("Cập nhật thành công!!!");

                dgvDSNhanVien.DataSource = BUS_NhanVien.DSNhanVien();

            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            dgvDSNhanVien.AutoGenerateColumns = false;
            dgvDSNhanVien.DataSource = BUS_NhanVien.TimNhanVien(key);
            txtKey.Text = "";
        }

      }
}
