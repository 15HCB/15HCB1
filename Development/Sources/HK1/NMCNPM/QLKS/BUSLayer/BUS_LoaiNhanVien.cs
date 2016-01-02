using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOLayer;
using DTOLayer;

namespace BUSLayer
{
    public class BUS_LoaiNhanVien
    {
        public static LoaiNhanVien[] dsLoaiNV()
        {
            return DAO_LoaiNhanVien.dsLoaiNV();
        }
    }
}
