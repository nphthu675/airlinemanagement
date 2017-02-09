using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLChuyenBay.DAO
{
    public class SanBay_DAO
    {
        string chuoi_ket_noi = @"Data Source=DESKTOP-B9SBFQG\SQLExpress2008;Initial Catalog=QLCHUYENBAY;Integrated Security=True";

        public bool ThemSanBay(string ma_san_bay, string ten_san_bay)
        {
            SqlConnection Conn = new SqlConnection(chuoi_ket_noi);
            string commentline = "INSERT INTO SANBAY(MaSB, TenSB) VALUES('" + ma_san_bay + "','" + ten_san_bay + "')";
            Conn.Open();
            SqlCommand insert_cmd = new SqlCommand(commentline, Conn);

            if (insert_cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public DataTable Get_List_Airport()
        {
            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(chuoi_ket_noi);
            Conn.Open();
            string select_cmd = "SELECT MaSB, TenSB FROM SANBAY";
            SqlDataAdapter da = new SqlDataAdapter(select_cmd, Conn);
            da.Fill(dt);
            return dt;
        }

        public bool Update_Airport(DataTable dt)
        {
            SqlConnection Conn = new SqlConnection(chuoi_ket_noi);
            Conn.Open();
            SqlCommand select_cmd = new SqlCommand("SELECT MaSB, TenSB FROM SANBAY", Conn);
            SqlDataAdapter da = new SqlDataAdapter(select_cmd);
            if (da.Update(dt.Select(null, null, DataViewRowState.Deleted)) > 0 && da.Update(dt.Select(null, null, DataViewRowState.ModifiedCurrent)) > 0 && da.Update(dt.Select(null, null, DataViewRowState.Added)) > 0)
                return true;
            else
                return false;
        }
    }
}
