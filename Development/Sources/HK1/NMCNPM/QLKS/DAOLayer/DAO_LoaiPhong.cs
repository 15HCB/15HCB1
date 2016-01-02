using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
using System.Data.Objects;

namespace DAOLayer
{
   public class DAO_LoaiPhong
    {
       static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
       public static splp_dsLoaiPhong_Result[] LoaiPhong()
       {
           using (db = new QuanLyKhachSanEntities())
           {
               return db.splp_dsLoaiPhong().ToArray<splp_dsLoaiPhong_Result>();
           }
       }
       static public LoaiPhong[] DSLoai()
       {
           using (db = new QuanLyKhachSanEntities())
           {
               return db.splp_dslphong().ToArray<LoaiPhong>();
           }
       }
       //xem chi tiet loai phong
       static public LoaiPhong XemChiTietLoaiPhong(int ma)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               LoaiPhong[] arr = db.splp_chitietloai(ma).ToArray<LoaiPhong>();
               if (arr.Length > 0)
               {
                   return arr[0];
               }
               return null;
           }
       }
       static public void ThemLoaiPhong(string ten, float dongia, int trangthai)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               db.splp_themloaiphong(ten, dongia, trangthai);
           }

       }
       static public void CapNhatLoaiPhong(int ma, string ten, float dongia, int trangthai)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               db.splp_SuaLoaiPhong(ma, ten, dongia, trangthai);
           }

       }
       static public void XoaLoaiPhong(int ma)
       {
           using (db = new QuanLyKhachSanEntities())
           {
               db.splp_xoaloaiphong(ma);
           }
       }
    }
}
