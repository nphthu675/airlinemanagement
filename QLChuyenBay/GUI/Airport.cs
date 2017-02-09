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
    public partial class Airport : Form
    {
        AddAirport_BUS BUS_Obj = new AddAirport_BUS();
        DataTable Data = new DataTable();
        public Airport()
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

        private void DGV_Airport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void DGV_Airport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i = DGV_Airport.SelectedCells[0].RowIndex;
                Data.Rows[i].Delete();
                BUS_Obj.Update_Airport(Data);
                LoadGridview();
            }
        }

        private void BT_Add_Click_1(object sender, EventArgs e)
        {
            string id = TXT_ID.Text;
            string name = TXT_Name.Text;
            BUS_Obj.Add_New_Airport(id, name);
            LoadGridview();
        }
    }
}
