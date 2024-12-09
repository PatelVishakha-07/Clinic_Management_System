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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            PanelLeft.Controls.Add(dashboard);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            ShowContent(new ShowPatients());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(new ShowPatients());
        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowContent(new AddPatients());
        }



        public void ShowContent(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }



        private void neewPatientsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void oldPatientsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
