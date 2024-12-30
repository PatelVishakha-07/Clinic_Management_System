using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class ShowAdmittedPatient : UserControl
    {
        databaseclass databaseclass = new databaseclass();
        string str;

        public ShowAdmittedPatient(string s)
        {
            InitializeComponent();
            str = s;
        }

        private void ShowAdmittedPatient_Load(object sender, EventArgs e)
        {
            // Load the grid on form load
        }

        private void LoadGridView()
        {
            string query = @"
        SELECT ipd.ipd_id, ipd.bed_number,ipd.admit_date,ipd.patient_id, p.name, p.contact_no 
        FROM ipd_table ipd 
        JOIN patients p ON ipd.patient_id = p.patient_id";

            DataSet ds = databaseclass.Getdata(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                populategridview(ds);
            }
            else
            {
                // MessageBox.Show("No data found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void populategridview(DataSet ds)
        //{
        //    dataGridView1.AutoGenerateColumns = false;

        //    // Map columns from the result set
        //    dataGridView1.Columns["ipd_id"].DataPropertyName = "ipd_id";
        //    dataGridView1.Columns["Bed_Number"].DataPropertyName = "bed_number";
        //    dataGridView1.Columns["Name"].DataPropertyName = "name";
        //    dataGridView1.Columns["Contact_No"].DataPropertyName = "contact_no";

        //    dataGridView1.DataSource = ds.Tables[0];
        //}

        private void populategridview(DataSet ds)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["ipd_id"].DataPropertyName = "ipd_id";
            dataGridView1.Columns["Bed_Number"].DataPropertyName = "bed_number";
            dataGridView1.Columns["Name"].DataPropertyName = "name";
            dataGridView1.Columns["Contact_No"].DataPropertyName = "contact_no";
            dataGridView1.Columns["Patient_id"].DataPropertyName = "patient_id";
            dataGridView1.Columns["Admit_Date"].DataPropertyName = "admit_date";
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string query;

            if (!string.IsNullOrEmpty(value))
            {
                query = $@"
                    SELECT ipd.ipd_id, ipd.bed_number,ipd.admit_date,ipd.patient_id, p.name, p.contact_no 
                    FROM ipd_table ipd 
                    JOIN patients p ON ipd.patient_id = p.patient_id 
                    WHERE ipd.bed_number LIKE '%{value}%' 
                       OR p.name LIKE '%{value}%' 
                       OR p.contact_no LIKE '%{value}%'";
            }
            else
            {
                query = @"
                    SELECT ipd.ipd_id, ipd.bed_number,ipd.admit_date,ipd.patient_id, p.name, p.contact_no 
                    FROM ipd_table ipd 
                    JOIN patients p ON ipd.patient_id = p.patient_id";
            }

            DataSet ds = databaseclass.Getdata(query);
            populategridview(ds);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrEmpty(txtSearch.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ipd_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ipd_id"].Value.ToString());
            int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value.ToString());
            if(str == "Doctor")
            {
                Admit_Patient_Details patientDetails = new Admit_Patient_Details("Doctor",ipd_id);
                patientDetails.getPatientDetails(patientId);
                AdmittedPatients patients = new AdmittedPatients();
                patients = this.FindForm() as AdmittedPatients;
                patients.ShowContent(patientDetails);
            }
            else if(str == "Receptionist")
            {
                Admit_Patient_Details patientDetails = new Admit_Patient_Details("Receptionist",ipd_id);
                patientDetails.getPatientDetails(patientId);
                Receptionist receptionist = new Receptionist();
                receptionist = this.FindForm() as Receptionist;
                receptionist.ShowControl(patientDetails);
            }
            
        }
    }
}
