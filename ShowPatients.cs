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
    public partial class ShowPatients : UserControl
    {
        databaseclass databaseclass = new databaseclass();
        public ShowPatients()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                string query = "select name,age,contact_no,gender,address from Patients";
                DataSet ds = databaseclass.Getdata(query);
                populategridview(ds);
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            string value=txtSearch.Text;
            string query;
            if (!string.IsNullOrEmpty(value))
            {
                
                if (value.Length < 4) {
                     query = $"select name,age,contact_no,gender,address from Patients where name='{value}' or age={int.Parse(value)} or gender='{value}' or contact_no='{value}' or address='{value}'";
                }
                else
                {
                     query = $"select name,age,contact_no,gender,address from Patients where name='{value}' or gender='{value}' or contact_no='{value}' or address='{value}'";
                }
                
            }
            else
            {
                 query = "select name,age,contact_no,gender,address from Patients";
            }
            DataSet ds = databaseclass.Getdata(query);
            populategridview(ds);
        }

        private void populategridview(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns["Name"].DataPropertyName = "name";
                dataGridView1.Columns["Age"].DataPropertyName = "age";
                dataGridView1.Columns["Contact_No"].DataPropertyName = "contact_no";
                dataGridView1.Columns["Gender"].DataPropertyName = "gender";
                dataGridView1.Columns["Address"].DataPropertyName = "address";
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (!dataGridView1.Columns.Contains("Prescription"))
            {
                DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
                {
                    Name = "Prescription",
                    HeaderText = "Prescription",
                    Text = "Add",
                    UseColumnTextForLinkValue = true
                };



                dataGridView1.Columns.Add(linkColumn);
            }
            if (!dataGridView1.Columns.Contains("Details"))
            {
                DataGridViewLinkColumn linkColumn1 = new DataGridViewLinkColumn
                {
                    Name = "Details",
                    HeaderText = "Details",
                    Text = "View",
                    UseColumnTextForLinkValue = true
                };


                dataGridView1.Columns.Add(linkColumn1);

            }
        }
        }
}
