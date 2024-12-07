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
            databaseclass dbClass = new databaseclass();
            string medicineName = txtName.Text;
            string cmpName = txtCmp.Text;
            int stock = Convert.ToInt32(txtStock.Text);
            string date = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(medicineName))
            {
                lblName.Visible = true;
            }
            else if (string.IsNullOrEmpty(cmpName))
            {
                lblCmp.Visible = true;
            }
            else if (string.IsNullOrEmpty(stock.ToString()))
            {
                lblStock.Visible = true;
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName) && string.IsNullOrEmpty(stock.ToString())) {
                LabelVisisble(true);
            }
            else
            {
                LabelVisisble(false);
                lblName.Text = "Please enter Valid Medicine Name";
                lblCmp.Text = "Please enter Valid Company Name";
                lblStock.Text = "Please enter Valid Medicine Stock";

                lblName.Visible = !Regex.IsMatch(medicineName, medicinePattern);
                lblCmp.Visible = !Regex.IsMatch(cmpName, cmpPattern);
                lblStock.Visible = !Regex.IsMatch(stock.ToString(), stockPattern);

                if (!lblName.Visible && !lblCmp.Visible && !lblStock.Visible)
                {
                    string query = "insert into Medicines(Medicine_Name, Company_Name, Medicine_Stock, Expiry_Date) values ('" + medicineName +
                "', '" + cmpName + "', " + stock + ", '" + date + "');";
                    dbClass.databaseoperations(query);
                    MessageBox.Show("Record Inserted Successfully");
                    ClearText();
                    Medicine medicine = new Medicine();
                    medicine.ShowControl(new ShowMedicine());
                }


            }
           
        }        

        private void LabelVisisble(bool boolValue)
        {
            lblName.Visible = boolValue;
            lblCmp.Visible = boolValue;
            lblStock.Visible = boolValue;
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
            dateTimePicker1.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ShowControl(new ShowMedicine());
        }

        
    }
}
