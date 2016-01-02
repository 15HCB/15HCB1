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
    public partial class frmPhieuThue : Form
    {
        public frmPhieuThue()
        {
            InitializeComponent();
        }
        List<KhachHang> dskh = new List<KhachHang>();
        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = Session.manv;
            DataGridViewRow row = (DataGridViewRow)this.Tag;
            lblMa.Text = row.Cells[0].Value.ToString();
            lblLoai.Text = row.Cells[2].Value.ToString();
            lblDonGia.Text = row.Cells[3].Value.ToString();
            dtpNgayThue.Value = DateTime.Now;

            cbbLoaiKH.DataSource = BUS_LoaiKH.dsLoaiKH();
            cbbLoaiKH.DisplayMember = "TenLoaiKH";
            cbbLoaiKH.ValueMember = "LoaiKH";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_laphd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaythue = dtpNgayThue.Value;
                int maphong = int.Parse(lblMa.Text.ToString());
                string manv = lblMaNV.Text;
                int songuoi = int.Parse(txtSoNguoi.Text.ToString());
                if (songuoi > 3)
                {
                    MessageBox.Show("Số người trong một phòng không nhiều hơn 3 người!!!");
                    return;
                }

                sppt_themphieuthue_Result1 pt = BUS_PhieuThue.ThemPT(ngaythue, maphong, manv, songuoi);
                int output = int.Parse(pt.mapt.ToString());

                foreach (KhachHang i in dskh)
                {
                         BUS_PhieuThue.themCTPhieu(i.CMND, output);

                }
         
                MessageBox.Show("Lập phiếu thành công!!!");
                BUS_Phong.CapNhatTTP(maphong);

            }

            catch
            {
                MessageBox.Show("Lập phiếu thuê phòng thất bại!!!");
            }

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.CMND= txtCMND.Text;
                kh.TenKH = txtTenKH.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.LoaiKH = int.Parse(cbbLoaiKH.SelectedValue.ToString());
                List<KhachHang> ds =new List<KhachHang>();
                ds = BUS_KhachHang.dsKH(kh.CMND);
                if (ds.Count == 0)
                {
                    BUS_KhachHang.ThemKH(kh.CMND, kh.TenKH, kh.DiaChi, int.Parse(kh.LoaiKH.ToString()));
                    dskh.Add(kh);
                }
                else
                {
                    dskh.Add(ds[0]);
                }
                dgvKhachHang.AutoGenerateColumns = false;
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = dskh;
                
                txtCMND.Text = "";
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                
            }
            catch
            {
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
}
