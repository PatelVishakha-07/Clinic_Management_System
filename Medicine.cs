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

            MenuMedicine menuMedicine = new MenuMedicine();

            menuMedicine.Dock = DockStyle.Top;
            TopPanel.Controls.Add(menuMedicine);
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShowMedicine showMedicine = new ShowMedicine();
            panel1.Controls.Add(showMedicine);

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
