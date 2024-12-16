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
    public partial class InHouse_Patient : UserControl
    {
        public InHouse_Patient()
        {
            InitializeComponent();
        }

        private void InHouse_Patient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e) { }

        private void txtAge_TextChanged(object sender, EventArgs e) { }

        private void txtContact_TextChanged(object sender, EventArgs e) { }

        private void txtGender_TextChanged(object sender, EventArgs e) { }

        private void txtAddress_TextChanged(object sender, EventArgs e) { }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void txtBed_TextChanged(object sender, EventArgs e) { }

        private void btnAdmit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiagnosis.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();
            txtRoom.Text = string.Empty;
            txtBed.Text = string.Empty;
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
