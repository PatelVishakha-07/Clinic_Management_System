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
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
