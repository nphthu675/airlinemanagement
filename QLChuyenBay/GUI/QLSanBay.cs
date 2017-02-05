using QLChuyenBay.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChuyenBay.GUI
{
    public partial class QLSanBay : Form
    {
        AddAirport_BUS BUS_Obj = new AddAirport_BUS();
        DataTable Data = new DataTable();
        public QLSanBay()
        {
            InitializeComponent();
        }
       
        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (BUS_Obj.Add_New_Airport(TXT_ID.Text, TXT_Name.Text))
            {
                MessageBox.Show("Success!", "Info");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed!", "Info");
            }
        }

        private void QLSanBay_Load(object sender, EventArgs e)
        {
            LoadGridview();
        }

        private void LoadGridview()
        {
            Data = BUS_Obj.Get_List_Airport();
            BindingSource bs = new BindingSource();
            bs.DataSource = Data;
            DGV_Airport.DataSource = bs;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            BUS_Obj.Update_Airport(Data);
        }
    }
}
