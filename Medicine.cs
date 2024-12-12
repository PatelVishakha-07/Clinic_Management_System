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
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            ShowControl(new ShowMedicine());

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
            if (item != null) {
                if(item.Text == "Expired Medicine")
                {
                    ShowControl(new Exp_Out_Medicines("expire"));
                }
                else if(item.Text == "Out Of Stock Medicine")
                {
                    ShowControl(new Exp_Out_Medicines("out of stock"));
                }
            }
        }

        private void showMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new ShowMedicine());
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new AddMedicine());
        }

        public void ShowControl(UserControl control)
        {
            MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
