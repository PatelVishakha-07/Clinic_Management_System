using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UpdateMedicine : UserControl
    {
        int medicineId;
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ShowControl(new ShowMedicine());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string medicineName=txtName.Text;
            string companyName=txtCmp.Text;
            int stock=Convert.ToInt32(txtStock.Text);
            string expiryDate = dateTimePicker1.Text;
            string query = "update Medicines set Medicine_Name= '" + medicineName + "', Company_Name= '" + companyName + 
                "', Medicine_Stock= " + stock + ", Expiry_Date= '" + expiryDate + "' where Medicine_Id= " + medicineId;
            databaseclass dbClass=new databaseclass();
            dbClass.databaseoperations(query);
            Medicine medicine=new Medicine();
            MessageBox.Show("Record Updated Successfully");
            medicine.ShowControl(new ShowMedicine());
        }

        public void getMedicineDetails(int medicineId, string medicineName, string companyName, int stock, string expiryDate) {
            this.medicineId=medicineId;
            txtName.Text = medicineName;
            txtCmp.Text= companyName;
            txtStock.Text = expiryDate;
            dateTimePicker1.Text = stock.ToString();
        }
    }
}
