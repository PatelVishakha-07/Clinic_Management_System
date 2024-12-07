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
    public partial class AddMedicine : UserControl
    {
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
            string query = "insert into Medicines(Medicine_Name, Company_Name, Medicine_Stock, Expiry_Date) values ('" + medicineName +
                "', '" + cmpName + "', " + stock + ", '" + date + "');";
            dbClass.databaseoperations(query);
            MessageBox.Show("Record Inserted Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
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
