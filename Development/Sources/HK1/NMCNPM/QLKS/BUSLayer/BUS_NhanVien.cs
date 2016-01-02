using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_NhanVien
    {
        public static sptk_laytaikhoan_Result2 LayTaiKhoan(string manv, string pass)
        {
            return DAO_NhanVien.LayTaiKhoan(manv, pass);
        }
        public static NhanVien ThonTinNV(string manv)
        {
            return DAO_NhanVien.ThongTinNV(manv);
        }
        public static void CapNhatTTNV(string manv, string pass, string cmnd, string sdt, string diachi)
        {
            DAO_NhanVien.CapNhatTTNV(manv, pass, cmnd, sdt, diachi);
        }
        //lấy danh sách ài khoản
        public static NhanVien[] DSNhanVien()
        {

            return DAO_NhanVien.DSNhanVien();
            
        }

        //thêm tài khoản
        public static void ThemNV(string ma, String pass, String hoten, String cmnd, String sdt, String diachi, int tinhtrang, int loainv)
        {
            DAO_NhanVien.ThemNV(ma, pass, hoten, cmnd, sdt, diachi, tinhtrang, loainv);
        }

        public static void CapNhatNV(string manv, int tinhtrang, int loainv)
        {
            DAO_NhanVien.CapNhatNV(manv, tinhtrang, loainv);
        }

        public static NhanVien[] TimNhanVien(string hoten)
        {
            return DAO_NhanVien.TimNhanVien(hoten);
        }
        
        public static void KhoaNV(string ma)
        {
            DAO_NhanVien.KhoaNV(ma);
        }
    }
}
