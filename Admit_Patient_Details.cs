using iTextSharp.text.pdf.fonts.cmaps;
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
    public partial class Admit_Patient_Details : UserControl
    {
        int patientId;
        databaseclass dbclass = new databaseclass();

        public Admit_Patient_Details()
        {
            InitializeComponent();
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

        public void getPatientDetails(int patientId)
        {
            this.patientId = patientId;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admit_Patient_Details_Load(object sender, EventArgs e)
        {
            string patientQuery = $"select Distinct * from patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 200;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });

            // Fetch and display prescription details and their associated prescribed medicines immediately
            string ipd_data = $"select * from ipd_table where patient_id={patientId}";
            DataSet ipd = dbclass.Getdata(ipd_data);

            if (ipd != null && ipd.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow ipdrow in ipd.Tables[0].Rows)
                {
                    int ipd_id = Convert.ToInt32(ipdrow["ipd_id"]);

                    string query = $"select * from ipd_treatment_table where ipd_id={ipd_id}";
                    DataSet currentprescription = dbclass.Getdata(query);
                    // Display prescription details
                    currentY = DisplayData(currentprescription, panel1, currentY, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id" });

                    // Fetch and display prescribed medicines for this prescription
                    string medicineQuery = $"select * from ipd_treatment_table where ipd_id= {ipd_id}";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string ipd_data = $"select ipd_id from ipd_table where patient_id={patientId}";
            DataSet ds = dbclass.Getdata(ipd_data);
            if (ds != null)
            {
                int ipd_id = int.Parse(ds.Tables[0].Rows[0]["ipd_id"].ToString());
                Diagnosis diagnosis = new Diagnosis(ipd_id);
                AdmittedPatients patients = this.FindForm() as AdmittedPatients;
                //    //patients.Visible = false;
                //    //patients?.Show(diagnosis);
                 patients.ShowContent(diagnosis);
            }
        }
    }
}
