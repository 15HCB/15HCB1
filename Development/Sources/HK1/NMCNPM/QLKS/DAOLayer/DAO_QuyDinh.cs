using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_QuyDinh
    {
        //lay danh sach quy đinh
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        static public QuyDinh[] DSQuyDinh()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spqd_dsquydinh().ToArray<QuyDinh>();
            }
        }

        //thêm quy định
        static public void ThemQuyDinh(string ten, float heso, string ghichu)
        {
            using (db =new QuanLyKhachSanEntities())
            {
                db.spqd_themqd(ten, heso, ghichu);
            }
        }

        // sửa quy định
        static public void SuaQD(int ma, string ten, float heso, string ghichu)
        {
            using (db = new QuanLyKhachSanEntities())
            {

                db.spqd_suaqd(ma, ten, heso, ghichu);
            }
        }
        // xóa quy định
        static public void XoaQD(int ma)
        {
            using (db = new QuanLyKhachSanEntities())
            {
                db.spqd_xoaqd(ma);
            }
        }

        public static spqd_dsHeSo_Result[] dsHeSo()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spqd_dsHeSo().ToArray<spqd_dsHeSo_Result>();
            }
        }

        public static spqd_phuThu_Result1[] phuThu()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spqd_phuThu().ToArray<spqd_phuThu_Result1>();
            }
        }
       
    }
}
