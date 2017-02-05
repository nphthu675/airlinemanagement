using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLChuyenBay.DAO
{
    public class ChuyenBay_DAO
    {
        string DBConnectionString = @"Data Source=DESKTOP-B9SBFQG\SQLExpress2008;Initial Catalog=QLCHUYENBAY;Integrated Security=True";

        public bool AddFlight(string id_from, string id_to, DateTime date)
        {
            SqlConnection Conn = new SqlConnection(DBConnectionString);
            Conn.Open();
            string insert_string = "INSERT INTO CHUYENBAY(SBDen, SBDi, KhoiHanh) VALUES('" + id_to + "','" + id_from + "','" + date.ToString() + "')";
            SqlCommand insert_cmd = new SqlCommand(insert_string, Conn);
            insert_cmd.ExecuteNonQuery();
            return true;
        }
    }
}
