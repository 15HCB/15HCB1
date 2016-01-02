using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_PhieuThue
    {
        public static QuanLyKhachSanEntities db = null;//new QuanLyKhachSanEntities();
        public static sppt_themphieuthue_Result1 ThemPT(DateTime ngaythue, int maphong, string manv, int songuoi)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return DAO_PhieuThue.ThemPT(ngaythue, maphong, manv, songuoi);
            }
        }
        public static void themCTPhieu(string cmnd, int maphieu)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                DAO_PhieuThue.themCTPhieu(cmnd, maphieu);
            }
        }
        //danh sách phiếu thuê

        static public sppt_DSphieuthue_Result1[] DSphieu()
        {
            using (db = new QuanLyKhachSanEntities())
            {

                return DAO_PhieuThue.DSphieu();
            }
        }

        // tìm theo mã phòng
        static public sppt_timmaphong_Result1[] DSTimMaPhong(int ma)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                return DAO_PhieuThue.DSTimMaPhong(ma);
            }
        }

        // tìm theo ngày thuê
        static public sppt_timngay_Result1[] DSTimNgayThue(DateTime ngaythue)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                return DAO_PhieuThue.DSTimNgayThue(ngaythue);
            }
        }

        // tìm theo mã khách hàng
        static public sppt_timkh_Result1[] DSTimTenKH(string tenkh)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                return DAO_PhieuThue.DSTimTenKH(tenkh);
            }
        }
        public static void capnhatPT(int mapt)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                DAO_PhieuThue.capnhatPT(mapt);
            }
        }
    }
}
