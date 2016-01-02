using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
using DAOLayer;

namespace BUSLayer
{
    public class BUS_HoaDon
    {
        public static QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public static void themHoaDon(string manv, string makh, int mapt, DateTime ngaylap, float dongia, int songay, float trigia)
        {
            DAO_HoaDon.themHoaDon(manv, makh, mapt, ngaylap, dongia, songay, trigia);
        }
    }
}
