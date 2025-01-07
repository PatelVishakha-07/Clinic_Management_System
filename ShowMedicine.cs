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
                DateTime date = DateTime.Now;
                string formattedDate = date.ToString("yyyy-MM-dd");
                // Build the query based on the input
                if (int.TryParse(value, out int stock))
                {
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.md_id,md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE md.Medicine_Stock = {stock} and  md.expiry_date > '" + formattedDate + "';";
                }
                else if (DateOnly.TryParse(value, out DateOnly expiryDate))
                {
                    string formattedDate1 = expiryDate.ToString("yyyy-MM-dd");
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type,md.md_id, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE md.Expiry_Date = '{formattedDate1}' and CAST(md.medicine_stock AS INTEGER) > 0;";
                }
                else
                {
                    query = $"SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type,md.md_id, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                            $"FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id " +
                            $"WHERE m.Medicine_Name LIKE '%{value}%' OR m.Company_Name LIKE '%{value}%' and md.expiry_date > '" + formattedDate + "' AND CAST(md.medicine_stock AS INTEGER) > 0 ";                           
                }
            }
            else
            {
                DateTime date = DateTime.Now;
                string formattedDate = date.ToString("yyyy-MM-dd");
                // If the input is empty, fetch all records
                query = "SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type,md.md_id, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                        "FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id WHERE md.expiry_date > '" + formattedDate + "' AND CAST(md.medicine_stock AS INTEGER) > 0";                             
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
                if (!medicinegrid.Columns.Contains("MD_ID"))
                {
                    var idColumn1 = new DataGridViewTextBoxColumn
                    {
                        Name = "Md_Id",
                        DataPropertyName = "md_id",
                        Visible = false
                    };
                    medicinegrid.Columns.Add(idColumn1);
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


                if (!medicinegrid.Columns.Contains("deletelink") && str == "Doctor")
                {
                    DataGridViewLinkColumn updateLink = new DataGridViewLinkColumn
                    {
                        HeaderText = "Action",
                        Name = "deletelink",
                        Text = "Delete",
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
                else if (e.ColumnIndex == medicinegrid.Columns["deletelink"].Index && e.RowIndex >= 0)
                {
                    int medicineId = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Id"].Value);
                    int batchId = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Md_Id"].Value);

                    // Check the number of related batches
                    string countQuery = $"select count(*) AS BatchCount from Medicine_Details WHERE medicine_id = {medicineId};";
                    DataSet ds1 = dbClass.Getdata(countQuery);

                    int batchCount = ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0
                        ? Convert.ToInt32(ds1.Tables[0].Rows[0]["BatchCount"])
                        : 0;

                    try
                    {
                        if (batchCount == 1)
                        {
                            // Delete related batch first
                            string deleteBatchQuery = $"DELETE FROM Medicine_Details WHERE medicine_id = {medicineId};";
                            dbClass.databaseoperations(deleteBatchQuery);

                            // Then delete the medicine
                            string deleteMedicineQuery = $"DELETE FROM Medicines WHERE medicine_id = {medicineId};";
                            dbClass.databaseoperations(deleteMedicineQuery);

                          //  MessageBox.Show("Medicine and its last batch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Delete only the batch
                            string deleteBatchQuery = $"DELETE FROM Medicine_Details WHERE md_id = {batchId};";
                            dbClass.databaseoperations(deleteBatchQuery);

                            MessageBox.Show("Batch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DateTime date = DateTime.Now;
                        string formattedDate = date.ToString("yyyy-MM-dd");
                        // Refresh the grid
                        string refreshQuery = "SELECT m.Medicine_Id, m.Medicine_Name, m.Company_Name, m.Medicine_Type, " +
                                              "md.Md_Id, md.Medicine_Stock, md.Expiry_Date, md.Purchase_Price, md.Sell_Price " +
                                              "FROM Medicines m JOIN Medicine_Details md ON m.medicine_id = md.medicine_id WHERE md.expiry_date > '" + formattedDate + "' AND CAST(md.medicine_stock AS INTEGER) > 0;";
                        DataSet ds = dbClass.Getdata(refreshQuery);
                        populategridview(ds);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}

//        private void label1_Click(object sender, EventArgs e) { }
//    }
//}