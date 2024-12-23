using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Income : Form
    {
        databaseclass dbClass = new databaseclass();
        DataSet ds;
        int totalProfit, totalCharge;        
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);
            comboBox1.SelectedItem = "Daily Income";

            TodayIncome();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TodayIncome()
        {
            string q1 = "select profit_date, amount from profit where DATE(profit_date) = CURRENT_DATE";
            ds = new DataSet();
            ds = dbClass.Getdata(q1);
            string q2 = "select total_charge from prescription WHERE DATE(prescription_date) = CURRENT_DATE";
            DataSet ds1 = new DataSet();
            ds1 = dbClass.Getdata(q2);

            string profitQuery = "select sum(amount) AS total_profit from profit  WHERE DATE(profit_date) = CURRENT_DATE";
            DataSet profitSet = dbClass.Getdata(profitQuery);
            if (profitSet != null && profitSet.Tables.Count > 0)
            {
                totalProfit = Convert.ToInt32(profitSet.Tables[0].Rows[0]["total_profit"].ToString());
                lblProfit.Text = "Today's Total Profit: " + totalProfit.ToString("C");
            }

            string chargeQuery = "select sum(total_charge) AS charge from prescription  WHERE DATE(prescription_date) = CURRENT_DATE";
            DataSet chargeSet = dbClass.Getdata(chargeQuery);
            if (chargeSet != null && chargeSet.Tables.Count > 0)
            {
                totalCharge = Convert.ToInt32(chargeSet.Tables[0].Rows[0]["charge"].ToString());
                lblCharge.Text = "Today's Total Charge: " + totalCharge.ToString("C");
            }

            populateGridView(ds, ds1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            //string formattedDate = date.ToString("yyyy-MM-dd");

            if (comboBox1.SelectedItem.ToString() == "Daily Income")
            {
                TodayIncome();

            }
            else if(comboBox1.SelectedItem.ToString() == "Monthly Income")
            {
                string q1 = "SELECT profit_date, amount FROM profit WHERE EXTRACT(MONTH FROM profit_date) = EXTRACT(MONTH FROM CURRENT_DATE) " +
                    "and EXTRACT(YEAR FROM profit_date) = EXTRACT(YEAR FROM CURRENT_DATE);";
                ds = new DataSet();
                ds = dbClass.Getdata(q1);
                string q2 = "select total_charge from prescription WHERE EXTRACT(MONTH FROM prescription_date) = EXTRACT(MONTH FROM CURRENT_DATE) AND " +
                    "EXTRACT(YEAR FROM prescription_date) = EXTRACT(YEAR FROM CURRENT_DATE);";    
                DataSet ds1 = new DataSet();
                ds1 = dbClass.Getdata(q2);

                string totalProfitQuery = "SELECT SUM(amount) AS total_profit FROM profit WHERE EXTRACT(MONTH FROM profit_date) = EXTRACT(MONTH FROM CURRENT_DATE) " +
                                  "AND EXTRACT(YEAR FROM profit_date) = EXTRACT(YEAR FROM CURRENT_DATE)";
                DataSet totalProfitDS = dbClass.Getdata(totalProfitQuery);
                if (totalProfitDS != null && totalProfitDS.Tables.Count > 0)
                {
                    totalProfit = Convert.ToInt32(totalProfitDS.Tables[0].Rows[0]["total_profit"].ToString());
                    lblProfit.Text = "This Month's Total Profit: " + totalProfit.ToString("C");
                }

                string chargeQuery = "select sum(total_charge) AS charge from prescription  WHERE EXTRACT(MONTH FROM prescription_date) = EXTRACT(MONTH FROM CURRENT_DATE) " +
                    "AND EXTRACT(YEAR FROM prescription_date) = EXTRACT(YEAR FROM CURRENT_DATE)";
                DataSet chargeSet = dbClass.Getdata(chargeQuery);
                if (chargeSet != null && chargeSet.Tables.Count > 0)
                {
                    totalCharge = Convert.ToInt32(chargeSet.Tables[0].Rows[0]["charge"].ToString());
                    lblCharge.Text = "This Month's Total Charge: " + totalCharge.ToString("C");
                }

                populateGridView(ds, ds1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Yearly Income")
            {
                string q1 = "SELECT profit_date, amount FROM profit WHERE EXTRACT(YEAR FROM profit_date) = EXTRACT(YEAR FROM CURRENT_DATE);";
                ds = new DataSet();
                ds = dbClass.Getdata(q1);
                string q2 = "select total_charge from prescription WHERE EXTRACT(YEAR FROM prescription_date) = EXTRACT(YEAR FROM CURRENT_DATE);";
                DataSet ds1 = new DataSet();
                ds1 = dbClass.Getdata(q2);

                string totalProfitQuery = "SELECT SUM(amount) AS total_profit FROM profit WHERE EXTRACT(YEAR FROM profit_date) = EXTRACT(YEAR FROM CURRENT_DATE)";
                DataSet totalProfitDS = dbClass.Getdata(totalProfitQuery);
                if (totalProfitDS != null && totalProfitDS.Tables.Count > 0)
                {
                    totalProfit = Convert.ToInt32(totalProfitDS.Tables[0].Rows[0]["total_profit"].ToString());
                    lblProfit.Text = "This Year's Total Profit: " + totalProfit.ToString("C");
                }

                string chargeQuery = "select sum(total_charge) AS charge from prescription  WHERE EXTRACT(YEAR FROM prescription_date) = EXTRACT(YEAR FROM CURRENT_DATE)";
                DataSet chargeSet = dbClass.Getdata(chargeQuery);
                if (chargeSet != null && chargeSet.Tables.Count > 0)
                {
                    totalCharge = Convert.ToInt32(chargeSet.Tables[0].Rows[0]["charge"].ToString());
                    lblCharge.Text = "This Year's Total Charge: " + totalCharge.ToString("C");
                }

                populateGridView(ds, ds1);
            }
                
        }

        private void populateGridView(DataSet ds, DataSet ds1)
        {
            
                if (ds != null && ds.Tables.Count > 0 && ds1 != null && ds1.Tables.Count > 0)
                {
                    DataTable profitTable = ds.Tables[0];
                    DataTable prescriptionTable = ds1.Tables[0];
                    DataTable combinedTable=new DataTable();
                    combinedTable.Columns.Add("profit_date", typeof(string));
                    combinedTable.Columns.Add("amount", typeof(int));
                    combinedTable.Columns.Add("total_charge", typeof(int));

                    int rowCount = Math.Max(profitTable.Rows.Count, prescriptionTable.Rows.Count);
                    for (int i = 0; i < rowCount; i++)
                    {
                        DataRow combinedRow = combinedTable.NewRow();

                        // Add data from profitTable (if available)
                        if (i < profitTable.Rows.Count)
                        {
                            combinedRow["profit_date"] = profitTable.Rows[i]["profit_date"];
                            combinedRow["amount"] = profitTable.Rows[i]["amount"];
                        }

                        // Add data from prescriptionTable (if available)
                        if (i < prescriptionTable.Rows.Count)
                        {
                            combinedRow["total_charge"] = prescriptionTable.Rows[i]["total_charge"];
                        }

                        combinedTable.Rows.Add(combinedRow);
                    }

                    // Bind the combined table to DataGridView
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = combinedTable;

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns["profit_date"].DataPropertyName = "profit_date";
                    dataGridView1.Columns["amount"].DataPropertyName = "amount";
                    dataGridView1.Columns["total_charge"].DataPropertyName = "total_charge";
                    dataGridView1.DataSource = combinedTable;
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            
        }
    }
}
