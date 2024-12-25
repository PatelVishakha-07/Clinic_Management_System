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
    public partial class PatientDetails : UserControl
    {
        int patientId;
        databaseclass dbclass = new databaseclass();
        public PatientDetails()
        {
            InitializeComponent();
        }
        public void getPatientDetails(int patientId)
        {
            this.patientId = patientId;
        }

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 35;
            int keyValueSpacing = 250;

            //Label titleLabel = new Label()
            //{
            //    Text = sectionTitle,
            //    Location = new Point(40, startY),
            //    AutoSize = true,
            //    Font = new Font("Arial", 16, FontStyle.Bold),
            //    ForeColor = Color.DimGray,
            //};
            // panel1.Controls.Add(titleLabel);
            startY += 40;

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    foreach (DataColumn col in ds.Tables[0].Columns)
                    {
                        if (excludeColumns != null && excludeColumns.Contains(col.ColumnName))
                            continue;

                        string columnName = col.ColumnName.ToUpper();
                        string columnValue = row[col].ToString();

                        // Check for the "usage" column and translate values
                        if (col.ColumnName.Equals("usage", StringComparison.OrdinalIgnoreCase))
                        {
                            columnValue = TranslateUsageToBars(columnValue);
                        }

                        Label keyLabel = new Label()
                        {
                            Text = $"{columnName}:",
                            Location = new Point(40, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold)
                        };

                        Label valueLabel = new Label()
                        {
                            Text = columnValue,
                            Location = new Point(40 + keyValueSpacing, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Regular)
                        };

                        panel1.Controls.Add(keyLabel);
                        panel1.Controls.Add(valueLabel);

                        startY += labelSpacing;
                    }
                }
            }
            else
            {
                Label noDataLabel = new Label()
                {
                    Text = "No data available.",
                    Location = new Point(40, startY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                startY += labelSpacing;
            }

            return startY;
        }

        // Helper method to translate usage values to bars
        private string TranslateUsageToBars(string usage)
        {
            switch (usage.ToUpper())
            {
                case "OD":
                    return "| ";  // Once a day
                case "BD":
                    return "| |"; // Twice a day
                case "TD":
                    return "| | |"; // Thrice a day
                case "QD":
                    return "| | | |"; // Four times a day
                default:
                    return usage; // If no match, return original value
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from patients where patient_id={patientId}";
            DataSet ds = dbclass.Getdata(query);
            string name = ds.Tables[0].Rows[0]["name"].ToString();
            int age = int.Parse(ds.Tables[0].Rows[0]["age"].ToString());
            string address = ds.Tables[0].Rows[0]["address"].ToString();
            string contact = ds.Tables[0].Rows[0]["contact_no"].ToString();
            string gender = ds.Tables[0].Rows[0]["gender"].ToString();

            AddPrescription addPrescription = new AddPrescription();
            addPrescription.getPatientDetails(patientId, name, address, age, contact, gender);
            Patients patients = this.FindForm() as Patients;                                   
            patients.ShowContent(addPrescription);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            // Fetch and display patient details
            string patientQuery = $"select Distinct * from patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 200;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });

            // Fetch and display prescription details and their associated prescribed medicines immediately
            string prescriptionQuery = $"select * from prescription where patient_id={patientId}";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow prescriptionRow in prescriptionData.Tables[0].Rows)
                {
                    int prescriptionId = Convert.ToInt32(prescriptionRow["prescription_id"]);

                    string query = $"select * from prescription where prescription_id={prescriptionId}";
                    DataSet currentprescription = dbclass.Getdata(query);
                    // Display prescription details
                    currentY = DisplayData(currentprescription, panel1, currentY, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id","charges" });

                    // Fetch and display prescribed medicines for this prescription
                    string medicineQuery = $"select * from Prescribed_Medicine where prescription_id={prescriptionId}";
                    DataSet medicineData = dbclass.Getdata(medicineQuery);

                    // Display the medicines immediately below the current prescription
                    currentY = DisplayData(medicineData, panel1, currentY + 50, "Prescribed Medicine Details", excludeColumns: new[] { "pres_med_id", "prescription_id" });
                    currentY += 20; // Adjust for next prescription and medicine set
                }
            }
            else
            {
                // Handle case where no prescriptions are found
                Label noDataLabel = new Label()
                {
                    Text = "No prescriptions available.",
                    Location = new Point(40, currentY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                currentY += 35; // Adjust for next section
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Report report = new Report(patientId);
            report.ShowDialog();
        }
    }
}
