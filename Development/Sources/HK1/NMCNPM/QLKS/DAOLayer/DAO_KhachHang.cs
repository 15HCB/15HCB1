using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_KhachHang
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static void ThemKH(string cmnd, string tenkh, string diachi, int loaikh)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spkh_ThemKH(cmnd, tenkh, diachi, loaikh);
            }
        }

        public static spkh_dsCMND_Result1 dsCMND(string cmnd)// v
        {
            using (db = new QuanLyKhachSanEntities()) //
            {
                var query = db.spkh_dsCMND(cmnd);
                if(query.Count() > 0)
                {
                    return query.First<spkh_dsCMND_Result1>();
                }
                return null;
            }
        }

        public static List< KhachHang > dsKH(string cmnd)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spkh_ChiTietKH(cmnd).ToList();
            }
        }

        public static void XoaKH(string cmnd)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spkh_XoaKH(cmnd);
            }
        }
    }
}
