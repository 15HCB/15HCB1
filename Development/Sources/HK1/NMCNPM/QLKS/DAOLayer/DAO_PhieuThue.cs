using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_PhieuThue
    {
        public static QuanLyKhachSanEntities db = null;// new QuanLyKhachSanEntities();
        public static sppt_themphieuthue_Result1 ThemPT(DateTime ngaythue, int maphong, string manv, int songuoi)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sppt_themphieuthue(ngaythue, maphong, manv, songuoi).ToList<sppt_themphieuthue_Result1>()[0];
            }
        }
        public static void themCTPhieu(string cmnd, int maphieu)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spct_themCTPhieu(cmnd, maphieu);
            }
        }

        //danh sách phiếu thuê
        static public sppt_DSphieuthue_Result1[] DSphieu()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sppt_DSphieuthue().ToArray<sppt_DSphieuthue_Result1>();
            }
        }

        // tìm theo mã phòng


        static public sppt_timmaphong_Result1[] DSTimMaPhong(int ma)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sppt_timmaphong(ma).ToArray<sppt_timmaphong_Result1>();
            }
        }

        // tìm theo ngày thuê
        static public sppt_timngay_Result1[] DSTimNgayThue(DateTime ngaythue)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sppt_timngay(ngaythue).ToArray<sppt_timngay_Result1>();
            }
        }

        // tìm theo mã khách hàng
        static public sppt_timkh_Result1[] DSTimTenKH(string tenkh)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sppt_timkh(tenkh).ToArray<sppt_timkh_Result1>();
            }
        }

        public static void capnhatPT(int mapt)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sphd_capnhatPT(mapt);
            }
        }
    }
}
