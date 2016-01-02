using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;

namespace DAOLayer
{
    public class DAO_LoaiKH
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static splkh_dsLoaiKH_Result[] dsLoaiKH()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return db.splkh_dsLoaiKH().ToArray<splkh_dsLoaiKH_Result>();
            }
        }
    }
}
