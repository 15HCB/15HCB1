using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
namespace DAOLayer
{
    public class DAO_LoaiNhanVien
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();

        public static LoaiNhanVien[] dsLoaiNV()
        {
            return db.spltk_dsLoaiNV().ToArray<LoaiNhanVien>();
        }

    }
}
