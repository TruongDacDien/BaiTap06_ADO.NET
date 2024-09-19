using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace DataLayer
{
    public class GiaSucAccess
    {
        dbConnect db = new dbConnect();

        public DataTable GetData()
        {
            return db.GetData("giasuc_select_all", null);
        }

        public DataTable GetDataByLoaiGiaSuc(String str)
        {
            SqlParameter[] para =
            {
                new SqlParameter("LoaiGiaSuc", str)
            };
            return db.GetData("giasuc_select_byname", para);
        }

        public int Insert(GiaSuc giaSuc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("LoaiGiaSuc", giaSuc.LoaiGiaSuc),
                new SqlParameter("SoLuongBD", giaSuc.SoLuongBD),
                new SqlParameter("SoConSinhRa", giaSuc.SoConSinhRa),
                new SqlParameter("SoLuongSua", giaSuc.SoLuongSua),
                new SqlParameter("TongSoLuong", giaSuc.TongSoLuong),
                new SqlParameter("TiengKeu", giaSuc.TiengKeu)
            };
            return db.ExecuteSQL("giasuc_insert", para);
        }

        public int Update(GiaSuc giaSuc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("LoaiGiaSuc", giaSuc.LoaiGiaSuc),
                new SqlParameter("SoLuongBD", giaSuc.SoLuongBD),
                new SqlParameter("SoConSinhRa", giaSuc.SoConSinhRa),
                new SqlParameter("SoLuongSua", giaSuc.SoLuongSua),
                new SqlParameter("TongSoLuong", giaSuc.TongSoLuong),
                new SqlParameter("TiengKeu", giaSuc.TiengKeu)
            };
            return db.ExecuteSQL("giasuc_update", para);
        }

        public int Delete()
        { 
            return db.ExecuteSQL("giasuc_delete");
        }
    }
}
