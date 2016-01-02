using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_TinhTrangPhong
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static TinhTrangPhong[] dsTinhTrangPhong()
        {
            using (db = new QuanLyKhachSanEntities())
            {
                return DAO_TinhTrangPhong.dsTinhTrangPhong();
            }
        }
    }
}
