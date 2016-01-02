using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
namespace DAOLayer
{
    public class DAO_TinhTrangNV
    {
        static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static TinhTrangNV[] dsTinhTrang()
        {
            return db.spnv_dsTinhTrangNV().ToArray<TinhTrangNV>();
        }
    }
}
