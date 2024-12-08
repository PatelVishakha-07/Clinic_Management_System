using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Prescriped_medicine : UserControl
    {
        int prescription_id;
        string changing_med;
        databaseclass dbclass = new databaseclass();
        public Prescriped_medicine()
        {
            InitializeComponent();
            changing_med = "";
            txtName.TextChanged += txtName_TextChanged;
        }

        public void getprescriptiondetails(int prescription_id)
        {
            this.prescription_id = prescription_id;
        }

        private void btnaddmore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                string medicine_name = $"select medicine_name from Medicines where medicine_name='{txtName.Text}'";
                DataSet ds = dbclass.Getdata(medicine_name);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string query = $"insert into Prescribed_Medicine(medicine_name, quantity, prescription_id) values('{txtName.Text}', '{txtqty.Text}', {prescription_id})";
                    dbclass.databaseoperations(query);

                    string queryqty = $"update Medicines set medicine_stock = medicine_stock - {int.Parse(txtqty.Text)} where medicine_name = '{txtName.Text}'";
                    dbclass.databaseoperations(queryqty);

                    txtqty.Text = "";
                    txtName.Text = "";
                    lblwrong.Visible = false;
                }
                else
                {
                    lblwrong.Visible = true;
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (!listBox1.Visible)
                {
                    listBox1.Visible = true;
                }

                changing_med = txtName.Text;
                string query = "select medicine_name from Medicines where medicine_name like @value";

                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;"))
                {
                    conn.Open();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@value", "%" + changing_med + "%");
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    listBox1.Items.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            listBox1.Items.Add(row["medicine_name"]);
                        }
                    }
                    else
                    {
                        listBox1.Visible = false;
                    }
                }
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                lblwrong.Visible = false;
                string medicine_name = $"select medicine_name, medicine_stock from Medicines where medicine_name='{txtName.Text}'";
                DataSet ds = dbclass.Getdata(medicine_name);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    lblqty.Visible = false;
                    int availableQty = int.Parse(ds.Tables[0].Rows[0]["medicine_stock"].ToString());

                    if (availableQty >= int.Parse(txtqty.Text))
                    {
                        string query = $"insert into Prescribed_Medicine(medicine_name, quantity, prescription_id) values('{txtName.Text}', '{txtqty.Text}', {prescription_id})";
                        dbclass.databaseoperations(query);

                        string queryqty = $"update Medicines set medicine_stock = medicine_stock - {int.Parse(txtqty.Text)} where medicine_name = '{txtName.Text}'";
                        dbclass.databaseoperations(queryqty);

                        AddPatients addpatients = new AddPatients();
                        Patients patients = this.FindForm() as Patients;
                        patients?.ShowContent(addpatients);
                    }
                    else
                    {
                        lblqty.Visible = true;
                    }
                }
                else
                {
                    lblwrong.Visible = true;
                }
            }
            else
            {
                lblwrong.Visible = true;
            }
        }
    }
}
