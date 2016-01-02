using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_TinhTrangPhong
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static TinhTrangPhong[] dsTinhTrangPhong()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.spp_dsTinhTrang().ToArray<TinhTrangPhong>();
            }
        }
    }
}
