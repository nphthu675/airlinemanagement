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
    public partial class Flight : Form
    {
        AddFlight_BUS BUS_Obj = new AddFlight_BUS();
        DataTable DataFlight = new DataTable();
        int CurrentFlightID = 0;

        public Flight()
        {
            InitializeComponent();
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
                    }
                    else
                    {
                        LoadGridview();
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

        private void Flight_Load(object sender, EventArgs e)
        {
            DGVFlight.AllowUserToAddRows = false;
            LoadCombobox();
            LoadGridview();
        }

        private void LoadCombobox()
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

        private void LoadGridview()
        {
            DataFlight = BUS_Obj.LoadAllFlight();
            BindingSource bs = new BindingSource();
            bs.DataSource = DataFlight;
            DGVFlight.DataSource = bs;
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            DataFlight.Rows[CurrentFlightID]["SBDi"] = CB_From.SelectedValue;
            DataFlight.Rows[CurrentFlightID]["SBDen"] = CB_To.SelectedValue;
            DataFlight.Rows[CurrentFlightID]["KhoiHanh"] = DTP_Date.Value.AddHours(TimeSpan.Parse(TXT_Time.Text).TotalHours);
        }

        private void DGVFlight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i = DGVFlight.SelectedCells[0].RowIndex;
                DataFlight.Rows[i].Delete();
                BUS_Obj.UpdateFlight(DataFlight);
                LoadGridview();
            }
        }

        private void DGVFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentFlightID = e.RowIndex;

            string IDFlight = DataFlight.Rows[CurrentFlightID]["IDChuyenBay"].ToString();
            CB_From.SelectedValue = DataFlight.Rows[CurrentFlightID]["SBDi"].ToString();
            CB_To.SelectedValue = DataFlight.Rows[CurrentFlightID]["SBDen"].ToString();

            DateTime TakeOffTime = DateTime.Parse(DataFlight.Rows[CurrentFlightID]["KhoiHanh"].ToString());
            DTP_Date.Value = TakeOffTime.Date;
            TXT_Time.Text = TakeOffTime.TimeOfDay.ToString();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            BUS_Obj.UpdateFlight(DataFlight);
        }
    }
}
