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
    public partial class BookFlight : Form
    {
        AddFlight_BUS BUS_Obj = new AddFlight_BUS();
        DataTable DataFlight = new DataTable();
        public BookFlight()
        {
            InitializeComponent();
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            ResultDGV.AllowUserToAddRows = false;
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            DataTable dt = BUS_Obj.Get_List_Airport();
            DataTable dt1 = BUS_Obj.Get_List_Airport();
            ToCB.DataSource = dt;
            ToCB.DisplayMember = dt.Columns["TenSB"].ToString();
            ToCB.ValueMember = dt.Columns["MaSB"].ToString();
            FromCB.DataSource = dt1;
            FromCB.DisplayMember = dt1.Columns["TenSB"].ToString();
            FromCB.ValueMember = dt1.Columns["MaSB"].ToString();
        }

        private void LoadGridview()
        {
            DataFlight = this.BUS_Obj.SearchFlight(ToCB.SelectedValue.ToString(), FromCB.SelectedValue.ToString(), DateDTP.Value);
            BindingSource bs = new BindingSource();
            bs.DataSource = DataFlight;
            ResultDGV.DataSource = bs;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            LoadGridview();
        }
    }
}
