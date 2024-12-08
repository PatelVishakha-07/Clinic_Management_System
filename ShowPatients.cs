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

        private void populategridview(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["patient_id"].DataPropertyName = "patient_id";
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
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                btnSearch.Enabled = false;  
            }
            else
            { 
                btnSearch.Enabled = true;
            }
            if (dataGridView1.Rows.Count == 1)
            {
                string query = "select * from Patients";
                DataSet ds = databaseclass.Getdata(query);
                populategridview(ds);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Prescription"].Index && e.RowIndex >= 0)
            {
                int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value.ToString());
                string patientName = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                string address = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                int age = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["age"].Value.ToString());
                string contact = dataGridView1.Rows[e.RowIndex].Cells["contact_no"].Value.ToString();
                string gender = dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                AddPrescription addPrescription = new AddPrescription();
                addPrescription.getPatientDetails(patientId,patientName, address, age, contact, gender);
                Patients patients = this.FindForm() as Patients;
                patients.ShowContent(addPrescription);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string query;
            if (!string.IsNullOrEmpty(value))
            {

                if (int.TryParse(value, out int age))
                {
                    query = $"select* from Patients where age={int.Parse(value)}";
                }
                else
                {
                    query = $"select * from Patients where name='{value}' or gender='{value}' or contact_no='{value}' or address='{value}'";
                }

            }
            else
            {
                query = "select * from Patients";
            }
            DataSet ds = databaseclass.Getdata(query);
            populategridview(ds);
        }
    }
}
