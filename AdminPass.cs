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
    public partial class AdminPass : UserControl
    {
        databaseclass dbclass=new databaseclass();
        public AdminPass()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusername.Text) &&
        !string.IsNullOrEmpty(txtpass.Text) &&
        !string.IsNullOrEmpty(txtName.Text))
            {
                string query = $"select * from users where username='{txtusername.Text}' and password='{txtpass.Text}';";
                DataSet ds = dbclass.Getdata(query);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string insertquery = $"update users set password='{txtName.Text}' where username='{txtusername.Text}' and password='{txtpass.Text}' and usertype='admin'";
                    dbclass.databaseoperations(insertquery);
                    MessageBox.Show("Password updated successfully");

                    // Clear the textboxes
                    txtusername.Text = "";
                    txtpass.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    MessageBox.Show("Admin not found");
                }
            }
            else
            {
                MessageBox.Show("Enter all Data");
            }
        }
    }
}
