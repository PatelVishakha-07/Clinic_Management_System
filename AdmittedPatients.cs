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
    public partial class AdmittedPatients : Form
    {
        public AdmittedPatients()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);
        }

        private void AdmittedPatients_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ShowAdmittedPatient showAdmittedPatient = new ShowAdmittedPatient();
            showAdmittedPatient.Dock = DockStyle.Fill;
            panel2.Controls.Add(showAdmittedPatient);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void ShowContent(UserControl control)
        {
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void showAdmittedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(new ShowAdmittedPatient());
        }

        private void admitPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(new InHouse_Patient());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dischargedStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowContent(new Discharged());
        }
    }
}
