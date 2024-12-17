using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Prescriped_medicine : UserControl
    {
        int prescription_id, medicine_qty;
        List<TextBox> medicineNameTextBoxes = new List<TextBox>();
        List<TextBox> quantityTextBoxes = new List<TextBox>();
        List<ComboBox> usageComboBoxes = new List<ComboBox>();
        List<ListBox> suggestionListBoxes = new List<ListBox>();
        databaseclass dbclass = new databaseclass();

        public Prescriped_medicine()
        {
            InitializeComponent();
        }

        public void GetPrescriptionDetails(int prescription_id, int medicine_qty)
        {
            this.prescription_id = prescription_id;
            this.medicine_qty = medicine_qty;
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
                    string queryStock = $"SELECT medicine_stock FROM Medicines WHERE medicine_name = '{medicineName}'";
                    DataSet ds = dbclass.Getdata(queryStock);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int availableStock = int.Parse(ds.Tables[0].Rows[0]["medicine_stock"].ToString());

                        if (availableStock >= quantity)
                        {
                            // Insert into Prescribed_Medicine
                            string queryInsert = $"INSERT INTO Prescribed_Medicine(medicine_name, quantity, usage, prescription_id) " +
                                                 $"VALUES('{medicineName}', {quantity}, '{usage}', {prescription_id})";
                            dbclass.databaseoperations(queryInsert);

                            // Update stock
                            string queryUpdateStock = $"UPDATE Medicines SET medicine_stock = medicine_stock - {quantity} " +
                                                      $"WHERE medicine_name = '{medicineName}'";
                            dbclass.databaseoperations(queryUpdateStock);

                        }
                        else
                        {
                            MessageBox.Show($"Not enough stock for {medicineName}.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{medicineName} not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
