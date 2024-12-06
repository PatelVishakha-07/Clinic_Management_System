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
            string query = "select name,age,contact_no,city,adress from Patients";
            DataSet ds = new DataSet();
            ds = databaseclass.Getdata(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns["Name"].DataPropertyName = "name";
                dataGridView1.Columns["Age"].DataPropertyName = "age";
                dataGridView1.Columns["Contact_No"].DataPropertyName = "contact_no";
                dataGridView1.Columns["City"].DataPropertyName = "city";
                dataGridView1.Columns["Address"].DataPropertyName = "adress";
                DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
                {
                    Name = "Prescription",
                    HeaderText = "Prescription",
                    Text = "Add",
                    UseColumnTextForLinkValue = true
                };


                dataGridView1.Columns.Add(linkColumn);
                DataGridViewLinkColumn linkColumn1 = new DataGridViewLinkColumn
                {
                    Name = "Details",
                    HeaderText = "Details",
                    Text = "View",
                    UseColumnTextForLinkValue = true
                };


                dataGridView1.Columns.Add(linkColumn1);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
