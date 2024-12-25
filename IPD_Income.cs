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
    public partial class IPD_Income : UserControl
    {
        public IPD_Income()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Today's Income";
        }

        private void IPD_Income_Load(object sender, EventArgs e)
        {

        }
    }
}
