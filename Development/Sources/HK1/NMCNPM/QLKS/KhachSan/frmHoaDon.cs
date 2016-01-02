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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public int mahd;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btn_inhoadon.Visible = false;
            
            label12.Text = Session.manv;
            DataGridViewRow row = (DataGridViewRow)this.Tag;
            lbl_maphieu.Text = row.Cells[0].Value.ToString();
            lblCMND.Text = row.Cells[1].Value.ToString();
            lbl_tenkh.Text = row.Cells[2].Value.ToString();
            lblMaPhong.Text = row.Cells[3].Value.ToString();
            lbl_ngaythue.Text = row.Cells[4].Value.ToString();
            lblSoNguoi.Text = row.Cells[5].Value.ToString();
            lbl_dongia.Text = row.Cells[6].Value.ToString();
            dtpNgayLapHD.Value = DateTime.Now;
            lblCMND.Visible = false;
            lblMaPhong.Visible = false;

            cbbHeSo.DataSource = BUS_QuyDinh.dsHeSo();
            cbbHeSo.DisplayMember = "TenQD";
            cbbHeSo.ValueMember = "HeSo";

            cbbPhuThu.DataSource = BUS_QuyDinh.phuThu();
            cbbPhuThu.DisplayMember = "HeSo";
            cbbPhuThu.ValueMember = "HeSo";

            label7.Visible = false;
            cbbPhuThu.Visible = false;
            
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            int songay = int.Parse(txtSoNgay.Text.ToString());
            int songuoi = int.Parse(lblSoNguoi.Text.ToString());
            float heso = float.Parse(cbbHeSo.SelectedValue.ToString());
            float dongia = float.Parse(lbl_dongia.Text.ToString());

            if (songuoi == 3)
            {
                label7.Visible = true;
                cbbPhuThu.Visible = true;
                float phuthu = float.Parse(cbbPhuThu.SelectedValue.ToString());
                float thanhtien = songay * songuoi * heso * dongia * phuthu;
                lblTongTien.Text = thanhtien.ToString();
            }
            else
            {
                float thanhtien = songay * songuoi * heso * dongia;
                lblTongTien.Text = thanhtien.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label12.Text = Session.manv;   
                string manv = label12.Text;
                string makh = lblCMND.Text;
                int mapt = int.Parse(lbl_maphieu.Text.ToString());
                int maphong = int.Parse(lblMaPhong.Text.ToString());
                DateTime ngay = dtpNgayLapHD.Value;
                float dongia = float.Parse(lbl_dongia.Text.ToString());
                int songay = int.Parse(txtSoNgay.Text.ToString());
                float trigia = float.Parse(lblTongTien.Text.ToString());
                int songuoi = int.Parse(lblSoNguoi.Text.ToString());

                    BUS_HoaDon.themHoaDon(manv, makh, mapt, ngay, dongia, songay, trigia);
                    BUS_PhieuThue.capnhatPT(mapt);
                    BUS_Phong.capnhatTTPhong(maphong);

                
                MessageBox.Show("Thanh Toan Thanh Cong!!!");
                button1.Visible = false;
                btn_inhoadon.Visible = true;
               
                
            }
            catch
            {
                MessageBox.Show("Thanh Toan khoong thanh cong!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
