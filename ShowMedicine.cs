﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class ShowMedicine : Form
    {
        public ShowMedicine()
        {
            InitializeComponent();
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);

            MenuMedicine menuMedicine = new MenuMedicine();

            menuMedicine.Dock = DockStyle.Top;
            TopPanel.Controls.Add(menuMedicine);
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}