using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class AddMedicine : UserControl
    {
        string cmpPattern = @"^[a-zA-Z0-9\s\.\-]+$";
        string medicinePattern = @"^[a-zA-Z0-9\s\-\(\)]+$";
        string stockPattern = @"^\d+$";
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblName.Text = "Medicine Name Cannot be empty";
            lblCmp.Text = "Company Name Cannot be empty";
            lblStock.Text = "Medicine Stock Cannot be empty";
            LabelVisisble();
            databaseclass dbClass = new databaseclass();
            string medicineName = txtName.Text;
            string cmpName = txtCmp.Text;
            string stock = txtStock.Text;
            string date = dateTimePicker1.Text;
            string type=comboType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName) && string.IsNullOrEmpty(stock))
            {
                LabelVisisble(true, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName))
            {
                LabelVisisble(true, true, false);
            }
            else if (string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(cmpName))
            {
                LabelVisisble(false, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName))
            {
                lblName.Visible = true;
            }
            else if (string.IsNullOrEmpty(cmpName))
            {
                lblCmp.Visible = true;
            }
            else if (string.IsNullOrEmpty(stock))
            {
                lblStock.Visible = true;
            }
            else
            {
                LabelVisisble();
                lblName.Text = "Please enter Valid Medicine Name";
                lblCmp.Text = "Please enter Valid Company Name";
                lblStock.Text = "Please enter Valid Medicine Stock";

                lblName.Visible = !Regex.IsMatch(medicineName, medicinePattern);
                lblCmp.Visible = !Regex.IsMatch(cmpName, cmpPattern);
                lblStock.Visible = !Regex.IsMatch(stock, stockPattern);

                if (!lblName.Visible && !lblCmp.Visible && !lblStock.Visible)
                {
                    string query = "insert into Medicines(medicine_name, company_name,medicine_type, medicine_stock, expiry_date) values ('" + medicineName +
                "', '" + cmpName + "', '" + type + "', " + int.Parse(stock) + ", '" + date + "');";
                    dbClass.databaseoperations(query);
                    MessageBox.Show("Record Inserted Successfully");
                    ClearText();
                    Medicine medicine = new Medicine();
                    medicine.ShowControl(new ShowMedicine());
                }


            }

        }


        private void LabelVisisble(bool name = false, bool cmp = false, bool stock = false)
        {
            lblName.Visible = name;
            lblCmp.Visible = cmp;
            lblStock.Visible = stock;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            txtName.Text = "";
            txtCmp.Text = "";
            txtStock.Text = "";
            comboType.SelectedItem = "Strips";
            dateTimePicker1.Text = DateTime.Today.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ShowControl(new ShowMedicine());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
