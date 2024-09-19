using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using DTO;

namespace BussinessLayer
{
    public class GiaSucBUS
    {
        GiaSucAccess access = new GiaSucAccess();

        public DataTable GetData()
        {
            return access.GetData();
        }

        public DataTable GetData(String str)
        {
            return access.GetDataByLoaiGiaSuc(str);
        }

        public int Insert(GiaSuc giaSuc)
        {
            return access.Insert(giaSuc);
        }

        public int Update(GiaSuc giaSuc)
        {
            return access.Update(giaSuc);
        }

        public int Delete()
        {
            return access.Delete();
        }
    }
}
