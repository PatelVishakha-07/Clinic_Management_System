using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management_System
{
    public partial class AddPrescription : UserControl
    {
        int patient_id;
        databaseclass dbclass = new databaseclass();
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }

        public void getPatientDetails(int patient_id, string name, string address, int age, string contact, string gender)
        {
            this.patient_id = patient_id;
            txtName.Text = name;
            txtaddress.Text = address;
            txtAge.Text = age.ToString();
            txtContact.Text = contact;
            txtGender.Text = gender.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisease.Text) || string.IsNullOrEmpty(txtPres.Text) || string.IsNullOrEmpty(txtmedqty.Text) || string.IsNullOrEmpty(txtCharges.Text))
            {
                lbldisease.Visible = true;
            }
            else
            {
                lbldisease.Visible = false;
                DateTime date = System.DateTime.Now;
                string dateFormatted = date.ToString("yyyy-MM-dd HH:mm:ss").Replace("'", "''");
                string query = $"insert into Prescription(prescription_date,disease,prescription,patient_id,charges) values('{dateFormatted}','{txtDisease.Text}','{txtPres.Text}',{patient_id},{int.Parse(txtCharges.Text)})";
                dbclass.Getdata(query);
                string data = $"select * from Prescription where patient_id={patient_id} and prescription_date='{dateFormatted}'";
                DataSet ds = dbclass.Getdata(data);
                Prescriped_medicine prescriped_Medicine = new Prescriped_medicine("Prescription");
                prescriped_Medicine.GetPrescriptionDetails(int.Parse(ds.Tables[0].Rows[0]["prescription_id"].ToString()), int.Parse(txtmedqty.Text),int.Parse(txtCharges.Text));
                Patients patients = this.FindForm() as Patients;
                patients.ShowContent(prescriped_Medicine);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPres.Text = string.Empty;
            txtDisease.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCharges_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
