using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_TinTrangLoaiPhong
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static TinhTrangLoaiPhong[] dsTinhTrang()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.splp_TrangThai().ToArray<TinhTrangLoaiPhong>();
            }
        }
    }
}
