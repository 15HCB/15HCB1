using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_HoaDon
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static void themHoaDon(string manv, string makh, int mapt, DateTime ngaylap, float dongia, int songay, float trigia)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sphd_ThemHD(manv, makh, mapt, ngaylap, dongia, songay, trigia);
            }
        }
    }
}
