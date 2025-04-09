using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Admit_Patient_Details : UserControl
    {
        int patientId, ipd_id;
        decimal updatedTotalPay, amount;
        databaseclass dbclass = new databaseclass();

        public Admit_Patient_Details(string role, int ipd_id)
        {
            InitializeComponent();
            this.ipd_id = ipd_id;

            if (role == "Receptionist")
            {
                btn_discharge.Enabled = false;
                btn_discharge.Visible = false;
                btn_add.Enabled = false;
                btn_add.Visible = false;
            }
        }

        public Admit_Patient_Details()
        {
            InitializeComponent();
        }

        public void getPatientDetails(int patientId)
        {
            this.patientId = patientId;
        }

        private void Admit_Patient_Details_Load(object sender, EventArgs e)
        {
            string patientQuery = $"SELECT * FROM patients WHERE patient_id = {patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 200;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", new[] { "patient_id" });

            string ipdQuery = $"SELECT * FROM ipd_table WHERE patient_id = {patientId}";
            DataSet ipdData = dbclass.Getdata(ipdQuery);

            if (ipdData != null && ipdData.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow ipdRow in ipdData.Tables[0].Rows)
                {
                    int ipd_id = Convert.ToInt32(ipdRow["ipd_id"]);
                    string treatmentQuery = $"SELECT * FROM ipd_treatment_table WHERE ipd_id = {ipd_id}";
                    DataSet treatments = dbclass.Getdata(treatmentQuery);

                    foreach (DataRow treatmentRow in treatments.Tables[0].Rows)
                    {
                        int treatment_id = Convert.ToInt32(treatmentRow["treatment_id"]);
                        string singleTreatmentQuery = $"SELECT * FROM ipd_treatment_table WHERE treatment_id = {treatment_id}";
                        DataSet treatmentDetails = dbclass.Getdata(singleTreatmentQuery);

                        currentY = DisplayData(treatmentDetails, panel1, currentY, "Prescription Details", new[] { "ipd_id", "treatment_id" });

                        string medicineQuery = $"SELECT * FROM ipd_prescribed_medicine WHERE treatment_id = {treatment_id}";
                        DataSet medicineData = dbclass.Getdata(medicineQuery);

                        currentY = DisplayData(medicineData, panel1, currentY + 20, "Prescribed Medicine", new[] { "pres_med_id", "treatment_id" });
                        currentY += 20;
                    }
                }
            }
            else
            {
                Label noPresLabel = new Label
                {
                    Text = "No prescriptions available.",
                    Location = new Point(40, currentY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noPresLabel);
                currentY += 35;
            }
        }

        private int DisplayData(DataSet ds, Panel panel, int startY, string title, string[] excludeColumns)
        {
            int spacing = 35, valueX = 300;

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    foreach (DataColumn col in ds.Tables[0].Columns)
                    {
                        if (excludeColumns != null && excludeColumns.Contains(col.ColumnName)) continue;

                        Label lblKey = new Label
                        {
                            Text = $"{col.ColumnName.ToUpper()}:",
                            Location = new Point(40, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold)
                        };

                        Label lblValue = new Label
                        {
                            Text = row[col].ToString(),
                            Location = new Point(valueX, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 12)
                        };

                        panel.Controls.Add(lblKey);
                        panel.Controls.Add(lblValue);
                        startY += spacing;
                    }
                }
            }
            else
            {
                Label noData = new Label
                {
                    Text = "No data available.",
                    Location = new Point(40, startY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel.Controls.Add(noData);
                startY += spacing;
            }

            return startY;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = $"SELECT ipd_id FROM ipd_table WHERE patient_id = {patientId}";
            DataSet ds = dbclass.Getdata(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                int ipd_id = Convert.ToInt32(ds.Tables[0].Rows[0]["ipd_id"]);
                Diagnosis diag = new Diagnosis(ipd_id);
                AdmittedPatients parentForm = this.FindForm() as AdmittedPatients;
                parentForm?.ShowContent(diag);
            }
        }

        public void Getcharge(decimal amount)
        {
            this.amount = amount;
        }

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            try
            {
                Discharge_Charge form = new Discharge_Charge(this);
                form.ShowDialog();

                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management"))
                {
                    conn.Open();
                    string updatePay = $"UPDATE ipd_table SET total_pay = COALESCE(total_pay, 0) + {amount} WHERE patient_id = {patientId} AND ipd_id = {ipd_id} RETURNING total_pay";
                    using (var cmd = new NpgsqlCommand(updatePay, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        updatedTotalPay = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }

                string insertProfit = $"INSERT INTO ipd_profit(profit_date, amount) VALUES('{DateTime.Now}', {amount})";
                dbclass.databaseoperations(insertProfit);

                ExecuteDischargeProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ExecuteDischargeProcess()
        {
            string ipdQuery = $"SELECT * FROM ipd_table WHERE patient_id = {patientId}";
            DataSet ipdData = dbclass.Getdata(ipdQuery);

            if (ipdData.Tables[0].Rows.Count > 0)
            {
                DataRow ipdRow = ipdData.Tables[0].Rows[0];
                string insertDischarge = $@"
    INSERT INTO discharged (bed_number, admit_date, total_pay, discharge_date, patient_id)
    VALUES ({ipdRow["bed_number"]}, '{ipdRow["admit_date"]}', {updatedTotalPay}, '{DateTime.Now}', {ipdRow["patient_id"]})
    RETURNING discharge_id";


                DataSet dischargeResult = dbclass.Getdata(insertDischarge);
                int dischargeId = Convert.ToInt32(dischargeResult.Tables[0].Rows[0]["discharge_id"]);

                string treatmentQuery = $"SELECT * FROM ipd_treatment_table WHERE ipd_id = {ipdRow["ipd_id"]}";
                DataSet treatmentData = dbclass.Getdata(treatmentQuery);

                foreach (DataRow tr in treatmentData.Tables[0].Rows)
                {
                    string insertTreatment = $@"
                        INSERT INTO discharge_treatment_table (diagnosis, treatment, treatment_date, discharge_id)
                        VALUES ('{tr["diagnosis"]}', '{tr["treatment"]}', '{tr["treatment_date"]}', {dischargeId})
                        RETURNING discharge_treatment_id";

                    DataSet treatResult = dbclass.Getdata(insertTreatment);
                    int dischargeTreatmentId = Convert.ToInt32(treatResult.Tables[0].Rows[0]["discharge_treatment_id"]);

                    string medicineQuery = $"SELECT * FROM ipd_prescribed_medicine WHERE treatment_id = {tr["treatment_id"]}";
                    DataSet medicineData = dbclass.Getdata(medicineQuery);

                    foreach (DataRow med in medicineData.Tables[0].Rows)
                    {
                        string insertMedicine = $@"
                            INSERT INTO discharge_prescribed_medicine (medicine_name, quantity, discharge_treatment_id)
                            VALUES ('{med["medicine_name"]}', '{med["quantity"]}', {dischargeTreatmentId})";
                        dbclass.databaseoperations(insertMedicine);
                    }

                    string deleteMedicine = $"DELETE FROM ipd_prescribed_medicine WHERE treatment_id = {tr["treatment_id"]}";
                    dbclass.databaseoperations(deleteMedicine);
                }

                string deleteTreatment = $"DELETE FROM ipd_treatment_table WHERE ipd_id = {ipdRow["ipd_id"]}";
                string deleteIpd = $"DELETE FROM ipd_table WHERE ipd_id = {ipdRow["ipd_id"]}";
                dbclass.databaseoperations(deleteTreatment);
                dbclass.databaseoperations(deleteIpd);

                MessageBox.Show("Patient discharged successfully!");
                Discharged discharged = new Discharged();
                AdmittedPatients form = this.FindForm() as AdmittedPatients;
                form?.ShowContent(discharged);
            }
        }
    }
}
