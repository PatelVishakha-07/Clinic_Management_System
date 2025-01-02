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
        string str;

        public ShowMedicine(string s)
        {
            InitializeComponent();
            str = s;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (medicinegrid.Rows.Count == 1)
            {
                DateTime date = DateTime.Now;
                string formattedDate = date.ToString("yyyy-MM-dd");
                string query = "SELECT m.medicine_id, m.medicine_name, m.company_name, m.medicine_type, md.medicine_stock, " +
                               "md.expiry_date, md.purchase_price, md.sell_price " +
                               "FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                               "WHERE md.expiry_date > '" + formattedDate + "' AND CAST(md.medicine_stock AS INTEGER) > 0 " +
                               "ORDER BY medicine_name;";
                DataSet ds = dbClass.Getdata(query);
                populategridview(ds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string query;

            if (!string.IsNullOrEmpty(value))
            {
                // Build the query based on the input
                if (int.TryParse(value, out int stock))
                {
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE md.Medicine_Stock = {stock};";
                }
                else if (DateOnly.TryParse(value, out DateOnly expiryDate))
                {
                    string formattedDate = expiryDate.ToString("yyyy-MM-dd");
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE md.Expiry_Date = '{formattedDate}';";
                }
                else
                {
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE m.Medicine_Name LIKE '%{value}%' OR m.Company_Name LIKE '%{value}%';";
                }
            }
            else
            {
                // If the input is empty, fetch all records
                query = "SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                        "FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id;";
            }

            // Fetch and populate the data
            DataSet ds = dbClass.Getdata(query);
            populategridview(ds);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Manually trigger the search on button click (optional)
            textBox1_TextChanged(sender, e);
        }

        private void populategridview(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                medicinegrid.AutoGenerateColumns = false;
                medicinegrid.Columns["medicine_name"].DataPropertyName = "medicine_name";
                medicinegrid.Columns["company_name"].DataPropertyName = "company_name";
                medicinegrid.Columns["medicine_type"].DataPropertyName = "medicine_type";
                medicinegrid.Columns["medicine_stock"].DataPropertyName = "medicine_stock";
                medicinegrid.Columns["expiry_date"].DataPropertyName = "expiry_date";
                medicinegrid.Columns["purchase_price"].DataPropertyName = "purchase_price";
                medicinegrid.Columns["sell_price"].DataPropertyName = "sell_price";
                medicinegrid.DataSource = ds.Tables[0];

                if (!medicinegrid.Columns.Contains("Medicine_Id"))
                {
                    var idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Medicine_Id",
                        DataPropertyName = "Medicine_Id",
                        Visible = false
                    };
                    medicinegrid.Columns.Add(idColumn);
                }

                if (!medicinegrid.Columns.Contains("updateLink") && str == "Doctor")
                {
                    DataGridViewLinkColumn updateLink = new DataGridViewLinkColumn
                    {
                        HeaderText = "Action",
                        Name = "updateLink",
                        Text = "Update",
                        UseColumnTextForLinkValue = true,
                    };

                    medicinegrid.Columns.Add(updateLink);
                }
            }
        }

        private void medicinegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (str != "Receptionist")
            {
                if (e.ColumnIndex == medicinegrid.Columns["updateLink"].Index && e.RowIndex >= 0)
                {
                    // Ensure the Medicine_Id column is accessible for the update action
                    int medicineId = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Id"].Value);
                    string medicineName = medicinegrid.Rows[e.RowIndex].Cells["medicine_name"].Value.ToString();
                    string cmpName = medicinegrid.Rows[e.RowIndex].Cells["company_name"].Value.ToString();
                    string medType = medicinegrid.Rows[e.RowIndex].Cells["medicine_type"].Value.ToString();
                    int stock = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["medicine_stock"].Value);
                    string date = medicinegrid.Rows[e.RowIndex].Cells["expiry_date"].Value.ToString();
                    string purchase = medicinegrid.Rows[e.RowIndex].Cells["purchase_price"].Value.ToString();
                    string sell = medicinegrid.Rows[e.RowIndex].Cells["sell_price"].Value.ToString();

                    UpdateMedicine updateMedicine = new UpdateMedicine();
                    updateMedicine.getMedicineDetails(medicineId, medicineName, medType, cmpName, stock, date, purchase, sell);
                    Medicine medicine = this.FindForm() as Medicine;
                    updateMedicine.UpdateCompleted += (sender, e) =>
                    {
                        medicine.ShowControl(new ShowMedicine("Doctor"));
                    };
                    medicine.ShowControl(updateMedicine);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}