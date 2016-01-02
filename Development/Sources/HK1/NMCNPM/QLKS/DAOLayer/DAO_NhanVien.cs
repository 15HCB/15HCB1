using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
   public class DAO_NhanVien
    {
       public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();

       public static sptk_laytaikhoan_Result2 LayTaiKhoan(string manv, string pass)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               return db.sptk_laytaikhoan(manv, pass).ToList<sptk_laytaikhoan_Result2>()[0];

           }
       }
       public static NhanVien ThongTinNV(string manv)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               return db.sptk_1taikhoan(manv).ToList<NhanVien>()[0];
           }
       }

       public static void CapNhatTTNV(string manv, string pass, string cmnd, string sdt, string diachi)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               db.sptk_capnhatTTNhanVien(manv, pass, cmnd, sdt, diachi);
           }
       }
       //lay danh sach taikhoan
        public static NhanVien[] DSNhanVien()
       {
           using (db = new QuanLyKhachSanEntities())
           {
               return db.sptk_dstaikhoan().ToArray<NhanVien>();
           }
       }

        public static NhanVien[] TimNhanVien(string hoten)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.sptk_timnhanvien(hoten).ToArray<NhanVien>();
            }
        }
              //them tai khoan
        public static void ThemNV(string ma, String pass, String hoten, String cmnd, String sdt, String diachi, int tinhtrang, int loainv)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sptk_themtaikhoan(ma, pass, hoten, cmnd, sdt, diachi, tinhtrang, loainv);
            }
        }

        public static void CapNhatNV(string manv, int tinhtrang, int loainv)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sptk_capnhattaikhoan(manv, tinhtrang, loainv);
            }
        }

       //khóa tài khoản nhân viên
        public static void KhoaNV(string ma)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sptk_khoataikhoan(ma);
            }
        }
    }
}
