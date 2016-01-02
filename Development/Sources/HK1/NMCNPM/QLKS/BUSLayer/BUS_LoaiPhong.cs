using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_LoaiPhong
    {
        public static splp_dsLoaiPhong_Result[] LoaiPhong()
        {
            return DAO_LoaiPhong.LoaiPhong();
        }
        //lay danh sach phong
        static public LoaiPhong[] DSLoai()
        {

            return DAO_LoaiPhong.DSLoai();
                       
        }
        //chi tiet loai phong
        static public LoaiPhong XemChiTietLoaiPhong(int ma)
        {
            return DAO_LoaiPhong.XemChiTietLoaiPhong(ma);
        }
        static public void ThemLoaiPhong(string ten, float dongia, int trangthai)
        {

            DAO_LoaiPhong.ThemLoaiPhong(ten, dongia, trangthai);

        }
        //cập nhât loại phòng

        static public void CapNhatLoaiPhong(int ma, string ten, float dongia, int trangthai)
        {

            DAO_LoaiPhong.CapNhatLoaiPhong(ma, ten, dongia, trangthai);

        }
        //xóa loại phòng
        static public void XoaLoaiPhong(int ma)
        {
            DAO_LoaiPhong.XoaLoaiPhong(ma);
        }

    }
}
