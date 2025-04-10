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
    public partial class receptionpass : UserControl
    {
        databaseclass dbclass = new databaseclass();
        public receptionpass()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusername.Text) && !string.IsNullOrEmpty(txtpass.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtrecpass.Text))
            {
                string query1 = $"select * from users where username='{txtusername.Text}' and password='{txtpass.Text}' and usertype='admin'";
                DataSet ds = dbclass.Getdata(query1);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string query = $"select * from users where username='{txtName.Text}';";
                    DataSet ds1 = dbclass.Getdata(query);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        string insertquery = $"update users set password='{txtrecpass.Text}' where username='{txtName.Text}'";
                        dbclass.databaseoperations(insertquery);
                        MessageBox.Show($"Password updated for {txtName.Text}");

                        // Clear the textboxes
                        txtusername.Text = "";
                        txtpass.Text = "";
                        txtName.Text = "";
                        txtrecpass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"No such reception found");
                    }
                }
                else
                {
                    MessageBox.Show("Admin not found");
                }
            }
            else
            {
                MessageBox.Show("Enter all data");
            }
        }
    }
}
