using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOLayer;
using DAOLayer;

namespace BUSLayer
{
    public class BUS_TinhTrangNV
    {
        public static TinhTrangNV[] dsTinhTrang()
        {
            return DAO_TinhTrangNV.dsTinhTrang();
        }
    }
}
