using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_TinhTrangLoaiPhong
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static TinhTrangLoaiPhong[] dsTinhTrang()
        {
            return DAO_TinTrangLoaiPhong.dsTinhTrang();
        }
    }
}
