using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    
    public class BUS_LoaiKH
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static splkh_dsLoaiKH_Result[] dsLoaiKH()
        {
            return DAO_LoaiKH.dsLoaiKH();
        }
    }
}
