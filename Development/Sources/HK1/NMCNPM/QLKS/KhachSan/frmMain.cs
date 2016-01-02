using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Session.dadangnhap == false)
            {
                btnDangXuat.Visible = false;
                btnTTCaNhan.Visible = false;
                btnDangNhap.Visible = true;
                btnQLNhanVien.Visible = false;
                btnQLPhong.Visible = false;
                btnQLLoaiPhong.Visible = false;
                btnQLQuyDinh.Visible = false;
                btnBaoCao.Visible = false;
                btnTraCuu.Visible = false;
            }
            else
            {
                btnDangXuat.Visible = true;
                btnTTCaNhan.Visible = true;
                btnDangNhap.Visible = false;
                if (Session.loainv == 2 )
                {
                    btnQLPhong.Visible = true;
                    btnPhongTrong.Visible = false;
                    btnQLLoaiPhong.Visible = true;
                    btnQLQuyDinh.Visible = true;
                    btnBaoCao.Visible = true;
                    btnTraCuu.Visible = true;
                    btnTCPhong.Visible = true;
                    btnTCPhieuThue.Visible = false;
                }
                if (Session.loainv == 1)
                {
                    btnQLNhanVien.Visible = true;
                    btnDSPhong.Visible = true;
                    btnTraCuu.Visible = false;
                    btnTCPhong.Visible = false;
                    btnTCPhieuThue.Visible = false;

                }
                if (Session.loainv == 3)
                {
                    btnQLPhong.Visible = true;
                    btnPhongTrong.Visible = true;
                    btnDSPhong.Visible = false;
                    btnTraCuu.Visible = true;
                    btnTCPhong.Visible = true;
                    btnTCPhieuThue.Visible = false;
                }
                if (Session.loainv == 4)
                {
                    btnTraCuu.Visible = true;
                    btnTCPhong.Visible = false;
                    btnTCPhieuThue.Visible = true;
                }
            }
            //this.reportViewer1.RefreshReport();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            if (Session.dadangnhap)
                frmMain_Load(sender, e);
        }

        private void btnTTCaNhan_Click(object sender, EventArgs e)
        {
            frmThonTinCaNhan frm = new frmThonTinCaNhan();
            frm.ShowDialog();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            frmDSNhanVien frm = new frmDSNhanVien();
            frm.ShowDialog();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

        private void btnDSPhong_Click(object sender, EventArgs e)
        {
            frmDSPhong frm = new frmDSPhong();
            frm.ShowDialog();
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            frmDSPhongTrong frm = new frmDSPhongTrong();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi hệ thống", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.dadangnhap = false;
                Session.manv = "";
                Session.loainv = -1;
                frmMain_Load(sender, e);
            }
        }

        private void btnDSQD_Click(object sender, EventArgs e)
        {
            frmDSQuyDinh frm = new frmDSQuyDinh();
            frm.ShowDialog();
        }


        private void btnTCPhieuThue_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuThue frm = new frmTraCuuPhieuThue();
            frm.ShowDialog();
        }

        private void btnTCPhong_Click(object sender, EventArgs e)
        {
            frmTraCuuPhong frm = new frmTraCuuPhong();
            frm.ShowDialog();
        }

        private void btnDSLoaiP_Click(object sender, EventArgs e)
        {
            frmQuanliLoaiPhong frm = new frmQuanliLoaiPhong();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.ShowDialog();
        }


        
    }
}
