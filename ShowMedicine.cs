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
                string query = "select m.medicine_id, m.medicine_name, m.company_name, m.medicine_type, md.medicine_stock," +
                    " md.expiry_date, md.purchase_price, md.sell_price from Medicines m join Medicine_Details md on " +
                    "m.medicine_id = md.medicine_id where md.expiry_date > '" + formattedDate + "' and md.medicine_stock > " + 0;
                DataSet ds = dbClass.Getdata(query);
                populategridview(ds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)        {}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)        {}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string query;
            if (!string.IsNullOrEmpty(value))
            {

                if (int.TryParse(value, out int stock))
                {
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price" +
                        $", md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id" +
                        $" where md.Medicine_Stock={int.Parse(value)};";
                }
                else if (DateOnly.TryParse(value, out DateOnly expiry_date))
                {
                    string formated_date = expiry_date.ToString("MM-dd-yyyy");
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where md.Expiry_Date='{formated_date}';";
                }
                else
                {
                    query = $"select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                        $" md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id " +
                        $"where Medicine_Name='{value}' or Company_Name='{value}';";

                }

            }
            else
            {
                query = "select m.Medicine_Name, m.Company_Name, m.Medicine_Type, md.Medicine_Stock, md.Expiry_Date, md.purchase_price, " +
                    "md.sell_price from Medicines m join medicine_details md on m.medicine_id = md.medicine_id ;";
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
                    int medicineId = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Id"].Value.ToString());
                    string medicineName = medicinegrid.Rows[e.RowIndex].Cells["Medicine_Name"].Value.ToString();
                    string cmpName = medicinegrid.Rows[e.RowIndex].Cells["Company_Name"].Value.ToString();
                    string medType = medicinegrid.Rows[e.RowIndex].Cells["Medicine_Type"].Value.ToString();
                    int stock = Convert.ToInt32(medicinegrid.Rows[e.RowIndex].Cells["Medicine_Stock"].Value.ToString());
                    string date = medicinegrid.Rows[e.RowIndex].Cells["Expiry_Date"].Value.ToString();
                    string purchase = medicinegrid.Rows[e.RowIndex].Cells["purchase_price"].Value.ToString();
                    string sell = medicinegrid.Rows[e.RowIndex].Cells["sell_price"].Value.ToString();

                    //int medicineId = 0;
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

        private void label1_Click(object sender, EventArgs e)        {        }
    }
}
