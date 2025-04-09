using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private int DisplayData(DataSet ds, Control container, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 30;
            int keyValueSpacing = 200;

            Label titleLabel = new Label()
            {
                Text = sectionTitle,
                Location = new Point(10, startY),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            };
            container.Controls.Add(titleLabel);
            startY += 30;

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
                            Location = new Point(10, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 10, FontStyle.Bold)
                        };

                        Label valueLabel = new Label()
                        {
                            Text = columnValue,
                            Location = new Point(10 + keyValueSpacing, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 10, FontStyle.Regular)
                        };

                        container.Controls.Add(keyLabel);
                        container.Controls.Add(valueLabel);

                        startY += labelSpacing;
                    }
                }
            }
            else
            {
                Label noDataLabel = new Label()
                {
                    Text = "No data available.",
                    Location = new Point(10, startY),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                container.Controls.Add(noDataLabel);
                startY += labelSpacing;
            }

            return startY;
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            // Only remove dynamic content, not buttons
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = panel1.Controls[i];
                if (ctrl.Name != "btnprint" && ctrl.Name != "button1")
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            int currentY = 20;

            // Fetch and display patient details
            string patientQuery = $"SELECT * FROM patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);

            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });
            currentY += 20;

            // Fetch prescriptions
            string prescriptionQuery = $"SELECT * FROM prescription WHERE patient_id={patientId} ORDER BY prescription_id DESC";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow prescriptionRow in prescriptionData.Tables[0].Rows)
                {
                    int prescriptionId = Convert.ToInt32(prescriptionRow["prescription_id"]);

                    Panel groupPanel = new Panel()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(30, currentY),
                        Width = panel1.Width - 60,
                        AutoSize = true,
                        BackColor = Color.WhiteSmoke
                    };

                    int yOffset = 10;

                    // Prescription details
                    string query = $"SELECT * FROM prescription WHERE prescription_id={prescriptionId}";
                    DataSet currentPrescription = dbclass.Getdata(query);
                    yOffset = DisplayData(currentPrescription, groupPanel, yOffset, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id", "charges" });

                    // Medicines
                    string medicineQuery = $"SELECT * FROM Prescribed_Medicine WHERE prescription_id={prescriptionId}";
                    DataSet medicineData = dbclass.Getdata(medicineQuery);
                    yOffset = DisplayData(medicineData, groupPanel, yOffset + 20, "Prescribed Medicines", excludeColumns: new[] { "prescription_id", "pres_med_id" });

                    groupPanel.Height = yOffset + 10;
                    panel1.Controls.Add(groupPanel);

                    currentY += groupPanel.Height + 20;
                }
            }
            else
            {
                Label noPresc = new Label()
                {
                    Text = "No prescriptions available.",
                    Location = new Point(40, currentY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noPresc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from patients where patient_id={patientId}";
            DataSet ds = dbclass.Getdata(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
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
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Report report = new Report(patientId);
            report.ShowDialog();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Optional: custom paint logic
        }
    }
}
