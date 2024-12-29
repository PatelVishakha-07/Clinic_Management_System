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
        string medName, cpName, expDate, type, medPurchase, sell;
        int st;
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UpdateMedicine_Load(object sender, EventArgs e) { }

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
            lblPurchase.Text = "Purchase Price cannot be empty";
            lblSell.Text = "Sell Price cannot be empty";
            LabelVisisble();

            string medicineName = txtName.Text;
            string companyName = txtCmp.Text;
            string stock = txtStock.Text;
            string expiryDate = dateTimePicker1.Text;
            string purchase = txtPurchase.Text;
            string sell = txtSell.Text;
            string type=comboType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(companyName) && string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(purchase) && string.IsNullOrEmpty(sell))
            {
                LabelVisisble(true, true, true, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(companyName) && string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(purchase))
            {
                LabelVisisble(true, true, true, true);
            }
            else if (string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(companyName) && string.IsNullOrEmpty(stock))
            {
                LabelVisisble(true, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(companyName))
            {
                LabelVisisble(true, true);
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
            else if (string.IsNullOrEmpty(purchase))
            {
                lblPurchase.Visible = true;
            }
            else if (string.IsNullOrEmpty(sell))
            {
                lblSell.Visible = true;
            }
            else
            {
                LabelVisisble();
                lblName.Text = "Please enter Valid Medicine Name";
                lblCmp.Text = "Please enter Valid Company Name";
                lblStock.Text = "Please enter Valid Medicine Stock";
                lblPurchase.Text = "Please enter Valid Purchase Price";
                lblSell.Text = "Please enter Valid Sell Price";

                lblName.Visible = !Regex.IsMatch(medicineName, medicinePattern);
                lblCmp.Visible = !Regex.IsMatch(companyName, cmpPattern);
                lblStock.Visible = !Regex.IsMatch(stock, stockPattern);
                lblSell.Visible = !Regex.IsMatch(sell, stockPattern);
                lblPurchase.Visible = !Regex.IsMatch(purchase, stockPattern);

                if (!lblName.Visible && !lblCmp.Visible && !lblStock.Visible && !lblPurchase.Visible && !lblSell.Visible)
                {
                    string query = "update Medicines set Medicine_Name= '" + medicineName + "', Company_Name= '" + companyName +
                        "',  medicine_type='"+ type + "' where Medicine_Id= " + medicineId;

                    databaseclass dbClass = new databaseclass();
                    dbClass.databaseoperations(query);

                    string q2 = "update Medicine_Details set Medicine_Stock= '" + stock + "', Expiry_Date= '" + expiryDate + "', purchase_price=" + int.Parse(purchase) +
                        ", sell_price= " + int.Parse(sell) + " where Medicine_Id= " + medicineId;
                    dbClass.databaseoperations(q2);

                    Medicine medicine = new Medicine();
                    MessageBox.Show("Record Updated Successfully");
                    UpdateCompleted?.Invoke(this, EventArgs.Empty);
                }

            }
        }

        private void LabelVisisble(bool name = false, bool cmp = false, bool stock = false, bool purchase=false, bool sell=false)
        {
            lblName.Visible = name;
            lblCmp.Visible = cmp;
            lblStock.Visible = stock;
            lblPurchase.Visible = purchase;
            lblSell.Visible = sell;
        }

        public void getMedicineDetails(int medicineId, string medicineName, string medType, string companyName, int stock, string expiryDate, string pur, string medSell)
        {
            this.medicineId = medicineId;
            txtName.Text = medicineName;
            txtCmp.Text = companyName;
            txtStock.Text = stock.ToString();
            dateTimePicker1.Text = expiryDate;
            comboType.SelectedValue = medType;
            txtPurchase.Text = pur;
            txtSell.Text = medSell;
            medName = medicineName;
            cpName = companyName;
            st = stock;
            expDate = expiryDate;
           type = medType;
            medPurchase = pur;
            sell = medSell;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = medName;
            txtCmp.Text = cpName;
            txtStock.Text = st.ToString();
            dateTimePicker1.Text = expDate;
            comboType .SelectedItem = type;
            txtPurchase.Text = medPurchase;    
            txtSell.Text = sell;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
