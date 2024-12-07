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
    public partial class AddPrescription : UserControl
    {
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }

        public void getPatientDetails(string name, string address, int age, string contact,string gender)
        {
            txtName.Text = name;
            txtaddress.Text = address;
            txtAge.Text=age.ToString();
            txtContact.Text = contact;
            txtGender.Text = gender.ToString();
        }

        private void txtDisease_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
