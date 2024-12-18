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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (medicinegrid.Rows.Count == 1)
            {
                DateTime date = DateTime.Now;
                string formattedDate = date.ToString("yyyy-MM-dd");
                string query = "select * from Medicines where expiry_date >= '" + formattedDate + "' and medicine_stock > " + 0;
                DataSet ds = dbClass.Getdata(query);
                populategridview(ds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string query;
            if (!string.IsNullOrEmpty(value))
            {

                if (int.TryParse(value, out int stock))
                {
                    query = $"select Medicine_Name,Company_Name,Medicine_Type,Medicine_Stock,Expiry_Date from Medicines where Medicine_Stock={int.Parse(value)};";
                }
                else if (DateOnly.TryParse(value, out DateOnly expiry_date))
                {
                    string formated_date = expiry_date.ToString("MM-dd-yyyy");
                    query = $"select Medicine_Name,Company_Name,Medicine_Type,Medicine_Stock,Expiry_Date from Medicines where Expiry_Date='{formated_date}';";
                }
                else
                {
                    query = $"select Medicine_Name,Company_Name,Medicine_Type,Medicine_Stock,Expiry_Date from Medicines where Medicine_Name='{value}' or Company_Name='{value}';";

                }

            }
            else
            {
                query = "select Medicine_Name,Company_Name,Medicine_Type,Medicine_Stock,Expiry_Date from Medicines;";
            }
            DataSet ds = dbClass.Getdata(query);
            populategridview(ds);
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

                if (!medicinegrid.Columns.Contains("updateLink"))
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
            if (e.ColumnIndex == medicinegrid.Columns["updateLink"].Index && e.RowIndex >= 0)
            {
                int medicineId = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Id"].Value.ToString());
                string medicineName = medicinegrid.Rows[e.RowIndex].Cells["Medicine_Name"].Value.ToString();
                string cmpName = medicinegrid.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                string medType = medicinegrid.Rows[e.RowIndex].Cells["Medicine_Type"].Value.ToString();
                int stock = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Stock"].Value.ToString());
                string date = medicinegrid.Rows[e.RowIndex].Cells["Expiry_Date"].Value.ToString();
                string purchase= medicinegrid.Rows[e.RowIndex].Cells["purchase_price"].Value.ToString();
                string sell= medicinegrid.Rows[e.RowIndex].Cells["sell_price"].Value.ToString();

                //int medicineId = 0;
                UpdateMedicine updateMedicine = new UpdateMedicine();
                updateMedicine.getMedicineDetails(medicineId, medicineName, cmpName, stock, date,medType,purchase,sell);
                Medicine medicine = this.FindForm() as Medicine;
                updateMedicine.UpdateCompleted += (sender, e) =>
                {
                    medicine.ShowControl(new ShowMedicine());
                };
                medicine.ShowControl(updateMedicine);
            }
        }

        private void label1_Click(object sender, EventArgs e)        {        }
    }
}
