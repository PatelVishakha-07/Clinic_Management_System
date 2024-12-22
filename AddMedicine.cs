using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class AddMedicine : UserControl
    {
        string cmpPattern = @"^[a-zA-Z0-9\s\.\-]+$";
        string medicinePattern = @"^[a-zA-Z0-9\s\-\(\)]+$";
        string stockPattern = @"^\d+$";
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
            lblName.Text = "Medicine Name Cannot be empty";
            lblCmp.Text = "Company Name Cannot be empty";
            lblStock.Text = "Medicine Stock Cannot be empty";
            lblPurchase.Text = "Purchase Price cannot be empty";
            lblSell.Text = "Sell Price cannot be empty";

            LabelVisisble();
            databaseclass dbClass = new databaseclass();
            string medicineName = txtName.Text;
            string cmpName = txtCmp.Text;
            string stock = txtStock.Text;
            string date = dateTimePicker1.Text;
            string type = comboType.SelectedItem?.ToString();
            string purchase=txtPurchase.Text;
            string sell = txtSell.Text;

            if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName) && string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(purchase) && string.IsNullOrEmpty(sell))
            {
                LabelVisisble(true, true, true,true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName) && string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(purchase))
            {
                LabelVisisble(true, true, true,true);
            }
            else if (string.IsNullOrEmpty(stock) && string.IsNullOrEmpty(cmpName) && string.IsNullOrEmpty(stock))
            {
                LabelVisisble(true, true, true);
            }
            else if (string.IsNullOrEmpty(medicineName) && string.IsNullOrEmpty(cmpName))
            {
                LabelVisisble(true, true);
            }
            else if (string.IsNullOrEmpty(medicineName))
            {
                lblName.Visible = true;
            }
            else if (string.IsNullOrEmpty(cmpName))
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
                lblCmp.Visible = !Regex.IsMatch(cmpName, cmpPattern);
                lblStock.Visible = !Regex.IsMatch(stock, stockPattern);
                lblSell.Visible = !Regex.IsMatch(sell, stockPattern);
                lblPurchase.Visible = !Regex.IsMatch(purchase, stockPattern);

                if (!lblName.Visible && !lblCmp.Visible && !lblStock.Visible && !lblPurchase.Visible && !lblSell.Visible)
                {
                    string medicineDetails = "select * from medicines where medicine_name='"+ medicineName + "' and company_name='" + 
                        cmpName + "' and medicine_type='"+ type +"'";
                    DataSet ds=new DataSet();
                    ds = dbClass.Getdata(medicineDetails);
                    
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        int medID = Convert.ToInt32(ds.Tables[0].Rows[0]["medicine_id"].ToString());
                        string q2 = "insert into Medicine_Details(medicine_stock, expiry_date, purchase_price, sell_price, medicine_id) values(" +
                            int.Parse(stock) + ", '" + date + "', " + int.Parse(purchase) + ", " + int.Parse(sell) + "," + medID + ");";
                        dbClass.databaseoperations(q2);
                    }
                    else
                    {
                        string query = "insert into Medicines(medicine_name, company_name,medicine_type) values ('"
                        + medicineName + "', '" + cmpName + "', '" + type + "');";
                        dbClass.databaseoperations(query);

                        DataSet dataSet = new DataSet();
                        dataSet = dbClass.Getdata(medicineDetails);

                        int medID = Convert.ToInt32(dataSet.Tables[0].Rows[0]["medicine_id"].ToString());
                        string q2 = "insert into Medicine_Details(medicine_stock, expiry_date, purchase_price, sell_price, medicine_id) values(" +
                            int.Parse(stock) + ", '" + date + "', " + int.Parse(purchase) + ", " + int.Parse(sell) + ", " + medID + ");";
                        dbClass.databaseoperations(q2);
                    }                    
                    
                    MessageBox.Show("Record Inserted Successfully");
                    ClearText();
                    Medicine medicine = new Medicine();
                    medicine.ShowControl(new ShowMedicine());
                }


            }

        }


        private void LabelVisisble(bool name = false, bool cmp = false, bool stock = false, bool purchase=false, bool sell =false)
        {
            lblName.Visible = name;
            lblCmp.Visible = cmp;
            lblStock.Visible = stock;
            lblPurchase.Visible = purchase;
            lblSell.Visible = sell;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            txtName.Text = "";
            txtCmp.Text = "";
            txtStock.Text = "";
            comboType.SelectedItem = "Strips";
            txtPurchase.Text = "";
            txtSell.Text = "";
            dateTimePicker1.Text = DateTime.Today.ToString();
        }       

        private void label6_Click(object sender, EventArgs e)        {        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)        {        }

        private void label8_Click(object sender, EventArgs e)        {}
    }
}
