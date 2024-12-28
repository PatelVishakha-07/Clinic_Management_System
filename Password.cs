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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            PanelLeft.Controls.Add(dashboard);
        }

        private void showPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void ShowContent(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }
    }
}
