using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Management_System
{
    public partial class Recep_Prescription : UserControl
    {
        private System.Windows.Forms.Timer timer;
        databaseclass dbClass = new databaseclass();
        string str = "not refreshed";

        public Recep_Prescription()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeTimer();
        }

        private void Recep_Prescription_Load(object sender, EventArgs e)
        {
            LoadPrescriptions(str);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadPrescriptions(str);
        }

        private void InitializeDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("patient_id", "Patient ID");
            dataGridView1.Columns.Add("name", "Patient Name");

            // Optional: Hide the Patient ID column if you don't want to display it
            dataGridView1.Columns["patient_id"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // 1 minute interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void LoadPrescriptions(string s)
        {
            try
            {
                string query = @"
            SELECT DISTINCT pt.patient_id, pt.name, p.prescription_date
            FROM patients pt
            INNER JOIN prescription p ON pt.patient_id = p.patient_id
            WHERE p.prescription_date > NOW() - INTERVAL '30 minutes'
            ORDER BY p.prescription_date DESC;
        ";

                DataSet ds = dbClass.Getdata(query);

                if (ds.Tables[0].Rows.Count == 0 && s == "refreshed")
                {
                    // Display message if no patients found
                    MessageBox.Show("No new patient details have been added in the last 30 minutes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Rows.Clear();

                // Populate DataGridView with new data
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(
                        row["patient_id"].ToString(),
                        row["name"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPrescriptions("refreshed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                string patientId = dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value.ToString();
                Receptionist receptionist = this.FindForm() as Receptionist;
                Recep_Patient_Details details = new Recep_Patient_Details(int.Parse(patientId));
                receptionist.ShowControl(details);
            }
        }
    }
}
