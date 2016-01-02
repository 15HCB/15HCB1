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
    public partial class frmThonTinCaNhan : Form
    {
        public frmThonTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThonTinCaNhan_Load(object sender, EventArgs e)
        {
           // sptk_laytaikhoan_Result2 tk = BUS_NhanVien.LayTaiKhoan(Session.manv, Session.pass);

                NhanVien nv = BUS_NhanVien.ThonTinNV(Session.manv);
                lblMaNV.Text = nv.MaNV;
                lblHoTen.Text = nv.HoTen;
                txtCMND.Text = nv.CMND;
                txtSDT.Text = nv.SDT;
                txtDiaChi.Text = nv.DiaChi;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = BUS_NhanVien.ThonTinNV(Session.manv);
            lblMaNV.Text = nv.MaNV;
            lblHoTen.Text = nv.HoTen;
            txtCMND.Text = nv.CMND;
            txtSDT.Text = nv.SDT;
            txtDiaChi.Text = nv.DiaChi;

            if (Session.pass != txtPassOld.Text)
                MessageBox.Show("Mật khẩu cũ không đúng");
            else
            {
                    try
                    {
                        BUS_NhanVien.CapNhatTTNV(lblMaNV.Text, txtPassNew.Text, txtCMND.Text, txtSDT.Text, txtDiaChi.Text);
                        MessageBox.Show("Cap nhat thanh cong");
                    }
                    catch
                    {
                        MessageBox.Show("Cap nhat khong thanh cong");
                    }
                    this.Close();
                }
            
        }
    }
}
