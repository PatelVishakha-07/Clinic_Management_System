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
    public partial class Recep_Patient_Details : UserControl
    {
        int patient_id, pres_id, pres_med_id;
        databaseclass dbclass = new databaseclass();
        public Recep_Patient_Details(int patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
            this.pres_id = pres_id;
            this.pres_med_id = pres_med_id; 
        }

        private void Recep_Patient_Details_Load(object sender, EventArgs e)
        {
            // Fetch and display patient details
            string patientQuery = $"select * from patients WHERE patient_id={patient_id}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 50;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });

            // Fetch and display prescription details and their associated prescribed medicines immediately
            string prescriptionQuery = $"select * from prescription where patient_id={patient_id} order by prescription_date desc limit 1";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                // Display the latest prescription details
                DataRow prescriptionRow = prescriptionData.Tables[0].Rows[0];
                int prescriptionId = Convert.ToInt32(prescriptionRow["prescription_id"]);

                string query = $"select * from prescription where prescription_id={prescriptionId}";
                DataSet currentprescription = dbclass.Getdata(query);
                // Display prescription details
                currentY = DisplayData(currentprescription, panel1, currentY, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id" });

                // Fetch and display prescribed medicines for this latest prescription
                string medicineQuery = $"select * from Prescribed_Medicine where prescription_id={prescriptionId}";
                DataSet medicineData = dbclass.Getdata(medicineQuery);

                // Display the medicines immediately below the current prescription
                currentY = DisplayData(medicineData, panel1, currentY + 50, "Prescribed Medicine Details", excludeColumns: new[] { "pres_med_id", "prescription_id" });
                currentY += 20; // Adjust for next prescription and medicine set
            }
            else
            {
                // Handle case where no prescriptions are found
                Label noDataLabel = new Label()
                {
                    Text = "No prescriptions available.",
                    Location = new Point(40, currentY),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                currentY += 35; // Adjust for next section
            }
        }

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 35;
            int keyValueSpacing = 250;

            Label titleLabel = new Label()
            {
                Text = sectionTitle,
                Location = new Point(40, startY),
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DimGray,
            };
            panel1.Controls.Add(titleLabel);
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


                        Label keyLabel = new Label()
                        {
                            Text = $"{columnName}:",
                            Location = new Point(40, startY),
                            AutoSize = true,
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold)
                        };

                        Label valueLabel = new Label()
                        {
                            Text = columnValue,
                            Location = new Point(40 + keyValueSpacing, startY),
                            AutoSize = true,
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular)
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
                    Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                startY += labelSpacing;
            }

            return startY;
        }

    }
}
