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
    public partial class AddFlight : Form
    {
        AddFlight_BUS BUS_Obj = new AddFlight_BUS();
        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_Obj.Get_List_Airport();
            DataTable dt1 = BUS_Obj.Get_List_Airport();
            CB_To.DataSource = dt;
            CB_To.DisplayMember = dt.Columns["TenSB"].ToString();
            CB_To.ValueMember = dt.Columns["MaSB"].ToString();
            CB_From.DataSource = dt1;
            CB_From.DisplayMember = dt1.Columns["TenSB"].ToString();
            CB_From.ValueMember = dt1.Columns["MaSB"].ToString();
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            TimeSpan time = new TimeSpan();
            if (TimeSpan.TryParse(TXT_Time.Text, out time))
            {
                string from = CB_From.SelectedValue.ToString();
                string to = CB_To.SelectedValue.ToString();
                DateTime date = DTP_Date.Value;
                if (from != to)
                {
                    if (!BUS_Obj.Insert_Flight(from, to, date, time))
                    {
                        MessageBox.Show("Lost connection", "Error");
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("From airport!", "Error");
                    CB_To.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Not time value!", "Error");
                TXT_Time.BackColor = Color.Red;
            }
        }
    }
}
