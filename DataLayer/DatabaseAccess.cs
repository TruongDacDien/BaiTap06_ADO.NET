using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{


    public class dbConnect : IDisposable
    {
        private readonly SqlConnection conn;

        public dbConnect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-O6AO007\SQLEXPRESS;Initial Catalog=QUANLYGIASUC;Integrated Security=True;TrustServerCertificate=True");
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
            {
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable GetData(string procName, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.Fill(dt);
                    conn.Close();
                }
            }
            return dt;
        }

        public int ExecuteSQL(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                conn.Close();
                return row;
            }
        }

        public int ExecuteSQL(string procName, SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(procName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                conn.Close();
                return row;
            }
        }

        public void Dispose()
        {
            conn?.Dispose();
        }
    }
}
