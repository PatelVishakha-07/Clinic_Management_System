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



        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    string query = $"select * from patients where patient_id={patientId}";
        //    DataSet ds = dbclass.Getdata(query);
        //    // panel1.Controls.Clear(); 159, 211
        //    int topMargin = 200;
        //    int labelSpacing = 35;
        //    int keyValueSpacing = 250;

        //    if (ds != null && ds.Tables[0].Rows.Count > 0)
        //    {
        //        DataRow row = ds.Tables[0].Rows[0];
        //        int y = topMargin;

        //        foreach (DataColumn col in ds.Tables[0].Columns)
        //        {

        //            if (col.ColumnName != "patient_id")
        //            {
        //                string columnName = col.ColumnName.ToUpper();
        //                string columnValue = row[col].ToString();


        //                Label keyLabel = new Label()
        //                {
        //                    Text = $"{columnName}:",
        //                    Location = new Point(40, y),
        //                    AutoSize = true,
        //                    Font = new Font("Arial", 15, FontStyle.Bold),
        //                };


        //                Label valueLabel = new Label()
        //                {
        //                    Text = columnValue,
        //                    Location = new Point(40 + keyValueSpacing, y),
        //                    AutoSize = true,
        //                    Font = new Font("Arial", 15, FontStyle.Regular),
        //                };

        //                panel1.Controls.Add(keyLabel);
        //                panel1.Controls.Add(valueLabel);


        //                y += labelSpacing;
        //            }
        //        }
        //    }
        //    query = $"select * from prescription where patient_id={patientId}";
        //    DataSet ds1 = dbclass.Getdata(query);

        //    int topMargin1 = 400;
        //    int labelSpacing1 = 35;
        //    int keyValueSpacing1 = 250;

        //    if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
        //    {
        //        DataRow row = ds1.Tables[0].Rows[0];
        //        int y = topMargin1;

        //        foreach (DataColumn col in ds1.Tables[0].Columns)
        //        {

        //            if (col.ColumnName != "patient_id" && col.ColumnName != "prescription_id")
        //            {
        //                string columnName = col.ColumnName.ToUpper();
        //                string columnValue = row[col].ToString();


        //                Label keyLabel = new Label()
        //                {
        //                    Text = $"{columnName}:",
        //                    Location = new Point(40, y),
        //                    AutoSize = true,
        //                    Font = new Font("Arial", 10, FontStyle.Bold),
        //                };


        //                Label valueLabel = new Label()
        //                {
        //                    Text = columnValue,
        //                    Location = new Point(40 + keyValueSpacing1, y),
        //                    AutoSize = true,
        //                    Font = new Font("Arial", 10, FontStyle.Regular),
        //                };

        //                panel1.Controls.Add(keyLabel);
        //                panel1.Controls.Add(valueLabel);


        //                y += labelSpacing1;

        //                query = $"select * from Prescribed_Medicine where prescription_id={}";
        //                DataSet ds2 = dbclass.Getdata(query);

        //                int topMargin2 = 400;
        //                int labelSpacing2 = 35;
        //                int keyValueSpacing2 = 250;

        //                if (ds2 != null && ds2.Tables[0].Rows.Count > 0)
        //                {
        //                    DataRow row1 = ds1.Tables[0].Rows[0];
        //                    int y1 = topMargin2;

        //                    foreach (DataColumn col1 in ds1.Tables[0].Columns)
        //                    {

        //                        if (col.ColumnName != "pres_med_id" && col.ColumnName != "prescription_id")
        //                        {
        //                            string columnName1 = col.ColumnName.ToUpper();
        //                            string columnValue1 = row[col].ToString();


        //                            Label keyLabel1 = new Label()
        //                            {
        //                                Text = $"{columnName}:",
        //                                Location = new Point(40, y),
        //                                AutoSize = true,
        //                                Font = new Font("Arial", 10, FontStyle.Bold),
        //                            };


        //                            Label valueLabel1 = new Label()
        //                            {
        //                                Text = columnValue,
        //                                Location = new Point(40 + keyValueSpacing2, y),
        //                                AutoSize = true,
        //                                Font = new Font("Arial", 10, FontStyle.Regular),
        //                            };

        //                            panel1.Controls.Add(keyLabel);
        //                            panel1.Controls.Add(valueLabel);


        //                            y += labelSpacing2;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //}
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

          
        //}

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 35;
            int keyValueSpacing = 250;


            Label titleLabel = new Label()
            {
                Text = sectionTitle,
                Location = new Point(40, startY),
                AutoSize = true,
                Font = new Font("Arial", 16, FontStyle.Bold),
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
           // panel1.Controls.Clear();
            string patientQuery = $"select * from patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 200;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });


            string prescriptionQuery = $"select * from prescription where patient_id={patientId}";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);
            currentY = DisplayData(prescriptionData, panel1, currentY + 50, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id" });


            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow prescriptionRow in prescriptionData.Tables[0].Rows)
                {
                    int prescriptionId = Convert.ToInt32(prescriptionRow["prescription_id"]);
                    string medicineQuery = $"select * from Prescribed_Medicine where prescription_id={prescriptionId}";
                    DataSet medicineData = dbclass.Getdata(medicineQuery);
                    currentY = DisplayData(medicineData, panel1, currentY + 50, "Prescribed Medicine Details", excludeColumns: new[] { "pres_med_id", "prescription_id" });
                    currentY += 20;
                }
            }
        }
    }
}
