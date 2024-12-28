using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Clinic_Management_System
{
    public partial class Prescriped_medicine : UserControl
    {
        int prescription_id, medicine_qty, charges, purchase_price, sell_price, profit, med_price, ttl_pres_charges, patient_id;
        string dialog;
        List<TextBox> medicineNameTextBoxes = new List<TextBox>();
        List<TextBox> quantityTextBoxes = new List<TextBox>();
        List<ComboBox> usageComboBoxes = new List<ComboBox>();
        List<ListBox> suggestionListBoxes = new List<ListBox>();
        databaseclass dbclass = new databaseclass();

        public Prescriped_medicine(string dialog)
        {
            InitializeComponent();
            this.dialog = dialog;
        }

        public void GetPrescriptionDetails(int prescription_id, int medicine_qty, int charges, int patient_id = 0)
        {
            this.prescription_id = prescription_id;
            this.medicine_qty = medicine_qty;
            this.charges = charges;
            this.patient_id = patient_id;
            GenerateDynamicControls();
        }

        private void GenerateDynamicControls()
        {
            // Clear any existing controls
            this.Controls.Clear();
            medicineNameTextBoxes.Clear();
            quantityTextBoxes.Clear();
            usageComboBoxes.Clear();
            suggestionListBoxes.Clear();

            // Title label
            Label lblTitle = new Label
            {
                Text = "Prescribe Medicines",
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(20, 10),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            int startY = 50; // Starting position for dynamic controls

            for (int i = 0; i < medicine_qty; i++)
            {
                // Medicine Name Label
                Label lblMedicineName = new Label
                {
                    Text = $"Medicine Name {i + 1}:",
                    Location = new System.Drawing.Point(20, startY),
                    AutoSize = true
                };
                this.Controls.Add(lblMedicineName);

                // Medicine Name TextBox
                TextBox txtMedicineName = new TextBox
                {
                    Name = $"txtMedicineName{i}",
                    Location = new System.Drawing.Point(150, startY),
                    Width = 150
                };
                this.Controls.Add(txtMedicineName);
                medicineNameTextBoxes.Add(txtMedicineName);

                // ListBox for suggestions
                ListBox listBoxSuggestions = new ListBox
                {
                    Location = new System.Drawing.Point(150, startY + 25),
                    Width = 150,
                    Height = 80,
                    Visible = false
                };
                this.Controls.Add(listBoxSuggestions);
                suggestionListBoxes.Add(listBoxSuggestions);

                txtMedicineName.TextChanged += (sender, e) => OnMedicineNameTextChanged(sender, listBoxSuggestions);
                listBoxSuggestions.SelectedIndexChanged += (sender, e) => OnSuggestionSelected(sender, txtMedicineName);

                // Quantity Label
                Label lblQuantity = new Label
                {
                    Text = "Quantity:",
                    Location = new System.Drawing.Point(320, startY),
                    AutoSize = true
                };
                this.Controls.Add(lblQuantity);

                // Quantity TextBox
                TextBox txtQuantity = new TextBox
                {
                    Name = $"txtQuantity{i}",
                    Location = new System.Drawing.Point(390, startY),
                    Width = 50
                };
                this.Controls.Add(txtQuantity);
                quantityTextBoxes.Add(txtQuantity);

                // Usage Label
                Label lblUsage = new Label
                {
                    Text = "Usage:",
                    Location = new System.Drawing.Point(460, startY),
                    AutoSize = true
                };
                this.Controls.Add(lblUsage);

                // Usage ComboBox
                ComboBox comboUsage = new ComboBox
                {
                    Name = $"comboUsage{i}",
                    Location = new System.Drawing.Point(520, startY),
                    Width = 80
                };
                comboUsage.Items.AddRange(new string[] { "OD", "BD", "TD", "QD" });
                comboUsage.SelectedIndex = 0; // Default selection
                this.Controls.Add(comboUsage);
                usageComboBoxes.Add(comboUsage);

                startY += 90; // Adjust Y position for the next set of controls
            }

            // Save Button
            Button btnSave = new Button
            {
                Text = "Save",
                Location = new System.Drawing.Point(20, startY + 20),
                Width = 80
            };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);
        }

        private void OnMedicineNameTextChanged(object sender, ListBox listBoxSuggestions)
        {
            TextBox txtBox = sender as TextBox;
            string query = "SELECT medicine_name FROM Medicines WHERE medicine_name LIKE @value";

            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;"))
                {
                    conn.Open();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@value", "%" + txtBox.Text + "%");
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    listBoxSuggestions.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        listBoxSuggestions.Items.Add(row["medicine_name"]);
                    }
                    listBoxSuggestions.Visible = ds.Tables[0].Rows.Count > 0;
                }
            }
            else
            {
                listBoxSuggestions.Visible = false;
            }
        }

        private void OnSuggestionSelected(object sender, TextBox txtMedicineName)
        {
            ListBox listBox = sender as ListBox;
            txtMedicineName.Text = listBox.SelectedItem.ToString();
            listBox.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < medicine_qty; i++)
            {
                string medicineName = medicineNameTextBoxes[i].Text;
                string quantityText = quantityTextBoxes[i].Text;
                string usage = usageComboBoxes[i].SelectedItem.ToString();

                if (!string.IsNullOrEmpty(medicineName) && int.TryParse(quantityText, out int quantity))
                {
                    string queryStock = $@"
                SELECT medicine_stock, Expiry_Date, purchase_price, sell_price 
                FROM Medicine_details 
                WHERE medicine_id = (SELECT medicine_id FROM Medicines WHERE medicine_name = '{medicineName}')
                ORDER BY Expiry_Date ASC";
                    DataSet ds = new DataSet();
                    try
                    {
                        ds = dbclass.Getdata(queryStock);
                    }
                    catch (Exception ex)
                    {
                        ds = null;
                        MessageBox.Show("Different data for a same medicine found");
                    }
                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            int remainingQuantity = quantity;
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                int availableStock = int.Parse(row["medicine_stock"].ToString());
                                DateTime expiryDate = DateTime.Parse(row["Expiry_Date"].ToString());
                                purchase_price = Convert.ToInt32(row["purchase_price"]);
                                sell_price = Convert.ToInt32(row["sell_price"]);

                                if (DateTime.Now >=expiryDate)
                                {
                                    MessageBox.Show($"The medicine {medicineName} (Expiry: {expiryDate.ToShortDateString()}) has expired.", "Expiry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }

                                if (remainingQuantity > 0 && availableStock > 0)
                                {
                                    int quantityToDeduct = Math.Min(remainingQuantity, availableStock);
                                    remainingQuantity -= quantityToDeduct;

                                    // Insert prescribed medicine record
                                    string queryInsert;
                                    if (dialog == "Prescription")
                                    {
                                        queryInsert = $@"INSERT INTO Prescribed_Medicine (medicine_name, quantity, usage, prescription_id)  VALUES ('{medicineName}', {quantityToDeduct}, '{usage}', {prescription_id})";
                                        
                                    }
                                    else
                                    {
                                        queryInsert = $"insert into ipd_prescribed_medicine(medicine_name,quantity,usage,treatment_id) values ('{medicineName}', {quantityToDeduct}, '{usage}', {prescription_id})";
                                       
                                    }
                                    dbclass.databaseoperations(queryInsert);
                                    MessageBox.Show("Medicine Added");
                                    // Update stock
                                    string queryUpdateStock = $@"
                            UPDATE Medicine_details 
                            SET medicine_stock = medicine_stock - {quantityToDeduct} 
                            WHERE medicine_id = (SELECT medicine_id FROM Medicines WHERE medicine_name = '{medicineName}')
                            AND Expiry_Date = '{expiryDate:yyyy-MM-dd}'";
                                    dbclass.databaseoperations(queryUpdateStock);

                                    // Calculate profit and charges
                                    med_price += ((sell_price - purchase_price) * quantityToDeduct);
                                    ttl_pres_charges += (sell_price * quantityToDeduct);

                                    if (remainingQuantity == 0)
                                        break;
                                }
                            }

                            if (remainingQuantity > 0)
                            {
                                MessageBox.Show($"Not enough stock for {medicineName}. Remaining Quantity: {remainingQuantity}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"{medicineName} not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            profit = charges + med_price;
            ttl_pres_charges += charges;
            string pres_query;
            if (dialog == "Prescription")
            {
                pres_query = $"UPDATE prescription SET total_charge = {ttl_pres_charges} WHERE prescription_id = {prescription_id}";
                dbclass.databaseoperations(pres_query);
                string profitQuery = $"INSERT INTO profit (profit_date, amount) VALUES ('{DateTime.Now}', {profit})";
                dbclass.databaseoperations(profitQuery);
            }
            else
            {


                pres_query = $" UPDATE ipd_table SET total_pay = COALESCE(total_pay, 0) + {ttl_pres_charges} WHERE patient_id = {patient_id};";
                dbclass.databaseoperations(pres_query);
                string profitQuery = $"INSERT INTO ipd_profit (profit_date, amount) VALUES ('{DateTime.Now}', {profit})";
                dbclass.databaseoperations(profitQuery);
            }


            
            this.Hide();
            if (dialog == "Prescription")
            {
                ShowPatients details = new ShowPatients();
                Parent.Controls.Add(details);
                details.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                ShowAdmittedPatient details = new ShowAdmittedPatient("Doctor");
                Parent.Controls.Add(details);
                details.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
                this.Dispose();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

        }
    }
}