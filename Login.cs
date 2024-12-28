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
        databaseclass dbclass=new databaseclass();
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string query = $"select * from users where username='{txtUsername.Text}' and password='{txtPassword.Text}'";
                DataSet ds = dbclass.Getdata(query);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string usertype = ds.Tables[0].Rows[0]["usertype"].ToString();
                    if (usertype=="client")
                    {
                        this.Hide();
                        Receptionist receptionist = new Receptionist();
                        receptionist.ShowDialog();
                        this.Close();
                    }
                    else if(usertype=="admin")
                    {
                        this.Hide();
                        Patients patients = new Patients();
                        patients.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No such user is registered");
                }
            }
            else
            {
                MessageBox.Show("Enter username and password");
            }
            
        }
    }
}
