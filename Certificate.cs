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
    public partial class Certificate : Form
    {
        public Certificate()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(dashboard);
        }

        private void Certificate_Load(object sender, EventArgs e)
        {
            ShowControl(new CertificateDetails());
        }

        public void ShowControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void btnDone_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e) { }

        private void createCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new CertificateDetails());
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new CertificateShow());
        }
    }
}
