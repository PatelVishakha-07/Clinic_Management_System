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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Client" && txtPassword.Text == "1234")
            {
                this.Hide();
                Receptionist receptionist = new Receptionist();
                receptionist.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Patients patients = new Patients();
                patients.ShowDialog();
                this.Close();
            }
            
        }
    }
}
