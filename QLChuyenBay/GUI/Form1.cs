﻿using QLChuyenBay.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChuyenBay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_ThemSanBay_Click(object sender, EventArgs e)
        {
            Airport add_ariport_gui = new Airport();
            add_ariport_gui.ShowDialog();
        }

        private void BT_ThemChuyenBay_Click(object sender, EventArgs e)
        {
            Flight add_flight_gui = new Flight();
            add_flight_gui.ShowDialog();
        }
    }
}
