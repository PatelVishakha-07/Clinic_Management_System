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
    public partial class Receptionist : Form
    {

        public Receptionist()
        {
            InitializeComponent();
        }

        public void ShowControl(UserControl control)
        {
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            ShowControl(new Recep_Prescription());
        }

        private void btnRefresh_Click(object sender, EventArgs e) { }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            ShowControl(new Recep_Prescription());
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            ShowControl(new ShowMedicine("Receptionist"));
        }

        private void btnInHouse_Click(object sender, EventArgs e)
        {
            ShowControl(new ShowAdmittedPatient("Receptionist"));
        }
    }
}
