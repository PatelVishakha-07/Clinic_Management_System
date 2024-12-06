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
            this.Controls.Add(dashboard);
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            
            MenuMedicine menuMedicine = new MenuMedicine();
            menuMedicine.Dock = DockStyle.Top;
            this.Controls.Add(menuMedicine);
        }
    }
}
