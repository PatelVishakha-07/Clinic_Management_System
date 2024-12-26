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
        }        

        private void btnDone_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string disease = txtDisease.Text;
            string fromDate = dtpFromDate.Text;
            string toDate = dtpToDate.Text;
            CertificateOutput certificateOutput = new CertificateOutput(name, disease, fromDate, toDate);
            certificateOutput.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDisease.Text = string.Empty;
            dtpFromDate.Text = DateTime.Now.ToString();
            dtpToDate.Text = DateTime.Now.ToString();                   
        }
    }
}
