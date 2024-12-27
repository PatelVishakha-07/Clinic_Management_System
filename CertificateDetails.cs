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
    public partial class CertificateDetails : UserControl
    {
        databaseclass dbClass =new databaseclass();
        public CertificateDetails()
        {
            InitializeComponent();
        }

        private void CertificateDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string disease=txtDisease.Text;
            string date1=dateTimePicker1.Text;
            string date2=dateTimePicker2.Text;
            string date4=dateTimePicker4.Text;
            string date5=dateTimePicker5.Text;
            string date6=dateTimePicker6.Text;

            DateTime fromdate1 = DateTime.Parse(dateTimePicker1.Text);
            string formattedDate1 = fromdate1.ToString("yyyy-MM-dd");

            DateTime fromdate2 = DateTime.Parse(dateTimePicker2.Text);
            string formattedDate2 = fromdate2.ToString("yyyy-MM-dd");
            
            DateTime fromdate4 = DateTime.Parse(dateTimePicker4.Text);
            string formattedDate4 = fromdate4.ToString("yyyy-MM-dd");

            DateTime fromdate5 = DateTime.Parse(dateTimePicker5.Text);
            string formattedDate5 = fromdate5.ToString("yyyy-MM-dd");

            DateTime fromdate6 = DateTime.Parse(dateTimePicker6.Text);
            string formattedDate6 = fromdate6.ToString("yyyy-MM-dd");

            string query = "insert into certificate_table(name, disease, from_date, to_date, rest_from_date, " +
                $"rest_to_date, resume_date) values ('{name}', '{disease}', '{formattedDate1}', '{formattedDate2}', " +
                $"'{formattedDate4}', '{formattedDate5}', '{formattedDate6}');";
            dbClass.databaseoperations(query);
            CertificateOutput certificateOutput = new CertificateOutput(name,disease,formattedDate1,formattedDate2,formattedDate4,formattedDate5,formattedDate6);
            certificateOutput.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text= string.Empty;
            txtDisease.Text= string.Empty;
            dateTimePicker1.Text=DateTime.Now.ToString();
            dateTimePicker2.Text= DateTime.Now.ToString();
            dateTimePicker4.Text= DateTime.Now.ToString();
            dateTimePicker5.Text= DateTime.Now.ToString();
            dateTimePicker6.Text= DateTime.Now.ToString();
        }
    }
}
