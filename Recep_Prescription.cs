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

            var patientIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "patient_id",
                HeaderText = "Patient ID",
                Visible = false
            };
            dataGridView1.Columns.Add(patientIdColumn);

            var prescriptionIdColumns = new DataGridViewTextBoxColumn
            {
                Name = "prescription_id",
                HeaderText = "Prescription ID",
                Visible = false
            };
            dataGridView1.Columns.Add(prescriptionIdColumns);

            var pres_med_IdColumns = new DataGridViewTextBoxColumn
            {
                Name = "pres_med_id",
                HeaderText = "Prescribed Medicine ID",
                Visible = false
            };
            dataGridView1.Columns.Add(pres_med_IdColumns);

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("name", "Patient Name");
            dataGridView1.Columns.Add("prescription", "Prescription");
            dataGridView1.Columns.Add("medicine_name", "Medicine Name");
            dataGridView1.Columns.Add("quantity", "Quantity");
            dataGridView1.Columns.Add("usage", "Dosage");

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
                string query = @"WITH LatestPrescriptions AS (
    SELECT p.prescription_id, p.patient_id, p.prescription, MAX(p.prescription_date) AS latest_date 
    FROM prescription p
    WHERE p.prescription_date > NOW() - INTERVAL '30 minutes' 
    GROUP BY p.prescription_id, p.patient_id, p.prescription
)
SELECT pt.name, lp.prescription_id, lp.prescription, pm.pres_med_id, pm.medicine_name, pm.quantity, pm.usage, lp.patient_id 
FROM LatestPrescriptions lp 
INNER JOIN prescribed_medicine pm ON lp.prescription_id = pm.prescription_id
INNER JOIN patients pt ON pt.patient_id = lp.patient_id
ORDER BY lp.latest_date DESC;
";


                DataSet ds = dbClass.Getdata(query);

                if (ds.Tables[0].Rows.Count == 0 && s == "refreshed")
                {
                    // Display message if no prescriptions found
                    MessageBox.Show("No new prescriptions have been added in the last 30 minutes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Rows.Clear();

                // Populate DataGridView with new data
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(
                        row["patient_id"].ToString(),
                        row["prescription_id"].ToString(),
                        row["pres_med_id"].ToString(),
                        row["name"].ToString(),
                        row["prescription"].ToString(),
                        row["medicine_name"].ToString(),
                        row["quantity"].ToString(),
                        row["usage"].ToString()
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
                string presId = dataGridView1.Rows[e.RowIndex].Cells["prescription_id"].Value.ToString();
                string pres_medId = dataGridView1.Rows[e.RowIndex].Cells["pres_med_id"].Value.ToString();
                Receptionist receptionist = this.FindForm() as Receptionist;
                Recep_Patient_Details details=new Recep_Patient_Details(int.Parse(patientId),int.Parse(presId), int.Parse(pres_medId));
                receptionist.ShowControl(details);
            }
        }
    }
}
