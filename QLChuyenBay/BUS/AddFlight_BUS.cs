using QLChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLChuyenBay.BUS
{
    public class AddFlight_BUS
    {
        SanBay_DAO Airport_DAO_Obj = new SanBay_DAO();
        ChuyenBay_DAO Flight_DAO_Obj = new ChuyenBay_DAO();

        public DataTable Get_List_Airport()
        {
            return Airport_DAO_Obj.Get_List_Airport();
        }

        public bool Insert_Flight(string id_from, string id_to, DateTime date, TimeSpan time)
        {
            date = date.Date.AddHours(time.TotalHours);
            return Flight_DAO_Obj.AddFlight(id_from, id_to, date);
        }

        public DataTable LoadAllFlight()
        {
            return Flight_DAO_Obj.LoadAllFlight();
        }

        public bool UpdateFlight( DataTable dt)
        {
            return Airport_DAO_Obj.Update_Airport(dt);
        }
    }
}
