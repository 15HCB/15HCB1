using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
using DAOLayer;


namespace BUSLayer
{
    public class BUS_Phong
    {
        //lay danh sách phòng
        static public Phong[] DSPhong()
        {

            return DAO_Phong.DSPhong();
            
        }
        //chi tiet phong
        static public Phong XemChiTietPhong(int ma)
        {
            return DAO_Phong.XemChiTietPhong(ma);

        }
        //danh sách phong trong
        static public spp_dsphongtrong_Result[] DSPhongTrong()
        {

            return DAO_Phong.DSPhongTrong();
            
        }

        public static spp_timPhongTrong_Result[] TimPhongTrong(string key)
        {
            return DAO_Phong.TimPhongTrong(key);
        }
        //them phong
        static public void ThemPhong(string ten, int loai, int songuoi, string ghichu)
        {

            DAO_Phong.ThemPhong(ten,loai,songuoi,ghichu);
            
        }

        //Sua phong
        public static void CapNhatPhong(int maphong, string tenphong, int loaiphong, int tinhtrang, int songuoi, string ghichu)
        {
            DAO_Phong.CapNhatPhong(maphong, tenphong, loaiphong, tinhtrang, songuoi, ghichu);
        }

        public static void CapNhatTTP(int maphong)
        {
            DAO_Phong.CapNhatTTP(maphong);
        }
        // tim theo tinh trang phong
        static public Phong[] TimTTPhong(int tinhtrang)
        {

            return DAO_Phong.TimTTPhong(tinhtrang);

        }

        //tìm theo loai phòng
        static public Phong[] TimLoaiPhong(int loai)
        {

            return DAO_Phong.TimLoaiPhong(loai);

        }


        //tìm theo giá phòng
        static public Phong[] TimGiaPhong(float gia)
        {

            return DAO_Phong.TimGiaPhong(gia);

        }

        public static void capnhatTTPhong(int maphong)
        {
            DAO_Phong.capnhatTTPhong(maphong);
        }   

    }
}
