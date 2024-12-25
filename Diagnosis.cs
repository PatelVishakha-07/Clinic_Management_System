using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Diagnosis : UserControl
    {
        int ipd_id;
        public static DateTime date = DateTime.Now;
        string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
        databaseclass dbclass = new databaseclass();
        public Diagnosis(int ipd_id)
        {
            InitializeComponent();
            this.ipd_id = ipd_id;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttreat.Text) && !string.IsNullOrEmpty(txtdiag.Text) )
            { 
                string query = $"insert into ipd_treatment_table(diagnosis,treatment,treatment_date,ipd_id) values ('{txtdiag.Text}','{txttreat.Text}','{formattedDate}',{ipd_id}) ";
                
                dbclass.databaseoperations(query);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdiag.Text = string.Empty;
            txtdiag.Text = string.Empty; 
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"insert into ipd_treatment_table(diagnosis,treatment,treatment_date,ipd_id) values ('{txtdiag.Text}','{txttreat.Text}','{formattedDate}',{ipd_id}) ";
            dbclass.databaseoperations(query);
            int medicine_qty = int.Parse(txtmedqty.Text);
            string patientID_query = $"select patient_id from ipd_table where ipd_id={ipd_id}";
            DataSet ds=dbclass.Getdata(patientID_query);
            string treatmentId_query = $"select treatment_id from ipd_treatment_table where ipd_id={ipd_id} and treatment_date='{formattedDate}'";
            DataSet ds1=dbclass.Getdata(treatmentId_query);
            if (ds != null && ds1 != null)
            {
                int treatement_id = int.Parse(ds1.Tables[0].Rows[0]["treatment_id"].ToString());
                int patient_id= int.Parse(ds.Tables[0].Rows[0]["patient_id"].ToString()) ;
                Prescriped_medicine prescriped = new Prescriped_medicine("Diagnosis");
                prescriped.GetPrescriptionDetails(treatement_id,  medicine_qty,0,patient_id);
                AdmittedPatients patients = this.FindForm() as AdmittedPatients;
                patients.ShowContent(prescriped);
            }
        }
    }
}
