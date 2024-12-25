using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Income : Form
    {
        
        public Income()
        {
            InitializeComponent();

        }

        private void Income_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);

            panel1.Controls.Clear();
            OPD_Income oPD_Income = new OPD_Income();
            oPD_Income.Dock = DockStyle.Fill;
            panel1.Controls.Add(oPD_Income);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void monthlyIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            IPD_Income iPD_Income = new IPD_Income();
            iPD_Income.Dock = DockStyle.Fill;
            panel1.Controls.Add(iPD_Income);
        }

        private void todaysIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OPD_Income oPD_Income = new OPD_Income();
            oPD_Income.Dock = DockStyle.Fill;
            panel1.Controls.Add(oPD_Income);
        }
    }
}
