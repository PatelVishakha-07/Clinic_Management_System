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
    public partial class Diagnosis : UserControl
    {
        int ipd_id;
        public Diagnosis(int ipd_id)
        {
            InitializeComponent();
            this.ipd_id = ipd_id;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttreat.Text) && !string.IsNullOrEmpty(txtdiag.Text) && !string.IsNullOrEmpty(txtcharge.Text))
            {
                string query = $"insert into ipd_treatment_table(diagnosis,treatment,charge,ipd_id) values ('{txtdiag.Text}','{txttreat.Text}',{txtcharge.Text},{ipd_id}) ";
                databaseclass dbclass = new databaseclass();
                dbclass.databaseoperations(query);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtcharge.Text = string.Empty;
            txtdiag.Text = string.Empty;
            txtcharge.Text = string.Empty;
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }
    }
}
