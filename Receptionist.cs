using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Management_System
{
    public partial class Receptionist : Form
    {
        private System.Windows.Forms.Timer timer;
        private DateTime lastCheckedTime;
        public Receptionist()
        {
            InitializeComponent();
            InitializeDataGridView();
            lastCheckedTime = DateTime.MinValue;

            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = 5000; // Poll every 5 seconds
            //timer.Tick += Timer_Tick;
            //timer.Start();
        }

        private void InitializeDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("name", "Patient Name");
            dataGridView1.Columns.Add("prescription", "Prescription");
            dataGridView1.Columns.Add("medicine_name", "Medicine Name");            
            dataGridView1.Columns.Add("quantity", "Quantity");
            dataGridView1.Columns.Add("usage", "Dosage");

            // Set properties (optional, e.g., auto-sizing columns)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Receptionist_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT pt.name, p.prescription, pm.medicine_name, pm.quantity, pm.usage FROM patients pt join prescription p" +
                        " on pt.patient_id=p.patient_id join prescribed_medicine pm on p.prescription_id=pm.pres_med_id WHERE " +
                        "prescription_date > @lastCheckedTime ORDER BY prescription_date ASC";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("lastCheckedTime", lastCheckedTime);
                        using (var reader = cmd.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                // Add the data to the DataGridView
                                string patientName = reader.GetString(0);
                                string prescription = reader.GetString(1);
                                string medicine = reader.GetString(2);
                                string quantity = reader.GetInt32(3).ToString();
                                string usage = reader.GetString(4);
                                //DateTime createdAt = reader.GetDateTime(4);

                                // Update DataGridView (you can customize this)
                                dataGridView1.Rows.Add(patientName, prescription, medicine, quantity, usage);
                            }
                        }
                        //lastCheckedTime = DateTime.Now;
                    }
                    if (lastCheckedTime < DateTime.Now)
                    {
                        lastCheckedTime = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNewPrescriptions();
        }

        private void LoadNewPrescriptions()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT pt.name, p.prescription, pm.medicine_name, pm.quantity, pm.usage FROM patients pt join prescription p" +
                        " on pt.patient_id=p.patient_id join prescribed_medicine pm on p.prescription_id=pm.pres_med_id WHERE " +
                        "prescription_date > @lastCheckedTime ORDER BY prescription_date ASC";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("lastCheckedTime", lastCheckedTime);
                        using (var reader = cmd.ExecuteReader())
                        {
                            bool hasNewData = false;
                            //dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                hasNewData = true;
                                // Add the data to the DataGridView
                                string patientName = reader.GetString(0);
                                string prescription = reader.GetString(1);
                                string medicine = reader.GetString(2);
                                string quantity = reader.GetInt32(3).ToString();
                                string usage = reader.GetString(4);
                                //DateTime createdAt = reader.GetDateTime(4);

                                // Update DataGridView (you can customize this)
                                dataGridView1.Rows.Add(patientName, prescription, medicine, quantity, usage);
                            }
                            if (hasNewData)
                            {
                                lastCheckedTime = DateTime.Now;
                            }
                            else
                            {
                                MessageBox.Show("No new prescriptions added.");
                            }
                        }
                        //lastCheckedTime = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}
