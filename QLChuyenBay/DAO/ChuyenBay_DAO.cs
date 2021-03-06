﻿using System;
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
            if (CheckDuplicate(id_from, id_to, date) == true)
            {
                return false;
            }
            string insert_string = "INSERT INTO CHUYENBAY(SBDen, SBDi, KhoiHanh) VALUES('" + id_to + "','" + id_from + "','" + date.ToString() + "')";
            SqlCommand insert_cmd = new SqlCommand(insert_string, Conn);
            insert_cmd.ExecuteNonQuery();
            return true;
        }

        public bool CheckDuplicate(string id_from, string id_to, DateTime date)
        {
            SqlConnection Conn = new SqlConnection(DBConnectionString);
            Conn.Open();
            string select_string = string.Format("SELECT IDChuyenBay FROM CHUYENBAY CB WHERE CB.SBDen = '{0}' AND CB.SBDi = '{1}' AND CB.KhoiHanh = '{2}'", id_to, id_from, date);
            SqlDataAdapter selectadapter = new SqlDataAdapter(select_string, Conn);
            DataTable dt = new DataTable();
            selectadapter.Fill(dt);
            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public DataTable LoadAllFlight()
        {
            SqlConnection Conn = new SqlConnection(DBConnectionString);
            Conn.Open();
            string select_string = "SELECT IDChuyenBay,SBDen, SBDi, KhoiHanh FROM CHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(select_string, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchFlight(string from, string to, string date)
        {
            SqlConnection Conn = new SqlConnection(DBConnectionString);
            Conn.Open();
            string select_string = string.Format("SELECT IDChuyenBay,SBDen, SBDi, KhoiHanh FROM CHUYENBAY WHERE SBDen = '{0}' AND SBDi = {1} AND KhoiHanh = '{2}", to, from, date);
            SqlDataAdapter da = new SqlDataAdapter(select_string, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Update_Flight(DataTable dt)
        {
            SqlConnection Conn = new SqlConnection(DBConnectionString);
            Conn.Open();
            SqlCommand select_cmd = new SqlCommand("SELECT IDChuyenBay, SBDen, SBDi, KhoiHanh FROM CHUYENBAY", Conn);
            SqlDataAdapter da = new SqlDataAdapter(select_cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int num_row_update = 0;
            da.UpdateCommand = cb.GetUpdateCommand();
            num_row_update += da.Update(dt.Select(null, null, DataViewRowState.Deleted));
            num_row_update += da.Update(dt.Select(null, null, DataViewRowState.ModifiedCurrent));
            num_row_update += da.Update(dt.Select(null, null, DataViewRowState.Added));
            if (num_row_update > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
