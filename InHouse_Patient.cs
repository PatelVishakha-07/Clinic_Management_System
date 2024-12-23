using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class InHouse_Patient : UserControl
    {
        databaseclass dbclass = new databaseclass();
        string changingname = "";
        int patientId;

        // Dictionary to store patient data temporarily
        Dictionary<string, PatientData> patientDataDict = new Dictionary<string, PatientData>();

        public InHouse_Patient()
        {
            InitializeComponent();
        }

        private void InHouse_Patient_Load(object sender, EventArgs e)
        {
            name.TextChanged += name_TextChanged;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name.Text))
            {
                if (!listBox1.Visible)
                    listBox1.Visible = true;

                changingname = name.Text;

                string query = "SELECT patient_id, name, contact_no, age, address, gender FROM Patients WHERE name ILIKE @value";
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
                try
                {
                    conn.Open();

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@value", "%" + changingname + "%");
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Clear previous data
                    listBox1.Items.Clear();
                    patientDataDict.Clear();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            // Format details to display in ListBox
                            string patientDisplay = $"{row["name"]}, Age: {row["age"]}, Contact: {row["contact_no"]}, Gender: {row["gender"]}, Address: {row["address"]}";

                            listBox1.Items.Add(patientDisplay);

                            // Store patient data in a dictionary using patient_id as key
                            patientDataDict[patientDisplay] = new PatientData
                            {
                                patient_id = int.Parse(row["patient_id"].ToString()),
                                ContactNo = row["contact_no"].ToString(),
                                Age = row["age"].ToString(),
                                Address = row["address"].ToString(),
                                Gender = row["gender"].ToString()
                            };
                        }
                    }
                    else
                    {
                        listBox1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedDisplay = listBox1.SelectedItem.ToString();

                if (patientDataDict.ContainsKey(selectedDisplay))
                {
                    var patientDetails = patientDataDict[selectedDisplay];

                    // Populate TextBoxes with selected patient's details
                    name.Text = selectedDisplay.Split(',')[0]; // Extract the name
                    txtContact.Text = patientDetails.ContactNo;
                    txtAge.Text = patientDetails.Age;
                    txtAddress.Text = patientDetails.Address;
                    txtGender.Text = patientDetails.Gender;
                    patientId = patientDetails.patient_id;
                }
            }
            listBox1.Visible=false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();
            txtBed.Text = string.Empty;
            listBox1.Items.Clear();
            listBox1.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            string date=DateTime.Now.ToString();
            string query = $"insert into ipd_table(bed_number,admit_date,patient_id) values({txtBed.Text},'{date}',{patientId})";
            dbclass.databaseoperations(query);
            string getquery = $"select ipd_id from ipd_table where patient_id={patientId} and admit_date='{date}'";
            DataSet ds = dbclass.Getdata(getquery);
            //Diagnosis diagnosis = new Diagnosis(int.Parse(ds.Tables[0].Rows[0]["ipd_id"].ToString()));
            ////Diagnosis.GetPrescriptionDetails(int.Parse(ds.Tables[0].Rows[0]["prescription_id"].ToString()), int.Parse(txtmedqty.Text), int.Parse(txtCharges.Text));
            //Patients patients = this.FindForm() as Patients;
            //patients.ShowContent(diagnosis);

            Diagnosis diagnosis= new Diagnosis(int.Parse(ds.Tables[0].Rows[0]["ipd_id"].ToString()));
          //  patientDetails.getPatientDetails(patientId);
            AdmittedPatients patients = new AdmittedPatients();
            patients = this.FindForm() as AdmittedPatients;
            patients.ShowContent(diagnosis);
        }
    }

    // Class to hold patient data
    public class PatientData
    {
        public int patient_id { get; set; }
        public string ContactNo { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
