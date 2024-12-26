using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Discharged : UserControl
    {
        databaseclass databaseclass = new databaseclass();

        public Discharged()
        {
            InitializeComponent();
        }

        // Load the GridView when the control loads
        private void Discharged_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        // Method to load data into the GridView
        private void LoadGridView()
        {
            string query = @"
                SELECT ipd.discharge_id, ipd.bed_number, ipd.admit_date,ipd.discharge_date,ipd.patient_id, p.name, p.contact_no 
                FROM discharged ipd 
                JOIN patients p ON ipd.patient_id = p.patient_id";

            DataSet ds = databaseclass.Getdata(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                populategridview(ds);
            }
            else
            {
                MessageBox.Show("No data found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Populate the GridView with the dataset
        private void populategridview(DataSet ds)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["ipd_id"].DataPropertyName = "discharge_id";
            dataGridView1.Columns["Bed_Number"].DataPropertyName = "bed_number";
            dataGridView1.Columns["Name"].DataPropertyName = "name";
            dataGridView1.Columns["Contact_No"].DataPropertyName = "contact_no";
            dataGridView1.Columns["Patient_id"].DataPropertyName = "patient_id";
            dataGridView1.Columns["Admit_Date"].DataPropertyName = "admit_date";
            dataGridView1.Columns["Discharge_Date"].DataPropertyName = "discharge_date";
            dataGridView1.DataSource = ds.Tables[0];
        }

        // Search button functionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text.Trim();
            string query;

            if (!string.IsNullOrEmpty(value))
            {
                query = $@"
                    SELECT ipd.discharge_id, ipd.bed_number,ipd.admit_date,ipd.discharge_date, ipd.patient_id, p.name, p.contact_no 
                    FROM discharged ipd 
                    JOIN patients p ON ipd.patient_id = p.patient_id 
                    WHERE ipd.bed_number::TEXT LIKE '%{value}%' 
                       OR p.name LIKE '%{value}%' 
                       OR p.contact_no LIKE '%{value}%'";
            }
            else
            {
                query = @"
                    SELECT ipd.discharge_id, ipd.bed_number,ipd.admit_date,ipd.discharge_date, ipd.patient_id, p.name, p.contact_no 
                    FROM discharged ipd 
                    JOIN patients p ON ipd.patient_id = p.patient_id";
            }

            DataSet ds = databaseclass.Getdata(query);
            populategridview(ds);
        }

        // Enable/disable the search button based on text input
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrEmpty(txtSearch.Text);
        }

        // Handle cell clicks to show patient details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value);
            Discharged_patient_detail patientDetails = new Discharged_patient_detail();
            patientDetails.getPatientDetails(patientId);

            AdmittedPatients patientsForm = this.FindForm() as AdmittedPatients;
            if (patientsForm != null)
            {
                patientsForm.ShowContent(patientDetails);
            }
        }
    }
}
