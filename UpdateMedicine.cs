using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UpdateMedicine : UserControl
    {
        public event EventHandler UpdateCompleted;
        int medicineId;
        string cmpPattern = @"^[a-zA-Z0-9\s\.\-]+$";
        string medicinePattern = @"^[a-zA-Z0-9\s\-\(\)]+$";
        string stockPattern = @"^\d+$";
        string medName, cpName, expDate;
        int st;
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UpdateMedicine_Load(object sender, EventArgs e) {        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            UpdateCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblName.Text = "Medicine Name Cannot be empty";
            lblCmp.Text = "Company Name Cannot be empty";
            lblStock.Text = "Medicine Stock Cannot be empty";
            LabelVisisble();

            string medicineName = txtName.Text;
            string companyName = txtCmp.Text;
            string stock = txtStock.Text;
            string expiryDate = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(companyName) && string.IsNullOrEmpty(stock))
            {
                LabelVisisble(true, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(companyName))
            {
                LabelVisisble(true, true, false);
            }
            else if (string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(companyName))
            {
                LabelVisisble(false, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName))
            {
                lblName.Visible = true;
            }
            else if (string.IsNullOrEmpty(companyName))
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
                lblCmp.Visible = !Regex.IsMatch(companyName, cmpPattern);
                lblStock.Visible = !Regex.IsMatch(stock, stockPattern);

                if (!lblName.Visible && !lblCmp.Visible && !lblStock.Visible)
                {
                    string query = "update Medicines set Medicine_Name= '" + medicineName + "', Company_Name= '" + companyName +
                        "', Medicine_Stock= " + stock + ", Expiry_Date= '" + expiryDate + "' where Medicine_Id= " + medicineId;
                    databaseclass dbClass = new databaseclass();
                    dbClass.databaseoperations(query);
                    Medicine medicine = new Medicine();
                    MessageBox.Show("Record Updated Successfully");
                    UpdateCompleted?.Invoke(this, EventArgs.Empty);                    
                }

            }
        }

        private void LabelVisisble(bool name = false, bool cmp = false, bool stock = false)
        {
            lblName.Visible = name;
            lblCmp.Visible = cmp;
            lblStock.Visible = stock;
        }

        public void getMedicineDetails(int medicineId, string medicineName, string companyName, int stock, string expiryDate)
        {
            this.medicineId = medicineId;
            txtName.Text = medicineName;
            txtCmp.Text = companyName;
            txtStock.Text = stock.ToString();
            dateTimePicker1.Text = expiryDate;
            medName= medicineName;
            cpName=companyName;
            st=stock;
            expDate=expiryDate;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text= medName;
            txtCmp.Text= cpName;
            txtStock.Text = st.ToString();
            dateTimePicker1.Text= expDate;
        }
    }
}
