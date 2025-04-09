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
    public partial class Discharge_Charge : Form
    {
        private Admit_Patient_Details admitDetails;

        public Discharge_Charge(Admit_Patient_Details admitDetails)
        {
            InitializeComponent();
            this.admitDetails = admitDetails;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtamount.Text, out decimal amount))
            {
                admitDetails.Getcharge(amount);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }

        }

    }

}
