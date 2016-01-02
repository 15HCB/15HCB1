using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_QuyDinh
    {
          static public QuyDinh[] DSDanhSach()
        {

            return DAO_QuyDinh.DSQuyDinh();
         }
          static public void ThemQuyDinh(string ten, float heso, string ghichu)
          {
              DAO_QuyDinh.ThemQuyDinh(ten, heso, ghichu);
          }

          // sửa quy định
          static public void SuaQD(int ma, string ten, float heso, string ghichu)
          {

              DAO_QuyDinh.SuaQD(ma, ten, heso, ghichu);

          }
          //xoa quy định
          static public void XoaQD(int ma)
          {

              DAO_QuyDinh.XoaQD(ma);
          }

        public static spqd_dsHeSo_Result[] dsHeSo()
        {
            return DAO_QuyDinh.dsHeSo();
        }
        public static spqd_phuThu_Result1[] phuThu()
        {
            return DAO_QuyDinh.phuThu();
        }
    }
}
