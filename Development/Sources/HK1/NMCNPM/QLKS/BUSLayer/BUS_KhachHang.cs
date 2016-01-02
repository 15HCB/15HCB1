using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_KhachHang
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static void ThemKH(string cmnd, string tenkh, string diachi, int loaikh)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spkh_ThemKH(cmnd, tenkh, diachi, loaikh);
            }
        }

        public static spkh_dsCMND_Result1 dsCMNd(string cmnd)
        {
            return DAO_KhachHang.dsCMND(cmnd);
        }

        public static List<KhachHang> dsKH(string cmnd)
        {
            return DAO_KhachHang.dsKH(cmnd);
        }

        public static void XoaKH(string cmnd)
        {
            DAO_KhachHang.XoaKH(cmnd);
        }
    }
}
