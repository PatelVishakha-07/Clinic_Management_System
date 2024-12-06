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

            MenuPatient menuPatient = new MenuPatient();
            menuPatient.Dock = DockStyle.Top;
            PanelTop.Controls.Add(menuPatient);
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
