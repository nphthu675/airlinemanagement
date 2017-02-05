using QLChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLChuyenBay.BUS
{
    public class AddAirport_BUS
    {
        SanBay_DAO Airport_DAO_Obj = new SanBay_DAO();
        public bool Add_New_Airport(string id_airp, string name_airp)
        {
            return Airport_DAO_Obj.ThemSanBay(id_airp, name_airp);
        }

        public DataTable Get_List_Airport()
        {
            return Airport_DAO_Obj.Get_List_Airport();
        }

        public bool Update_Airport(DataTable dt)
        {
            return Airport_DAO_Obj.Update_Airport(dt);
        }
    }
}
