using iTextSharp.text.pdf.fonts.cmaps;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic_Management_System
{
    public partial class Admit_Patient_Details : UserControl
    {
        int patientId,amount,ipd_id;
        databaseclass dbclass = new databaseclass();
        decimal updatedTotalPay;
        public Admit_Patient_Details(string s,int ipd_id)
        {
            InitializeComponent();
            if(s == "Receptionist")
            {
                btnprint.Enabled = false;
                btnprint.Visible = false;
                btn_discharge.Enabled = false;
                btn_discharge.Visible = false;
                btn_add.Enabled=false;
                btn_add.Visible=false;
            }
            this.ipd_id = ipd_id;
        }
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
                    DataSet allprescription = dbclass.Getdata(query);
                    // Display prescription details
                    foreach (DataRow treatmentrow in allprescription.Tables[0].Rows)
                    {
                        int treatment_id = Convert.ToInt32(treatmentrow["treatment_id"]);
                        string trtquery = $"select * from ipd_treatment_table where treatment_id={treatment_id}";
                        DataSet currentprescription = dbclass.Getdata(trtquery);
                        currentY = DisplayData(currentprescription, panel1, currentY, "Prescription Details", excludeColumns: new[] { "ipd_id", "treatment_id" });

                        string medicineQuery = $"select * from ipd_prescribed_medicine where treatment_id={treatment_id}";
                        DataSet medicineData = dbclass.Getdata(medicineQuery);

                        // Display the medicines immediately below the current prescription
                        currentY = DisplayData(medicineData, panel1, currentY + 50, "Prescribed Medicine Details", excludeColumns: new[] { "pres_med_id", "treatment_id" });

                        currentY += 20; // Adjust for next prescription and medicine set
                    }
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
            IPD_Report report = new IPD_Report(patientId);
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
                //   //patients?.Show(diagnosis);
                patients.ShowContent(diagnosis);
            }
        }

        private void btn_pres_Click(object sender, EventArgs e)
        {

        }

        //public void Getcharge(int amount)
        //{
        //    this.amount = amount;
        //}

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            try
            {
                Discharge_Charge dischargeForm = new Discharge_Charge(this);
                dischargeForm.ShowDialog();
                using (var connection = new NpgsqlConnection("Host = localhost; Port = 5432; Username = postgres; Password = 2002; Database = Clinic_Management;")) // Use your database connection string
                {
                    connection.Open();
                    string updatepay = $"UPDATE ipd_table SET total_pay = COALESCE(total_pay, 0) + {amount} WHERE patient_id = {patientId}  and ipd_id={ipd_id} RETURNING total_pay;";

                    using (var command = new NpgsqlCommand(updatepay, connection))
                    {
                        updatedTotalPay = (decimal)command.ExecuteScalar(); // Fetch the returned value
                       
                     //   Console.WriteLine($"Updated total pay: {updatedTotalPay}");
                    }
                }

                // string updatepay = $"UPDATE ipd_table SET total_pay = COALESCE(total_pay, 0) + {amount} WHERE patient_id = {patientId};";
                string updateprofit =$"insert into ipd_profit(profit_date,amount) values('{DateTime.Now}',{amount});";
               // dbclass.databaseoperations(updatepay);
                dbclass.databaseoperations(updateprofit);
                ExecuteDischargeProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public void Getcharge(int amount)
        {
            this.amount = amount;
        }


        private void ExecuteDischargeProcess()
        {
            try
            {
                // Fetch IPD record
                string ipdQuery = $"SELECT * FROM ipd_table WHERE patient_id={patientId}";
                DataSet ipdData = dbclass.Getdata(ipdQuery);

                if (ipdData != null && ipdData.Tables[0].Rows.Count > 0)
                {
                    DataRow ipdRow = ipdData.Tables[0].Rows[0];

                    // Insert into discharged table
                    string insertDischargedQuery = $"INSERT INTO discharged (bed_number, admit_date, total_pay,discharge_date,patient_id) " +
                                                   $"VALUES ({ipdRow["bed_number"]}, '{ipdRow["admit_date"]}', {updatedTotalPay},'{DateTime.Now}', {ipdRow["patient_id"]}) " +
                                                   $"RETURNING discharge_id";
                    DataSet dischargeResult = dbclass.Getdata(insertDischargedQuery);
                    int dischargeId = Convert.ToInt32(dischargeResult.Tables[0].Rows[0]["discharge_id"]);

                    // Fetch and move treatments
                    string treatmentQuery = $"SELECT * FROM ipd_treatment_table WHERE ipd_id={ipdRow["ipd_id"]}";
                    DataSet treatmentData = dbclass.Getdata(treatmentQuery);

                    if (treatmentData != null && treatmentData.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow treatmentRow in treatmentData.Tables[0].Rows)
                        {
                            // Insert into discharge_treatment_table
                            string insertTreatmentQuery = $"INSERT INTO discharge_treatment_table (diagnosis, treatment, treatment_date, discharge_id) " +
                                                          $"VALUES ('{treatmentRow["diagnosis"]}', '{treatmentRow["treatment"]}', '{treatmentRow["treatment_date"]}', {dischargeId})" + "returning discharge_treatment_id";
                            DataSet treatmentquery=dbclass.Getdata(insertTreatmentQuery);
                            int treatmentid = Convert.ToInt32(treatmentquery.Tables[0].Rows[0]["discharge_treatment_id"]);
                            // Fetch and move prescribed medicines
                            string medicineQuery = $"SELECT * FROM ipd_prescribed_medicine WHERE treatment_id={treatmentRow["treatment_id"]}";
                            DataSet medicineData = dbclass.Getdata(medicineQuery);

                            if (medicineData != null && medicineData.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow medicineRow in medicineData.Tables[0].Rows)
                                {
                                    string insertMedicineQuery = $"INSERT INTO discharge_prescribed_medicine (medicine_name, quantity, usage, discharge_treatment_id) " +
                                                                  $"VALUES ('{medicineRow["medicine_name"]}', '{medicineRow["quantity"]}', '{medicineRow["usage"]}', {treatmentid})";
                                    dbclass.databaseoperations(insertMedicineQuery);
                                }
                            }

                            // Delete from ipd_prescribed_medicine
                            string deleteMedicineQuery = $"DELETE FROM ipd_prescribed_medicine WHERE treatment_id={treatmentRow["treatment_id"]}";
                            dbclass.databaseoperations(deleteMedicineQuery);
                        }
                    }

                    // Delete from ipd_treatment_table
                    string deleteTreatmentQuery = $"DELETE FROM ipd_treatment_table WHERE ipd_id={ipdRow["ipd_id"]}";
                    dbclass.databaseoperations(deleteTreatmentQuery);

                    // Delete from ipd_table
                    string deleteIpdQuery = $"DELETE FROM ipd_table WHERE ipd_id={ipdRow["ipd_id"]}";
                    dbclass.databaseoperations(deleteIpdQuery);

                    MessageBox.Show("Patient discharged successfully!");
                    Discharged discharged = new Discharged();
                    AdmittedPatients patients = this.FindForm() as AdmittedPatients;
                    patients.ShowContent(discharged);
                }
                else
                {
                    MessageBox.Show("No IPD records found for the patient.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


    }
}
