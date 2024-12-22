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
    public partial class Exp_Out_Medicines : UserControl
    {
        string st;
        databaseclass dbClass = new databaseclass();
        public Exp_Out_Medicines(string str)
        {
            InitializeComponent();
            st = str;
        }

        private void Exp_Out_Medicines_Load(object sender, EventArgs e)
        {
            if (st == "expire")
            {
                ExpiredMedicine();
            }
            else if (st == "out of stock")
            {
                OutOfStock();
            }
        }
        private void ExpiredMedicine()
        {
            label1.Text = "Expired Medicines";
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy-MM-dd");
            string q = "select m.medicine_id, m.medicine_name, m.company_name, m.medicine_type, md.medicine_stock, md.expiry_date, md.purchase_price" +
                ", md.sell_price from medicines m join medicine_details md on m.medicine_id = md.medicine_id where md.expiry_date < '" + formattedDate + "'";

            DataSet ds = dbClass.Getdata(q);
            PopulateGridView(ds);
        }

        private void OutOfStock()
        {
            label1.Text = "Out Of Stock Medicines";
            string q = "select m.medicine_id,m.medicine_name, m.company_name, m.medicine_type, md.medicine_stock, md.expiry_date, md.purchase_price" +
                ", md.sell_price from medicines m join medicine_details md on m.medicine_id = md.medicine_id where md.medicine_stock=" + 0;

            DataSet ds = dbClass.Getdata(q);
            PopulateGridView(ds);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                int medicineId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Medicine_Id"].Value.ToString());
                string query = "delete from medicine_details where medicine_id=" + medicineId;
                databaseclass dbClass = new databaseclass();
                dbClass.databaseoperations(query);
                string q2 = "delete from medicines where medicine_id=" + medicineId;
                dbClass.databaseoperations(q2);
                MessageBox.Show("Record Deleted Successfully");
                if (st == "expire")
                {
                    ExpiredMedicine();
                }
                else if (st == "out of stock")
                {
                    OutOfStock();
                }
            }
        }

        private void PopulateGridView(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["medicine_name"].DataPropertyName = "medicine_name";
                dataGridView1.Columns["company_name"].DataPropertyName = "company_name";
                dataGridView1.Columns["medicine_type"].DataPropertyName = "medicine_type";
                dataGridView1.Columns["medicine_stock"].DataPropertyName = "medicine_stock";
                dataGridView1.Columns["expiry_date"].DataPropertyName = "expiry_date";
                dataGridView1.DataSource = ds.Tables[0];

                if (!dataGridView1.Columns.Contains("Medicine_Id"))
                {
                    var idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Medicine_Id",
                        DataPropertyName = "Medicine_Id",
                        Visible = false
                    };
                    dataGridView1.Columns.Add(idColumn);
                }

                if (!dataGridView1.Columns.Contains("delete"))
                {
                    DataGridViewLinkColumn delete = new DataGridViewLinkColumn
                    {
                        HeaderText = "Action",
                        Name = "delete",
                        Text = "Delete",
                        UseColumnTextForLinkValue = true,
                    };

                    dataGridView1.Columns.Add(delete);
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (st == "expire")
            {
                ExpiredMedicineSearch();
            }
            else if (st == "out of stock")
            {
                OutOfStockSearch();
            }
        }

        private void ExpiredMedicineSearch()
        {
            string value = txtSearch.Text;
            string query;
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy-MM-dd");
            if (!string.IsNullOrEmpty(value))
            {

                if (int.TryParse(value, out int stock))
                {
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price" +
                        $", md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id" +
                        $" where md.medicine_stock ={int.Parse(value)} and md.expiry_date < '" + formattedDate + "';";
                }
                else if (DateOnly.TryParse(value, out DateOnly expiry_date))
                {
                    string formated_date = expiry_date.ToString("MM-dd-yyyy");
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where md.Expiry_Date='{formated_date}' and md.expiry_date < '" + formattedDate + "';";
                }
                else
                {
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where Medicine_Name='{value}' or Company_Name='{value}' and md.expiry_date < '" + formattedDate + "';";

                }

            }
            else
            {
                query = "select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                    "md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id and md.expiry_date < '" + formattedDate + "';";
            }
            DataSet ds = dbClass.Getdata(query);
            PopulateGridView(ds);
        }

        private void OutOfStockSearch()
        {
            string value = txtSearch.Text;
            string query;
            if (!string.IsNullOrEmpty(value))
            {

                if (DateOnly.TryParse(value, out DateOnly expiry_date))
                {
                    string formated_date = expiry_date.ToString("MM-dd-yyyy");
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where md.Expiry_Date='{formated_date}' and md.medicine_stock=0;";
                }
                else
                {
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where Medicine_Name='{value}' or Company_Name='{value}' and md.medicine_stock=0;";

                }

            }
            else
            {
                query = "select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                    "md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id and md.medicine_stock=0;";
            }
            DataSet ds = dbClass.Getdata(query);
            PopulateGridView(ds);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
