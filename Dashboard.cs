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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form) {
            Form currentForm = this.FindForm();
            currentForm?.Hide();
            form.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            ShowForm(new Medicine());
        }
    }
}
