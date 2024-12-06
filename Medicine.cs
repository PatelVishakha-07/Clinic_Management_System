using System;
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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);

            //MenuMedicine menuMedicine = new MenuMedicine();

            //menuMedicine.Dock = DockStyle.Top;
            //TopPanel.Controls.Add(menuMedicine);
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ShowMedicine showMedicine = new ShowMedicine();
            MainPanel.Controls.Add(showMedicine);

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void showMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ShowMedicine showMedicine = new ShowMedicine();
            MainPanel.Controls.Add(showMedicine);
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            AddMedicine addMedicine = new AddMedicine();
            MainPanel.Controls.Add(addMedicine);
        }
    }
}
