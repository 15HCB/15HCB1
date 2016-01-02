using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_Phong
    {
        static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        //lấy danh sách phòng
        static public Phong[] DSPhong()
        { 
            using(db= new QuanLyKhachSanEntities())
            
            {
                return db.spp_dspphong().ToArray<Phong>();
            }
        }
        //xem chi tiết phòng
        static public Phong XemChiTietPhong(int ma)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                Phong[] arr = db.spp_1phong(ma).ToArray<Phong>();
                if (arr.Length > 0)
                {
                    return arr[0];
                }
                return null;
            }
        }
        //lấy danh sách phòng trống. tình trạng =1
        static public spp_dsphongtrong_Result[] DSPhongTrong()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_dsphongtrong().ToArray<spp_dsphongtrong_Result>();
            }
        }

        public static spp_timPhongTrong_Result[] TimPhongTrong(string key)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_timPhongTrong(key).ToArray<spp_timPhongTrong_Result>();
            }
        }
        // them thông tin phòng
        static public void ThemPhong(string ten, int loai, int songuoi, string ghichu)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spp_themphong(ten, loai,songuoi,ghichu);
            }
        }

        //Sua Phong
        public static void CapNhatPhong(int maphong, string tenphong, int loaiphong, int tinhtrang, int songuoi, string ghichu)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spp_capnhatphong(maphong, tenphong, loaiphong, tinhtrang, songuoi, ghichu);
            }
        }

        public static void CapNhatTTP(int maphong)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spp_CapNhatTTP(maphong);
            }
        }

        // tìm theo tinh trang phong
        static public Phong[] TimTTPhong(int tinhtrang)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_tracuutinhtrang(tinhtrang).ToArray<Phong>();
            }
        }

        //tìm theo loai phòng
        static public Phong[] TimLoaiPhong(int loai)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_tracuuloai(loai).ToArray<Phong>();
            }
        }


        //tìm theo giá phòng
        static public Phong[] TimGiaPhong(float gia)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_tracuugia(gia).ToArray<Phong>();
            }
        }

        public static void capnhatTTPhong(int maphong)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.sphd_capnhatPhong(maphong);
            }
        }      
    }
}
