using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class AddPrescription : UserControl
    {
        int patient_id;
        databaseclass dbclass = new databaseclass();
        List<string> allMedicines = new List<string>();
        DataTable prescriptionTable = new DataTable(); // For DataGridView

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
                   "AND CAST(md2.medicine_stock AS BIGINT) > 0" +
               ") " +
               "ORDER BY m.medicine_name;";

            DataSet ds = dbclass.Getdata(query);
            allMedicines.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                allMedicines.Add(row["medicine_name"].ToString());
            }
            listMedicine.DataSource = new BindingSource(allMedicines, null);

            // Setup DataGridView columns
            prescriptionTable.Columns.Add("Medicine", typeof(string));
            prescriptionTable.Columns.Add("Quantity", typeof(int));
            dataGridView1.DataSource = prescriptionTable;

            // Add remove button
            if (!dataGridView1.Columns.Contains("Remove"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Action";
                btn.Name = "Remove";
                btn.Text = "Remove";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }

            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["Medicine"].ReadOnly = true;
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
            if (string.IsNullOrWhiteSpace(txtDisease.Text) || string.IsNullOrWhiteSpace(txtCharges.Text) || prescriptionTable.Rows.Count == 0)
            {
                MessageBox.Show("Please fill disease, charges, and add at least one medicine.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCharges.Text, out decimal charges) || charges < 0)
            {
                MessageBox.Show("Enter valid charges.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in prescriptionTable.Rows)
            {
                if (!int.TryParse(row["Quantity"].ToString(), out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Medicine quantity cannot be 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Step 2: Check stock for each medicine
            foreach (DataRow row in prescriptionTable.Rows)
            {
                string medicineName = row["Medicine"].ToString();
                int requestedQty = int.Parse(row["Quantity"].ToString());

                string queryStock = $@"
SELECT SUM(CAST(medicine_stock AS BIGINT)) 
FROM Medicine_Details 
WHERE medicine_id = (SELECT medicine_id FROM Medicines WHERE medicine_name = '{medicineName}')
AND expiry_date > '{DateTime.Now:yyyy-MM-dd}'";

                DataSet dsStock = dbclass.Getdata(queryStock);
                int totalAvailableStock = dsStock.Tables[0].Rows[0][0] != DBNull.Value
                    ? Convert.ToInt32(dsStock.Tables[0].Rows[0][0])
                    : 0;

                if (requestedQty > totalAvailableStock)
                {
                    MessageBox.Show($"Not enough stock for {medicineName}. Requested: {requestedQty}, Available: {totalAvailableStock}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Step 3: Insert Prescription
            decimal med_price = 0, ttl_pres_charges = 0, profit = 0;

            string dateFormatted = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string insertPrescriptionQuery = $"INSERT INTO Prescription(prescription_date, disease, patient_id, charges) " +
                                             $"VALUES('{dateFormatted}', '{txtDisease.Text}', {patient_id}, {charges});";
            dbclass.databaseoperations(insertPrescriptionQuery);

            string getPresIdQuery = $"SELECT MAX(prescription_id) FROM Prescription WHERE patient_id = {patient_id}";
            DataSet presIdDS = dbclass.Getdata(getPresIdQuery);
            int prescription_id = Convert.ToInt32(presIdDS.Tables[0].Rows[0][0]);

            foreach (DataRow row in prescriptionTable.Rows)
            {
                string medicineName = row["Medicine"].ToString();
                int quantity = int.Parse(row["Quantity"].ToString());

                string queryStock = $@"
SELECT medicine_stock, Expiry_Date, purchase_price, sell_price 
FROM Medicine_details 
WHERE medicine_id = (SELECT medicine_id FROM Medicines WHERE medicine_name = '{medicineName}')
AND expiry_date > '{DateTime.Now:yyyy-MM-dd}'
ORDER BY Expiry_Date ASC";
                

                DataSet ds = dbclass.Getdata(queryStock);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    int remainingQuantity = quantity;
                    foreach (DataRow stockRow in ds.Tables[0].Rows)
                    {
                        int availableStock = int.Parse(stockRow["medicine_stock"].ToString());
                        DateTime expiryDate = DateTime.Parse(stockRow["Expiry_Date"].ToString());
                        decimal purchase_price = Convert.ToDecimal(stockRow["purchase_price"]);
                        decimal sell_price = Convert.ToDecimal(stockRow["sell_price"]);

                        int quantityToDeduct = Math.Min(remainingQuantity, availableStock);

                        if (quantityToDeduct > 0)
                        {
                            string insertMedQuery = $@"INSERT INTO Prescribed_Medicine (medicine_name, quantity, prescription_id) 
VALUES ('{medicineName}', {quantityToDeduct}, {prescription_id})";
                            dbclass.databaseoperations(insertMedQuery);

                            string updateStockQuery = $@" UPDATE Medicine_details 
                        SET medicine_stock = CAST(medicine_stock AS BIGINT) - {quantityToDeduct}
                        WHERE medicine_id = (SELECT medicine_id FROM Medicines WHERE medicine_name = '{medicineName}')
                        AND Expiry_Date = '{expiryDate:yyyy-MM-dd}'";

                            dbclass.databaseoperations(updateStockQuery);

                            med_price += ((sell_price - purchase_price) * quantityToDeduct);
                            ttl_pres_charges += (sell_price * quantityToDeduct);
                        }

                        remainingQuantity -= quantityToDeduct;
                        if (remainingQuantity <= 0)
                            break;
                    }
                }
            }

            ttl_pres_charges += charges;
            profit = charges + med_price;

            string updatePres = $"UPDATE Prescription SET total_charge = {ttl_pres_charges} WHERE prescription_id = {prescription_id}";
            dbclass.databaseoperations(updatePres);

            string profitQuery = $"INSERT INTO profit (profit_date, amount) VALUES ('{DateTime.Now}', {profit})";
            dbclass.databaseoperations(profitQuery);

            MessageBox.Show("Prescription saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            ShowPatients details = new ShowPatients();
            Parent.Controls.Add(details);
            details.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisease.Text = string.Empty;
            prescriptionTable.Rows.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            var filtered = allMedicines
                .Where(m => m.ToLower().Contains(search))
                .ToList();

            listMedicine.DataSource = new BindingSource(filtered, null);
        }

        private void listMedicine_Click(object sender, EventArgs e)
        {
            if (listMedicine.SelectedItem != null)
            {
                string selectedMedicine = listMedicine.SelectedItem.ToString();

                foreach (DataRow row in prescriptionTable.Rows)
                {
                    if (row["Medicine"].ToString() == selectedMedicine)
                        return;
                }

                DataRow newRow = prescriptionTable.NewRow();
                newRow["Medicine"] = selectedMedicine;
                newRow["Quantity"] = 0;
                prescriptionTable.Rows.Add(newRow);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Remove"].Index)
            {
                prescriptionTable.Rows[e.RowIndex].Delete();
            }
        }

        // Unused event handlers
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void txtCharges_TextChanged(object sender, EventArgs e) { }
        private void listMedicine_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMedicine_Click(object sender, EventArgs e) { }
        private void txtMedicine_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
    }
}
