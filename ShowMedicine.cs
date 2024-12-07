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
    public partial class ShowMedicine : UserControl
    {
        databaseclass dbClass = new databaseclass();
        public ShowMedicine()
        {
            InitializeComponent();
            
        }

        private void ShowMedicine_Load(object sender, EventArgs e)
        {
            string query = "select Medicine_Name, Company_Name, Medicine_Stock, Expiry_Date from Medicines;";
            DataSet ds = new DataSet();
            ds = dbClass.Getdata(query);
            
            if (ds != null && ds.Tables.Count > 0 && ds.Tables.Contains("Medicines"))
            {
                ds.Tables[0].TableName = "Medicines";
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["Medicine_Name"].DataPropertyName = "Medicine_Name";
                dataGridView1.Columns["Company_Name"].DataPropertyName = "Company_Name";
                dataGridView1.Columns["Medicine_Stock"].DataPropertyName = "Medicine_Stock";
                dataGridView1.Columns["Expiry_Date"].DataPropertyName = "Expiry_Date";

                if (dataGridView1.Columns["updateLink"] == null) {
                    DataGridViewLinkColumn updateLink = new DataGridViewLinkColumn
                    {
                        HeaderText="Action",
                        Name = "updateLink",
                        Text = "Update",
                        UseColumnTextForLinkValue = true,
                    };

                    dataGridView1.Columns.Add(updateLink);
                    dataGridView1.DataSource = ds.Tables["Medicines"];
                    dataGridView1.Refresh();
                }

            }            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
