using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management_System
{
    public partial class AddPrescription : UserControl
    {
        int patient_id;
        databaseclass dbclass = new databaseclass();
        List<string> allMedicines = new List<string>();

        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy-MM-dd");
            string query = "SELECT m.medicine_id, m.medicine_name, m.company_name, m.medicine_type, " +
               "md.medicine_stock, md.expiry_date, md.purchase_price, md.sell_price, md.md_id " +
               "FROM Medicines m " +
               "JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
               "WHERE md.expiry_date > '" + formattedDate + "' " +
               "AND CAST(md.medicine_stock AS INTEGER) > 0 " +
               "AND md.expiry_date = (" +
                   "SELECT MIN(md2.expiry_date) " +
                   "FROM Medicine_Details md2 " +
                   "WHERE md2.medicine_id = m.medicine_id " +
                   "AND md2.expiry_date > '" + formattedDate + "' " +
                   "AND CAST(md2.medicine_stock AS INTEGER) > 0" +
               ") " +
               "ORDER BY m.medicine_name;";

            DataSet ds = dbclass.Getdata(query);
            allMedicines.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                allMedicines.Add(row["medicine_name"].ToString());
            }
            listMedicine.DataSource = new BindingSource(allMedicines, null);
        }

        public void getPatientDetails(int patient_id, string name, string address, int age, string contact, string gender)
        {
            this.patient_id = patient_id;
            txtName.Text = name;
            txtaddress.Text = address;
            txtAge.Text = age.ToString();
            txtContact.Text = contact;
            txtGender.Text = gender.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisease.Text) || string.IsNullOrEmpty(txtMedicine.Text) ||  string.IsNullOrEmpty(txtCharges.Text))
            {
                lbldisease.Visible = true;
            }
            else
            {
                lbldisease.Visible = false;
                DateTime date = System.DateTime.Now;
                string dateFormatted = date.ToString("yyyy-MM-dd HH:mm:ss").Replace("'", "''");
                string query = $"insert into Prescription(prescription_date,disease,prescription,patient_id,charges) values('{dateFormatted}','{txtDisease.Text}','{txtMedicine.Text}',{patient_id},{int.Parse(txtCharges.Text)})";
                dbclass.Getdata(query);
                string data = $"select * from Prescription where patient_id={patient_id} and prescription_date='{dateFormatted}'";
                DataSet ds = dbclass.Getdata(data);
                Prescriped_medicine prescriped_Medicine = new Prescriped_medicine("Prescription");
                //prescriped_Medicine.GetPrescriptionDetails(int.Parse(ds.Tables[0].Rows[0]["prescription_id"].ToString()), int.Parse(txtCharges.Text));
                Patients patients = this.FindForm() as Patients;
                patients.ShowContent(prescriped_Medicine);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicine.Text = string.Empty;
            txtDisease.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCharges_TextChanged(object sender, EventArgs e)
        {

        }

        private void listMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            var filtered = allMedicines
                .Where(m => m.ToLower().Contains(search))
                .ToList();

            listMedicine.DataSource = new BindingSource(filtered, null);
        }

        private void txtMedicine_Click(object sender, EventArgs e)
        {

        }

        private void listMedicine_Click(object sender, EventArgs e)
        {
            if (listMedicine.SelectedItem != null)
            {
                string selectedMedicine = listMedicine.SelectedItem.ToString();
                var lines = txtMedicine.Lines.ToList();

                // Prevent duplicates (optional)
                if (!lines.Contains(selectedMedicine))
                {
                    txtMedicine.AppendText(selectedMedicine + Environment.NewLine);
                }
            }
        }
    }
}
