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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                sptk_laytaikhoan_Result2 nv = BUS_NhanVien.LayTaiKhoan(txtUser.Text, txtPass.Text);
                if (nv.manv != null)
                {
                    if (nv.TinhTrang == 2 || nv.TinhTrang == 3)
                        MessageBox.Show("Tài khoản nhân viên đang bị khóa!!!");

                    else
                    {
                        Session.manv = nv.manv;
                        Session.pass = nv.pass;
                        Session.loainv = nv.LoaiNV.Value;
                        Session.dadangnhap = true;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!");
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!");
            }
        }
      
        
    }
}
